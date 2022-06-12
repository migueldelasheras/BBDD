Public Class Pantalla_Carga

    Private Sub Pantalla_Carga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar.Value = ProgressBar.Maximum) Then
            Timer1.Stop()
            Me.Hide()
            InicSesion.Show()
        Else
            ProgressBar.PerformStep()
            lblPorcentaje.Text = ProgressBar.Value & ("%")
        End If
    End Sub


End Class