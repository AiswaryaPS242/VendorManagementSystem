Imports System.Data.SqlClient


Public Class DashboardForm

    Private Sub LoadControl(control As UserControl)
        MainPanel.Controls.Clear()
        control.Dock = DockStyle.Fill
        MainPanel.Controls.Add(control)
    End Sub

    Private Sub btnVendor_Click(sender As Object, e As EventArgs) Handles btnVendors.Click
        Dim vendorControl As New VendorControl()
        LoadControl(vendorControl)
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Dim customerControl As New CustomerControl()
        LoadControl(customerControl)
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Dim productControl As New ProductControl()
        LoadControl(productControl)
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Backup files (*.bak)|*.bak"
            sfd.Title = "Save Backup File"
            sfd.FileName = "VendorSystemBackup.bak"

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    ' Update these details as per your SQL setup
                    Dim connectionString As String = "Data Source=AISHULAP\SQLEXPRESS;Initial Catalog=VendorDB;Integrated Security=True"
                    Dim backupCommand As String = $"BACKUP DATABASE [VendorDB] TO DISK = 'D:\backup\bu\IMS.bak '"

                    Using con As New SqlConnection(connectionString)
                        con.Open()
                        Using cmd As New SqlCommand(backupCommand, con)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Backup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Backup failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnPurchaseReport_Click(sender As Object, e As EventArgs) Handles btnPurchaseReport.Click
        LoadControl(New PurchaseReportControl())
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadControl(New DashboardHomeControl())
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Show LoginForm again
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close() ' Close DashboardForm
        End If
    End Sub

    Private Sub btnStockTransfer_Click(sender As Object, e As EventArgs) Handles btnStockTransfer.Click
        Dim control As New StockTransferControl()
        LoadControl(control)
    End Sub

    Private Sub btnPurchaseEntry_Click(sender As Object, e As EventArgs) Handles btnPurchaseEntry.Click
        Dim ctrl As New PurchaseEntryControl()
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(ctrl)
        ctrl.Dock = DockStyle.Fill
    End Sub

End Class
