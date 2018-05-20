Imports Negocio
Public Class BuscarPastel

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim obj As New Neg_Pastel
        obj.listarPastel(TxtBuscar.Text, ListBox1)
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        pastelbuscado = Mid(ListBox1.Text, 1, 3) 'mid recorta de un string un rango del mismo
        Me.Close()
    End Sub

    Private Sub BuscarPastel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "***PASTEL BUSCADO***"
    End Sub
End Class