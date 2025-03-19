<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnOcultarISV = New System.Windows.Forms.Button()
        Me.BtnMostrarISV = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.White
        Me.LblUsuario.Location = New System.Drawing.Point(182, 97)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(0, 43)
        Me.LblUsuario.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 43)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bienvenido(a)"
        '
        'BtnOcultarISV
        '
        Me.BtnOcultarISV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BtnOcultarISV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOcultarISV.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOcultarISV.Location = New System.Drawing.Point(833, 93)
        Me.BtnOcultarISV.Name = "BtnOcultarISV"
        Me.BtnOcultarISV.Size = New System.Drawing.Size(113, 37)
        Me.BtnOcultarISV.TabIndex = 24
        Me.BtnOcultarISV.Text = "Ocultar"
        Me.BtnOcultarISV.UseVisualStyleBackColor = False
        '
        'BtnMostrarISV
        '
        Me.BtnMostrarISV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BtnMostrarISV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrarISV.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrarISV.Location = New System.Drawing.Point(714, 93)
        Me.BtnMostrarISV.Name = "BtnMostrarISV"
        Me.BtnMostrarISV.Size = New System.Drawing.Size(113, 37)
        Me.BtnMostrarISV.TabIndex = 23
        Me.BtnMostrarISV.Text = "Mostrar"
        Me.BtnMostrarISV.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnCalcular2)
        Me.GroupBox2.Controls.Add(Me.BtnLimpiar2)
        Me.GroupBox2.Controls.Add(Me.TxtTotal2)
        Me.GroupBox2.Controls.Add(Me.TxtNeto2)
        Me.GroupBox2.Controls.Add(Me.TxtImpuesto2)
        Me.GroupBox2.Controls.Add(Me.TxtBase2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Dubai", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(536, 427)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 296)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Impuesto 15%"
        '
        'BtnCalcular2
        '
        Me.BtnCalcular2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCalcular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular2.ForeColor = System.Drawing.Color.Black
        Me.BtnCalcular2.Location = New System.Drawing.Point(161, 246)
        Me.BtnCalcular2.Name = "BtnCalcular2"
        Me.BtnCalcular2.Size = New System.Drawing.Size(107, 37)
        Me.BtnCalcular2.TabIndex = 30
        Me.BtnCalcular2.Text = "Calcular"
        Me.BtnCalcular2.UseVisualStyleBackColor = False
        '
        'BtnLimpiar2
        '
        Me.BtnLimpiar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar2.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiar2.Location = New System.Drawing.Point(274, 246)
        Me.BtnLimpiar2.Name = "BtnLimpiar2"
        Me.BtnLimpiar2.Size = New System.Drawing.Size(111, 37)
        Me.BtnLimpiar2.TabIndex = 31
        Me.BtnLimpiar2.Text = "Limpiar"
        Me.BtnLimpiar2.UseVisualStyleBackColor = False
        '
        'TxtTotal2
        '
        Me.TxtTotal2.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal2.Location = New System.Drawing.Point(219, 191)
        Me.TxtTotal2.Name = "TxtTotal2"
        Me.TxtTotal2.ReadOnly = True
        Me.TxtTotal2.Size = New System.Drawing.Size(166, 48)
        Me.TxtTotal2.TabIndex = 27
        '
        'TxtNeto2
        '
        Me.TxtNeto2.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNeto2.Location = New System.Drawing.Point(219, 81)
        Me.TxtNeto2.Name = "TxtNeto2"
        Me.TxtNeto2.ReadOnly = True
        Me.TxtNeto2.Size = New System.Drawing.Size(166, 48)
        Me.TxtNeto2.TabIndex = 26
        '
        'TxtImpuesto2
        '
        Me.TxtImpuesto2.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpuesto2.Location = New System.Drawing.Point(219, 136)
        Me.TxtImpuesto2.Name = "TxtImpuesto2"
        Me.TxtImpuesto2.ReadOnly = True
        Me.TxtImpuesto2.Size = New System.Drawing.Size(166, 48)
        Me.TxtImpuesto2.TabIndex = 25
        '
        'TxtBase2
        '
        Me.TxtBase2.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBase2.Location = New System.Drawing.Point(219, 26)
        Me.TxtBase2.Name = "TxtBase2"
        Me.TxtBase2.Size = New System.Drawing.Size(166, 48)
        Me.TxtBase2.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(112, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 36)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "TOTAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(16, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 36)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Neto antes de ISV"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(123, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 36)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "15 %"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(58, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 36)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Ingrese Base"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtImpTur)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnCalcular)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtBase)
        Me.GroupBox1.Controls.Add(Me.TxtImpuesto)
        Me.GroupBox1.Controls.Add(Me.TxtNeto)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Font = New System.Drawing.Font("Dubai", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(536, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 288)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Impuesto 4%"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiar.Location = New System.Drawing.Point(274, 234)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(111, 37)
        Me.BtnLimpiar.TabIndex = 31
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(76, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 32)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ingrese Base"
        '
        'TxtImpTur
        '
        Me.TxtImpTur.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpTur.Location = New System.Drawing.Point(228, 155)
        Me.TxtImpTur.Name = "TxtImpTur"
        Me.TxtImpTur.ReadOnly = True
        Me.TxtImpTur.Size = New System.Drawing.Size(157, 29)
        Me.TxtImpTur.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(134, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 32)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "15 %"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.ForeColor = System.Drawing.Color.Black
        Me.BtnCalcular.Location = New System.Drawing.Point(157, 234)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(111, 37)
        Me.BtnCalcular.TabIndex = 30
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(74, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 32)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Turismo 4 %"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(34, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 32)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Neto antes de ISV"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(117, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 32)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "TOTAL"
        '
        'TxtBase
        '
        Me.TxtBase.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBase.Location = New System.Drawing.Point(228, 37)
        Me.TxtBase.Name = "TxtBase"
        Me.TxtBase.Size = New System.Drawing.Size(157, 29)
        Me.TxtBase.TabIndex = 14
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpuesto.Location = New System.Drawing.Point(228, 115)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(157, 29)
        Me.TxtImpuesto.TabIndex = 15
        '
        'TxtNeto
        '
        Me.TxtNeto.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNeto.Location = New System.Drawing.Point(228, 76)
        Me.TxtNeto.Name = "TxtNeto"
        Me.TxtNeto.ReadOnly = True
        Me.TxtNeto.Size = New System.Drawing.Size(157, 29)
        Me.TxtNeto.TabIndex = 16
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(228, 194)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(157, 29)
        Me.TxtTotal.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1136, 58)
        Me.Panel1.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(494, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOME"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HotelClementina.My.Resources.Resources.HC_F4
        Me.PictureBox1.Location = New System.Drawing.Point(12, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(499, 580)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1160, 748)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnOcultarISV)
        Me.Controls.Add(Me.BtnMostrarISV)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "Home"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtTotal2 As TextBox
    Friend WithEvents TxtNeto2 As TextBox
    Friend WithEvents TxtImpuesto2 As TextBox
    Friend WithEvents TxtBase2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCalcular2 As Button
    Friend WithEvents BtnLimpiar2 As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnCalcular As Button
End Class
