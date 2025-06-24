<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerControl
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
        txtCustomerID = New TextBox()
        txtCustomerName = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        btnNew = New Button()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        dgvCustomers = New DataGridView()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 0
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 2
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Location = New Point(120, 20)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(200, 27)
        txtCustomerID.TabIndex = 4
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(120, 60)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(200, 27)
        txtCustomerName.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(120, 100)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(200, 27)
        txtPhone.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(120, 140)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(200, 27)
        txtEmail.TabIndex = 7
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(20, 180)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(75, 30)
        btnNew.TabIndex = 8
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(105, 180)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 30)
        btnSave.TabIndex = 9
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(190, 180)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 30)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(275, 180)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 30)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.Location = New Point(20, 230)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.RowHeadersWidth = 51
        dgvCustomers.Size = New Size(700, 250)
        dgvCustomers.TabIndex = 12
        ' 
        ' CustomerControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(dgvCustomers)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(btnNew)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtCustomerName)
        Controls.Add(txtCustomerID)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "CustomerControl"
        Size = New Size(755, 518)
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvCustomers As DataGridView

End Class
