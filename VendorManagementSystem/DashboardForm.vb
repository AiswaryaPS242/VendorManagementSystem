Public Class DashboardForm
    Private Sub btnVendors_Click(sender As Object, e As EventArgs) Handles btnVendors.Click
        Dim vendorForm As New Form1()
        vendorForm.Show()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        MessageBox.Show("Customer management not implemented yet.")
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        MessageBox.Show("Product management not implemented yet.")
    End Sub
End Class
