Public Class PedidoNegocio
    Dim pedidoPersistencia As New PedidoPersistencia()
    Dim detallePedidoPersistencia As New DetallePedidoPersistencia()

    Public Function validarPago(pago As Double, total As Double) As Boolean
        If pago >= total Then
            Return True
        End If
        Return False
    End Function

    Public Sub grabarPedido(id_cliente As String,
                            dir As String,
                            desc As String,
                            id_medio_pago As String,
                            hora As String,
                            lo_antes_posible As String,
                            total As String,
                            telefono As String)
        pedidoPersistencia.grabarPedido(id_cliente,
                            dir,
                            desc,
                            id_medio_pago,
                            hora,
                            lo_antes_posible,
                            total,
                            telefono)
    End Sub

    Friend Function getDetalles(v As Integer) As DataTable
        Dim ret = detallePedidoPersistencia.getDetalles(v)
        Return ret
    End Function

    Friend Sub grabarDetalle(id_det As String, id_ped As String, prod As String, cant As String, unitario As String)
        detallePedidoPersistencia.grabarDetalle(id_det,
                                                id_ped,
                                                prod,
                                                cant,
                                                unitario)
    End Sub
End Class
