Imports Windows.Win32.UI

Public Class Usuario
    Dim tampan As Integer
    Dim ver As Boolean
    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ver = False
        Bordes(pbFoto, 10)
        tampan = PSombraSeguridad.Width
        btnActualizar.MinimumSize = New Size(20, 20)
        btnFoto.Size = New Size(btnFoto.Width, btnFoto.Width)
        pbFoto.Size = New Size(pbFoto.Width, pbFoto.Width)
        btnVer.Size = New Size(btnVer.Width, btnVer.Width)
        btnSee.Size = New Size(btnSee.Width, btnSee.Width)
        btnGuardar.Size = New Size(btnGuardar.Width, btnGuardar.Width)
        btnCancelar.Size = New Size(btnCancelar.Width, btnCancelar.Width)
        btnSave.Size = New Size(btnSave.Width, btnSave.Width)
        btnHide.Size = New Size(btnHide.Width, btnHide.Width)
        '[Panelr2.Size = New Size(Panelr2.Height, Panelr2.Height)
    End Sub

    Private Sub Usuario_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Bordes(btnEstadistica, 10)
        Bordes(btnCambiarCuenta, 10)
        TamTexto(lbSeguridad, "Segoe UI", 20, FontStyle.Bold, tampan, PSombraSeguridad)
        TamTexto(lbCorreo, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(lbPss, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(txtCorreo, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(txtPss, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)

        TamTexto(lbDatos, "Segoe UI", 20, FontStyle.Bold, tampan, PSombraSeguridad)
        TamTexto(lbNombre, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(lbApp, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(lbApm, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(lbDireccion, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(lbEdad, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(lbTelefono, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(txtNombre, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(txtApp, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(txtApm, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(txtDireccion, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(txtEdad, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(txtTelefono, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)

        TamTexto(lbInformacion, "Segoe UI", 20, FontStyle.Bold, tampan, PSombraSeguridad)
        TamTexto(lbLetreroPuesto, "Segoe UI", 20, FontStyle.Bold, tampan, PSombraSeguridad)
        TamTexto(lbLetreroNombre, "Segoe UI", 20, FontStyle.Bold, tampan, PSombraSeguridad)
        TamTexto(lbLetreroFR, "Segoe UI", 20, FontStyle.Bold, tampan, PSombraSeguridad)
        TamTexto(lbFechaRegistro, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(lbNomCompleto, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)
        TamTexto(lbPuesto, "Segoe UI", 20, FontStyle.Regular, tampan, PSombraSeguridad)

        TamTexto(btnCancelar, "Arial", 20, FontStyle.Bold, tampan, PSombraSeguridad)
        TamTexto(btnHide, "Arial", 20, FontStyle.Bold, tampan, PSombraSeguridad)
        TamTexto(btnCambiarCuenta, "Arial", 10, FontStyle.Bold, tampan, PSombraSeguridad)
        TamTexto(btnEstadistica, "Arial", 10, FontStyle.Bold, tampan, PSombraSeguridad)

        btnActualizar.Size = New Size(btnActualizar.Width, btnActualizar.Width)
        btnFoto.Size = New Size(btnFoto.Width, btnFoto.Width)
        pbFoto.Size = New Size(pbFoto.Width, pbFoto.Width)
        btnGuardar.Size = New Size(btnGuardar.Width, btnGuardar.Width)
        btnCancelar.Size = New Size(btnCancelar.Width, btnCancelar.Width)
        btnVer.Size = New Size(btnVer.Width, btnVer.Width)
        btnSee.Size = New Size(btnSee.Width, btnSee.Width)
        btnSave.Size = New Size(btnSave.Width, btnSave.Width)
        btnHide.Size = New Size(btnHide.Width, btnHide.Width)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        txtNombre.Focus()
        txtNombre.Enabled = True
        txtApp.Enabled = True
        txtApm.Enabled = True
        txtEdad.Enabled = True
        txtTelefono.Enabled = True
        txtDireccion.Enabled = True
        btnGuardar.Visible = True
        btnCancelar.Visible = True
        btnActualizar.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNombre.Enabled = False
        txtApp.Enabled = False
        txtApm.Enabled = False
        txtEdad.Enabled = False
        txtTelefono.Enabled = False
        txtDireccion.Enabled = False
        btnGuardar.Visible = False
        btnCancelar.Visible = False
        btnActualizar.Enabled = True
    End Sub

    Private Sub KeyDownMedio(sender As Control, e As KeyEventArgs) Handles txtNombre.KeyDown, txtApp.KeyDown, txtApm.KeyDown, txtEdad.KeyDown, txtTelefono.KeyDown, txtDireccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If sender.TabIndex = 5 Then
                e.SuppressKeyPress = True
                Return
            End If

            Me.SelectNextControl(sender, True, True, True, True)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub KeyDownSeguridad(sender As Control, e As KeyEventArgs) Handles txtCorreo.KeyDown, txtPss.KeyDown
        If e.KeyCode = Keys.Enter Then
            If sender.TabIndex = 1 Then
                e.SuppressKeyPress = True
                Return
            End If

            Me.SelectNextControl(sender, True, True, True, True)
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        If txtPss.Text.Contains("*") Then

        End If


        If ver = True Then
            btnVer.BackgroundImage = My.Resources.hide
            txtCorreo.PasswordChar = "*"
            txtPss.PasswordChar = "*"
            ver = False
        Else
            Dim confirmar As New Transparente()
            Dim segunda As New opConfirmar
            confirmar.pantalla = segunda
            confirmar.ShowDialog()
            btnGuardar.Size = New Size(btnGuardar.Width, btnGuardar.Width)
            btnCancelar.Size = New Size(btnCancelar.Width, btnCancelar.Width)
            'Dim valor As String
            'valor = InputBox("Ingresa un valor:", "Entrada requerida")

            'If valor <> "" Then
            'MessageBox.Show("Ingresaste: " & valor)
            'End If
            btnVer.BackgroundImage = My.Resources.see
            txtCorreo.PasswordChar = ""
            txtPss.PasswordChar = ""
            ver = True
        End If
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        Dim abrir As New OpenFileDialog()

        abrir.Title = "Selecciona una imagen"
        abrir.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If abrir.ShowDialog() = DialogResult.OK Then
            pbFoto.BackgroundImage = Image.FromFile(abrir.FileName)
        End If
    End Sub

    Private Sub btnSee_Click(sender As Object, e As EventArgs) Handles btnSee.Click
        txtCorreo.Enabled = True
        txtPss.Enabled = True
        txtCorreo.Focus()
        btnSave.Visible = True
        btnHide.Visible = True
        btnSee.Enabled = False
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        txtCorreo.Enabled = False
        txtPss.Enabled = False
        btnSave.Visible = False
        btnHide.Visible = False
        btnSee.Enabled = True
    End Sub
End Class