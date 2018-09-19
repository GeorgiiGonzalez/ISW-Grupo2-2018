Imports System.ComponentModel

Public Class PagoEnEfectivo
    Dim gestorPedido As New PedidoNegocio()
    Dim total_venta As Double

    'Este metodo se podria implementar a medida que el va cargando el monto
    Private Sub btn_aceptarPago_Click(sender As Object, e As EventArgs) Handles btn_aceptarPago.Click
        If validarCampo() Then
            If gestorPedido.validarPago(Convert.ToDouble(txt_pago.Text), total_venta) Then
                Pedido.setPagaCon(Convert.ToDouble(txt_pago.Text))
                Pedido.setMedioPagoElegido(True)
                Me.Hide()
            Else
                MessageBox.Show("Ingrese un monto mayor al total de venta.")
                txt_pago.Select()
            End If
        End If
    End Sub

    Private Sub btn_cancelarPago_Click(sender As Object, e As EventArgs) Handles btn_cancelarPago.Click

    End Sub

    Private Sub PagoEnEfectivo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Pedido.closeEfectivoForm()
    End Sub

    Private Sub PagoEnEfectivo_Load(sender As Object, e As EventArgs) Handles Me.Load
        total_venta = Pedido.getTotal()
        txt_pago.Text = total_venta.ToString()
    End Sub

    Private Sub txt_pago_LostFocus(sender As Object, e As EventArgs) Handles txt_pago.LostFocus
        If validarCampo() Then
            If gestorPedido.validarPago(Convert.ToDouble(txt_pago.Text), total_venta) Then
                txt_vuelto.Text = (Convert.ToDouble(txt_pago.Text) - total_venta).ToString()
            Else
                MessageBox.Show("Ingrese un monto mayor al total de venta.")
                txt_pago.Select()
            End If
        End If
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

End Class