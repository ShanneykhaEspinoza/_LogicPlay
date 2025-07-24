Public Class frmRegistro
    Private Sub btnAlmacenarRegistro_Click(sender As Object, e As EventArgs) Handles btnAlmacenarRegistro.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub txtCédulaUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtCédulaUsuario.TextChanged
        Dim ch(10) As Char
        Dim len As Integer
        len = txtCédulaUsuario.Text.Length
        ch = txtCédulaUsuario.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Inserte un valor numerico")
                txtCédulaUsuario.Clear()
            End If
        Next
    End Sub
End Class