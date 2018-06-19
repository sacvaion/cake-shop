Imports Negocio
Public Class Pastel

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim nuevoPastel As New Neg_Pastel
        Dim resp As String = ""
        If Trim(TxtNomPastel.Text) = "" Then
            MsgBox("Por favor, ingrese el nombre del pastel", MsgBoxStyle.Exclamation, "REGISTRO SIN NOMBRE")
            TxtNomPastel.Focus()
            Exit Sub
        End If

        If Trim(TxtPrecio.Text) = "" Then
            MsgBox("Por favor, ingrese el precio del pastel", MsgBoxStyle.Exclamation, "REGISTRO SIN VALOR")
            TxtPrecio.Focus()
            Exit Sub
        End If

        If Trim(TxtNumPersonas.Text) = "" Then
            MsgBox("Por favor, ingrese el numero de porciones del pastel", MsgBoxStyle.Exclamation, "REGISTRO SIN NUMERO DE PORCIONES")
            TxtNumPersonas.Focus()
            Exit Sub
        End If

        If Trim(TxtDetalle.Text) = "" Then
            MsgBox("Por favor, digite algun comentario", MsgBoxStyle.Exclamation, "REGISTRO SIN COMENTARIO")
            TxtDetalle.Focus()
            Exit Sub
        End If

        If Trim(TxtForma.Text) = "" Then
            MsgBox("Por favor, ingrese la forma del pastel", MsgBoxStyle.Exclamation, "REGISTRO SIN NOMBRE DE LA FORMA")
            TxtForma.Focus()
            Exit Sub
        End If

        If Trim(TxtCubierta.Text) = "" Then
            MsgBox("Por favor, ingrese el nombre del pastel", MsgBoxStyle.Exclamation, "REGISTRO SIN NOMBRE")
            TxtCubierta.Focus()
            Exit Sub
        End If


        nuevoPastel.Pastel_Id = TxtIdPastel.Text
        nuevoPastel.Pastel_Nombre = UCase(TxtNomPastel.Text)
        nuevoPastel.Pastel_Precio = TxtPrecio.Text
        nuevoPastel.Pastel_NumPers = TxtNumPersonas.Text
        nuevoPastel.Pastel_Detalle = UCase(TxtDetalle.Text)
        nuevoPastel.Pastel_Forma = UCase(TxtForma.Text)
        nuevoPastel.Pastel_Cubierta = UCase(TxtCubierta.Text)


            resp = nuevoPastel.insertarPastel(nuevoPastel)
            If InStr(resp, "satisfactoriamente") > 0 Then
                MsgBox(resp, MsgBoxStyle.Information, "Operacion Existosa")
                BtnNuevo_Click(sender, e)
            ElseIf resp <> "" Then
                MsgBox(resp, MsgBoxStyle.Exclamation, "Error")
                BtnNuevo_Click(sender, e)
            End If

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim obj As New Neg_Pastel

        TxtIdPastel.Text = obj.Autonumerico
        TxtNomPastel.Text = ""
        TxtPrecio.Text = ""
        TxtNumPersonas.Text = ""
        TxtDetalle.Text = ""
        TxtForma.Text = ""
        TxtCubierta.Text = ""

    End Sub

    Private Sub Pastel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Neg_Pastel
        TxtIdPastel.Text = obj.Autonumerico
        GBox_Variables.Visible = False
    End Sub
End Class