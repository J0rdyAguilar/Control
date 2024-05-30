Public Class frmServiciosR
    Private Sub frmServiciosR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DgvVerSS.ServiciosSolicitados' Puede moverla o quitarla según sea necesario.
        Me.ServiciosSolicitadosTableAdapter.Fill(Me.DgvVerSS.ServiciosSolicitados)

    End Sub
End Class