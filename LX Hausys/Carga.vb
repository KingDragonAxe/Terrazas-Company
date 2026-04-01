Public Class Carga
    Dim pantalla As New Loggin()
    Dim cont As Integer = 0
    Private Sub Carga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pantalla = New Loggin()
        pantalla.Opacity = 0
        pantalla.Show()

        ProgressBar1.Value = 0
        Timer1.Interval = 30
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cont < 200 Then
            cont += 5
            While (ProgressBar1.Value < 100)
                ProgressBar1.Value += 1
            End While
        Else
            Timer1.Stop()
            pantalla.Opacity = 1
            Me.Hide()
        End If
    End Sub
End Class