Imports CapaDatos
Imports System.Data.SqlClient

Public Class frmOficinasD
    Private Sub frmOficinasD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DgvEliminarO1.Oficina' Puede moverla o quitarla según sea necesario.
        Me.OficinaTableAdapter.Fill(Me.DgvEliminarO1.Oficina)

    End Sub

    Private Sub btnEliminarO_Click(sender As Object, e As EventArgs) Handles btnEliminarO.Click
        ' Obtener el texto del TextBox
        Dim numeroOficina As Integer = txtEliminarO.Text
        If Not String.IsNullOrEmpty(numeroOficina) Then
            EliminarOficina(numeroOficina)
        Else
            MsgBox("El numero de la oficina no puede estar vacío")
        End If
    End Sub

    Private Sub EliminarOficina(numeroOficina As Integer)

        Try
            ' Asegurarse de que la conexión está abierta
            'conexion.conectar(usuario:="sa", pass:="Cuilco123") Then
            ' Crear el comando para ejecutar el procedimiento almacenado
            Dim cmd As New SqlCommand("EliminarOficina", conexion.conexion)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar el parámetro del procedimiento almacenado
            cmd.Parameters.AddWithValue("@numeroOficina", numeroOficina)

            ' Ejecutar el comando
            cmd.ExecuteNonQuery()

            MsgBox("Oficina eliminada correctamente")

        Catch ex As SqlException
            MsgBox("Error al eliminar Oficina: " & ex.Message)
        End Try
        Me.OficinaTableAdapter.Fill(Me.DgvEliminarO1.Oficina)
    End Sub

End Class