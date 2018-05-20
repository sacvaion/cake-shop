<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Abono
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
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtAbono = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtFecha = New System.Windows.Forms.TextBox
        Me.TxtSaldo = New System.Windows.Forms.TextBox
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox
        Me.TxtIdPedido = New System.Windows.Forms.TextBox
        Me.TxtIdAbono = New System.Windows.Forms.TextBox
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardar.Location = New System.Drawing.Point(414, 276)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(101, 34)
        Me.BtnGuardar.TabIndex = 43
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 27)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Nuevo Abono:"
        '
        'TxtAbono
        '
        Me.TxtAbono.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAbono.Location = New System.Drawing.Point(180, 192)
        Me.TxtAbono.Name = "TxtAbono"
        Me.TxtAbono.Size = New System.Drawing.Size(272, 34)
        Me.TxtAbono.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 27)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 27)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Saldo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 27)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Nombre Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 27)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "No. Pedido:"
        '
        'TxtFecha
        '
        Me.TxtFecha.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha.Location = New System.Drawing.Point(180, 152)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.ReadOnly = True
        Me.TxtFecha.Size = New System.Drawing.Size(272, 34)
        Me.TxtFecha.TabIndex = 36
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaldo.Location = New System.Drawing.Point(180, 114)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.ReadOnly = True
        Me.TxtSaldo.Size = New System.Drawing.Size(272, 34)
        Me.TxtSaldo.TabIndex = 35
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreCliente.Location = New System.Drawing.Point(180, 75)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.ReadOnly = True
        Me.TxtNombreCliente.Size = New System.Drawing.Size(272, 34)
        Me.TxtNombreCliente.TabIndex = 34
        '
        'TxtIdPedido
        '
        Me.TxtIdPedido.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.TxtIdPedido.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdPedido.Location = New System.Drawing.Point(180, 35)
        Me.TxtIdPedido.Name = "TxtIdPedido"
        Me.TxtIdPedido.ReadOnly = True
        Me.TxtIdPedido.Size = New System.Drawing.Size(80, 34)
        Me.TxtIdPedido.TabIndex = 33
        '
        'TxtIdAbono
        '
        Me.TxtIdAbono.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.TxtIdAbono.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdAbono.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtIdAbono.Location = New System.Drawing.Point(435, 12)
        Me.TxtIdAbono.Name = "TxtIdAbono"
        Me.TxtIdAbono.ReadOnly = True
        Me.TxtIdAbono.Size = New System.Drawing.Size(80, 34)
        Me.TxtIdAbono.TabIndex = 44
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.Black
        Me.BtnNuevo.Location = New System.Drawing.Point(307, 277)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(101, 34)
        Me.BtnNuevo.TabIndex = 45
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Abono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(525, 332)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtIdAbono)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtAbono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtSaldo)
        Me.Controls.Add(Me.TxtNombreCliente)
        Me.Controls.Add(Me.TxtIdPedido)
        Me.Name = "Abono"
        Me.Text = "Abono"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtAbono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdPedido As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdAbono As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
End Class
