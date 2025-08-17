Imports System.Text
Public Class frmInicioPartida
    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmMenu.Show()
        cbxCuestionario.Items.Clear()
        Me.Close()
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
            T.Tables.Clear()
            '--------------Verificacion de que no se repitan los codigos--------------------
            SQL = "SELECT CODIGO_SESION FROM PARTICIPACION WHERE CODIGO_SESION = '" & codigo & "'"
            CARGAR_TABLA(T, SQL)
            If T.Tables.Count > 0 And T.Tables(0).Rows.Count = 0 Then
                existe = False
            End If

        End While

        Return codigo

    End Function

    Private Sub btnCompartirCodigo_Click(sender As Object, e As EventArgs) Handles btnCompartirCodigo.Click
        Dim ID_QUIZZ As String
        Dim codigo As String = CreacionCodigo()
        Dim Fecha As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        T.Tables.Clear()
        SQL = "SELECT ID_QUIZZ FROM QUIZZ WHERE NOMBRE = '" & cbxCuestionario.Text & "'"
        CARGAR_TABLA(T, SQL)

        ID_QUIZZ = T.Tables(0).Rows(0).Item(0)
        frmLobby.txtCodigo.Text = codigo

        T.Tables.Clear()
        SQL = "INSERT INTO PARTICIPACION (ID_PARTICIPACION, ID_USUARIO, ID_QUIZZ, PUNTAJE_TOTAL, CODIGO_SESION, P_FECHA, INICIADA) VALUES(" & PK("PARTICIPACION", "ID_PARTICIPACION") & ", " & SESION_USUARIO & ", " & ID_QUIZZ & ", " & 0 & ", '" & codigo & "', '" & Fecha & "', '" & 0 & "')"
        EJECUTAR(SQL)

        frmLobby.Show()
        Me.Hide()

    End Sub

    Friend Sub CARGAR_CUESTIONARIOS()
        cbxCuestionario.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT NOMBRE FROM QUIZZ"
        CARGAR_TABLA(T, SQL)

        If T.Tables(0).Rows.Count > 0 Then
            For FILA = 0 To T.Tables(0).Rows.Count - 1
                cbxCuestionario.Items.Add(T.Tables(0).Rows(FILA).ItemArray(0))
            Next
        End If
    End Sub

    Private Sub frmInicioPartida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGAR_CUESTIONARIOS()
    End Sub

    Private Sub cbxCuestionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCuestionario.SelectedIndexChanged
        btnCompartirCodigo.Enabled = True
    End Sub
End Class