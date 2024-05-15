Imports CapaDatos

Public Class frmLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        CapaDatos.conexion.conectar(txtUsuario.Text, txtPass.Text)
        Dim RolEncontrado = ModeloUsuario.verRoles(txtUsuario.Text, txtPass.Text)

        If (CapaDatos.conexion.conexion.State = 1) Then
            If (RolEncontrado.Equals("Administrador")) Then
                frmAdmin.Show()
                Me.Dispose()
                Incio.Close()

            Else
                If (RolEncontrado.Equals("Técnico")) Then
                    frmTecnicos.Show()
                    Me.Dispose()
                    Incio.Close()
                Else
                    If (RolEncontrado.Equals("Cliente")) Then
                        frmClientes.Show()
                        Me.Dispose()
                        Incio.Close()
                    End If
                End If
            End If
        End If

        'frmAdmin.Show()
        'Me.Close()
        'Incio.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

End Class
