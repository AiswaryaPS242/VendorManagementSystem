Public Class CustomerControl

    Private ReadOnly customerRepo As New CustomerRepository()
    Private currentCustomer As Customer

    Private Sub CustomerControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCustomers.DataSource = customerRepo.GetAllCustomers()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        currentCustomer = New Customer With {
        .ID = CInt(txtCustomerID.Text),
        .Name = txtCustomerName.Text,
        .Phone = txtPhone.Text,
        .Email = txtEmail.Text
    }

        customerRepo.AddCustomer(currentCustomer)
        dgvCustomers.DataSource = customerRepo.GetAllCustomers()
        btnNew.PerformClick()
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtCustomerID.Text = customerRepo.GetNextID().ToString()
        txtCustomerName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtCustomerName.Focus()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvCustomers.SelectedRows.Count > 0 Then
            Dim row = dgvCustomers.SelectedRows(0)
            row.Cells(0).Value = txtCustomerID.Text
            row.Cells(1).Value = txtCustomerName.Text
            row.Cells(2).Value = txtPhone.Text
            row.Cells(3).Value = txtEmail.Text
            ClearFields()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCustomers.SelectedRows.Count > 0 Then
            dgvCustomers.Rows.Remove(dgvCustomers.SelectedRows(0))
            ClearFields()
        End If
    End Sub

    Private Sub dgvCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvCustomers.Rows(e.RowIndex)
            txtCustomerID.Text = row.Cells(0).Value
            txtCustomerName.Text = row.Cells(1).Value
            txtPhone.Text = row.Cells(2).Value
            txtEmail.Text = row.Cells(3).Value
        End If
    End Sub

    Private Sub ClearFields()
        txtCustomerID.Clear()
        txtCustomerName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
    End Sub
End Class
