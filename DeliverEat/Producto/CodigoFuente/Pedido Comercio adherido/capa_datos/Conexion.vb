Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Conexion
    Dim con As New SqlConnection()
    Dim cadena_con As String = "Data Source=DESKTOP-9EE1QA6;Initial Catalog=pedidos;Integrated Security=True;Pooling=False"

    Public Sub conectar()
        Try
            con.ConnectionString = cadena_con
            con.Open()
        Catch ex As Exception
            Console.WriteLine("Conexion open: " & ex.Message)
        End Try
    End Sub

    Public Sub desconectar()
        Try
            con.Close()
        Catch ex As Exception
            WriteLine("Conexion close: " & ex.Message)
        End Try
    End Sub

    Public Function getConexion() As SqlConnection
        conectar()
        Return con
    End Function

    Public Sub ejecutarNoQuery(comando As SqlCommand)
        conectar()
        comando.Connection = con
        Try
            comando.ExecuteNonQuery()
        Catch ex As Exception
            desconectar()
            MessageBox.Show(ex.Message)
        End Try
        desconectar()
    End Sub
End Class
