<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginEmpleado))
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Dim PwdLabel As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BDCtrlAsistenciaDataSet = New ProyectoSTAM.BDCtrlAsistenciaDataSet()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New ProyectoSTAM.BDCtrlAsistenciaDataSetTableAdapters.empleadoTableAdapter()
        Me.TableAdapterManager = New ProyectoSTAM.BDCtrlAsistenciaDataSetTableAdapters.TableAdapterManager()
        Me.EmpleadoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpleadoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.PwdTextBox = New System.Windows.Forms.TextBox()
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        PwdLabel = New System.Windows.Forms.Label()
        CType(Me.BDCtrlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "INICIO DE SESIÓN"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(110, 177)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 25)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Cambria", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(223, 177)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 25)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BDCtrlAsistenciaDataSet
        '
        Me.BDCtrlAsistenciaDataSet.DataSetName = "BDCtrlAsistenciaDataSet"
        Me.BDCtrlAsistenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.departamentoTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager.empresaTableAdapter = Nothing
        Me.TableAdapterManager.opcionesTableAdapter = Nothing
        Me.TableAdapterManager.parametrosHorarioTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.puestoTableAdapter = Nothing
        Me.TableAdapterManager.registroAsistenciaTableAdapter = Nothing
        Me.TableAdapterManager.rolOpcionTableAdapter = Nothing
        Me.TableAdapterManager.rolTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoSTAM.BDCtrlAsistenciaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'EmpleadoBindingNavigator
        '
        Me.EmpleadoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadoBindingNavigator.BindingSource = Me.EmpleadoBindingSource
        Me.EmpleadoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadoBindingNavigatorSaveItem})
        Me.EmpleadoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadoBindingNavigator.Name = "EmpleadoBindingNavigator"
        Me.EmpleadoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadoBindingNavigator.Size = New System.Drawing.Size(526, 25)
        Me.EmpleadoBindingNavigator.TabIndex = 7
        Me.EmpleadoBindingNavigator.Text = "BindingNavigator1"
        Me.EmpleadoBindingNavigator.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'EmpleadoBindingNavigatorSaveItem
        '
        Me.EmpleadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadoBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpleadoBindingNavigatorSaveItem.Name = "EmpleadoBindingNavigatorSaveItem"
        Me.EmpleadoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EmpleadoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.Location = New System.Drawing.Point(90, 51)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(68, 13)
        IdEmpleadoLabel.TabIndex = 7
        IdEmpleadoLabel.Text = "id Empleado:"
        '
        'IdEmpleadoTextBox
        '
        Me.IdEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "idEmpleado", True))
        Me.IdEmpleadoTextBox.Location = New System.Drawing.Point(164, 48)
        Me.IdEmpleadoTextBox.Name = "IdEmpleadoTextBox"
        Me.IdEmpleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdEmpleadoTextBox.TabIndex = 8
        '
        'PwdLabel
        '
        PwdLabel.AutoSize = True
        PwdLabel.Location = New System.Drawing.Point(128, 90)
        PwdLabel.Name = "PwdLabel"
        PwdLabel.Size = New System.Drawing.Size(30, 13)
        PwdLabel.TabIndex = 8
        PwdLabel.Text = "pwd:"
        '
        'PwdTextBox
        '
        Me.PwdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "pwd", True))
        Me.PwdTextBox.Location = New System.Drawing.Point(164, 87)
        Me.PwdTextBox.Name = "PwdTextBox"
        Me.PwdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PwdTextBox.TabIndex = 9
        '
        'frmLoginEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 248)
        Me.Controls.Add(PwdLabel)
        Me.Controls.Add(Me.PwdTextBox)
        Me.Controls.Add(IdEmpleadoLabel)
        Me.Controls.Add(Me.IdEmpleadoTextBox)
        Me.Controls.Add(Me.EmpleadoBindingNavigator)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "frmLoginEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE ASISTENCIA DE EMPLEADOS || EMPLEADOS"
        CType(Me.BDCtrlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadoBindingNavigator.ResumeLayout(False)
        Me.EmpleadoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BDCtrlAsistenciaDataSet As BDCtrlAsistenciaDataSet
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As BDCtrlAsistenciaDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents TableAdapterManager As BDCtrlAsistenciaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmpleadoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdEmpleadoTextBox As TextBox
    Friend WithEvents PwdTextBox As TextBox
End Class
