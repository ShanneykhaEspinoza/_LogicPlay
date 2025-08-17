Imports System.IO
Public Class frmPreguntasAlmacenadas
    Dim ultima_ruta As String
    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        If Nuevo_Cuestionario = False Then
            frmAdministrarCuestionarios.Show()
            Me.Close()
            Exit Sub
        End If

        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardarPreguntas.Click
        frmMenu.Show()
        Me.Close()

    End Sub

    Friend Sub BUSCANDO()
        Dim ID_QUIZZ As Integer
        Dim Respuesta As String
        Dim Correcta As String

        T.Tables.Clear()
        SQL = "SELECT ID_QUIZZ FROM QUIZZ WHERE NOMBRE = '" & Cuestionario.Text & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            ID_QUIZZ = T.Tables(0).Rows(0).Item(0)
        End If

        Tt.Tables.Clear()
        SQL = "SELECT ID_PREGUNTA, PREGUNTA, TIEMPO_SEGUNDOS FROM PREGUNTA WHERE ID_QUIZZ = " & ID_QUIZZ
        CARGAR_TABLA(Tt, SQL)


        L_PreguntasAlmacenadas.Items.Clear()
        If Tt.Tables(0).Rows.Count > 0 Then
            For I = 0 To Tt.Tables(0).Rows.Count - 1
                T.Tables.Clear()
                SQL = "SELECT TEXTO_RESPUESTA, CORRECTA, ID_RESPUESTA FROM RESPUESTA WHERE ID_PREGUNTA = " & Tt.Tables(0).Rows(I).ItemArray(0)
                CARGAR_TABLA(T, SQL)

                For R = 0 To T.Tables(0).Rows.Count - 1
                    Respuesta = T.Tables(0).Rows(R).Item(0)
                    Correcta = T.Tables(0).Rows(R).Item(1)
                    Dim Buena_Mala As String

                    If Correcta = True Then
                        Buena_Mala = "Correcta"
                    Else
                        Buena_Mala = "Incorrecta"
                    End If

                    L_PreguntasAlmacenadas.Items.Add(Tt.Tables(0).Rows(I).ItemArray(0))
                    For J = 1 To 5
                        If J = 1 Then
                            L_PreguntasAlmacenadas.Items(L_PreguntasAlmacenadas.Items.Count - 1).SubItems.Add(Tt.Tables(0).Rows(I).ItemArray(J))
                        End If
                        If J = 2 Then
                            L_PreguntasAlmacenadas.Items(L_PreguntasAlmacenadas.Items.Count - 1).SubItems.Add(Tt.Tables(0).Rows(I).ItemArray(J))
                        End If
                        If J = 3 Then
                            L_PreguntasAlmacenadas.Items(L_PreguntasAlmacenadas.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(R).ItemArray(2))
                        End If
                        If J = 4 Then
                            L_PreguntasAlmacenadas.Items(L_PreguntasAlmacenadas.Items.Count - 1).SubItems.Add(Respuesta)
                        End If
                        If J = 5 Then
                            L_PreguntasAlmacenadas.Items(L_PreguntasAlmacenadas.Items.Count - 1).SubItems.Add(Buena_Mala)
                        End If
                    Next
                Next
            Next
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub frmPreguntasAlmacenadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Nuevo_Cuestionario = True Then
            Cuestionario.Text = CN_Cuestionario
        Else
            CN_Cuestionario = Cuestionario.Text
        End If
        BUSCANDO()
    End Sub

    Private Sub btnAgregarCuestionario_Click(sender As Object, e As EventArgs) Handles btnAgregarCuestionario.Click

        Nuevo_Cuestionario = True
        frmPreguntas.Show()
        Me.Close()

    End Sub

    Private Sub btnEditarCuestionario_Click(sender As Object, e As EventArgs) Handles btnEditarRespuestas.Click
        Nuevo_Cuestionario = False
        If MsgBox("¿Desea actualizar esta información?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
            If L_PreguntasAlmacenadas.SelectedItems.Count > 0 Then
                Dim ID As Integer = L_PreguntasAlmacenadas.SelectedItems(0).SubItems(0).Text
                frmPreguntas.Guna2CirclePictureBox1.Tag = ID

                MessageBox.Show(ID)

                T.Tables.Clear()
                SQL = "SELECT PREGUNTA, TIEMPO_SEGUNDOS, PUNTOS, ARCHIVO, EXTENSION FROM PREGUNTA WHERE ID_PREGUNTA = " & ID & ""
                CARGAR_TABLA(T, SQL)

                frmPreguntas.txtPreguntaCuestionario.Text = T.Tables(0).Rows(0).ItemArray(0)
                frmPreguntas.txtTiempo.Text = T.Tables(0).Rows(0).ItemArray(1)
                frmPreguntas.txtPuntos.Text = T.Tables(0).Rows(0).ItemArray(2)
                Dim extension As String = T.Tables(0).Rows(0).ItemArray(4)

                Dim archivo() As Byte
                Dim Carpeta As String = Path.GetTempPath()
                Directory.CreateDirectory(Carpeta)


                Dim Ruta_nueva = Carpeta & "Archivo_" & extension

                If ultima_ruta <> "" Then
                    frmPreguntas.VIDEO.Ctlcontrols.stop()
                    frmPreguntas.VIDEO.URL = ""
                    File.Delete(ultima_ruta)
                End If

                If frmPreguntas.IMAGEN.Image IsNot Nothing Then
                    frmPreguntas.IMAGEN.Dispose()
                    frmPreguntas.IMAGEN.Image = Nothing
                End If

                ultima_ruta = Ruta_nueva

                If T.Tables(0).Rows(0).Item(3).ToString <> "" Then
                    archivo = T.Tables(0).Rows(0).Item(3)
                    File.WriteAllBytes(Ruta_nueva, archivo)
                End If

                If extension = ".mp3" OrElse extension = ".flac" OrElse extension = ".avi" OrElse extension = ".mp4" OrElse extension = ".wma" OrElse extension = ".m4a" Then
                    frmPreguntas.VIDEO.URL = Ruta_nueva
                    frmPreguntas.VIDEO.Visible = True
                    frmPreguntas.VIDEO.Ctlcontrols.play()
                    frmPreguntas.IMAGEN.Visible = False
                ElseIf extension = ".jpg" OrElse extension = ".jpeg" OrElse extension = ".png" OrElse extension = ".bmp" OrElse extension = ".gif" Then
                    Using datos_foto As New FileStream(Ruta_nueva, FileMode.Open, FileAccess.Read)
                        Using foto As Image = Image.FromStream(datos_foto)
                            frmPreguntas.IMAGEN.Image = New Bitmap(foto)
                        End Using
                    End Using

                    frmPreguntas.IMAGEN.Visible = True
                    frmPreguntas.VIDEO.URL = ""
                    frmPreguntas.VIDEO.Visible = False
                Else
                    frmPreguntas.VIDEO.URL = ""
                    frmPreguntas.VIDEO.Visible = False
                    frmPreguntas.IMAGEN.Visible = False
                End If


                T.Tables.Clear()
                SQL = "SELECT TEXTO_RESPUESTA FROM RESPUESTA WHERE ID_PREGUNTA = " & ID & " AND CORRECTA = " & 1
                CARGAR_TABLA(T, SQL)

                frmPreguntas.txtRespuestaCorrecta.Text = T.Tables(0).Rows(0).ItemArray(0)

                T.Tables.Clear()
                SQL = "SELECT TEXTO_RESPUESTA FROM RESPUESTA WHERE ID_PREGUNTA = " & ID & " AND CORRECTA = " & 0
                CARGAR_TABLA(T, SQL)

                For i = 0 To T.Tables(0).Rows.Count - 1
                    If i = 0 Then
                        frmPreguntas.txtRespuestaErronea2.Text = T.Tables(0).Rows(i).ItemArray(0)
                    End If
                    If i = 1 Then
                        frmPreguntas.txtRespuestaErronea1.Text = T.Tables(0).Rows(i).ItemArray(0)
                    End If
                    If i = 2 Then
                        frmPreguntas.txtRespuestaErronea3.Text = T.Tables(0).Rows(i).ItemArray(0)
                    End If
                Next

            End If

            frmPreguntas.Show()
            Me.Close()
        End If
    End Sub

    Private Sub L_PreguntasAlmacenadas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_PreguntasAlmacenadas.SelectedIndexChanged
        If L_PreguntasAlmacenadas.SelectedItems.Count > 0 Then
            btnEditarRespuestas.Enabled = True
        End If
    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        Dim ID_R As Integer
        Dim ID_P As Integer

        If L_PreguntasAlmacenadas.SelectedItems.Count > 0 Then

            If L_PreguntasAlmacenadas.SelectedItems(0).SubItems(5).Text = "Correcta" Then
                ID_P = L_PreguntasAlmacenadas.SelectedItems(0).SubItems(0).Text
                If MsgBox("Si la respuesta es la correcta se eliminara todas las respuestas y la pregunta ¿Desea eliminar la información seleccionada?", vbQuestion + vbYesNo, "Confirme") = vbYes Then
                    SQL = "DELETE FROM RESPUESTA WHERE ID_PREGUNTA =" & ID_P
                    EJECUTAR(SQL)

                    SQL = "DELETE FROM PREGUNTA WHERE ID_PREGUNTA =" & ID_P
                    EJECUTAR(SQL)

                    BUSCANDO()
                    MsgBox("La información ha sido eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Concluido con éxito")
                End If
            Else
                ID_R = L_PreguntasAlmacenadas.SelectedItems(0).SubItems(3).Text
                If MsgBox("¿Desea eliminar la información seleccionada?", vbQuestion + vbYesNo, "Confirme") = vbYes Then
                    SQL = "DELETE FROM RESPUESTA WHERE ID_RESPUESTA   = " & ID_R & ""
                    EJECUTAR(SQL)
                    BUSCANDO()
                    MsgBox("La información ha sido eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Concluido con éxito")
                End If

            End If
        End If
    End Sub
End Class