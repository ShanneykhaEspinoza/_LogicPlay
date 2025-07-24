Public Class frmPreguntas
    Private Sub btnVerPreguntasAlmacenadas_Click(sender As Object, e As EventArgs) Handles btnVerPreguntasAlmacenadas.Click
        frmPreguntasAlmacenadas.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmAdministrarCuestionarios.Show()
        Me.Hide()

    End Sub

    Private Sub btnAgregarImagen_Click(sender As Object, e As EventArgs) Handles btnAgregarImagen.Click
        If ABRIR.ShowDialog = DialogResult.OK Then
            btnAgregarImagen.Image = Image.FromFile(ABRIR.FileName)
            btnAgregarImagen.Tag = ABRIR.FileName
        Else
            btnAgregarImagen.Tag = ""

        End If
    End Sub




    'My.Computer.Audio.Play(My.Resources.TUSONIDO, AudioPlayMode.Background)

End Class