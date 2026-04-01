Imports System.Drawing.Drawing2D

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panelr2 = New PanelR()
        Panelr3 = New PanelR()
        Grafica3 = New PanelR()
        Panelr6 = New PanelR()
        Chart3 = New DataVisualization.Charting.Chart()
        Grafica4 = New PanelR()
        Panelr7 = New PanelR()
        Chart4 = New DataVisualization.Charting.Chart()
        PanelRedondeado1 = New PanelR()
        Panelr1 = New PanelR()
        Grafica1 = New PanelR()
        Panelr4 = New PanelR()
        Chart2 = New DataVisualization.Charting.Chart()
        Panelr9 = New PanelR()
        Panelr10 = New PanelR()
        Chart5 = New DataVisualization.Charting.Chart()
        Panel9 = New PanelR()
        Panelr8 = New PanelR()
        Panelr5 = New PanelR()
        Panelr11 = New PanelR()
        TableLayoutPanel1.SuspendLayout()
        Panelr2.SuspendLayout()
        Grafica3.SuspendLayout()
        Panelr6.SuspendLayout()
        CType(Chart3, ComponentModel.ISupportInitialize).BeginInit()
        Grafica4.SuspendLayout()
        Panelr7.SuspendLayout()
        CType(Chart4, ComponentModel.ISupportInitialize).BeginInit()
        PanelRedondeado1.SuspendLayout()
        Grafica1.SuspendLayout()
        Panelr4.SuspendLayout()
        CType(Chart2, ComponentModel.ISupportInitialize).BeginInit()
        Panelr9.SuspendLayout()
        Panelr10.SuspendLayout()
        CType(Chart5, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        Panelr5.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.Controls.Add(Panelr5, 2, 0)
        TableLayoutPanel1.Controls.Add(Panelr2, 1, 0)
        TableLayoutPanel1.Controls.Add(Grafica3, 0, 2)
        TableLayoutPanel1.Controls.Add(Grafica4, 1, 2)
        TableLayoutPanel1.Controls.Add(PanelRedondeado1, 0, 0)
        TableLayoutPanel1.Controls.Add(Grafica1, 0, 1)
        TableLayoutPanel1.Controls.Add(Panelr9, 2, 1)
        TableLayoutPanel1.ForeColor = SystemColors.ControlLight
        TableLayoutPanel1.Location = New Point(20, 96)
        TableLayoutPanel1.Margin = New Padding(2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel1.Size = New Size(1679, 969)
        TableLayoutPanel1.TabIndex = 13
        ' 
        ' Panelr2
        ' 
        Panelr2.BackColor = SystemColors.ButtonFace
        Panelr2.Controls.Add(Panelr3)
        Panelr2.Dock = DockStyle.Fill
        Panelr2.Location = New Point(569, 0)
        Panelr2.Margin = New Padding(10, 0, 10, 20)
        Panelr2.Name = "Panelr2"
        Panelr2.Size = New Size(539, 173)
        Panelr2.TabIndex = 17
        ' 
        ' Panelr3
        ' 
        Panelr3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr3.BackColor = Color.White
        Panelr3.Location = New Point(2, 2)
        Panelr3.Name = "Panelr3"
        Panelr3.Size = New Size(532, 167)
        Panelr3.TabIndex = 0
        ' 
        ' Grafica3
        ' 
        Grafica3.BackColor = SystemColors.ButtonFace
        Grafica3.Controls.Add(Panelr6)
        Grafica3.Dock = DockStyle.Fill
        Grafica3.ForeColor = Color.Gainsboro
        Grafica3.Location = New Point(0, 590)
        Grafica3.Margin = New Padding(0, 10, 10, 0)
        Grafica3.Name = "Grafica3"
        Grafica3.Size = New Size(549, 379)
        Grafica3.TabIndex = 12
        ' 
        ' Panelr6
        ' 
        Panelr6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr6.BackColor = Color.White
        Panelr6.Controls.Add(Chart3)
        Panelr6.ForeColor = Color.White
        Panelr6.Location = New Point(2, 2)
        Panelr6.Name = "Panelr6"
        Panelr6.Size = New Size(543, 371)
        Panelr6.TabIndex = 2
        ' 
        ' Chart3
        ' 
        Chart3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ChartArea5.Name = "ChartArea1"
        Chart3.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Chart3.Legends.Add(Legend5)
        Chart3.Location = New Point(0, 0)
        Chart3.Margin = New Padding(3, 2, 3, 2)
        Chart3.Name = "Chart3"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Chart3.Series.Add(Series5)
        Chart3.Size = New Size(540, 369)
        Chart3.TabIndex = 1
        ' 
        ' Grafica4
        ' 
        Grafica4.BackColor = SystemColors.ButtonFace
        Grafica4.Controls.Add(Panelr7)
        Grafica4.Dock = DockStyle.Fill
        Grafica4.Location = New Point(569, 590)
        Grafica4.Margin = New Padding(10, 10, 10, 0)
        Grafica4.Name = "Grafica4"
        Grafica4.Size = New Size(539, 379)
        Grafica4.TabIndex = 13
        ' 
        ' Panelr7
        ' 
        Panelr7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr7.BackColor = Color.White
        Panelr7.Controls.Add(Chart4)
        Panelr7.ForeColor = Color.White
        Panelr7.Location = New Point(2, 2)
        Panelr7.Name = "Panelr7"
        Panelr7.Size = New Size(532, 371)
        Panelr7.TabIndex = 3
        ' 
        ' Chart4
        ' 
        Chart4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ChartArea6.Name = "ChartArea1"
        Chart4.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Chart4.Legends.Add(Legend6)
        Chart4.Location = New Point(0, 0)
        Chart4.Margin = New Padding(3, 2, 3, 2)
        Chart4.Name = "Chart4"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Chart4.Series.Add(Series6)
        Chart4.Size = New Size(489, 371)
        Chart4.TabIndex = 2
        ' 
        ' PanelRedondeado1
        ' 
        PanelRedondeado1.BackColor = SystemColors.ButtonFace
        PanelRedondeado1.Controls.Add(Panelr1)
        PanelRedondeado1.Dock = DockStyle.Fill
        PanelRedondeado1.Location = New Point(0, 0)
        PanelRedondeado1.Margin = New Padding(0, 0, 10, 20)
        PanelRedondeado1.Name = "PanelRedondeado1"
        PanelRedondeado1.Size = New Size(549, 173)
        PanelRedondeado1.TabIndex = 16
        ' 
        ' Panelr1
        ' 
        Panelr1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr1.BackColor = Color.White
        Panelr1.Location = New Point(2, 2)
        Panelr1.Name = "Panelr1"
        Panelr1.Size = New Size(543, 167)
        Panelr1.TabIndex = 0
        ' 
        ' Grafica1
        ' 
        Grafica1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Grafica1.BackColor = SystemColors.ButtonFace
        TableLayoutPanel1.SetColumnSpan(Grafica1, 2)
        Grafica1.Controls.Add(Panelr4)
        Grafica1.ForeColor = Color.Gainsboro
        Grafica1.Location = New Point(0, 193)
        Grafica1.Margin = New Padding(0, 0, 10, 10)
        Grafica1.Name = "Grafica1"
        Grafica1.Size = New Size(1108, 377)
        Grafica1.TabIndex = 11
        ' 
        ' Panelr4
        ' 
        Panelr4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr4.BackColor = Color.White
        Panelr4.Controls.Add(Chart2)
        Panelr4.ForeColor = Color.White
        Panelr4.Location = New Point(2, 2)
        Panelr4.Name = "Panelr4"
        Panelr4.Size = New Size(1102, 371)
        Panelr4.TabIndex = 1
        ' 
        ' Chart2
        ' 
        Chart2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ChartArea7.Name = "ChartArea1"
        Chart2.ChartAreas.Add(ChartArea7)
        Legend7.Name = "Legend1"
        Chart2.Legends.Add(Legend7)
        Chart2.Location = New Point(0, 0)
        Chart2.Margin = New Padding(3, 2, 3, 2)
        Chart2.Name = "Chart2"
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Series1"
        Chart2.Series.Add(Series7)
        Chart2.Size = New Size(1080, 369)
        Chart2.TabIndex = 0
        ' 
        ' Panelr9
        ' 
        Panelr9.BackColor = SystemColors.ButtonFace
        Panelr9.Controls.Add(Panelr10)
        Panelr9.Dock = DockStyle.Fill
        Panelr9.Location = New Point(1128, 193)
        Panelr9.Margin = New Padding(10, 0, 0, 0)
        Panelr9.Name = "Panelr9"
        TableLayoutPanel1.SetRowSpan(Panelr9, 2)
        Panelr9.Size = New Size(551, 776)
        Panelr9.TabIndex = 18
        ' 
        ' Panelr10
        ' 
        Panelr10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr10.BackColor = Color.White
        Panelr10.Controls.Add(Chart5)
        Panelr10.Location = New Point(2, 2)
        Panelr10.Name = "Panelr10"
        Panelr10.Size = New Size(545, 770)
        Panelr10.TabIndex = 0
        ' 
        ' Chart5
        ' 
        Chart5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ChartArea8.Name = "ChartArea1"
        Chart5.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        Chart5.Legends.Add(Legend8)
        Chart5.Location = New Point(0, 0)
        Chart5.Margin = New Padding(3, 2, 3, 2)
        Chart5.Name = "Chart5"
        Series8.ChartArea = "ChartArea1"
        Series8.Legend = "Legend1"
        Series8.Name = "Series1"
        Chart5.Series.Add(Series8)
        Chart5.Size = New Size(529, 766)
        Chart5.TabIndex = 1
        Chart5.Text = "Chart5"
        ' 
        ' Panel9
        ' 
        Panel9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel9.BackColor = SystemColors.ButtonFace
        Panel9.Controls.Add(Panelr8)
        Panel9.Location = New Point(0, -5)
        Panel9.Margin = New Padding(0, 0, 20, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(1720, 89)
        Panel9.TabIndex = 1
        ' 
        ' Panelr8
        ' 
        Panelr8.BackColor = Color.White
        Panelr8.Location = New Point(0, 0)
        Panelr8.Name = "Panelr8"
        Panelr8.Size = New Size(1720, 83)
        Panelr8.TabIndex = 0
        ' 
        ' Panelr5
        ' 
        Panelr5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr5.BackColor = SystemColors.ButtonFace
        Panelr5.Controls.Add(Panelr11)
        Panelr5.Location = New Point(1128, 0)
        Panelr5.Margin = New Padding(10, 0, 0, 20)
        Panelr5.Name = "Panelr5"
        Panelr5.Size = New Size(551, 173)
        Panelr5.TabIndex = 19
        ' 
        ' Panelr11
        ' 
        Panelr11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panelr11.BackColor = Color.White
        Panelr11.Location = New Point(2, 2)
        Panelr11.Name = "Panelr11"
        Panelr11.Size = New Size(545, 167)
        Panelr11.TabIndex = 0
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        Controls.Add(Panel9)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Dashboard"
        Size = New Size(1720, 1080)
        TableLayoutPanel1.ResumeLayout(False)
        Panelr2.ResumeLayout(False)
        Grafica3.ResumeLayout(False)
        Panelr6.ResumeLayout(False)
        CType(Chart3, ComponentModel.ISupportInitialize).EndInit()
        Grafica4.ResumeLayout(False)
        Panelr7.ResumeLayout(False)
        CType(Chart4, ComponentModel.ISupportInitialize).EndInit()
        PanelRedondeado1.ResumeLayout(False)
        Grafica1.ResumeLayout(False)
        Panelr4.ResumeLayout(False)
        CType(Chart2, ComponentModel.ISupportInitialize).EndInit()
        Panelr9.ResumeLayout(False)
        Panelr10.ResumeLayout(False)
        CType(Chart5, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        Panelr5.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart4 As DataVisualization.Charting.Chart
    Friend WithEvents Panel9 As PanelR
    Friend WithEvents PanelRedondeado1 As PanelR
    Friend WithEvents Grafica1 As PanelR
    Friend WithEvents Grafica4 As PanelR
    Friend WithEvents Grafica3 As PanelR
    Friend WithEvents Panelr2 As PanelR
    Friend WithEvents Panelr3 As PanelR
    Friend WithEvents Panelr1 As PanelR
    Friend WithEvents Panelr4 As PanelR
    Friend WithEvents Panelr6 As PanelR
    Friend WithEvents Panelr7 As PanelR
    Friend WithEvents Panelr8 As PanelR
    Friend WithEvents Panelr9 As PanelR
    Friend WithEvents Panelr10 As PanelR
    Friend WithEvents Chart5 As DataVisualization.Charting.Chart
    Friend WithEvents Panelr5 As PanelR
    Friend WithEvents Panelr11 As PanelR

End Class
