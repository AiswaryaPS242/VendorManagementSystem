Imports System.Data.SqlClient
Imports System.Data

Public Class PurchaseEntryRepository
    Private ReadOnly connectionString As String = "Server=AISHULAP\SQLEXPRESS;Database=VendorDB;Integrated Security=True;"

    Public Function GetNextPurchaseID() As Integer
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT ISNULL(MAX(ID), 0) + 1 FROM Setup.Purchase", cnn)
            cnn.Open()
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function
    Public Function GetVendors() As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT DISTINCT VendorName FROM Setup.Vendor", con)
            con.Open()
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function

    Public Function GetProducts() As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT DISTINCT ProductName FROM Setup.Product", con)
            con.Open()
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function

    Public Sub AddPurchase(purchase As Purchase)
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("INSERT INTO Setup.Purchase (VendorName, Item, Quantity, PurchaseAmount, WarehouseLocation, PurchaseDate) VALUES (@Vendor, @Item, @Qty, @Amount, @Warehouse, @Date)", con)
            cmd.Parameters.AddWithValue("@Vendor", purchase.VendorName)
            cmd.Parameters.AddWithValue("@Item", purchase.Item)
            cmd.Parameters.AddWithValue("@Qty", purchase.Quantity)
            cmd.Parameters.AddWithValue("@Amount", purchase.PurchaseAmount)
            cmd.Parameters.AddWithValue("@Warehouse", purchase.WarehouseLocation)
            cmd.Parameters.AddWithValue("@Date", purchase.PurchaseDate)
            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Sub Add(purchase As Purchase)
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("INSERT INTO Setup.Purchase (VendorName, Item, Quantity, PurchaseAmount, PurchaseDate, WarehouseLocation) 
                                       VALUES (@Vendor, @Item, @Qty, @Amount, @Date, @Warehouse)", cnn)
            cmd.Parameters.AddWithValue("@Vendor", purchase.VendorName)
            cmd.Parameters.AddWithValue("@Item", purchase.Item)
            cmd.Parameters.AddWithValue("@Qty", purchase.Quantity)
            cmd.Parameters.AddWithValue("@Amount", purchase.PurchaseAmount)
            cmd.Parameters.AddWithValue("@Date", purchase.PurchaseDate)
            cmd.Parameters.AddWithValue("@Warehouse", purchase.WarehouseLocation)
            cnn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class
