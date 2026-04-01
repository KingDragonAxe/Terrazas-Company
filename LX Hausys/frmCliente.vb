Public Class frmCliente
    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bordes(btnAceptar, 5)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class