Public Class frmAdministrarCuestionarios

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    Friend Sub BUSCANDO(ByVal CONTENIDO As String)
        Try
            T.Tables.Clear()
            L_ADMINCUESTIONARIO.Items.Clear()
            SQL = "SELECT ID_QUIZZ, NOMBRE, FECHA_CREACION FROM QUIZZ WHERE NOMBRE LIKE '%" & CONTENIDO & "%'"
            CARGAR_TABLA(T, SQL)


            If T.Tables(0).Rows.Count > 0 Then
                For I = 0 To T.Tables(0).Rows.Count - 1
                    Tt.Tables.Clear()
                    SQL = "SELECT ID_PREGUNTA FROM PREGUNTA WHERE ID_QUIZZ = " & T.Tables(0).Rows(I).Item(0)
                    CARGAR_TABLA(Tt, SQL)
                    Dim contador_p As Integer = 0

                    For p = 0 To Tt.Tables(0).Rows.Count - 1
                        contador_p += 1
                    Next

                    L_ADMINCUESTIONARIO.Items.Add(T.Tables(0).Rows(I).ItemArray(0))
                    For J = 1 To 4
                        If J = 1 Then
                            L_ADMINCUESTIONARIO.Items(L_ADMINCUESTIONARIO.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).ItemArray(1))
                        End If
                        If J = 2 Then
                            L_ADMINCUESTIONARIO.Items(L_ADMINCUESTIONARIO.Items.Count - 1).SubItems.Add(contador_p)
                        End If
                        If J = 3 Then
                            L_ADMINCUESTIONARIO.Items(L_ADMINCUESTIONARIO.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).ItemArray(2))
                        End If
                    Next
                Next
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar cuestionarios: " & ex.Message, "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
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

    Private Sub btnAgregarCuestionario_Click(sender As Object, e As EventArgs) Handles btnAgregarCuestionario.Click
        Nuevo_Cuestionario = True
        frmCreacionCuestionario.Show()
        Me.Close()
    End Sub

    Private Sub btnEditarCuestionario_Click_1(sender As Object, e As EventArgs) Handles btnEditarCuestionario.Click
        Nuevo_Cuestionario = False
        If MsgBox("¿Desea actualizar esta información?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
            If L_ADMINCUESTIONARIO.SelectedItems.Count > 0 Then
                Dim ID As Integer = L_ADMINCUESTIONARIO.SelectedItems(0).SubItems(0).Text
                T.Tables.Clear()
                SQL = "SELECT ID_QUIZZ, NOMBRE FROM QUIZZ WHERE ID_QUIZZ = " & ID & ""
                CARGAR_TABLA(T, SQL)

                frmCreacionCuestionario.txtNombreCuestionario.Text = T.Tables(0).Rows(0).ItemArray(1) 'nombre
                frmCreacionCuestionario.Guna2CirclePictureBox1.Tag = T.Tables(0).Rows(0).ItemArray(0) 'nombre

                frmCreacionCuestionario.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnVerCuestionario_Click(sender As Object, e As EventArgs) Handles btnVerCuestionario.Click
        Nuevo_Cuestionario = False
        If L_ADMINCUESTIONARIO.SelectedItems.Count > 0 Then
            Dim ID As Integer = L_ADMINCUESTIONARIO.SelectedItems(0).SubItems(0).Text
            T.Tables.Clear()
            SQL = "SELECT NOMBRE FROM QUIZZ WHERE ID_QUIZZ = " & ID & ""
            CARGAR_TABLA(T, SQL)

            frmPreguntasAlmacenadas.Cuestionario.Text = T.Tables(0).Rows(0).ItemArray(0) 'nombre


            frmPreguntasAlmacenadas.Show()
            Me.Close()
        End If
    End Sub
End Class