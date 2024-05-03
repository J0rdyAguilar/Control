Public Class frmEdificiosC
    Private Sub frmEdificiosC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlServiciosDataSet2.Edificios' Puede moverla o quitarla según sea necesario.
        Me.EdificiosTableAdapter.Fill(Me.ControlServiciosDataSet2.Edificios)

    End Sub
End Class