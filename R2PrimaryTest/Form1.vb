Imports R2CoreFinancialSystem
Imports R2CoreFinancialSystem.AccountsCoding.AccountsCoding

Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            UcViewerNSSAccountCoding1.UCViewNSS(57)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub UcViewerNSSAccountCoding1_UCClickedEvent(UC As UCViewerNSSAccountCoding) Handles UcViewerNSSAccountCoding1.UCClickedEvent
        MessageBox.Show("UcViewerNSSAccountCoding1_UCClickedEvent")
    End Sub

    Private Sub UcViewerNSSAccountCoding1_UCDoubleClickedEvent(UC As UCViewerNSSAccountCoding) Handles UcViewerNSSAccountCoding1.UCRequestHighLevelsEvent
        MessageBox.Show("UCRequestHighLevelsEvent")

    End Sub

    Private Sub UcViewerNSSAccountCoding1_UCTripleClickedEvent(UC As UCViewerNSSAccountCoding) Handles UcViewerNSSAccountCoding1.UCRequestLowLevelsEvent
        MessageBox.Show("UCRequestLowLevelsEvent")

    End Sub
End Class
