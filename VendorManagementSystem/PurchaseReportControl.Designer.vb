<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseReportControl
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
        dgvReport = New DataGridView()
        btnExportExcel = New Button()
        txtVendor = New TextBox()
        txtAmount = New TextBox()
        dtpDate = New DateTimePicker()
        btnAddReport = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(dgvReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvReport
        ' 
        dgvReport.AllowUserToAddRows = False
        dgvReport.AllowUserToDeleteRows = False
        dgvReport.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReport.Location = New Point(20, 50)
        dgvReport.Name = "dgvReport"
        dgvReport.ReadOnly = True
        dgvReport.RowHeadersVisible = False
        dgvReport.RowHeadersWidth = 51
        dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReport.Size = New Size(1449, 267)
        dgvReport.TabIndex = 0
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnExportExcel.BackColor = SystemColors.GradientActiveCaption
        btnExportExcel.Location = New Point(20, 330)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(150, 35)
        btnExportExcel.TabIndex = 1
        btnExportExcel.Text = "Export to Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' txtVendor
        ' 
        txtVendor.Location = New Point(20, 20)
        txtVendor.Name = "txtVendor"
        txtVendor.Size = New Size(125, 27)
        txtVendor.TabIndex = 2
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(250, 20)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(125, 27)
        txtAmount.TabIndex = 3
        ' 
        ' dtpDate
        ' 
        dtpDate.CausesValidation = False
        dtpDate.Location = New Point(480, 20)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(250, 27)
        dtpDate.TabIndex = 4
        dtpDate.Tag = ""
        ' 
        ' btnAddReport
        ' 
        btnAddReport.Location = New Point(750, 20)
        btnAddReport.Name = "btnAddReport"
        btnAddReport.Size = New Size(94, 29)
        btnAddReport.TabIndex = 5
        btnAddReport.Text = "Add Report"
        btnAddReport.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 6
        Label1.Text = "Vendor Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(250, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 7
        Label2.Text = "Net Amount"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(480, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 8
        Label3.Text = "Date"
        ' 
        ' PurchaseReportControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnAddReport)
        Controls.Add(dtpDate)
        Controls.Add(txtAmount)
        Controls.Add(txtVendor)
        Controls.Add(btnExportExcel)
        Controls.Add(dgvReport)
        Name = "PurchaseReportControl"
        Size = New Size(1386, 479)
        CType(dgvReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents txtVendor As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnAddReport As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
