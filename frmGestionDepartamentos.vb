Public Class frmGestionDepartamentos
    Private Sub frmGestionDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDCtrlAsistenciaDataSet.departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.BDCtrlAsistenciaDataSet.departamento)
        Me.Hide()
        frmMenuPpal.Show()

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        frmMenuPpal.Show()
    End Sub

End Class