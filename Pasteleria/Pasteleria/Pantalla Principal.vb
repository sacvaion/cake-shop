Imports System.IO
Imports Negocio
Public Class Pasteleria

    Private Sub Form_Marca_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim m As New Neg_Client
        Dim p As New Neg_Pastel
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
        End If

    End Sub

    Private Sub Pasteleria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "****PASTELERIA SANTANDER***"
        AxShockwaveFlash1.LoadMovie(0, Path.GetFullPath("LogoPastSantander.swf"))
        BtnNuevo_Click(sender, e)
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim NewClient As New Neg_Client
        Dim resp As String = ""
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


        NewClient.clientId = TxtIdCliente.Text
        NewClient.clientNombre = UCase(TxtNomCliente.Text)
        NewClient.clientDireccion = UCase(TxtDireCliente.Text)
        NewClient.clientTelefono = TxtTelCliente.Text

        resp = NewClient.InsertarCliente(NewClient)
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

        TxtValorTotal.Text = ""
        TxtNumMesas.Text = ""
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


End Class
