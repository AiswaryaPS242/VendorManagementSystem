Imports System.Data.SqlClient

Public Class CustomerRepository
    Private ReadOnly connectionString As String = "Server=AISHULAP\SQLEXPRESS;Database=VendorDB;Integrated Security=True;"

    Public Function GetNextID() As Integer
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT ISNULL(MAX(ID), 0) + 1 FROM Setup.Customer", con)
            con.Open()
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function

    Public Function GetAllCustomers() As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT * FROM Setup.Customer", con)
            con.Open()
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function

    Public Sub AddCustomer(customer As Customer)
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("INSERT INTO Setup.Customer (ID, CustomerName, Phone, Email) VALUES (@ID, @Name, @Phone, @Email)", con)
            cmd.Parameters.AddWithValue("@ID", customer.ID)
            cmd.Parameters.AddWithValue("@Name", customer.Name)
            cmd.Parameters.AddWithValue("@Phone", If(String.IsNullOrEmpty(customer.Phone), DBNull.Value, customer.Phone))
            cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrEmpty(customer.Email), DBNull.Value, customer.Email))
            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub UpdateCustomer(customer As Customer)
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("UPDATE Setup.Customer SET CustomerName=@Name, Phone=@Phone, Email=@Email WHERE ID=@ID", con)
            cmd.Parameters.AddWithValue("@ID", customer.ID)
            cmd.Parameters.AddWithValue("@Name", customer.Name)
            cmd.Parameters.AddWithValue("@Phone", customer.Phone)
            cmd.Parameters.AddWithValue("@Email", customer.Email)
            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub DeleteCustomer(id As Integer)
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("DELETE FROM Setup.Customer WHERE ID = @ID", con)
            cmd.Parameters.AddWithValue("@ID", id)
            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class

Public Class Customer
    Public Property ID As Integer
    Public Property Name As String
    Public Property Phone As String
    Public Property Email As String
End Class
