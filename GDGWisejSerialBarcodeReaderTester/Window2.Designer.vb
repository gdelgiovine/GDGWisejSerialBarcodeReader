<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window2
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej.NET Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej.NET Designer
    'It can be modified using the Wisej.NET Designer.
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.txtBarcodeData = New Wisej.Web.TextBox()
        Me.TextBox1 = New Wisej.Web.TextBox()
        Me.Button1 = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'txtBarcodeData
        '
        Me.txtBarcodeData.LabelText = "Barcode"
        Me.txtBarcodeData.Location = New System.Drawing.Point(12, 7)
        Me.txtBarcodeData.Name = "txtBarcodeData"
        Me.txtBarcodeData.Size = New System.Drawing.Size(423, 53)
        Me.txtBarcodeData.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.LabelText = "Text "
        Me.TextBox1.Location = New System.Drawing.Point(12, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(423, 53)
        Me.TextBox1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(335, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ok"
        '
        'Window2
        '
        Me.ClientSize = New System.Drawing.Size(451, 160)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtBarcodeData)
        Me.Name = "Window2"
        Me.Text = "Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBarcodeData As Wisej.Web.TextBox
    Friend WithEvents TextBox1 As Wisej.Web.TextBox
    Friend WithEvents Button1 As Wisej.Web.Button
End Class
