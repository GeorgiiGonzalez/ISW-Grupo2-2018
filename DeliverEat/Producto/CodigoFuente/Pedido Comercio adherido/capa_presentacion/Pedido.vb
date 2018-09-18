Public Class Pedido
    Dim total As Double
    Dim medioPago As Boolean
    Dim hora As Boolean


    Private Sub btn_Efectivo_Click(sender As Object, e As EventArgs) Handles btn_Tarjeta.Click

    End Sub

    Private Sub btn_nuevo_cliente_carga_Click(sender As Object, e As EventArgs) Handles btn_aceptarPedido.Click

    End Sub

    Private Sub bnt_antesPosible_Click(sender As Object, e As EventArgs) Handles bnt_antesPosible.Click

    End Sub

    Private Sub btn_Efectivo_Click_1(sender As Object, e As EventArgs) Handles btn_Efectivo.Click

    End Sub

    Private Sub bnt_horaProgramada_Click(sender As Object, e As EventArgs) Handles bnt_horaProgramada.Click

    End Sub

    Private Sub btn_cancelarPedido_Click(sender As Object, e As EventArgs) Handles btn_cancelarPedido.Click

    End Sub

    Private Sub grabarPedido()
        If validarOperacion() Then
            'grabar el pedido
        End If
    End Sub

    Private Function validarCampos() As Boolean
        If txt_descipcion_cliente_carga.Text = "" Then
            txt_descipcion_cliente_carga.Select()
            MessageBox.Show("Ingrese una descripción.")
            Return False
        ElseIf txt_direccion_cliente_carga.Text = "" Then
            txt_direccion_cliente_carga.Select()
            MessageBox.Show("Ingrese una dirección.")
            Return False
        End If
        Return True
    End Function

    Private Function validarBooleans() As Boolean
        If Not medioPago Then
            MessageBox.Show("Especifique un medio de pago.")
            Return False
        ElseIf Not hora Then
            MessageBox.Show("Especifique una hora de entrega.")
            Return False
        End If
        Return True
    End Function

    Private Function carritoVacio() As Boolean
        If dgv_clientes.Rows.Count = 0 Then
            MessageBox.Show("Carrito vacio.")
            Return True
        End If
        Return False
    End Function

    Private Function validarOperacion() As Boolean
        If validarCampos() AndAlso
                validarBooleans() AndAlso
                Not carritoVacio() Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
