<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendorControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtID = New TextBox()
        txtName = New TextBox()
        txtAddress = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        btnNew = New Button()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        dgvVendors = New DataGridView()
        CType(dgvVendors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 0
        Label1.Text = "Vendor ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 1
        Label2.Text = "Vendor Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 20)
        Label3.TabIndex = 2
        Label3.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 3
        Label4.Text = "Phone"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 4
        Label5.Text = "Email"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(120, 20)
        txtID.Name = "txtID"
        txtID.Size = New Size(200, 27)
        txtID.TabIndex = 5
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(120, 60)
        txtName.Name = "txtName"
        txtName.Size = New Size(200, 27)
        txtName.TabIndex = 6
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(120, 100)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(200, 27)
        txtAddress.TabIndex = 7
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(120, 140)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(200, 27)
        txtPhone.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(120, 180)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(200, 27)
        txtEmail.TabIndex = 9
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(20, 230)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(75, 30)
        btnNew.TabIndex = 10
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(105, 230)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 30)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(190, 230)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 30)
        btnUpdate.TabIndex = 12
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(275, 230)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 30)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' dgvVendors
        ' 
        dgvVendors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVendors.Location = New Point(20, 280)
        dgvVendors.Name = "dgvVendors"
        dgvVendors.RowHeadersWidth = 51
        dgvVendors.Size = New Size(700, 250)
        dgvVendors.TabIndex = 14
        ' 
        ' VendorControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(dgvVendors)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(btnNew)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtAddress)
        Controls.Add(txtName)
        Controls.Add(txtID)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "VendorControl"
        Size = New Size(750, 550)
        CType(dgvVendors, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvVendors As DataGridView

End Class
