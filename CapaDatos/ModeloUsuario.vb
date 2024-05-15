Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class ModeloUsuario
    Public Shared Function verRoles(ByVal Usuario As String, ByVal Contraseña As String) As String
        Dim roles As String
        Dim rs As SqlDataReader
        Dim cmd As New System.Data.SqlClient.SqlCommand
        roles = "Sin Roles"

        Try
            'PREPARAR EL COMANDO'
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "BuscarRol"
            cmd.Connection = CapaDatos.conexion.conexion

            'AGREGAR LOS PARAMETROS QUE USAN EL PROCE ALMACENADO'
            cmd.Parameters.Add(New SqlClient.SqlParameter("@NombreUsuario", Usuario))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Contraseña", Contraseña))

            'EJECUTAR EL PROCE ALMACENADO'
            rs = cmd.ExecuteReader()
            If rs.HasRows Then
                rs.Read()
                roles = rs.GetValue(0)
                'MsgBox("El rol para su usuario es: " + roles)
            End If

        Catch ex As Exception
            MsgBox("Usuario y/o contraseña incorrectas")
            Console.WriteLine(ex)
        End Try
        Return roles
    End Function
End Class
