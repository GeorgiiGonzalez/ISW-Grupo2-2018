Imports System.Data.SqlClient

Public Class DetallePedidoPersistencia
    Dim con As New Conexion()
    Dim sqlComando As New SqlCommand
    Dim str As String
    Dim buscadorMaxId As New BuscadorMaxId()

    Friend Function getDetalles(v As Integer) As DataTable
        str = "SELECT id_detalle, id_pedido, producto, cantidad, precio_unidad FROM detalles_pedido WHERE id_pedido = @id"
        sqlComando.CommandText = str
        sqlComando.Parameters.AddWithValue("@id", buscadorMaxId.buscarMaxId("pedidos", "id_pedido") - 1)
        sqlComando.Connection = con.getConexion()
        Dim data As New DataTable()
        data.Load(sqlComando.ExecuteReader())
        sqlComando.Parameters.Clear()
        con.desconectar()
        Return data
    End Function

    Friend Sub grabarDetalle(id_det As String, id_ped As String, prod As String, cant As String, unitario As String)
        str = "INSERT INTO detalles_pedido (id_detalle, id_pedido, producto, cantidad, precio_unidad) VALUES (@id_det, @id_ped, @prod, @cant, @unitario)"
        sqlComando.CommandText = str
        sqlComando.Parameters.AddWithValue("@id_det", BuscadorMaxId.buscarMaxId("detalles_pedido", "id_detalle"))
        sqlComando.Parameters.AddWithValue("@id_ped", buscadorMaxId.buscarMaxId("pedidos", "id_pedido") - 1)
        sqlComando.Parameters.AddWithValue("@prod", prod)
        sqlComando.Parameters.AddWithValue("@cant", cant)
        sqlComando.Parameters.AddWithValue("@unitario", unitario)
        con.ejecutarNoQuery(sqlComando)
        sqlComando.Parameters.Clear()
    End Sub
End Class
