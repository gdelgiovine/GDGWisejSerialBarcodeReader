Imports Wisej.Web
Imports GDGWisejSerialBarcodeReader

Public Class Window2

    Private Sub Window2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Acquisisce il lock esclusivo quando la form diventa attiva
        BarcodeReaderHub.AcquireExclusive(AddressOf OnBarcodeScanned)
    End Sub

    Private Sub Window2_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        ' Rilascia il lock: nessun altro riceverà l'evento in esclusiva
        BarcodeReaderHub.ReleaseExclusive(AddressOf OnBarcodeScanned)
    End Sub

    Private Sub Window2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' Sicurezza: rilascia il lock anche alla chiusura
        BarcodeReaderHub.ReleaseExclusive(AddressOf OnBarcodeScanned)
    End Sub

    Private Sub OnBarcodeScanned(sender As Object, e As BarcodeReader.BarcodeScannedEventArgs)
        Me.txtBarcodeData.Text = e.BarcodeData
    End Sub

End Class
