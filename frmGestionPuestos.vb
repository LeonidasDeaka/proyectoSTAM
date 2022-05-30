Public Class frmGestPuestos
    Private Sub frmGestionPuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDCtrlAsistenciaDataSet.VistaRol' Puede moverla o quitarla según sea necesario.
        Me.VistaRolTableAdapter.Fill(Me.BDCtrlAsistenciaDataSet.VistaRol)
        'TODO: esta línea de código carga datos en la tabla 'BDCtrlAsistenciaDataSet.VistaPuesto' Puede moverla o quitarla según sea necesario.
        Me.VistaPuestoTableAdapter.Fill(Me.BDCtrlAsistenciaDataSet.VistaPuesto)
        Me.Hide()
        frmMenuPpal.Show()

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        frmMenuPpal.Show()
    End Sub

End Class