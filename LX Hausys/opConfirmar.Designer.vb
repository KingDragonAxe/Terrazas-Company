<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opConfirmar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(opConfirmar))
        panelNorte = New PanelR()
        Panelr6 = New PanelR()
        PictureBox3 = New PictureBox()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        panelCentro = New PanelR()
        Panelr5 = New PanelR()
        PictureBox2 = New PictureBox()
        TextBox2 = New TextBox()
        Panelr3 = New PanelR()
        panelBotones = New PanelR()
        Panelr1 = New PanelR()
        lbVerificacion = New Label()
        Panelr2 = New PanelR()
        panelNorte.SuspendLayout()
        Panelr6.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        panelCentro.SuspendLayout()
        Panelr5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panelr3.SuspendLayout()
        panelBotones.SuspendLayout()
        Panelr1.SuspendLayout()
        Panelr2.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelNorte
        ' 
        panelNorte.BackColor = SystemColors.ButtonFace
        panelNorte.Controls.Add(Panelr6)
        panelNorte.Location = New Point(26, 19)
        panelNorte.Name = "panelNorte"
        panelNorte.Size = New Size(349, 79)
        panelNorte.TabIndex = 0
        ' 
        ' Panelr6
        ' 
        Panelr6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr6.BackColor = Color.White
        Panelr6.Controls.Add(PictureBox3)
        Panelr6.Controls.Add(Label2)
        Panelr6.Location = New Point(2, 2)
        Panelr6.Name = "Panelr6"
        Panelr6.Size = New Size(342, 72)
        Panelr6.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.check
        PictureBox3.Location = New Point(39, 11)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(51, 51)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(109, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(206, 25)
        Label2.TabIndex = 0
        Label2.Text = "Escribe tu contraseña:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(8, 8)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(219, 8)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 3
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' panelCentro
        ' 
        panelCentro.BackColor = SystemColors.ButtonFace
        panelCentro.Controls.Add(Panelr5)
        panelCentro.Location = New Point(46, 117)
        panelCentro.Name = "panelCentro"
        panelCentro.Size = New Size(308, 48)
        panelCentro.TabIndex = 5
        ' 
        ' Panelr5
        ' 
        Panelr5.BackColor = Color.White
        Panelr5.Controls.Add(PictureBox2)
        Panelr5.Controls.Add(TextBox2)
        Panelr5.Location = New Point(2, 2)
        Panelr5.Name = "Panelr5"
        Panelr5.Size = New Size(302, 42)
        Panelr5.TabIndex = 6
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.padlock
        PictureBox2.Location = New Point(7, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 28)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(38, 5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(260, 33)
        TextBox2.TabIndex = 1
        ' 
        ' Panelr3
        ' 
        Panelr3.BackColor = Color.White
        Panelr3.Controls.Add(Button2)
        Panelr3.Controls.Add(Button1)
        Panelr3.Location = New Point(2, 2)
        Panelr3.Name = "Panelr3"
        Panelr3.Size = New Size(304, 37)
        Panelr3.TabIndex = 6
        ' 
        ' panelBotones
        ' 
        panelBotones.BackColor = SystemColors.ButtonFace
        panelBotones.Controls.Add(Panelr3)
        panelBotones.Location = New Point(44, 179)
        panelBotones.Name = "panelBotones"
        panelBotones.Size = New Size(310, 43)
        panelBotones.TabIndex = 7
        ' 
        ' Panelr1
        ' 
        Panelr1.BackColor = Color.White
        Panelr1.Controls.Add(panelNorte)
        Panelr1.Controls.Add(panelBotones)
        Panelr1.Controls.Add(panelCentro)
        Panelr1.Location = New Point(0, -3)
        Panelr1.Margin = New Padding(0)
        Panelr1.Name = "Panelr1"
        Panelr1.Size = New Size(386, 241)
        Panelr1.TabIndex = 8
        ' 
        ' lbVerificacion
        ' 
        lbVerificacion.AutoSize = True
        lbVerificacion.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbVerificacion.ForeColor = Color.White
        lbVerificacion.Location = New Point(157, 238)
        lbVerificacion.Name = "lbVerificacion"
        lbVerificacion.Size = New Size(82, 16)
        lbVerificacion.TabIndex = 8
        lbVerificacion.Text = "Verificacion"
        ' 
        ' Panelr2
        ' 
        Panelr2.BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        Panelr2.Controls.Add(lbVerificacion)
        Panelr2.Controls.Add(Panelr1)
        Panelr2.Location = New Point(0, 0)
        Panelr2.Name = "Panelr2"
        Panelr2.Size = New Size(393, 268)
        Panelr2.TabIndex = 9
        ' 
        ' opConfirmar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(384, 254)
        ControlBox = False
        Controls.Add(Panelr2)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(400, 270)
        MinimumSize = New Size(400, 270)
        Name = "opConfirmar"
        StartPosition = FormStartPosition.CenterScreen
        panelNorte.ResumeLayout(False)
        Panelr6.ResumeLayout(False)
        Panelr6.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        panelCentro.ResumeLayout(False)
        Panelr5.ResumeLayout(False)
        Panelr5.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panelr3.ResumeLayout(False)
        panelBotones.ResumeLayout(False)
        Panelr1.ResumeLayout(False)
        Panelr2.ResumeLayout(False)
        Panelr2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelNorte As PanelR
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents panelCentro As PanelR
    Friend WithEvents Panelr5 As PanelR
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panelr3 As PanelR
    Friend WithEvents panelBotones As PanelR
    Friend WithEvents Panelr6 As PanelR
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panelr1 As PanelR
    Friend WithEvents lbVerificacion As Label
    Friend WithEvents Panelr2 As PanelR
End Class
