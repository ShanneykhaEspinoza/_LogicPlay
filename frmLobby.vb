Imports System.Timers
Public Class frmLobby
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        T.Tables.Clear()
        SQL = ""
        SQL = "UPDATE PARTICIPACION SET INICIADA = 0 WHERE ID_USUARIO = " & SESION_USUARIO
        EJECUTAR(SQL)
        frmInicioPartida.Show()
        Me.Hide()
    End Sub

    Private Sub btnIniciarPartida_Click(sender As Object, e As EventArgs) Handles btnIniciarPartida.Click
        T.Tables.Clear()
        SQL = "UPDATE PARTICIPACION SET INICIADA = 1 WHERE CODIGO_SESION = '" & txtCodigo.Text & "'"
        EJECUTAR(SQL)

    End Sub

    Private Sub frmLobby_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim timer As Timer = New Timer(1000)
        AddHandler timer.Elapsed, New ElapsedEventHandler(AddressOf TimerElapsed)
        timer.SynchronizingObject = Me
        timer.AutoReset = True
        timer.Start()
    End Sub

    Friend Sub TimerElapsed(ByVal sender As Object, ByVal e As ElapsedEventArgs)
        REFRESCAR_USUARIOS()
    End Sub

    Friend Sub REFRESCAR_USUARIOS()
        Dim ID_USUARIO As Integer
        Dim PUNTOS As Integer
        listaUsuariosUnidosAPartida.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT ID_USUARIO, ID_QUIZZ FROM PARTICIPACION WHERE CODIGO_SESION = '" & txtCodigo.Text & "'"
        CARGAR_TABLA(T, SQL)

        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                ID_USUARIO = T.Tables(0).Rows(I).Item(0)

                Tt.Tables.Clear()
                SQL = "SELECT ID_USUARIO, NOMBRE_COMPLETO FROM USUARIO WHERE ID_USUARIO = " & ID_USUARIO & " AND ID_ROL = 2"
                CARGAR_TABLA(Tt, SQL)

                If Tt.Tables(0).Rows.Count = 0 Then
                    Continue For
                End If

                listaUsuariosUnidosAPartida.Items.Add(Tt.Tables(0).Rows(0).Item(0))
                listaUsuariosUnidosAPartida.Items(listaUsuariosUnidosAPartida.Items.Count - 1).SubItems.Add(Tt.Tables(0).Rows(0).ItemArray(1))

                'T.Tables.Clear()
                'SQL = "SELECT PUNTAJE_OBTENIDO FROM RESPUESTA_USUARIO WHERE ID_USUARIO = " & ID_USUARIO

            Next
        End If
    End Sub
End Class
