Imports System.Drawing.Drawing2D
Imports System.IO
Imports Windows.Win32.UI.Input

Public Class Inicio
    Dim Dash As New Dashboard()
    Dim User As New Usuario()
    Dim Mat As New Material
    Dim reporte As New Reportes
    Dim dinero As New Gastos
    Dim cliente As New Clientes
    Dim trabajo As New Trabajos
    Dim proveedor As New Proveedores
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(990, 650)
        cambioContenedor(Dash)
        verificarBtn()
    End Sub
    'Eventos del logo ------------------------------------------------------

    Private Sub LogoPanel_Click(sender As Object, e As EventArgs) Handles LogoPanel.Click, LogoLabel.Click, LogoPicture.Click
        'Contenedor.Controls.Clear()
        'Contenedor.Controls.Remove(Inicio)


        'Panel.SetBounds(0, 80, Me.Width, Me.Height)
        'Contenedor.Controls.Add(Panel)
        'Panel.Show()
        'Contenedor.Controls.Clear()
        'Inicio.SetBounds(0, 80, Me.Width, Me.Height)
        'Contenedor.Controls.Add(Inicio)
        'Inicio.Show()
    End Sub


    Private Sub LogoPanel_MouseLeave(sender As Object, e As EventArgs) Handles LogoPanel.MouseLeave, LogoLabel.MouseLeave, LogoPicture.MouseLeave
        LogoLabel.Font = New Font("Dubai", 18, FontStyle.Bold)
        LogoLabel.ForeColor = Color.White
        LogoLabel.Top = 20
        LogoPicture.Height = 60
        LogoPicture.Width = 62
        LogoPicture.Top = 8
        LogoPicture.Left = 17
    End Sub

    Private Sub LogoPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles LogoPanel.MouseMove, LogoLabel.MouseMove, LogoPicture.MouseMove
        LogoLabel.Font = New Font("Dubai", 19, FontStyle.Bold)
        LogoLabel.Top = 21
        LogoPicture.Height = 65
        LogoPicture.Width = 67
        LogoPicture.Top = 6
        LogoPicture.Left = 16
    End Sub

    Private Sub LogoPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles LogoPanel.MouseClick, LogoLabel.MouseClick, LogoPicture.MouseClick
        'LogoLabel.ForeColor = Color.LightGray
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim pantalla As New Carga()
        Me.Hide()
        pantalla.Show()
    End Sub
    '---------------------------------------------------------

    Private Sub Panel_Resize(sender As Object, e As EventArgs) Handles btnDashBoard.Resize, btnMateriales.Resize, btnGastos.Resize, btnCliente.Resize, btnProveedores.Resize, btnReportes.Resize, btnTrabajos.Resize
        Bordes(btnDashBoard, 10)
        Bordes(btnMateriales, 10)
        Bordes(btnGastos, 10)
        Bordes(btnCliente, 10)
        Bordes(btnProveedores, 10)
        Bordes(btnReportes, 10)
        Bordes(btnTrabajos, 10)

    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        cambioContenedor(User)
    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        cambioContenedor(Dash)
    End Sub
    Private Sub btnMateriales_Click(sender As Object, e As EventArgs) Handles btnMateriales.Click
        cambioContenedor(Mat)
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        cambioContenedor(reporte)
    End Sub

    Private Sub btnGastos_Click(sender As Object, e As EventArgs) Handles btnGastos.Click
        cambioContenedor(dinero)
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        cambioContenedor(cliente)
    End Sub

    Private Sub btnTrabajos_Click(sender As Object, e As EventArgs) Handles btnTrabajos.Click
        cambioContenedor(trabajo)
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        cambioContenedor(proveedor)
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click

    End Sub
    Private Sub cambioContenedor(panel As UserControl)
        If Not Contenedor.Contains(panel) Then
            Contenedor.Controls.Clear()
            panel.Dock = DockStyle.Fill
            Contenedor.Controls.Add(panel)
        End If
        verificarBtn()
    End Sub
    Private Sub verificarBtn()
        Dim gris As Color = Color.WhiteSmoke
        Dim indigo As Color = Color.Indigo
        Dim morado As Color = Color.FromArgb(96, 62, 136)
        If Contenedor.Contains(Dash) Then
            btnDashBoard.BackColor = gris
            btnDashBoard.ForeColor = Color.Black
            btnDashBoard.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\dashboard.png")

            btnUsuario.BackColor = indigo
            btnUsuario.ForeColor = Color.White
            btnUsuario.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\userBlanco.png")
            btnMateriales.BackColor = morado
            btnMateriales.ForeColor = Color.White
            btnMateriales.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\MaterialBlanco.png")
            btnReportes.BackColor = morado
            btnReportes.ForeColor = Color.White
            btnReportes.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\reportBlanco.png")
            btnGastos.BackColor = morado
            btnGastos.ForeColor = Color.White
            btnGastos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\moneyBlanco.png")
            btnCliente.BackColor = morado
            btnCliente.ForeColor = Color.White
            btnCliente.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ClienteBlanco.png")
            btnTrabajos.BackColor = morado
            btnTrabajos.ForeColor = Color.White
            btnTrabajos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\TrabajoBlanco.png")
            btnProveedores.BackColor = morado
            btnProveedores.ForeColor = Color.White
            btnProveedores.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ProveedorBlanco.png")
        ElseIf Contenedor.Contains(User) Then
            btnUsuario.BackColor = gris
            btnUsuario.ForeColor = Color.Black
            btnUsuario.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\user (1).png")

            btnDashBoard.BackColor = morado
            btnDashBoard.ForeColor = Color.White
            btnDashBoard.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\dashboardBlanco.png")
            btnMateriales.BackColor = morado
            btnMateriales.ForeColor = Color.White
            btnMateriales.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\MaterialBlanco.png")
            btnReportes.BackColor = morado
            btnReportes.ForeColor = Color.White
            btnReportes.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\reportBlanco.png")
            btnGastos.BackColor = morado
            btnGastos.ForeColor = Color.White
            btnGastos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\moneyBlanco.png")
            btnCliente.BackColor = morado
            btnCliente.ForeColor = Color.White
            btnCliente.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ClienteBlanco.png")
            btnTrabajos.BackColor = morado
            btnTrabajos.ForeColor = Color.White
            btnTrabajos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\TrabajoBlanco.png")
            btnProveedores.BackColor = morado
            btnProveedores.ForeColor = Color.White
            btnProveedores.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ProveedorBlanco.png")
        ElseIf Contenedor.Contains(Mat) Then
            btnMateriales.BackColor = gris
            btnMateriales.ForeColor = Color.Black
            btnMateriales.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\Material.png")

            btnUsuario.BackColor = Color.Indigo
            btnUsuario.ForeColor = Color.White
            btnUsuario.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\userBlanco.png")
            btnDashBoard.BackColor = morado
            btnDashBoard.ForeColor = Color.White
            btnDashBoard.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\dashboardBlanco.png")
            btnReportes.BackColor = morado
            btnReportes.ForeColor = Color.White
            btnReportes.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\reportBlanco.png")
            btnGastos.BackColor = morado
            btnGastos.ForeColor = Color.White
            btnGastos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\moneyBlanco.png")
            btnCliente.BackColor = morado
            btnCliente.ForeColor = Color.White
            btnCliente.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ClienteBlanco.png")
            btnTrabajos.BackColor = morado
            btnTrabajos.ForeColor = Color.White
            btnTrabajos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\TrabajoBlanco.png")
            btnProveedores.BackColor = morado
            btnProveedores.ForeColor = Color.White
            btnProveedores.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ProveedorBlanco.png")
        ElseIf Contenedor.Contains(reporte) Then
            btnReportes.BackColor = gris
            btnReportes.ForeColor = Color.Black
            btnReportes.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\report.png")

            btnUsuario.BackColor = Color.Indigo
            btnUsuario.ForeColor = Color.White
            btnUsuario.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\userBlanco.png")
            btnDashBoard.BackColor = morado
            btnDashBoard.ForeColor = Color.White
            btnDashBoard.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\dashboardBlanco.png")
            btnGastos.BackColor = morado
            btnGastos.ForeColor = Color.White
            btnGastos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\moneyBlanco.png")
            btnMateriales.BackColor = morado
            btnMateriales.ForeColor = Color.White
            btnMateriales.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\MaterialBlanco.png")
            btnCliente.BackColor = morado
            btnCliente.ForeColor = Color.White
            btnCliente.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ClienteBlanco.png")
            btnTrabajos.BackColor = morado
            btnTrabajos.ForeColor = Color.White
            btnTrabajos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\TrabajoBlanco.png")
            btnProveedores.BackColor = morado
            btnProveedores.ForeColor = Color.White
            btnProveedores.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ProveedorBlanco.png")
        ElseIf Contenedor.Contains(dinero) Then
            btnGastos.BackColor = gris
            btnGastos.ForeColor = Color.Black
            btnGastos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\money.png")

            btnUsuario.BackColor = Color.Indigo
            btnUsuario.ForeColor = Color.White
            btnUsuario.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\userBlanco.png")
            btnDashBoard.BackColor = morado
            btnDashBoard.ForeColor = Color.White
            btnDashBoard.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\dashboardBlanco.png")
            btnMateriales.BackColor = morado
            btnMateriales.ForeColor = Color.White
            btnMateriales.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\MaterialBlanco.png")
            btnCliente.BackColor = morado
            btnCliente.ForeColor = Color.White
            btnCliente.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ClienteBlanco.png")
            btnTrabajos.BackColor = morado
            btnTrabajos.ForeColor = Color.White
            btnTrabajos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\TrabajoBlanco.png")
            btnProveedores.BackColor = morado
            btnProveedores.ForeColor = Color.White
            btnProveedores.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ProveedorBlanco.png")
            btnReportes.BackColor = morado
            btnReportes.ForeColor = Color.White
            btnReportes.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\reportBlanco.png")
        ElseIf Contenedor.Contains(cliente) Then
            btnCliente.BackColor = gris
            btnCliente.ForeColor = Color.Black
            btnCliente.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\cliente.png")

            btnUsuario.BackColor = Color.Indigo
            btnUsuario.ForeColor = Color.White
            btnUsuario.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\userBlanco.png")
            btnDashBoard.BackColor = morado
            btnDashBoard.ForeColor = Color.White
            btnDashBoard.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\dashboardBlanco.png")
            btnMateriales.BackColor = morado
            btnMateriales.ForeColor = Color.White
            btnMateriales.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\MaterialBlanco.png")
            btnTrabajos.BackColor = morado
            btnTrabajos.ForeColor = Color.White
            btnTrabajos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\TrabajoBlanco.png")
            btnProveedores.BackColor = morado
            btnProveedores.ForeColor = Color.White
            btnProveedores.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ProveedorBlanco.png")
            btnReportes.BackColor = morado
            btnReportes.ForeColor = Color.White
            btnReportes.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\reportBlanco.png")
            btnGastos.BackColor = morado
            btnGastos.ForeColor = Color.White
            btnGastos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\moneyBlanco.png")
        ElseIf Contenedor.Contains(trabajo) Then
            btnTrabajos.BackColor = gris
            btnTrabajos.ForeColor = Color.Black
            btnTrabajos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\Trabajo.png")

            btnUsuario.BackColor = Color.Indigo
            btnUsuario.ForeColor = Color.White
            btnUsuario.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\userBlanco.png")
            btnDashBoard.BackColor = morado
            btnDashBoard.ForeColor = Color.White
            btnDashBoard.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\dashboardBlanco.png")
            btnMateriales.BackColor = morado
            btnMateriales.ForeColor = Color.White
            btnMateriales.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\MaterialBlanco.png")
            btnProveedores.BackColor = morado
            btnProveedores.ForeColor = Color.White
            btnProveedores.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ProveedorBlanco.png")
            btnReportes.BackColor = morado
            btnReportes.ForeColor = Color.White
            btnReportes.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\reportBlanco.png")
            btnGastos.BackColor = morado
            btnGastos.ForeColor = Color.White
            btnGastos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\moneyBlanco.png")
            btnCliente.BackColor = morado
            btnCliente.ForeColor = Color.White
            btnCliente.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ClienteBlanco.png")
        ElseIf Contenedor.Contains(proveedor) Then
            btnProveedores.BackColor = gris
            btnProveedores.ForeColor = Color.Black
            btnProveedores.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\Proveedor.png")

            btnUsuario.BackColor = Color.Indigo
            btnUsuario.ForeColor = Color.White
            btnUsuario.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\userBlanco.png")
            btnDashBoard.BackColor = morado
            btnDashBoard.ForeColor = Color.White
            btnDashBoard.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\dashboardBlanco.png")
            btnMateriales.BackColor = morado
            btnMateriales.ForeColor = Color.White
            btnMateriales.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\MaterialBlanco.png")
            btnReportes.BackColor = morado
            btnReportes.ForeColor = Color.White
            btnReportes.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\reportBlanco.png")
            btnGastos.BackColor = morado
            btnGastos.ForeColor = Color.White
            btnGastos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\moneyBlanco.png")
            btnCliente.BackColor = morado
            btnCliente.ForeColor = Color.White
            btnCliente.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\ClienteBlanco.png")
            btnTrabajos.BackColor = morado
            btnTrabajos.ForeColor = Color.White
            btnTrabajos.Image = Image.FromFile("C:\Users\axel_\source\repos\LX Hausys\LX Hausys\Imagenes\TrabajoBlanco.png")
        End If
    End Sub
End Class
