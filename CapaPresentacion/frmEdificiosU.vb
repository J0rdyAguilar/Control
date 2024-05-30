Imports CapaDatos
Imports System.Data.SqlClient

Public Class frmEdificiosU
    Private Sub frmEdificiosU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DgvActualizarE.Edificios' Puede moverla o quitarla según sea necesario.
        Me.EdificiosTableAdapter.Fill(Me.DgvActualizarE.Edificios)
        'TODO: esta línea de código carga datos en la tabla 'ControlServiciosDataSet.Edificios' Puede moverla o quitarla según sea necesario.


    End Sub

    Private Sub btnActualizarE_Click(sender As Object, e As EventArgs) Handles btnActualizarE.Click
        ' Obtener el texto del TextBox
        Dim numEdificio As Integer = txtNumEdi.Text
        Dim nombreEdificio As String = txtActualizarE.Text

        If Not String.IsNullOrEmpty(nombreEdificio) Then
            ActualizarEdificio(numEdificio, nombreEdificio)
        Else
            MsgBox("El nombre del edificio no puede estar vacío")
        End If
    End Sub

    Private Sub ActualizarEdificio(numEdificio As Integer, nombreEdificio As String)

        Try
            ' Asegurarse de que la conexión está abierta
            'conexion.conectar(usuario:="sa", pass:="Cuilco123") Then
            ' Crear el comando para ejecutar el procedimiento almacenado
            Dim cmd As New SqlCommand("ActualizarEdificio", conexion.conexion)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar el parámetro del procedimiento almacenado
            cmd.Parameters.AddWithValue("@numEdificio", numEdificio)
            cmd.Parameters.AddWithValue("@nomEdificio", nombreEdificio)

            ' Ejecutar el comando
            cmd.ExecuteNonQuery()

            MsgBox("Edificio actualizado correctamente")

        Catch ex As SqlException
            MsgBox("Error al actualizar edificio: " & ex.Message)
        End Try
        Me.EdificiosTableAdapter.Fill(Me.DgvActualizarE.Edificios)
    End Sub



End Class