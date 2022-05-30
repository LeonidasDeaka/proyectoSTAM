<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestionDepartamentos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionDepartamentos))
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEliminarDep = New System.Windows.Forms.Button()
        Me.BtnAgregarDep = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TxtboxDep = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BDCtrlAsistenciaDataSet = New ProyectoSTAM.BDCtrlAsistenciaDataSet()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentoTableAdapter = New ProyectoSTAM.BDCtrlAsistenciaDataSetTableAdapters.departamentoTableAdapter()
        Me.IdEmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDCtrlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Bold)
        Me.BtnRegresar.Location = New System.Drawing.Point(32, 980)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(200, 74)
        Me.BtnRegresar.TabIndex = 4
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(403, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion de Departamentos"
        '
        'BtnEliminarDep
        '
        Me.BtnEliminarDep.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarDep.Location = New System.Drawing.Point(1048, 315)
        Me.BtnEliminarDep.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnEliminarDep.Name = "BtnEliminarDep"
        Me.BtnEliminarDep.Size = New System.Drawing.Size(200, 69)
        Me.BtnEliminarDep.TabIndex = 2
        Me.BtnEliminarDep.Text = "Eliminar"
        Me.BtnEliminarDep.UseVisualStyleBackColor = True
        '
        'BtnAgregarDep
        '
        Me.BtnAgregarDep.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarDep.Location = New System.Drawing.Point(616, 315)
        Me.BtnAgregarDep.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnAgregarDep.Name = "BtnAgregarDep"
        Me.BtnAgregarDep.Size = New System.Drawing.Size(200, 69)
        Me.BtnAgregarDep.TabIndex = 3
        Me.BtnAgregarDep.Text = "Agregar"
        Me.BtnAgregarDep.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.TxtboxDep)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 444)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Size = New System.Drawing.Size(1216, 522)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Departamentos Registrados"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpresaDataGridViewTextBoxColumn, Me.IdDepartamentoDataGridViewTextBoxColumn, Me.NombreDepartamentoDataGridViewTextBoxColumn, Me.DescripcionDepartamentoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DepartamentoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(24, 136)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 102
        Me.DataGridView1.Size = New System.Drawing.Size(1144, 358)
        Me.DataGridView1.TabIndex = 2
        '
        'TxtboxDep
        '
        Me.TxtboxDep.Location = New System.Drawing.Point(160, 52)
        Me.TxtboxDep.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TxtboxDep.Name = "TxtboxDep"
        Me.TxtboxDep.Size = New System.Drawing.Size(1001, 46)
        Me.TxtboxDep.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 38)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 217)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(401, 38)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre del Departamento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(319, 38)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ID del Departamento:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(832, 315)
        Me.Button1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 69)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(480, 134)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 38)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(480, 217)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(601, 38)
        Me.TextBox2.TabIndex = 11
        '
        'BDCtrlAsistenciaDataSet
        '
        Me.BDCtrlAsistenciaDataSet.DataSetName = "BDCtrlAsistenciaDataSet"
        Me.BDCtrlAsistenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "departamento"
        Me.DepartamentoBindingSource.DataSource = Me.BDCtrlAsistenciaDataSet
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'IdEmpresaDataGridViewTextBoxColumn
        '
        Me.IdEmpresaDataGridViewTextBoxColumn.DataPropertyName = "idEmpresa"
        Me.IdEmpresaDataGridViewTextBoxColumn.HeaderText = "idEmpresa"
        Me.IdEmpresaDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.IdEmpresaDataGridViewTextBoxColumn.Name = "IdEmpresaDataGridViewTextBoxColumn"
        Me.IdEmpresaDataGridViewTextBoxColumn.Width = 250
        '
        'IdDepartamentoDataGridViewTextBoxColumn
        '
        Me.IdDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "idDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.HeaderText = "idDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.IdDepartamentoDataGridViewTextBoxColumn.Name = "IdDepartamentoDataGridViewTextBoxColumn"
        Me.IdDepartamentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDepartamentoDataGridViewTextBoxColumn.Width = 250
        '
        'NombreDepartamentoDataGridViewTextBoxColumn
        '
        Me.NombreDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "nombreDepartamento"
        Me.NombreDepartamentoDataGridViewTextBoxColumn.HeaderText = "Nombre del departamento"
        Me.NombreDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.NombreDepartamentoDataGridViewTextBoxColumn.Name = "NombreDepartamentoDataGridViewTextBoxColumn"
        Me.NombreDepartamentoDataGridViewTextBoxColumn.Width = 250
        '
        'DescripcionDepartamentoDataGridViewTextBoxColumn
        '
        Me.DescripcionDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "descripcionDepartamento"
        Me.DescripcionDepartamentoDataGridViewTextBoxColumn.HeaderText = "Descripcion del departamento"
        Me.DescripcionDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.DescripcionDepartamentoDataGridViewTextBoxColumn.Name = "DescripcionDepartamentoDataGridViewTextBoxColumn"
        Me.DescripcionDepartamentoDataGridViewTextBoxColumn.Width = 250
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
        Me.EstadoDataGridViewTextBoxColumn.Width = 250
        '
        'frmGestionDepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 1083)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnAgregarDep)
        Me.Controls.Add(Me.BtnEliminarDep)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "frmGestionDepartamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE ASISTENCIA DE EMPLEADOS || ADMINISTRADORES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDCtrlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BtnEliminarDep As Button
    Friend WithEvents BtnAgregarDep As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtboxDep As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BDCtrlAsistenciaDataSet As BDCtrlAsistenciaDataSet
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As BDCtrlAsistenciaDataSetTableAdapters.departamentoTableAdapter
    Friend WithEvents IdEmpresaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
