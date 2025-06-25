Imports System.Data.SqlClient
Imports System.Data

Public Class ProductRepository
    Private ReadOnly connectionString As String = "Server=AISHULAP\SQLEXPRESS;Database=VendorDB;Integrated Security=True;"

    Public Function GetNextID() As Integer
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT ISNULL(MAX(ID), 0) + 1 FROM Setup.Product", con)
            con.Open()
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function

    Public Function GetAllProducts() As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT * FROM Setup.Product", con)
            con.Open()
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function

    Public Sub AddProduct(product As Product)
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(
                "INSERT INTO Setup.Product (ID, ProductName, Category, Price) " &
                "VALUES (@ID, @ProductName, @Category, @Price)", con)

            cmd.Parameters.AddWithValue("@ID", product.ID)
            cmd.Parameters.AddWithValue("@ProductName", product.Name)
            cmd.Parameters.AddWithValue("@Category", product.Category)
            cmd.Parameters.AddWithValue("@Price", product.Price)

            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub UpdateProduct(product As Product)
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(
                "UPDATE Setup.Product SET ProductName = @ProductName, Category = @Category, " &
                "Price = @Price WHERE ID = @ID", con)

            cmd.Parameters.AddWithValue("@ID", product.ID)
            cmd.Parameters.AddWithValue("@ProductName", product.Name)
            cmd.Parameters.AddWithValue("@Category", product.Category)
            cmd.Parameters.AddWithValue("@Price", product.Price)

            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub DeleteProduct(id As Integer)
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("DELETE FROM Setup.Product WHERE ID = @ID", con)
            cmd.Parameters.AddWithValue("@ID", id)

            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class

Public Class Product
    Public Property ID As Integer
    Public Property Name As String
    Public Property Category As String
    Public Property Price As Decimal
End Class
