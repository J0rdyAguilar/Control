Public Class frmEdificiosD
    Private Sub frmEdificiosD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlServiciosDataSet1.Edificios' Puede moverla o quitarla según sea necesario.
        Me.EdificiosTableAdapter.Fill(Me.ControlServiciosDataSet1.Edificios)

    End Sub
End Class