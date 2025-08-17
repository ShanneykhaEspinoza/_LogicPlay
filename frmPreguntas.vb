Imports System.IO
Public Class frmPreguntas
    Dim ruta_archivo As String = ""

    Friend Sub REINICIAR()
        txtPreguntaCuestionario.Clear()
        txtTiempo.Clear()
        txtRespuestaErronea3.Clear()
        txtRespuestaErronea2.Clear()
        txtRespuestaErronea1.Clear()
        txtRespuestaCorrecta.Clear()
        txtPuntos.Clear()
        ruta_archivo = ""
        VIDEO.URL = ""
        VIDEO.Visible = False
        IMAGEN.Visible = False
    End Sub
    Private Sub btnVerPreguntasAlmacenadas_Click(sender As Object, e As EventArgs)
        frmPreguntasAlmacenadas.Show()
        Me.Hide()
    End Sub

    Friend Sub ACTIVAR()
        If txtPreguntaCuestionario.Text <> "" And txtRespuestaCorrecta.Text <> "" And txtPuntos.Text <> "" And txtTiempo.Text <> "" And txtRespuestaErronea2.Text <> "" Then
            btnGuardarPreguntas.Enabled = True
        Else
            btnGuardarPreguntas.Enabled = False
        End If
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmPreguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Nuevo_Cuestionario = True Then
            Cuestionario.Text = CN_Cuestionario
            REINICIAR()
        Else
            Cuestionario.Text = CN_Cuestionario
        End If
        If Agregar_preguntas = True Then

        End If
    End Sub

    Private Sub btnAgregarImagen_Click(sender As Object, e As EventArgs) Handles btnAgregarImagen.Click
        ABRIR.Filter = "Audio, Video e imagenes |*.mp4;*.flac;*.m4v;*.avi;*.mp3;*.m4a;*.wma;*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        If ABRIR.ShowDialog() = DialogResult.OK Then
            ruta_archivo = ABRIR.FileName
            Dim TIPO As String = Path.GetExtension(ruta_archivo).ToLowerInvariant()

            If TIPO = ".mp3" OrElse TIPO = ".flac" OrElse TIPO = ".avi" OrElse TIPO = ".mp4" OrElse TIPO = ".wma" OrElse TIPO = ".m4a" Then
                VIDEO.URL = ruta_archivo
                VIDEO.Visible = True
                VIDEO.Ctlcontrols.play()
                IMAGEN.Visible = False
            ElseIf TIPO = ".jpg" OrElse TIPO = ".jpeg" OrElse TIPO = ".png" OrElse TIPO = ".bmp" OrElse TIPO = ".gif" Then
                IMAGEN.Image = Image.FromFile(ruta_archivo)
                IMAGEN.Visible = True
                VIDEO.URL = ""
                VIDEO.Visible = False
            Else
                VIDEO.URL = ""
                VIDEO.Visible = False
                IMAGEN.Visible = False
            End If
        Else
            ruta_archivo = ""
        End If

    End Sub

    Private Sub btnGuardarPreguntas_Click(sender As Object, e As EventArgs) Handles btnGuardarPreguntas.Click
        Dim extension As String
        Dim dato_hexa As String
        Dim Id_pregunta As Integer

        If Nuevo_Cuestionario = True Then
            Try
                T.Tables.Clear()
                Dim ID As Integer
                SQL = "SELECT ID_QUIZZ FROM QUIZZ WHERE NOMBRE = '" & Cuestionario.Text & "'"
                CARGAR_TABLA(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    ID = T.Tables(0).Rows(0).Item(0)
                End If

                T.Tables.Clear()



                If ruta_archivo <> "" Then
                    '-----------------Encargado de guardar el archivo en binario y conseguir la direccion o ruta del archivo--------------

                    Dim nombre_archivo As String = Path.GetFileName(ruta_archivo)
                    extension = Path.GetExtension(ruta_archivo)
                    Dim datos() As Byte = File.ReadAllBytes(ruta_archivo)


                    '-----------------Se encarga de convertir los datos binarios del archivo en hexadecimal para poder ingresarlo---------
                    '-------------------en el SQL, ademas hay que agregar 0x para que funcione en SQL y quitarle los (-) que--------------
                    '---------------------agrega el "BitConverter.Tostring()" para que salga seguido en numero hexadecimal----------------
                    dato_hexa = "0x" & BitConverter.ToString(datos).Replace("-", "")
                Else
                    extension = "NULL"
                    dato_hexa = "NULL"
                End If

                Id_pregunta = PK("PREGUNTA", "ID_PREGUNTA")

                SQL = "INSERT INTO PREGUNTA (ID_PREGUNTA, ID_QUIZZ, PREGUNTA, TIEMPO_SEGUNDOS, ARCHIVO, EXTENSION, RUTA, PUNTOS) VALUES(" & PK("PREGUNTA", "ID_PREGUNTA") & ", '" & ID & "', '" & txtPreguntaCuestionario.Text & "', '" & txtTiempo.Text & "', " & dato_hexa & ", '" & extension & "', '" & ruta_archivo & "', '" & txtPuntos.Text & "')"
                EJECUTAR(SQL)

                T.Tables.Clear()

                SQL = "INSERT INTO RESPUESTA (ID_RESPUESTA, ID_PREGUNTA, TEXTO_RESPUESTA, CORRECTA) VALUES(" & PK("RESPUESTA", "ID_RESPUESTA") & ", '" & Id_pregunta & "', '" & txtRespuestaCorrecta.Text & "', 1)"
                EJECUTAR(SQL)
                T.Tables.Clear()

                If txtRespuestaErronea1.Text <> "" Then
                    SQL = "INSERT INTO RESPUESTA (ID_RESPUESTA, ID_PREGUNTA, TEXTO_RESPUESTA, CORRECTA) VALUES(" & PK("RESPUESTA", "ID_RESPUESTA") & ", '" & Id_pregunta & "', '" & txtRespuestaErronea1.Text & "', 0)"
                    EJECUTAR(SQL)
                    T.Tables.Clear()
                End If

                If txtRespuestaErronea2.Text <> "" Then
                    SQL = "INSERT INTO RESPUESTA (ID_RESPUESTA, ID_PREGUNTA, TEXTO_RESPUESTA, CORRECTA) VALUES(" & PK("RESPUESTA", "ID_RESPUESTA") & ", '" & Id_pregunta & "', '" & txtRespuestaErronea2.Text & "', 0)"
                    EJECUTAR(SQL)
                    T.Tables.Clear()
                End If

                If txtRespuestaErronea3.Text <> "" Then
                    SQL = "INSERT INTO RESPUESTA (ID_RESPUESTA, ID_PREGUNTA, TEXTO_RESPUESTA, CORRECTA) VALUES(" & PK("RESPUESTA", "ID_RESPUESTA") & ", '" & Id_pregunta & "', '" & txtRespuestaErronea3.Text & "', 0)"
                    EJECUTAR(SQL)
                    T.Tables.Clear()
                End If

                REINICIAR()
            Catch ex As Exception
                MessageBox.Show("Error al guardar: " & ex.Message)
            End Try
        Else

            If ruta_archivo <> "" Then
                T.Tables.Clear()
                Dim ID As Integer
                SQL = "SELECT ID_QUIZZ FROM QUIZZ WHERE NOMBRE = '" & Cuestionario.Text & "'"
                CARGAR_TABLA(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    ID = T.Tables(0).Rows(0).Item(0)
                End If

                Dim nombre_archivo As String = Path.GetFileName(ruta_archivo)
                extension = Path.GetExtension(ruta_archivo)
                Dim datos() As Byte = File.ReadAllBytes(ruta_archivo)

                dato_hexa = "0x" & BitConverter.ToString(datos).Replace("-", "")


                SQL = "UPDATE PREGUNTA SET PREGUNTA = '" & txtPreguntaCuestionario.Text & "', TIEMPO_SEGUNDOS = '" & txtTiempo.Text & "', PUNTOS = '" & txtPuntos.Text & "', ARCHIVO = " & dato_hexa & ", EXTENSION = '" & extension & "' WHERE ID_PREGUNTA = " & Guna2CirclePictureBox1.Tag
                EJECUTAR(SQL)

                SQL = "UPDATE RESPUESTA SET TEXTO_RESPUESTA = '" & txtRespuestaCorrecta.Text & "' WHERE CORRECTA = " & 1 & " AND ID_PREGUNTA = " & Guna2CirclePictureBox1.Tag
                EJECUTAR(SQL)
                T.Tables.Clear()

                SQL = "SELECT ID_RESPUESTA FROM RESPUESTA WHERE ID_PREGUNTA = " & Guna2CirclePictureBox1.Tag & " AND CORRECTA = " & 0
                CARGAR_TABLA(T, SQL)

                For I = 0 To T.Tables(0).Rows.Count - 1

                    Dim actualizar_respuesta As New Integer

                    actualizar_respuesta = T.Tables(0).Rows(I).Item(0)

                    If I = 0 Then
                        SQL = "UPDATE RESPUESTA SET TEXTO_RESPUESTA = '" & txtRespuestaErronea2.Text & "' WHERE ID_RESPUESTA = " & actualizar_respuesta
                        EJECUTAR(SQL)
                    End If

                    If I = 1 Then
                        SQL = "UPDATE RESPUESTA SET TEXTO_RESPUESTA = '" & txtRespuestaErronea1.Text & "' WHERE ID_RESPUESTA = " & actualizar_respuesta
                        EJECUTAR(SQL)
                    End If

                    If I = 2 Then
                        SQL = "UPDATE RESPUESTA SET TEXTO_RESPUESTA = '" & txtRespuestaErronea3.Text & "' WHERE ID_RESPUESTA = " & actualizar_respuesta
                        EJECUTAR(SQL)
                    End If
                Next
                REINICIAR()
            Else

                SQL = "UPDATE PREGUNTA SET PREGUNTA = '" & txtPreguntaCuestionario.Text & "', TIEMPO_SEGUNDOS = '" & txtTiempo.Text & "', PUNTOS = '" & txtPuntos.Text & "' WHERE ID_PREGUNTA = " & Guna2CirclePictureBox1.Tag
                EJECUTAR(SQL)

                SQL = "UPDATE RESPUESTA SET TEXTO_RESPUESTA = '" & txtRespuestaCorrecta.Text & "' WHERE CORRECTA = " & 1 & " AND ID_PREGUNTA = " & Guna2CirclePictureBox1.Tag
                EJECUTAR(SQL)
                T.Tables.Clear()

                SQL = "SELECT ID_RESPUESTA FROM RESPUESTA WHERE ID_PREGUNTA = " & Guna2CirclePictureBox1.Tag & " AND CORRECTA = " & 0
                CARGAR_TABLA(T, SQL)

                For I = 0 To T.Tables(0).Rows.Count - 1

                    Dim actualizar_respuesta As New Integer

                    actualizar_respuesta = T.Tables(0).Rows(I).Item(0)

                    If I = 0 Then
                        SQL = "UPDATE RESPUESTA SET TEXTO_RESPUESTA = '" & txtRespuestaErronea2.Text & "' WHERE ID_RESPUESTA = " & actualizar_respuesta
                        EJECUTAR(SQL)
                    End If

                    If I = 1 Then
                        SQL = "UPDATE RESPUESTA SET TEXTO_RESPUESTA = '" & txtRespuestaErronea1.Text & "' WHERE ID_RESPUESTA = " & actualizar_respuesta
                        EJECUTAR(SQL)
                    End If

                    If I = 2 Then
                        SQL = "UPDATE RESPUESTA SET TEXTO_RESPUESTA = '" & txtRespuestaErronea3.Text & "' WHERE ID_RESPUESTA = " & actualizar_respuesta
                        EJECUTAR(SQL)
                    End If
                Next
                REINICIAR()
            End If
        End If
    End Sub

    Private Sub txtPreguntaCuestionario_TextChanged(sender As Object, e As EventArgs) Handles txtPreguntaCuestionario.TextChanged
        ACTIVAR()
    End Sub

    Private Sub txtRespuestaCorrecta_TextChanged(sender As Object, e As EventArgs) Handles txtRespuestaCorrecta.TextChanged
        ACTIVAR()
    End Sub

    Private Sub txtRespuestaErronea2_TextChanged(sender As Object, e As EventArgs) Handles txtRespuestaErronea2.TextChanged
        ACTIVAR()
    End Sub

    Private Sub txtTiempo_TextChanged(sender As Object, e As EventArgs) Handles txtTiempo.TextChanged
        ACTIVAR()
    End Sub

    Private Sub txtPuntos_TextChanged(sender As Object, e As EventArgs) Handles txtPuntos.TextChanged
        ACTIVAR()
    End Sub

    Private Sub txtTiempo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTiempo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar números", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub txtPuntos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPuntos.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar números", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnVerPreguntasAlmacenadas_Click_1(sender As Object, e As EventArgs) Handles btnVerPreguntasAlmacenadas.Click
        If Nuevo_Cuestionario = False Then
            frmPreguntasAlmacenadas.Cuestionario.Text = Cuestionario.Text
        End If

        frmPreguntasAlmacenadas.Show()
        Me.Close()
    End Sub
End Class