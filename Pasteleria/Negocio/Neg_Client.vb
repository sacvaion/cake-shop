Imports Datos
Imports System.IO
Public Class Neg_Client
    Public clientId As String
    Public clientNombre As String
    Public clientDireccion As String
    Public clientTelefono As String


    Function ExisteClient(ByVal campo As String, ByVal Valor_campo As String) As String
        Dim c As New Cls_Conexion
        Dim consulta As String = ""
        Try
            If IsNumeric(Valor_campo) Then
                consulta = "select * from cliente where " & campo & " = " & Valor_campo
            Else
                consulta = "select * from cliente where " & campo & " = '" & Valor_campo & "'"
            End If
            c.consultar(consulta)
            If c.rs.Read Then
                Return "El objeto si existe"
            Else
                Return "El objeto no existe"
            End If
            c.rs.Close()
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Function InsertarCliente(ByVal obj As Neg_Client) As String
        Dim c As New Cls_Conexion
        Dim consulta As String = ""
        Dim existe As String = ""

        Try
            'Validamos si el objeto existe
            existe = obj.ExisteClient("Cliente_id", obj.clientId)
            If existe = "El objeto si existe" Then

                If MsgBox("Està seguro que desea modificar el registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje de Confirmacion Cliente") = MsgBoxResult.No Then
                    Return ""
                Else
                    'si existe, agregamos la modificacion
                    consulta = "update Cliente set Cliente_Id = '" & obj.clientId & "',Cliente_Nombre = '" & obj.clientNombre & "',Cliente_Direccion = '" & obj.clientDireccion & "',Cliente_Telefono= '" & obj.clientTelefono & "'where Cliente_Id = " & obj.clientId
                End If

            Else
                'si no existe, agregamos el registro
                consulta = "insert into Cliente values('" & obj.clientId & "','" & obj.clientNombre & "','" & obj.clientTelefono & "','" & obj.clientDireccion & "')"

            End If

            c.consultar(consulta)
            c.rs.Close()
            Return "Registro Agregado / Actualizado satisfactoriamente"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function extraerDatos(ByVal Cod As String) As Neg_Client
        Dim c As New Cls_Conexion
        Dim consulta As String = ""
        Dim obj As New Neg_Client

        Try
            consulta = "Select * From Cliente where Cliente_Id= " & Cod
            c.consultar(consulta)
            If c.rs.Read Then
                obj.clientId = c.rs("Cliente_Id")
                obj.clientNombre = c.rs("Cliente_Nombre")
                obj.clientDireccion = c.rs("Cliente_Direccion")
                obj.clientTelefono = c.rs("Cliente_Telefono")
            Else
                obj.clientId = "-1"
                obj.clientNombre = "NO EXISTE"
                obj.clientDireccion = "NO EXISTE"
                obj.clientTelefono = "NO EXISTE"
            End If
            c.rs.Close()
            Return obj
        Catch ex As Exception
            obj.clientId = "-2"
            obj.clientNombre = ex.Message
            obj.clientDireccion = ex.Message
            obj.clientTelefono = ex.Message
            Return obj
        End Try

    End Function

    Sub ListarCliente(ByVal palabra As String, ByVal obj As ListBox)
        Dim c As New Cls_Conexion
        Dim pp As String = ""

        Try
            pp = "select * from cliente where Cliente_Nombre like '%" & palabra & "%'" '" or Marca_Modelo like '%" & palabra & "%'"
            c.consultar(pp)
            obj.Items.Clear()
            While c.rs.Read
                obj.Items.Add(Format(CInt(c.rs("Cliente_Id")), "000") & "  " & Mid(c.rs("Cliente_Nombre") & Space(30), 1, 30) & "  " & Mid(c.rs("Cliente_Direccion") & Space(30), 1, 30) & "   " & c.rs("Cliente_Telefono"))
            End While
            c.rs.Close()
        Catch ex As Exception
        End Try
    End Sub

    Function Autonumerico() As String
        Dim c As New Cls_Conexion
        Dim consulta As String

        consulta = "select max(Cliente_Id) as item from Cliente"
        c.consultar(consulta)
        Autonumerico = 1
        If c.rs.Read Then
            If DBNull.Value.Equals(c.rs("item")) Then Autonumerico = "001" Else Autonumerico = Format(c.rs("item") + 1, "000")
        End If
        c.rs.Close()
    End Function

End Class
