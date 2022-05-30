Public Class frmJustificacion
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        frmMenuPpal.Show()


    End Sub

    Private Sub frmJustificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        frmMenuPpal.Show()
    End Sub
End Class