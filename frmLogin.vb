Public Class frmLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        LOGIN(txtCedulaRegistrada.Text, txtContraseniaRegistrada.Text)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmRegistro.Show()
        Me.Hide()
    End Sub

    Friend Sub LOGIN(ByVal CEDULA As String, ByVal CLAVE As String)
        T.Tables.Clear()

        SQL = "SELECT CEDULA, CLAVE, ROL FROM USUARIOS WHERE CEDULA = '" & CEDULA & "' AND CLAVE = '" & CLAVE & "'"
        CARGAR_TABLA(T, SQL)

        Dim ROL As String = T.Tables(0).Rows(0).ItemArray(2)

        If T.Tables(0).Rows.Count > 0 Then
            MsgBox("Inicio de sesión exitoso", vbInformation + vbOKOnly)
            If (ROL = "ADMIN") Then
                frmMenu.Show()
                Me.Hide()
            Else
                frmMenuParticipante.Show()
                Me.Hide()
            End If
        Else
            MsgBox("Cédula o clave incorrecta", vbInformation + vbOKOnly)
        End If

    End Sub

    Private Sub txtCedulaRegistrada_TextChanged(sender As Object, e As EventArgs) Handles txtCedulaRegistrada.TextChanged
        Dim ch(10) As Char
        Dim len As Integer
        len = txtCedulaRegistrada.Text.Length
        ch = txtCedulaRegistrada.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Inserte un valor numerico")
                txtCedulaRegistrada.Clear()
            End If
        Next


    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
