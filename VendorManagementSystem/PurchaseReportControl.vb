Imports ClosedXML.Excel
Imports System.IO
Imports System.Data

Public Class PurchaseReportControl
    Private ReadOnly repo As New PurchaseRepository()
    Private allReports As DataTable

    Private Sub PurchaseReportControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReports()
    End Sub

    Private Sub LoadReports()
        allReports = repo.GetAll()
        dgvReport.DataSource = allReports
        UpdateTotal()
    End Sub

    Private Sub UpdateTotal()
        Dim total As Decimal = 0
        If dgvReport.DataSource IsNot Nothing Then
            For Each row As DataGridViewRow In dgvReport.Rows
                If Not row.IsNewRow AndAlso row.Cells("PurchaseAmount").Value IsNot Nothing Then
                    Dim value As Decimal
                    If Decimal.TryParse(row.Cells("PurchaseAmount").Value.ToString(), value) Then
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
