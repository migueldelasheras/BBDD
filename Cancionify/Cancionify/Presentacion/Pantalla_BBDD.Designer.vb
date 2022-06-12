<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantalla_BBDD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla_BBDD))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRuta = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.TbxRuta = New System.Windows.Forms.TextBox()
        Me.OpFile = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(654, 122)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BIENVENIDO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnRuta
        '
        Me.BtnRuta.BackColor = System.Drawing.Color.Green
        Me.BtnRuta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRuta.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRuta.ForeColor = System.Drawing.Color.Black
        Me.BtnRuta.Location = New System.Drawing.Point(0, 122)
        Me.BtnRuta.Name = "BtnRuta"
        Me.BtnRuta.Size = New System.Drawing.Size(146, 165)
        Me.BtnRuta.TabIndex = 1
        Me.BtnRuta.Text = "SELECCIONAR BBDD"
        Me.BtnRuta.UseVisualStyleBackColor = False
        '
        'btnConectar
        '
        Me.btnConectar.BackColor = System.Drawing.Color.Green
        Me.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConectar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnConectar.Enabled = False
        Me.btnConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConectar.ForeColor = System.Drawing.Color.Black
        Me.btnConectar.Location = New System.Drawing.Point(146, 197)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(503, 90)
        Me.btnConectar.TabIndex = 2
        Me.btnConectar.Text = "CONECTAR BBDD"
        Me.btnConectar.UseVisualStyleBackColor = False
        '
        'TbxRuta
        '
        Me.TbxRuta.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.TbxRuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbxRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxRuta.Location = New System.Drawing.Point(146, 122)
        Me.TbxRuta.Multiline = True
        Me.TbxRuta.Name = "TbxRuta"
        Me.TbxRuta.Size = New System.Drawing.Size(503, 75)
        Me.TbxRuta.TabIndex = 3
        '
        'OpFile
        '
        Me.OpFile.FileName = "OpenFileDialog1"
        '
        'Pantalla_BBDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(649, 287)
        Me.Controls.Add(Me.TbxRuta)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.BtnRuta)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pantalla_BBDD"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRuta As Button
    Friend WithEvents btnConectar As Button
    Friend WithEvents TbxRuta As TextBox
    Friend WithEvents OpFile As OpenFileDialog
End Class
