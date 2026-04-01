Imports System.Drawing.Drawing2D

Public Class PanelR
    Inherits Panel
    Private curva As Integer = 10

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        ActualizarPanel()
    End Sub
    Private Sub ActualizarPanel()
        Using path As GraphicsPath = Borde(ClientRectangle, curva)
            Me.Region = New Region(path)
        End Using
    End Sub

    Private Function Borde(Panel As Object, d As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        d = d * 2

        path.StartFigure()
        path.AddArc(Panel.X, Panel.Y, d, d, 180, 90)
        path.AddArc(Panel.Right - d, Panel.Y, d, d, 270, 90)
        path.AddArc(Panel.Right - d, Panel.Bottom - d, d, d, 0, 90)
        path.AddArc(Panel.X, Panel.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function
End Class