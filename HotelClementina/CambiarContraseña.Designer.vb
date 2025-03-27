<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarContraseña
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambiarContraseña))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtRenueva = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNueva = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAntigua = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(17, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 53)
        Me.Panel1.TabIndex = 132
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 47)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "CAMBIAR CONTRASEÑA"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(33, 300)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(310, 41)
        Me.BtnGuardar.TabIndex = 141
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(28, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 27)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Re-Ingrese Contraseña"
        '
        'TxtRenueva
        '
        Me.TxtRenueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRenueva.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtRenueva.Location = New System.Drawing.Point(33, 255)
        Me.TxtRenueva.Name = "TxtRenueva"
        Me.TxtRenueva.ShortcutsEnabled = False
        Me.TxtRenueva.Size = New System.Drawing.Size(310, 25)
        Me.TxtRenueva.TabIndex = 139
        Me.TxtRenueva.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 27)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Contraseña Nueva"
        '
        'TxtNueva
        '
        Me.TxtNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNueva.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtNueva.Location = New System.Drawing.Point(33, 183)
        Me.TxtNueva.Name = "TxtNueva"
        Me.TxtNueva.ShortcutsEnabled = False
        Me.TxtNueva.Size = New System.Drawing.Size(310, 25)
        Me.TxtNueva.TabIndex = 137
        Me.TxtNueva.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 27)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Contraseña Antigua"
        '
        'TxtAntigua
        '
        Me.TxtAntigua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAntigua.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtAntigua.Location = New System.Drawing.Point(33, 116)
        Me.TxtAntigua.Name = "TxtAntigua"
        Me.TxtAntigua.ShortcutsEnabled = False
        Me.TxtAntigua.Size = New System.Drawing.Size(310, 25)
        Me.TxtAntigua.TabIndex = 135
        Me.TxtAntigua.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(28, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 27)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "Usuario"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.TxtUsuario.Location = New System.Drawing.Point(33, 51)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.ShortcutsEnabled = False
        Me.TxtUsuario.Size = New System.Drawing.Size(310, 25)
        Me.TxtUsuario.TabIndex = 133
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.TxtRenueva)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtAntigua)
        Me.GroupBox1.Controls.Add(Me.TxtNueva)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 358)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CambiarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(417, 440)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CambiarContraseña"
        Me.Text = "CambiarContraseña"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtRenueva As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNueva As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAntigua As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
