Public Class frmGestUsuario

    Private Sub frmGestUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDCtrlAsistenciaDataSet.rol' Puede moverla o quitarla según sea necesario.
        Me.RolTableAdapter.Fill(Me.BDCtrlAsistenciaDataSet.rol)
        'TODO: esta línea de código carga datos en la tabla 'BDCtrlAsistenciaDataSet.VistaUsuario' Puede moverla o quitarla según sea necesario.
        Me.VistaUsuarioTableAdapter.Fill(Me.BDCtrlAsistenciaDataSet.VistaUsuario)
        Me.Hide()
        frmMenuPpal.Show()

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        frmMenuPpal.Show()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.txbIdUsuario.Text = ""
        Me.txbUsuario.Text = ""
        Me.txbNombresUsuario.Text = ""
        Me.txbApellidosUsuario.Text = ""
        Me.txbEmailUsuario.Text = ""
        Me.txbEmail2Usuario.Text = ""
        Me.txbClaveUsuario.Text = ""
        Me.txbClave2Usuario.Text = ""

    End Sub
End Class