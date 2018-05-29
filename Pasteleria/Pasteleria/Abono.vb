Imports Negocio
Public Class Abono

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim obj As New Neg_Abono

        obj.Abono_Id = TxtIdAbono.Text
        obj.Abono_Id_Pedido = TxtIdPedido.Text
        obj.Abono_Valor = TxtIdAbono.Text
        obj.Abono_Saldo = obj.saldo(TxtSaldo.Text, TxtAbono.Text)

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim obj As New Neg_Abono

        TxtIdAbono.Text = obj.Autonumerico
        TxtFecha.Text = FormatDateTime(Now, DateFormat.ShortDate)
        TxtNombreCliente.Text = ""
        TxtSaldo.Text = "$"
        TxtAbono.Text = "$"

    End Sub

    Private Sub Abono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnNuevo_Click(sender, e)
    End Sub
End Class