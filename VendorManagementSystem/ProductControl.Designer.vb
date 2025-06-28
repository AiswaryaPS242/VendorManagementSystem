<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductControl
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
        txtProductID = New TextBox()
        txtProductName = New TextBox()
        txtCategory = New TextBox()
        txtPrice = New TextBox()
        btnNew = New Button()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        dgvProducts = New DataGridView()
        lblQuantity = New Label()
        txtQuantity = New TextBox()
        Label5 = New Label()
        lblWarehouse = New Label()
        cboWarehouse = New ComboBox()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
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
        Label2.Location = New Point(20, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 2
        Label3.Text = "Category"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 123)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 20)
        Label4.TabIndex = 3
        Label4.Text = "Price"
        ' 
        ' txtProductID
        ' 
        txtProductID.Location = New Point(120, 17)
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(200, 27)
        txtProductID.TabIndex = 4
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(120, 50)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(200, 27)
        txtProductName.TabIndex = 5
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(120, 83)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(200, 27)
        txtCategory.TabIndex = 6
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(120, 116)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(200, 27)
        txtPrice.TabIndex = 7
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(20, 223)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(75, 30)
        btnNew.TabIndex = 8
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(101, 223)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 30)
        btnSave.TabIndex = 9
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(182, 223)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 30)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(263, 223)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 30)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' dgvProducts
        ' 
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(20, 259)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.RowHeadersWidth = 51
        dgvProducts.Size = New Size(700, 250)
        dgvProducts.TabIndex = 12
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(20, 156)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(65, 20)
        lblQuantity.TabIndex = 13
        lblQuantity.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(120, 149)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(200, 27)
        txtQuantity.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 15
        ' 
        ' lblWarehouse
        ' 
        lblWarehouse.AutoSize = True
        lblWarehouse.Location = New Point(20, 191)
        lblWarehouse.Name = "lblWarehouse"
        lblWarehouse.Size = New Size(82, 20)
        lblWarehouse.TabIndex = 17
        lblWarehouse.Text = "Warehouse"
        ' 
        ' cboWarehouse
        ' 
        cboWarehouse.FormattingEnabled = True
        cboWarehouse.Items.AddRange(New Object() {"Warehouse 1", "Warehouse 2", "Warehouse 3", "Warehouse 4"})
        cboWarehouse.Location = New Point(120, 188)
        cboWarehouse.Name = "cboWarehouse"
        cboWarehouse.Size = New Size(200, 28)
        cboWarehouse.TabIndex = 18
        ' 
        ' ProductControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(cboWarehouse)
        Controls.Add(lblWarehouse)
        Controls.Add(Label5)
        Controls.Add(txtQuantity)
        Controls.Add(lblQuantity)
        Controls.Add(dgvProducts)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(btnNew)
        Controls.Add(txtPrice)
        Controls.Add(txtCategory)
        Controls.Add(txtProductName)
        Controls.Add(txtProductID)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ProductControl"
        Size = New Size(756, 526)
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblWarehouse As Label
    Friend WithEvents cboWarehouse As ComboBox

End Class
