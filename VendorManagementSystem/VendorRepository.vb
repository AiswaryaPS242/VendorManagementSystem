Imports System.Data
Imports System.Data.SqlClient

Public Class VendorRepository
    Private ReadOnly connectionString As String = "Server=AISHULAP\SQLEXPRESS;Database=VendorDB;Integrated Security=True;"

    ' Get the next available Vendor ID
    Public Function GetNextID() As Integer
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT ISNULL(MAX(ID), 0) + 1 FROM Setup.Vendor", cnn)
            cnn.Open()
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function

    ' Get all vendors (for DataGridView)
    Public Function GetAllVendors() As DataTable
        Dim dt As New DataTable()
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT * FROM Setup.Vendor", cnn)
            cnn.Open()
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function

    ' Add a new vendor
    Public Sub AddVendor(vendor As Vendor)
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(
                "INSERT INTO Setup.Vendor (ID, VendorName, Address, Email, PhoneNumber) " &
                "VALUES (@ID, @VendorName, @Address, @Email, @PhoneNumber)", cnn)

            cmd.Parameters.AddWithValue("@ID", vendor.ID)
            cmd.Parameters.AddWithValue("@VendorName", vendor.VendorName)
            cmd.Parameters.AddWithValue("@Address", If(String.IsNullOrEmpty(vendor.Address), DBNull.Value, vendor.Address))
            cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrEmpty(vendor.Email), DBNull.Value, vendor.Email))
            cmd.Parameters.AddWithValue("@PhoneNumber", If(String.IsNullOrEmpty(vendor.PhoneNumber), DBNull.Value, vendor.PhoneNumber))

            cnn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Update an existing vendor
    Public Sub UpdateVendor(vendor As Vendor)
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(
                "UPDATE Setup.Vendor SET VendorName = @VendorName, Address = @Address, " &
                "Email = @Email, PhoneNumber = @PhoneNumber WHERE ID = @ID", cnn)

            cmd.Parameters.AddWithValue("@ID", vendor.ID)
            cmd.Parameters.AddWithValue("@VendorName", vendor.VendorName)
            cmd.Parameters.AddWithValue("@Address", If(String.IsNullOrEmpty(vendor.Address), DBNull.Value, vendor.Address))
            cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrEmpty(vendor.Email), DBNull.Value, vendor.Email))
            cmd.Parameters.AddWithValue("@PhoneNumber", If(String.IsNullOrEmpty(vendor.PhoneNumber), DBNull.Value, vendor.PhoneNumber))

            cnn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Delete a vendor
    Public Sub DeleteVendor(id As Integer)
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("DELETE FROM Setup.Vendor WHERE ID = @ID", cnn)
            cmd.Parameters.AddWithValue("@ID", id)
            cnn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class

' Vendor model class
Public Class Vendor
    Public Property ID As Integer
    Public Property VendorName As String
    Public Property Address As String
    Public Property Email As String
    Public Property PhoneNumber As String
End Class