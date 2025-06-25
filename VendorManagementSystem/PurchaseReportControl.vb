Imports ClosedXML.Excel
Imports System.IO

Public Class PurchaseReportControl

    Private ReadOnly repo As New PurchaseReportRepository()

    ' Simulated purchase report data
    Private Sub PurchaseReportControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvReport.Columns.Clear()
        dgvReport.Columns.Add("TransactionType", "Transaction Type")
        dgvReport.Columns.Add("TransactionID", "Transaction ID")
        dgvReport.Columns.Add("Vendor", "Vendor")
        dgvReport.Columns.Add("Amount", "Net Amount")
        dgvReport.Columns.Add("Date", "Date")

        RefreshReportTable()
    End Sub
    Private Sub RefreshReportTable()
        dgvReport.Rows.Clear()
        For Each report In repo.GetAll()
            dgvReport.Rows.Add(
            report.TransactionType,
            report.TransactionID,
            report.Vendor,
            report.Amount.ToString("F2"),
            report.DateOfPurchase.ToShortDateString()
        )
        Next
        UpdateTotal()
    End Sub

    Private Sub btnAddReport_Click(sender As Object, e As EventArgs) Handles btnAddReport.Click
        ' Basic validation
        If String.IsNullOrWhiteSpace(txtVendor.Text) OrElse String.IsNullOrWhiteSpace(txtAmount.Text) Then
            MessageBox.Show("Vendor and Amount are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim amountValue As Decimal
        If Not Decimal.TryParse(txtAmount.Text, amountValue) Then
            MessageBox.Show("Amount must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim newReport As New PurchaseReport With {
        .TransactionType = "PI",
        .TransactionID = repo.GetNextTransactionID(),
        .Vendor = txtVendor.Text,
        .Amount = amountValue,
        .DateOfPurchase = dtpDate.Value.Date
    }

        repo.Add(newReport)
        RefreshReportTable()
        UpdateTotal()

        ' Optional: Clear fields
        txtVendor.Clear()
        txtAmount.Clear()
        dtpDate.Value = Date.Today
    End Sub

    Private Sub UpdateTotal()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgvReport.Rows
            If row.Cells("Amount").Value IsNot Nothing Then
                Dim value As Decimal
                If Decimal.TryParse(row.Cells("Amount").Value.ToString(), value) Then
                    total += value ' Only add once
                End If
            End If
        Next

        lblTotalAmount.Text = "Total: ₹" & total.ToString("N2")
    End Sub



    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook|*.xlsx"
            sfd.Title = "Save Purchase Report"
            sfd.FileName = "PurchaseReport.xlsx"

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Dim workbook = New XLWorkbook()
                    Dim worksheet = workbook.Worksheets.Add("Purchase Report")

                    ' Add headers
                    For col As Integer = 0 To dgvReport.Columns.Count - 1
                        worksheet.Cell(1, col + 1).Value = dgvReport.Columns(col).HeaderText
                    Next

                    ' Add data
                    For row As Integer = 0 To dgvReport.Rows.Count - 1
                        For col As Integer = 0 To dgvReport.Columns.Count - 1
                            Dim cellValue = dgvReport.Rows(row).Cells(col).Value
                            worksheet.Cell(row + 2, col + 1).Value = If(cellValue IsNot Nothing, cellValue.ToString(), "")
                        Next
                    Next


                    workbook.SaveAs(sfd.FileName)

                    MessageBox.Show("Report exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Failed to export: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

End Class
