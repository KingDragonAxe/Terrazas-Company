Imports System.Drawing.Drawing2D

Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ajustarAnchoTabla()
    End Sub
    Private Sub BotonesMouseEnter(sender As Object, e As EventArgs) Handles pExcel.MouseEnter, pcbExcel.MouseEnter, lbExcel.MouseEnter, pAgregar.MouseEnter, pcbAgregar.MouseEnter, lbAgregar.MouseEnter, pEditar.MouseEnter, pcbEditar.MouseEnter, lbEditar.MouseEnter, pEliminar.MouseEnter, pcbEliminar.MouseEnter, lbEliminar.MouseEnter
        If sender Is pExcel Or sender Is pcbExcel Or sender Is lbExcel Then
            pExcel.BackColor = Color.FromArgb(120, 90, 160)
        ElseIf sender Is pAgregar Or sender Is pcbAgregar Or sender Is lbAgregar Then
            pAgregar.BackColor = Color.FromArgb(170, 85, 170)
        ElseIf sender Is pEditar Or sender Is pcbEditar Or sender Is lbEditar Then
            pEditar.BackColor = Color.FromArgb(120, 90, 160)
        ElseIf sender Is pEliminar Or sender Is pcbEliminar Or sender Is lbEliminar Then
            pEliminar.BackColor = Color.FromArgb(100, 30, 100)
        End If
    End Sub
    Private Sub BotonesMouseLeave(sender As Object, e As EventArgs) Handles pExcel.MouseLeave, pcbExcel.MouseLeave, lbExcel.MouseLeave, pAgregar.MouseLeave, pcbAgregar.MouseLeave, lbAgregar.MouseLeave, pEditar.MouseLeave, pcbEditar.MouseLeave, lbEditar.MouseLeave, pEliminar.MouseLeave, pcbEliminar.MouseLeave, lbEliminar.MouseLeave
        If sender Is pExcel Or sender Is pcbExcel Or sender Is lbExcel Then
            pExcel.BackColor = Color.FromArgb(96, 62, 136)
        ElseIf sender Is pAgregar Or sender Is pcbAgregar Or sender Is lbAgregar Then
            pAgregar.BackColor = Color.Purple
        ElseIf sender Is pEditar Or sender Is pcbEditar Or sender Is lbEditar Then
            pEditar.BackColor = Color.FromArgb(96, 62, 136)
        ElseIf sender Is pEliminar Or sender Is pcbEliminar Or sender Is lbEliminar Then
            pEliminar.BackColor = Color.FromArgb(64, 0, 64)
        End If
    End Sub
    Private Sub BotonesClick(sender As Object, e As EventArgs) Handles pExcel.MouseClick, pcbExcel.MouseClick, lbExcel.MouseClick, pAgregar.MouseClick, pcbAgregar.MouseClick, lbAgregar.MouseClick, pEditar.MouseClick, pcbEditar.MouseClick, lbEditar.MouseClick, pEliminar.MouseClick, pcbEliminar.MouseClick, lbEliminar.MouseClick
        If sender Is pExcel Or sender Is pcbExcel Or sender Is lbExcel Then
            pExcel.BackColor = Color.FromArgb(70, 45, 110)
        ElseIf sender Is pAgregar Or sender Is pcbAgregar Or sender Is lbAgregar Then
            pAgregar.BackColor = Color.FromArgb(90, 0, 90)
            Dim confirmar As New Transparente()
            Dim segunda As New frmCliente
            confirmar.pantalla = segunda
            confirmar.ShowDialog()
        ElseIf sender Is pEditar Or sender Is pcbEditar Or sender Is lbEditar Then
            pEditar.BackColor = Color.FromArgb(70, 45, 110)
            Dim confirmar As New Transparente()
            Dim segunda As New frmCliente
            confirmar.pantalla = segunda
            confirmar.ShowDialog()
        ElseIf sender Is pEliminar Or sender Is pcbEliminar Or sender Is lbEliminar Then
            pEliminar.BackColor = Color.FromArgb(40, 0, 40)
        End If
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
        TamTexto(dgvCliente.ColumnHeadersDefaultCellStyle, "Segoe UI", 15, FontStyle.Bold, tampan, pExcel)
        TamTexto(dgvCliente.RowsDefaultCellStyle, "Arial", 13, FontStyle.Regular, tampan, pExcel)
        TamTexto(dgvCliente.AlternatingRowsDefaultCellStyle, "Arial", 13, FontStyle.Regular, tampan, pExcel)

        'Panel abajo tabla----------------------
        'boton editar 
        TamTexto(lbEditar, "Segoe UI Semibold", 14, FontStyle.Bold, tampan, pExcel)
        pcbEditar.SetBounds(pcbEditar.Location.X, (pEditar.Height - pcbEditar.Height) / 2, pcbEditar.Height, pcbEditar.Height)
        lbEditar.Location = New Point((pEditar.Width - lbEditar.Width + 6) / 2, (pEditar.Height - lbEditar.Height) / 2)
        'boton eliminar
        TamTexto(lbEliminar, "Segoe UI Semibold", 14, FontStyle.Bold, tampan, pExcel)
        pcbEliminar.SetBounds(pcbEliminar.Location.X, (pEliminar.Height - pcbEliminar.Height) / 2, pcbEliminar.Height, pcbEliminar.Height)
        lbEliminar.Location = New Point((pEliminar.Width - lbEliminar.Width + 6) / 2, (pEliminar.Height - lbEliminar.Height) / 2)

    End Sub

    Public Sub ajustarAnchoTabla()
        dgvCliente.ClearSelection()
        dgvCliente.CurrentCell = Nothing

        dgvCliente.RowTemplate.Height = 35
        dgvCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

        dgvCliente.Rows.Add(1, "Cliente", "Juan Pérez Hernández", "8661234501", "Calle Fresno 123", "Activo")
        dgvCliente.Rows.Add(2, "Cliente", "María López Castillo", "8661234502", "Av. Hidalgo 456", "Activo")
        dgvCliente.Rows.Add(3, "Cliente", "Roberto Martínez Cruz", "8661234503", "Calle Roble 321", "Activo")
        dgvCliente.Rows.Add(4, "Cliente", "Fernanda Torres Salinas", "8661234504", "Col. Centro #99", "Activo")
        dgvCliente.Rows.Add(5, "Cliente", "Carlos Ramírez Ortega", "8661234505", "Priv. Encinos 87", "Activo")
        dgvCliente.Rows.Add(6, "Cliente", "Lucía Hernández Rivas", "8661234506", "Calle Abedul 12", "Activo")
        dgvCliente.Rows.Add(7, "Cliente", "Miguel Sánchez Varela", "8661234507", "Paseo del Norte 534", "Activo")
        dgvCliente.Rows.Add(8, "Cliente", "Daniela Campos Nájera", "8661234508", "Calle Olmos 702", "Activo")
        dgvCliente.Rows.Add(9, "Cliente", "Héctor Godínez Soto", "8661234509", "Fracc. Las Lomas 14", "Activo")
        dgvCliente.Rows.Add(10, "Cliente", "Sofía Aguilar Medina", "8661234510", "Calle Pinos 605", "Activo")
        dgvCliente.Rows.Add(11, "Cliente", "Andrea Valdez Juárez", "8661234511", "Av. Universidad 111", "Activo")
        dgvCliente.Rows.Add(12, "Cliente", "Pablo Castañeda Flores", "8661234512", "Blvd. Pape 777", "Activo")
        dgvCliente.Rows.Add(13, "Cliente", "Karina Morales Galván", "8661234513", "Calle Luna 15", "Activo")
        dgvCliente.Rows.Add(14, "Cliente", "Luis Herrera Delgado", "8661234514", "Calle Sol 88", "Activo")
        dgvCliente.Rows.Add(15, "Cliente", "Paola García Reyna", "8661234515", "Col. Industrial 34", "Activo")
        dgvCliente.Rows.Add(16, "Cliente", "José Antonio Ríos", "8661234516", "Calle Vía Rápida 999", "Activo")
        dgvCliente.Rows.Add(17, "Cliente", "Melissa Peña Carrillo", "8661234517", "Cerrada Magnolia 21", "Activo")
        dgvCliente.Rows.Add(18, "Cliente", "Ricardo Fuentes Lara", "8661234518", "Av. Monterrey 223", "Activo")
        dgvCliente.Rows.Add(19, "Cliente", "Diana Juárez Ramírez", "8661234519", "Calle Oro 41", "Activo")
        dgvCliente.Rows.Add(20, "Cliente", "Arturo Medina Lozoya", "8661234520", "Calle Platino 77", "Activo")
        dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvCliente.Columns("IdCliente").FillWeight = 11
        dgvCliente.Columns("Tipo").FillWeight = 10
        dgvCliente.Columns("Estado").FillWeight = 10
        dgvCliente.Columns("Nombre").FillWeight = 30
        dgvCliente.Columns("Telefono").FillWeight = 15
        dgvCliente.Columns("Direccion").FillWeight = 40

    End Sub

End Class
