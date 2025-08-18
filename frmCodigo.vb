Public Class frmCodigo
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmInicioPartida.Show()
        Me.Hide()

    End Sub

    Private Sub btnIniciarPartida_Click(sender As Object, e As EventArgs) Handles btnIniciarPartida.Click
        frmEnPartida.Show()
        Me.Hide()
    End Sub
End Class