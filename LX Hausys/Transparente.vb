Public Class Transparente
    Public pantalla As Form
    Private Sub Transparente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pantalla IsNot Nothing Then
            pantalla.StartPosition = FormStartPosition.CenterScreen
            pantalla.ShowDialog()
            If pantalla.Visible = False Then
                DialogResult = DialogResult.Cancel
                pantalla = Nothing
            End If
        Else
            DialogResult = DialogResult.Cancel
        End If
    End Sub
End Class