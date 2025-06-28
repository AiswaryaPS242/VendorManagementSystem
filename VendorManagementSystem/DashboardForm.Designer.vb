<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        btnVendors = New Button()
        btnCustomers = New Button()
        btnProducts = New Button()
        MainPanel = New Panel()
        TopPanel = New Panel()
        btnStockTransfer = New Button()
        btnLogout = New Button()
        btnPurchaseReport = New Button()
        btnBackup = New Button()
        btnPurchaseEntry = New Button()
        TopPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnVendors
        ' 
        btnVendors.Location = New Point(10, 10)
        btnVendors.Name = "btnVendors"
        btnVendors.Size = New Size(94, 29)
        btnVendors.TabIndex = 0
        btnVendors.Text = "Vendors"
        btnVendors.UseVisualStyleBackColor = True
        ' 
        ' btnCustomers
        ' 
        btnCustomers.Location = New Point(110, 11)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(94, 29)
        btnCustomers.TabIndex = 1
        btnCustomers.Text = "Customers"
        btnCustomers.UseVisualStyleBackColor = True
        ' 
        ' btnProducts
        ' 
        btnProducts.Location = New Point(210, 10)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(94, 29)
        btnProducts.TabIndex = 2
        btnProducts.Text = "Products"
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' MainPanel
        ' 
        MainPanel.Location = New Point(0, 50)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(900, 550)
        MainPanel.TabIndex = 3
        ' 
        ' TopPanel
        ' 
        TopPanel.Controls.Add(btnPurchaseEntry)
        TopPanel.Controls.Add(btnStockTransfer)
        TopPanel.Controls.Add(btnLogout)
        TopPanel.Controls.Add(btnPurchaseReport)
        TopPanel.Controls.Add(btnBackup)
        TopPanel.Controls.Add(btnVendors)
        TopPanel.Controls.Add(btnProducts)
        TopPanel.Controls.Add(btnCustomers)
        TopPanel.Location = New Point(0, -6)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(900, 50)
        TopPanel.TabIndex = 3
        ' 
        ' btnStockTransfer
        ' 
        btnStockTransfer.Location = New Point(660, 11)
        btnStockTransfer.Name = "btnStockTransfer"
        btnStockTransfer.Size = New Size(114, 29)
        btnStockTransfer.TabIndex = 4
        btnStockTransfer.Text = "Stock Transfer"
        btnStockTransfer.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(800, 10)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(80, 30)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnPurchaseReport
        ' 
        btnPurchaseReport.Location = New Point(410, 11)
        btnPurchaseReport.Name = "btnPurchaseReport"
        btnPurchaseReport.Size = New Size(122, 29)
        btnPurchaseReport.TabIndex = 4
        btnPurchaseReport.Text = "Purchase report"
        btnPurchaseReport.UseVisualStyleBackColor = True
        ' 
        ' btnBackup
        ' 
        btnBackup.Location = New Point(310, 10)
        btnBackup.Name = "btnBackup"
        btnBackup.Size = New Size(94, 29)
        btnBackup.TabIndex = 3
        btnBackup.Text = "Backup"
        btnBackup.UseVisualStyleBackColor = True
        ' 
        ' btnPurchaseEntry
        ' 
        btnPurchaseEntry.Location = New Point(538, 10)
        btnPurchaseEntry.Name = "btnPurchaseEntry"
        btnPurchaseEntry.Size = New Size(116, 29)
        btnPurchaseEntry.TabIndex = 0
        btnPurchaseEntry.Text = "Purchase Entry"
        btnPurchaseEntry.UseVisualStyleBackColor = True
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 553)
        Controls.Add(TopPanel)
        Controls.Add(MainPanel)
        Name = "DashboardForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Vendor Management Dashboard"
        TopPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnVendors As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnPurchaseReport As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnStockTransfer As Button
    Friend WithEvents btnPurchaseEntry As Button
End Class
