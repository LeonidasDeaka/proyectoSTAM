<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuPpal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPpal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeRolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeDepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDePuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioDeSesionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JustificacionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.GestionToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ControlDeAsistenciaToolStripMenuItem, Me.ReportesToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(2, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(386, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 22)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeEmpleadosToolStripMenuItem, Me.GestionDeUsuariosToolStripMenuItem, Me.GestionDeRolesToolStripMenuItem, Me.GestionDeDepartamentosToolStripMenuItem, Me.GestionDePuestosToolStripMenuItem})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(59, 22)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'GestionDeEmpleadosToolStripMenuItem
        '
        Me.GestionDeEmpleadosToolStripMenuItem.Name = "GestionDeEmpleadosToolStripMenuItem"
        Me.GestionDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.GestionDeEmpleadosToolStripMenuItem.Text = "Gestion de Empleados"
        '
        'GestionDeUsuariosToolStripMenuItem
        '
        Me.GestionDeUsuariosToolStripMenuItem.Name = "GestionDeUsuariosToolStripMenuItem"
        Me.GestionDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.GestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios"
        '
        'GestionDeRolesToolStripMenuItem
        '
        Me.GestionDeRolesToolStripMenuItem.Name = "GestionDeRolesToolStripMenuItem"
        Me.GestionDeRolesToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.GestionDeRolesToolStripMenuItem.Text = "Gestion de Roles"
        '
        'GestionDeDepartamentosToolStripMenuItem
        '
        Me.GestionDeDepartamentosToolStripMenuItem.Name = "GestionDeDepartamentosToolStripMenuItem"
        Me.GestionDeDepartamentosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.GestionDeDepartamentosToolStripMenuItem.Text = "Gestion de Departamentos"
        '
        'GestionDePuestosToolStripMenuItem
        '
        Me.GestionDePuestosToolStripMenuItem.Name = "GestionDePuestosToolStripMenuItem"
        Me.GestionDePuestosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.GestionDePuestosToolStripMenuItem.Text = "Gestion de Puestos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeEmpleadosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteDeEmpleadosToolStripMenuItem
        '
        Me.ReporteDeEmpleadosToolStripMenuItem.Name = "ReporteDeEmpleadosToolStripMenuItem"
        Me.ReporteDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ReporteDeEmpleadosToolStripMenuItem.Text = "Reporte de empleados"
        '
        'ControlDeAsistenciaToolStripMenuItem
        '
        Me.ControlDeAsistenciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioDeSesionDeEmpleadosToolStripMenuItem, Me.JustificacionDeEmpleadosToolStripMenuItem})
        Me.ControlDeAsistenciaToolStripMenuItem.Name = "ControlDeAsistenciaToolStripMenuItem"
        Me.ControlDeAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(72, 22)
        Me.ControlDeAsistenciaToolStripMenuItem.Text = "Asistencia"
        '
        'InicioDeSesionDeEmpleadosToolStripMenuItem
        '
        Me.InicioDeSesionDeEmpleadosToolStripMenuItem.Name = "InicioDeSesionDeEmpleadosToolStripMenuItem"
        Me.InicioDeSesionDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.InicioDeSesionDeEmpleadosToolStripMenuItem.Text = "Inicio de sesion de empleados"
        '
        'JustificacionDeEmpleadosToolStripMenuItem
        '
        Me.JustificacionDeEmpleadosToolStripMenuItem.Name = "JustificacionDeEmpleadosToolStripMenuItem"
        Me.JustificacionDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.JustificacionDeEmpleadosToolStripMenuItem.Text = "Justificacion de empleados"
        '
        'ReportesToolStripMenuItem1
        '
        Me.ReportesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsistenciaToolStripMenuItem})
        Me.ReportesToolStripMenuItem1.Name = "ReportesToolStripMenuItem1"
        Me.ReportesToolStripMenuItem1.Size = New System.Drawing.Size(65, 22)
        Me.ReportesToolStripMenuItem1.Text = "Reportes"
        '
        'AsistenciaToolStripMenuItem
        '
        Me.AsistenciaToolStripMenuItem.Name = "AsistenciaToolStripMenuItem"
        Me.AsistenciaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AsistenciaToolStripMenuItem.Text = "Asistencia"
        '
        'frmMenuPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 314)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "frmMenuPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE ASISTENCIA DE EMPLEADOS || MENU PRINCIPAL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlDeAsistenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioDeSesionDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JustificacionDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeDepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeRolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDePuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AsistenciaToolStripMenuItem As ToolStripMenuItem
End Class
