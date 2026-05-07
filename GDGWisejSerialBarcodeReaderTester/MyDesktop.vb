Imports System
Imports GDGWisejSerialBarcodeReader
Imports Wisej.Web

Public Class MyDesktop
    Private Sub BarcodeReader1_OnConnect(sender As Object, e As GDGWisejSerialBarcodeReader.BarcodeReader.ConnectEventArgs) Handles BarcodeReader1.OnConnect
        Me.txtDeviceID.Text = e.DeviceID
    End Sub

    Private Sub BarcodeReader1_OnBarcodeScanned(sender As Object, e As GDGWisejSerialBarcodeReader.BarcodeReader.BarcodeScannedEventArgs) Handles BarcodeReader1.OnBarcodeScanned
        Me.txtBarcodeData.Text = e.BarcodeData

        ' Propaga l'evento tramite l'hub centralizzato della libreria
        BarcodeReaderHub.RaiseBarcodeScanned(sender, e)
    End Sub

    Private Sub BarcodeReader1_OnDisconnect(sender As Object, e As GDGWisejSerialBarcodeReader.BarcodeReader.DisconnectEventArgs) Handles BarcodeReader1.OnDisconnect
    End Sub


End Class
