<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantalla_Carga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla_Carga))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(753, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CARGANDO CANCIONIFY..."
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(0, 172)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(810, 26)
        Me.ProgressBar.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentaje.Location = New System.Drawing.Point(381, 144)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(0, 25)
        Me.lblPorcentaje.TabIndex = 2
        '
        'Pantalla_Carga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(809, 198)
        Me.Controls.Add(Me.lblPorcentaje)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pantalla_Carga"
        Me.Text = "Pantalla_Carga"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblPorcentaje As Label
End Class
