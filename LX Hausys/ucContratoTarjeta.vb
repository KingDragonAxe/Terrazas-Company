Imports System.Drawing.Imaging
Imports System.Security.Cryptography

Public Class ucContratoTarjeta
    'Private contenido As New TagList
    Private Sub ucContratoTarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Efecto_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter, lbFecha.MouseEnter, Label1.MouseEnter, lbID.MouseEnter, lbMonto.MouseEnter, lbNombre.MouseEnter, lbResto.MouseEnter, lbServicio.MouseEnter, lbTipo.MouseEnter, Label10.MouseEnter, Label12.MouseEnter, Label3.MouseEnter, Label6.MouseEnter, Label8.MouseEnter, Panel1.MouseEnter, Panelr1.MouseEnter, pPrincipal.MouseEnter
        pPrincipal.BackColor = Color.FromArgb(240, 230, 255)
        Me.BackColor = Color.FromArgb(96, 62, 136)
        pPrincipal.Cursor = Cursors.Hand
    End Sub
    Private Sub Efecto_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave, lbFecha.MouseLeave, Label1.MouseLeave, lbID.MouseLeave, lbMonto.MouseLeave, lbNombre.MouseLeave, lbResto.MouseLeave, lbServicio.MouseLeave, lbTipo.MouseLeave, Label10.MouseLeave, Label12.MouseLeave, Label3.MouseLeave, Label6.MouseLeave, Label8.MouseLeave, Panel1.MouseLeave, Panelr1.MouseLeave, pPrincipal.MouseLeave
        pPrincipal.BackColor = Color.White
        Me.BackColor = SystemColors.ButtonFace
    End Sub
End Class
