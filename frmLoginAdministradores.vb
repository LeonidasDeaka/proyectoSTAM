Public Class frmLoginAdministradores
    Private Sub limpiarCampos()
        Me.UsuarioTextBox.Text = ""
        Me.PwdTextBox.Text = ""
    End Sub

    Private Sub frmLoginAdministradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDCtrlAsistenciaDataSet.usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.BDCtrlAsistenciaDataSet.usuario)
        limpiarCampos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim tblLog As New BDCtrlAsistenciaDataSetTableAdapters.usuarioTableAdapter
        Dim menuPpal As New frmMenuPpal
        If Me.UsuarioTableAdapter.BuscarLogin(Me.BDCtrlAsistenciaDataSet.usuario, UsuarioTextBox.Text, PwdTextBox.Text) Then
            Me.Hide()
            menuPpal.Show()
        Else
            MessageBox.Show("Datos incorrectos, porfavor intente de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            limpiarCampos()
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frEntrada.Show()
    End Sub

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDCtrlAsistenciaDataSet)

    End Sub
End Class