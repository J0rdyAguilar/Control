Public Class Incio
    Private Sub Incio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        frmLogin.MdiParent = Me
        frmLogin.StartPosition = 1
        frmLogin.Show()
    End Sub
End Class
