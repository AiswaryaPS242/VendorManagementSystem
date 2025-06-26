<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurchaseReportControl
    Inherits System.Windows.Forms.UserControl

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtTransactionID = New TextBox()
        txtVendor = New TextBox()
        txtAmount = New TextBox()
        dtpDate = New DateTimePicker()
        btnNew = New Button()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnExportExcel = New Button()
        dgvReport = New DataGridView()
        lblTotalAmount = New Label()
        lblTransactionID = New Label()
        lblVendor = New Label()
        lblAmount = New Label()
        lblDate = New Label()
        CType(dgvReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTransactionID
        ' 
        txtTransactionID.Location = New Point(20, 35)
        txtTransactionID.Name = "txtTransactionID"
        txtTransactionID.Size = New Size(130, 27)
        txtTransactionID.TabIndex = 0
        ' 
        ' txtVendor
        ' 
        txtVendor.Location = New Point(170, 35)
        txtVendor.Name = "txtVendor"
        txtVendor.Size = New Size(130, 27)
        txtVendor.TabIndex = 1
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(320, 35)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(130, 27)
        txtAmount.TabIndex = 2
        ' 
        ' dtpDate
        ' 
        dtpDate.CustomFormat = "dd   MMMM   yyyy"
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.Location = New Point(470, 35)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(160, 27)
        dtpDate.TabIndex = 3
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(636, 14)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(75, 23)
        btnNew.TabIndex = 8
        btnNew.Text = "New"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(703, 15)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 9
        btnSave.Text = "Save"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(636, 37)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(703, 37)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.Location = New Point(140, 375)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(120, 30)
        btnExportExcel.TabIndex = 14
        btnExportExcel.Text = "Export to Excel"
        ' 
        ' dgvReport
        ' 
        dgvReport.AllowUserToAddRows = False
        dgvReport.AllowUserToDeleteRows = False
        dgvReport.ColumnHeadersHeight = 29
        dgvReport.Location = New Point(20, 70)
        dgvReport.Name = "dgvReport"
        dgvReport.ReadOnly = True
        dgvReport.RowHeadersWidth = 51
        dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReport.Size = New Size(900, 300)
        dgvReport.TabIndex = 12
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblTotalAmount.Location = New Point(20, 380)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(104, 23)
        lblTotalAmount.TabIndex = 13
        lblTotalAmount.Text = "Total: ₹0.00"
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.AutoSize = True
        lblTransactionID.Location = New Point(20, 15)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(103, 20)
        lblTransactionID.TabIndex = 4
        lblTransactionID.Text = "Transaction ID"
        ' 
        ' lblVendor
        ' 
        lblVendor.AutoSize = True
        lblVendor.Location = New Point(170, 15)
        lblVendor.Name = "lblVendor"
        lblVendor.Size = New Size(100, 20)
        lblVendor.TabIndex = 5
        lblVendor.Text = "Vendor Name"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(320, 15)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(90, 20)
        lblAmount.TabIndex = 6
        lblAmount.Text = "Net Amount"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(470, 15)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(41, 20)
        lblDate.TabIndex = 7
        lblDate.Text = "Date"
        ' 
        ' PurchaseReportControl
        ' 
        Controls.Add(txtTransactionID)
        Controls.Add(txtVendor)
        Controls.Add(txtAmount)
        Controls.Add(dtpDate)
        Controls.Add(lblTransactionID)
        Controls.Add(lblVendor)
        Controls.Add(lblAmount)
        Controls.Add(lblDate)
        Controls.Add(btnNew)
        Controls.Add(btnSave)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(dgvReport)
        Controls.Add(lblTotalAmount)
        Controls.Add(btnExportExcel)
        Name = "PurchaseReportControl"
        Size = New Size(950, 420)
        CType(dgvReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTransactionID As TextBox
    Friend WithEvents txtVendor As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents lblTotalAmount As Label

    Friend WithEvents lblTransactionID As Label
    Friend WithEvents lblVendor As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblDate As Label
End Class
