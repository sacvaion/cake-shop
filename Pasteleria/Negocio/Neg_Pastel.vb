Imports Datos
Public Class Neg_Pastel
    Public Pastel_Id As String
    Public Pastel_Nombre As String
    Public Pastel_Precio As String
    Public Pastel_NumPers As String
    Public Pastel_Detalle As String
    Public Pastel_Forma As String
    Public Pastel_Cubierta As String



    Function existePastel(ByVal campo As String, ByVal Valor_campo As String) As String
        Dim c As New Cls_Conexion
        Dim consulta As String = ""
        Try
            If IsNumeric(Valor_campo) Then
                consulta = "select * from Pastel where " & campo & " = " & Valor_campo
            Else
                consulta = "select * from Pastel where " & campo & " = '" & Valor_campo & "'"
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

    Function insertarPastel(ByVal obj As Neg_Pastel) As String
        Dim c As New Cls_Conexion
        Dim consulta As String = ""
        Dim existe As String = ""

        Try
            'Validamos si el objeto existe
            existe = obj.existePastel("Pastel_id", obj.Pastel_Id)
            If existe = "El objeto si existe" Then

                If MsgBox("Està seguro que desea modificar el registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje de confirmacion") = MsgBoxResult.No Then
                    Return ""
                Else
                    'si existe, agregamos la modificacion
                    consulta = "update Pastel set Pastel_Id = '" & obj.Pastel_Id & "',Pastel_Nombre = '" & obj.Pastel_Nombre & "',Pastel_Precio = '" & obj.Pastel_Precio & "',Pastel_NumPers= '" & obj.Pastel_NumPers & "',Pastel_Detalle= '" & obj.Pastel_Detalle & "',Pastel_Forma= '" & obj.Pastel_Forma & "',Pastel_Cubierta= '" & obj.Pastel_Cubierta & "'where Pastel_Id = " & obj.Pastel_Id
                End If

            Else
                'si no existe, agregamos el registro
                consulta = "insert into Pastel values('" & obj.Pastel_Id & "','" & obj.Pastel_Nombre & "','" & obj.Pastel_Precio & "','" & obj.Pastel_NumPers & "','" & obj.Pastel_Detalle & "','" & obj.Pastel_Forma & "','" & obj.Pastel_Cubierta & "')"

            End If

            c.consultar(consulta)
            c.rs.Close()
            Return "Registro Agregado / Actualizado satisfactoriamente"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function extraerDatos(ByVal Cod As String) As Neg_Pastel
        Dim c As New Cls_Conexion
        Dim consulta As String = ""
        Dim obj As New Neg_Pastel

        Try
            consulta = "Select * From Pastel where Pastel_Id= " & Cod
            c.consultar(consulta)
            If c.rs.Read Then
                obj.Pastel_Id = c.rs("Pastel_Id")
                obj.Pastel_Nombre = c.rs("Pastel_Nombre")
                obj.Pastel_Precio = c.rs("Pastel_Precio")
                obj.Pastel_NumPers = c.rs("Pastel_NumPers")
                obj.Pastel_Detalle = c.rs("Pastel_Detalle")
                obj.Pastel_Forma = c.rs("Pastel_Forma")
                obj.Pastel_Cubierta = c.rs("Pastel_Cubierta")
            Else
                obj.Pastel_Id = "-1"
                obj.Pastel_Nombre = "NO EXISTE"
                obj.Pastel_Precio = "NO EXISTE"
                obj.Pastel_NumPers = "NO EXISTE"
                obj.Pastel_Detalle = "NO EXISTE"
                obj.Pastel_Forma = "NO EXISTE"
                obj.Pastel_Cubierta = "NO EXISTE"
            End If
            c.rs.Close()
            Return obj
        Catch ex As Exception
            obj.Pastel_Id = "-2"
            obj.Pastel_Nombre = ex.Message
            obj.Pastel_Precio = ex.Message
            obj.Pastel_NumPers = ex.Message
            obj.Pastel_Detalle = ex.Message
            obj.Pastel_Forma = ex.Message
            obj.Pastel_Cubierta = ex.Message
            Return obj
        End Try

    End Function

    Sub listarPastel(ByVal palabra As String, ByVal obj As ListBox)
        Dim c As New Cls_Conexion
        Dim pp As String = ""

        Try
            pp = "select * from pastel where Pastel_Nombre like '%" & palabra & "%'" '" or Marca_Modelo like '%" & palabra & "%'"
            c.consultar(pp)
            obj.Items.Clear()
            While c.rs.Read
                obj.Items.Add(Format(CInt(c.rs("Pastel_Id")), "000") & "  " & Mid(c.rs("Pastel_Nombre") & Space(20), 1, 20) & "  " & Mid(c.rs("Pastel_Forma") & Space(10), 1, 10) & "   " & Mid(c.rs("Pastel_Precio") & Space(10), 1, 10) & "   " & c.rs("Pastel_NumPers"))
            End While
            c.rs.Close()
        Catch ex As Exception
        End Try
    End Sub

    Function Autonumerico() As String
        Dim c As New Cls_Conexion
        Dim consulta As String

        consulta = "select max(Pastel_Id) as item from Pastel"
        c.consultar(consulta)
        Autonumerico = 1
        If c.rs.Read Then
            If DBNull.Value.Equals(c.rs("item")) Then Autonumerico = "001" Else Autonumerico = Format(c.rs("item") + 1, "000")
        End If
        c.rs.Close()
    End Function

End Class
