Imports CapaDatos
Imports System.Data.SqlClient

Public Class frmOficinasC
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmOficinasC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DgvInsertarO.Oficina' Puede moverla o quitarla según sea necesario.
        Me.OficinaTableAdapter.Fill(Me.DgvInsertarO.Oficina)

    End Sub

    Private Sub btnAgregarO_Click(sender As Object, e As EventArgs) Handles btnAgregarO.Click
        ' Obtener el texto del TextBox
        Dim nombreOficina As String = txtAgregarO.Text
        Dim numeroEdificio As Integer = txtEdiOfA.Text
        If Not String.IsNullOrEmpty(nombreOficina) Then
            InsertarOficina(nombreOficina, numeroEdificio)
        Else
            MsgBox("El nombre de la oficina no puede estar vacío")
        End If
    End Sub

    Private Sub InsertarOficina(nombreOficina As String, numeroEdificio As Integer)

        Try
            ' Asegurarse de que la conexión está abierta
            'conexion.conectar(usuario:="sa", pass:="Cuilco123") Then
            ' Crear el comando para ejecutar el procedimiento almacenado
            Dim cmd As New SqlCommand("InsertarOficina", conexion.conexion)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar el parámetro del procedimiento almacenado
            cmd.Parameters.AddWithValue("@numeroEdi", numeroEdificio)
            cmd.Parameters.AddWithValue("@nomOficina", nombreOficina)

            ' Ejecutar el comando
            cmd.ExecuteNonQuery()

            MsgBox("Oficina insertado correctamente")

        Catch ex As SqlException
            MsgBox("Error al insertar Oficina: " & ex.Message)
        End Try
        Me.OficinaTableAdapter.Fill(Me.DgvInsertarO.Oficina)
    End Sub

End Class