Public Class frmAdministrarCuestionarios

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnAgregarPreguntas_Click(sender As Object, e As EventArgs) Handles btnAgregarCuestionario.Click
        frmPreguntas.Show()
        Me.Hide()
    End Sub
End Class