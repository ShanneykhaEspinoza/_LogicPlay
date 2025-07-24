Public Class frmLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtCedulaRegistrada.Text = "123" Then
            frmMenu.Show()
            Me.Hide()
        ElseIf txtCedulaRegistrada.Text = "098" Then
            frmMenuParticipante.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmRegistro.Show()
        Me.Hide()
    End Sub

    Private Sub txtCedulaRegistrada_TextChanged(sender As Object, e As EventArgs) Handles txtCedulaRegistrada.TextChanged
        Dim ch(10) As Char
        Dim len As Integer
        len = txtCedulaRegistrada.Text.Length
        ch = txtCedulaRegistrada.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Inserte un valor numerico")
                txtCedulaRegistrada.Clear()
            End If
        Next
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
