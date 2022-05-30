<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionEmpleado))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxPuesto = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txbClave2Emp = New System.Windows.Forms.TextBox()
        Me.txbClaveEmp = New System.Windows.Forms.TextBox()
        Me.txbUsuarioEmp = New System.Windows.Forms.TextBox()
        Me.txbEmail2Emp = New System.Windows.Forms.TextBox()
        Me.txbEmailEmp = New System.Windows.Forms.TextBox()
        Me.txbNombresEmp = New System.Windows.Forms.TextBox()
        Me.txbApellidosEmp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VistaEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDCtrlAsistenciaDataSet = New ProyectoSTAM.BDCtrlAsistenciaDataSet()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New ProyectoSTAM.BDCtrlAsistenciaDataSetTableAdapters.empleadoTableAdapter()
        Me.VistaEmpleadoTableAdapter = New ProyectoSTAM.BDCtrlAsistenciaDataSetTableAdapters.VistaEmpleadoTableAdapter()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txbIdEmp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txbFechaIngreso = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentoTableAdapter = New ProyectoSTAM.BDCtrlAsistenciaDataSetTableAdapters.departamentoTableAdapter()
        Me.PuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuestoTableAdapter = New ProyectoSTAM.BDCtrlAsistenciaDataSetTableAdapters.puestoTableAdapter()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txbFechaNac = New System.Windows.Forms.TextBox()
        Me.txbCedula = New System.Windows.Forms.TextBox()
        Me.txbSeguroSocial = New System.Windows.Forms.TextBox()
        Me.txbTelefono = New System.Windows.Forms.TextBox()
        Me.IdEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumSeguroSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rtxbDireccion = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDCtrlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txbFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txbIdEmp)
        Me.GroupBox1.Controls.Add(Me.cbxPuesto)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbxDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txbClave2Emp)
        Me.GroupBox1.Controls.Add(Me.txbClaveEmp)
        Me.GroupBox1.Controls.Add(Me.txbUsuarioEmp)
        Me.GroupBox1.Controls.Add(Me.txbEmail2Emp)
        Me.GroupBox1.Controls.Add(Me.txbEmailEmp)
        Me.GroupBox1.Controls.Add(Me.txbNombresEmp)
        Me.GroupBox1.Controls.Add(Me.txbApellidosEmp)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1583, 669)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos basicos del empleado"
        '
        'cbxPuesto
        '
        Me.cbxPuesto.DataSource = Me.PuestoBindingSource
        Me.cbxPuesto.DisplayMember = "nombrePuesto"
        Me.cbxPuesto.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPuesto.FormattingEnabled = True
        Me.cbxPuesto.Location = New System.Drawing.Point(1105, 122)
        Me.cbxPuesto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxPuesto.Name = "cbxPuesto"
        Me.cbxPuesto.Size = New System.Drawing.Size(454, 46)
        Me.cbxPuesto.TabIndex = 22
        Me.cbxPuesto.ValueMember = "idPuesto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(977, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 38)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Puesto:"
        '
        'cbxDepartamento
        '
        Me.cbxDepartamento.DataSource = Me.DepartamentoBindingSource
        Me.cbxDepartamento.DisplayMember = "nombreDepartamento"
        Me.cbxDepartamento.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDepartamento.FormattingEnabled = True
        Me.cbxDepartamento.Location = New System.Drawing.Point(1105, 52)
        Me.cbxDepartamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxDepartamento.Name = "cbxDepartamento"
        Me.cbxDepartamento.Size = New System.Drawing.Size(454, 46)
        Me.cbxDepartamento.TabIndex = 20
        Me.cbxDepartamento.ValueMember = "idDepartamento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(870, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(229, 38)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Departamento:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(719, 431)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(200, 55)
        Me.btnEliminar.TabIndex = 18
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(503, 431)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(200, 55)
        Me.btnEditar.TabIndex = 17
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(287, 431)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(200, 55)
        Me.btnAgregar.TabIndex = 16
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txbClave2Emp
        '
        Me.txbClave2Emp.Location = New System.Drawing.Point(350, 521)
        Me.txbClave2Emp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbClave2Emp.Name = "txbClave2Emp"
        Me.txbClave2Emp.Size = New System.Drawing.Size(484, 43)
        Me.txbClave2Emp.TabIndex = 14
        '
        'txbClaveEmp
        '
        Me.txbClaveEmp.Location = New System.Drawing.Point(350, 463)
        Me.txbClaveEmp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbClaveEmp.Name = "txbClaveEmp"
        Me.txbClaveEmp.Size = New System.Drawing.Size(484, 43)
        Me.txbClaveEmp.TabIndex = 13
        '
        'txbUsuarioEmp
        '
        Me.txbUsuarioEmp.Location = New System.Drawing.Point(350, 388)
        Me.txbUsuarioEmp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbUsuarioEmp.Name = "txbUsuarioEmp"
        Me.txbUsuarioEmp.Size = New System.Drawing.Size(484, 43)
        Me.txbUsuarioEmp.TabIndex = 12
        '
        'txbEmail2Emp
        '
        Me.txbEmail2Emp.Location = New System.Drawing.Point(350, 315)
        Me.txbEmail2Emp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbEmail2Emp.Name = "txbEmail2Emp"
        Me.txbEmail2Emp.Size = New System.Drawing.Size(484, 43)
        Me.txbEmail2Emp.TabIndex = 10
        '
        'txbEmailEmp
        '
        Me.txbEmailEmp.Location = New System.Drawing.Point(350, 245)
        Me.txbEmailEmp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbEmailEmp.Name = "txbEmailEmp"
        Me.txbEmailEmp.Size = New System.Drawing.Size(484, 43)
        Me.txbEmailEmp.TabIndex = 9
        '
        'txbNombresEmp
        '
        Me.txbNombresEmp.Location = New System.Drawing.Point(350, 114)
        Me.txbNombresEmp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbNombresEmp.Name = "txbNombresEmp"
        Me.txbNombresEmp.Size = New System.Drawing.Size(484, 43)
        Me.txbNombresEmp.TabIndex = 8
        '
        'txbApellidosEmp
        '
        Me.txbApellidosEmp.Location = New System.Drawing.Point(350, 180)
        Me.txbApellidosEmp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbApellidosEmp.Name = "txbApellidosEmp"
        Me.txbApellidosEmp.Size = New System.Drawing.Size(484, 43)
        Me.txbApellidosEmp.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 521)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(333, 38)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Confirmar contraseña:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(145, 453)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 38)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Contraseña:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(182, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 38)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Usuario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 38)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Confirmar email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(213, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 38)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 38)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Apellidos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 38)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombres:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 694)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(2559, 534)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empleados registrados"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(189, 67)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1209, 43)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleadoDataGridViewTextBoxColumn, Me.IdDepartamentoDataGridViewTextBoxColumn, Me.NombreDepartamentoDataGridViewTextBoxColumn, Me.NombrePuestoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.NumSeguroSocialDataGridViewTextBoxColumn, Me.FechaIngresoDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VistaEmpleadoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(21, 129)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 102
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(2354, 353)
        Me.DataGridView1.TabIndex = 0
        '
        'VistaEmpleadoBindingSource
        '
        Me.VistaEmpleadoBindingSource.DataMember = "VistaEmpleado"
        Me.VistaEmpleadoBindingSource.DataSource = Me.BDCtrlAsistenciaDataSet
        '
        'BDCtrlAsistenciaDataSet
        '
        Me.BDCtrlAsistenciaDataSet.DataSetName = "BDCtrlAsistenciaDataSet"
        Me.BDCtrlAsistenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(31, 1253)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(299, 60)
        Me.BtnRegresar.TabIndex = 2
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.BDCtrlAsistenciaDataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'VistaEmpleadoTableAdapter
        '
        Me.VistaEmpleadoTableAdapter.ClearBeforeFill = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(71, 431)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(200, 55)
        Me.btnNuevo.TabIndex = 23
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txbIdEmp
        '
        Me.txbIdEmp.BackColor = System.Drawing.SystemColors.Control
        Me.txbIdEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbIdEmp.Location = New System.Drawing.Point(350, 48)
        Me.txbIdEmp.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txbIdEmp.Name = "txbIdEmp"
        Me.txbIdEmp.Size = New System.Drawing.Size(263, 43)
        Me.txbIdEmp.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(280, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 38)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "ID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(69, 590)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(261, 38)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Fecha de ingreso:"
        '
        'txbFechaIngreso
        '
        Me.txbFechaIngreso.Location = New System.Drawing.Point(350, 582)
        Me.txbFechaIngreso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbFechaIngreso.Name = "txbFechaIngreso"
        Me.txbFechaIngreso.Size = New System.Drawing.Size(484, 43)
        Me.txbFechaIngreso.TabIndex = 27
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rtxbDireccion)
        Me.GroupBox3.Controls.Add(Me.txbTelefono)
        Me.GroupBox3.Controls.Add(Me.txbSeguroSocial)
        Me.GroupBox3.Controls.Add(Me.txbCedula)
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Controls.Add(Me.txbFechaNac)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.btnEditar)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.btnAgregar)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1612, 41)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(958, 648)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos especificos del empleado"
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
        'PuestoBindingSource
        '
        Me.PuestoBindingSource.DataMember = "puesto"
        Me.PuestoBindingSource.DataSource = Me.BDCtrlAsistenciaDataSet
        '
        'PuestoTableAdapter
        '
        Me.PuestoTableAdapter.ClearBeforeFill = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(66, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(313, 38)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Fecha de nacimiento:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(373, 38)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Numero de seguro social:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(257, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 38)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Cedula:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(241, 238)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(148, 38)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Telefono:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(227, 313)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(162, 38)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Direccion:"
        '
        'txbFechaNac
        '
        Me.txbFechaNac.Location = New System.Drawing.Point(385, 49)
        Me.txbFechaNac.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbFechaNac.Name = "txbFechaNac"
        Me.txbFechaNac.Size = New System.Drawing.Size(484, 43)
        Me.txbFechaNac.TabIndex = 28
        '
        'txbCedula
        '
        Me.txbCedula.Location = New System.Drawing.Point(385, 110)
        Me.txbCedula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbCedula.Name = "txbCedula"
        Me.txbCedula.Size = New System.Drawing.Size(484, 43)
        Me.txbCedula.TabIndex = 33
        '
        'txbSeguroSocial
        '
        Me.txbSeguroSocial.Location = New System.Drawing.Point(395, 168)
        Me.txbSeguroSocial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbSeguroSocial.Name = "txbSeguroSocial"
        Me.txbSeguroSocial.Size = New System.Drawing.Size(474, 43)
        Me.txbSeguroSocial.TabIndex = 34
        '
        'txbTelefono
        '
        Me.txbTelefono.Location = New System.Drawing.Point(385, 238)
        Me.txbTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(484, 43)
        Me.txbTelefono.TabIndex = 35
        '
        'IdEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.IdEmpleadoDataGridViewTextBoxColumn.Name = "IdEmpleadoDataGridViewTextBoxColumn"
        Me.IdEmpleadoDataGridViewTextBoxColumn.Width = 250
        '
        'IdDepartamentoDataGridViewTextBoxColumn
        '
        Me.IdDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "idDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.HeaderText = "idDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.IdDepartamentoDataGridViewTextBoxColumn.Name = "IdDepartamentoDataGridViewTextBoxColumn"
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
        'NombrePuestoDataGridViewTextBoxColumn
        '
        Me.NombrePuestoDataGridViewTextBoxColumn.DataPropertyName = "nombrePuesto"
        Me.NombrePuestoDataGridViewTextBoxColumn.HeaderText = "Nombre del puesto"
        Me.NombrePuestoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.NombrePuestoDataGridViewTextBoxColumn.Name = "NombrePuestoDataGridViewTextBoxColumn"
        Me.NombrePuestoDataGridViewTextBoxColumn.Width = 250
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 250
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.Width = 250
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.Width = 250
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Width = 250
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 250
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.Width = 250
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.Width = 250
        '
        'NumSeguroSocialDataGridViewTextBoxColumn
        '
        Me.NumSeguroSocialDataGridViewTextBoxColumn.DataPropertyName = "numSeguroSocial"
        Me.NumSeguroSocialDataGridViewTextBoxColumn.HeaderText = "Numero de seguro social"
        Me.NumSeguroSocialDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.NumSeguroSocialDataGridViewTextBoxColumn.Name = "NumSeguroSocialDataGridViewTextBoxColumn"
        Me.NumSeguroSocialDataGridViewTextBoxColumn.Width = 250
        '
        'FechaIngresoDataGridViewTextBoxColumn
        '
        Me.FechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "fechaIngreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.HeaderText = "Fecha de Ingreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.FechaIngresoDataGridViewTextBoxColumn.Name = "FechaIngresoDataGridViewTextBoxColumn"
        Me.FechaIngresoDataGridViewTextBoxColumn.Width = 250
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.MinimumWidth = 12
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.Width = 250
        '
        'rtxbDireccion
        '
        Me.rtxbDireccion.Location = New System.Drawing.Point(392, 311)
        Me.rtxbDireccion.Name = "rtxbDireccion"
        Me.rtxbDireccion.Size = New System.Drawing.Size(477, 89)
        Me.rtxbDireccion.TabIndex = 28
        Me.rtxbDireccion.Text = ""
        '
        'frmGestionEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2604, 1380)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmGestionEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE ASISTENCIA DE EMPLEADOS || ADMINISTRADORES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDCtrlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txbEmail2Emp As TextBox
    Friend WithEvents txbEmailEmp As TextBox
    Friend WithEvents txbNombresEmp As TextBox
    Friend WithEvents txbApellidosEmp As TextBox
    Friend WithEvents txbClave2Emp As TextBox
    Friend WithEvents txbClaveEmp As TextBox
    Friend WithEvents txbUsuarioEmp As TextBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cbxDepartamento As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbxPuesto As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BDCtrlAsistenciaDataSet As BDCtrlAsistenciaDataSet
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As BDCtrlAsistenciaDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents VistaEmpleadoBindingSource As BindingSource
    Friend WithEvents VistaEmpleadoTableAdapter As BDCtrlAsistenciaDataSetTableAdapters.VistaEmpleadoTableAdapter
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txbFechaIngreso As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txbIdEmp As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As BDCtrlAsistenciaDataSetTableAdapters.departamentoTableAdapter
    Friend WithEvents PuestoBindingSource As BindingSource
    Friend WithEvents PuestoTableAdapter As BDCtrlAsistenciaDataSetTableAdapters.puestoTableAdapter
    Friend WithEvents txbTelefono As TextBox
    Friend WithEvents txbSeguroSocial As TextBox
    Friend WithEvents txbCedula As TextBox
    Friend WithEvents txbFechaNac As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents IdEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombrePuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumSeguroSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents rtxbDireccion As RichTextBox
End Class
