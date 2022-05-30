Public Class frmGestionEmpleado
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        frmMenuPpal.Show()
    End Sub

    Private Sub frmGestionEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDCtrlAsistenciaDataSet.puesto' Puede moverla o quitarla según sea necesario.
        Me.PuestoTableAdapter.Fill(Me.BDCtrlAsistenciaDataSet.puesto)
        'TODO: esta línea de código carga datos en la tabla 'BDCtrlAsistenciaDataSet.departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.BDCtrlAsistenciaDataSet.departamento)
        'TODO: esta línea de código carga datos en la tabla 'BDCtrlAsistenciaDataSet.VistaEmpleado' Puede moverla o quitarla según sea necesario.
        Me.VistaEmpleadoTableAdapter.Fill(Me.BDCtrlAsistenciaDataSet.VistaEmpleado)
        'TODO: esta línea de código carga datos en la tabla 'BDCtrlAsistenciaDataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BDCtrlAsistenciaDataSet.empleado)
        Me.Hide()
        frmMenuPpal.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'El .text se encarga de acceder a los valores dentro de los controles
        Me.txbIdEmp.Text = ""
        Me.txbUsuarioEmp.Text = ""
        Me.txbNombresEmp.Text = ""
        Me.txbApellidosEmp.Text = ""
        Me.txbEmailEmp.Text = ""
        Me.txbEmail2Emp.Text = ""
        Me.txbClaveEmp.Text = ""
        Me.txbClave2Emp.Text = ""
        Me.txbFechaIngreso.Text = ""
        Me.txbFechaNac.Text = ""
        Me.txbCedula.Text = ""
        Me.txbSeguroSocial.Text = ""
        Me.txbTelefono.Text = ""
        Me.rtxbDireccion.Text = ""

    End Sub
End Class