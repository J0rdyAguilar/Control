Imports System.Data.SqlClient

Public Class conexion
    Public Shared conexion As SqlConnection
    Public Shared Function conectar(usuario As String, pass As String)
        Try
            conexion = New SqlConnection("Data Source=TUF-GAMING\SQLEXPRESS;Initial Catalog=ControlServicios;User ID=" & usuario & ";Password=" & pass & "")
            If (conexion.State = 0) Then
                conexion.Open()
                MsgBox("conexion exitosa")
            End If

        Catch ex As SqlException
            MsgBox("no se pudo conectar" + ex.Message)

        End Try
    End Function

End Class