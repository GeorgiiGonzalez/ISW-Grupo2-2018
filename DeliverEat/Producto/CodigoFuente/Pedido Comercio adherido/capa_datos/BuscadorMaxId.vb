Imports System.Data.SqlClient

Public Class BuscadorMaxId
    Dim con As New Conexion()
    Dim sqlComando As New SqlCommand
    Dim str As String
    Dim id As Integer

    Public Function buscarMaxId(tabla As String, pk As String) As Integer
        str = "SELECT MAX(" + pk + ") FROM " + tabla
        sqlComando.CommandText = str
        Try
            sqlComando.Connection = con.getConexion()
            id = sqlComando.ExecuteScalar()
        Catch ex As Exception
            con.desconectar()
            Console.WriteLine(ex.Message)
        End Try
        con.desconectar()
        If IsDBNull(id) Then
            Return 1
        Else
            Return id + 1
        End If
    End Function

End Class
