Public Class frmRegistro
    Private Sub btnAlmacenarRegistro_Click(sender As Object, e As EventArgs) Handles btnAlmacenarRegistro.Click
        SQL = "INSERT INTO USUARIO (ID_USUARIO, NOMBRE_COMPLETO, CEDULA, CLAVE, ID_ROL) VALUES(" & PK("USUARIO", "ID_USUARIO") & ", '" & txtNombreUsuario.Text & "', '" & txtCedulaUsuario.Text & "', '" & txtContraseniaUsuario.Text & "')"

        EJECUTAR(SQL)
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmLogin.Show()
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

    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NUEVO_USER = True 'se creará un nuevo usuario
    End Sub
End Class