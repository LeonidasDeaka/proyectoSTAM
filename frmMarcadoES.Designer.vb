<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarcadoES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarcadoES))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbHoras = New System.Windows.Forms.Label()
        Me.lbMin = New System.Windows.Forms.Label()
        Me.lbSeg = New System.Windows.Forms.Label()
        Me.lbFormato = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(82, 136)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Entrada"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbHoras
        '
        Me.lbHoras.AutoSize = True
        Me.lbHoras.Font = New System.Drawing.Font("Cambria", 14.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoras.ForeColor = System.Drawing.Color.Blue
        Me.lbHoras.Location = New System.Drawing.Point(271, 30)
        Me.lbHoras.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbHoras.Name = "lbHoras"
        Me.lbHoras.Size = New System.Drawing.Size(41, 22)
        Me.lbHoras.TabIndex = 2
        Me.lbHoras.Text = "00 :"
        '
        'lbMin
        '
        Me.lbMin.AutoSize = True
        Me.lbMin.Font = New System.Drawing.Font("Cambria", 14.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMin.ForeColor = System.Drawing.Color.Blue
        Me.lbMin.Location = New System.Drawing.Point(304, 30)
        Me.lbMin.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbMin.Name = "lbMin"
        Me.lbMin.Size = New System.Drawing.Size(32, 22)
        Me.lbMin.TabIndex = 3
        Me.lbMin.Text = "00"
        '
        'lbSeg
        '
        Me.lbSeg.AutoSize = True
        Me.lbSeg.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSeg.ForeColor = System.Drawing.Color.Blue
        Me.lbSeg.Location = New System.Drawing.Point(338, 36)
        Me.lbSeg.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbSeg.Name = "lbSeg"
        Me.lbSeg.Size = New System.Drawing.Size(24, 16)
        Me.lbSeg.TabIndex = 4
        Me.lbSeg.Text = "00"
        '
        'lbFormato
        '
        Me.lbFormato.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFormato.ForeColor = System.Drawing.Color.Blue
        Me.lbFormato.Location = New System.Drawing.Point(338, 18)
        Me.lbFormato.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbFormato.Name = "lbFormato"
        Me.lbFormato.Size = New System.Drawing.Size(38, 13)
        Me.lbFormato.TabIndex = 0
        Me.lbFormato.Text = "AM"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MARCADO DE ENTRADA Y SALIDA"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(117, 104)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(200, 136)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 31)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Salida"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(23, 209)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegresar.TabIndex = 8
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'frmMarcadoES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 253)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbFormato)
        Me.Controls.Add(Me.lbSeg)
        Me.Controls.Add(Me.lbMin)
        Me.Controls.Add(Me.lbHoras)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "frmMarcadoES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE ASISTENCIA DE EMPLEADOS || EMPLEADOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents lbHoras As Label
    Friend WithEvents lbMin As Label
    Friend WithEvents lbSeg As Label
    Friend WithEvents lbFormato As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnRegresar As Button
End Class
