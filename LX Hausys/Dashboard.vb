Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGraficoVentas()
        'Grafica1.Location = New Point(20, 180)
        'Panel1.MinimumSize = New Size(250, 650)
    End Sub
    Private Sub Panel_Resize(sender As Object, e As EventArgs)
        'Grafica3.Location = New Point(Grafica1.Height + 20, Grafica2.Location.Y)
        'Bordes(Panel1, 5)
    End Sub


    Private Sub ConfigurarGraficoVentas()
        Chart5.Series.Clear()
        Chart5.Titles.Clear()
        Chart2.Series.Clear()
        Chart2.Titles.Clear()
        Chart3.Series.Clear()
        Chart3.Titles.Clear()
        Chart4.Series.Clear()
        Chart4.Titles.Clear()
        Dim serieVentas As New Series("Ventas")
        serieVentas.ChartType = SeriesChartType.Pie

        serieVentas.Points.AddXY("Lun", 1200)
        serieVentas.Points.AddXY("Mar", 1800)
        serieVentas.Points.AddXY("Mie", 1500)
        serieVentas.Points.AddXY("Jue", 2200)
        serieVentas.Points.AddXY("Vie", 3000)
        serieVentas.Color = Color.FromArgb(128, 0, 128)

        Chart2.Series.Add(serieVentas)
        Chart2.Titles.Add("Resumen de Ventas Semanales")

        Chart3.Series.Add(serieVentas)
        Chart3.Titles.Add("Resumen de Ventas Semanales")

        Chart4.Series.Add(serieVentas)
        Chart4.Titles.Add("Resumen de Ventas Semanales")

        Chart5.Series.Add(serieVentas)
        Chart5.Titles.Add("Resumen de Ventas Semanales")

    End Sub
End Class
