Imports System.Text
Public Class frmCreacionCuestionario


    Private Sub btnGuardarPreguntas_Click(sender As Object, e As EventArgs) Handles btnGuardarPreguntas.Click
        Dim Fecha As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        CN_Cuestionario = ""
        CN_Cuestionario = txtNombreCuestionario.Text

        '-----------------Validacion que no se repitan los cuestionarios con el mismo nombre-----------

        T.Tables.Clear()

        SQL = "SELECT ID_QUIZZ FROM QUIZZ WHERE NOMBRE = '" & txtNombreCuestionario.Text & "'"
        CARGAR_TABLA(T, SQL)
        If Nuevo_Cuestionario = True Then
            If T.Tables(0).Rows.Count > 0 Then
                Dim ID As Integer = T.Tables(0).Rows(0).Item(0)
                MsgBox("Ya existe un cuestionario con ese nombre, elija algun otro.", vbInformation + vbOKOnly,)
                Exit Sub
            End If
        End If

        T.Tables.Clear()
        '-----------------Insertar LOS cuestionarios datos en la base de dato (QUIZZ)-----------
        SQL = "INSERT INTO QUIZZ (ID_QUIZZ, NOMBRE, CODIGO, FECHA_CREACION) VALUES(" & PK("QUIZZ", "ID_QUIZZ") & ", '" & txtNombreCuestionario.Text & "', '" & CODIGO.Text & "', '" & Fecha & "')"
        EJECUTAR(SQL)
        txtNombreCuestionario.Clear()
        CODIGO.Text = CreacionCodigo()
        frmPreguntas.Show()
        Me.Hide()
    End Sub

    Friend Function CreacionCodigo() As String
        '--------------Creacion de codigo random--------------------
        Dim codigo As String = ""
        Dim existe As Boolean = True
        Dim caracteres As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim random As New Random()

        While existe
            Dim sb As New StringBuilder()
            For i As Integer = 1 To 8
                Dim idx As Integer = random.Next(0, caracteres.Length)
                Dim randomCaracter As Char = caracteres(idx)
                sb.Append(randomCaracter)
            Next i

            codigo = sb.ToString()

            '--------------Verificacion de que no se repitan los codigos--------------------
            SQL = "SELECT CODIGO FROM QUIZZ WHERE CODIGO = '" & codigo & "'"
            CARGAR_TABLA(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                existe = False
            End If

        End While

        Return codigo

    End Function

    Private Sub frmCreacionCuestionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CODIGO.Text = CreacionCodigo()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmAdministrarCuestionarios.Show()
        Me.Close()
    End Sub
End Class