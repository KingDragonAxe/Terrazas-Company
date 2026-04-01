<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        pSombraNorte = New PanelR()
        PanelInformacion = New PanelR()
        tlpInformacion = New TableLayoutPanel()
        pbFoto = New PictureBox()
        btnFoto = New Button()
        lbPuesto = New Label()
        lbLetreroPuesto = New Label()
        lbNomCompleto = New Label()
        lbInformacion = New Label()
        lbLetreroFR = New Label()
        lbFechaRegistro = New Label()
        lbLetreroNombre = New Label()
        Panelr3 = New PanelR()
        panelDatos = New PanelR()
        TableLayoutPanel3 = New TableLayoutPanel()
        lbDatos = New Label()
        btnActualizar = New Button()
        lbNombre = New Label()
        txtNombre = New TextBox()
        lbEdad = New Label()
        txtEdad = New TextBox()
        lbApp = New Label()
        txtApp = New TextBox()
        txtTelefono = New TextBox()
        lbTelefono = New Label()
        lbApm = New Label()
        txtApm = New TextBox()
        lbDireccion = New Label()
        txtDireccion = New TextBox()
        btnCancelar = New Button()
        btnGuardar = New Button()
        PSombraSeguridad = New PanelR()
        PanelSeguridad = New PanelR()
        tbpSeguridad = New TableLayoutPanel()
        btnHide = New Button()
        btnVer = New Button()
        lbSeguridad = New Label()
        txtPss = New TextBox()
        lbCorreo = New Label()
        txtCorreo = New TextBox()
        lbPss = New Label()
        btnSave = New Button()
        btnSee = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panelr5 = New PanelR()
        PictureBox1 = New PictureBox()
        btnCambiarCuenta = New Button()
        TableLayoutPanel5 = New TableLayoutPanel()
        Panelr4 = New PanelR()
        PictureBox2 = New PictureBox()
        btnEstadistica = New Button()
        TableLayoutPanel1.SuspendLayout()
        pSombraNorte.SuspendLayout()
        PanelInformacion.SuspendLayout()
        tlpInformacion.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        Panelr3.SuspendLayout()
        panelDatos.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        PSombraSeguridad.SuspendLayout()
        PanelSeguridad.SuspendLayout()
        tbpSeguridad.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panelr5.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel5.SuspendLayout()
        Panelr4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.WhiteSmoke
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(pSombraNorte, 0, 0)
        TableLayoutPanel1.Controls.Add(Panelr3, 0, 1)
        TableLayoutPanel1.Controls.Add(PSombraSeguridad, 0, 2)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(50, 20, 50, 20)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 26.31579F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 36.8421059F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 36.8421059F))
        TableLayoutPanel1.Size = New Size(1720, 1080)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' pSombraNorte
        ' 
        pSombraNorte.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pSombraNorte.BackColor = SystemColors.ButtonFace
        pSombraNorte.Controls.Add(PanelInformacion)
        pSombraNorte.Location = New Point(80, 25)
        pSombraNorte.Margin = New Padding(80, 25, 80, 15)
        pSombraNorte.Name = "pSombraNorte"
        pSombraNorte.Size = New Size(1560, 244)
        pSombraNorte.TabIndex = 0
        ' 
        ' PanelInformacion
        ' 
        PanelInformacion.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelInformacion.BackColor = Color.White
        PanelInformacion.Controls.Add(tlpInformacion)
        PanelInformacion.Location = New Point(2, 2)
        PanelInformacion.Name = "PanelInformacion"
        PanelInformacion.Size = New Size(1554, 238)
        PanelInformacion.TabIndex = 7
        ' 
        ' tlpInformacion
        ' 
        tlpInformacion.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tlpInformacion.BackColor = Color.Transparent
        tlpInformacion.ColumnCount = 6
        tlpInformacion.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.0452728F))
        tlpInformacion.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 2.8608582F))
        tlpInformacion.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.836151F))
        tlpInformacion.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 32.7563248F))
        tlpInformacion.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.1744347F))
        tlpInformacion.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.2330227F))
        tlpInformacion.Controls.Add(pbFoto, 0, 0)
        tlpInformacion.Controls.Add(btnFoto, 1, 2)
        tlpInformacion.Controls.Add(lbPuesto, 4, 2)
        tlpInformacion.Controls.Add(lbLetreroPuesto, 4, 1)
        tlpInformacion.Controls.Add(lbNomCompleto, 3, 2)
        tlpInformacion.Controls.Add(lbInformacion, 3, 0)
        tlpInformacion.Controls.Add(lbLetreroFR, 5, 1)
        tlpInformacion.Controls.Add(lbFechaRegistro, 5, 2)
        tlpInformacion.Controls.Add(lbLetreroNombre, 3, 1)
        tlpInformacion.Location = New Point(0, 0)
        tlpInformacion.Name = "tlpInformacion"
        tlpInformacion.RowCount = 3
        tlpInformacion.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0904713F))
        tlpInformacion.RowStyles.Add(New RowStyle(SizeType.Percent, 21.4653034F))
        tlpInformacion.RowStyles.Add(New RowStyle(SizeType.Percent, 53.44423F))
        tlpInformacion.Size = New Size(1553, 235)
        tlpInformacion.TabIndex = 6
        ' 
        ' pbFoto
        ' 
        pbFoto.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pbFoto.BackgroundImage = My.Resources.Resources.ui_user_profile_avatar_person_icon_208734
        pbFoto.BackgroundImageLayout = ImageLayout.Stretch
        pbFoto.BorderStyle = BorderStyle.FixedSingle
        pbFoto.Location = New Point(40, 20)
        pbFoto.Margin = New Padding(40, 20, 0, 20)
        pbFoto.Name = "pbFoto"
        tlpInformacion.SetRowSpan(pbFoto, 3)
        pbFoto.Size = New Size(209, 182)
        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' btnFoto
        ' 
        btnFoto.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnFoto.AutoSize = True
        btnFoto.BackgroundImage = My.Resources.Resources.camera
        btnFoto.BackgroundImageLayout = ImageLayout.Stretch
        btnFoto.Location = New Point(249, 118)
        btnFoto.Margin = New Padding(0, 10, 0, 0)
        btnFoto.Name = "btnFoto"
        btnFoto.Size = New Size(44, 44)
        btnFoto.TabIndex = 2
        btnFoto.UseVisualStyleBackColor = True
        ' 
        ' lbPuesto
        ' 
        lbPuesto.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbPuesto.AutoSize = True
        lbPuesto.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbPuesto.Location = New Point(881, 108)
        lbPuesto.Margin = New Padding(20, 0, 0, 0)
        lbPuesto.Name = "lbPuesto"
        lbPuesto.Size = New Size(278, 127)
        lbPuesto.TabIndex = 5
        lbPuesto.Text = "Lider"
        ' 
        ' lbLetreroPuesto
        ' 
        lbLetreroPuesto.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbLetreroPuesto.AutoSize = True
        lbLetreroPuesto.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbLetreroPuesto.Location = New Point(861, 58)
        lbLetreroPuesto.Margin = New Padding(0)
        lbLetreroPuesto.Name = "lbLetreroPuesto"
        lbLetreroPuesto.Size = New Size(298, 50)
        lbLetreroPuesto.TabIndex = 4
        lbLetreroPuesto.Text = "Puesto:"
        lbLetreroPuesto.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lbNomCompleto
        ' 
        lbNomCompleto.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbNomCompleto.AutoSize = True
        lbNomCompleto.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbNomCompleto.Location = New Point(382, 108)
        lbNomCompleto.Margin = New Padding(30, 0, 0, 0)
        lbNomCompleto.Name = "lbNomCompleto"
        lbNomCompleto.Size = New Size(479, 127)
        lbNomCompleto.TabIndex = 3
        lbNomCompleto.Text = "Axel Gabriel Sifuentes Hernandez"
        ' 
        ' lbInformacion
        ' 
        lbInformacion.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbInformacion.AutoSize = True
        lbInformacion.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbInformacion.Location = New Point(352, 10)
        lbInformacion.Margin = New Padding(0, 10, 0, 0)
        lbInformacion.Name = "lbInformacion"
        lbInformacion.Size = New Size(509, 48)
        lbInformacion.TabIndex = 1
        lbInformacion.Text = "Informacion:"
        ' 
        ' lbLetreroFR
        ' 
        lbLetreroFR.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbLetreroFR.AutoSize = True
        lbLetreroFR.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbLetreroFR.Location = New Point(1159, 58)
        lbLetreroFR.Margin = New Padding(0)
        lbLetreroFR.Name = "lbLetreroFR"
        lbLetreroFR.Size = New Size(394, 50)
        lbLetreroFR.TabIndex = 8
        lbLetreroFR.Text = "Fecha de Registro:"
        lbLetreroFR.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lbFechaRegistro
        ' 
        lbFechaRegistro.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbFechaRegistro.AutoSize = True
        lbFechaRegistro.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbFechaRegistro.Location = New Point(1179, 108)
        lbFechaRegistro.Margin = New Padding(20, 0, 0, 0)
        lbFechaRegistro.Name = "lbFechaRegistro"
        lbFechaRegistro.Size = New Size(374, 127)
        lbFechaRegistro.TabIndex = 9
        lbFechaRegistro.Text = "13 / 03 / 2026"
        ' 
        ' lbLetreroNombre
        ' 
        lbLetreroNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbLetreroNombre.AutoSize = True
        lbLetreroNombre.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbLetreroNombre.Location = New Point(362, 58)
        lbLetreroNombre.Margin = New Padding(10, 0, 0, 0)
        lbLetreroNombre.Name = "lbLetreroNombre"
        lbLetreroNombre.Size = New Size(499, 50)
        lbLetreroNombre.TabIndex = 6
        lbLetreroNombre.Text = "Bienvenido:"
        lbLetreroNombre.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panelr3
        ' 
        Panelr3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr3.BackColor = SystemColors.ButtonFace
        Panelr3.Controls.Add(panelDatos)
        Panelr3.Location = New Point(80, 300)
        Panelr3.Margin = New Padding(80, 16, 80, 15)
        Panelr3.Name = "Panelr3"
        Panelr3.Size = New Size(1560, 366)
        Panelr3.TabIndex = 1
        ' 
        ' panelDatos
        ' 
        panelDatos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelDatos.BackColor = Color.White
        panelDatos.Controls.Add(TableLayoutPanel3)
        panelDatos.Location = New Point(2, 2)
        panelDatos.Name = "panelDatos"
        panelDatos.Size = New Size(1554, 360)
        panelDatos.TabIndex = 20
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 6
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.5525227F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.5525322F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.5525322F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.5525322F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.277453F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.05393124F))
        TableLayoutPanel3.Controls.Add(lbDatos, 0, 0)
        TableLayoutPanel3.Controls.Add(btnActualizar, 5, 0)
        TableLayoutPanel3.Controls.Add(lbNombre, 0, 1)
        TableLayoutPanel3.Controls.Add(txtNombre, 1, 1)
        TableLayoutPanel3.Controls.Add(lbEdad, 2, 1)
        TableLayoutPanel3.Controls.Add(txtEdad, 3, 1)
        TableLayoutPanel3.Controls.Add(lbApp, 0, 2)
        TableLayoutPanel3.Controls.Add(txtApp, 1, 2)
        TableLayoutPanel3.Controls.Add(txtTelefono, 3, 2)
        TableLayoutPanel3.Controls.Add(lbTelefono, 2, 2)
        TableLayoutPanel3.Controls.Add(lbApm, 0, 3)
        TableLayoutPanel3.Controls.Add(txtApm, 1, 3)
        TableLayoutPanel3.Controls.Add(lbDireccion, 2, 3)
        TableLayoutPanel3.Controls.Add(txtDireccion, 3, 3)
        TableLayoutPanel3.Controls.Add(btnCancelar, 5, 3)
        TableLayoutPanel3.Controls.Add(btnGuardar, 5, 2)
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 4
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 18.9599438F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 27.42894F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 26.80556F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 26.80556F))
        TableLayoutPanel3.Size = New Size(1538, 360)
        TableLayoutPanel3.TabIndex = 19
        ' 
        ' lbDatos
        ' 
        lbDatos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbDatos.AutoSize = True
        lbDatos.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbDatos.Location = New Point(20, 10)
        lbDatos.Margin = New Padding(20, 10, 0, 0)
        lbDatos.Name = "lbDatos"
        lbDatos.Size = New Size(324, 58)
        lbDatos.TabIndex = 6
        lbDatos.Text = "Datos:"
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnActualizar.BackgroundImage = My.Resources.Resources.edit
        btnActualizar.BackgroundImageLayout = ImageLayout.Stretch
        btnActualizar.Location = New Point(1487, 20)
        btnActualizar.Margin = New Padding(0, 20, 0, 0)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(51, 48)
        btnActualizar.TabIndex = 6
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' lbNombre
        ' 
        lbNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbNombre.AutoSize = True
        lbNombre.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbNombre.Location = New Point(20, 78)
        lbNombre.Margin = New Padding(20, 10, 0, 0)
        lbNombre.Name = "lbNombre"
        lbNombre.Size = New Size(324, 88)
        lbNombre.TabIndex = 7
        lbNombre.Text = "Nombre:"
        lbNombre.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.BorderStyle = BorderStyle.FixedSingle
        txtNombre.Enabled = False
        txtNombre.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNombre.Location = New Point(347, 71)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(338, 35)
        txtNombre.TabIndex = 0
        txtNombre.Text = "Axel Gabriel"
        ' 
        ' lbEdad
        ' 
        lbEdad.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbEdad.AutoSize = True
        lbEdad.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbEdad.Location = New Point(708, 78)
        lbEdad.Margin = New Padding(20, 10, 0, 0)
        lbEdad.Name = "lbEdad"
        lbEdad.Size = New Size(324, 88)
        lbEdad.TabIndex = 13
        lbEdad.Text = "Edad:"
        lbEdad.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtEdad
        ' 
        txtEdad.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtEdad.BorderStyle = BorderStyle.FixedSingle
        txtEdad.Enabled = False
        txtEdad.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEdad.Location = New Point(1035, 71)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(338, 35)
        txtEdad.TabIndex = 3
        txtEdad.Text = "21"
        ' 
        ' lbApp
        ' 
        lbApp.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbApp.AutoSize = True
        lbApp.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbApp.Location = New Point(20, 176)
        lbApp.Margin = New Padding(20, 10, 0, 0)
        lbApp.Name = "lbApp"
        lbApp.Size = New Size(324, 86)
        lbApp.TabIndex = 8
        lbApp.Text = "Apellido Paterno:"
        lbApp.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtApp
        ' 
        txtApp.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtApp.BorderStyle = BorderStyle.FixedSingle
        txtApp.Enabled = False
        txtApp.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtApp.Location = New Point(347, 169)
        txtApp.Name = "txtApp"
        txtApp.Size = New Size(338, 35)
        txtApp.TabIndex = 1
        txtApp.Text = "Sifuentes"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtTelefono.BorderStyle = BorderStyle.FixedSingle
        txtTelefono.Enabled = False
        txtTelefono.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTelefono.Location = New Point(1035, 169)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(338, 35)
        txtTelefono.TabIndex = 4
        txtTelefono.Text = "866-236-53-86"
        ' 
        ' lbTelefono
        ' 
        lbTelefono.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbTelefono.AutoSize = True
        lbTelefono.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbTelefono.Location = New Point(708, 176)
        lbTelefono.Margin = New Padding(20, 10, 0, 0)
        lbTelefono.Name = "lbTelefono"
        lbTelefono.Size = New Size(324, 86)
        lbTelefono.TabIndex = 14
        lbTelefono.Text = "Telefono:"
        lbTelefono.TextAlign = ContentAlignment.TopRight
        ' 
        ' lbApm
        ' 
        lbApm.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbApm.AutoSize = True
        lbApm.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbApm.Location = New Point(20, 272)
        lbApm.Margin = New Padding(20, 10, 0, 0)
        lbApm.Name = "lbApm"
        lbApm.Size = New Size(324, 88)
        lbApm.TabIndex = 9
        lbApm.Text = "Apellido Materno:"
        lbApm.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtApm
        ' 
        txtApm.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtApm.BorderStyle = BorderStyle.FixedSingle
        txtApm.Enabled = False
        txtApm.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtApm.Location = New Point(347, 265)
        txtApm.Name = "txtApm"
        txtApm.Size = New Size(338, 35)
        txtApm.TabIndex = 2
        txtApm.Text = "Hernandez"
        ' 
        ' lbDireccion
        ' 
        lbDireccion.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbDireccion.AutoSize = True
        lbDireccion.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbDireccion.Location = New Point(708, 272)
        lbDireccion.Margin = New Padding(20, 10, 0, 0)
        lbDireccion.Name = "lbDireccion"
        lbDireccion.Size = New Size(324, 88)
        lbDireccion.TabIndex = 15
        lbDireccion.Text = "Direccion:"
        lbDireccion.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtDireccion.BorderStyle = BorderStyle.FixedSingle
        txtDireccion.Enabled = False
        txtDireccion.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDireccion.Location = New Point(1035, 265)
        txtDireccion.Margin = New Padding(3, 3, 3, 10)
        txtDireccion.Multiline = True
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(338, 85)
        txtDireccion.TabIndex = 5
        txtDireccion.Text = "Indios Naturales #1237, " & vbCrLf & "Colonia obrera, 25790"
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnCancelar.BackColor = Color.White
        btnCancelar.BackgroundImageLayout = ImageLayout.Stretch
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelar.ForeColor = Color.Red
        btnCancelar.Location = New Point(1487, 272)
        btnCancelar.Margin = New Padding(0, 10, 0, 0)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(51, 48)
        btnCancelar.TabIndex = 20
        btnCancelar.Text = "X"
        btnCancelar.UseVisualStyleBackColor = False
        btnCancelar.Visible = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnGuardar.BackColor = Color.MintCream
        btnGuardar.BackgroundImage = My.Resources.Resources.down
        btnGuardar.BackgroundImageLayout = ImageLayout.Stretch
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.Location = New Point(1487, 176)
        btnGuardar.Margin = New Padding(0, 10, 0, 0)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(51, 48)
        btnGuardar.TabIndex = 19
        btnGuardar.UseVisualStyleBackColor = False
        btnGuardar.Visible = False
        ' 
        ' PSombraSeguridad
        ' 
        PSombraSeguridad.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PSombraSeguridad.BackColor = SystemColors.ButtonFace
        PSombraSeguridad.Controls.Add(PanelSeguridad)
        PSombraSeguridad.Location = New Point(80, 696)
        PSombraSeguridad.Margin = New Padding(80, 15, 80, 25)
        PSombraSeguridad.Name = "PSombraSeguridad"
        PSombraSeguridad.Size = New Size(1560, 359)
        PSombraSeguridad.TabIndex = 2
        ' 
        ' PanelSeguridad
        ' 
        PanelSeguridad.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelSeguridad.BackColor = Color.White
        PanelSeguridad.Controls.Add(tbpSeguridad)
        PanelSeguridad.Location = New Point(2, 2)
        PanelSeguridad.Name = "PanelSeguridad"
        PanelSeguridad.Size = New Size(1554, 353)
        PanelSeguridad.TabIndex = 24
        ' 
        ' tbpSeguridad
        ' 
        tbpSeguridad.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbpSeguridad.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tbpSeguridad.ColumnCount = 5
        tbpSeguridad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.5697908F))
        tbpSeguridad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 31.7202911F))
        tbpSeguridad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.585124F))
        tbpSeguridad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 36.2703323F))
        tbpSeguridad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 2.85446215F))
        tbpSeguridad.Controls.Add(btnHide, 4, 4)
        tbpSeguridad.Controls.Add(btnVer, 4, 0)
        tbpSeguridad.Controls.Add(lbSeguridad, 0, 0)
        tbpSeguridad.Controls.Add(txtPss, 3, 1)
        tbpSeguridad.Controls.Add(lbCorreo, 0, 1)
        tbpSeguridad.Controls.Add(txtCorreo, 1, 1)
        tbpSeguridad.Controls.Add(lbPss, 2, 1)
        tbpSeguridad.Controls.Add(btnSave, 4, 3)
        tbpSeguridad.Controls.Add(btnSee, 4, 1)
        tbpSeguridad.Controls.Add(TableLayoutPanel2, 3, 4)
        tbpSeguridad.Controls.Add(TableLayoutPanel5, 1, 4)
        tbpSeguridad.Location = New Point(0, 0)
        tbpSeguridad.Name = "tbpSeguridad"
        tbpSeguridad.RowCount = 6
        tbpSeguridad.RowStyles.Add(New RowStyle(SizeType.Percent, 18.4544182F))
        tbpSeguridad.RowStyles.Add(New RowStyle(SizeType.Percent, 18.7298584F))
        tbpSeguridad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.3947582F))
        tbpSeguridad.RowStyles.Add(New RowStyle(SizeType.Percent, 16.5263481F))
        tbpSeguridad.RowStyles.Add(New RowStyle(SizeType.Percent, 25.4909916F))
        tbpSeguridad.RowStyles.Add(New RowStyle(SizeType.Percent, 8.403624F))
        tbpSeguridad.Size = New Size(1539, 353)
        tbpSeguridad.TabIndex = 23
        ' 
        ' btnHide
        ' 
        btnHide.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnHide.BackColor = Color.White
        btnHide.BackgroundImageLayout = ImageLayout.Stretch
        btnHide.FlatAppearance.BorderSize = 0
        btnHide.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHide.ForeColor = Color.Red
        btnHide.Location = New Point(1494, 242)
        btnHide.Margin = New Padding(0, 10, 0, 0)
        btnHide.Name = "btnHide"
        btnHide.Size = New Size(45, 46)
        btnHide.TabIndex = 21
        btnHide.Text = "X"
        btnHide.UseVisualStyleBackColor = False
        btnHide.Visible = False
        ' 
        ' btnVer
        ' 
        btnVer.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnVer.BackgroundImage = My.Resources.Resources.hide
        btnVer.BackgroundImageLayout = ImageLayout.Stretch
        btnVer.Location = New Point(1494, 20)
        btnVer.Margin = New Padding(0, 20, 0, 0)
        btnVer.Name = "btnVer"
        btnVer.Size = New Size(45, 45)
        btnVer.TabIndex = 21
        btnVer.UseVisualStyleBackColor = True
        ' 
        ' lbSeguridad
        ' 
        lbSeguridad.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbSeguridad.AutoSize = True
        lbSeguridad.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbSeguridad.Location = New Point(20, 10)
        lbSeguridad.Margin = New Padding(20, 10, 0, 0)
        lbSeguridad.Name = "lbSeguridad"
        lbSeguridad.Size = New Size(219, 55)
        lbSeguridad.TabIndex = 13
        lbSeguridad.Text = "Seguridad:"
        ' 
        ' txtPss
        ' 
        txtPss.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtPss.BorderStyle = BorderStyle.FixedSingle
        txtPss.Enabled = False
        txtPss.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPss.Location = New Point(939, 68)
        txtPss.Name = "txtPss"
        txtPss.PasswordChar = "*"c
        txtPss.Size = New Size(552, 35)
        txtPss.TabIndex = 1
        txtPss.Text = "gsdfgg"
        ' 
        ' lbCorreo
        ' 
        lbCorreo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbCorreo.AutoSize = True
        lbCorreo.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbCorreo.Location = New Point(20, 75)
        lbCorreo.Margin = New Padding(20, 10, 0, 0)
        lbCorreo.Name = "lbCorreo"
        lbCorreo.Size = New Size(219, 56)
        lbCorreo.TabIndex = 19
        lbCorreo.Text = "Correo:"
        lbCorreo.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtCorreo.BorderStyle = BorderStyle.FixedSingle
        txtCorreo.Enabled = False
        txtCorreo.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCorreo.Location = New Point(242, 68)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.PasswordChar = "*"c
        txtCorreo.Size = New Size(482, 35)
        txtCorreo.TabIndex = 0
        txtCorreo.Text = "sggad"
        ' 
        ' lbPss
        ' 
        lbPss.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbPss.AutoSize = True
        lbPss.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbPss.Location = New Point(747, 75)
        lbPss.Margin = New Padding(20, 10, 0, 0)
        lbPss.Name = "lbPss"
        lbPss.Size = New Size(189, 56)
        lbPss.TabIndex = 21
        lbPss.Text = "Contraseña:"
        lbPss.TextAlign = ContentAlignment.TopRight
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnSave.BackColor = Color.MintCream
        btnSave.BackgroundImage = My.Resources.Resources.down
        btnSave.BackgroundImageLayout = ImageLayout.Stretch
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.Location = New Point(1494, 184)
        btnSave.Margin = New Padding(0, 10, 0, 0)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(45, 46)
        btnSave.TabIndex = 21
        btnSave.UseVisualStyleBackColor = False
        btnSave.Visible = False
        ' 
        ' btnSee
        ' 
        btnSee.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnSee.BackgroundImage = My.Resources.Resources.edit
        btnSee.BackgroundImageLayout = ImageLayout.Stretch
        btnSee.Location = New Point(1494, 85)
        btnSee.Margin = New Padding(0, 20, 0, 0)
        btnSee.Name = "btnSee"
        btnSee.Size = New Size(45, 46)
        btnSee.TabIndex = 21
        btnSee.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Panelr5, 0, 0)
        TableLayoutPanel2.Location = New Point(939, 235)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 71.0843353F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 28.9156628F))
        TableLayoutPanel2.Size = New Size(552, 83)
        TableLayoutPanel2.TabIndex = 26
        ' 
        ' Panelr5
        ' 
        Panelr5.BackColor = SystemColors.ButtonFace
        Panelr5.Controls.Add(PictureBox1)
        Panelr5.Controls.Add(btnCambiarCuenta)
        Panelr5.Dock = DockStyle.Fill
        Panelr5.Location = New Point(3, 3)
        Panelr5.Name = "Panelr5"
        Panelr5.Size = New Size(270, 53)
        Panelr5.TabIndex = 25
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        PictureBox1.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        PictureBox1.Image = My.Resources.Resources.refresh
        PictureBox1.Location = New Point(13, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(25, 30)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' btnCambiarCuenta
        ' 
        btnCambiarCuenta.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnCambiarCuenta.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        btnCambiarCuenta.BackgroundImageLayout = ImageLayout.Stretch
        btnCambiarCuenta.FlatAppearance.BorderSize = 0
        btnCambiarCuenta.FlatStyle = FlatStyle.Flat
        btnCambiarCuenta.Font = New Font("Arial", 10F, FontStyle.Bold)
        btnCambiarCuenta.ForeColor = Color.White
        btnCambiarCuenta.Location = New Point(2, 2)
        btnCambiarCuenta.Margin = New Padding(0)
        btnCambiarCuenta.Name = "btnCambiarCuenta"
        btnCambiarCuenta.Size = New Size(264, 47)
        btnCambiarCuenta.TabIndex = 22
        btnCambiarCuenta.Text = "Cambiar de Cuenta"
        btnCambiarCuenta.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCambiarCuenta.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 48.755188F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 51.244812F))
        TableLayoutPanel5.Controls.Add(Panelr4, 1, 0)
        TableLayoutPanel5.Location = New Point(242, 235)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 69.87952F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 30.1204815F))
        TableLayoutPanel5.Size = New Size(482, 83)
        TableLayoutPanel5.TabIndex = 27
        ' 
        ' Panelr4
        ' 
        Panelr4.BackColor = SystemColors.ButtonFace
        Panelr4.Controls.Add(PictureBox2)
        Panelr4.Controls.Add(btnEstadistica)
        Panelr4.Dock = DockStyle.Fill
        Panelr4.Location = New Point(238, 3)
        Panelr4.Name = "Panelr4"
        Panelr4.Size = New Size(241, 52)
        Panelr4.TabIndex = 24
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        PictureBox2.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        PictureBox2.Image = My.Resources.Resources.report
        PictureBox2.Location = New Point(13, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 32)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 24
        PictureBox2.TabStop = False
        ' 
        ' btnEstadistica
        ' 
        btnEstadistica.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnEstadistica.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        btnEstadistica.BackgroundImageLayout = ImageLayout.Stretch
        btnEstadistica.FlatAppearance.BorderSize = 0
        btnEstadistica.FlatStyle = FlatStyle.Flat
        btnEstadistica.Font = New Font("Arial", 10F, FontStyle.Bold)
        btnEstadistica.Location = New Point(2, 2)
        btnEstadistica.Margin = New Padding(0)
        btnEstadistica.Name = "btnEstadistica"
        btnEstadistica.Size = New Size(235, 46)
        btnEstadistica.TabIndex = 23
        btnEstadistica.Text = "Estadisticas"
        btnEstadistica.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEstadistica.UseVisualStyleBackColor = False
        ' 
        ' Usuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "Usuario"
        Size = New Size(1720, 1080)
        TableLayoutPanel1.ResumeLayout(False)
        pSombraNorte.ResumeLayout(False)
        PanelInformacion.ResumeLayout(False)
        tlpInformacion.ResumeLayout(False)
        tlpInformacion.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        Panelr3.ResumeLayout(False)
        panelDatos.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        PSombraSeguridad.ResumeLayout(False)
        PanelSeguridad.ResumeLayout(False)
        tbpSeguridad.ResumeLayout(False)
        tbpSeguridad.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        Panelr5.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel5.ResumeLayout(False)
        Panelr4.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panelr1 As PanelR
    Friend WithEvents Panelr3 As PanelR
    Friend WithEvents PSombraSeguridad As PanelR
    Friend WithEvents Label3 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lbApm As Label
    Friend WithEvents lbInformacion As Label
    Friend WithEvents lbApp As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbDatos As Label
    Friend WithEvents txtApm As TextBox
    Friend WithEvents txtApp As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lbSeguridad As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents lbDireccion As Label
    Friend WithEvents lbTelefono As Label
    Friend WithEvents lbEdad As Label
    Friend WithEvents txtPss As TextBox
    Friend WithEvents lbPss As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lbCorreo As Label
    Friend WithEvents tbpSeguridad As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnFoto As Button
    Friend WithEvents lbPuesto As Label
    Friend WithEvents lbLetreroPuesto As Label
    Friend WithEvents lbNomCompleto As Label
    Friend WithEvents lbLetreroNombre As Label
    Friend WithEvents lbLetreroFR As Label
    Friend WithEvents lbFechaRegistro As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnHide As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSee As Button
    Friend WithEvents btnCambiarCuenta As Button
    Friend WithEvents btnEstadistica As Button
    Friend WithEvents Panelr2 As PanelR
    Friend WithEvents pSombraNorte As PanelR
    Friend WithEvents PanelInformacion As PanelR
    Friend WithEvents tlpInformacion As TableLayoutPanel
    Friend WithEvents panelDatos As PanelR
    Friend WithEvents PanelSeguridad As PanelR
    Friend WithEvents Panelr4 As PanelR
    Friend WithEvents Panelr5 As PanelR
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel

End Class
