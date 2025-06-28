Imports System.Data.SqlClient

Public Class StockTransferControl
    Private repo As New StockTransferRepository()
    Private Sub StockTransferControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxData()
    End Sub

    Private Sub LoadComboBoxData()
        Using cnn As New SqlConnection("Server=AISHULAP\SQLEXPRESS;Database=VendorDB;Integrated Security=True;")
            cnn.Open()

            ' Vendor ComboBox
            Dim cmdVendor As New SqlCommand("SELECT DISTINCT VendorName FROM Setup.Purchase", cnn)
            Using reader = cmdVendor.ExecuteReader()
                While reader.Read()
                    cboVendor.Items.Add(reader("VendorName").ToString())
                End While
            End Using

            ' Item ComboBox
            Dim cmdItem As New SqlCommand("SELECT DISTINCT Item FROM Setup.Purchase", cnn)
            Using reader = cmdItem.ExecuteReader()
                While reader.Read()
                    cboItem.Items.Add(reader("Item").ToString())
                End While
            End Using

            ' FromLocation ComboBox
            Dim cmdFrom As New SqlCommand("SELECT DISTINCT WarehouseLocation FROM Setup.Purchase", cnn)
            Using reader = cmdFrom.ExecuteReader()
                While reader.Read()
                    cboFromLocation.Items.Add(reader("WarehouseLocation").ToString())
                    cboToLocation.Items.Add(reader("WarehouseLocation").ToString())
                End While
            End Using
        End Using
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Dim vendor = cboVendor.Text
        Dim item = cboItem.Text
        Dim fromLoc = cboFromLocation.Text
        Dim toLoc = cboToLocation.Text
        Dim qty As Integer

        If Not Integer.TryParse(txtQuantity.Text, qty) Or qty <= 0 Then
            MessageBox.Show("Please enter valid quantity.")
            Return
        End If

        If vendor = "" Or item = "" Or fromLoc = "" Or toLoc = "" Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If

        If fromLoc = toLoc Then
            MessageBox.Show("From and To location cannot be the same.")
            Return
        End If

        Dim availableStock = repo.GetAvailableStock(vendor, item, fromLoc)
        If qty > availableStock Then
            MessageBox.Show("Insufficient stock.")
            Return
        End If

        Dim transfer = New StockTransfer With {
            .VendorName = vendor,
            .Item = item,
            .Quantity = qty,
            .FromLocation = fromLoc,
            .ToLocation = toLoc
        }

        Try
            repo.TransferStock(transfer)
            MessageBox.Show("Stock transferred successfully.")
        Catch ex As Exception
            MessageBox.Show("Transfer failed: " & ex.Message)
        End Try
    End Sub
End Class
