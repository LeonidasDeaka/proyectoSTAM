<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestionRoles
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dGVRol = New System.Windows.Forms.DataGridView()
        Me.tbBuscarRol = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbRolName = New System.Windows.Forms.TextBox()
        Me.tbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbIDRol = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnEliminarRol = New System.Windows.Forms.Button()
        Me.btnEditarRol = New System.Windows.Forms.Button()
        Me.btnAgregarRol = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.IdRolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescRolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VistaRolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDCtrlAsistenciaDataSet = New ProyectoSTAM.BDCtrlAsistenciaDataSet()
        Me.btnNuevoRol = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dGVRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VistaRolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDCtrlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dGVRol)
        Me.GroupBox2.Controls.Add(Me.tbBuscarRol)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(-2, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 233)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Roles Registrados"
        '
        'dGVRol
        '
        Me.dGVRol.AutoGenerateColumns = False
        Me.dGVRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVRol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRolDataGridViewTextBoxColumn, Me.RolNameDataGridViewTextBoxColumn, Me.DescRolDataGridViewTextBoxColumn})
        Me.dGVRol.DataSource = Me.VistaRolBindingSource
        Me.dGVRol.Location = New System.Drawing.Point(12, 61)
        Me.dGVRol.Name = "dGVRol"
        Me.dGVRol.RowHeadersWidth = 102
        Me.dGVRol.Size = New System.Drawing.Size(500, 150)
        Me.dGVRol.TabIndex = 2
        '
        'tbBuscarRol
        '
        Me.tbBuscarRol.Location = New System.Drawing.Point(63, 32)
        Me.tbBuscarRol.Name = "tbBuscarRol"
        Me.tbBuscarRol.Size = New System.Drawing.Size(446, 23)
        Me.tbBuscarRol.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Buscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNuevoRol)
        Me.GroupBox1.Controls.Add(Me.tbRolName)
        Me.GroupBox1.Controls.Add(Me.tbDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tbIDRol)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnEliminarRol)
        Me.GroupBox1.Controls.Add(Me.btnEditarRol)
        Me.GroupBox1.Controls.Add(Me.btnAgregarRol)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 200)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Rol"
        '
        'tbRolName
        '
        Me.tbRolName.Location = New System.Drawing.Point(299, 24)
        Me.tbRolName.Name = "tbRolName"
        Me.tbRolName.Size = New System.Drawing.Size(156, 23)
        Me.tbRolName.TabIndex = 26
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Location = New System.Drawing.Point(105, 77)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(404, 53)
        Me.tbDescripcion.TabIndex = 25
        Me.tbDescripcion.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Descripcion:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(196, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Nombre del Rol:"
        '
        'tbIDRol
        '
        Me.tbIDRol.BackColor = System.Drawing.SystemColors.Control
        Me.tbIDRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbIDRol.Location = New System.Drawing.Point(63, 24)
        Me.tbIDRol.Name = "tbIDRol"
        Me.tbIDRol.Size = New System.Drawing.Size(83, 23)
        Me.tbIDRol.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "ID Rol:"
        '
        'btnEliminarRol
        '
        Me.btnEliminarRol.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRol.Location = New System.Drawing.Point(392, 153)
        Me.btnEliminarRol.Name = "btnEliminarRol"
        Me.btnEliminarRol.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarRol.TabIndex = 17
        Me.btnEliminarRol.Text = "Eliminar"
        Me.btnEliminarRol.UseVisualStyleBackColor = True
        '
        'btnEditarRol
        '
        Me.btnEditarRol.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarRol.Location = New System.Drawing.Point(299, 153)
        Me.btnEditarRol.Name = "btnEditarRol"
        Me.btnEditarRol.Size = New System.Drawing.Size(75, 23)
        Me.btnEditarRol.TabIndex = 16
        Me.btnEditarRol.Text = "Editar"
        Me.btnEditarRol.UseVisualStyleBackColor = True
        '
        'btnAgregarRol
        '
        Me.btnAgregarRol.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRol.Location = New System.Drawing.Point(201, 153)
        Me.btnAgregarRol.Name = "btnAgregarRol"
        Me.btnAgregarRol.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarRol.TabIndex = 15
        Me.btnAgregarRol.Text = "Agregar"
        Me.btnAgregarRol.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(13, 460)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegresar.TabIndex = 8
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'IdRolDataGridViewTextBoxColumn
        '
        Me.IdRolDataGridViewTextBoxColumn.DataPropertyName = "idRol"
        Me.IdRolDataGridViewTextBoxColumn.HeaderText = "idRol"
        Me.IdRolDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.IdRolDataGridViewTextBoxColumn.Name = "IdRolDataGridViewTextBoxColumn"
        Me.IdRolDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdRolDataGridViewTextBoxColumn.Width = 250
        '
        'RolNameDataGridViewTextBoxColumn
        '
        Me.RolNameDataGridViewTextBoxColumn.DataPropertyName = "rolName"
        Me.RolNameDataGridViewTextBoxColumn.HeaderText = "Nombre del rol"
        Me.RolNameDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.RolNameDataGridViewTextBoxColumn.Name = "RolNameDataGridViewTextBoxColumn"
        Me.RolNameDataGridViewTextBoxColumn.Width = 250
        '
        'DescRolDataGridViewTextBoxColumn
        '
        Me.DescRolDataGridViewTextBoxColumn.DataPropertyName = "descRol"
        Me.DescRolDataGridViewTextBoxColumn.HeaderText = "Descripcion del rol"
        Me.DescRolDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.DescRolDataGridViewTextBoxColumn.Name = "DescRolDataGridViewTextBoxColumn"
        Me.DescRolDataGridViewTextBoxColumn.Width = 250
        '
        'VistaRolBindingSource
        '
        Me.VistaRolBindingSource.DataMember = "VistaRol"
        Me.VistaRolBindingSource.DataSource = Me.BDCtrlAsistenciaDataSet
        '
        'BDCtrlAsistenciaDataSet
        '
        Me.BDCtrlAsistenciaDataSet.DataSetName = "BDCtrlAsistenciaDataSet"
        Me.BDCtrlAsistenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnNuevoRol
        '
        Me.btnNuevoRol.Location = New System.Drawing.Point(105, 153)
        Me.btnNuevoRol.Name = "btnNuevoRol"
        Me.btnNuevoRol.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevoRol.TabIndex = 27
        Me.btnNuevoRol.Text = "Nuevo"
        Me.btnNuevoRol.UseVisualStyleBackColor = True
        '
        'frmGestionRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 457)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGestionRoles"
        Me.Text = "Gestion de Roles"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dGVRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VistaRolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDCtrlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dGVRol As DataGridView
    Friend WithEvents tbBuscarRol As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbIDRol As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEliminarRol As Button
    Friend WithEvents btnEditarRol As Button
    Friend WithEvents btnAgregarRol As Button
    Friend WithEvents tbDescripcion As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbRolName As TextBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents IdRolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescRolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VistaRolBindingSource As BindingSource
    Friend WithEvents BDCtrlAsistenciaDataSet As BDCtrlAsistenciaDataSet
    Friend WithEvents btnNuevoRol As Button
End Class
