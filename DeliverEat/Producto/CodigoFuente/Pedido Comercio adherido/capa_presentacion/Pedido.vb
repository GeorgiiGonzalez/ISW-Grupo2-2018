Imports Pedido_Comercio_adherido.PedidoPersistencia
Imports System.Data.OleDb

Public Class Pedido

    Private string_conexion = "Provider=SQLNCLI11;Data Source=LAPTOP-6VOLNCDP\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DeliverEat"

    Dim total As Double
    Dim medioPago As Boolean
    Dim hora As Boolean
    Dim pago
    Enum tipoPago
        efectivo
        tarjeta
    End Enum
    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_descipcion_cliente_carga.Enabled = True
        txt_direccion_cliente_carga.Enabled = True
        txt_telefono_cliente_carga.Enabled = True


        'Dim str As String = "insert into pedidos (id_usuario) values (3);"
        Dim str As String = "select * from pedidos"
        Dim conexion As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim tabla As New DataTable

        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = str
            cmd.ExecuteNonQuery()

            tabla.Load(cmd.ExecuteReader)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            '
            conexion.Close()
            conexion.Dispose()
        End Try


        Me.dgv_clientes.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_clientes.Rows.Add()
            Me.dgv_clientes.Rows(c).Cells("user").Value = tabla.Rows(c)(0)
        Next
    End Sub

    Private Sub GroupBox3_Load(sender As Object, e As EventArgs)
        habilitarPago()
    End Sub
    'Metodo para hacer que los botones aparezcan deshabilitados cuando no hay texto y habilitados cuando hay, PERO NO ME FUNCIONA
    Private Function habilitarPago()
        If (txt_descipcion_cliente_carga.Text = String.Empty) Or (txt_direccion_cliente_carga.Text = String.Empty) Then
            btn_Efectivo.Enabled = False
            btn_Tarjeta.Enabled = False
        Else
            btn_Efectivo.Enabled = True
            btn_Tarjeta.Enabled = True
        End If
    End Function

    Private Sub btn_Efectivo_Click(sender As Object, e As EventArgs) Handles btn_Efectivo.Click
        PagoEnEfectivo.Show()
        btn_Efectivo.BackColor = Color.LawnGreen
        btn_Tarjeta.BackColor = Color.White
        pago = tipoPago.efectivo
    End Sub
    Private Sub btn_Tarjeta_Click(sender As Object, e As EventArgs) Handles btn_Tarjeta.Click
        btn_Efectivo.BackColor = Color.White
        btn_Tarjeta.BackColor = Color.LawnGreen
        pago = tipoPago.tarjeta
    End Sub

    Private Sub bnt_antesPosible_Click(sender As Object, e As EventArgs) Handles bnt_antesPosible.Click
        bnt_antesPosible.BackColor = Color.LawnGreen
        bnt_horaProgramada.BackColor = Color.White
    End Sub
    Private Sub bnt_horaProgramada_Click(sender As Object, e As EventArgs) Handles bnt_horaProgramada.Click

        bnt_antesPosible.BackColor = Color.White
        bnt_horaProgramada.BackColor = Color.LawnGreen
    End Sub
    Private Sub btn_nuevo_cliente_carga_Click(sender As Object, e As EventArgs) Handles btn_aceptarPedido.Click
        Dim str As String = "select * from pedidos"
        Dim conexion As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim tabla As New DataTable

        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = str
            cmd.ExecuteNonQuery()

            tabla.Load(cmd.ExecuteReader)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            '
            conexion.Close()
            conexion.Dispose()
        End Try
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
