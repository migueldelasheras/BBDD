Public Class InicSesion

    Private Sub InicSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uAux As Usuario = New Usuario
        Try
            uAux.leerTodosUsuarios(Pantalla_BBDD.TbxRuta.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each u As Usuario In uAux._usuarioDAO._listaUsuarios
            LstUsuarios.Items.Add(u._email)
        Next
        GroupBox1.Enabled = True
        btnEliminar.Enabled = False
        btnModificar.Enabled = False

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtEmail.Text = String.Empty
        txtNombre.Text = String.Empty
        txtApellido.Text = String.Empty
        txtNacimiento.Text = String.Empty
        btnAñadir.Enabled = True
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
    End Sub

    Private Sub LstUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstUsuarios.SelectedIndexChanged
        Dim uAux As Usuario
        If LstUsuarios.SelectedItem IsNot Nothing Then
            uAux = New Usuario(LstUsuarios.SelectedItem.ToString())
            Try
                uAux.leerUsuario()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            txtEmail.Text = uAux._email
            txtNombre.Text = uAux._nombre
            txtApellido.Text = uAux._apellidos
            txtNacimiento.Text = uAux._nacimiento
            btnAñadir.Enabled = False
            btnEliminar.Enabled = True
            btnModificar.Enabled = True
            btnIniciar.Enabled = True
        End If
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim uAux As Usuario
        If txtEmail.Text IsNot String.Empty And txtNombre.Text IsNot String.Empty And txtApellido.Text IsNot String.Empty And txtNacimiento.Text IsNot String.Empty Then
            uAux = New Usuario(txtEmail.Text)
            uAux._nombre = txtNombre.Text
            uAux._apellidos = txtApellido.Text
            uAux._nacimiento = txtNacimiento.Text
            Try
                If uAux.insertar() <> 1 Then
                    MessageBox.Show("Insert Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            LstUsuarios.Items.Add(uAux._email)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim uAux As Usuario
        If txtEmail.Text IsNot String.Empty Then
            uAux = New Usuario(txtEmail.Text)
            If MessageBox.Show("¿Desea eliminar el usuario " & uAux._email & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If uAux.delete() <> 1 Then
                        MessageBox.Show("Delete Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                LstUsuarios.Items.Remove(uAux._email)
                btnLimpiar.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim uAux As Usuario
        If txtEmail.Text IsNot String.Empty And txtNombre.Text IsNot String.Empty And txtApellido.Text IsNot String.Empty And txtNacimiento.Text IsNot String.Empty Then
            uAux = New Usuario(txtEmail.Text)
            uAux._nombre = txtNombre.Text
            uAux._apellidos = txtApellido.Text
            uAux._nacimiento = txtNacimiento.Text
            Try
                If uAux.actualizar() <> 1 Then
                    MessageBox.Show("Update Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            MessageBox.Show("El nombre del usuario " & uAux._email & " se ha actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim u As Usuario = New Usuario(LstUsuarios.SelectedItem.ToString)
        Me.Hide()
        Pantalla_Principal.Show()
    End Sub
End Class