Imports MySql.Data.MySqlClient

Public Class Cls_Conexion

    'Declaramos atributos de la clase
    Public cn As MySqlConnection   'Conexión 
    Public cm As New MySqlCommand      'Ejecuta la conexión
    'Public da As New MySqlDataAdapter
    'Public ds As New DataSet
    Public rs As System.Data.IDataReader 'Es el recordset de la consulta 
    'Public dt As New DataTable


    Sub Conectar()
        Dim bConexionExitosa As Boolean = True
        Try
            cn = New MySqlConnection("uid=root;server=localhost;password=root;database=pasteleria;port=3306;Pooling=false;Connection Lifetime=1; Max Pool Size=1")
            'cn = New MySqlConnection("uid=root;server=tecnologia;password=root;database=intranet_admin;port=3306;Pooling=false;Connection Lifetime=1; Max Pool Size=1")
            'Abrimos la conexión y comprobamos que no hay error
            cn.Open()
            bConexionExitosa = True
        Catch ex As MySqlException
            'Si hubiese error en la conexión mostramos el texto de la descripción
            MsgBox(ex.Message.ToString)
            bConexionExitosa = False
        End Try
    End Sub

    Sub consultar(ByVal consulta As String)
        Try
            cn = New MySqlConnection("uid=root;server=localhost;password=root;database=pasteleria;port=3306;Pooling=false;Connection Lifetime=1; Max Pool Size=1")
            'cn = New MySqlConnection("uid=root;server=tecnologia;password=root;database=intranet_admin;port=3306;Pooling=false;Connection Lifetime=1; Max Pool Size=1")
            'Abrimos la conexión y comprobamos que no hay error
            cn.Open()
            cm.Connection = cn
            cm.CommandText = consulta
            cm.CommandType = CommandType.Text
            rs = cm.ExecuteReader()
        Catch ex As MySqlException
            'Si hubiese error en la conexión mostramos el texto de la descripción
            MsgBox("ERROR" & ex.Message.ToString, MsgBoxStyle.Exclamation, "CONEXION")
        End Try
    End Sub


End Class

