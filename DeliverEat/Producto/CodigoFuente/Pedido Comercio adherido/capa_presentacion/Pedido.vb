Public Class Pedido
    Dim gestorPedido As New PedidoNegocio()
    Dim total As Double
    Dim medioPagoElegido As Boolean = False
    Dim hora_definida As Boolean = False
    Dim lo_antes_posible As Integer
    Dim hora As String
    Dim tipoPago As Integer = 1
    Dim horaForm As New Hora()
    Dim efectivoForm As New PagoEnEfectivo()
    Dim pagaCon As Double
    Dim tabla As DataTable

    'Load
    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarDataGridDetalles()
        calcularTotal()
    End Sub

    'GET y SET
    Public Function getTotal() As Double
        Return total
    End Function

    Public Sub setHora(hora As String)
        Me.hora = hora
        Me.hora_definida = True
    End Sub

    Public Sub setPagaCon(monto As Double)
        pagaCon = monto
    End Sub

    Public Sub setMedioPagoElegido(v As Boolean)
        medioPagoElegido = v
    End Sub

    'Manejo de bonotes
    Private Sub btn_Efectivo_Click(sender As Object, e As EventArgs) Handles btn_Efectivo.Click
        btn_Efectivo.BackColor = Color.LawnGreen
        btn_Tarjeta.BackColor = Color.White
        If IsNothing(efectivoForm) Then
            efectivoForm = New PagoEnEfectivo()
        End If
        efectivoForm.Show()
        efectivoForm.BringToFront()
        tipoPago = 1
    End Sub

    Private Sub btn_Tarjeta_Click(sender As Object, e As EventArgs) Handles btn_Tarjeta.Click
        btn_Efectivo.BackColor = Color.White
        btn_Tarjeta.BackColor = Color.LawnGreen
        tipoPago = 2
    End Sub

    Private Sub bnt_antesPosible_Click(sender As Object, e As EventArgs) Handles bnt_antesPosible.Click
        bnt_antesPosible.BackColor = Color.LawnGreen
        bnt_horaProgramada.BackColor = Color.White
        setHora("")
        Me.hora_definida = True
        Me.lo_antes_posible = True
    End Sub

    Private Sub bnt_horaProgramada_Click(sender As Object, e As EventArgs) Handles bnt_horaProgramada.Click
        bnt_antesPosible.BackColor = Color.White
        bnt_horaProgramada.BackColor = Color.LawnGreen
        If IsNothing(horaForm) Then
            horaForm = New Hora()
        End If
        horaForm.Show()
        horaForm.BringToFront()
    End Sub

    Private Sub btn_nuevo_cliente_carga_Click(sender As Object, e As EventArgs) Handles btn_aceptarPedido.Click
        grabarPedido()
    End Sub

    Private Sub btn_cancelarPedido_Click(sender As Object, e As EventArgs) Handles btn_cancelarPedido.Click

    End Sub

    'Manejo de inserciones y cargas
    Private Sub grabarPedido()
        If validarOperacion() Then
            Try
                gestorPedido.grabarPedido("1",
                          txt_direccion_cliente_carga.Text,
                          txt_descipcion_cliente_carga.Text,
                          tipoPago.ToString,
                          hora.ToString,
                          Convert.ToInt16(lo_antes_posible).ToString,
                          total.ToString(),
                          txt_telefono_cliente_carga.Text)
                grabarDetalles()
                MessageBox.Show("Su pedido fue registrado con éxito.")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Algo no anda bien.")
            End Try
        End If
    End Sub

    Private Sub grabarDetalles()
        For Each r As DataRow In tabla.Rows
            gestorPedido.grabarDetalle(r.Item("id_detalle").ToString,
                                       r.Item("id_pedido").ToString,
                                       r.Item("producto").ToString,
                                       r.Item("cantidad").ToString,
                                       r.Item("precio_unidad").ToString)
        Next
    End Sub

    Private Sub cargarDataGridDetalles()
        Dim tabla_mostrar As New DataTable()
        tabla = gestorPedido.getDetalles(1)
        definirTabla(tabla_mostrar)
        For Each r As DataRow In tabla.Rows
            tabla_mostrar.Rows.Add(r.Item("producto"),
                       r.Item("cantidad"),
                       r.Item("precio_unidad"))
        Next
        dgv_clientes.DataSource = tabla_mostrar
    End Sub


    'Procedimientos
    Private Sub calcularTotal()
        Dim t As Double
        For Each r As DataGridViewRow In dgv_clientes.Rows
            t += (Convert.ToDouble(r.Cells("Unitario").Value) * Convert.ToDouble(r.Cells("Cantidad").Value))
        Next
        total = t
        txt_totalVENTA.Text = t.ToString()
    End Sub

    Private Sub definirTabla(ByRef tabla As DataTable)
        tabla.Columns.Add("Producto")
        tabla.Columns.Add("Cantidad")
        tabla.Columns.Add("Unitario")
    End Sub

    'Validaciones
    Private Function validarCampos() As Boolean
        If txt_direccion_cliente_carga.Text = "" Then
            txt_direccion_cliente_carga.Select()
            MessageBox.Show("Ingrese una dirección.")
            Return False
        ElseIf txt_descipcion_cliente_carga.Text = "" Then
            txt_descipcion_cliente_carga.Select()
            MessageBox.Show("Ingrese una descripción.")
            Return False
        End If
        Return True
    End Function

    Private Function validarBooleans() As Boolean
        If Not medioPagoElegido Then
            MessageBox.Show("Especifique un medio de pago.")
            Return False
        ElseIf Not hora_definida Then
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

    'Manejo de cierres de formularios
    Public Sub closeHoraForm()
        horaForm = Nothing
        If Not hora = "" Then
            Me.hora_definida = True
            Me.lo_antes_posible = False
        Else
            bnt_antesPosible.BackColor = Color.White
            bnt_horaProgramada.BackColor = Color.White
        End If
    End Sub

    Public Sub closeEfectivoForm()
        efectivoForm = Nothing
        If Not medioPagoElegido Then
            btn_Efectivo.BackColor = Color.White
        End If
    End Sub

End Class
