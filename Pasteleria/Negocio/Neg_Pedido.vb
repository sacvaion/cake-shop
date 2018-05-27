Imports Datos
Public Class Neg_Pedido
    Public Pedido_Id As String
    Public Pedido_Id_Pastel As String
    'Public Pedido_Id_Abono As String
    Public Pedido_FechaPedido As String
    Public Pedido_FechaEntrega As String
    Public Pedido_Comentario As String

    Function ExistePedido(ByVal campo As String, ByVal Valor_campo As String) As String
        Dim c As New Cls_Conexion
        Dim consulta As String = ""
        Try
            If IsNumeric(Valor_campo) Then
                consulta = "select * from pedido where " & campo & " = " & Valor_campo
            Else
                consulta = "select * from pedido where " & campo & " = '" & Valor_campo & "'"
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

    Function InsertarPedido(ByVal obj As Neg_Pedido) As String
        Dim c As New Cls_Conexion
        Dim consulta As String = ""
        Dim existe As String = ""

        Try
            'Validamos si el objeto existe
            existe = obj.ExistePedido("Pedido_id", obj.Pedido_Id)
            If existe = "El objeto si existe" Then

                If MsgBox("Està seguro que desea modificar el registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje de Confirmacion Cliente") = MsgBoxResult.No Then
                    Return ""
                Else
                    'si existe, agregamos la modificacion
                    consulta = "update Pedido set Pedido_Id = '" & obj.Pedido_Id & "',Pedido_id_Pastel = '" & obj.Pedido_id_Pastel & "',Pedido_FechaPedido = '" & obj.Pedido_FechaPedido & "',Pedido_FechaEntrega= '" & obj.Pedido_FechaEntrega & "',Pedido_Comentario='" & obj.Pedido_Comentario & "'where Pedido_Id = " & obj.Pedido_Id
                End If

            Else
                'si no existe, agregamos el registro
                consulta = "insert into Pedido values('" & obj.Pedido_Id & "','" & obj.Pedido_id_Pastel & "','" & obj.Pedido_FechaPedido & "','" & obj.Pedido_FechaEntrega & "','" & obj.Pedido_Comentario & "')"

            End If

            c.consultar(consulta)
            c.rs.Close()
            Return "Registro Agregado / Actualizado satisfactoriamente"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function extraerDatos(ByVal Cod As String) As Neg_Pedido
        Dim c As New Cls_Conexion
        Dim consulta As String = ""
        Dim obj As New Neg_Pedido

        Try
            consulta = "Select * From Pedido where Pedido_Id= " & Cod
            c.consultar(consulta)
            If c.rs.Read Then
                obj.Pedido_Id = c.rs("Pedido_Id")
                obj.Pedido_Id_Pastel = c.rs("Pedido_id_Pastel")
                obj.Pedido_FechaPedido = c.rs("Pedido_FechaPedido")
                obj.Pedido_FechaEntrega = c.rs("Pedido_FechaEntrega")
                obj.Pedido_Comentario = c.rs("Pedido_Comentario")
            Else
                obj.Pedido_Id = "-1"
                obj.Pedido_Id_Pastel = "NO EXISTE"
                obj.Pedido_FechaPedido = "NO EXISTE"
                obj.Pedido_FechaEntrega = "NO EXISTE"
                obj.Pedido_Comentario = "NO EXISTE"
            End If
            c.rs.Close()
            Return obj
        Catch ex As Exception
            obj.Pedido_Id = "-2"
            obj.Pedido_Id_Pastel = ex.Message
            obj.Pedido_FechaPedido = ex.Message
            obj.Pedido_FechaEntrega = ex.Message
            obj.Pedido_Comentario = ex.Message
            Return obj
        End Try

    End Function

    Sub ListarCliente(ByVal palabra As String, ByVal obj As ListBox)
        Dim c As New Cls_Conexion
        Dim pp As String = ""

        Try
            pp = "select * from Pedido where Pedido_id like '%" & palabra & "%'" '" or Marca_Modelo like '%" & palabra & "%'"
            c.consultar(pp)
            obj.Items.Clear()
            While c.rs.Read
                obj.Items.Add(Format(CInt(c.rs("Pedido_Id")), "000") & "  " & Format(CInt(c.rs("Pedido_Id_Pastel")), "000") & "" & Mid(c.rs("Pedido_Nombre_Cliente") & Space(30), 1, 30) & "  " & Mid(c.rs("Pedido_FechaPedido") & Space(30), 1, 30) & "   " & c.rs("Pedido_FechaEntrega"))
            End While
            c.rs.Close()
        Catch ex As Exception
        End Try
    End Sub

    Function Autonumerico() As String
        Dim c As New Cls_Conexion
        Dim consulta As String

        consulta = "select max(Pedido_Id) as item from Pedido"
        c.consultar(consulta)
        Autonumerico = 1
        If c.rs.Read Then
            If DBNull.Value.Equals(c.rs("item")) Then Autonumerico = "001" Else Autonumerico = Format(c.rs("item") + 1, "000")
        End If
        c.rs.Close()
    End Function

End Class
