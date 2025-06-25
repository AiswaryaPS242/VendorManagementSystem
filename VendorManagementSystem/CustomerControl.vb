Public Class CustomerControl
    Private ReadOnly customerRepo As New CustomerRepository()
    Private currentCustomer As Customer
    Private allCustomers As DataTable

    Private Sub CustomerControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
        btnNew.PerformClick()
    End Sub

    Private Sub LoadCustomers()
        allCustomers = customerRepo.GetAllCustomers().Copy()
        dgvCustomers.DataSource = allCustomers
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtCustomerID.Text = customerRepo.GetNextID().ToString()
        ClearFields()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        currentCustomer = New Customer With {
            .ID = CInt(txtCustomerID.Text),
            .Name = txtCustomerName.Text,
            .Phone = txtPhone.Text,
            .Email = txtEmail.Text
        }

        Try
            customerRepo.AddCustomer(currentCustomer)
            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()
            btnNew.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error saving customer: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        currentCustomer = New Customer With {
            .ID = CInt(txtCustomerID.Text),
            .Name = txtCustomerName.Text,
            .Phone = txtPhone.Text,
            .Email = txtEmail.Text
        }

        Try
            customerRepo.UpdateCustomer(currentCustomer)
            MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating customer: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCustomers.SelectedRows.Count > 0 Then
            Dim id = CInt(dgvCustomers.SelectedRows(0).Cells("ID").Value)
            If MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                customerRepo.DeleteCustomer(id)
                LoadCustomers()
                ClearFields()
            End If
        End If
    End Sub

    Private Sub dgvCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvCustomers.Rows(e.RowIndex)
            txtCustomerID.Text = row.Cells("ID").Value.ToString()
            txtCustomerName.Text = row.Cells("CustomerName").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()
            txtEmail.Text = row.Cells("Email").Value.ToString()
        End If
    End Sub

    Private Sub ClearFields()
        txtCustomerName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtCustomerName.Focus()
    End Sub
End Class
