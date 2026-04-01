<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carga))
        PictureBox1 = New PictureBox()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        Panelr1 = New PanelR()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panelr1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(616, 325)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = SystemColors.ActiveCaption
        ProgressBar1.Location = New Point(-2, 329)
        ProgressBar1.Margin = New Padding(3, 2, 3, 2)
        ProgressBar1.MarqueeAnimationSpeed = 30
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(626, 22)
        ProgressBar1.TabIndex = 1
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 50
        ' 
        ' Panelr1
        ' 
        Panelr1.BackColor = Color.White
        Panelr1.Controls.Add(PictureBox1)
        Panelr1.Controls.Add(ProgressBar1)
        Panelr1.Location = New Point(0, -6)
        Panelr1.Name = "Panelr1"
        Panelr1.Size = New Size(616, 350)
        Panelr1.TabIndex = 2
        ' 
        ' Carga
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(96), CByte(62), CByte(136))
        ClientSize = New Size(616, 356)
        ControlBox = False
        Controls.Add(Panelr1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(632, 372)
        MinimumSize = New Size(632, 372)
        Name = "Carga"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panelr1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panelr1 As PanelR
End Class
