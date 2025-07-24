Public Class frmMenuParticipante
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnIngresarCodigo_Click(sender As Object, e As EventArgs) Handles btnIngresarCodigo.Click
        frmCodigoParticipante.Show()
        Me.Hide()
    End Sub

    Private Sub frmMenuParticipante_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class