Imports System.ComponentModel

Public Class Hora
    Dim result As String

    Private Sub btn_cancelarHora_Click(sender As Object, e As EventArgs) Handles btn_cancelarHora.Click
        limpiarCampos()
        Me.Hide()
    End Sub

    Private Sub btn_aceptarHora_Click(sender As Object, e As EventArgs) Handles btn_aceptarHora.Click
        If validarMask() Then
            result = validarDateTime()
            If Not result = "" Then
                Pedido.setHora(result)
                limpiarCampos()
                Me.Hide()
            End If
        End If
    End Sub

    Private Function validarMask() As Boolean
        If Not msk_Hora.Text.ToCharArray.Length.Equals(5) Then
            MessageBox.Show("Ingrese una hora válida [HH:mm].")
            Return False
        End If
        Return True
    End Function

    Private Function validarDateTime() As String
        Dim now As Date = Date.Now
        Dim dt As Date = dtp_Hora.Value.Date
        Dim msk As Array = msk_Hora.Text.ToCharArray
        Dim hora As String = msk.GetValue(0) & msk.GetValue(1)
        Dim min As String = msk.GetValue(3) & msk.GetValue(4)
        Dim result As DateTime

        If dtp_Hora.Value.Date.Date >= now.Date.Date Then
            If Convert.ToInt16(hora) > 23 Or Convert.ToInt16(min) > 59 Then
                MessageBox.Show("Ingrese una hora válida [HH:mm].")
                Return ""
            Else
                result = New DateTime(Convert.ToInt16(dt.Year),
                                        Convert.ToInt16(dt.Month),
                                        Convert.ToInt16(dt.Day),
                                        Convert.ToInt16(hora),
                                        Convert.ToInt16(min),
                                        0,
                                        0)
                If result > DateTime.Now Then
                    Return result.ToString()
                Else
                    MessageBox.Show("Ingrese una hora válida.")
                    Return ""
                End If
            End If
        Else
            MessageBox.Show("Ingrese una fecha válida.")
            Return ""
        End If
    End Function

    Private Sub limpiarCampos()
        result = ""
        msk_Hora.ResetText()
        dtp_Hora.ResetText()
    End Sub

    Private Sub Hora_Load(sender As Object, e As EventArgs) Handles Me.Load
        limpiarCampos()
    End Sub

    Private Sub Hora_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Pedido.closeHoraForm()
    End Sub
End Class