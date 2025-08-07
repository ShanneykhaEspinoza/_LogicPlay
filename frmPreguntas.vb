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
    End Sub
    Private Sub btnVerPreguntasAlmacenadas_Click(sender As Object, e As EventArgs) Handles btnVerPreguntasAlmacenadas.Click
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
        frmCreacionCuestionario.Show()
        Me.Close()

    End Sub

    Private Sub frmPreguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Nuevo_Cuestionario = True Then
            Cuestionario.Text = CN_Cuestionario
        End If
        REINICIAR()
    End Sub

    Private Sub btnAgregarImagen_Click(sender As Object, e As EventArgs) Handles btnAgregarImagen.Click
        ABRIR.Filter = "Todos los archivos|*.*"
        If ABRIR.ShowDialog() = DialogResult.OK Then
            ruta_archivo = ABRIR.FileName
        Else
            ruta_archivo = ""
        End If
    End Sub

    Private Sub btnGuardarPreguntas_Click(sender As Object, e As EventArgs) Handles btnGuardarPreguntas.Click
        Try
            T.Tables.Clear()
            Dim ID As Integer
            SQL = "SELECT ID_QUIZZ FROM QUIZZ WHERE NOMBRE = '" & Cuestionario.Text & "'"
            CARGAR_TABLA(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                ID = T.Tables(0).Rows(0).Item(0)
            End If

            T.Tables.Clear()


            Dim extension As String
            Dim dato_hexa As String
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

            SQL = "INSERT INTO PREGUNTA (ID_PREGUNTA, ID_QUIZZ, PREGUNTA, TIEMPO_SEGUNDOS, ARCHIVO, EXTENSION) VALUES(" & PK("PREGUNTA", "ID_PREGUNTA") & ", '" & ID & "', '" & txtPreguntaCuestionario.Text & "', '" & txtTiempo.Text & "', " & dato_hexa & ", '" & extension & "')"
            EJECUTAR(SQL)

            T.Tables.Clear()

            Dim Id_pregunta As Integer
            SQL = "SELECT ID_PREGUNTA FROM PREGUNTA WHERE PREGUNTA = '" & txtPreguntaCuestionario.Text & "'"
            CARGAR_TABLA(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                Id_pregunta = T.Tables(0).Rows(0).Item(0)
            End If

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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmPreguntasAlmacenadas.Show()
        Me.Hide()
    End Sub

End Class