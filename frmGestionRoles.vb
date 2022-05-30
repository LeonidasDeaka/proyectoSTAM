Imports System.Data.SqlClient
Public Class frmGestionRoles

    Dim vWRol As New BDCtrlAsistenciaDataSetTableAdapters.VistaRolTableAdapter
    Dim tblRol As New BDCtrlAsistenciaDataSetTableAdapters.rolTableAdapter

    Private Sub limpiarCampos()
        Me.tbIDRol.Text = ""
        Me.tbRolName.Text = ""
        Me.tbDescripcion.Text = ""
    End Sub

    Private Sub cbRol_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmGestionRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.vWRol.Fill(Me.BDCtrlAsistenciaDataSet.VistaRol)
        Me.tblRol.Fill(Me.BDCtrlAsistenciaDataSet.rol)
        Me.Hide()
        frmMenuPpal.Show()
        limpiarCampos()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        frmMenuPpal.Show()
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarRol.Click
        Try
            If Me.tbRolName.Text.Equals("") Or Me.tbDescripcion.Text.Equals("") Then
                MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Dim tblRol As New BDCtrlAsistenciaDataSetTableAdapters.rolTableAdapter
                tblRol.AgregarRol(Me.tbRolName.Text, Me.tbDescripcion.Text, 1)
                MessageBox.Show("El Registro se ha guardado correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.vWRol.Fill(Me.BDCtrlAsistenciaDataSet.VistaRol)
                limpiarCampos()

            End If

        Catch sqlEx As SqlException
            MsgBox("Error al registrar rol: ", sqlEx.Message())
            MsgBox("Error al registrar rol: ", sqlEx.StackTrace())

        Catch ex As Exception
            MsgBox("Error al registrar rol: ", ex.Message())
            MsgBox("Error al registrar rol: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub dGVRol_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dGVRol.CellContentClick
        Me.tbIDRol.Text = dGVRol.CurrentRow.Cells.Item(0).Value.ToString
        Me.tbRolName.Text = dGVRol.CurrentRow.Cells.Item(1).Value.ToString
        Me.tbDescripcion.Text = dGVRol.CurrentRow.Cells.Item(2).Value.ToString
    End Sub

    Private Sub tbBuscarRol_TextChanged(sender As Object, e As EventArgs) Handles tbBuscarRol.TextChanged
        Me.dGVRol.DataSource = Me.vWRol.GetDataBy(tbBuscarRol.Text)
    End Sub

    Private Sub btnNuevoRol_Click(sender As Object, e As EventArgs) Handles btnNuevoRol.Click
        limpiarCampos()
    End Sub

    Private Sub btnEliminarRol_Click(sender As Object, e As EventArgs) Handles btnEliminarRol.Click
        Try
            If tbIDRol.Text.Equals("") Or String.IsNullOrEmpty(Me.tbIDRol.Text) Then
                MessageBox.Show("Error, primero debe seleccionar el usuario que intenta eliminar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim tblRol As New BDCtrlAsistenciaDataSetTableAdapters.rolTableAdapter
                tblRol.EliminarByEstado(Me.tbIDRol.Text)
                MessageBox.Show("El Registro se ha eliminado satisfactoriamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.vWRol.Fill(Me.BDCtrlAsistenciaDataSet.VistaRol)

            End If
        Catch sqlEx As SqlException
            MsgBox("Error al eliminar al usuario: ", sqlEx.Message())
            MsgBox("Error al eliminar al usuario: ", sqlEx.StackTrace())
        Catch ex As Exception
            MsgBox("Error al eliminar registro: ", ex.Message())
            MsgBox("Error al eliminar registro: ", ex.StackTrace())
        End Try
    End Sub

    Private Sub btnEditarRol_Click(sender As Object, e As EventArgs) Handles btnEditarRol.Click
        Try
            If tbIDRol.Text.Equals("") Or String.IsNullOrEmpty(Me.tbIDRol.Text) Then
                MessageBox.Show("Error, primero debe seleccionar el usuario que intenta modificar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Me.tbRolName.Text.Equals("") Or Me.tbDescripcion.Text.Equals("") Then
                    MessageBox.Show("Todos los campos son requeridos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim tblRolU As New BDCtrlAsistenciaDataSetTableAdapters.rolTableAdapter
                    tblRolU.UpdateQuery(Me.tbRolName.Text, Me.tbDescripcion.Text, 2, Me.tbIDRol.Text)
                    MessageBox.Show("El Registro se ha modificado correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.vWRol.Fill(Me.BDCtrlAsistenciaDataSet.VistaRol)
                    limpiarCampos()
                End If
            End If
        Catch sqlEx As SqlException
            MsgBox("Error al editar el registro: ", sqlEx.Message())
            MsgBox("Error al editar el registro: ", sqlEx.StackTrace())
        Catch ex As Exception
            MsgBox("Error al editar el registro: ", ex.Message())
            MsgBox("Error al editarl el registro: ", ex.StackTrace())
        End Try
    End Sub
End Class