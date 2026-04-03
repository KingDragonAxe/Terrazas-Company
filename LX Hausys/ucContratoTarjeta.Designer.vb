<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucContratoTarjeta
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
        Panelr1 = New PanelR()
        lbID = New Label()
        Label1 = New Label()
        pPrincipal = New PanelR()
        lbResto = New Label()
        Label12 = New Label()
        lbMonto = New Label()
        Label8 = New Label()
        lbFecha = New Label()
        Label10 = New Label()
        lbServicio = New Label()
        Label6 = New Label()
        lbNombre = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        lbTipo = New Label()
        Panelr1.SuspendLayout()
        pPrincipal.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panelr1
        ' 
        Panelr1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr1.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        Panelr1.Controls.Add(lbID)
        Panelr1.Controls.Add(Label1)
        Panelr1.Controls.Add(pPrincipal)
        Panelr1.Location = New Point(2, 2)
        Panelr1.Name = "Panelr1"
        Panelr1.Size = New Size(274, 294)
        Panelr1.TabIndex = 0
        ' 
        ' lbID
        ' 
        lbID.AutoSize = True
        lbID.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbID.ForeColor = Color.White
        lbID.Location = New Point(163, 274)
        lbID.Name = "lbID"
        lbID.Size = New Size(17, 18)
        lbID.TabIndex = 3
        lbID.Text = "1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(92, 274)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 18)
        Label1.TabIndex = 2
        Label1.Text = "Contrato :"
        ' 
        ' pPrincipal
        ' 
        pPrincipal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pPrincipal.BackColor = Color.White
        pPrincipal.Controls.Add(lbResto)
        pPrincipal.Controls.Add(Label12)
        pPrincipal.Controls.Add(lbMonto)
        pPrincipal.Controls.Add(Label8)
        pPrincipal.Controls.Add(lbFecha)
        pPrincipal.Controls.Add(Label10)
        pPrincipal.Controls.Add(lbServicio)
        pPrincipal.Controls.Add(Label6)
        pPrincipal.Controls.Add(lbNombre)
        pPrincipal.Controls.Add(Label3)
        pPrincipal.Controls.Add(Panel1)
        pPrincipal.Controls.Add(lbTipo)
        pPrincipal.Location = New Point(0, 0)
        pPrincipal.Name = "pPrincipal"
        pPrincipal.Size = New Size(274, 271)
        pPrincipal.TabIndex = 1
        ' 
        ' lbResto
        ' 
        lbResto.AutoSize = True
        lbResto.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbResto.Location = New Point(199, 238)
        lbResto.Name = "lbResto"
        lbResto.Size = New Size(44, 18)
        lbResto.TabIndex = 11
        lbResto.Text = "4550"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(199, 220)
        Label12.Name = "Label12"
        Label12.Size = New Size(60, 18)
        Label12.TabIndex = 10
        Label12.Text = "Resto:"
        ' 
        ' lbMonto
        ' 
        lbMonto.AutoSize = True
        lbMonto.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbMonto.Location = New Point(7, 238)
        lbMonto.Name = "lbMonto"
        lbMonto.Size = New Size(53, 18)
        lbMonto.TabIndex = 9
        lbMonto.Text = "10250"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(7, 220)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 18)
        Label8.TabIndex = 8
        Label8.Text = "Total:"
        ' 
        ' lbFecha
        ' 
        lbFecha.AutoSize = True
        lbFecha.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbFecha.Location = New Point(16, 172)
        lbFecha.Name = "lbFecha"
        lbFecha.Size = New Size(148, 18)
        lbFecha.TabIndex = 7
        lbFecha.Text = "5 de enero del 2026"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(7, 153)
        Label10.Name = "Label10"
        Label10.Size = New Size(67, 18)
        Label10.TabIndex = 6
        Label10.Text = "Fecha: "
        ' 
        ' lbServicio
        ' 
        lbServicio.AutoSize = True
        lbServicio.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbServicio.Location = New Point(16, 125)
        lbServicio.Name = "lbServicio"
        lbServicio.Size = New Size(150, 18)
        lbServicio.TabIndex = 5
        lbServicio.Text = "Reparacion de bano"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(7, 106)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 18)
        Label6.TabIndex = 4
        Label6.Text = "Servicio:"
        ' 
        ' lbNombre
        ' 
        lbNombre.AutoSize = True
        lbNombre.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbNombre.Location = New Point(16, 78)
        lbNombre.Name = "lbNombre"
        lbNombre.Size = New Size(241, 18)
        lbNombre.TabIndex = 3
        lbNombre.Text = "Axel Gabriel Sifuentes Hernandez"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(7, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 18)
        Label3.TabIndex = 2
        Label3.Text = "De: "
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Location = New Point(37, 43)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 2)
        Panel1.TabIndex = 1
        ' 
        ' lbTipo
        ' 
        lbTipo.AutoSize = True
        lbTipo.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbTipo.Location = New Point(59, 17)
        lbTipo.Name = "lbTipo"
        lbTipo.Size = New Size(160, 24)
        lbTipo.TabIndex = 0
        lbTipo.Text = "Mantenimiento"
        ' 
        ' ucContratoTarjeta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        Controls.Add(Panelr1)
        Margin = New Padding(105, 15, 0, 15)
        Name = "ucContratoTarjeta"
        Size = New Size(280, 300)
        Panelr1.ResumeLayout(False)
        Panelr1.PerformLayout()
        pPrincipal.ResumeLayout(False)
        pPrincipal.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panelr1 As PanelR
    Friend WithEvents pPrincipal As PanelR
    Friend WithEvents lbID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTipo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbNombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbResto As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbMonto As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbFecha As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbServicio As Label
    Friend WithEvents Label6 As Label

End Class
