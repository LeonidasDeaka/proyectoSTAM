Public Class frmRptES
    Private Sub frmRptES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDCtrlAsistenciaDataSet.VistaRegistroAsistencia' Puede moverla o quitarla según sea necesario.
        Me.VistaRegistroAsistenciaTableAdapter.Fill(Me.BDCtrlAsistenciaDataSet.VistaRegistroAsistencia)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class