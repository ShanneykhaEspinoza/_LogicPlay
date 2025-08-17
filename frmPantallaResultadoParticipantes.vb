Public Class frmPantallaResultadoParticipantes
    Private Sub btnAlmacenarRespuestaParticipante_Click(sender As Object, e As EventArgs) Handles btnAlmacenarRespuestaParticipante.Click
        frmMenuParticipante.Show()
        Me.Close()

    End Sub

    Private Sub frmPantallaResultadoParticipantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPUNTOS.Text = Contador_respuestas_correctas.ToString() & " / " & Contador_preguntas.ToString()
        frmCodigoParticipante.Close()
    End Sub

End Class