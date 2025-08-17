Public Class frmCodigoParticipante
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmMenuParticipante.Show()
        Me.Hide()

    End Sub

    Private Sub btnCopiarCodigo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCopiarCodigo_Click_1(sender As Object, e As EventArgs) Handles btnCopiarCodigo.Click
        Dim Comenzo_partida As Boolean = False
        Dim Fecha As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")


        T.Tables.Clear()
        SQL = "SELECT ID_QUIZZ FROM PARTICIPACION WHERE CODIGO_SESION = '" & txtCodigoIngresadoJugador.Text & "'"
        CARGAR_TABLA(T, SQL)

        If T.Tables(0).Rows.Count > 0 Then
            ID_QUIZZ_PARTIDA = T.Tables(0).Rows(0).Item(0)
            frmPantallaEspera.Show()
            Comenzo_partida = True
        Else
            MsgBox("No se encontro una cuestionario disponible con ese codigo en este momento.", vbInformation + vbOKOnly, "No existe cuestionario")
        End If

        If Comenzo_partida = True Then
            T.Tables.Clear()
            SQL = "INSERT INTO PARTICIPACION (ID_PARTICIPACION, ID_USUARIO, ID_QUIZZ, PUNTAJE_TOTAL, CODIGO_SESION, P_FECHA, INICIADA) VALUES(" & PK("PARTICIPACION", "ID_PARTICIPACION") & ", " & SESION_USUARIO & ", " & ID_QUIZZ_PARTIDA & ", " & 0 & ", '" & txtCodigoIngresadoJugador.Text & "', '" & Fecha & "', '" & 0 & "')"
            EJECUTAR(SQL)

            Tt.Tables.Clear()
            SQL = "SELECT ID_PARTICIPACION FROM PARTICIPACION WHERE ID_USUARIO = " & SESION_USUARIO & " AND ID_QUIZZ = " & ID_QUIZZ_PARTIDA & " AND CODIGO_SESION = '" & txtCodigoIngresadoJugador.Text & "' AND P_FECHA = '" & Fecha & "'"
            CARGAR_TABLA(Tt, SQL)
            If Tt.Tables(0).Rows.Count > 0 Then
                ID_PARTICIPACION = Tt.Tables(0).Rows(0).Item(0)
            End If
        End If

    End Sub

    Private Sub txtCodigoIngresadoJugador_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoIngresadoJugador.TextChanged
        btnCopiarCodigo.Enabled = True
    End Sub
End Class