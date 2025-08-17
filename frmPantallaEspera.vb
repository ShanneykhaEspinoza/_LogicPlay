Imports System.Timers
Public Class frmPantallaEspera
    Dim timer As Timer
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer = New Timer(1000)
        AddHandler timer.Elapsed, New ElapsedEventHandler(AddressOf EmpezarPartida)
        timer.SynchronizingObject = Me
        timer.AutoReset = True
        timer.Start()

        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Friend Sub EmpezarPartida(ByVal sender As Object, ByVal e As ElapsedEventArgs)
        T.Tables.Clear()
        SQL = "SELECT INICIADA FROM PARTICIPACION WHERE CODIGO_SESION = '" & frmCodigoParticipante.txtCodigoIngresadoJugador.Text & "'"
        CARGAR_TABLA(T, SQL)

        If T.Tables(0).Rows.Count > 0 Then
            If T.Tables(0).Rows(0).Item(0) = True Then
                frmEnPartida.Show()
                Me.Close()
                timer.Stop()
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblMovimiento.Left += 5

        If lblMovimiento.Left > Me.ClientSize.Width Then
            lblMovimiento.Left = -lblMovimiento.Width
        End If

    End Sub

End Class