Imports CapaDatos
Imports System.Data.SqlClient

Public Class frmOficinasU
    Private Sub frmOficinasU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DgvActualizarO.Oficina' Puede moverla o quitarla según sea necesario.
        Me.OficinaTableAdapter.Fill(Me.DgvActualizarO.Oficina)

    End Sub

    Private Sub btnActualizarO_Click(sender As Object, e As EventArgs) Handles btnActualizarO.Click
        ' Obtener el texto del TextBox
        Dim numeroOficina As Integer = txtNumOfici.Text
        Dim nombreOficina As String = txtActualizarO.Text
        Dim numeroEdificio As Integer = txtNumEdifi.Text
        If Not String.IsNullOrEmpty(nombreOficina) Then
            ActualizarOficina(numeroOficina, nombreOficina, numeroEdificio)
        Else
            MsgBox("El nombre de la oficina no puede estar vacío")
        End If
    End Sub

    Private Sub ActualizarOficina(numeroOficina As Integer, nombreOficina As String, numeroEdificio As Integer)

        Try
            ' Asegurarse de que la conexión está abierta
            'conexion.conectar(usuario:="sa", pass:="Cuilco123") Then
            ' Crear el comando para ejecutar el procedimiento almacenado
            Dim cmd As New SqlCommand("ActualizarOficina", conexion.conexion)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar el parámetro del procedimiento almacenado
            cmd.Parameters.AddWithValue("@numeroOficina", numeroOficina)
            cmd.Parameters.AddWithValue("@nomOficina", nombreOficina)
            cmd.Parameters.AddWithValue("@numeroEdi", numeroEdificio)

            ' Ejecutar el comando
            cmd.ExecuteNonQuery()

            MsgBox("Oficina actualizada correctamente")

        Catch ex As SqlException
            MsgBox("Error al actualizar Oficina: " & ex.Message)
        End Try
        Me.OficinaTableAdapter.Fill(Me.DgvActualizarO.Oficina)
    End Sub

End Class