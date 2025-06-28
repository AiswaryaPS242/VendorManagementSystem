Partial Class PurchaseEntryControl
    Inherits UserControl

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        cboVendor = New ComboBox()
        cboItem = New ComboBox()
        txtQuantity = New TextBox()
        txtAmount = New TextBox()
        cboWarehouse = New ComboBox()
        dtpDate = New DateTimePicker()
        btnNew = New Button()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        lblVendor = New Label()
        lblItem = New Label()
        lblQuantity = New Label()
        lblAmount = New Label()
        lblWarehouse = New Label()
        lblDate = New Label()
        SuspendLayout()
        ' 
        ' cboVendor
        ' 
        cboVendor.Location = New Point(150, 27)
        cboVendor.Name = "cboVendor"
        cboVendor.Size = New Size(200, 28)
        cboVendor.TabIndex = 6
        ' 
        ' cboItem
        ' 
        cboItem.Location = New Point(150, 67)
        cboItem.Name = "cboItem"
        cboItem.Size = New Size(200, 28)
        cboItem.TabIndex = 7
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(150, 107)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(200, 27)
        txtQuantity.TabIndex = 8
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(150, 147)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(200, 27)
        txtAmount.TabIndex = 9
        ' 
        ' cboWarehouse
        ' 
        cboWarehouse.Location = New Point(150, 187)
        cboWarehouse.Name = "cboWarehouse"
        cboWarehouse.Size = New Size(200, 28)
        cboWarehouse.TabIndex = 10
        ' 
        ' dtpDate
        ' 
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(150, 227)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(200, 27)
        dtpDate.TabIndex = 11
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(30, 320)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(80, 30)
        btnNew.TabIndex = 13
        btnNew.Text = "New"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(120, 320)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(80, 30)
        btnSave.TabIndex = 14
        btnSave.Text = "Save"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Enabled = True
        btnUpdate.Location = New Point(210, 320)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(80, 30)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "Update"
        ' 
        ' btnDelete
        ' 
        btnDelete.Enabled = True
        btnDelete.Location = New Point(300, 320)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(80, 30)
        btnDelete.TabIndex = 16
        btnDelete.Text = "Delete"
        ' 
        ' lblVendor
        ' 
        lblVendor.AutoSize = True
        lblVendor.Location = New Point(30, 30)
        lblVendor.Name = "lblVendor"
        lblVendor.Size = New Size(56, 20)
        lblVendor.TabIndex = 0
        lblVendor.Text = "Vendor"
        ' 
        ' lblItem
        ' 
        lblItem.AutoSize = True
        lblItem.Location = New Point(30, 70)
        lblItem.Name = "lblItem"
        lblItem.Size = New Size(39, 20)
        lblItem.TabIndex = 1
        lblItem.Text = "Item"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(30, 110)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(65, 20)
        lblQuantity.TabIndex = 2
        lblQuantity.Text = "Quantity"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(30, 150)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(62, 20)
        lblAmount.TabIndex = 3
        lblAmount.Text = "Amount"
        ' 
        ' lblWarehouse
        ' 
        lblWarehouse.AutoSize = True
        lblWarehouse.Location = New Point(30, 190)
        lblWarehouse.Name = "lblWarehouse"
        lblWarehouse.Size = New Size(82, 20)
        lblWarehouse.TabIndex = 4
        lblWarehouse.Text = "Warehouse"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(30, 230)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(103, 20)
        lblDate.TabIndex = 5
        lblDate.Text = "Purchase Date"
        ' 
        ' PurchaseEntryControl
        ' 
        Controls.Add(lblVendor)
        Controls.Add(lblItem)
        Controls.Add(lblQuantity)
        Controls.Add(lblAmount)
        Controls.Add(lblWarehouse)
        Controls.Add(lblDate)
        Controls.Add(cboVendor)
        Controls.Add(cboItem)
        Controls.Add(txtQuantity)
        Controls.Add(txtAmount)
        Controls.Add(cboWarehouse)
        Controls.Add(dtpDate)
        Controls.Add(btnNew)
        Controls.Add(btnSave)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Name = "PurchaseEntryControl"
        Size = New Size(1148, 464)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboVendor As ComboBox
    Friend WithEvents cboItem As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cboWarehouse As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button

    Friend WithEvents lblVendor As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblWarehouse As Label
    Friend WithEvents lblDate As Label

End Class
