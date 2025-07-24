Public Class frmPreguntasAlmacenadas
    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmPreguntas.Show()
        Me.Hide()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardarPreguntas.Click
        frmMenu.Show()
        Me.Hide()

    End Sub
End Class