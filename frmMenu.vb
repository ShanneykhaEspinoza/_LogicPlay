Public Class frmMenu
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdministrarUsuarios_Click(sender As Object, e As EventArgs) Handles btnAdministrarUsuarios.Click
        frmAdministrarUsuarios.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdministrarCuestionario_Click(sender As Object, e As EventArgs) Handles btnAdministrarCuestionario.Click
        frmAdministrarCuestionarios.Show()
        Me.Hide()

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciarPartida.Click
        frmInicioPartida.Show()
        Me.Hide()

    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class