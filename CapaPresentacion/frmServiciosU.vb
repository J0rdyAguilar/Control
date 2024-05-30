Imports CapaDatos
Imports System.Data.SqlClient

Public Class frmServiciosU
    Private Sub frmServiciosU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DgvActualizarSS.ServiciosSolicitados' Puede moverla o quitarla según sea necesario.
        Me.ServiciosSolicitadosTableAdapter.Fill(Me.DgvActualizarSS.ServiciosSolicitados)

    End Sub

    Private Sub btnActualizarS_Click(sender As Object, e As EventArgs) Handles btnActualizarS.Click
        ' Obtener el texto del TextBox
        Dim codigoServicio As Integer = txtCodSerAct.Text
        Dim fecha As String = dtpFechaSolucion.Value.ToString("yyyy-MM-dd")
        Dim solucion As String = txtSolucion.Text
        Dim idCliente As Integer = txtidCliente.Text
        Dim estatus As String = txtEstServAc.Text

        If Not String.IsNullOrEmpty(solucion) Then
            ActualizarServicioSolicitado(codigoServicio, fecha, solucion, idCliente, estatus)
        Else
            MsgBox("La solucion no puede estar vacío")
        End If

        txtCodSerAct.Text = ""
        txtEstServAc.Text = ""
        txtidCliente.Text = ""
        txtSolucion.Text = ""
    End Sub

    Private Sub ActualizarServicioSolicitado(codigoServicio As Integer, fecha As String, solucion As String, idCliente As Integer, estatus As String)

        Try
            ' Asegurarse de que la conexión está abierta
            'conexion.conectar(usuario:="sa", pass:="Cuilco123") Then
            ' Crear el comando para ejecutar el procedimiento almacenado
            Dim cmd As New SqlCommand("ActualizarServicioSolicitado", conexion.conexion)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar el parámetro del procedimiento almacenado
            cmd.Parameters.AddWithValue("@CodigoServicio", codigoServicio)
            cmd.Parameters.AddWithValue("@fechaSolicitud", fecha)
            cmd.Parameters.AddWithValue("@Descripcion", solucion)
            cmd.Parameters.AddWithValue("@CodigoSolicitante", idCliente)
            cmd.Parameters.AddWithValue("@Estado", estatus)


            ' Ejecutar el comando
            cmd.ExecuteNonQuery()

            MsgBox("Servicio actualizado correctamente")

        Catch ex As SqlException
            MsgBox("Error al actualizar el servicio: " & ex.Message)
        End Try
        Me.ServiciosSolicitadosTableAdapter.Fill(Me.DgvActualizarSS.ServiciosSolicitados)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class