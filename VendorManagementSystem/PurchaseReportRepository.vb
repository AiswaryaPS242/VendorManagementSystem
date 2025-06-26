Imports System.Data.SqlClient
Imports System.Data

Public Class PurchaseReportRepository
    Private ReadOnly connectionString As String = "Server=AISHULAP\SQLEXPRESS;Database=VendorDB;Integrated Security=True;"

    Public Function GetAll() As DataTable
        Dim dt As New DataTable()
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT * FROM Setup.PurchaseReport ORDER BY DateOfPurchase DESC", cnn)
            cnn.Open()
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function

    Public Sub Add(report As PurchaseReport)
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("INSERT INTO Setup.PurchaseReport (TransactionID, TransactionType, Vendor, Amount, DateOfPurchase) VALUES (@ID, @Type, @Vendor, @Amount, @Date)", cnn)
            cmd.Parameters.AddWithValue("@ID", report.TransactionID)
            cmd.Parameters.AddWithValue("@Type", report.TransactionType)
            cmd.Parameters.AddWithValue("@Vendor", report.Vendor)
            cmd.Parameters.AddWithValue("@Amount", report.Amount)
            cmd.Parameters.AddWithValue("@Date", report.DateOfPurchase)
            cnn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Update(report As PurchaseReport)
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("UPDATE Setup.PurchaseReport SET Vendor = @Vendor, Amount = @Amount, DateOfPurchase = @Date WHERE TransactionID = @ID", cnn)
            cmd.Parameters.AddWithValue("@ID", report.TransactionID)
            cmd.Parameters.AddWithValue("@Vendor", report.Vendor)
            cmd.Parameters.AddWithValue("@Amount", report.Amount)
            cmd.Parameters.AddWithValue("@Date", report.DateOfPurchase)
            cnn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Delete(id As Integer)
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("DELETE FROM Setup.PurchaseReport WHERE TransactionID = @ID", cnn)
            cmd.Parameters.AddWithValue("@ID", id)
            cnn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function GetNextTransactionID() As Integer
        Using cnn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT ISNULL(MAX(TransactionID), 0) + 1 FROM Setup.PurchaseReport", cnn)
            cnn.Open()
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function
End Class
