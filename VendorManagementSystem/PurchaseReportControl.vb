Imports ClosedXML.Excel
Imports System.IO
Imports System.Data

Public Class PurchaseReportControl
    Private ReadOnly repo As New PurchaseReportRepository()
    Private allReports As DataTable

    Private Sub PurchaseReportControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReports()
    End Sub

    Private Sub LoadReports()
        allReports = repo.GetAll()
        dgvReport.DataSource = allReports
        UpdateTotal()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtTransactionID.Text = repo.GetNextTransactionID().ToString()
        txtVendor.Clear()
        txtAmount.Clear()
        dtpDate.Value = Date.Today
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtVendor.Text.Trim() = "" OrElse txtAmount.Text.Trim() = "" Then
            MessageBox.Show("Please enter all fields.")
            Return
        End If

        Dim amount As Decimal
        If Not Decimal.TryParse(txtAmount.Text, amount) Then
            MessageBox.Show("Amount must be a number.")
            Return
        End If

        Dim report As New PurchaseReport With {
            .TransactionID = CInt(txtTransactionID.Text),
            .TransactionType = "PI",
            .Vendor = txtVendor.Text,
            .Amount = amount,
            .DateOfPurchase = dtpDate.Value.Date
        }

        repo.Add(report)
        LoadReports()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvReport.SelectedRows.Count > 0 Then
            Dim report As New PurchaseReport With {
                .TransactionID = CInt(txtTransactionID.Text),
                .TransactionType = "PI",
                .Vendor = txtVendor.Text,
                .Amount = Decimal.Parse(txtAmount.Text),
                .DateOfPurchase = dtpDate.Value
            }

            repo.Update(report)
            LoadReports()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvReport.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgvReport.SelectedRows(0).Cells("TransactionID").Value)
            repo.Delete(id)
            LoadReports()
        End If
    End Sub

    Private Sub dgvReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReport.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvReport.Rows(e.RowIndex)
            txtTransactionID.Text = row.Cells("TransactionID").Value.ToString()
            txtVendor.Text = row.Cells("Vendor").Value.ToString()
            txtAmount.Text = row.Cells("Amount").Value.ToString()
            dtpDate.Value = Convert.ToDateTime(row.Cells("DateOfPurchase").Value)
        End If
    End Sub

    Private Sub UpdateTotal()
        Dim total As Decimal = 0
        If dgvReport.DataSource IsNot Nothing Then
            For Each row As DataGridViewRow In dgvReport.Rows
                If Not row.IsNewRow AndAlso row.Cells("Amount").Value IsNot Nothing Then
                    Dim value As Decimal
                    If Decimal.TryParse(row.Cells("Amount").Value.ToString(), value) Then
                        total += value
                    End If
                End If
            Next
        End If
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
                    For i As Integer = 0 To dgvReport.Columns.Count - 1
                        worksheet.Cell(1, i + 1).Value = dgvReport.Columns(i).HeaderText
                    Next

                    ' Add data
                    For r As Integer = 0 To dgvReport.Rows.Count - 1
                        For c As Integer = 0 To dgvReport.Columns.Count - 1
                            worksheet.Cell(r + 2, c + 1).Value = dgvReport.Rows(r).Cells(c).Value?.ToString()
                        Next
                    Next

                    workbook.SaveAs(sfd.FileName)
                    MessageBox.Show("Exported successfully.")
                Catch ex As Exception
                    MessageBox.Show("Export failed: " & ex.Message)
                End Try
            End If
        End Using
    End Sub


End Class
