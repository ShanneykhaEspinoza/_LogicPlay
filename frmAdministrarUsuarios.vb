Public Class frmAdministrarUsuarios
    Friend Sub BUSCANDO(ByVal CONTENIDO As String)
        T.Tables.Clear()
        L_ADMINUSUARIO.Items.Clear()
        'NOTA: arrglar ID
        SQL = "SELECT ID_USUARIO, CEDULA, NOMBRE_COMPLETO, ID_ROL FROM USUARIO WHERE NOMBRE_COMPLETO LIKE '%" & CONTENIDO & "%'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                L_ADMINUSUARIO.Items.Add(T.Tables(0).Rows(I).ItemArray(0))
                For J = 1 To 3

                    L_ADMINUSUARIO.Items(L_ADMINUSUARIO.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).ItemArray(J))
                Next
            Next
            ELIMINAR_ADMINUSUARIO.Enabled = True
        Else
            ELIMINAR_ADMINUSUARIO.Enabled = False
        End If
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        frmRegistro.Show()
        Me.Hide()
    End Sub

    Private Sub txtFiltrarParticipante_TextChanged(sender As Object, e As EventArgs) Handles txtFiltrarParticipante.TextChanged
        BUSCANDO(txtFiltrarParticipante.Text)
    End Sub

    Private Sub ELIMINAR_ADMINUSUARIO_Click(sender As Object, e As EventArgs) Handles ELIMINAR_ADMINUSUARIO.Click
        Dim ID As Integer
        If L_ADMINUSUARIO.SelectedItems.Count > 0 Then
            ID = L_ADMINUSUARIO.SelectedItems(0).SubItems(0).Text
            If MsgBox("¿Desea eliminar la información seleccionada?", vbQuestion + vbYesNo, "Confirme") = vbYes Then
                SQL = "DELETE FROM USUARIO WHERE ID = " & ID & ""
                EJECUTAR(SQL)
                BUSCANDO(txtFiltrarParticipante.Text)
                MsgBox("La información ha sido eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Concluido con éxito")
            End If
        End If
    End Sub

    Private Sub btnEditarUsuario_Click(sender As Object, e As EventArgs) Handles btnEditarUsuario.Click
        If MsgBox("¿Desea actualizar esta información?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
            If L_ADMINUSUARIO.SelectedItems.Count > 0 Then
                Dim ID As Integer = L_ADMINUSUARIO.SelectedItems(0).SubItems(0).Text
                frmRegistro.IDU_OBJ.Tag = ID
                T.Tables.Clear()
                SQL = "SELECT CEDULA, NOMBRE_COMPLETO, CLAVE, ID_ROL FROM USUARIO WHERE ID_USUARIO = " & ID & ""
                CARGAR_TABLA(T, SQL)

                frmRegistro.txtCedulaUsuario.Text = T.Tables(0).Rows(0).ItemArray(0)
                frmRegistro.txtNombreUsuario.Text = T.Tables(0).Rows(0).ItemArray(1)
                frmRegistro.txtContraseniaUsuario.Text = T.Tables(0).Rows(0).ItemArray(2)

                NUEVO_USER = False 'lo que voy hacer es a modificar un usuario existente.
                frmRegistro.Show()
                Me.Close()
            End If
        Else
            If L_ADMINUSUARIO.SelectedItems.Count > 0 Then
                ELIMINAR_ADMINUSUARIO.Enabled = True
            Else
                ELIMINAR_ADMINUSUARIO.Enabled = False
            End If
        End If
    End Sub

    Private Sub L_ADMINUSUARIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_ADMINUSUARIO.SelectedIndexChanged

    End Sub
End Class