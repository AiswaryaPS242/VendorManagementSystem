<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardHomeControl
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
        pnlVendors = New Panel()
        pnlCustomers = New Panel()
        pnlProducts = New Panel()
        pnlPurchase = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblVendorCount = New Label()
        lblCustomerCount = New Label()
        lblProductCount = New Label()
        lblPurchaseTotal = New Label()
        pnlVendors.SuspendLayout()
        pnlCustomers.SuspendLayout()
        pnlProducts.SuspendLayout()
        pnlPurchase.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlVendors
        ' 
        pnlVendors.BackColor = Color.LightSkyBlue
        pnlVendors.Controls.Add(Label1)
        pnlVendors.Controls.Add(lblVendorCount)
        pnlVendors.Location = New Point(20, 20)
        pnlVendors.Name = "pnlVendors"
        pnlVendors.Size = New Size(180, 100)
        pnlVendors.TabIndex = 0
        ' 
        ' pnlCustomers
        ' 
        pnlCustomers.BackColor = Color.LightGreen
        pnlCustomers.Controls.Add(lblCustomerCount)
        pnlCustomers.Controls.Add(Label2)
        pnlCustomers.Location = New Point(340, 20)
        pnlCustomers.Name = "pnlCustomers"
        pnlCustomers.Size = New Size(180, 100)
        pnlCustomers.TabIndex = 0
        ' 
        ' pnlProducts
        ' 
        pnlProducts.BackColor = Color.LightGoldenrodYellow
        pnlProducts.Controls.Add(lblProductCount)
        pnlProducts.Controls.Add(Label3)
        pnlProducts.Location = New Point(20, 140)
        pnlProducts.Name = "pnlProducts"
        pnlProducts.Size = New Size(180, 100)
        pnlProducts.TabIndex = 0
        ' 
        ' pnlPurchase
        ' 
        pnlPurchase.BackColor = Color.LightCoral
        pnlPurchase.Controls.Add(Label4)
        pnlPurchase.Controls.Add(lblPurchaseTotal)
        pnlPurchase.Location = New Point(340, 140)
        pnlPurchase.Name = "pnlPurchase"
        pnlPurchase.Size = New Size(180, 100)
        pnlPurchase.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 20)
        Label1.TabIndex = 0
        Label1.Text = "Total Vendors"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 1
        Label2.Text = "Total Customers"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 20)
        Label3.TabIndex = 2
        Label3.Text = "Total Products"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(10, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 20)
        Label4.TabIndex = 3
        Label4.Text = "Total Purchase ₹"
        ' 
        ' lblVendorCount
        ' 
        lblVendorCount.AutoSize = True
        lblVendorCount.Font = New Font("Microsoft Sans Serif", 14F)
        lblVendorCount.Location = New Point(10, 50)
        lblVendorCount.Name = "lblVendorCount"
        lblVendorCount.Size = New Size(122, 29)
        lblVendorCount.TabIndex = 4
        lblVendorCount.Text = "0 Vendors"
        ' 
        ' lblCustomerCount
        ' 
        lblCustomerCount.AutoSize = True
        lblCustomerCount.Font = New Font("Microsoft Sans Serif", 14F)
        lblCustomerCount.Location = New Point(10, 50)
        lblCustomerCount.Name = "lblCustomerCount"
        lblCustomerCount.Size = New Size(148, 29)
        lblCustomerCount.TabIndex = 5
        lblCustomerCount.Text = "0 Customers"
        ' 
        ' lblProductCount
        ' 
        lblProductCount.AutoSize = True
        lblProductCount.Font = New Font("Microsoft Sans Serif", 14F)
        lblProductCount.Location = New Point(10, 50)
        lblProductCount.Name = "lblProductCount"
        lblProductCount.Size = New Size(127, 29)
        lblProductCount.TabIndex = 6
        lblProductCount.Text = "0 Products"
        ' 
        ' lblPurchaseTotal
        ' 
        lblPurchaseTotal.AutoSize = True
        lblPurchaseTotal.Font = New Font("Microsoft Sans Serif", 14F)
        lblPurchaseTotal.Location = New Point(10, 50)
        lblPurchaseTotal.Name = "lblPurchaseTotal"
        lblPurchaseTotal.Size = New Size(77, 29)
        lblPurchaseTotal.TabIndex = 7
        lblPurchaseTotal.Text = "₹ 0.00"
        ' 
        ' DashboardHomeControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlCustomers)
        Controls.Add(pnlProducts)
        Controls.Add(pnlPurchase)
        Controls.Add(pnlVendors)
        Name = "DashboardHomeControl"
        Size = New Size(813, 509)
        pnlVendors.ResumeLayout(False)
        pnlVendors.PerformLayout()
        pnlCustomers.ResumeLayout(False)
        pnlCustomers.PerformLayout()
        pnlProducts.ResumeLayout(False)
        pnlProducts.PerformLayout()
        pnlPurchase.ResumeLayout(False)
        pnlPurchase.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlVendors As Panel
    Friend WithEvents pnlCustomers As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlProducts As Panel
    Friend WithEvents pnlPurchase As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblVendorCount As Label
    Friend WithEvents lblCustomerCount As Label
    Friend WithEvents lblProductCount As Label
    Friend WithEvents lblPurchaseTotal As Label

End Class
