Public Class frmPantallaEspera
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configura el Timer cuando el formulario se carga
        Timer1.Interval = 100 ' Establece el intervalo en milisegundos (100 ms = 10 veces por segundo)
        Timer1.Start()        ' Inicia el Timer para que empiece a contar
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Este código se ejecuta cada vez que el Timer "hace un tick"

        ' Mueve el Label 5 píxeles hacia la derecha
        ' La propiedad Left controla la posición horizontal (coordenada X)
        lblMovimiento.Left += 5

        ' Opcional: Si quieres que desaparezca por el borde derecho y reaparezca por la izquierda
        If lblMovimiento.Left > Me.ClientSize.Width Then
            lblMovimiento.Left = -lblMovimiento.Width ' Mueve el Label completamente fuera del borde izquierdo
        End If

    End Sub

End Class