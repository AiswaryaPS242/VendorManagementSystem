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
        btnCustomers.Location = New Point(120, 10)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(94, 29)
        btnCustomers.TabIndex = 1
        btnCustomers.Text = "Customers"
        btnCustomers.UseVisualStyleBackColor = True
        ' 
        ' btnProducts
        ' 
        btnProducts.Location = New Point(230, 10)
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
        TopPanel.Controls.Add(btnVendors)
        TopPanel.Controls.Add(btnProducts)
        TopPanel.Controls.Add(btnCustomers)
        TopPanel.Location = New Point(0, -6)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(900, 50)
        TopPanel.TabIndex = 3
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
End Class
