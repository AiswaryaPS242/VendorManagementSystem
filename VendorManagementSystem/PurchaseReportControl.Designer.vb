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
        btnExportExcel = New Button()
        dgvReport = New DataGridView()
        lblTotalAmount = New Label()
        CType(dgvReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

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
        ' PurchaseReportControl
        '
        Controls.Add(dgvReport)
        Controls.Add(lblTotalAmount)
        Controls.Add(btnExportExcel)
        Name = "PurchaseReportControl"
        Size = New Size(950, 420)
        CType(dgvReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Friend WithEvents btnExportExcel As Button
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents lblTotalAmount As Label
End Class
