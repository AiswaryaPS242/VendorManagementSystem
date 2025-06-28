' In PurchaseRepository.vb
Imports System.Data.SqlClient
Imports System.Data

Public Class PurchaseRepository
    Private ReadOnly connectionString As String = "Server=AISHULAP\SQLEXPRESS;Database=VendorDB;Integrated Security=True;"

    ' Get all purchases (for future use, not needed for this control)
    Public Function GetAll() As DataTable
        Dim dt As New DataTable()
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT * FROM Setup.Purchase", cnn)
            cnn.Open()
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function

    Public Sub Update(purchase As Purchase)
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("UPDATE Setup.Purchase SET VendorName=@Vendor, Item=@Item, Quantity=@Qty, PurchaseAmount=@Amount, WarehouseLocation=@Warehouse, PurchaseDate=@Date WHERE ID=@ID", con)
            cmd.Parameters.AddWithValue("@Vendor", purchase.VendorName)
            cmd.Parameters.AddWithValue("@Item", purchase.Item)
            cmd.Parameters.AddWithValue("@Qty", purchase.Quantity)
            cmd.Parameters.AddWithValue("@Amount", purchase.PurchaseAmount)
            cmd.Parameters.AddWithValue("@Warehouse", purchase.WarehouseLocation)
            cmd.Parameters.AddWithValue("@Date", purchase.PurchaseDate)
            cmd.Parameters.AddWithValue("@ID", purchase.ID)
            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Delete(id As Integer)
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("DELETE FROM Setup.Purchase WHERE ID=@ID", con)
            cmd.Parameters.AddWithValue("@ID", id)
            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub


    ' Optional: Add method to insert purchase entries
    Public Sub Add(purchase As Purchase)
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("INSERT INTO Setup.Purchase (VendorName, Item, Quantity, PurchaseAmount, PurchaseDate, WarehouseLocation) VALUES (@Vendor, @Item, @Qty, @Amount, @Date, @Warehouse)", cnn)
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
