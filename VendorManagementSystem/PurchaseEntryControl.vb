Imports System.Data.SqlClient
Imports System.Data

Public Class PurchaseEntryControl
    Inherits UserControl
    Private nextID As Integer
    Private ReadOnly repo As New PurchaseEntryRepository()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PurchaseEntryControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVendors()
        LoadProducts()
        LoadWarehouses()
        ResetForm()
    End Sub

    Private Sub LoadVendors()
        Dim vendors = repo.GetVendors()
        cboVendor.DataSource = vendors
        cboVendor.DisplayMember = "VendorName"
        cboVendor.ValueMember = "VendorName"
    End Sub

    Private Sub LoadProducts()
        Dim products = repo.GetProducts()
        cboItem.DataSource = products
        cboItem.DisplayMember = "ProductName"
        cboItem.ValueMember = "ProductName"
    End Sub

    Private Sub LoadWarehouses()
        cboWarehouse.Items.Clear()
        cboWarehouse.Items.Add("Warehouse 1")
        cboWarehouse.Items.Add("Warehouse 2")
    End Sub

    Private Sub ResetForm()
        txtQuantity.Clear()
        txtAmount.Clear()
        cboVendor.SelectedIndex = -1
        cboItem.SelectedIndex = -1
        cboWarehouse.SelectedIndex = -1
        dtpDate.Value = Date.Today
        nextID = repo.GetNextPurchaseID()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ResetForm()
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        If cboVendor.SelectedIndex = -1 Or cboItem.SelectedIndex = -1 Or cboWarehouse.SelectedIndex = -1 Or txtQuantity.Text.Trim() = "" Or txtAmount.Text.Trim() = "" Then
            MessageBox.Show("Please fill all fields")
            Return
        End If

        Dim qty As Integer
        Dim amt As Decimal
        If Not Integer.TryParse(txtQuantity.Text, qty) Or Not Decimal.TryParse(txtAmount.Text, amt) Then
            MessageBox.Show("Quantity and Amount must be valid numbers")
            Return
        End If

        Dim purchase As New Purchase With {
            .VendorName = cboVendor.SelectedValue.ToString(),
            .Item = cboItem.SelectedValue.ToString(),
            .Quantity = qty,
            .PurchaseAmount = amt,
            .WarehouseLocation = cboWarehouse.SelectedItem.ToString(),
            .PurchaseDate = dtpDate.Value
        }

        repo.Add(purchase)
        MessageBox.Show("Purchase saved")
        ResetForm()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        MessageBox.Show("This form does not support in-place editing of purchases. Please use the Purchase Report to edit records.")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        MessageBox.Show("This form does not support deletion. Please use the Purchase Report to delete records.")
    End Sub
End Class
