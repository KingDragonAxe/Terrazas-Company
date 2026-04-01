<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnCerrar = New Button()
        btnDashBoard = New Button()
        btnMateriales = New Button()
        btnReportes = New Button()
        btnGastos = New Button()
        btnCliente = New Button()
        btnTrabajos = New Button()
        btnProveedores = New Button()
        btnSet = New Button()
        Panel9 = New Panel()
        btnUsuario = New Button()
        LogoPanel = New Panel()
        LogoPicture = New PictureBox()
        LogoLabel = New Label()
        Contenedor = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel9.SuspendLayout()
        LogoPanel.SuspendLayout()
        CType(LogoPicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Contenedor)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1559, 791)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        Panel2.Controls.Add(btnCerrar)
        Panel2.Controls.Add(btnDashBoard)
        Panel2.Controls.Add(btnMateriales)
        Panel2.Controls.Add(btnReportes)
        Panel2.Controls.Add(btnGastos)
        Panel2.Controls.Add(btnCliente)
        Panel2.Controls.Add(btnTrabajos)
        Panel2.Controls.Add(btnProveedores)
        Panel2.Controls.Add(btnSet)
        Panel2.Controls.Add(Panel9)
        Panel2.Controls.Add(LogoPanel)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(262, 791)
        Panel2.TabIndex = 0
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Bottom
        btnCerrar.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCerrar.ForeColor = Color.White
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(1, 738)
        btnCerrar.Margin = New Padding(3, 2, 3, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(264, 53)
        btnCerrar.TabIndex = 19
        btnCerrar.Text = "     Cerrar Sesion"
        btnCerrar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' btnDashBoard
        ' 
        btnDashBoard.Anchor = AnchorStyles.Top
        btnDashBoard.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        btnDashBoard.FlatAppearance.BorderSize = 0
        btnDashBoard.FlatStyle = FlatStyle.Flat
        btnDashBoard.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDashBoard.ForeColor = Color.White
        btnDashBoard.Image = CType(resources.GetObject("btnDashBoard.Image"), Image)
        btnDashBoard.Location = New Point(1, 140)
        btnDashBoard.Margin = New Padding(3, 2, 3, 2)
        btnDashBoard.Name = "btnDashBoard"
        btnDashBoard.Size = New Size(262, 49)
        btnDashBoard.TabIndex = 16
        btnDashBoard.Text = "  Dashboard"
        btnDashBoard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashBoard.UseVisualStyleBackColor = False
        ' 
        ' btnMateriales
        ' 
        btnMateriales.Anchor = AnchorStyles.Top
        btnMateriales.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        btnMateriales.FlatAppearance.BorderSize = 0
        btnMateriales.FlatStyle = FlatStyle.Flat
        btnMateriales.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMateriales.ForeColor = Color.White
        btnMateriales.Image = CType(resources.GetObject("btnMateriales.Image"), Image)
        btnMateriales.Location = New Point(0, 352)
        btnMateriales.Margin = New Padding(3, 2, 3, 2)
        btnMateriales.Name = "btnMateriales"
        btnMateriales.Size = New Size(262, 49)
        btnMateriales.TabIndex = 17
        btnMateriales.Text = "  Materiales"
        btnMateriales.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMateriales.UseVisualStyleBackColor = False
        ' 
        ' btnReportes
        ' 
        btnReportes.Anchor = AnchorStyles.Top
        btnReportes.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        btnReportes.FlatAppearance.BorderSize = 0
        btnReportes.FlatStyle = FlatStyle.Flat
        btnReportes.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReportes.ForeColor = Color.White
        btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), Image)
        btnReportes.Location = New Point(0, 458)
        btnReportes.Margin = New Padding(3, 2, 3, 2)
        btnReportes.Name = "btnReportes"
        btnReportes.Size = New Size(262, 49)
        btnReportes.TabIndex = 18
        btnReportes.Text = "  Reportes"
        btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReportes.UseVisualStyleBackColor = False
        ' 
        ' btnGastos
        ' 
        btnGastos.Anchor = AnchorStyles.Top
        btnGastos.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        btnGastos.FlatAppearance.BorderSize = 0
        btnGastos.FlatStyle = FlatStyle.Flat
        btnGastos.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGastos.ForeColor = Color.White
        btnGastos.Image = CType(resources.GetObject("btnGastos.Image"), Image)
        btnGastos.Location = New Point(1, 299)
        btnGastos.Margin = New Padding(3, 2, 3, 2)
        btnGastos.Name = "btnGastos"
        btnGastos.Size = New Size(262, 49)
        btnGastos.TabIndex = 19
        btnGastos.Text = "  Gastos"
        btnGastos.TextImageRelation = TextImageRelation.ImageBeforeText
        btnGastos.UseVisualStyleBackColor = False
        ' 
        ' btnCliente
        ' 
        btnCliente.Anchor = AnchorStyles.Top
        btnCliente.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        btnCliente.FlatAppearance.BorderSize = 0
        btnCliente.FlatStyle = FlatStyle.Flat
        btnCliente.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCliente.ForeColor = Color.White
        btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), Image)
        btnCliente.Location = New Point(1, 246)
        btnCliente.Margin = New Padding(3, 2, 3, 2)
        btnCliente.Name = "btnCliente"
        btnCliente.Size = New Size(262, 49)
        btnCliente.TabIndex = 20
        btnCliente.Text = "  Clientes"
        btnCliente.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCliente.UseVisualStyleBackColor = False
        ' 
        ' btnTrabajos
        ' 
        btnTrabajos.Anchor = AnchorStyles.Top
        btnTrabajos.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        btnTrabajos.FlatAppearance.BorderSize = 0
        btnTrabajos.FlatStyle = FlatStyle.Flat
        btnTrabajos.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTrabajos.ForeColor = Color.White
        btnTrabajos.Image = CType(resources.GetObject("btnTrabajos.Image"), Image)
        btnTrabajos.Location = New Point(1, 193)
        btnTrabajos.Margin = New Padding(3, 2, 3, 2)
        btnTrabajos.Name = "btnTrabajos"
        btnTrabajos.Size = New Size(262, 49)
        btnTrabajos.TabIndex = 21
        btnTrabajos.Text = "  Trabajos"
        btnTrabajos.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTrabajos.UseVisualStyleBackColor = False
        ' 
        ' btnProveedores
        ' 
        btnProveedores.Anchor = AnchorStyles.Top
        btnProveedores.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        btnProveedores.FlatAppearance.BorderSize = 0
        btnProveedores.FlatStyle = FlatStyle.Flat
        btnProveedores.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnProveedores.ForeColor = Color.White
        btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), Image)
        btnProveedores.Location = New Point(0, 405)
        btnProveedores.Margin = New Padding(3, 2, 3, 2)
        btnProveedores.Name = "btnProveedores"
        btnProveedores.Size = New Size(262, 49)
        btnProveedores.TabIndex = 22
        btnProveedores.Text = "Proveedores"
        btnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProveedores.UseVisualStyleBackColor = False
        ' 
        ' btnSet
        ' 
        btnSet.Anchor = AnchorStyles.Bottom
        btnSet.BackColor = Color.Purple
        btnSet.FlatAppearance.BorderSize = 0
        btnSet.FlatStyle = FlatStyle.Flat
        btnSet.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSet.ForeColor = Color.White
        btnSet.Image = CType(resources.GetObject("btnSet.Image"), Image)
        btnSet.Location = New Point(1, 690)
        btnSet.Margin = New Padding(3, 2, 3, 2)
        btnSet.Name = "btnSet"
        btnSet.Size = New Size(262, 49)
        btnSet.TabIndex = 24
        btnSet.Text = "     Configuracion"
        btnSet.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSet.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.DimGray
        Panel9.Controls.Add(btnUsuario)
        Panel9.Location = New Point(0, 82)
        Panel9.Margin = New Padding(3, 2, 3, 2)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(262, 52)
        Panel9.TabIndex = 3
        ' 
        ' btnUsuario
        ' 
        btnUsuario.Anchor = AnchorStyles.Top
        btnUsuario.BackColor = Color.Indigo
        btnUsuario.FlatAppearance.BorderSize = 0
        btnUsuario.FlatStyle = FlatStyle.Flat
        btnUsuario.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUsuario.ForeColor = Color.White
        btnUsuario.Image = CType(resources.GetObject("btnUsuario.Image"), Image)
        btnUsuario.Location = New Point(0, 0)
        btnUsuario.Margin = New Padding(3, 2, 3, 2)
        btnUsuario.Name = "btnUsuario"
        btnUsuario.Size = New Size(262, 52)
        btnUsuario.TabIndex = 0
        btnUsuario.Text = "  Axel Sifuentes"
        btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUsuario.UseVisualStyleBackColor = False
        ' 
        ' LogoPanel
        ' 
        LogoPanel.Anchor = AnchorStyles.Top
        LogoPanel.Controls.Add(LogoPicture)
        LogoPanel.Controls.Add(LogoLabel)
        LogoPanel.Location = New Point(1, 0)
        LogoPanel.Margin = New Padding(3, 2, 3, 2)
        LogoPanel.Name = "LogoPanel"
        LogoPanel.Size = New Size(262, 71)
        LogoPanel.TabIndex = 2
        ' 
        ' LogoPicture
        ' 
        LogoPicture.Image = CType(resources.GetObject("LogoPicture.Image"), Image)
        LogoPicture.Location = New Point(10, 6)
        LogoPicture.Margin = New Padding(3, 2, 3, 2)
        LogoPicture.Name = "LogoPicture"
        LogoPicture.Size = New Size(70, 58)
        LogoPicture.SizeMode = PictureBoxSizeMode.StretchImage
        LogoPicture.TabIndex = 0
        LogoPicture.TabStop = False
        ' 
        ' LogoLabel
        ' 
        LogoLabel.AutoSize = True
        LogoLabel.Font = New Font("Dubai", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogoLabel.ForeColor = SystemColors.ButtonHighlight
        LogoLabel.Location = New Point(86, 17)
        LogoLabel.Name = "LogoLabel"
        LogoLabel.Size = New Size(122, 40)
        LogoLabel.TabIndex = 1
        LogoLabel.Text = "Terrazas's"
        ' 
        ' Contenedor
        ' 
        Contenedor.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Contenedor.BackColor = Color.WhiteSmoke
        Contenedor.Location = New Point(262, 0)
        Contenedor.Margin = New Padding(3, 2, 3, 2)
        Contenedor.Name = "Contenedor"
        Contenedor.Size = New Size(1298, 791)
        Contenedor.TabIndex = 1
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1559, 791)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Inicio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Terrazas Company"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        LogoPanel.ResumeLayout(False)
        LogoPanel.PerformLayout()
        CType(LogoPicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Contenedor As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDashBoard As Button
    Friend WithEvents btnMateriales As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnGastos As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnTrabajos As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnSet As Button
    Friend WithEvents Panel21 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel9 As Panel
    Private WithEvents btnUsuario As Button
    Friend WithEvents LogoPanel As Panel
    Friend WithEvents LogoPicture As PictureBox
    Friend WithEvents LogoLabel As Label

End Class
