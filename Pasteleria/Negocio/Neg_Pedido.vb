Imports Datos
Public Class Neg_Pedido
    Public Pedido_Id As String
    Public Pedido_Id_Pastel As String
    'Public Pedido_Id_Abono As String
    Public Pedido_FechaPedido As String
    Public Pedido_FechaEntrega As String
    Public Pedido_Comentario As String
    Public Pedido_Id_Cliente As String
    Public Pedido_NumMesas As String
    Public Pedido_Usuario As String
    Public Pedido_Deposito As String
    Public Pedido_HoraEntrega As String



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
                    consulta = "update Pedido set Pedido_Id = '" & obj.Pedido_Id & "',Pedido_id_Pastel = '" & obj.Pedido_Id_Pastel & "',Pedido_Id_Cliente = " & obj.Pedido_Id_Cliente & ",Pedido_FechaPedido = '" & obj.Pedido_FechaPedido & "',Pedido_FechaEntrega= '" & obj.Pedido_FechaEntrega & "',Pedido_HoraEntrega = '" & obj.Pedido_HoraEntrega & "',Pedido_NumMesas = " & obj.Pedido_NumMesas & ",Pedido_Deposito = " & obj.Pedido_Deposito & ",Pedido_Comentario='" & obj.Pedido_Comentario & "',Pedido_Usuario = '" & obj.Pedido_Usuario & "'where Pedido_Id = " & obj.Pedido_Id
                End If

            Else
                'si no existe, agregamos el registro
                consulta = "insert into Pedido values('" & obj.Pedido_Id & "','" & obj.Pedido_Id_Pastel & "','" & obj.Pedido_Id_Cliente & "','" & obj.Pedido_FechaPedido & "','" & obj.Pedido_FechaEntrega & "','" & obj.Pedido_HoraEntrega & "','" & obj.Pedido_NumMesas & "','" & obj.Pedido_Deposito & "','" & obj.Pedido_Comentario & "','" & obj.Pedido_Usuario & "')"

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
                obj.Pedido_Id_Cliente = c.rs("Pedido_id_Cliente")
                obj.Pedido_FechaPedido = c.rs("Pedido_FechaPedido")
                obj.Pedido_FechaEntrega = c.rs("Pedido_FechaEntrega")
                obj.Pedido_NumMesas = c.rs("Pedido_NumMesas")
                obj.Pedido_Comentario = c.rs("Pedido_Comentario")
                obj.Pedido_Deposito = c.rs("Pedido_Deposito")
                obj.Pedido_Usuario = c.rs("Pedido_Usuario")
                obj.Pedido_HoraEntrega = c.rs("Pedido_HoraEntrega")
            Else
                obj.Pedido_Id = "-1"
                obj.Pedido_Id_Pastel = "NO EXISTE"
                obj.Pedido_Id_Cliente = "NO EXISTE"
                obj.Pedido_FechaPedido = "NO EXISTE"
                obj.Pedido_FechaEntrega = "NO EXISTE"
                obj.Pedido_NumMesas = "NO EXISTE"
                obj.Pedido_Comentario = "NO EXISTE"
                obj.Pedido_Deposito = "NO EXISTE"
                obj.Pedido_Usuario = "NO EXISTE"
                obj.Pedido_HoraEntrega = "NO EXISTE"
            End If
            c.rs.Close()
            Return obj
        Catch ex As Exception
            obj.Pedido_Id = "-2"
            obj.Pedido_Id_Pastel = ex.Message
            obj.Pedido_FechaPedido = ex.Message
            obj.Pedido_FechaEntrega = ex.Message
            obj.Pedido_Comentario = ex.Message
            obj.Pedido_Id_Cliente = ex.Message
            obj.Pedido_NumMesas = ex.Message
            obj.Pedido_Deposito = ex.Message
            obj.Pedido_Usuario = ex.Message
            obj.Pedido_HoraEntrega = ex.Message
            Return obj
        End Try

    End Function

    Sub ListarPedido(ByVal palabra As String, ByVal obj As ListBox)
        Dim c As New Cls_Conexion
        Dim pp As String = ""

        Try
            pp = "SELECT Pedido_Id,Cliente_Nombre,Pedido_FechaPedido,Pedido_FechaEntrega,Pastel_Precio,sum(Abono_Valor)AS TAbono,Pedido_Deposito, min(Abono_Saldo) as Saldo FROM Pedido,Cliente,Abono,Pastel WHERE Pedido_Id_Cliente = Cliente_Id and Abono_Id_Pedido = Pedido_Id and Pastel_Id = Pedido_Id_Pastel and Pedido_Id like '%" & palabra & "%' group by Abono_Id_Pedido"
            c.consultar(pp)
            obj.Items.Clear()
            While c.rs.Read
                obj.Items.Add(Format(CInt(c.rs("Pedido_Id")), "000") & " " & Mid(c.rs("Cliente_Nombre") & Space(20), 1, 20) & "  " & Mid(c.rs("Pedido_FechaPedido") & Space(12), 1, 12) & " " & Mid(c.rs("Pedido_FechaEntrega") & Space(12), 1, 12) & " " & Mid(Format(c.rs("Pastel_Precio"), "$ #,#0.#0") & Space(10), 1, 10) & "   " & Mid(Format(c.rs("TAbono"), "$ #,#0.#0") & Space(10), 1, 10) & "   " & Mid(Format(c.rs("Pedido_Deposito"), "$ #,#0.#0") & Space(10), 1, 10) & "   " & Mid(Format(c.rs("Saldo"), "$ #,#0.#0") & Space(10), 1, 10))
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
