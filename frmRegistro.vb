Public Class frmRegistro
    Private _formularioAnterior As Form
    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(ByVal formularioLlamador As Form)
        InitializeComponent()
        _formularioAnterior = formularioLlamador

    End Sub

    Private Sub btnAlmacenarRegistro_Click(sender As Object, e As EventArgs) Handles btnAlmacenarRegistro.Click
        Dim contraseniaOriginal As String = txtContraseniaUsuario.Text
        Dim contraseniaConfirmacion As String = txtConfirmarContrasenia.Text

        If String.IsNullOrWhiteSpace(contraseniaOriginal) OrElse String.IsNullOrWhiteSpace(contraseniaConfirmacion) Then
            MessageBox.Show("Por favor, ingresa y confirma tu contraseña.", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If contraseniaOriginal = contraseniaConfirmacion Then

            If NUEVO_USER = True Then
                SQL = "INSERT INTO USUARIO (ID_USUARIO, NOMBRE_COMPLETO, CEDULA, CLAVE, ID_ROL) VALUES(" & PK("USUARIO", "ID_USUARIO") & ", '" & txtNombreUsuario.Text & "', '" & txtCedulaUsuario.Text & "', '" & txtContraseniaUsuario.Text & "', 2)"
            Else
                SQL = "UPDATE USUARIO SET NOMBRE_COMPLETO = '" & txtNombreUsuario.Text & "', CEDULA = '" & txtCedulaUsuario.Text & "', CLAVE = '" & txtContraseniaUsuario.Text & "' WHERE ID_USUARIO = " & IDU_OBJ.Tag & " "
            End If

            EJECUTAR(SQL)
            MessageBox.Show("Usuario registrado exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If _formularioAnterior IsNot Nothing Then

                _formularioAnterior.Show()
            Else

                frmLogin.Show()

            End If
            Me.Hide()
        Else
            MessageBox.Show("Las contraseñas no coinciden. Por favor intentalo de nuevo.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContraseniaUsuario.Clear()
            txtConfirmarContrasenia.Clear()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If _formularioAnterior IsNot Nothing Then

            _formularioAnterior.Show()

        Else

            frmLogin.Show()

        End If

        Me.Hide()
    End Sub

    Private Sub txtCédulaUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtCedulaUsuario.TextChanged
        Dim ch(10) As Char
        Dim len As Integer
        len = txtCedulaUsuario.Text.Length
        ch = txtCedulaUsuario.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Inserte un valor numero")
                txtCedulaUsuario.Clear()
            End If
        Next
    End Sub

    Private Sub txtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtNombreUsuario.TextChanged

    End Sub

    Private Sub txtNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreUsuario.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub



    Private Sub txtContraseniaUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtContraseniaUsuario.TextChanged

    End Sub
End Class