Imports Datos
Public Class Neg_Abono
    Public Abono_Id As String
    Public Abono_Id_Pedido As String
    Public Abono_Valor As String
    Public Abono_Saldo As String
    Public Abono_Fecha As String


    Function existeAbono(ByVal campo As String, ByVal Valor_campo As String) As String
        Dim c As New Cls_Conexion
        Dim consulta As String = ""
        Try
            If IsNumeric(Valor_campo) Then
                consulta = "select * from Abono where " & campo & " = " & Valor_campo
            Else
                consulta = "select * from Abono where " & campo & " = '" & Valor_campo & "'"
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

    Function insertarAbono(ByVal obj As Neg_Abono) As String
        Dim c As New Cls_Conexion
        Dim consulta As String = ""
        Dim existe As String = ""

        Try
            'Validamos si el objeto existe
            existe = obj.existeAbono("Abono_id", obj.Abono_Id)
            If existe = "El objeto si existe" Then

                If MsgBox("Està seguro que desea modificar el registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje de confirmacion") = MsgBoxResult.No Then
                    Return ""
                Else
                    'si existe, agregamos la modificacion
                    consulta = "update Abono set Abono_Id = '" & obj.Abono_Id & "',Abono_Id_Pedido = '" & obj.Abono_Id_Pedido & "',Abono_Valor = '" & obj.Abono_Valor & "',Abono_Saldo= '" & obj.Abono_Saldo & "',Abono_Fecha= '" & obj.Abono_Fecha & "'where Abono_Id = " & obj.Abono_Id
                End If

            Else
                'si no existe, agregamos el registro
                consulta = "insert into Abono values('" & obj.Abono_Id & "','" & obj.Abono_Id_Pedido & "','" & obj.Abono_Valor & "','" & obj.Abono_Saldo & "','" & obj.Abono_Fecha & "')"

            End If

            c.consultar(consulta)
            c.rs.Close()
            Return "Registro Agregado / Actualizado satisfactoriamente"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function extraerDatos(ByVal Cod As String) As Neg_Abono
        Dim c As New Cls_Conexion
        Dim consulta As String = ""
        Dim obj As New Neg_Abono

        Try
            consulta = "SELECT Max(Abono_Id)As Id,Abono_Id_Pedido,sum(Abono_Valor) as VTotal,Min(Abono_Saldo) as Saldo,Abono_Fecha FROM `Abono` WHERE Abono_Id_Pedido=" & Cod & " Group By Abono_Id_Pedido"
            c.consultar(consulta)
            If c.rs.Read Then
                obj.Abono_Id = c.rs("Id")
                obj.Abono_Id_Pedido = c.rs("Abono_Id_Pedido")
                obj.Abono_Valor = Format(c.rs("VTotal"), "$ #,#0.#0")
                obj.Abono_Saldo = Format(c.rs("Saldo"), "$ #,#0.#0")
                obj.Abono_Fecha = c.rs("Abono_Fecha")
            Else

                obj.Abono_Id = "-1"
                obj.Abono_Id_Pedido = "NO EXISTE"
                obj.Abono_Valor = "NO EXISTE"
                obj.Abono_Saldo = "NO EXISTE"
                obj.Abono_Fecha = "NO EXISTE"
            End If
            c.rs.Close()
            Return obj
        Catch ex As Exception
            obj.Abono_Id = "-2"
            obj.Abono_Id_Pedido = ex.Message
            obj.Abono_Valor = ex.Message
            obj.Abono_Saldo = ex.Message
            obj.Abono_Fecha = ex.Message
            Return obj
        End Try

    End Function

    Sub listarAbono(ByVal palabra As String, ByVal obj As ListBox)
        Dim c As New Cls_Conexion
        Dim pp As String = ""

        Try
            pp = "select cliente.Cliente_Nombre, Pedido.Pedido_Id,Abono.Abono_Fecha,Abono.Abono_Valor, Abono.Abono_Saldo from pedido,abono,cliente where Abono_Id_Pedido=Pedido_Id and Pedido_Id_Cliente=Cliente_Id and (Pedido_Id like '%" & palabra & "%' or Cliente_Nombre like '%" & palabra & "%')order by Pedido_Id"
            c.consultar(pp)
            obj.Items.Clear()
            While c.rs.Read
                obj.Items.Add(Format(CInt(c.rs("Pedido_Id")), "000") & "  " & Mid(c.rs("Cliente_Nombre") & Space(30), 1, 30) & "  " & Mid(c.rs("Abono_Fecha") & Space(12), 1, 12) & " " & Mid(Format(c.rs("Abono_Valor"), "$ #,#0.#0") & Space(12), 1, 12) & "     " & Format(c.rs("Abono_Saldo"), "$ #,#0.#0"))
            End While
            c.rs.Close()
        Catch ex As Exception
        End Try
    End Sub

    Function autonumerico() As String
        Dim c As New Cls_Conexion
        Dim consulta As String

        consulta = "select max(Abono_Id) as item from Abono"
        c.consultar(consulta)
        Autonumerico = 1
        If c.rs.Read Then
            If DBNull.Value.Equals(c.rs("item")) Then Autonumerico = "001" Else Autonumerico = Format(c.rs("item") + 1, "000")
        End If
        c.rs.Close()
    End Function

    Function saldo(ByVal valor As Double, ByVal abono As Double)
        Return valor - abono
    End Function

    Function totalAbonos(ByVal cod As String)
        Dim c As New Cls_Conexion
        Dim consulta As String
        Dim total As String = ""
        consulta = "SELECT sum(Abono_Valor)AS TAbono FROM Abono WHERE Abono_Id=" & cod
        c.consultar(consulta)
        If c.rs.Read Then
            total = c.rs("TAbono")
        End If
        c.rs.Close()
        Return total
    End Function

End Class
