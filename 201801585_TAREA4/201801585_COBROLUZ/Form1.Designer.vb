<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbServicio = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbTarifa = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKWH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSaldoAnterior = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLregistros = New System.Windows.Forms.Button()
        Me.btnLentradas = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.listFinal = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.listParcial = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.listDescuento = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.listMora = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.listInicial = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.listSaldo = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.listTarifa = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.listServicio = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.listNIT = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.listCliente = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbServicio
        '
        Me.cmbServicio.FormattingEnabled = True
        Me.cmbServicio.Items.AddRange(New Object() {"Residencial", "Industrial"})
        Me.cmbServicio.Location = New System.Drawing.Point(158, 77)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Size = New System.Drawing.Size(121, 23)
        Me.cmbServicio.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 174)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbTarifa)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtKWH)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmbServicio)
        Me.GroupBox3.Controls.Add(Me.txtSaldoAnterior)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(345, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(318, 145)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos consumo eléctrico"
        '
        'cmbTarifa
        '
        Me.cmbTarifa.FormattingEnabled = True
        Me.cmbTarifa.Items.AddRange(New Object() {"Social", "No social"})
        Me.cmbTarifa.Location = New System.Drawing.Point(158, 113)
        Me.cmbTarifa.Name = "cmbTarifa"
        Me.cmbTarifa.Size = New System.Drawing.Size(121, 23)
        Me.cmbTarifa.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tipo de tarifa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipo de servicio"
        '
        'txtKWH
        '
        Me.txtKWH.Location = New System.Drawing.Point(158, 46)
        Me.txtKWH.Name = "txtKWH"
        Me.txtKWH.Size = New System.Drawing.Size(121, 23)
        Me.txtKWH.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Consumo mes actual kwh"
        '
        'txtSaldoAnterior
        '
        Me.txtSaldoAnterior.Location = New System.Drawing.Point(158, 17)
        Me.txtSaldoAnterior.Name = "txtSaldoAnterior"
        Me.txtSaldoAnterior.Size = New System.Drawing.Size(121, 23)
        Me.txtSaldoAnterior.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(59, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Saldo anterior Q"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNit)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos consumidor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(63, 48)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(193, 23)
        Me.txtNit.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(63, 16)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(193, 23)
        Me.txtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIT"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btnSalir)
        Me.GroupBox4.Controls.Add(Me.btnLregistros)
        Me.GroupBox4.Controls.Add(Me.btnLentradas)
        Me.GroupBox4.Controls.Add(Me.btnCalcular)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(709, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(261, 174)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ACCIONES"
        '
        'btnSalir
        '
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Location = New System.Drawing.Point(75, 108)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLregistros
        '
        Me.btnLregistros.ForeColor = System.Drawing.Color.Black
        Me.btnLregistros.Location = New System.Drawing.Point(139, 79)
        Me.btnLregistros.Name = "btnLregistros"
        Me.btnLregistros.Size = New System.Drawing.Size(116, 23)
        Me.btnLregistros.TabIndex = 2
        Me.btnLregistros.Text = "Limpiar Registros"
        Me.btnLregistros.UseVisualStyleBackColor = True
        '
        'btnLentradas
        '
        Me.btnLentradas.ForeColor = System.Drawing.Color.Black
        Me.btnLentradas.Location = New System.Drawing.Point(6, 79)
        Me.btnLentradas.Name = "btnLentradas"
        Me.btnLentradas.Size = New System.Drawing.Size(116, 23)
        Me.btnLentradas.TabIndex = 1
        Me.btnLentradas.Text = "Limpiar Entradas"
        Me.btnLentradas.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.ForeColor = System.Drawing.Color.Black
        Me.btnCalcular.Location = New System.Drawing.Point(6, 50)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(249, 23)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.listFinal)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.listParcial)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.listDescuento)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.listMora)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.listInicial)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.listSaldo)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.listTarifa)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.listServicio)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.listNIT)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.listCliente)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(958, 211)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Resultados"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(850, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 15)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Pago Final"
        '
        'listFinal
        '
        Me.listFinal.FormattingEnabled = True
        Me.listFinal.ItemHeight = 15
        Me.listFinal.Location = New System.Drawing.Point(850, 42)
        Me.listFinal.Name = "listFinal"
        Me.listFinal.Size = New System.Drawing.Size(84, 124)
        Me.listFinal.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(579, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 15)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Pago Parcial"
        '
        'listParcial
        '
        Me.listParcial.FormattingEnabled = True
        Me.listParcial.ItemHeight = 15
        Me.listParcial.Location = New System.Drawing.Point(579, 42)
        Me.listParcial.Name = "listParcial"
        Me.listParcial.Size = New System.Drawing.Size(84, 124)
        Me.listParcial.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(669, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 15)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Descuento"
        '
        'listDescuento
        '
        Me.listDescuento.FormattingEnabled = True
        Me.listDescuento.ItemHeight = 15
        Me.listDescuento.Location = New System.Drawing.Point(669, 42)
        Me.listDescuento.Name = "listDescuento"
        Me.listDescuento.Size = New System.Drawing.Size(84, 124)
        Me.listDescuento.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(489, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 15)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Pago Inicial"
        '
        'listMora
        '
        Me.listMora.FormattingEnabled = True
        Me.listMora.ItemHeight = 15
        Me.listMora.Location = New System.Drawing.Point(760, 42)
        Me.listMora.Name = "listMora"
        Me.listMora.Size = New System.Drawing.Size(84, 124)
        Me.listMora.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(760, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 15)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Mora"
        '
        'listInicial
        '
        Me.listInicial.FormattingEnabled = True
        Me.listInicial.ItemHeight = 15
        Me.listInicial.Location = New System.Drawing.Point(489, 42)
        Me.listInicial.Name = "listInicial"
        Me.listInicial.Size = New System.Drawing.Size(84, 124)
        Me.listInicial.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(400, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Saldo Anterior"
        '
        'listSaldo
        '
        Me.listSaldo.FormattingEnabled = True
        Me.listSaldo.ItemHeight = 15
        Me.listSaldo.Location = New System.Drawing.Point(399, 42)
        Me.listSaldo.Name = "listSaldo"
        Me.listSaldo.Size = New System.Drawing.Size(84, 124)
        Me.listSaldo.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(293, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 15)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Tipo de Tarifa"
        '
        'listTarifa
        '
        Me.listTarifa.FormattingEnabled = True
        Me.listTarifa.ItemHeight = 15
        Me.listTarifa.Location = New System.Drawing.Point(292, 42)
        Me.listTarifa.Name = "listTarifa"
        Me.listTarifa.Size = New System.Drawing.Size(101, 124)
        Me.listTarifa.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(187, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Tipo de Servicio"
        '
        'listServicio
        '
        Me.listServicio.FormattingEnabled = True
        Me.listServicio.ItemHeight = 15
        Me.listServicio.Location = New System.Drawing.Point(186, 42)
        Me.listServicio.Name = "listServicio"
        Me.listServicio.Size = New System.Drawing.Size(100, 124)
        Me.listServicio.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "NIT"
        '
        'listNIT
        '
        Me.listNIT.FormattingEnabled = True
        Me.listNIT.ItemHeight = 15
        Me.listNIT.Location = New System.Drawing.Point(96, 42)
        Me.listNIT.Name = "listNIT"
        Me.listNIT.Size = New System.Drawing.Size(84, 124)
        Me.listNIT.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Cliente"
        '
        'listCliente
        '
        Me.listCliente.FormattingEnabled = True
        Me.listCliente.ItemHeight = 15
        Me.listCliente.Location = New System.Drawing.Point(6, 42)
        Me.listCliente.Name = "listCliente"
        Me.listCliente.Size = New System.Drawing.Size(84, 124)
        Me.listCliente.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201801585_COBROLUZ.My.Resources.Resources._67313
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 415)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbServicio As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNit As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbTarifa As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKWH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSaldoAnterior As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnLregistros As Button
    Friend WithEvents btnLentradas As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents listCliente As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents listMora As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents listInicial As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents listSaldo As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents listTarifa As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents listServicio As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents listNIT As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents listDescuento As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents listParcial As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents listFinal As ListBox
End Class
