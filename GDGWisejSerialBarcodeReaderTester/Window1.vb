Imports Wisej.Web
Imports GDGWisejSerialBarcodeReader

Public Class Window1
    Private Sub BarcodeReader1_OnConnect(sender As Object, e As GDGWisejSerialBarcodeReader.BarcodeReader.ConnectEventArgs) Handles BarcodeReader1.OnConnect
        Me.txtDeviceID.Text = e.DeviceID
    End Sub

    Private Sub BarcodeReader1_OnBarcodeScanned(sender As Object, e As GDGWisejSerialBarcodeReader.BarcodeReader.BarcodeScannedEventArgs) Handles BarcodeReader1.OnBarcodeScanned
        Me.txtBarcodeData.Text = e.BarcodeData
        Me.txtFullBarcodeData.Text = e.FullBarcodeData
        ' Propaga l'evento tramite l'hub centralizzato della libreria
        BarcodeReaderHub.RaiseBarcodeScanned(sender, e)
    End Sub

    Private Sub BarcodeReader1_OnDisconnect(sender As Object, e As GDGWisejSerialBarcodeReader.BarcodeReader.DisconnectEventArgs) Handles BarcodeReader1.OnDisconnect
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Win2 As New Window2()
        Win2.Show()
    End Sub
End Class
