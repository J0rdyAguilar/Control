Imports System.Data.SqlClient
Imports CapaDatos

Public Class frmEdificiosC
    Private Sub frmEdificiosC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DgvInsertarE.Edificios' Puede moverla o quitarla según sea necesario.
        Me.EdificiosTableAdapter.Fill(Me.DgvInsertarE.Edificios)
        'TODO: esta línea de código carga datos en la tabla 'Control3DataSet.Edificios' Puede moverla o quitarla según sea necesario.
        ' Aquí puedes agregar código que quieras ejecutar al cargar el formulario
    End Sub

    Private Sub btnAgregarE_Click(sender As Object, e As EventArgs) Handles btnAgregarE.Click
        ' Obtener el texto del TextBox
        Dim nombreEdificio As String = txtAgregarE.Text
        If Not String.IsNullOrEmpty(nombreEdificio) Then
            InsertarEdificio(nombreEdificio)
        Else
            MsgBox("El nombre del edificio no puede estar vacío")
        End If
    End Sub

    Private Sub InsertarEdificio(nomEdificio As String)

        Try
            ' Asegurarse de que la conexión está abierta
            'conexion.conectar(usuario:="sa", pass:="Cuilco123") Then
            ' Crear el comando para ejecutar el procedimiento almacenado
            Dim cmd As New SqlCommand("InsertarEdificio", conexion.conexion)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agregar el parámetro del procedimiento almacenado
            cmd.Parameters.AddWithValue("@nomEdificio", nomEdificio)

            ' Ejecutar el comando
            cmd.ExecuteNonQuery()

            MsgBox("Edificio insertado correctamente")

        Catch ex As SqlException
            MsgBox("Error al insertar edificio: " & ex.Message)
        Finally
            ' Asegurarse de cerrar la conexión
            If conexion.conexion IsNot Nothing AndAlso conexion.conexion.State = ConnectionState.Open Then
                conexion.conexion.Close()
            End If
        End Try
        Me.EdificiosTableAdapter.Fill(Me.DgvInsertarE.Edificios)
    End Sub
End Class
