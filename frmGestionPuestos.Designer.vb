<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestPuestos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxPuesto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BDCtrlAsistenciaDataSet = New ProyectoSTAM.BDCtrlAsistenciaDataSet()
        Me.VistaPuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaPuestoTableAdapter = New ProyectoSTAM.BDCtrlAsistenciaDataSetTableAdapters.VistaPuestoTableAdapter()
        Me.NombreDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarioPuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VistaRolTableAdapter = New ProyectoSTAM.BDCtrlAsistenciaDataSetTableAdapters.VistaRolTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDCtrlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaPuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(552, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTION DE PUESTOS"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(749, 382)
        Me.Button1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 57)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Agregar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1181, 382)
        Me.Button2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 57)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Eliminar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(32, 1061)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(205, 60)
        Me.BtnRegresar.TabIndex = 4
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtBoxPuesto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 477)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Size = New System.Drawing.Size(1395, 570)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Registrados"
        '
        'TxtBoxPuesto
        '
        Me.TxtBoxPuesto.Location = New System.Drawing.Point(168, 72)
        Me.TxtBoxPuesto.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TxtBoxPuesto.Name = "TxtBoxPuesto"
        Me.TxtBoxPuesto.Size = New System.Drawing.Size(1167, 46)
        Me.TxtBoxPuesto.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Buscar:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDepartamentoDataGridViewTextBoxColumn, Me.IdPuestoDataGridViewTextBoxColumn, Me.NombrePuestoDataGridViewTextBoxColumn, Me.DescripcionPuestoDataGridViewTextBoxColumn, Me.SalarioPuestoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VistaPuestoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(45, 172)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 102
        Me.DataGridView1.Size = New System.Drawing.Size(1296, 358)
        Me.DataGridView1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(965, 384)
        Me.Button3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 55)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Editar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(101, 148)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 38)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID de Puesto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 222)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 38)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombre de Puesto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 289)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 38)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Departamento:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Location = New System.Drawing.Point(344, 148)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 38)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(344, 217)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(468, 38)
        Me.TextBox2.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(344, 284)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(596, 39)
        Me.ComboBox1.TabIndex = 12
        '
        'BDCtrlAsistenciaDataSet
        '
        Me.BDCtrlAsistenciaDataSet.DataSetName = "BDCtrlAsistenciaDataSet"
        Me.BDCtrlAsistenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaPuestoBindingSource
        '
        Me.VistaPuestoBindingSource.DataMember = "VistaPuesto"
        Me.VistaPuestoBindingSource.DataSource = Me.BDCtrlAsistenciaDataSet
        '
        'VistaPuestoTableAdapter
        '
        Me.VistaPuestoTableAdapter.ClearBeforeFill = True
        '
        'NombreDepartamentoDataGridViewTextBoxColumn
        '
        Me.NombreDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "nombreDepartamento"
        Me.NombreDepartamentoDataGridViewTextBoxColumn.HeaderText = "Nombre del departamento"
        Me.NombreDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.NombreDepartamentoDataGridViewTextBoxColumn.Name = "NombreDepartamentoDataGridViewTextBoxColumn"
        Me.NombreDepartamentoDataGridViewTextBoxColumn.Width = 250
        '
        'IdPuestoDataGridViewTextBoxColumn
        '
        Me.IdPuestoDataGridViewTextBoxColumn.DataPropertyName = "idPuesto"
        Me.IdPuestoDataGridViewTextBoxColumn.HeaderText = "idPuesto"
        Me.IdPuestoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.IdPuestoDataGridViewTextBoxColumn.Name = "IdPuestoDataGridViewTextBoxColumn"
        Me.IdPuestoDataGridViewTextBoxColumn.Width = 250
        '
        'NombrePuestoDataGridViewTextBoxColumn
        '
        Me.NombrePuestoDataGridViewTextBoxColumn.DataPropertyName = "nombrePuesto"
        Me.NombrePuestoDataGridViewTextBoxColumn.HeaderText = "Nombre del puesto"
        Me.NombrePuestoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.NombrePuestoDataGridViewTextBoxColumn.Name = "NombrePuestoDataGridViewTextBoxColumn"
        Me.NombrePuestoDataGridViewTextBoxColumn.Width = 250
        '
        'DescripcionPuestoDataGridViewTextBoxColumn
        '
        Me.DescripcionPuestoDataGridViewTextBoxColumn.DataPropertyName = "descripcionPuesto"
        Me.DescripcionPuestoDataGridViewTextBoxColumn.HeaderText = "Descripcion del puesto"
        Me.DescripcionPuestoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.DescripcionPuestoDataGridViewTextBoxColumn.Name = "DescripcionPuestoDataGridViewTextBoxColumn"
        Me.DescripcionPuestoDataGridViewTextBoxColumn.Width = 250
        '
        'SalarioPuestoDataGridViewTextBoxColumn
        '
        Me.SalarioPuestoDataGridViewTextBoxColumn.DataPropertyName = "salarioPuesto"
        Me.SalarioPuestoDataGridViewTextBoxColumn.HeaderText = "Salario del puesto"
        Me.SalarioPuestoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.SalarioPuestoDataGridViewTextBoxColumn.Name = "SalarioPuestoDataGridViewTextBoxColumn"
        Me.SalarioPuestoDataGridViewTextBoxColumn.Width = 250
        '
        'VistaRolTableAdapter
        '
        Me.VistaRolTableAdapter.ClearBeforeFill = True
        '
        'frmGestPuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1504, 1142)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "frmGestPuestos"
        Me.Text = "CONTROL DE ASISTENCIA DE EMPLEADOS || ADMINISTRADORES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDCtrlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaPuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtBoxPuesto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BDCtrlAsistenciaDataSet As BDCtrlAsistenciaDataSet
    Friend WithEvents VistaPuestoBindingSource As BindingSource
    Friend WithEvents VistaPuestoTableAdapter As BDCtrlAsistenciaDataSetTableAdapters.VistaPuestoTableAdapter
    Friend WithEvents NombreDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombrePuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalarioPuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VistaRolTableAdapter As BDCtrlAsistenciaDataSetTableAdapters.VistaRolTableAdapter
End Class
