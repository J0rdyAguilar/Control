Imports CapaDatos
Imports System.Data.SqlClient

Public Class frmServiciosC
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub frmServiciosC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DgvInsertarSS.ServiciosSolicitados' Puede moverla o quitarla según sea necesario.
        Me.ServiciosSolicitadosTableAdapter.Fill(Me.DgvInsertarSS.ServiciosSolicitados)

    End Sub

    Private Sub btnAgregarS_Click(sender As Object, e As EventArgs) Handles btnAgregarS.Click
        ' Obtener el texto del TextBox
        Dim numeroDPI As Integer = txtDPICAS.Text
        Dim descripcion As String = txtDescripcion.Text
        Dim fecha As String = dtpFechaIngreso.Value.ToString("yyyy-MM-dd")

        If Not String.IsNullOrEmpty(descripcion) Then
            InsertarServicioSolicitado(numeroDPI, descripcion, fecha)
        Else
            MsgBox("La descripción no puede estar vacío")
        End If

        txtDescripcion.Text = ""
        txtDPICAS.Text = ""

    End Sub

    Private Sub InsertarServicioSolicitado(numeroDPI As Integer, descripcion As String, fecha As String)

        Try
            ' Asegurarse de que la conexión está abierta
            'conexion.conectar(usuario:="sa", pass:="Cuilco123") Then
            ' Crear el comando para ejecutar el procedimiento almacenado
            Dim cmd As New SqlCommand("InsertarServicioSolicitado", conexion.conexion)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar el parámetro del procedimiento almacenado
            cmd.Parameters.AddWithValue("@fechaSolicitud", fecha)
            cmd.Parameters.AddWithValue("@Descripcion", descripcion)
            cmd.Parameters.AddWithValue("@CodigoSolicitante", numeroDPI)

            ' Ejecutar el comando
            cmd.ExecuteNonQuery()

            MsgBox("Servicio insertado correctamente")

        Catch ex As SqlException
            MsgBox("Error al insertar el servicio: " & ex.Message)
        End Try
        Me.ServiciosSolicitadosTableAdapter.Fill(Me.DgvInsertarSS.ServiciosSolicitados)
    End Sub

End Class