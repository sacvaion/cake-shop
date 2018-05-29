Imports System.IO
Imports Negocio
Public Class Pasteleria

    Private Sub Form_Marca_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim m As New Neg_Client
        Dim p As New Neg_Pastel
        Dim A As New Neg_Abono
        If ClienteBuscado <> "" Then
            TxtIdCliente.Text = ClienteBuscado
            m = m.extraerDatos(ClienteBuscado)
            ClienteBuscado = ""
            TxtNomCliente.Text = m.clientNombre
            TxtDireCliente.Text = m.clientDireccion
            TxtTelCliente.Text = m.clientTelefono
        End If

        If pastelBuscado <> "" Then
            TxtIdPastel.Text = pastelBuscado
            p = p.extraerDatos(pastelBuscado)
            pastelBuscado = ""
            TxtNomPastel.Text = p.Pastel_Nombre
            TxtCubierta.Text = p.Pastel_Cubierta
            TxtForma.Text = p.Pastel_Forma
            TxtNumPersonas.Text = p.Pastel_NumPers
            TxtValorTotal.Text = p.Pastel_Precio
        End If



    End Sub

    Private Sub Pasteleria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "****PASTELERIA SANTANDER***"
        AxShockwaveFlash1.LoadMovie(0, Path.GetFullPath("LogoPastSantander.swf"))
        BtnNuevo_Click(sender, e)
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim NewClient As New Neg_Client
        Dim PedidoNuevo As New Neg_Pedido
        Dim AbonoNuevo As New Neg_Abono

        Dim resp As String = ""
        Dim resp2 As String = ""
        If Trim(TxtIdCliente.Text) = "" Or Trim(TxtNomCliente.Text) = "" Then
            MsgBox("Por favor, si quiere agregar un pedido ingrese el nombre del cliente", MsgBoxStyle.Exclamation, "REGISTRO SIN NOMBRE")
            TxtNomCliente.Focus()
            Exit Sub
        End If

        If Trim(TxtDireCliente.Text) = "" Then
            MsgBox("Por favor, digite la direccion del cliente", MsgBoxStyle.Exclamation, "REGISTRO SIN DIRECCION")
            TxtDireCliente.Focus()
            Exit Sub
        End If

        If Trim(TxtTelCliente.Text) = "" Then
            MsgBox("Por favor, digite el numero del cliente", MsgBoxStyle.Exclamation, "REGISTRO SIN TELEFONO")
            TxtTelCliente.Focus()
            Exit Sub
        End If

        If Trim(TxtIdPastel.Text) = "" Then
            MsgBox("Por favor, escoga el pastel a vender", MsgBoxStyle.Exclamation, "REGUISTRO SIN PASTEL")
            TxtNomPastel.Focus()
            Exit Sub
        End If

        'ESTA PENDIENTE LAS VALIDACIONES DE PEDIDO
        


        NewClient.clientId = TxtIdCliente.Text
        NewClient.clientNombre = UCase(TxtNomCliente.Text)
        NewClient.clientDireccion = UCase(TxtDireCliente.Text)
        NewClient.clientTelefono = TxtTelCliente.Text
        resp2 = NewClient.InsertarCliente(NewClient)

        PedidoNuevo.Pedido_Id = TxtIdPedido.Text
        PedidoNuevo.Pedido_Id_Pastel = TxtIdPastel.Text
        PedidoNuevo.Pedido_Id_Cliente = TxtIdCliente.Text
        PedidoNuevo.Pedido_FechaPedido = FechaParaMySQL(TxtFechaActual.Text)
        PedidoNuevo.Pedido_FechaEntrega = FechaParaMySQL(DateTimePicker1.Text)
        PedidoNuevo.Pedido_NumMesas = TxtNumMesas.Text
        PedidoNuevo.Pedido_Deposito = TxtDeposito.Text
        PedidoNuevo.Pedido_Comentario = UCase(TxtComentario.Text)
        PedidoNuevo.Pedido_Usuario = UCase(TxtUsuario.Text)
        PedidoNuevo.Pedido_HoraEntrega = DateTimePicker3.Text

        AbonoNuevo.Abono_Id = TxtIdAbono.Text
        AbonoNuevo.Abono_Fecha = FechaParaMySQL(TxtFechaActual.Text)
        AbonoNuevo.Abono_Valor = Str(TxtAbono.Text) 'devuelve el valor entero de un string
        AbonoNuevo.Abono_Saldo = AbonoNuevo.saldo(TxtValorTotal.Text, AbonoNuevo.Abono_Valor)
        AbonoNuevo.Abono_Id_Pedido = TxtIdPedido.Text

        AbonoNuevo.insertarAbono(AbonoNuevo)

        resp = PedidoNuevo.InsertarPedido(PedidoNuevo)

        If InStr(resp, "satisfactoriamente") > 0 Then
            MsgBox(resp, MsgBoxStyle.Information, "Operacion Existosa")
            BtnNuevo_Click(sender, e)
        ElseIf resp <> "" Then
            MsgBox(resp, MsgBoxStyle.Exclamation, "Error")
            BtnNuevo_Click(sender, e)
        End If

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim obj As New Neg_Client
        Dim ped As New Neg_Pedido
        Dim Abo As New Neg_Abono

        'DATOS CLIENTE
        TxtIdCliente.Text = obj.Autonumerico()
        TxtNomCliente.Text = ""
        TxtDireCliente.Text = ""
        TxtTelCliente.Text = ""
        'DATOS PASTEL
        TxtIdPastel.Text = ""
        TxtNomPastel.Text = ""
        TxtForma.Text = ""
        TxtCubierta.Text = ""
        TxtNumPersonas.Text = ""
        TxtValorTotal.Text = "$"
        'DATOS PEDIDO
        TxtIdPedido.Text = ped.Autonumerico
        DateTimePicker1.Text = FormatDateTime(Now, DateFormat.ShortDate)
        TxtFechaActual.Text = FormatDateTime(Now, DateFormat.ShortDate)
        'TxtHoraEntrega.Text = ""
        TxtAbono.Text = "$"
        TxtSaldo.Text = "$"
        TxtNumMesas.Text = ""
        TxtDeposito.Text = ""
        TxtUsuario.Text = ""
        TxtComentario.Text = ""
        'TxtHoraEntrega.Text = FormatDateTime(Now, DateFormat.ShortTime)
        DateTimePicker3.Text = FormatDateTime(Now, DateFormat.ShortTime)
        'DATOS ABONO
        TxtIdAbono.Text = Abo.Autonumerico


    End Sub

    Private Sub TxtNomCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNomCliente.KeyDown
        If e.KeyCode = Keys.F1 Then
            ClienteBuscado = ""
            BuscarCliente.Show()
        End If

    End Sub

    Private Sub TxtNomPastel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNomPastel.KeyDown
        If e.KeyCode = Keys.F1 Then
            pastelbuscado = ""
            BuscarPastel.Show()
        End If
    End Sub

    Private Sub AgregarPastelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarPastelToolStripMenuItem.Click
        Pastel.Show()
    End Sub

    Private Sub BuscarPedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarPedidoToolStripMenuItem.Click
        BuscarPedido.Show()
    End Sub

    Private Sub AbonoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbonoToolStripMenuItem.Click
        Abono.Show()
    End Sub

End Class
