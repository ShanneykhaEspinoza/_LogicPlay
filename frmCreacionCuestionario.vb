Imports System.Text
Public Class frmCreacionCuestionario


    Private Sub btnGuardarPreguntas_Click(sender As Object, e As EventArgs) Handles btnGuardarPreguntas.Click
        Dim Fecha As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        CN_Cuestionario = ""
        CN_Cuestionario = txtNombreCuestionario.Text

        '-----------------Validacion que no se repitan los cuestionarios con el mismo nombre-----------
        If Nuevo_Cuestionario = True Then
            T.Tables.Clear()

            SQL = "SELECT ID_QUIZZ FROM QUIZZ WHERE NOMBRE = '" & txtNombreCuestionario.Text & "'"
            CARGAR_TABLA(T, SQL)

            If T.Tables(0).Rows.Count > 0 Then
                Dim ID As Integer = T.Tables(0).Rows(0).Item(0)
                MsgBox("Ya existe un cuestionario con ese nombre, elija algun otro.", vbInformation + vbOKOnly,)
                Exit Sub
            End If
        End If

        If Nuevo_Cuestionario = True Then
            T.Tables.Clear()
            '-----------------Insertar los datos de los cuestionarios en la base de dato (QUIZZ)-----------
            SQL = "INSERT INTO QUIZZ (ID_QUIZZ, NOMBRE, FECHA_CREACION) VALUES(" & PK("QUIZZ", "ID_QUIZZ") & ", '" & txtNombreCuestionario.Text & "', '" & Fecha & "')"
            EJECUTAR(SQL)

            txtNombreCuestionario.Clear()
            frmPreguntas.Show()
            Me.Close()
        Else
            T.Tables.Clear()
            '-----------------Actualiza los datos de los cuestionarios en la base de dato (QUIZZ)-----------
            SQL = "UPDATE QUIZZ SET NOMBRE = '" & txtNombreCuestionario.Text & "', FECHA_CREACION = '" & Fecha & "' WHERE ID_QUIZZ = " & Guna2CirclePictureBox1.Tag & ""
            EJECUTAR(SQL)

            txtNombreCuestionario.Clear()
            frmAdministrarCuestionarios.Show()
            Me.Close()
        End If


    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmAdministrarCuestionarios.Show()
        Me.Close()
    End Sub
End Class