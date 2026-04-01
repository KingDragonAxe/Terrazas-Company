Imports System.Drawing.Drawing2D

Module Diseno
    Public tampan As Integer = 300
    Public Sub Bordes(panel As Control, radio As Integer)
        Dim grafico As New GraphicsPath()
        Dim r As Integer = radio * 2

        grafico.AddArc(0, 0, r, r, 180, 90)
        grafico.AddArc(panel.Width - r, 0, r, r, 270, 90) 'derecho arriba
        grafico.AddArc(panel.Width - r, panel.Height - r, r, r, 0, 90) 'derecha abajo
        grafico.AddArc(0, panel.Height - r, r, r, 90, 90)
        grafico.CloseFigure()
        panel.Region = New Region(grafico)
    End Sub

    Public Sub TamTexto(Elemento As Object, Tipografia As String, Tam As Integer, Estilo As FontStyle, WidthOriginalPanel As Integer, Panel As Object)
        Dim tamL As Double = 0
        If WidthOriginalPanel > 0 Then
            tamL = Panel.Width / WidthOriginalPanel
        Else
            tamL = 1
        End If

        Dim Texto As Integer = Tam * tamL
        If Texto < 6 Then
            Texto = 6
        End If
        If Texto > 200 Then
            Texto = 200
        End If
        Elemento.Font = New Font(Tipografia, Texto, Estilo)
    End Sub

End Module
