<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pasteleria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pasteleria))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Dirección = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.GBox_Cliente = New System.Windows.Forms.GroupBox
        Me.TxtTelCliente = New System.Windows.Forms.TextBox
        Me.TxtDireCliente = New System.Windows.Forms.TextBox
        Me.TxtNomCliente = New System.Windows.Forms.TextBox
        Me.GBox_Pastel = New System.Windows.Forms.GroupBox
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtComentarios = New System.Windows.Forms.TextBox
        Me.TxtNumPersonas = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.TextBox21 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.TxtForma = New System.Windows.Forms.TextBox
        Me.TxtCubierta = New System.Windows.Forms.TextBox
        Me.TxtNomPastel = New System.Windows.Forms.TextBox
        Me.GBox_Pedido = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TxtUsuario = New System.Windows.Forms.TextBox
        Me.TxtDeposito = New System.Windows.Forms.TextBox
        Me.TxtNumMesas = New System.Windows.Forms.TextBox
        Me.TxtSaldo = New System.Windows.Forms.TextBox
        Me.TxtAbono = New System.Windows.Forms.TextBox
        Me.TxtValorTotal = New System.Windows.Forms.TextBox
        Me.TxtHoraEntrega = New System.Windows.Forms.TextBox
        Me.TxtFechaActual = New System.Windows.Forms.TextBox
        Me.TxtNumPedido = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.TxtIdCliente = New System.Windows.Forms.TextBox
        Me.TxtIdPastel = New System.Windows.Forms.TextBox
        Me.GBox_Cliente.SuspendLayout()
        Me.GBox_Pastel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBox_Pedido.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Dirección
        '
        Me.Dirección.AutoSize = True
        Me.Dirección.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dirección.ForeColor = System.Drawing.Color.Red
        Me.Dirección.Location = New System.Drawing.Point(13, 78)
        Me.Dirección.Name = "Dirección"
        Me.Dirección.Size = New System.Drawing.Size(104, 27)
        Me.Dirección.TabIndex = 1
        Me.Dirección.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(13, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No. Pedido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha Pedido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 27)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha Entrega:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 27)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Hora Entrega:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 27)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Valor Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 27)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Abonos:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 27)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Saldo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 27)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "No. Mesas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 328)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 27)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Deposito:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 362)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(198, 27)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Pedido Recibido Por:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 27)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Pastel:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 158)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 27)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Personas:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 27)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Forma:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 81)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 27)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Cubierta:"
        '
        'GBox_Cliente
        '
        Me.GBox_Cliente.BackColor = System.Drawing.Color.Navy
        Me.GBox_Cliente.Controls.Add(Me.TxtTelCliente)
        Me.GBox_Cliente.Controls.Add(Me.TxtDireCliente)
        Me.GBox_Cliente.Controls.Add(Me.TxtNomCliente)
        Me.GBox_Cliente.Controls.Add(Me.Label1)
        Me.GBox_Cliente.Controls.Add(Me.Dirección)
        Me.GBox_Cliente.Controls.Add(Me.Label2)
        Me.GBox_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox_Cliente.ForeColor = System.Drawing.Color.LightGray
        Me.GBox_Cliente.Location = New System.Drawing.Point(21, 71)
        Me.GBox_Cliente.Name = "GBox_Cliente"
        Me.GBox_Cliente.Size = New System.Drawing.Size(986, 168)
        Me.GBox_Cliente.TabIndex = 17
        Me.GBox_Cliente.TabStop = False
        Me.GBox_Cliente.Text = "Datos Cliente"
        '
        'TxtTelCliente
        '
        Me.TxtTelCliente.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelCliente.Location = New System.Drawing.Point(139, 118)
        Me.TxtTelCliente.Name = "TxtTelCliente"
        Me.TxtTelCliente.Size = New System.Drawing.Size(802, 41)
        Me.TxtTelCliente.TabIndex = 5
        '
        'TxtDireCliente
        '
        Me.TxtDireCliente.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireCliente.Location = New System.Drawing.Point(139, 69)
        Me.TxtDireCliente.Name = "TxtDireCliente"
        Me.TxtDireCliente.Size = New System.Drawing.Size(802, 41)
        Me.TxtDireCliente.TabIndex = 4
        '
        'TxtNomCliente
        '
        Me.TxtNomCliente.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomCliente.Location = New System.Drawing.Point(139, 21)
        Me.TxtNomCliente.Name = "TxtNomCliente"
        Me.TxtNomCliente.Size = New System.Drawing.Size(802, 41)
        Me.TxtNomCliente.TabIndex = 3
        '
        'GBox_Pastel
        '
        Me.GBox_Pastel.BackColor = System.Drawing.Color.Navy
        Me.GBox_Pastel.Controls.Add(Me.BtnNuevo)
        Me.GBox_Pastel.Controls.Add(Me.BtnGuardar)
        Me.GBox_Pastel.Controls.Add(Me.Label17)
        Me.GBox_Pastel.Controls.Add(Me.TxtComentarios)
        Me.GBox_Pastel.Controls.Add(Me.TxtNumPersonas)
        Me.GBox_Pastel.Controls.Add(Me.GroupBox1)
        Me.GBox_Pastel.Controls.Add(Me.TxtForma)
        Me.GBox_Pastel.Controls.Add(Me.TxtCubierta)
        Me.GBox_Pastel.Controls.Add(Me.TxtNomPastel)
        Me.GBox_Pastel.Controls.Add(Me.Label16)
        Me.GBox_Pastel.Controls.Add(Me.Label13)
        Me.GBox_Pastel.Controls.Add(Me.Label14)
        Me.GBox_Pastel.Controls.Add(Me.Label15)
        Me.GBox_Pastel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox_Pastel.ForeColor = System.Drawing.Color.LightGray
        Me.GBox_Pastel.Location = New System.Drawing.Point(459, 245)
        Me.GBox_Pastel.Name = "GBox_Pastel"
        Me.GBox_Pastel.Size = New System.Drawing.Size(548, 436)
        Me.GBox_Pastel.TabIndex = 18
        Me.GBox_Pastel.TabStop = False
        Me.GBox_Pastel.Text = "Datos Pastel"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.Black
        Me.BtnNuevo.Location = New System.Drawing.Point(295, 373)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(101, 34)
        Me.BtnNuevo.TabIndex = 24
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardar.Location = New System.Drawing.Point(402, 373)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(101, 34)
        Me.BtnGuardar.TabIndex = 23
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 248)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(131, 27)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Comentarios:"
        '
        'TxtComentarios
        '
        Me.TxtComentarios.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComentarios.Location = New System.Drawing.Point(20, 290)
        Me.TxtComentarios.Name = "TxtComentarios"
        Me.TxtComentarios.Size = New System.Drawing.Size(437, 26)
        Me.TxtComentarios.TabIndex = 21
        '
        'TxtNumPersonas
        '
        Me.TxtNumPersonas.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumPersonas.Location = New System.Drawing.Point(147, 155)
        Me.TxtNumPersonas.Name = "TxtNumPersonas"
        Me.TxtNumPersonas.Size = New System.Drawing.Size(272, 34)
        Me.TxtNumPersonas.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Navy
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.TextBox15)
        Me.GroupBox1.Controls.Add(Me.TextBox16)
        Me.GroupBox1.Controls.Add(Me.TextBox17)
        Me.GroupBox1.Controls.Add(Me.TextBox18)
        Me.GroupBox1.Controls.Add(Me.TextBox19)
        Me.GroupBox1.Controls.Add(Me.TextBox20)
        Me.GroupBox1.Controls.Add(Me.TextBox21)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Location = New System.Drawing.Point(-438, -6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 436)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Pedido"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(158, 99)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(161, 26)
        Me.DateTimePicker2.TabIndex = 30
        Me.DateTimePicker2.Value = New Date(2012, 9, 12, 15, 29, 22, 0)
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(11, 390)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(277, 34)
        Me.TextBox6.TabIndex = 29
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(158, 325)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(161, 34)
        Me.TextBox14.TabIndex = 28
        '
        'TextBox15
        '
        Me.TextBox15.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(158, 287)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(161, 34)
        Me.TextBox15.TabIndex = 27
        '
        'TextBox16
        '
        Me.TextBox16.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(158, 248)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(161, 34)
        Me.TextBox16.TabIndex = 26
        '
        'TextBox17
        '
        Me.TextBox17.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(158, 209)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(161, 34)
        Me.TextBox17.TabIndex = 25
        '
        'TextBox18
        '
        Me.TextBox18.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(158, 171)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(161, 34)
        Me.TextBox18.TabIndex = 24
        '
        'TextBox19
        '
        Me.TextBox19.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(158, 131)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(161, 34)
        Me.TextBox19.TabIndex = 23
        '
        'TextBox20
        '
        Me.TextBox20.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(158, 54)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(161, 34)
        Me.TextBox20.TabIndex = 21
        '
        'TextBox21
        '
        Me.TextBox21.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.Location = New System.Drawing.Point(158, 17)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(161, 34)
        Me.TextBox21.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(119, 27)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "No. Pedido:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(141, 27)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Fecha Pedido:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 96)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(155, 27)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Fecha Entrega:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 362)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(198, 27)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Pedido Recibido Por:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 134)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(145, 27)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Hora Entrega:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 328)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(98, 27)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Deposito:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 174)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(124, 27)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Valor Total:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 290)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(110, 27)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "No. Mesas"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 212)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 27)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Abonos:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 251)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 27)
        Me.Label28.TabIndex = 9
        Me.Label28.Text = "Saldo:"
        '
        'TxtForma
        '
        Me.TxtForma.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtForma.Location = New System.Drawing.Point(147, 117)
        Me.TxtForma.Name = "TxtForma"
        Me.TxtForma.Size = New System.Drawing.Size(272, 34)
        Me.TxtForma.TabIndex = 19
        '
        'TxtCubierta
        '
        Me.TxtCubierta.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCubierta.Location = New System.Drawing.Point(147, 78)
        Me.TxtCubierta.Name = "TxtCubierta"
        Me.TxtCubierta.Size = New System.Drawing.Size(272, 34)
        Me.TxtCubierta.TabIndex = 18
        '
        'TxtNomPastel
        '
        Me.TxtNomPastel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomPastel.Location = New System.Drawing.Point(147, 40)
        Me.TxtNomPastel.Name = "TxtNomPastel"
        Me.TxtNomPastel.Size = New System.Drawing.Size(272, 34)
        Me.TxtNomPastel.TabIndex = 17
        '
        'GBox_Pedido
        '
        Me.GBox_Pedido.BackColor = System.Drawing.Color.Navy
        Me.GBox_Pedido.Controls.Add(Me.DateTimePicker1)
        Me.GBox_Pedido.Controls.Add(Me.TxtUsuario)
        Me.GBox_Pedido.Controls.Add(Me.TxtDeposito)
        Me.GBox_Pedido.Controls.Add(Me.TxtNumMesas)
        Me.GBox_Pedido.Controls.Add(Me.TxtSaldo)
        Me.GBox_Pedido.Controls.Add(Me.TxtAbono)
        Me.GBox_Pedido.Controls.Add(Me.TxtValorTotal)
        Me.GBox_Pedido.Controls.Add(Me.TxtHoraEntrega)
        Me.GBox_Pedido.Controls.Add(Me.TxtFechaActual)
        Me.GBox_Pedido.Controls.Add(Me.TxtNumPedido)
        Me.GBox_Pedido.Controls.Add(Me.Label3)
        Me.GBox_Pedido.Controls.Add(Me.Label4)
        Me.GBox_Pedido.Controls.Add(Me.Label5)
        Me.GBox_Pedido.Controls.Add(Me.Label12)
        Me.GBox_Pedido.Controls.Add(Me.Label6)
        Me.GBox_Pedido.Controls.Add(Me.Label11)
        Me.GBox_Pedido.Controls.Add(Me.Label7)
        Me.GBox_Pedido.Controls.Add(Me.Label10)
        Me.GBox_Pedido.Controls.Add(Me.Label8)
        Me.GBox_Pedido.Controls.Add(Me.Label9)
        Me.GBox_Pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox_Pedido.ForeColor = System.Drawing.Color.LightGray
        Me.GBox_Pedido.Location = New System.Drawing.Point(21, 245)
        Me.GBox_Pedido.Name = "GBox_Pedido"
        Me.GBox_Pedido.Size = New System.Drawing.Size(422, 436)
        Me.GBox_Pedido.TabIndex = 19
        Me.GBox_Pedido.TabStop = False
        Me.GBox_Pedido.Text = "Datos Pedido"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(158, 99)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(161, 26)
        Me.DateTimePicker1.TabIndex = 30
        Me.DateTimePicker1.Value = New Date(2012, 9, 12, 15, 29, 22, 0)
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(11, 390)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(277, 34)
        Me.TxtUsuario.TabIndex = 29
        '
        'TxtDeposito
        '
        Me.TxtDeposito.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeposito.Location = New System.Drawing.Point(158, 325)
        Me.TxtDeposito.Name = "TxtDeposito"
        Me.TxtDeposito.Size = New System.Drawing.Size(161, 34)
        Me.TxtDeposito.TabIndex = 28
        '
        'TxtNumMesas
        '
        Me.TxtNumMesas.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumMesas.Location = New System.Drawing.Point(158, 287)
        Me.TxtNumMesas.Name = "TxtNumMesas"
        Me.TxtNumMesas.Size = New System.Drawing.Size(161, 34)
        Me.TxtNumMesas.TabIndex = 27
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaldo.Location = New System.Drawing.Point(158, 248)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(161, 34)
        Me.TxtSaldo.TabIndex = 26
        '
        'TxtAbono
        '
        Me.TxtAbono.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAbono.Location = New System.Drawing.Point(158, 209)
        Me.TxtAbono.Name = "TxtAbono"
        Me.TxtAbono.Size = New System.Drawing.Size(161, 34)
        Me.TxtAbono.TabIndex = 25
        '
        'TxtValorTotal
        '
        Me.TxtValorTotal.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValorTotal.Location = New System.Drawing.Point(158, 171)
        Me.TxtValorTotal.Name = "TxtValorTotal"
        Me.TxtValorTotal.Size = New System.Drawing.Size(161, 34)
        Me.TxtValorTotal.TabIndex = 24
        '
        'TxtHoraEntrega
        '
        Me.TxtHoraEntrega.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHoraEntrega.Location = New System.Drawing.Point(158, 131)
        Me.TxtHoraEntrega.Name = "TxtHoraEntrega"
        Me.TxtHoraEntrega.Size = New System.Drawing.Size(161, 34)
        Me.TxtHoraEntrega.TabIndex = 23
        '
        'TxtFechaActual
        '
        Me.TxtFechaActual.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaActual.Location = New System.Drawing.Point(158, 54)
        Me.TxtFechaActual.Name = "TxtFechaActual"
        Me.TxtFechaActual.Size = New System.Drawing.Size(161, 34)
        Me.TxtFechaActual.TabIndex = 21
        '
        'TxtNumPedido
        '
        Me.TxtNumPedido.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumPedido.Location = New System.Drawing.Point(158, 17)
        Me.TxtNumPedido.Name = "TxtNumPedido"
        Me.TxtNumPedido.Size = New System.Drawing.Size(161, 34)
        Me.TxtNumPedido.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(659, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(332, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(434, 3)
        Me.AxShockwaveFlash1.Margin = New System.Windows.Forms.Padding(0)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(179, 65)
        Me.AxShockwaveFlash1.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(917, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "IdCliente"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(917, 33)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(53, 13)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "IdPonque"
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtIdCliente.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TxtIdCliente.Location = New System.Drawing.Point(978, 7)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.ReadOnly = True
        Me.TxtIdCliente.Size = New System.Drawing.Size(50, 20)
        Me.TxtIdCliente.TabIndex = 26
        '
        'TxtIdPastel
        '
        Me.TxtIdPastel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtIdPastel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TxtIdPastel.Location = New System.Drawing.Point(978, 30)
        Me.TxtIdPastel.Name = "TxtIdPastel"
        Me.TxtIdPastel.ReadOnly = True
        Me.TxtIdPastel.Size = New System.Drawing.Size(50, 20)
        Me.TxtIdPastel.TabIndex = 28
        '
        'Pasteleria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 689)
        Me.Controls.Add(Me.TxtIdPastel)
        Me.Controls.Add(Me.TxtIdCliente)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GBox_Pedido)
        Me.Controls.Add(Me.GBox_Pastel)
        Me.Controls.Add(Me.GBox_Cliente)
        Me.Name = "Pasteleria"
        Me.Text = "Pasteleria"
        Me.GBox_Cliente.ResumeLayout(False)
        Me.GBox_Cliente.PerformLayout()
        Me.GBox_Pastel.ResumeLayout(False)
        Me.GBox_Pastel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBox_Pedido.ResumeLayout(False)
        Me.GBox_Pedido.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dirección As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GBox_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents GBox_Pastel As System.Windows.Forms.GroupBox
    Friend WithEvents GBox_Pedido As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTelCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumPedido As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomPastel As System.Windows.Forms.TextBox
    Friend WithEvents TxtFechaActual As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumPersonas As System.Windows.Forms.TextBox
    Friend WithEvents TxtForma As System.Windows.Forms.TextBox
    Friend WithEvents TxtCubierta As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumMesas As System.Windows.Forms.TextBox
    Friend WithEvents TxtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents TxtAbono As System.Windows.Forms.TextBox
    Friend WithEvents TxtValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtDeposito As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtHoraEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TxtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdPastel As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button

End Class
