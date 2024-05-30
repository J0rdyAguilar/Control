Public Class frmOficinasR
    Private Sub frmOficinasR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DgvVerO.Oficina' Puede moverla o quitarla según sea necesario.
        Me.OficinaTableAdapter.Fill(Me.DgvVerO.Oficina)

    End Sub
End Class