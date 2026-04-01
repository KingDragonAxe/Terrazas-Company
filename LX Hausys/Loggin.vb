Imports System.Drawing.Drawing2D

Public Class Loggin
    Private cont As Integer
    Dim Inicio As New Inicio()
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bordes(btnCerrar, 7)
        Panelr4.Location = New Point((PanelIzq.Size.Width - Panelr4.Width - 10) / 2, (PanelIzq.Height - Panelr4.Height) / 2)
        pcbUsuario.Location = New Point((PanelInicio.Size.Width - pcbUsuario.Width) / 2, (pcbUsuario.Location.Y))
        pSombraUsuario.Location = New Point((PanelInicio.Size.Width - pSombraUsuario.Width) / 2, (pSombraUsuario.Location.Y))
        pSombraPss.Location = New Point((PanelInicio.Size.Width - pSombraPss.Width) / 2, (pSombraPss.Location.Y))
        cbVer.Location = New Point((PanelInicio.Size.Width - cbVer.Width) / 2, (cbVer.Location.Y))
        lbIniciar.Location = New Point((PanelInicio.Size.Width - lbIniciar.Width) / 2, (lbIniciar.Location.Y))
        Me.MinimumSize = (New Size(940, 860))
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Inicio.Opacity = 0
        Inicio.Show()
        Timer1.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
    Private Sub cbVer_CheckedChanged(sender As Object, e As EventArgs) Handles cbVer.CheckedChanged
        If cbVer.Checked = True Then
            txtPss.PasswordChar = ""
        Else
            txtPss.PasswordChar = "*"
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cont < 10 Then
            cont += 5
        Else
            Timer1.Stop()
            Inicio.Opacity = 1
            Me.Hide()
        End If
    End Sub

End Class