Public Class frmPreguntas
    Private Sub btnVerPreguntasAlmacenadas_Click(sender As Object, e As EventArgs) Handles btnVerPreguntasAlmacenadas.Click
        frmPreguntasAlmacenadas.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmAdministrarCuestionarios.Show()
        Me.Hide()

    End Sub

End Class