Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing.Text

Public Class frmEnPartida
    Dim puntos As Integer
    Dim random As New Random()
    Dim Pregunta_actual As New Integer
    Dim ultima_ruta As String

    '-----TIEMPO EN PROGRESSBAR-----
    Private tiempoTotal As Integer = 0
    Private tiempoRestante As Integer = 0

    Private Sub btnAlmacenarRespuestaParticipante_Click(sender As Object, e As EventArgs) Handles btnAlmacenarRespuestaParticipante.Click
        Dim id_respuesta_elegida As Integer
        Dim puntos_ganados As Integer


        If btnRespuesta1.Checked = True Then
            id_respuesta_elegida = txtRespuesta1.Tag

            T.Tables.Clear()
            SQL = "SELECT CORRECTA FROM RESPUESTA WHERE ID_RESPUESTA = " & id_respuesta_elegida
            CARGAR_TABLA(T, SQL)

            If T.Tables(0).Rows(0).Item(0) = True Then
                Contador_respuestas_correctas += 1
            End If

        End If
        If btnRespuesta2.Checked = True Then
            id_respuesta_elegida = txtRespuesta2.Tag

            T.Tables.Clear()
            SQL = "SELECT CORRECTA FROM RESPUESTA WHERE ID_RESPUESTA = " & id_respuesta_elegida
            CARGAR_TABLA(T, SQL)

            If T.Tables(0).Rows(0).Item(0) = True Then
                Contador_respuestas_correctas += 1
            End If
        End If
        If btnRespuesta3.Checked = True Then
            id_respuesta_elegida = txtRespuesta3.Tag

            T.Tables.Clear()
            SQL = "SELECT CORRECTA FROM RESPUESTA WHERE ID_RESPUESTA = " & id_respuesta_elegida
            CARGAR_TABLA(T, SQL)

            If T.Tables(0).Rows(0).Item(0) = True Then
                Contador_respuestas_correctas += 1
            End If
        End If
        If btnRespuesta4.Checked = True Then
            id_respuesta_elegida = txtRespuesta4.Tag

            T.Tables.Clear()
            SQL = "SELECT CORRECTA FROM RESPUESTA WHERE ID_RESPUESTA = " & id_respuesta_elegida
            CARGAR_TABLA(T, SQL)

            If T.Tables(0).Rows(0).Item(0) = True Then
                Contador_respuestas_correctas += 1
            End If
        End If

        Ttt.Tables.Clear()
        SQL = "SELECT CORRECTA, ID_PREGUNTA FROM RESPUESTA WHERE ID_RESPUESTA = " & id_respuesta_elegida
        CARGAR_TABLA(Ttt, SQL)

        Dim PREGUNTA_PARTICIPACION As Integer = Ttt.Tables(0).Rows(0).Item(1)

        If Ttt.Tables(0).Rows(0).Item(0) = True Then
            puntos_ganados = puntos
        Else
            puntos_ganados = 0
        End If

        T.Tables.Clear()
        SQL = "INSERT INTO RESPUESTA_USUARIO (ID_RESPUESTA_USUARIO, ID_PREGUNTAS, ID_RESPUESTA, ID_PARTICIPACION, PUNTAJE_OBTENIDO) VALUES(" & PK("RESPUESTA_USUARIO", "ID_RESPUESTA_USUARIO") & ", '" & PREGUNTA_PARTICIPACION & "', '" & id_respuesta_elegida & "', '" & ID_PARTICIPACION & "', " & puntos_ganados & ")"
        EJECUTAR(SQL)

        CARGAR_PREGUNTAS()
        CARGAR_RESPUESTAS()
    End Sub

    Friend Sub CARGAR_RESPUESTAS()
        Dim orden_respuestas As New List(Of Integer)
        orden_respuestas = RESPUESTAS_RANDOM()

        txtRespuesta1.Visible = False
        btnRespuesta1.Visible = False
        btnRespuesta1.Checked = False

        txtRespuesta2.Visible = False
        btnRespuesta2.Visible = False
        btnRespuesta2.Checked = False

        txtRespuesta3.Visible = False
        btnRespuesta3.Visible = False
        btnRespuesta3.Checked = False

        txtRespuesta4.Visible = False
        btnRespuesta4.Visible = False
        btnRespuesta4.Checked = False


        btnAlmacenarRespuestaParticipante.Enabled = False

        For I = 0 To orden_respuestas.Count - 1

            Dim ID_RESPUESTA_TAG As Integer = orden_respuestas(I)

            T.Tables.Clear()
            SQL = "SELECT TEXTO_RESPUESTA FROM RESPUESTA WHERE ID_RESPUESTA = " & orden_respuestas(I)
            CARGAR_TABLA(T, SQL)

            Select Case orden_respuestas(I)
                Case orden_respuestas(0)
                    If T.Tables(0).Rows(0).Item(0) <> "" Then
                        txtRespuesta1.Text = T.Tables(0).Rows(0).Item(0)
                        txtRespuesta1.Visible = True
                        btnRespuesta1.Visible = True
                        txtRespuesta1.Tag = ID_RESPUESTA_TAG
                    End If

                Case orden_respuestas(1)
                    If T.Tables(0).Rows(0).Item(0) <> "" Then
                        txtRespuesta2.Text = T.Tables(0).Rows(0).Item(0)
                        txtRespuesta2.Visible = True
                        btnRespuesta2.Visible = True
                        txtRespuesta2.Tag = ID_RESPUESTA_TAG
                    End If

                Case orden_respuestas(2)
                    If T.Tables(0).Rows(0).Item(0) <> "" Then
                        txtRespuesta3.Text = T.Tables(0).Rows(0).Item(0)
                        txtRespuesta3.Visible = True
                        btnRespuesta3.Visible = True
                        txtRespuesta3.Tag = ID_RESPUESTA_TAG
                    End If

                Case orden_respuestas(3)
                    If T.Tables(0).Rows(0).Item(0) <> "" Then
                        txtRespuesta4.Text = T.Tables(0).Rows(0).Item(0)
                        txtRespuesta4.Visible = True
                        btnRespuesta4.Visible = True
                        txtRespuesta4.Tag = ID_RESPUESTA_TAG
                    End If
            End Select
        Next

    End Sub
    Friend Sub CARGAR_PREGUNTAS()
        Dim ID_PREGUNTA_FINAL As Integer = PREGUNTAS_RANDOM()
        Pregunta_actual = ID_PREGUNTA_FINAL
        '------DA UN ERROR RELACIONADO A PREGUNTA DE BASE DE DATOS---
        'CuentaRegresiva(ID_PREGUNTA_FINAL)

        If ID_PREGUNTA_FINAL = -1 Then
            Dim puntos_totales As Integer

            T.Tables.Clear()
            SQL = "SELECT PUNTAJE_OBTENIDO FROM RESPUESTA_USUARIO USUARIO WHERE ID_PARTICIPACION = " & ID_PARTICIPACION
            CARGAR_TABLA(T, SQL)

            If T.Tables(0).Rows.Count > 0 Then
                For i = 0 To T.Tables(0).Rows.Count - 1
                    puntos_totales += T.Tables(0).Rows(i).Item(0)
                Next
            End If

            T.Tables.Clear()
            SQL = "UPDATE PARTICIPACION SET PUNTAJE_TOTAL = " & puntos_totales & ", INICIADA = " & 0 & " WHERE ID_PARTICIPACION = " & ID_PARTICIPACION & ""
            EJECUTAR(SQL)

            frmPantallaResultadoParticipantes.Show()
            Me.Close()
            Exit Sub
        End If

        T.Tables.Clear()
        SQL = "SELECT PREGUNTA, TIEMPO_SEGUNDOS, ARCHIVO, PUNTOS, EXTENSION FROM PREGUNTA WHERE ID_PREGUNTA = " & ID_PREGUNTA_FINAL
        CARGAR_TABLA(T, SQL)

        If T.Tables(0).Rows.Count > 0 Then
            Nombre_pregunta.Text = T.Tables(0).Rows(0).Item(0)
            '-------------SELECCIONA EL TIEMPO_JUEGO DESDE AQUI (SHANNE)--------------------------------------


            '----AVECES SALE UN ERROR EN PUNTOS Y NO SE POR QUE-------
            puntos = T.Tables(0).Rows(0).Item(3)
            Dim extension As String = T.Tables(0).Rows(0).Item(4).ToString

            Dim archivo() As Byte
            Dim Carpeta As String = Path.GetTempPath()
            Directory.CreateDirectory(Carpeta)


            Dim Ruta_nueva = Carpeta & "Archivo_" & ID_PREGUNTA_FINAL & extension

            If ultima_ruta <> "" Then
                VIDEO.Ctlcontrols.stop()
                VIDEO.URL = ""
                File.Delete(ultima_ruta)
            End If

            If IMAGEN.Image IsNot Nothing Then
                IMAGEN.Dispose()
                IMAGEN.Image = Nothing
            End If

            ultima_ruta = Ruta_nueva

            If T.Tables(0).Rows(0).Item(2).ToString <> "" Then
                archivo = T.Tables(0).Rows(0).Item(2)
                File.WriteAllBytes(Ruta_nueva, archivo)
            End If

            If extension = ".mp3" OrElse extension = ".flac" OrElse extension = ".avi" OrElse extension = ".mp4" OrElse extension = ".wma" OrElse extension = ".m4a" Then
                    VIDEO.URL = Ruta_nueva
                    VIDEO.Visible = True
                    VIDEO.Ctlcontrols.play()
                IMAGEN.Visible = False
                lbOcultar.Visible = True
            ElseIf extension = ".jpg" OrElse extension = ".jpeg" OrElse extension = ".png" OrElse extension = ".bmp" OrElse extension = ".gif" Then
                Using datos_foto As New FileStream(Ruta_nueva, FileMode.Open, FileAccess.Read)
                    Using foto As Image = Image.FromStream(datos_foto)
                        IMAGEN.Image = New Bitmap(foto)
                    End Using
                End Using

                IMAGEN.Visible = True
                VIDEO.URL = ""
                VIDEO.Visible = False
                lbOcultar.Visible = False
            Else
                    VIDEO.URL = ""
                    VIDEO.Visible = False
                IMAGEN.Visible = False
                lbOcultar.Visible = False
            End If

            End If

            If ID_PREGUNTA_FINAL <> -1 Then
            Contador_preguntas += 1
        End If

        CARGAR_RESPUESTAS()
    End Sub

    Friend Function RESPUESTAS_RANDOM() As List(Of Integer)
        Dim lista_respuestas As New List(Of Integer)


        Tt.Tables.Clear()
        SQL = "SELECT ID_RESPUESTA FROM RESPUESTA WHERE ID_PREGUNTA = " & Pregunta_actual
        CARGAR_TABLA(Tt, SQL)

        If Tt.Tables(0).Rows.Count > 0 Then
            For i = 0 To Tt.Tables(0).Rows.Count - 1
                lista_respuestas.Add(Tt.Tables(0).Rows(i).Item(0))
            Next
        End If

        Dim elegida As New List(Of Integer)

        While lista_respuestas.Count > 0
            Dim idx As Integer = random.Next(0, lista_respuestas.Count)
            elegida.Add(lista_respuestas(idx))
            lista_respuestas.RemoveAt(idx)
        End While

        Return elegida

    End Function

    Friend Function PREGUNTAS_RANDOM() As Integer

        T.Tables.Clear()
        SQL = "SELECT ID_PREGUNTA FROM PREGUNTA WHERE ID_QUIZZ = " & ID_QUIZZ_PARTIDA
        CARGAR_TABLA(T, SQL)

        Dim id_preguntas As New List(Of Integer)

        If T.Tables(0).Rows.Count > 0 Then
            For i = 0 To T.Tables(0).Rows.Count - 1
                id_preguntas.Add(T.Tables(0).Rows(i).Item(0))
            Next
        End If

        Dim elegida As Integer = -1
        Dim respondido As Boolean = True


        While respondido AndAlso id_preguntas.Count > 0
            Dim idx As Integer = random.Next(0, id_preguntas.Count)
            Dim pregunta_random As Integer = id_preguntas(idx)

            Tt.Tables.Clear()
            SQL = "SELECT ID_RESPUESTA_USUARIO FROM RESPUESTA_USUARIO WHERE ID_PARTICIPACION =" & ID_PARTICIPACION & " AND ID_PREGUNTAS = " & pregunta_random
            CARGAR_TABLA(Tt, SQL)

            If Tt.Tables.Count > 0 AndAlso Tt.Tables(0).Rows.Count = 0 Then
                elegida = pregunta_random
                respondido = False
            Else
                id_preguntas.RemoveAt(idx)
            End If

        End While

        Return elegida

    End Function

    Private Sub frmEnPartida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Contador_preguntas = 0
        Contador_respuestas_correctas = 0

        VIDEO.enableContextMenu = False
        VIDEO.stretchToFit = True

        CARGAR_PREGUNTAS()


    End Sub


    '--------------------------------------------PROGRESS BAR----------------------------------
    Friend Sub CuentaRegresiva(ByVal idPregunta As Integer)
        Try
            T.Tables.Clear()
            SQL = "SELECT TIEMPO_SEGUNDOS TIEMPO_TS" & "FROM PREGUNTA WHERE ID_PREGUNTA= " & idPregunta
            CARGAR_TABLA(T, SQL)

            tiempoTotal = CInt(T.Tables(0).Rows(0).Item("TIEMPO_TS"))

            scbTiempoRestante.Value = tiempoTotal
            tiempoRestante = tiempoTotal
            scbTiempoRestante.Maximum = tiempoTotal
            Try
                scbTiempoRestante.Text = tiempoRestante.ToString() & " seg."
            Catch ex As Exception
            End Try

            tmrTiempo.Stop()
            tmrTiempo.Interval = 1000
            tmrTiempo.Start()
        Catch ex As Exception
            TmrTiempo.Stop()
            MsgBox("Error al iniciar timer: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub tmrTiempo_Tick(sender As Object, e As EventArgs) Handles tmrTiempo.Tick
        Try
            If tiempoRestante > 0 Then
                tiempoRestante -= 1
                scbTiempoRestante.Value = Math.Max(0, tiempoRestante)

                Try
                    scbTiempoRestante.Text = tiempoRestante.ToString() & " seg."
                Catch ex As Exception

                End Try
            Else
                tmrTiempo.Stop()
                scbTiempoRestante.Value = 0
                Try
                    scbTiempoRestante.Text = "0 seg."
                Catch ex As Exception

                End Try
                TimerOff()
            End If
        Catch ex As Exception
            tmrTiempo.Stop()
            scbTiempoRestante.Value = 0
            Try
                scbTiempoRestante.Text = "0 seg."
            Catch
                MsgBox("Error al iniciar timer: " & ex.Message, vbCritical)
            End Try
            TimerOff()

        End Try
    End Sub

    Private Sub TimerOff()
        ' 1. Buscar la siguiente pregunta en BD
        T.Tables.Clear()
        SQL = "SELECT TOP 1 ID_PREGUNTA, TEXTO, TIEMPOS_SEGUNDOS " &
              "FROM PREGUNTA " &
              "WHERE ID_PREGUNTA > " & Pregunta_actual & " " &
              "ORDER BY ID_PREGUNTA ASC"
        CARGAR_TABLA(T, SQL)

        ' 2. Validar si hay siguiente pregunta
        If T.Tables(0).Rows.Count > 0 Then
            ' Actualizar ID actual
            Pregunta_actual = CInt(T.Tables(0).Rows(0).Item("ID_PREGUNTA"))

            ' Mostrar el texto en tu TextBox

            ' Reiniciar el tiempo de la barra
            tiempoTotal = CInt(T.Tables(0).Rows(0).Item("TIEMPOS_SEGUNDOS"))
            tiempoRestante = tiempoTotal
            scbTiempoRestante.Maximum = tiempoTotal
            scbTiempoRestante.Value = tiempoTotal

            ' (Opcional) si tu barra muestra texto
            Try : scbTiempoRestante.Text = tiempoRestante.ToString() & "s" : Catch : End Try

            ' Reiniciar el timer
            TmrTiempo.Stop()
            TmrTiempo.Start()

        Else
            ' No hay más preguntas
            MsgBox("¡Has terminado todas las preguntas!", vbInformation)
            ' Aquí puedes pasar a resultados o cerrar el juego
        End If
    End Sub

    Private Sub btnRespuesta3_CheckedChanged(sender As Object, e As EventArgs) Handles btnRespuesta3.CheckedChanged
        btnAlmacenarRespuestaParticipante.Enabled = True
    End Sub

    Private Sub btnRespuesta2_CheckedChanged(sender As Object, e As EventArgs) Handles btnRespuesta2.CheckedChanged
        btnAlmacenarRespuestaParticipante.Enabled = True
    End Sub

    Private Sub btnRespuesta1_CheckedChanged(sender As Object, e As EventArgs) Handles btnRespuesta1.CheckedChanged
        btnAlmacenarRespuestaParticipante.Enabled = True
    End Sub

    Private Sub btnRespuesta4_CheckedChanged(sender As Object, e As EventArgs) Handles btnRespuesta4.CheckedChanged
        btnAlmacenarRespuestaParticipante.Enabled = True
    End Sub
End Class