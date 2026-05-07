<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Window1
    Inherits Wisej.Web.Form

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

    'Required by the Wisej Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej.NET Designer
    'It can be modified using the Wisej.NET Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtBarcodeData = New Wisej.Web.TextBox()
        Me.BarcodeReader1 = New GDGWisejSerialBarcodeReader.BarcodeReader()
        Me.txtFullBarcodeData = New Wisej.Web.TextBox()
        Me.txtDeviceID = New Wisej.Web.TextBox()
        Me.Button1 = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'txtBarcodeData
        '
        Me.txtBarcodeData.LabelText = "Barcode"
        Me.txtBarcodeData.Location = New System.Drawing.Point(146, 13)
        Me.txtBarcodeData.Name = "txtBarcodeData"
        Me.txtBarcodeData.Size = New System.Drawing.Size(423, 53)
        Me.txtBarcodeData.TabIndex = 1
        '
        'BarcodeReader1
        '
        Me.BarcodeReader1.Location = New System.Drawing.Point(18, 13)
        Me.BarcodeReader1.Name = "BarcodeReader1"
        Me.BarcodeReader1.Size = New System.Drawing.Size(101, 53)
        Me.BarcodeReader1.TabIndex = 0
        '
        'txtFullBarcodeData
        '
        Me.txtFullBarcodeData.LabelText = "Barcode"
        Me.txtFullBarcodeData.Location = New System.Drawing.Point(146, 72)
        Me.txtFullBarcodeData.Name = "txtFullBarcodeData"
        Me.txtFullBarcodeData.Size = New System.Drawing.Size(423, 53)
        Me.txtFullBarcodeData.TabIndex = 2
        '
        'txtDeviceID
        '
        Me.txtDeviceID.LabelText = "DeviceID"
        Me.txtDeviceID.Location = New System.Drawing.Point(18, 166)
        Me.txtDeviceID.Name = "txtDeviceID"
        Me.txtDeviceID.Size = New System.Drawing.Size(423, 53)
        Me.txtDeviceID.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        '
        'Window1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(613, 432)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDeviceID)
        Me.Controls.Add(Me.txtFullBarcodeData)
        Me.Controls.Add(Me.txtBarcodeData)
        Me.Controls.Add(Me.BarcodeReader1)
        Me.Name = "Window1"
        Me.Text = "Window1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarcodeReader1 As GDGWisejSerialBarcodeReader.BarcodeReader
    Friend WithEvents txtBarcodeData As Wisej.Web.TextBox
    Friend WithEvents txtFullBarcodeData As Wisej.Web.TextBox
    Friend WithEvents txtDeviceID As Wisej.Web.TextBox
    Friend WithEvents Button1 As Wisej.Web.Button
End Class
