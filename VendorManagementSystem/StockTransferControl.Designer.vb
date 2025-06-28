<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockTransferControl
    Inherits System.Windows.Forms.UserControl

    ' Dispose method
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboVendor = New System.Windows.Forms.ComboBox()
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.cboFromLocation = New System.Windows.Forms.ComboBox()
        Me.cboToLocation = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnTransfer = New System.Windows.Forms.Button()

        Me.lblVendor = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblFromLocation = New System.Windows.Forms.Label()
        Me.lblToLocation = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()

        Me.SuspendLayout()

        ' Vendor Label
        Me.lblVendor.AutoSize = True
        Me.lblVendor.Location = New System.Drawing.Point(30, 30)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(72, 13)
        Me.lblVendor.Text = "Vendor Name"

        ' cboVendor
        Me.cboVendor.FormattingEnabled = True
        Me.cboVendor.Location = New System.Drawing.Point(150, 25)
        Me.cboVendor.Name = "cboVendor"
        Me.cboVendor.Size = New System.Drawing.Size(200, 21)

        ' Item Label
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(30, 70)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(58, 13)
        Me.lblItem.Text = "Item Name"

        ' cboItem
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Location = New System.Drawing.Point(150, 65)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(200, 21)

        ' FromLocation Label
        Me.lblFromLocation.AutoSize = True
        Me.lblFromLocation.Location = New System.Drawing.Point(30, 110)
        Me.lblFromLocation.Name = "lblFromLocation"
        Me.lblFromLocation.Size = New System.Drawing.Size(81, 13)
        Me.lblFromLocation.Text = "From Location"

        ' cboFromLocation
        Me.cboFromLocation.FormattingEnabled = True
        Me.cboFromLocation.Location = New System.Drawing.Point(150, 105)
        Me.cboFromLocation.Name = "cboFromLocation"
        Me.cboFromLocation.Size = New System.Drawing.Size(200, 21)

        ' ToLocation Label
        Me.lblToLocation.AutoSize = True
        Me.lblToLocation.Location = New System.Drawing.Point(30, 150)
        Me.lblToLocation.Name = "lblToLocation"
        Me.lblToLocation.Size = New System.Drawing.Size(70, 13)
        Me.lblToLocation.Text = "To Location"

        ' cboToLocation
        Me.cboToLocation.FormattingEnabled = True
        Me.cboToLocation.Location = New System.Drawing.Point(150, 145)
        Me.cboToLocation.Name = "cboToLocation"
        Me.cboToLocation.Size = New System.Drawing.Size(200, 21)

        ' Quantity Label
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(30, 190)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.Text = "Quantity"

        ' txtQuantity
        Me.txtQuantity.Location = New System.Drawing.Point(150, 185)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(200, 20)

        ' btnTransfer
        Me.btnTransfer.Location = New System.Drawing.Point(150, 230)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(100, 30)
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True

        ' Add controls to the UserControl
        Me.Controls.Add(Me.lblVendor)
        Me.Controls.Add(Me.cboVendor)

        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.cboItem)

        Me.Controls.Add(Me.lblFromLocation)
        Me.Controls.Add(Me.cboFromLocation)

        Me.Controls.Add(Me.lblToLocation)
        Me.Controls.Add(Me.cboToLocation)

        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantity)

        Me.Controls.Add(Me.btnTransfer)

        ' Finalize
        Me.Name = "StockTransferControl"
        Me.Size = New System.Drawing.Size(420, 300)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents cboVendor As ComboBox
    Friend WithEvents cboItem As ComboBox
    Friend WithEvents cboFromLocation As ComboBox
    Friend WithEvents cboToLocation As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnTransfer As Button
    Friend WithEvents lblVendor As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents lblFromLocation As Label
    Friend WithEvents lblToLocation As Label
    Friend WithEvents lblQuantity As Label
End Class
