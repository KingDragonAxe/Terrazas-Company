
Public Class Reportes
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTarjetasContratos()
    End Sub
    Private Sub Clientes_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Panel Norte Titulo------------------------
        pcbLogo.Size = New Size(pcbLogo.Width, pcbLogo.Width)
        TamTexto(lbSubTitulo, "Segoe UI", 10, FontStyle.Regular, tampan, pExcel)
        TamTexto(lbTitulo, "Segoe UI Semibold", 24, FontStyle.Bold, tampan, pExcel)
        'boton excel
        TamTexto(lbExcel, "Segoe UI Semibold", 14, FontStyle.Bold, tampan, pExcel)
        pcbExcel.SetBounds(pcbExcel.Location.X, (pExcel.Height - pcbExcel.Height) / 2, pcbExcel.Height, pcbExcel.Height)
        lbExcel.Location = New Point((pExcel.Width - lbExcel.Width) / 2, (pExcel.Height - lbExcel.Height) / 2)
        'boton agregar
        TamTexto(lbAgregar, "Segoe UI Semibold", 14, FontStyle.Bold, tampan, pExcel)
        pcbAgregar.SetBounds(pcbAgregar.Location.X, (pAgregar.Height - pcbAgregar.Height) / 2, pcbAgregar.Height, pcbAgregar.Height)
        lbAgregar.Location = New Point((pAgregar.Width - lbAgregar.Width) / 2, (pAgregar.Height - lbAgregar.Height) / 2)

        'Panel medio Filtros-------------------
        'buscador
        Panel1.Size = New Size(Panel1.Height + 4, Panel1.Height)
        pcbBuscar.SetBounds((Panel1.Width - pcbBuscar.Height) / 2, ((pBuscar.Height - pcbBuscar.Height) / 2) - 2, pBuscar.Height - 4, pBuscar.Height - 4)
        TamTexto(txtBuscar, "Arial", 16, FontStyle.Regular, tampan, pExcel)
        txtBuscar.SetBounds(txtBuscar.Location.X, (pBuscar.Height - txtBuscar.Height) / 2, txtBuscar.Width, txtBuscar.Height)
        TamTexto(lbBuscar, "Segoe UI Semibold", 10, FontStyle.Bold, tampan, pExcel)
        'Filtro
        pcbFiltro.Size = New Size(pcbFiltro.Width, pcbFiltro.Width)
        TamTexto(lbFiltro, "Segoe UI Semibold", 20, FontStyle.Bold, tampan, pExcel)
        'cmbTipo
        TamTexto(cmbTipo, "Segoe UI", 12, FontStyle.Regular, tampan, pExcel)
        cmbTipo.SetBounds(cmbTipo.Location.X, (pcmbTipo.Height - cmbTipo.Height) / 2, cmbTipo.Width, cmbTipo.Height)
        TamTexto(lbTipo, "Segoe UI Semibold", 10, FontStyle.Bold, tampan, pExcel)
        'cmbRazon
        TamTexto(cmbRS, "Segoe UI", 12, FontStyle.Regular, tampan, pExcel)
        cmbRS.SetBounds(cmbRS.Location.X, (pcmbRS.Height - cmbRS.Height) / 2, cmbRS.Width, cmbRS.Height)
        TamTexto(lbRazonS, "Segoe UI Semibold", 10, FontStyle.Bold, tampan, pExcel)
        'cmbEstado
        TamTexto(cmbEstado, "Segoe UI", 12, FontStyle.Regular, tampan, pExcel)
        cmbEstado.SetBounds(cmbEstado.Location.X, (pcmbEstado.Height - cmbEstado.Height) / 2, cmbEstado.Width, cmbEstado.Height)
        TamTexto(lbEstado, "Segoe UI Semibold", 10, FontStyle.Bold, tampan, pExcel)
    End Sub
    Private Sub BotonesMouseEnter(sender As Object, e As EventArgs) Handles pExcel.MouseEnter, pcbExcel.MouseEnter, lbExcel.MouseEnter, pAgregar.MouseEnter, pcbAgregar.MouseEnter, lbAgregar.MouseEnter
        If sender Is pExcel Or sender Is pcbExcel Or sender Is lbExcel Then
            pExcel.BackColor = Color.FromArgb(120, 90, 160)
        ElseIf sender Is pAgregar Or sender Is pcbAgregar Or sender Is lbAgregar Then
            pAgregar.BackColor = Color.FromArgb(170, 85, 170)
        End If
    End Sub
    Private Sub BotonesMouseLeave(sender As Object, e As EventArgs) Handles pExcel.MouseLeave, pcbExcel.MouseLeave, lbExcel.MouseLeave, pAgregar.MouseLeave, pcbAgregar.MouseLeave, lbAgregar.MouseLeave
        If sender Is pExcel Or sender Is pcbExcel Or sender Is lbExcel Then
            pExcel.BackColor = Color.FromArgb(96, 62, 136)
        ElseIf sender Is pAgregar Or sender Is pcbAgregar Or sender Is lbAgregar Then
            pAgregar.BackColor = Color.Purple
        End If
    End Sub
    Private Sub BotonesClick(sender As Object, e As EventArgs) Handles pExcel.MouseClick, pcbExcel.MouseClick, lbExcel.MouseClick, pAgregar.MouseClick, pcbAgregar.MouseClick, lbAgregar.MouseClick
        If sender Is pExcel Or sender Is pcbExcel Or sender Is lbExcel Then
            pExcel.BackColor = Color.FromArgb(70, 45, 110)
        ElseIf sender Is pAgregar Or sender Is pcbAgregar Or sender Is lbAgregar Then
            pAgregar.BackColor = Color.FromArgb(90, 0, 90)
            Dim confirmar As New Transparente()
            Dim segunda As New frmCliente
            confirmar.pantalla = segunda
            confirmar.ShowDialog()
        End If
    End Sub
    Public Sub CargarTarjetasContratos()
        FlowLayoutPanel1.Controls.Clear()

        For i As Integer = 1 To 40
            Dim tarjeta As New ucContratoTarjeta()
            tarjeta.lbID.Text = i.ToString
            tarjeta.lbMonto.Text = "$ " & (i * 1000).ToString("N2")
            Bordes(tarjeta, 10)
            FlowLayoutPanel1.Controls.Add(tarjeta)
        Next
    End Sub
End Class
