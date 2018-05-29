Public Module Module1
    Public ClienteBuscado As String
    Public PastelBuscado As String
    Public PedidoBuscado As String
    Public AbonoBuscado As String


    Function FechaParaMySQL(ByVal fecha As String) As String
        Dim dia As String
        Dim mes As String
        Dim ano As String

        dia = Mid(fecha, 1, 2)
        mes = Mid(fecha, 4, 2)
        ano = Mid(fecha, 7, 4)

        FechaParaMySQL = ano & "/" & mes & "/" & dia

    End Function
End Module
