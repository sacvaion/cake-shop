Imports Negocio
Public Class Abono

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim obj As New Neg_Abono
        Dim resp As String

        obj.Abono_Id = TxtIdAbono.Text
        obj.Abono_Id_Pedido = TxtIdPedido.Text
        obj.Abono_Valor = Str(TxtAbono.Text)
        obj.Abono_Saldo = obj.saldo(TxtSaldo.Text, Str(TxtAbono.Text))
        obj.Abono_Fecha = FechaParaMySQL(TxtFecha.Text)

        resp = obj.insertarAbono(obj)
        If InStr(resp, "satisfactoriamente") > 0 Then
            MsgBox(resp, MsgBoxStyle.Information, "Operacion Existosa")
            BtnNuevo_Click(sender, e)
        ElseIf resp <> "" Then
            MsgBox(resp, MsgBoxStyle.Exclamation, "Error")
            BtnNuevo_Click(sender, e)
        End If
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim obj As New Neg_Abono

        TxtIdAbono.Text = obj.Autonumerico
        TxtFecha.Text = FormatDateTime(Now, DateFormat.ShortDate)
        TxtNombreCliente.Text = ""
        TxtSaldo.Text = "$"
        TxtAbono.Text = "$"
        TxtIdPedido.Text = ""


    End Sub

    Private Sub Abono_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim m As New Neg_Client
        Dim p As New Neg_Pedido
        Dim A As New Neg_Abono


        
        If AbonoBuscado <> "" Then
            TxtIdPedido.Text = AbonoBuscado
            A = A.extraerDatos(AbonoBuscado)
            PedidoBuscado = A.Abono_Id_Pedido
            TxtSaldo.Text = A.Abono_Saldo
            AbonoBuscado = ""
        End If

        If PedidoBuscado <> "" Then
            p = p.extraerDatos(PedidoBuscado)
            ClienteBuscado = p.Pedido_Id_Cliente
        End If

        If ClienteBuscado <> "" Then
            m = m.extraerDatos(ClienteBuscado)
            ClienteBuscado = ""
            TxtNombreCliente.Text = m.clientNombre
        End If


    End Sub

    Private Sub Abono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnNuevo_Click(sender, e)
        TxtIdAbono.Visible = False
    End Sub

    Private Sub TxtIdPedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtIdPedido.KeyDown
        If e.KeyCode = Keys.F1 Then
            AbonoBuscado = ""
            BuscarAbono.Show()
        End If
    End Sub
End Class