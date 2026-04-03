<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorreo
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
        Panelr2 = New PanelR()
        Panelr8 = New PanelR()
        Panelr9 = New PanelR()
        Panel3 = New Panel()
        txtCuerpo = New TextBox()
        Panelr10 = New PanelR()
        Label4 = New Label()
        Panel2 = New Panel()
        txtAsunto = New TextBox()
        Panelr7 = New PanelR()
        Label3 = New Label()
        Panelr4 = New PanelR()
        Panelr5 = New PanelR()
        Panel1 = New Panel()
        txtDestinatario = New TextBox()
        Panelr6 = New PanelR()
        Label2 = New Label()
        Panelr3 = New PanelR()
        btnCerrar = New Button()
        Panelr1 = New PanelR()
        Panelr18 = New PanelR()
        btnAceptar = New Button()
        Label1 = New Label()
        Panelr2.SuspendLayout()
        Panelr8.SuspendLayout()
        Panelr9.SuspendLayout()
        Panelr10.SuspendLayout()
        Panelr7.SuspendLayout()
        Panelr4.SuspendLayout()
        Panelr5.SuspendLayout()
        Panelr6.SuspendLayout()
        Panelr3.SuspendLayout()
        Panelr1.SuspendLayout()
        Panelr18.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panelr2
        ' 
        Panelr2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr2.BackColor = Color.White
        Panelr2.Controls.Add(Panelr8)
        Panelr2.Controls.Add(Panel2)
        Panelr2.Controls.Add(txtAsunto)
        Panelr2.Controls.Add(Panelr7)
        Panelr2.Controls.Add(Panelr4)
        Panelr2.Controls.Add(Panelr3)
        Panelr2.Controls.Add(Panelr1)
        Panelr2.Location = New Point(-1, -44)
        Panelr2.Name = "Panelr2"
        Panelr2.Size = New Size(554, 749)
        Panelr2.TabIndex = 4
        ' 
        ' Panelr8
        ' 
        Panelr8.BackColor = SystemColors.ButtonFace
        Panelr8.Controls.Add(Panelr9)
        Panelr8.Location = New Point(-1, 201)
        Panelr8.Name = "Panelr8"
        Panelr8.Size = New Size(554, 460)
        Panelr8.TabIndex = 6
        ' 
        ' Panelr9
        ' 
        Panelr9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr9.BackColor = Color.White
        Panelr9.Controls.Add(Panel3)
        Panelr9.Controls.Add(txtCuerpo)
        Panelr9.Controls.Add(Panelr10)
        Panelr9.Location = New Point(0, 2)
        Panelr9.Name = "Panelr9"
        Panelr9.Size = New Size(554, 454)
        Panelr9.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Location = New Point(88, 437)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(424, 2)
        Panel3.TabIndex = 2
        ' 
        ' txtCuerpo
        ' 
        txtCuerpo.BackColor = Color.White
        txtCuerpo.BorderStyle = BorderStyle.None
        txtCuerpo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCuerpo.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtCuerpo.Location = New Point(88, 35)
        txtCuerpo.Multiline = True
        txtCuerpo.Name = "txtCuerpo"
        txtCuerpo.Size = New Size(424, 396)
        txtCuerpo.TabIndex = 1
        ' 
        ' Panelr10
        ' 
        Panelr10.BackColor = Color.WhiteSmoke
        Panelr10.Controls.Add(Label4)
        Panelr10.Location = New Point(24, 27)
        Panelr10.Name = "Panelr10"
        Panelr10.Size = New Size(55, 40)
        Panelr10.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(-3, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 0
        Label4.Text = "Cuerpo:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Location = New Point(87, 188)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(424, 2)
        Panel2.TabIndex = 5
        ' 
        ' txtAsunto
        ' 
        txtAsunto.BackColor = Color.White
        txtAsunto.BorderStyle = BorderStyle.None
        txtAsunto.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAsunto.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtAsunto.Location = New Point(87, 162)
        txtAsunto.Name = "txtAsunto"
        txtAsunto.Size = New Size(424, 22)
        txtAsunto.TabIndex = 4
        ' 
        ' Panelr7
        ' 
        Panelr7.BackColor = Color.WhiteSmoke
        Panelr7.Controls.Add(Label3)
        Panelr7.Location = New Point(23, 154)
        Panelr7.Name = "Panelr7"
        Panelr7.Size = New Size(55, 40)
        Panelr7.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(1, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 0
        Label3.Text = "Asunto:"
        ' 
        ' Panelr4
        ' 
        Panelr4.BackColor = SystemColors.ButtonFace
        Panelr4.Controls.Add(Panelr5)
        Panelr4.Location = New Point(-1, 36)
        Panelr4.Name = "Panelr4"
        Panelr4.Size = New Size(554, 100)
        Panelr4.TabIndex = 2
        ' 
        ' Panelr5
        ' 
        Panelr5.BackColor = Color.White
        Panelr5.Controls.Add(Panel1)
        Panelr5.Controls.Add(txtDestinatario)
        Panelr5.Controls.Add(Panelr6)
        Panelr5.Location = New Point(0, 2)
        Panelr5.Name = "Panelr5"
        Panelr5.Size = New Size(554, 94)
        Panelr5.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Location = New Point(88, 61)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(424, 2)
        Panel1.TabIndex = 2
        ' 
        ' txtDestinatario
        ' 
        txtDestinatario.BackColor = Color.White
        txtDestinatario.BorderStyle = BorderStyle.None
        txtDestinatario.Enabled = False
        txtDestinatario.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDestinatario.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txtDestinatario.Location = New Point(88, 35)
        txtDestinatario.Name = "txtDestinatario"
        txtDestinatario.Size = New Size(424, 22)
        txtDestinatario.TabIndex = 1
        ' 
        ' Panelr6
        ' 
        Panelr6.BackColor = Color.WhiteSmoke
        Panelr6.Controls.Add(Label2)
        Panelr6.Location = New Point(24, 27)
        Panelr6.Name = "Panelr6"
        Panelr6.Size = New Size(55, 40)
        Panelr6.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(7, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 0
        Label2.Text = "Para:"
        ' 
        ' Panelr3
        ' 
        Panelr3.BackColor = SystemColors.ButtonFace
        Panelr3.Controls.Add(btnCerrar)
        Panelr3.Location = New Point(305, 677)
        Panelr3.Name = "Panelr3"
        Panelr3.Size = New Size(206, 41)
        Panelr3.TabIndex = 1
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCerrar.Location = New Point(2, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(200, 35)
        btnCerrar.TabIndex = 3
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' Panelr1
        ' 
        Panelr1.BackColor = SystemColors.ButtonFace
        Panelr1.Controls.Add(Panelr18)
        Panelr1.Location = New Point(49, 677)
        Panelr1.Name = "Panelr1"
        Panelr1.Size = New Size(206, 41)
        Panelr1.TabIndex = 0
        ' 
        ' Panelr18
        ' 
        Panelr18.BackColor = Color.Purple
        Panelr18.Controls.Add(btnAceptar)
        Panelr18.Location = New Point(2, 2)
        Panelr18.Name = "Panelr18"
        Panelr18.Size = New Size(200, 35)
        Panelr18.TabIndex = 36
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackColor = Color.Purple
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatStyle = FlatStyle.Flat
        btnAceptar.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAceptar.ForeColor = Color.White
        btnAceptar.Location = New Point(0, 0)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(200, 35)
        btnAceptar.TabIndex = 2
        btnAceptar.Text = "Enviar"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(217, 701)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 36)
        Label1.TabIndex = 5
        Label1.Text = "Correo"
        ' 
        ' frmCorreo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        ClientSize = New Size(552, 736)
        ControlBox = False
        Controls.Add(Panelr2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        MaximizeBox = False
        MaximumSize = New Size(568, 752)
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        MinimumSize = New Size(568, 752)
        Name = "frmCorreo"
        Opacity = 0.9R
        ShowIcon = False
        ShowInTaskbar = False
        Panelr2.ResumeLayout(False)
        Panelr2.PerformLayout()
        Panelr8.ResumeLayout(False)
        Panelr9.ResumeLayout(False)
        Panelr9.PerformLayout()
        Panelr10.ResumeLayout(False)
        Panelr10.PerformLayout()
        Panelr7.ResumeLayout(False)
        Panelr7.PerformLayout()
        Panelr4.ResumeLayout(False)
        Panelr5.ResumeLayout(False)
        Panelr5.PerformLayout()
        Panelr6.ResumeLayout(False)
        Panelr6.PerformLayout()
        Panelr3.ResumeLayout(False)
        Panelr1.ResumeLayout(False)
        Panelr18.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panelr2 As PanelR
    Friend WithEvents Panelr3 As PanelR
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panelr1 As PanelR
    Friend WithEvents Panelr18 As PanelR
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panelr4 As PanelR
    Friend WithEvents Panelr5 As PanelR
    Friend WithEvents Panelr6 As PanelR
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panelr8 As PanelR
    Friend WithEvents Panelr9 As PanelR
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panelr10 As PanelR
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panelr7 As PanelR
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCuerpo As TextBox
    Friend WithEvents txtAsunto As TextBox
    Friend WithEvents txtDestinatario As TextBox
End Class
