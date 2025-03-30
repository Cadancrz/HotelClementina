<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnOcultarISV = New System.Windows.Forms.Button()
        Me.BtnMostrarISV = New System.Windows.Forms.Button()
        Me.GbxImpuesto15 = New System.Windows.Forms.GroupBox()
        Me.BtnCalcular2 = New System.Windows.Forms.Button()
        Me.BtnLimpiar2 = New System.Windows.Forms.Button()
        Me.TxtTotal2 = New System.Windows.Forms.TextBox()
        Me.TxtNeto2 = New System.Windows.Forms.TextBox()
        Me.TxtImpuesto2 = New System.Windows.Forms.TextBox()
        Me.TxtBase2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GbxImpuesto4 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtImpTur = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBase = New System.Windows.Forms.TextBox()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.TxtNeto = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbxImpuesto15.SuspendLayout()
        Me.GbxImpuesto4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Segoe Print", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.White
        Me.LblUsuario.Location = New System.Drawing.Point(247, 116)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(0, 44)
        Me.LblUsuario.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 44)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bienvenido(a)"
        '
        'BtnOcultarISV
        '
        Me.BtnOcultarISV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BtnOcultarISV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOcultarISV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOcultarISV.Location = New System.Drawing.Point(1111, 114)
        Me.BtnOcultarISV.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOcultarISV.Name = "BtnOcultarISV"
        Me.BtnOcultarISV.Size = New System.Drawing.Size(151, 46)
        Me.BtnOcultarISV.TabIndex = 24
        Me.BtnOcultarISV.Text = "Ocultar"
        Me.BtnOcultarISV.UseVisualStyleBackColor = False
        '
        'BtnMostrarISV
        '
        Me.BtnMostrarISV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BtnMostrarISV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrarISV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrarISV.Location = New System.Drawing.Point(952, 114)
        Me.BtnMostrarISV.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMostrarISV.Name = "BtnMostrarISV"
        Me.BtnMostrarISV.Size = New System.Drawing.Size(151, 46)
        Me.BtnMostrarISV.TabIndex = 23
        Me.BtnMostrarISV.Text = "Mostrar"
        Me.BtnMostrarISV.UseVisualStyleBackColor = False
        '
        'GbxImpuesto15
        '
        Me.GbxImpuesto15.Controls.Add(Me.BtnCalcular2)
        Me.GbxImpuesto15.Controls.Add(Me.BtnLimpiar2)
        Me.GbxImpuesto15.Controls.Add(Me.TxtTotal2)
        Me.GbxImpuesto15.Controls.Add(Me.TxtNeto2)
        Me.GbxImpuesto15.Controls.Add(Me.TxtImpuesto2)
        Me.GbxImpuesto15.Controls.Add(Me.TxtBase2)
        Me.GbxImpuesto15.Controls.Add(Me.Label8)
        Me.GbxImpuesto15.Controls.Add(Me.Label9)
        Me.GbxImpuesto15.Controls.Add(Me.Label10)
        Me.GbxImpuesto15.Controls.Add(Me.Label11)
        Me.GbxImpuesto15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxImpuesto15.ForeColor = System.Drawing.Color.White
        Me.GbxImpuesto15.Location = New System.Drawing.Point(715, 526)
        Me.GbxImpuesto15.Margin = New System.Windows.Forms.Padding(4)
        Me.GbxImpuesto15.Name = "GbxImpuesto15"
        Me.GbxImpuesto15.Padding = New System.Windows.Forms.Padding(4)
        Me.GbxImpuesto15.Size = New System.Drawing.Size(547, 364)
        Me.GbxImpuesto15.TabIndex = 28
        Me.GbxImpuesto15.TabStop = False
        Me.GbxImpuesto15.Text = "Impuesto 15%"
        '
        'BtnCalcular2
        '
        Me.BtnCalcular2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCalcular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular2.ForeColor = System.Drawing.Color.Black
        Me.BtnCalcular2.Location = New System.Drawing.Point(215, 303)
        Me.BtnCalcular2.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCalcular2.Name = "BtnCalcular2"
        Me.BtnCalcular2.Size = New System.Drawing.Size(143, 46)
        Me.BtnCalcular2.TabIndex = 30
        Me.BtnCalcular2.Text = "Calcular"
        Me.BtnCalcular2.UseVisualStyleBackColor = False
        '
        'BtnLimpiar2
        '
        Me.BtnLimpiar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar2.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiar2.Location = New System.Drawing.Point(365, 303)
        Me.BtnLimpiar2.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar2.Name = "BtnLimpiar2"
        Me.BtnLimpiar2.Size = New System.Drawing.Size(148, 46)
        Me.BtnLimpiar2.TabIndex = 31
        Me.BtnLimpiar2.Text = "Limpiar"
        Me.BtnLimpiar2.UseVisualStyleBackColor = False
        '
        'TxtTotal2
        '
        Me.TxtTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal2.Location = New System.Drawing.Point(292, 235)
        Me.TxtTotal2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotal2.Name = "TxtTotal2"
        Me.TxtTotal2.ReadOnly = True
        Me.TxtTotal2.Size = New System.Drawing.Size(220, 36)
        Me.TxtTotal2.TabIndex = 27
        '
        'TxtNeto2
        '
        Me.TxtNeto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNeto2.Location = New System.Drawing.Point(292, 100)
        Me.TxtNeto2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNeto2.Name = "TxtNeto2"
        Me.TxtNeto2.ReadOnly = True
        Me.TxtNeto2.Size = New System.Drawing.Size(220, 35)
        Me.TxtNeto2.TabIndex = 26
        '
        'TxtImpuesto2
        '
        Me.TxtImpuesto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpuesto2.Location = New System.Drawing.Point(292, 167)
        Me.TxtImpuesto2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtImpuesto2.Name = "TxtImpuesto2"
        Me.TxtImpuesto2.ReadOnly = True
        Me.TxtImpuesto2.Size = New System.Drawing.Size(220, 35)
        Me.TxtImpuesto2.TabIndex = 25
        '
        'TxtBase2
        '
        Me.TxtBase2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBase2.Location = New System.Drawing.Point(292, 32)
        Me.TxtBase2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBase2.Name = "TxtBase2"
        Me.TxtBase2.Size = New System.Drawing.Size(220, 35)
        Me.TxtBase2.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(149, 250)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "TOTAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(21, 114)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 25)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Neto antes de ISV"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(164, 182)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 25)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "15 %"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(77, 41)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 25)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Ingrese Base"
        '
        'GbxImpuesto4
        '
        Me.GbxImpuesto4.Controls.Add(Me.BtnLimpiar)
        Me.GbxImpuesto4.Controls.Add(Me.Label5)
        Me.GbxImpuesto4.Controls.Add(Me.TxtImpTur)
        Me.GbxImpuesto4.Controls.Add(Me.Label3)
        Me.GbxImpuesto4.Controls.Add(Me.BtnCalcular)
        Me.GbxImpuesto4.Controls.Add(Me.Label7)
        Me.GbxImpuesto4.Controls.Add(Me.Label4)
        Me.GbxImpuesto4.Controls.Add(Me.Label6)
        Me.GbxImpuesto4.Controls.Add(Me.TxtBase)
        Me.GbxImpuesto4.Controls.Add(Me.TxtImpuesto)
        Me.GbxImpuesto4.Controls.Add(Me.TxtNeto)
        Me.GbxImpuesto4.Controls.Add(Me.TxtTotal)
        Me.GbxImpuesto4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxImpuesto4.ForeColor = System.Drawing.Color.White
        Me.GbxImpuesto4.Location = New System.Drawing.Point(715, 159)
        Me.GbxImpuesto4.Margin = New System.Windows.Forms.Padding(4)
        Me.GbxImpuesto4.Name = "GbxImpuesto4"
        Me.GbxImpuesto4.Padding = New System.Windows.Forms.Padding(4)
        Me.GbxImpuesto4.Size = New System.Drawing.Size(547, 354)
        Me.GbxImpuesto4.TabIndex = 27
        Me.GbxImpuesto4.TabStop = False
        Me.GbxImpuesto4.Text = "Impuesto 4%"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiar.Location = New System.Drawing.Point(365, 288)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(148, 46)
        Me.BtnLimpiar.TabIndex = 31
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(101, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ingrese Base"
        '
        'TxtImpTur
        '
        Me.TxtImpTur.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpTur.Location = New System.Drawing.Point(304, 187)
        Me.TxtImpTur.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtImpTur.Name = "TxtImpTur"
        Me.TxtImpTur.ReadOnly = True
        Me.TxtImpTur.Size = New System.Drawing.Size(208, 33)
        Me.TxtImpTur.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(179, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "15 %"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.ForeColor = System.Drawing.Color.Black
        Me.BtnCalcular.Location = New System.Drawing.Point(209, 288)
        Me.BtnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(148, 46)
        Me.BtnCalcular.TabIndex = 30
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(99, 186)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Turismo 4 %"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(45, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Neto antes de ISV"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(156, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "TOTAL"
        '
        'TxtBase
        '
        Me.TxtBase.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBase.Location = New System.Drawing.Point(304, 34)
        Me.TxtBase.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBase.Name = "TxtBase"
        Me.TxtBase.Size = New System.Drawing.Size(208, 33)
        Me.TxtBase.TabIndex = 14
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpuesto.Location = New System.Drawing.Point(304, 135)
        Me.TxtImpuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(208, 33)
        Me.TxtImpuesto.TabIndex = 15
        '
        'TxtNeto
        '
        Me.TxtNeto.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNeto.Location = New System.Drawing.Point(304, 85)
        Me.TxtNeto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNeto.Name = "TxtNeto"
        Me.TxtNeto.ReadOnly = True
        Me.TxtNeto.Size = New System.Drawing.Size(208, 33)
        Me.TxtNeto.TabIndex = 16
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(304, 238)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(208, 34)
        Me.TxtTotal.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(16, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1515, 71)
        Me.Panel1.TabIndex = 29
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 176)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(665, 714)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(659, -4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOME"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1547, 921)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GbxImpuesto15)
        Me.Controls.Add(Me.GbxImpuesto4)
        Me.Controls.Add(Me.BtnOcultarISV)
        Me.Controls.Add(Me.BtnMostrarISV)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.GbxImpuesto15.ResumeLayout(False)
        Me.GbxImpuesto15.PerformLayout()
        Me.GbxImpuesto4.ResumeLayout(False)
        Me.GbxImpuesto4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnOcultarISV As Button
    Friend WithEvents BtnMostrarISV As Button
    Friend WithEvents GbxImpuesto15 As GroupBox
    Friend WithEvents TxtTotal2 As TextBox
    Friend WithEvents TxtNeto2 As TextBox
    Friend WithEvents TxtImpuesto2 As TextBox
    Friend WithEvents TxtBase2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GbxImpuesto4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtImpTur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBase As TextBox
    Friend WithEvents TxtImpuesto As TextBox
    Friend WithEvents TxtNeto As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCalcular2 As Button
    Friend WithEvents BtnLimpiar2 As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Label1 As Label
End Class
