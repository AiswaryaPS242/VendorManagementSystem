Imports System.Data

Public Class VendorControl
    Private allVendors As DataTable
    Private ReadOnly vendorRepo As New VendorRepository()
    Private currentVendor As Vendor

    Private Sub VendorControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVendors()
        SetFormState(False)
    End Sub

    ' Load all vendors into DataGridView
    Private Sub LoadVendors()
        allVendors = vendorRepo.GetAllVendors().Copy()
        dgvVendors.DataSource = allVendors
    End Sub


    ' Clear form fields
    Private Sub ClearForm()
        txtID.Text = ""
        txtName.Text = ""
        txtAddress.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
    End Sub

    ' Enable/disable form controls
    Private Sub SetFormState(enabled As Boolean)
        txtName.Enabled = enabled
        txtAddress.Enabled = enabled
        txtPhone.Enabled = enabled
        txtEmail.Enabled = enabled
        btnSave.Enabled = enabled
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    ' "New" button - Prepare for new entry
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearForm()
        txtID.Text = vendorRepo.GetNextID().ToString()
        SetFormState(True)
        txtName.Focus()
    End Sub

    ' "Save" button - Add new vendor
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtName.Text) Then
            MessageBox.Show("Please enter vendor name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
            Return
        End If

        currentVendor = New Vendor With {
            .ID = CInt(txtID.Text),
            .VendorName = txtName.Text,
            .Address = txtAddress.Text,
            .Email = txtEmail.Text,
            .PhoneNumber = txtPhone.Text
        }

        Try
            vendorRepo.AddVendor(currentVendor)
            MessageBox.Show("Vendor saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadVendors()
            ClearForm()
            SetFormState(False)
        Catch ex As Exception
            MessageBox.Show($"Error saving vendor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' When a row is selected in DataGridView
    Private Sub dgvVendors_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVendors.SelectionChanged
        Try
            If dgvVendors.SelectedRows.Count > 0 Then
                Dim selectedRow = dgvVendors.SelectedRows(0)

                ' Fill textboxes
                txtID.Text = selectedRow.Cells("ID").Value.ToString()
                txtName.Text = selectedRow.Cells("VendorName").Value.ToString()
                txtAddress.Text = If(selectedRow.Cells("Address").Value Is DBNull.Value, "", selectedRow.Cells("Address").Value.ToString())
                txtEmail.Text = If(selectedRow.Cells("Email").Value Is DBNull.Value, "", selectedRow.Cells("Email").Value.ToString())
                txtPhone.Text = If(selectedRow.Cells("PhoneNumber").Value Is DBNull.Value, "", selectedRow.Cells("PhoneNumber").Value.ToString())

                ' Enable buttons
                btnUpdate.Enabled = True
                btnDelete.Enabled = True
                btnSave.Enabled = False

                ' Enable editing
                txtName.Enabled = True
                txtAddress.Enabled = True
                txtPhone.Enabled = True
                txtEmail.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading vendor: " & ex.Message)
        End Try
    End Sub

    ' "Update" button - Modify existing vendor
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtName.Text) Then
            MessageBox.Show("Please enter vendor name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
            Return
        End If

        currentVendor = New Vendor With {
            .ID = CInt(txtID.Text),
            .VendorName = txtName.Text,
            .Address = txtAddress.Text,
            .Email = txtEmail.Text,
            .PhoneNumber = txtPhone.Text
        }

        Try
            vendorRepo.UpdateVendor(currentVendor)
            MessageBox.Show("Vendor updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadVendors()
            ClearForm()
            SetFormState(False)
        Catch ex As Exception
            MessageBox.Show($"Error updating vendor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' "Delete" button - Remove vendor
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this vendor?", "Confirm Delete",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                vendorRepo.DeleteVendor(CInt(txtID.Text))
                MessageBox.Show("Vendor deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadVendors()
                ClearForm()
                SetFormState(False)
            Catch ex As Exception
                MessageBox.Show($"Error deleting vendor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        If String.IsNullOrEmpty(searchText) Then
            dgvVendors.DataSource = allVendors
        Else
            Dim filtered = allVendors.AsEnumerable().
                Where(Function(row) row.Field(Of String)("VendorName").ToLower().Contains(searchText))

            If filtered.Any() Then
                dgvVendors.DataSource = filtered.CopyToDataTable()
            Else
                dgvVendors.DataSource = allVendors.Clone() ' Empty with same structure
            End If
        End If
    End Sub

End Class