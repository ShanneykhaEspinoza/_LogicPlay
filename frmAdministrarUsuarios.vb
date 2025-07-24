Public Class frmAdministrarUsuarios


    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        frmRegistro.Show()
        Me.Hide()
    End Sub
End Class