Public Class frmMenuPpal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
        frmLoginAdministradores.Show()

    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click
        Me.Hide()
        Dim frmGestEmpleado As New frmGestionEmpleado
        frmGestEmpleado.Show()


    End Sub

    Private Sub InicioDeSesionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioDeSesionDeEmpleadosToolStripMenuItem.Click
        Me.Hide()
        frmLoginEmpleado.Show()


    End Sub

    Private Sub JustificacionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JustificacionDeEmpleadosToolStripMenuItem.Click
        Me.Hide()
        Dim frmJust As New frmJustificacion
        frmJust.Show()

    End Sub

    Private Sub GestionDeDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeDepartamentosToolStripMenuItem.Click
        Me.Hide()
        Dim frmGestDepartamentos As New frmGestionDepartamentos
        frmGestDepartamentos.Show()


    End Sub

    Private Sub frmMenuPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GestionDeRolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeRolesToolStripMenuItem.Click
        Me.Hide()
        Dim frmGestRoles As New frmGestionRoles
        frmGestRoles.Show()
    End Sub

    Private Sub GestionDePuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDePuestosToolStripMenuItem.Click
        Me.Hide()
        Dim frmGestPuestos As New frmGestPuestos
        frmGestPuestos.Show()
    End Sub

    Private Sub GestionDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeUsuariosToolStripMenuItem.Click
        Me.Hide()
        Dim frmGestUsuario As New frmGestUsuario
        frmGestUsuario.Show()
    End Sub

    Private Sub AsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsistenciaToolStripMenuItem.Click
        Dim frmRptES As New frmRptES
        Me.Hide()
        frmRptES.Show()
    End Sub
End Class