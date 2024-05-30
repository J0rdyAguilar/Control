Imports CapaDatos
Imports System.Data.SqlClient

Public Class frmServiciosE
    Private Sub frmServiciosE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DgvEliminarSS.ServiciosSolicitados' Puede moverla o quitarla según sea necesario.
        Me.ServiciosSolicitadosTableAdapter.Fill(Me.DgvEliminarSS.ServiciosSolicitados)

    End Sub

    Private Sub btnEliminarS_Click(sender As Object, e As EventArgs) Handles btnEliminarS.Click
        ' Obtener el texto del TextBox
        Dim codigoServicio As Integer = txtCodSerE.Text

        If Not String.IsNullOrEmpty(codigoServicio) Then
            EliminarServicioSolicitado(codigoServicio)
        Else
            MsgBox("El codigo no puede estar vacío")
        End If

    End Sub

    Private Sub EliminarServicioSolicitado(codigoServicio As Integer)

        Try
            ' Asegurarse de que la conexión está abierta
            'conexion.conectar(usuario:="sa", pass:="Cuilco123") Then
            ' Crear el comando para ejecutar el procedimiento almacenado
            Dim cmd As New SqlCommand("EliminarServicioSolicitado", conexion.conexion)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar el parámetro del procedimiento almacenado
            cmd.Parameters.AddWithValue("@CodigoServicio", codigoServicio)

            ' Ejecutar el comando
            cmd.ExecuteNonQuery()

            MsgBox("Servicio eliminado correctamente")

        Catch ex As SqlException
            MsgBox("Error al eliminar el servicio: " & ex.Message)
        End Try
        Me.ServiciosSolicitadosTableAdapter.Fill(Me.DgvEliminarSS.ServiciosSolicitados)
    End Sub

End Class