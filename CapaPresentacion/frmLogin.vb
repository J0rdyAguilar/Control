Public Class frmLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            CapaDatos.conexion.conectar(txtUsuario.Text, txtPass.Text)



        Catch ex As Exception

        End Try

        frmAdmin.Show()
        Me.Close()
        Incio.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

End Class
