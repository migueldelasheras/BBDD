<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicSesion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNacimiento = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.LstUsuarios = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnIniciar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnAñadir)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNacimiento)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.LstUsuarios)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 320)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USUARIOS"
        '
        'btnIniciar
        '
        Me.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnIniciar.Enabled = False
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(220, 285)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(462, 32)
        Me.btnIniciar.TabIndex = 13
        Me.btnIniciar.Text = "INICIAR SESIÓN"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(574, 220)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(85, 32)
        Me.btnModificar.TabIndex = 12
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(467, 220)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(85, 32)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAñadir
        '
        Me.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAñadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadir.Location = New System.Drawing.Point(359, 220)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(85, 32)
        Me.btnAñadir.TabIndex = 10
        Me.btnAñadir.Text = "AÑADIR"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(253, 220)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(85, 32)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(272, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "NACIMIENTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(289, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "APELLIDO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(296, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(316, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "EMAIL"
        '
        'txtNacimiento
        '
        Me.txtNacimiento.Location = New System.Drawing.Point(386, 166)
        Me.txtNacimiento.Multiline = True
        Me.txtNacimiento.Name = "txtNacimiento"
        Me.txtNacimiento.Size = New System.Drawing.Size(273, 27)
        Me.txtNacimiento.TabIndex = 4
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(386, 117)
        Me.txtApellido.Multiline = True
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(273, 27)
        Me.txtApellido.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(386, 68)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(273, 27)
        Me.txtNombre.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(386, 19)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(273, 27)
        Me.txtEmail.TabIndex = 1
        '
        'LstUsuarios
        '
        Me.LstUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LstUsuarios.Dock = System.Windows.Forms.DockStyle.Left
        Me.LstUsuarios.FormattingEnabled = True
        Me.LstUsuarios.Location = New System.Drawing.Point(3, 16)
        Me.LstUsuarios.Name = "LstUsuarios"
        Me.LstUsuarios.ScrollAlwaysVisible = True
        Me.LstUsuarios.Size = New System.Drawing.Size(217, 301)
        Me.LstUsuarios.TabIndex = 0
        '
        'InicSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(708, 342)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InicSesion"
        Me.Text = "InicSesion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNacimiento As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents LstUsuarios As ListBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label4 As Label
End Class
