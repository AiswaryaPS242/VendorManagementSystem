Imports System.Data.SqlClient

Public Class StockTransferRepository
    Private ReadOnly connectionString As String = "Server=AISHULAP\SQLEXPRESS;Database=VendorDB;Integrated Security=True;"

    Public Function GetAvailableStock(vendor As String, item As String, location As String) As Integer
        Dim stock As Integer = 0
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT SUM(Quantity) FROM Setup.Purchase WHERE VendorName = @Vendor AND Item = @Item AND WarehouseLocation = @Location", conn)
            cmd.Parameters.AddWithValue("@Vendor", vendor)
            cmd.Parameters.AddWithValue("@Item", item)
            cmd.Parameters.AddWithValue("@Location", location)
            conn.Open()
            Dim result = cmd.ExecuteScalar()
            If result IsNot DBNull.Value Then
                stock = Convert.ToInt32(result)
            End If
        End Using
        Return stock
    End Function

    Public Sub TransferStock(transfer As StockTransfer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim transaction = conn.BeginTransaction()

            Try
                ' Deduct stock from source
                Dim deductCmd As New SqlCommand("UPDATE Setup.Purchase SET Quantity = Quantity - @Qty WHERE VendorName = @Vendor AND Item = @Item AND WarehouseLocation = @FromLocation", conn, transaction)
                deductCmd.Parameters.AddWithValue("@Qty", transfer.Quantity)
                deductCmd.Parameters.AddWithValue("@Vendor", transfer.VendorName)
                deductCmd.Parameters.AddWithValue("@Item", transfer.Item)
                deductCmd.Parameters.AddWithValue("@FromLocation", transfer.FromLocation)
                deductCmd.ExecuteNonQuery()

                ' Try to update destination, else insert
                Dim updateCmd As New SqlCommand("UPDATE Setup.Purchase SET Quantity = Quantity + @Qty WHERE VendorName = @Vendor AND Item = @Item AND WarehouseLocation = @ToLocation", conn, transaction)
                updateCmd.Parameters.AddWithValue("@Qty", transfer.Quantity)
                updateCmd.Parameters.AddWithValue("@Vendor", transfer.VendorName)
                updateCmd.Parameters.AddWithValue("@Item", transfer.Item)
                updateCmd.Parameters.AddWithValue("@ToLocation", transfer.ToLocation)
                Dim rowsAffected = updateCmd.ExecuteNonQuery()

                If rowsAffected = 0 Then
                    ' Insert new record if destination doesn't exist
                    Dim insertCmd As New SqlCommand("INSERT INTO Setup.Purchase (VendorName, Item, Quantity, WarehouseLocation, PurchaseDate, PurchaseAmount) VALUES (@Vendor, @Item, @Qty, @ToLocation, GETDATE(), 0)", conn, transaction)
                    insertCmd.Parameters.AddWithValue("@Vendor", transfer.VendorName)
                    insertCmd.Parameters.AddWithValue("@Item", transfer.Item)
                    insertCmd.Parameters.AddWithValue("@Qty", transfer.Quantity)
                    insertCmd.Parameters.AddWithValue("@ToLocation", transfer.ToLocation)
                    insertCmd.ExecuteNonQuery()
                End If

                ' Log the transfer
                Dim logCmd As New SqlCommand("INSERT INTO Inventory.StockTransfer (VendorName, Item, Quantity, FromLocation, ToLocation, TransferDate) VALUES (@Vendor, @Item, @Qty, @FromLocation, @ToLocation, GETDATE())", conn, transaction)
                logCmd.Parameters.AddWithValue("@Vendor", transfer.VendorName)
                logCmd.Parameters.AddWithValue("@Item", transfer.Item)
                logCmd.Parameters.AddWithValue("@Qty", transfer.Quantity)
                logCmd.Parameters.AddWithValue("@FromLocation", transfer.FromLocation)
                logCmd.Parameters.AddWithValue("@ToLocation", transfer.ToLocation)
                logCmd.ExecuteNonQuery()

                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                Throw
            End Try
        End Using
    End Sub
    Public Function GetDistinctValues() As DataSet
        Dim ds As New DataSet()
        Using cnn As New SqlConnection(connectionString)
            cnn.Open()

            ' Vendors
            Dim da1 As New SqlDataAdapter("SELECT DISTINCT VendorName FROM Setup.Purchase", cnn)
            da1.Fill(ds, "Vendors")

            ' Items
            Dim da2 As New SqlDataAdapter("SELECT DISTINCT Item FROM Setup.Purchase", cnn)
            da2.Fill(ds, "Items")

            ' Warehouses
            Dim da3 As New SqlDataAdapter("SELECT DISTINCT WarehouseLocation FROM Setup.Purchase", cnn)
            da3.Fill(ds, "Warehouses")
        End Using
        Return ds
    End Function

End Class
