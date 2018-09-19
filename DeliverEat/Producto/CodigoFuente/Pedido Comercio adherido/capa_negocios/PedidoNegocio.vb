Public Class PedidoNegocio
    Dim pedidoPersistencia As New PedidoPersistencia()

    Public Function validarPago(pago As Double, total As Double) As Boolean
        If pago >= total Then
            Return True
        End If
        Return False
    End Function

    Public Sub grabarPedido()
    End Sub
End Class
