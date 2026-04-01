<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loggin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loggin))
        pcbUsuario = New PictureBox()
        Timer1 = New Timer(components)
        Panel1 = New PanelR()
        PanelInicio = New PanelR()
        Panelr2 = New PanelR()
        btnCerrar = New Button()
        Panelr1 = New PanelR()
        btnInicio = New Button()
        pSombraUsuario = New PanelR()
        Panelr5 = New PanelR()
        txtUsuario = New TextBox()
        pSombraPss = New PanelR()
        Panelr3 = New PanelR()
        txtPss = New TextBox()
        cbVer = New CheckBox()
        Label5 = New Label()
        Label6 = New Label()
        lbIniciar = New Label()
        PanelIzq = New Panel()
        Panelr4 = New PanelR()
        PictureBox1 = New PictureBox()
        CType(pcbUsuario, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        PanelInicio.SuspendLayout()
        Panelr2.SuspendLayout()
        Panelr1.SuspendLayout()
        pSombraUsuario.SuspendLayout()
        Panelr5.SuspendLayout()
        pSombraPss.SuspendLayout()
        Panelr3.SuspendLayout()
        PanelIzq.SuspendLayout()
        Panelr4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pcbUsuario
        ' 
        pcbUsuario.Image = CType(resources.GetObject("pcbUsuario.Image"), Image)
        pcbUsuario.Location = New Point(240, 78)
        pcbUsuario.Margin = New Padding(3, 2, 3, 2)
        pcbUsuario.Name = "pcbUsuario"
        pcbUsuario.Size = New Size(180, 178)
        pcbUsuario.SizeMode = PictureBoxSizeMode.StretchImage
        pcbUsuario.TabIndex = 0
        pcbUsuario.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        Panel1.Controls.Add(PanelInicio)
        Panel1.Controls.Add(lbIniciar)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(650, 813)
        Panel1.TabIndex = 1
        ' 
        ' PanelInicio
        ' 
        PanelInicio.BackColor = Color.White
        PanelInicio.BackgroundImageLayout = ImageLayout.Stretch
        PanelInicio.Controls.Add(Panelr2)
        PanelInicio.Controls.Add(Panelr1)
        PanelInicio.Controls.Add(pSombraUsuario)
        PanelInicio.Controls.Add(pSombraPss)
        PanelInicio.Controls.Add(cbVer)
        PanelInicio.Controls.Add(pcbUsuario)
        PanelInicio.Controls.Add(Label5)
        PanelInicio.Controls.Add(Label6)
        PanelInicio.Location = New Point(0, 0)
        PanelInicio.Name = "PanelInicio"
        PanelInicio.Size = New Size(650, 783)
        PanelInicio.TabIndex = 0
        ' 
        ' Panelr2
        ' 
        Panelr2.BackColor = SystemColors.ButtonFace
        Panelr2.Controls.Add(btnCerrar)
        Panelr2.Location = New Point(376, 708)
        Panelr2.Name = "Panelr2"
        Panelr2.Size = New Size(209, 38)
        Panelr2.TabIndex = 13
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top
        btnCerrar.BackColor = Color.Purple
        btnCerrar.FlatAppearance.BorderColor = Color.IndianRed
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCerrar.ForeColor = Color.White
        btnCerrar.ImageAlign = ContentAlignment.MiddleLeft
        btnCerrar.Location = New Point(2, 2)
        btnCerrar.Margin = New Padding(3, 2, 3, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(203, 32)
        btnCerrar.TabIndex = 8
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' Panelr1
        ' 
        Panelr1.BackColor = SystemColors.ButtonFace
        Panelr1.Controls.Add(btnInicio)
        Panelr1.Location = New Point(79, 707)
        Panelr1.Name = "Panelr1"
        Panelr1.Size = New Size(209, 38)
        Panelr1.TabIndex = 12
        ' 
        ' btnInicio
        ' 
        btnInicio.Anchor = AnchorStyles.Top
        btnInicio.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        btnInicio.FlatAppearance.BorderSize = 0
        btnInicio.FlatStyle = FlatStyle.System
        btnInicio.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnInicio.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        btnInicio.Location = New Point(2, 2)
        btnInicio.Margin = New Padding(3, 2, 3, 2)
        btnInicio.Name = "btnInicio"
        btnInicio.Size = New Size(203, 32)
        btnInicio.TabIndex = 7
        btnInicio.Text = "Iniciar"
        btnInicio.UseVisualStyleBackColor = False
        ' 
        ' pSombraUsuario
        ' 
        pSombraUsuario.BackColor = SystemColors.ButtonFace
        pSombraUsuario.Controls.Add(Panelr5)
        pSombraUsuario.Location = New Point(80, 328)
        pSombraUsuario.Name = "pSombraUsuario"
        pSombraUsuario.Size = New Size(505, 43)
        pSombraUsuario.TabIndex = 12
        ' 
        ' Panelr5
        ' 
        Panelr5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr5.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        Panelr5.Controls.Add(txtUsuario)
        Panelr5.Location = New Point(2, 2)
        Panelr5.Name = "Panelr5"
        Panelr5.Size = New Size(499, 37)
        Panelr5.TabIndex = 11
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Anchor = AnchorStyles.Top
        txtUsuario.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtUsuario.BorderStyle = BorderStyle.None
        txtUsuario.Font = New Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsuario.ForeColor = Color.Black
        txtUsuario.Location = New Point(11, 5)
        txtUsuario.Margin = New Padding(3, 2, 3, 2)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(474, 25)
        txtUsuario.TabIndex = 3
        ' 
        ' pSombraPss
        ' 
        pSombraPss.BackColor = SystemColors.ButtonFace
        pSombraPss.Controls.Add(Panelr3)
        pSombraPss.Location = New Point(79, 473)
        pSombraPss.Name = "pSombraPss"
        pSombraPss.Size = New Size(505, 43)
        pSombraPss.TabIndex = 10
        ' 
        ' Panelr3
        ' 
        Panelr3.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        Panelr3.Controls.Add(txtPss)
        Panelr3.Location = New Point(2, 2)
        Panelr3.Name = "Panelr3"
        Panelr3.Size = New Size(499, 37)
        Panelr3.TabIndex = 11
        ' 
        ' txtPss
        ' 
        txtPss.Anchor = AnchorStyles.Top
        txtPss.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtPss.BorderStyle = BorderStyle.None
        txtPss.Font = New Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPss.ForeColor = Color.Black
        txtPss.Location = New Point(12, 6)
        txtPss.Margin = New Padding(3, 2, 3, 2)
        txtPss.Name = "txtPss"
        txtPss.PasswordChar = "*"c
        txtPss.Size = New Size(474, 25)
        txtPss.TabIndex = 5
        ' 
        ' cbVer
        ' 
        cbVer.Anchor = AnchorStyles.Top
        cbVer.AutoSize = True
        cbVer.Font = New Font("Segoe UI", 14F)
        cbVer.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        cbVer.Location = New Point(253, 613)
        cbVer.Margin = New Padding(3, 2, 3, 2)
        cbVer.Name = "cbVer"
        cbVer.Size = New Size(157, 29)
        cbVer.TabIndex = 9
        cbVer.Text = "Ver contraseña"
        cbVer.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        Label5.Location = New Point(93, 285)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 22)
        Label5.TabIndex = 4
        Label5.Text = "Usuario:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        Label6.Location = New Point(92, 426)
        Label6.Name = "Label6"
        Label6.Size = New Size(124, 22)
        Label6.TabIndex = 6
        Label6.Text = "Contraseña:"
        ' 
        ' lbIniciar
        ' 
        lbIniciar.Anchor = AnchorStyles.Top
        lbIniciar.AutoSize = True
        lbIniciar.Font = New Font("Century Gothic", 21F)
        lbIniciar.ForeColor = Color.WhiteSmoke
        lbIniciar.Location = New Point(229, 779)
        lbIniciar.Name = "lbIniciar"
        lbIniciar.Size = New Size(190, 34)
        lbIniciar.TabIndex = 1
        lbIniciar.Text = "Iniciar Sesión"
        ' 
        ' PanelIzq
        ' 
        PanelIzq.BackColor = Color.WhiteSmoke
        PanelIzq.Controls.Add(Panelr4)
        PanelIzq.Dock = DockStyle.Left
        PanelIzq.Location = New Point(0, 0)
        PanelIzq.Name = "PanelIzq"
        PanelIzq.Size = New Size(960, 1041)
        PanelIzq.TabIndex = 2
        ' 
        ' Panelr4
        ' 
        Panelr4.Anchor = AnchorStyles.None
        Panelr4.BackColor = SystemColors.ButtonFace
        Panelr4.Controls.Add(Panel1)
        Panelr4.Location = New Point(156, 118)
        Panelr4.Name = "Panelr4"
        Panelr4.Size = New Size(658, 821)
        Panelr4.TabIndex = 13
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.OriginalFondoTorres_1_
        PictureBox1.Location = New Point(961, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(944, 1041)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Loggin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 1041)
        Controls.Add(PictureBox1)
        Controls.Add(PanelIzq)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Loggin"
        Opacity = 0.99R
        Text = "Terrazas Company"
        WindowState = FormWindowState.Maximized
        CType(pcbUsuario, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        PanelInicio.ResumeLayout(False)
        PanelInicio.PerformLayout()
        Panelr2.ResumeLayout(False)
        Panelr1.ResumeLayout(False)
        pSombraUsuario.ResumeLayout(False)
        Panelr5.ResumeLayout(False)
        Panelr5.PerformLayout()
        pSombraPss.ResumeLayout(False)
        Panelr3.ResumeLayout(False)
        Panelr3.PerformLayout()
        PanelIzq.ResumeLayout(False)
        Panelr4.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pcbUsuario As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel1 As PanelR
    Friend WithEvents PanelInicio As PanelR
    Friend WithEvents lbIniciar As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnInicio As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelIzq As Panel
    Friend WithEvents cbVer As CheckBox
    Friend WithEvents txtPss As TextBox
    Friend WithEvents pSombraPss As PanelR
    Friend WithEvents pSombraUsuario As PanelR
    Friend WithEvents Panelr5 As PanelR
    Friend WithEvents Panelr3 As PanelR
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panelr1 As PanelR
    Friend WithEvents Panelr2 As PanelR
    Friend WithEvents Panelr4 As PanelR
End Class
