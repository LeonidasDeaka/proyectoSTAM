<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestUsuario))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.txbClaveUsuario = New System.Windows.Forms.TextBox()
        Me.txbClave2Usuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxRol = New System.Windows.Forms.ComboBox()
        Me.txbEmail2Usuario = New System.Windows.Forms.TextBox()
        Me.txbEmailUsuario = New System.Windows.Forms.TextBox()
        Me.txbApellidosUsuario = New System.Windows.Forms.TextBox()
        Me.txbNombresUsuario = New System.Windows.Forms.TextBox()
        Me.txbIdUsuario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.BDCtrlAsistenciaDataSet = New ProyectoSTAM.BDCtrlAsistenciaDataSet()
        Me.VistaUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaUsuarioTableAdapter = New ProyectoSTAM.BDCtrlAsistenciaDataSetTableAdapters.VistaUsuarioTableAdapter()
        Me.IdUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RolTableAdapter = New ProyectoSTAM.BDCtrlAsistenciaDataSetTableAdapters.rolTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BDCtrlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1320, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1272, 148)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtBoxUser)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 563)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Size = New System.Drawing.Size(2013, 532)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios Registrados"
        '
        'TxtBoxUser
        '
        Me.TxtBoxUser.Location = New System.Drawing.Point(192, 64)
        Me.TxtBoxUser.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TxtBoxUser.Name = "TxtBoxUser"
        Me.TxtBoxUser.Size = New System.Drawing.Size(1753, 46)
        Me.TxtBoxUser.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 72)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 38)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Buscar:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuarioDataGridViewTextBoxColumn, Me.RolNameDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VistaUsuarioBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(56, 145)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 102
        Me.DataGridView1.Size = New System.Drawing.Size(1896, 334)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(32, 1109)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(200, 55)
        Me.BtnRegresar.TabIndex = 4
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'txbClaveUsuario
        '
        Me.txbClaveUsuario.Location = New System.Drawing.Point(1477, 141)
        Me.txbClaveUsuario.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txbClaveUsuario.Name = "txbClaveUsuario"
        Me.txbClaveUsuario.Size = New System.Drawing.Size(449, 46)
        Me.txbClaveUsuario.TabIndex = 5
        '
        'txbClave2Usuario
        '
        Me.txbClave2Usuario.Location = New System.Drawing.Point(1477, 210)
        Me.txbClave2Usuario.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txbClave2Usuario.Name = "txbClave2Usuario"
        Me.txbClave2Usuario.Size = New System.Drawing.Size(449, 46)
        Me.txbClave2Usuario.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1128, 217)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(324, 38)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confrmar contraseña:"
        '
        'txbUsuario
        '
        Me.txbUsuario.Location = New System.Drawing.Point(1477, 72)
        Me.txbUsuario.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(449, 46)
        Me.txbUsuario.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Controls.Add(Me.cbxRol)
        Me.GroupBox2.Controls.Add(Me.txbEmail2Usuario)
        Me.GroupBox2.Controls.Add(Me.txbEmailUsuario)
        Me.GroupBox2.Controls.Add(Me.txbApellidosUsuario)
        Me.GroupBox2.Controls.Add(Me.txbNombresUsuario)
        Me.GroupBox2.Controls.Add(Me.txbIdUsuario)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txbUsuario)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txbClaveUsuario)
        Me.GroupBox2.Controls.Add(Me.txbClave2Usuario)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(32, 29)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox2.Size = New System.Drawing.Size(2013, 498)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Usuario"
        '
        'cbxRol
        '
        Me.cbxRol.DataSource = Me.RolBindingSource
        Me.cbxRol.DisplayMember = "rolName"
        Me.cbxRol.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRol.FormattingEnabled = True
        Me.cbxRol.Location = New System.Drawing.Point(1477, 291)
        Me.cbxRol.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cbxRol.Name = "cbxRol"
        Me.cbxRol.Size = New System.Drawing.Size(449, 40)
        Me.cbxRol.TabIndex = 23
        Me.cbxRol.ValueMember = "idRol"
        '
        'txbEmail2Usuario
        '
        Me.txbEmail2Usuario.Location = New System.Drawing.Point(333, 358)
        Me.txbEmail2Usuario.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txbEmail2Usuario.Name = "txbEmail2Usuario"
        Me.txbEmail2Usuario.Size = New System.Drawing.Size(671, 46)
        Me.txbEmail2Usuario.TabIndex = 22
        '
        'txbEmailUsuario
        '
        Me.txbEmailUsuario.Location = New System.Drawing.Point(333, 289)
        Me.txbEmailUsuario.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txbEmailUsuario.Name = "txbEmailUsuario"
        Me.txbEmailUsuario.Size = New System.Drawing.Size(671, 46)
        Me.txbEmailUsuario.TabIndex = 21
        '
        'txbApellidosUsuario
        '
        Me.txbApellidosUsuario.Location = New System.Drawing.Point(333, 217)
        Me.txbApellidosUsuario.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txbApellidosUsuario.Name = "txbApellidosUsuario"
        Me.txbApellidosUsuario.Size = New System.Drawing.Size(671, 46)
        Me.txbApellidosUsuario.TabIndex = 20
        '
        'txbNombresUsuario
        '
        Me.txbNombresUsuario.Location = New System.Drawing.Point(333, 148)
        Me.txbNombresUsuario.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txbNombresUsuario.Name = "txbNombresUsuario"
        Me.txbNombresUsuario.Size = New System.Drawing.Size(671, 46)
        Me.txbNombresUsuario.TabIndex = 19
        '
        'txbIdUsuario
        '
        Me.txbIdUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txbIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbIdUsuario.Location = New System.Drawing.Point(333, 72)
        Me.txbIdUsuario.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txbIdUsuario.Name = "txbIdUsuario"
        Me.txbIdUsuario.Size = New System.Drawing.Size(263, 46)
        Me.txbIdUsuario.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(56, 365)
        Me.Label10.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(255, 38)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Confirmar email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(203, 296)
        Me.Label9.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 38)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(155, 224)
        Me.Label8.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 38)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Apellidos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(155, 155)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 38)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nombres:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(248, 72)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 38)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1384, 289)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 38)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Rol:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(1752, 393)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(200, 55)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(1536, 393)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(200, 55)
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(1320, 393)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(200, 55)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(1104, 393)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(200, 55)
        Me.btnNuevo.TabIndex = 24
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'BDCtrlAsistenciaDataSet
        '
        Me.BDCtrlAsistenciaDataSet.DataSetName = "BDCtrlAsistenciaDataSet"
        Me.BDCtrlAsistenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaUsuarioBindingSource
        '
        Me.VistaUsuarioBindingSource.DataMember = "VistaUsuario"
        Me.VistaUsuarioBindingSource.DataSource = Me.BDCtrlAsistenciaDataSet
        '
        'VistaUsuarioTableAdapter
        '
        Me.VistaUsuarioTableAdapter.ClearBeforeFill = True
        '
        'IdUsuarioDataGridViewTextBoxColumn
        '
        Me.IdUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.IdUsuarioDataGridViewTextBoxColumn.Name = "IdUsuarioDataGridViewTextBoxColumn"
        Me.IdUsuarioDataGridViewTextBoxColumn.Width = 250
        '
        'RolNameDataGridViewTextBoxColumn
        '
        Me.RolNameDataGridViewTextBoxColumn.DataPropertyName = "rolName"
        Me.RolNameDataGridViewTextBoxColumn.HeaderText = "Nombre del rol"
        Me.RolNameDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.RolNameDataGridViewTextBoxColumn.Name = "RolNameDataGridViewTextBoxColumn"
        Me.RolNameDataGridViewTextBoxColumn.Width = 250
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.Width = 250
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.Width = 250
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.Width = 250
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 250
        '
        'RolBindingSource
        '
        Me.RolBindingSource.DataMember = "rol"
        Me.RolBindingSource.DataSource = Me.BDCtrlAsistenciaDataSet
        '
        'RolTableAdapter
        '
        Me.RolTableAdapter.ClearBeforeFill = True
        '
        'frmGestUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2128, 1183)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "frmGestUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE ASISTENCIA DE EMPLEADOS || ADMINISTRADORES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BDCtrlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents txbClaveUsuario As TextBox
    Friend WithEvents txbClave2Usuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents TxtBoxUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cbxRol As ComboBox
    Friend WithEvents txbEmail2Usuario As TextBox
    Friend WithEvents txbEmailUsuario As TextBox
    Friend WithEvents txbApellidosUsuario As TextBox
    Friend WithEvents txbNombresUsuario As TextBox
    Friend WithEvents txbIdUsuario As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents BDCtrlAsistenciaDataSet As BDCtrlAsistenciaDataSet
    Friend WithEvents VistaUsuarioBindingSource As BindingSource
    Friend WithEvents VistaUsuarioTableAdapter As BDCtrlAsistenciaDataSetTableAdapters.VistaUsuarioTableAdapter
    Friend WithEvents IdUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolBindingSource As BindingSource
    Friend WithEvents RolTableAdapter As BDCtrlAsistenciaDataSetTableAdapters.rolTableAdapter
End Class
