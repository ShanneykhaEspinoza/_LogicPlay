Public Class frmRegistro
    Private Sub btnAlmacenarRegistro_Click(sender As Object, e As EventArgs) Handles btnAlmacenarRegistro.Click


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
End Class