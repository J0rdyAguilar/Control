Public Class frmEdificiosR
    Private Sub frmEdificiosR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DgvVerE.Edificios' Puede moverla o quitarla según sea necesario.
        Me.EdificiosTableAdapter.Fill(Me.DgvVerE.Edificios)
        'TODO: esta línea de código carga datos en la tabla 'ControlServiciosDataSet3.Edificios' Puede moverla o quitarla según sea necesario.

    End Sub
End Class