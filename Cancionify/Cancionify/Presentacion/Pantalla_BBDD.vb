Public Class Pantalla_BBDD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRuta_Click(sender As Object, e As EventArgs) Handles BtnRuta.Click
        Me.OpFile.InitialDirectory = Application.StartupPath

        If Me.OpFile.ShowDialog() = DialogResult.OK Then
            Me.TbxRuta.Text = Me.OpFile.FileName
            Me.btnConectar.Enabled = True
        End If
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim usuario As Usuario = New Usuario()
        Try
            usuario.leerTodosUsuarios(TbxRuta.Text)
            Me.Visible = False
            Pantalla_Carga.Visible = True
        Catch ex As Exception
            MessageBox.Show("Asegurese de elegir una BBDD correcta", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try

    End Sub


End Class