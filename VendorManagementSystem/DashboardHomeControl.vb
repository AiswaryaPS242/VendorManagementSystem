Public Class DashboardHomeControl

    ' Repositories
    Private ReadOnly vendorRepo As New VendorRepository()
    Private ReadOnly customerRepo As New CustomerRepository()
    Private ReadOnly productRepo As New ProductRepository()
    Private ReadOnly purchaseRepo As New PurchaseRepository()

    Private Sub DashboardHomeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateSummary()
    End Sub

    Private Sub UpdateSummary()
        ' Vendors
        Dim vendors = vendorRepo.GetAllVendors()
        lblVendorCount.Text = vendors.Rows.Count.ToString()

        ' Customers
        Dim customers = customerRepo.GetAllCustomers()
        lblCustomerCount.Text = customers.Rows.Count.ToString()

        ' Products
        Dim products = productRepo.GetAllProducts()
        lblProductCount.Text = products.Rows.Count.ToString()

        ' Purchase Reports
        Dim purchases = purchaseRepo.GetAll()
        Dim totalAmount As Decimal = 0

        For Each row As DataRow In purchases.Rows
            If Not IsDBNull(row("PurchaseAmount")) Then
                totalAmount += Convert.ToDecimal(row("PurchaseAmount"))
            End If
        Next

        lblPurchaseTotal.Text = "₹ " & totalAmount.ToString("N2")
    End Sub


End Class
