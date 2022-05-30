Public Class frmMarcadoES
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbHoras.Text = Format(DateAndTime.TimeOfDay, "hh") & ":"
        lbMin.Text = Format(DateAndTime.TimeOfDay, "mm")
        lbSeg.Text = Format(DateAndTime.TimeOfDay, "ss")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Val(lbHoras.Text) > 12 Then  'Solo toma en cuenta el valor numerico dentro del label, no los dos puntos
            lbFormato.Text = "AM"

        Else
            lbFormato.Text = "PM"

        End If

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        frmLoginEmpleado.Show()
    End Sub
End Class