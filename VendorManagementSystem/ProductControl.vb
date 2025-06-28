Public Class ProductControl
    Private ReadOnly productRepo As New ProductRepository()
    Private currentProduct As Product

    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProducts.DataSource = productRepo.GetAllProducts()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        currentProduct = New Product With {
        .ID = CInt(txtProductID.Text),
        .Name = txtProductName.Text,
        .Category = txtCategory.Text,
        .Price = CDec(txtPrice.Text),
        .Quantity = Integer.Parse(txtQuantity.Text),
        .WarehouseLocation = cboWarehouse.Text
    }

        productRepo.AddProduct(currentProduct)
        dgvProducts.DataSource = productRepo.GetAllProducts()
        btnNew.PerformClick()
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtProductID.Text = productRepo.GetNextID().ToString()
        txtProductName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        cboWarehouse.SelectedIndex = -1
        txtProductName.Focus()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        currentProduct = New Product With {
        .ID = CInt(txtProductID.Text),
        .Name = txtProductName.Text,
        .Category = txtCategory.Text,
        .Price = CDec(txtPrice.Text),
        .Quantity = Integer.Parse(txtQuantity.Text),
        .WarehouseLocation = cboWarehouse.Text
    }

        productRepo.UpdateProduct(currentProduct)
        dgvProducts.DataSource = productRepo.GetAllProducts()
        ClearFields()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim selectedID As Integer = CInt(dgvProducts.SelectedRows(0).Cells(0).Value)
            productRepo.DeleteProduct(selectedID)
            dgvProducts.DataSource = productRepo.GetAllProducts()
            ClearFields()
        End If
    End Sub


    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvProducts.Rows(e.RowIndex)
            txtProductID.Text = row.Cells(0).Value
            txtProductName.Text = row.Cells(1).Value
            txtCategory.Text = row.Cells(2).Value
            txtPrice.Text = row.Cells(3).Value
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
            cboWarehouse.Text = row.Cells("WarehouseLocation").Value.ToString()
        End If
    End Sub

    Private Sub ClearFields()
        txtProductID.Clear()
        txtProductName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        cboWarehouse.SelectedIndex = -1
    End Sub


End Class
