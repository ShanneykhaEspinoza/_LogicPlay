Public Class frmAdministrarCuestionarios

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnAgregarPreguntas_Click(sender As Object, e As EventArgs) Handles btnAgregarCuestionario.Click
        frmCreacionCuestionario.Show()
        Me.Hide()
    End Sub

    Friend Sub BUSCANDO(ByVal CONTENIDO As String)
        T.Tables.Clear()
        L_ADMINCUESTIONARIO.Items.Clear()
        'NOTA: arrglar ID
        SQL = "SELECT ID_QUIZZ, NOMBRE, FECHA_CREACION FROM QUIZZ WHERE NOMBRE LIKE '%" & CONTENIDO & "%'"
        CARGAR_TABLA(T, SQL)

        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                L_ADMINCUESTIONARIO.Items.Add(T.Tables(0).Rows(I).ItemArray(0))
                For J = 1 To 4
                    If J = 1 Then
                        L_ADMINCUESTIONARIO.Items(L_ADMINCUESTIONARIO.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).ItemArray(1))
                    End If
                    If J = 2 Then
                        L_ADMINCUESTIONARIO.Items(L_ADMINCUESTIONARIO.Items.Count - 1).SubItems.Add("Ya casi lo agrego")
                    End If
                    If J = 3 Then
                        L_ADMINCUESTIONARIO.Items(L_ADMINCUESTIONARIO.Items.Count - 1).SubItems.Add("Ya casi lo agrego")
                    End If
                    If J = 4 Then
                        L_ADMINCUESTIONARIO.Items(L_ADMINCUESTIONARIO.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).ItemArray(2))
                    End If
                Next
            Next
            ELIMINAR.Enabled = True
        Else
            ELIMINAR.Enabled = False
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BUSCANDO(txtBuscar.Text)
    End Sub

    Private Sub L_ADMINCUESTIONARIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_ADMINCUESTIONARIO.SelectedIndexChanged
    End Sub

    Private Sub ELIMINAR_Click_1(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        Dim ID As Integer
        If L_ADMINCUESTIONARIO.SelectedItems.Count > 0 Then
            ID = L_ADMINCUESTIONARIO.SelectedItems(0).SubItems(0).Text
            If MsgBox("¿Desea eliminar la información seleccionada?", vbQuestion + vbYesNo, "Confirme") = vbYes Then
                SQL = "DELETE FROM QUIZZ WHERE ID_QUIZZ = " & ID & ""
                EJECUTAR(SQL)
                BUSCANDO(txtBuscar.Text)
                MsgBox("La información ha sido eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Concluido con éxito")
            End If
        End If
    End Sub

    Private Sub btnEditarCuestionario_Click(sender As Object, e As EventArgs) Handles btnEditarCuestionario.Click

    End Sub
End Class