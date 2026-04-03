Public Class Proveedores
    Private Sub Proveedores_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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
        'txtDireccion
        TamTexto(txtDireccion, "Segoe UI", 12, FontStyle.Regular, tampan, pExcel)
        txtDireccion.SetBounds(txtDireccion.Location.X, (pcmbTipo.Height - txtDireccion.Height) / 2, txtDireccion.Width, txtDireccion.Height)
        TamTexto(lbDireccion, "Segoe UI Semibold", 10, FontStyle.Bold, tampan, pExcel)
        'cmbRazon
        TamTexto(cmbRS, "Segoe UI", 12, FontStyle.Regular, tampan, pExcel)
        cmbRS.SetBounds(cmbRS.Location.X, (pcmbRS.Height - cmbRS.Height) / 2, cmbRS.Width, cmbRS.Height)
        TamTexto(lbRazonS, "Segoe UI Semibold", 10, FontStyle.Bold, tampan, pExcel)
        'cmbEstado
        TamTexto(cmbEstado, "Segoe UI", 12, FontStyle.Regular, tampan, pExcel)
        cmbEstado.SetBounds(cmbEstado.Location.X, (pcmbEstado.Height - cmbEstado.Height) / 2, cmbEstado.Width, cmbEstado.Height)
        TamTexto(lbEstado, "Segoe UI Semibold", 10, FontStyle.Bold, tampan, pExcel)
        TamTexto(dgvProveedor.ColumnHeadersDefaultCellStyle, "Segoe UI", 15, FontStyle.Bold, tampan, pExcel)
        TamTexto(dgvProveedor.RowsDefaultCellStyle, "Arial", 13, FontStyle.Regular, tampan, pExcel)
        TamTexto(dgvProveedor.AlternatingRowsDefaultCellStyle, "Arial", 13, FontStyle.Regular, tampan, pExcel)

        'Panel abajo tabla----------------------
        'boton correo 
        TamTexto(lbCorreo, "Segoe UI Semibold", 14, FontStyle.Bold, tampan, pExcel)
        pcbCorreo.SetBounds(pcbCorreo.Location.X, (pCorreo.Height - pcbCorreo.Height) / 2, pcbCorreo.Height, pcbCorreo.Height)
        lbCorreo.Location = New Point((pCorreo.Width - lbCorreo.Width + 6) / 2, (pCorreo.Height - lbCorreo.Height) / 2)
        'boton editar 
        TamTexto(lbEditar, "Segoe UI Semibold", 14, FontStyle.Bold, tampan, pExcel)
        pcbEditar.SetBounds(pcbEditar.Location.X, (pEditar.Height - pcbEditar.Height) / 2, pcbEditar.Height, pcbEditar.Height)
        lbEditar.Location = New Point((pEditar.Width - lbEditar.Width + 6) / 2, (pEditar.Height - lbEditar.Height) / 2)
        'boton eliminar
        TamTexto(lbEliminar, "Segoe UI Semibold", 14, FontStyle.Bold, tampan, pExcel)
        pcbEliminar.SetBounds(pcbEliminar.Location.X, (pEliminar.Height - pcbEliminar.Height) / 2, pcbEliminar.Height, pcbEliminar.Height)
        lbEliminar.Location = New Point((pEliminar.Width - lbEliminar.Width + 6) / 2, (pEliminar.Height - lbEliminar.Height) / 2)

    End Sub
    Private Sub BotonesMouseEnter(sender As Object, e As EventArgs) Handles pExcel.MouseEnter, pcbExcel.MouseEnter, lbExcel.MouseEnter, pAgregar.MouseEnter, pcbAgregar.MouseEnter, lbAgregar.MouseEnter, pEditar.MouseEnter, pcbEditar.MouseEnter, lbEditar.MouseEnter, pEliminar.MouseEnter, pcbEliminar.MouseEnter, lbEliminar.MouseEnter, pCorreo.MouseEnter, pcbCorreo.MouseEnter, lbCorreo.MouseEnter
        If sender Is pExcel Or sender Is pcbExcel Or sender Is lbExcel Then
            pExcel.BackColor = Color.FromArgb(120, 90, 160)
        ElseIf sender Is pAgregar Or sender Is pcbAgregar Or sender Is lbAgregar Then
            pAgregar.BackColor = Color.FromArgb(170, 85, 170)
        ElseIf sender Is pEditar Or sender Is pcbEditar Or sender Is lbEditar Then
            pEditar.BackColor = Color.FromArgb(170, 85, 170)
        ElseIf sender Is pEliminar Or sender Is pcbEliminar Or sender Is lbEliminar Then
            pEliminar.BackColor = Color.FromArgb(100, 30, 100)
        ElseIf sender Is pCorreo Or sender Is pcbCorreo Or sender Is lbCorreo Then
            pCorreo.BackColor = Color.FromArgb(120, 90, 160)
        End If
    End Sub
    Private Sub BotonesMouseLeave(sender As Object, e As EventArgs) Handles pExcel.MouseLeave, pcbExcel.MouseLeave, lbExcel.MouseLeave, pAgregar.MouseLeave, pcbAgregar.MouseLeave, lbAgregar.MouseLeave, pEditar.MouseLeave, pcbEditar.MouseLeave, lbEditar.MouseLeave, pEliminar.MouseLeave, pcbEliminar.MouseLeave, lbEliminar.MouseLeave, pCorreo.MouseLeave, pcbCorreo.MouseLeave, lbCorreo.MouseLeave
        If sender Is pExcel Or sender Is pcbExcel Or sender Is lbExcel Then
            pExcel.BackColor = Color.FromArgb(96, 62, 136)
        ElseIf sender Is pAgregar Or sender Is pcbAgregar Or sender Is lbAgregar Then
            pAgregar.BackColor = Color.Purple
        ElseIf sender Is pEditar Or sender Is pcbEditar Or sender Is lbEditar Then
            pEditar.BackColor = Color.Purple
        ElseIf sender Is pEliminar Or sender Is pcbEliminar Or sender Is lbEliminar Then
            pEliminar.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender Is pCorreo Or sender Is pcbCorreo Or sender Is lbCorreo Then
            pCorreo.BackColor = Color.FromArgb(96, 62, 136)
        End If
    End Sub
    Private Sub BotonesClick(sender As Object, e As EventArgs) Handles pExcel.MouseClick, pcbExcel.MouseClick, lbExcel.MouseClick, pAgregar.MouseClick, pcbAgregar.MouseClick, lbAgregar.MouseClick, pEditar.MouseClick, pcbEditar.MouseClick, lbEditar.MouseClick, pEliminar.MouseClick, pcbEliminar.MouseClick, lbEliminar.MouseClick, pCorreo.MouseClick, pcbCorreo.MouseClick, lbCorreo.MouseClick
        If sender Is pExcel Or sender Is pcbExcel Or sender Is lbExcel Then
            pExcel.BackColor = Color.FromArgb(70, 45, 110)
        ElseIf sender Is pAgregar Or sender Is pcbAgregar Or sender Is lbAgregar Then
            pAgregar.BackColor = Color.FromArgb(90, 0, 90)
            Dim confirmar As New Transparente
            Dim segunda As New frmProveedores
            confirmar.pantalla = segunda
            confirmar.ShowDialog()
        ElseIf sender Is pEditar Or sender Is pcbEditar Or sender Is lbEditar Then
            pEditar.BackColor = Color.FromArgb(90, 0, 90)
            Dim confirmar As New Transparente
            Dim segunda As New frmProveedores
            confirmar.pantalla = segunda
            confirmar.ShowDialog()
        ElseIf sender Is pEliminar Or sender Is pcbEliminar Or sender Is lbEliminar Then
            pEliminar.BackColor = Color.FromArgb(40, 0, 40)
        ElseIf sender Is pCorreo Or sender Is pcbCorreo Or sender Is lbCorreo Then
            pCorreo.BackColor = Color.FromArgb(70, 45, 110)
            Dim confirmar As New Transparente
            Dim segunda As New frmCorreo
            confirmar.pantalla = segunda
            confirmar.ShowDialog()
        End If
    End Sub
End Class
