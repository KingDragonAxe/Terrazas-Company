Public Class opConfirmar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub opConfirmar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbVerificacion.Location = New Point((Panelr1.Width - lbVerificacion.Width) \ 2, lbVerificacion.Location.Y)
        panelNorte.Location = New Point((Panelr1.Width - panelNorte.Width - 5) \ 2, panelNorte.Location.Y)
        panelCentro.Location = New Point((Panelr1.Width - panelCentro.Width - 5) \ 2, panelCentro.Location.Y)
        panelBotones.Location = New Point((Panelr1.Width - panelBotones.Width - 5) \ 2, panelBotones.Location.Y)
    End Sub

    Private Sub Panelr2_Paint(sender As Object, e As PaintEventArgs) Handles Panelr2.Paint

    End Sub
End Class