<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyDesktop
    Inherits Wisej.Web.Desktop

    'Overrides dispose to clean up the component list.
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
    'It can be modified using the Wisej Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.txtDeviceID = New Wisej.Web.TextBox()
        Me.txtBarcodeData = New Wisej.Web.TextBox()
        Me.BarcodeReader1 = New GDGWisejSerialBarcodeReader.BarcodeReader()
        Me.SuspendLayout()
        '
        'txtDeviceID
        '
        Me.txtDeviceID.LabelText = "DeviceID"
        Me.txtDeviceID.Location = New System.Drawing.Point(137, 19)
        Me.txtDeviceID.Name = "txtDeviceID"
        Me.txtDeviceID.Size = New System.Drawing.Size(423, 53)
        Me.txtDeviceID.TabIndex = 4
        '
        'txtBarcodeData
        '
        Me.txtBarcodeData.LabelText = "Barcode"
        Me.txtBarcodeData.Location = New System.Drawing.Point(23, 78)
        Me.txtBarcodeData.Name = "txtBarcodeData"
        Me.txtBarcodeData.Size = New System.Drawing.Size(423, 53)
        Me.txtBarcodeData.TabIndex = 5
        '
        'BarcodeReader1
        '
        Me.BarcodeReader1.Location = New System.Drawing.Point(23, 19)
        Me.BarcodeReader1.Name = "BarcodeReader1"
        Me.BarcodeReader1.Size = New System.Drawing.Size(108, 53)
        Me.BarcodeReader1.TabIndex = 6
        Me.BarcodeReader1.UsbProductId = 394
        Me.BarcodeReader1.UsbVendorId = 10473
        '
        'MyDesktop
        '
        Me.Controls.Add(Me.BarcodeReader1)
        Me.Controls.Add(Me.txtBarcodeData)
        Me.Controls.Add(Me.txtDeviceID)
        Me.Name = "MyDesktop"
        Me.Size = New System.Drawing.Size(939, 394)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents txtDeviceID As Wisej.Web.TextBox
    Friend WithEvents txtBarcodeData As Wisej.Web.TextBox
    Friend WithEvents BarcodeReader1 As GDGWisejSerialBarcodeReader.BarcodeReader
End Class
