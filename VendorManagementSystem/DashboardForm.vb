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


End Class
