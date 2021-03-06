﻿Imports System.Data.SqlClient

Public Class PedidoPersistencia
    Dim buscadorMaxId As New BuscadorMaxId()
    Dim con As New Conexion()
    Dim sqlComando As New SqlCommand
    Dim str As String

    Public Sub grabarPedido(id_cliente As String,
                            dir As String,
                            desc As String,
                            id_medio_pago As String,
                            hora As String,
                            lo_antes_posible As String,
                            total As String,
                            telefono As String)
        str = "INSERT INTO pedidos (id_pedido, id_cliente, direccion, descripcion, id_medio_pago, hora_programada, lo_antes_posible, total, telefono) VALUES (@id_pedido, @id_cliente, @dir, @desc, @id_medio_pago, @hora, @lo_antes_posible, @total, @tel)"
        sqlComando.CommandText = str
        Console.WriteLine(id_cliente & " " & dir & " " & desc & " " & id_medio_pago & " " & lo_antes_posible & " " & total & " " & telefono)
        sqlComando.Parameters.AddWithValue("@id_pedido", buscadorMaxId.buscarMaxId("pedidos", "id_pedido"))
        sqlComando.Parameters.AddWithValue("@id_cliente", id_cliente)
        sqlComando.Parameters.AddWithValue("@dir", dir)
        sqlComando.Parameters.AddWithValue("@desc", desc)
        sqlComando.Parameters.AddWithValue("@id_medio_pago", id_medio_pago)
        sqlComando.Parameters.AddWithValue("@hora", hora)
        sqlComando.Parameters.AddWithValue("@lo_antes_posible", lo_antes_posible)
        sqlComando.Parameters.AddWithValue("@total", total)
        sqlComando.Parameters.AddWithValue("@tel", telefono)
        con.ejecutarNoQuery(sqlComando)
        sqlComando.Parameters.Clear()
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Esta clase que tenes aca abajo es una que usamos el año pasado con unos compañeros cuando hicimos el TP, es probable que te sirva asi no reescribis codigo todo el tiempo
    'No te olvides de ir al App.config para cambiar tu string de conexion asi se conecta al sql de tu pc
    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



    'Imports System.Data.OleDb

    'Public Class DBHelper
    '    ' La clase BDHelper permite quitar del código del formulario todo lo relacionado con el acceso a bd.
    '    ' Permite ejecutar comandos sql y retornar resultados a la capa de datos.
    '    ' Implementa el patrón SINGLETON, que garantiza tener solo una instancia de esta clase.

    '    Enum tipoOperacion
    '        comun
    '        transaccion
    '    End Enum

    '    Private string_conexion As String
    '    Private Shared instance As DBHelper 'Unica instancia de la clase

    '    Public deDondeViene As Integer
    '    Private Sub New()

    '        Select Case My.Computer.Name.ToString
    '            Case "DESKTOP-B5BDNHJ"
    '                string_conexion = "Provider=SQLNCLI11;Data Source=DESKTOP-B5BDNHJ\EUROCOOLSQLEX;Integrated Security=SSPI;Initial Catalog=PAV-TPI"
    '            Case "LAPTOP-6VOLNCDP"
    '                string_conexion = "Provider=SQLNCLI11;Data Source=LAPTOP-6VOLNCDP\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PAV-TPI"
    '            Case "DESKTOP-VS0357J"
    '                string_conexion = "Provider=SQLNCLI11;Data Source=DESKTOP-VS0357J\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PAV-TPI"
    '            Case "ALVARO-PC"
    '                string_conexion = "Provider=SQLNCLI11;Data Source=(localdb)\Alvo_Server;Integrated Security=SSPI;Initial Catalog=PAV-TPI"
    '            Case "EMA-PC"
    '                string_conexion = "Provider=SQLNCLI11;Data Source=EMA-PC;Integrated Security=SSPI;Initial Catalog=PAVTPI"
    '            Case "WKS-ERAMELLO"
    '                string_conexion = "Provider=SQLNCLI11;Data Source=WKS-ERAMELLO;Integrated Security=SSPI;Initial Catalog=PAV-TPI"
    '        End Select

    '    End Sub

    '    Public Shared Function getDBHelper() As DBHelper
    '        If IsNothing(instance) Then
    '            instance = New DBHelper()
    '        End If
    '        Return instance
    '    End Function

    '    Public Function EjecutarSQL(ByVal strSql As String) As Integer

    '        Dim operacion As tipoOperacion = tipoOperacion.comun

    '        Dim str As String = strSql
    '        Dim myarray() As String = str.Split(vbLf)
    '        Dim listadoString As List(Of String) = myarray.ToList()

    '        Dim count As Integer = 0

    '        For Each stringg As String In listadoString
    '            If stringg.Trim.ToUpper.Contains("INSERT") Then
    '                count += 1
    '                If count > 1 Then
    '                    operacion = tipoOperacion.transaccion
    '                    Exit For
    '                End If
    '            ElseIf stringg.Trim.ToUpper.Contains("UPDATE") Then
    '                count += 1
    '                If count > 1 Then
    '                    operacion = tipoOperacion.transaccion
    '                    Exit For
    '                End If
    '            ElseIf stringg.Trim.ToUpper.Contains("DELETE") Then
    '                count += 1
    '                If count > 1 Then
    '                    operacion = tipoOperacion.transaccion
    '                    Exit For
    '                End If
    '            End If
    '        Next

    '        If operacion = tipoOperacion.transaccion Then
    '            Return ejecutarTransaccion(listadoString)
    '        Else
    '            Return ejecutarSimple(strSql)
    '        End If

    '    End Function

    '    Private Function ejecutarSimple(ByVal strSql As String) As Integer
    '        ' Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

    '        Dim ret As Integer = 0

    '        Dim conexion As New OleDbConnection
    '        Dim cmd As New OleDbCommand
    '        'Dim conexion As New SQLiteConnection
    '        'Dim cmd As New SQLiteCommand


    '        'Try Catch Finally
    '        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
    '        'Si hay error lo capta a través de una excepción
    '        'Si no hubo error
    '        Try
    '            ' Establece que conexión usar
    '            conexion.ConnectionString = string_conexion
    '            ' Abre la conexión
    '            conexion.Open()

    '            cmd.Connection = conexion
    '            cmd.CommandType = CommandType.Text
    '            ' Establece la instrucción a ejecutar
    '            cmd.CommandText = strSql
    '            ' Retorna el resultado de ejecutar el comando
    '            ret = cmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '            'Throw ex
    '            MsgBox(ex.ToString)
    '        Finally
    '            '
    '            ' Cierra la conexión
    '            conexion.Close()
    '            conexion.Dispose()
    '        End Try

    '        Return ret
    '    End Function

    '    Private Function ejecutarTransaccion(ByVal listadoString As List(Of String)) As Integer
    '        Dim ret As Integer = 0

    '        Dim conexion As New OleDbConnection
    '        Dim cmd As New OleDbCommand
    '        Dim tabla As New Data.DataTable
    '        ' Las sentencias se ejecutarán bajo transacción
    '        Dim miTransaccion As OleDbTransaction

    '        Try
    '            conexion.ConnectionString = string_conexion
    '            conexion.Open()
    '            ' La conexion establecida con la base de datos trabaja bajo transacción
    '            miTransaccion = conexion.BeginTransaction
    '            'Recorre la lista de calificaciones de la grilla.
    '            'Por cada valor realiza la inserción en la tabla de materias por alumnos
    '            For Each str As String In listadoString
    '                ' En la sentencia los @indican parámetros
    '                If Not (str.ToString = "") Then
    '                    cmd = New OleDbCommand(str.ToString, conexion, miTransaccion)
    '                    cmd.Connection = conexion
    '                    'Ejecuta la consulta insert con los parámetros ya con los valores adecuados
    '                    cmd.ExecuteNonQuery()
    '                    ret += 1
    '                End If
    '            Next
    '            miTransaccion.Commit()
    '            MsgBox("EJECUTANDO COMMIT")

    '        Catch ex As Exception
    '            miTransaccion.Rollback()
    '            MsgBox("EJECUTANDO ROLLBACK")
    '            ret = 0
    '            Throw ex

    '        Finally
    '            conexion.Close()
    '            conexion.Dispose()
    '        End Try

    '        Return ret
    '    End Function

    '    Public Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
    '        ' Se utiliza para sentencias SQL del tipo “Select”
    '        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
    '        Dim conexion As New OleDbConnection
    '        Dim cmd As New OleDbCommand
    '        Dim tabla As New DataTable
    '        Try
    '            conexion.ConnectionString = string_conexion
    '            conexion.Open()
    '            cmd.Connection = conexion
    '            cmd.CommandType = CommandType.Text
    '            cmd.CommandText = strSql
    '            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
    '            tabla.Load(cmd.ExecuteReader)
    '            ' La función retorna el objeto datatable con 0, 1 o mas registros
    '            Return tabla
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '            Throw ex
    '        Finally
    '            conexion.Close()
    '            conexion.Dispose()
    '        End Try
    '    End Function


    'End Class


End Class
