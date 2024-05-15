Imports CapaDatos
Imports System.Data.SqlClient

Public Class frmEdificiosD
    Private Sub frmEdificiosD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DgvEliminarE.Edificios' Puede moverla o quitarla según sea necesario.
        Me.EdificiosTableAdapter.Fill(Me.DgvEliminarE.Edificios)
        'TODO: esta línea de código carga datos en la tabla 'ControlServiciosDataSet1.Edificios' Puede moverla o quitarla según sea necesario.


    End Sub

    Private Sub btnEliminarE_Click(sender As Object, e As EventArgs) Handles btnEliminarE.Click
        ' Obtener el texto del TextBox
        Dim numEdificio As Integer = txtEliminarE.Text
        If Not String.IsNullOrEmpty(numEdificio) Then
            EliminarEdificio(numEdificio)
        Else
            MsgBox("El nombre del edificio no puede estar vacío")
        End If
    End Sub

    Private Sub EliminarEdificio(numEdificio As Integer)

        Try
            ' Asegurarse de que la conexión está abierta
            'conexion.conectar(usuario:="sa", pass:="Cuilco123") Then
            ' Crear el comando para ejecutar el procedimiento almacenado
            Dim cmd As New SqlCommand("EliminarEdificio", conexion.conexion)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar el parámetro del procedimiento almacenado
            cmd.Parameters.AddWithValue("@numEdificio", numEdificio)

            ' Ejecutar el comando
            cmd.ExecuteNonQuery()

            MsgBox("Edificio eliminado correctamente")

        Catch ex As SqlException
            MsgBox("Error al eliminar edificio: " & ex.Message)
        Finally
            ' Asegurarse de cerrar la conexión
            If conexion.conexion IsNot Nothing AndAlso conexion.conexion.State = ConnectionState.Open Then
                conexion.conexion.Close()
            End If
        End Try
        Me.EdificiosTableAdapter.Fill(Me.DgvEliminarE.Edificios)
    End Sub
End Class