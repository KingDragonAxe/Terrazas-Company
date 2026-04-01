Public Class Material
    Private Sub Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Material_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Bordes(btnAgregarDerecho, 7)
        Bordes(btnAsignar, 7)
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
        TamTexto(cmbMarca, "Segoe UI", 12, FontStyle.Regular, tampan, pExcel)
        cmbMarca.SetBounds(cmbMarca.Location.X, (pcmbRS.Height - cmbMarca.Height) / 2, cmbMarca.Width, cmbMarca.Height)
        TamTexto(lbMarca, "Segoe UI Semibold", 10, FontStyle.Bold, tampan, pExcel)
        'cmbEstado
        TamTexto(cmbEstado, "Segoe UI", 12, FontStyle.Regular, tampan, pExcel)
        cmbEstado.SetBounds(cmbEstado.Location.X, (pcmbEstado.Height - cmbEstado.Height) / 2, cmbEstado.Width, cmbEstado.Height)
        TamTexto(lbEstado, "Segoe UI Semibold", 10, FontStyle.Bold, tampan, pExcel)
        TamTexto(dgvCliente.ColumnHeadersDefaultCellStyle, "Segoe UI", 15, FontStyle.Bold, tampan, pExcel)
        TamTexto(dgvCliente.RowsDefaultCellStyle, "Arial", 13, FontStyle.Regular, tampan, pExcel)
        TamTexto(dgvCliente.AlternatingRowsDefaultCellStyle, "Arial", 13, FontStyle.Regular, tampan, pExcel)

        'Panel abajo tabla----------------------
        'boton editar 
        TamTexto(lbEditar, "Segoe UI Semibold", 14, FontStyle.Bold, tampan, pExcel)
        pcbEditar.SetBounds(pcbEditar.Location.X, (pEditar.Height - pcbEditar.Height) / 2, pcbEditar.Height, pcbEditar.Height)
        lbEditar.Location = New Point((pEditar.Width - lbEditar.Width + 6) / 2, (pEditar.Height - lbEditar.Height) / 2)

        'Panel derecho 
        'Imagen
        'pcbMaterial.Height = pcbMaterial.Width - 50
        'Texto
        TamTexto(lbTipoMarca, "Arial Rounded MT", 20, FontStyle.Bold, tampan, pExcel)
        TamTexto(lbCantidadUMedidaFechaR, "Arial", 16, FontStyle.Regular, tampan, pExcel)
        TamTexto(lbsubProveedor, "Arial Rounded MT", 18, FontStyle.Bold, tampan, pExcel)
        TamTexto(lbProveedorPrincipal, "Arial", 14, FontStyle.Regular, tampan, pExcel)
        TamTexto(lbsubUltimoUso, "Arial Rounded MT", 18, FontStyle.Bold, tampan, pExcel)
        TamTexto(lbUltimoUso, "Arial", 14, FontStyle.Regular, tampan, pExcel)
        TamTexto(lbsubPrecioVenta, "Arial Rounded MT", 18, FontStyle.Bold, tampan, pExcel)
        TamTexto(lbPrecioVentaUMedida, "Arial", 14, FontStyle.Regular, tampan, pExcel)
        TamTexto(lbDesripcionUltimoUso, "Arial", 15, FontStyle.Regular, tampan, pExcel)
        'Botones
        TamTexto(btnAgregarDerecho, "Segoe UI Semibold", 16, FontStyle.Bold, tampan, pExcel)
        TamTexto(btnAsignar, "Segoe UI Semibold", 16, FontStyle.Bold, tampan, pExcel)
    End Sub
    Private Sub BotonesMouseEnter(sender As Object, e As EventArgs) Handles pExcel.MouseEnter, pcbExcel.MouseEnter, lbExcel.MouseEnter, pAgregar.MouseEnter, pcbAgregar.MouseEnter, lbAgregar.MouseEnter, pEditar.MouseEnter, pcbEditar.MouseEnter, lbEditar.MouseEnter
        If sender Is pExcel Or sender Is pcbExcel Or sender Is lbExcel Then
            pExcel.BackColor = Color.FromArgb(120, 90, 160)
        ElseIf sender Is pAgregar Or sender Is pcbAgregar Or sender Is lbAgregar Then
            pAgregar.BackColor = Color.FromArgb(170, 85, 170)
        ElseIf sender Is pEditar Or sender Is pcbEditar Or sender Is lbEditar Then
            pEditar.BackColor = Color.FromArgb(120, 90, 160)
        End If
    End Sub
    Private Sub BotonesMouseLeave(sender As Object, e As EventArgs) Handles pExcel.MouseLeave, pcbExcel.MouseLeave, lbExcel.MouseLeave, pAgregar.MouseLeave, pcbAgregar.MouseLeave, lbAgregar.MouseLeave, pEditar.MouseLeave, pcbEditar.MouseLeave, lbEditar.MouseLeave
        If sender Is pExcel Or sender Is pcbExcel Or sender Is lbExcel Then
            pExcel.BackColor = Color.FromArgb(96, 62, 136)
        ElseIf sender Is pAgregar Or sender Is pcbAgregar Or sender Is lbAgregar Then
            pAgregar.BackColor = Color.Purple
        ElseIf sender Is pEditar Or sender Is pcbEditar Or sender Is lbEditar Then
            pEditar.BackColor = Color.FromArgb(96, 62, 136)
        End If
    End Sub
    Private Sub BotonesClick(sender As Object, e As EventArgs) Handles pExcel.MouseClick, pcbExcel.MouseClick, lbExcel.MouseClick, pAgregar.MouseClick, pcbAgregar.MouseClick, lbAgregar.MouseClick, pEditar.MouseClick, pcbEditar.MouseClick, lbEditar.MouseClick
        If sender Is pExcel Or sender Is pcbExcel Or sender Is lbExcel Then
            pExcel.BackColor = Color.FromArgb(70, 45, 110)
        ElseIf sender Is pAgregar Or sender Is pcbAgregar Or sender Is lbAgregar Then
            pAgregar.BackColor = Color.FromArgb(90, 0, 90)
            Dim confirmar As New Transparente()
            Dim segunda As New frmMaterial
            confirmar.pantalla = segunda
            confirmar.ShowDialog()
        ElseIf sender Is pEditar Or sender Is pcbEditar Or sender Is lbEditar Then
            pEditar.BackColor = Color.FromArgb(70, 45, 110)
            Dim confirmar As New Transparente()
            Dim segunda As New frmMaterial
            confirmar.pantalla = segunda
            confirmar.ShowDialog()
        End If
    End Sub

    Private Sub btnAgregarDerecho_Click(sender As Object, e As EventArgs) Handles btnAgregarDerecho.Click
        Dim confirmar As New Transparente()
        Dim segunda As New frmMaterial
        confirmar.pantalla = segunda
        confirmar.ShowDialog()
    End Sub
End Class
