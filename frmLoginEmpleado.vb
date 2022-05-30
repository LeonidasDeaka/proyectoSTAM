Public Class frmLoginEmpleado
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frEntrada.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmMarcado As New frmMarcadoES
        frmMarcado.Show()
    End Sub

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDCtrlAsistenciaDataSet)

    End Sub

    Private Sub frmLoginEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDCtrlAsistenciaDataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BDCtrlAsistenciaDataSet.empleado)

    End Sub
End Class