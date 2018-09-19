Public Class PagoEnEfectivo
    Dim gestorPedido As New PedidoNegocio()

    'Este metodo se podria implementar a medida que el va cargando el monto
    Private Sub btn_aceptarPago_Click(sender As Object, e As EventArgs) Handles btn_aceptarPago.Click
        If validarCampo() Then
            If gestorPedido.validarPago(Convert.ToDouble(txt_pago.Text), Convert.ToDouble(Pedido.txt_totalVENTA.Text)) Then
                'gestorPedido.setearHora()
                'setearHora hace precisamente eso, 
                'pero ademas pone en true a la variable hora del pedido
            Else
                MessageBox.Show("Ingrese un monto mayor al total de venta.")
                txt_pago.Select()
            End If
        End If
    End Sub

    Private Sub btn_cancelarPago_Click(sender As Object, e As EventArgs) Handles btn_cancelarPago.Click

    End Sub

    Private Function validarCampo() As Boolean
        If IsNumeric(txt_pago.Text) Then
            If Convert.ToDouble(txt_pago.Text) >= 0 Then
                Return True
            Else
                MessageBox.Show("Ingrese un monto válido.")
                txt_pago.Select()
                Return False
            End If
        Else
            MessageBox.Show("Ingrese un monto numérico.")
            txt_pago.Select()
            Return False
        End If
    End Function

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class