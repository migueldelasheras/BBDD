Public Class Pantalla_Principal

    Private rutaEjecutable As String
    Private artSeleccionado As Integer 'artista seleccionada en la pestaña Tu biblioteca'
    Private cancionSonando As Integer 'cancion que tenemos seleccionada cuando pulsamos el boton de repoducir'
    Private usuario As String

    Private Sub Pantalla_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'este es el usuario que ha iniciado sesion.'
        usuario = InicSesion.txtEmail.Text
        'definimos ruta de las imagenes'
        rutaEjecutable = Application.StartupPath
        rutaEjecutable = rutaEjecutable.Substring(0, rutaEjecutable.Length - 9) & "Imagenes\"

        'inicializamos la lista de artista en la pestaña configuracion'
        Dim aAux As Artista = New Artista
        Try
            aAux.leerTodosArtistas(Pantalla_BBDD.TbxRuta.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each a As Artista In aAux._artistaDAO._listaArtistas
            lstArtistas.Items.Add(a._idArtista)
            Me.gridArtistas.Rows.Add(a._idArtista, a._nombre, a._pais)
        Next
        grboxArtistas.Enabled = True
        btnEliminarArt.Enabled = False
        btnModificarArt.Enabled = False

        'inicializamos la lista de canciones en la pestaña configuracion'
        Dim cAux As Cancion = New Cancion
        Try
            cAux.leerTodasCanciones(Pantalla_BBDD.TbxRuta.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each c As Cancion In cAux._cancionDAO._listaCanciones
            lstCanciones.Items.Add(c._idCancion)

        Next
        grCanciones.Enabled = True
        btnEliminarCancion.Enabled = False
        btnModificarCancion.Enabled = False
        'incializamos la lista de albumes en la pestaña configuracion'
        Dim alAux As Album = New Album
        Try
            alAux.leerTodosAlbumes(Pantalla_BBDD.TbxRuta.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each al As Album In alAux._albumDAO._listaAlbumes
            lstAlbumes.Items.Add(al._idAlbum)
        Next
        grAlbumes.Enabled = True
        btnEliminarAlbum.Enabled = False
        btnModificarAlbum.Enabled = False

        'inicializamos el historial de reproducciones en la pantalla reproducir'
        Dim rAux As Reproduccion = New Reproduccion
        rAux._usuario = usuario
        Try
            rAux.leerTodasReproducciones(Pantalla_BBDD.TbxRuta.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each r As Reproduccion In rAux.ReproduccionDAO._listaReproducciones
            gridReproducciones.Rows.Add(r._id, r._cancion, r._fecha)
        Next

        'Rellenamos el grid de los artistas,canciones y usuarios mas escuchados'

        mostrarTopCanciones()
        mostrarTopUsuarios()
        mostrarTopFavoritos()


    End Sub

    'Funcion para saber la direccion de las imagenes'
    Private Function completarRutaImagenes(nombreImg As String) As String
        Return rutaEjecutable & nombreImg
    End Function
    'Funcion para convertir de segundos a horas, minutos y segundos'
    Private Function conversor(num As Integer) As String
        Dim hor As Integer
        Dim min As Integer
        Dim seg As Integer
        hor = Math.Floor(num / 3600)
        min = Math.Floor((num - hor * 3600) / 60)
        seg = num - (hor * 3600 + min * 60)
        Return Trim(hor) + ":" + Trim(min) + ":" + Trim(seg)
    End Function


    'PANTALLA DE CONFIGURACIÓN'
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click

        If MessageBox.Show("¿Seguro que desea cerrar sesión?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            InicSesion.Show()
        End If

    End Sub
    'Configuracion de las listas de artistas, albumes y canciones'
    Private Sub LstArtistas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArtistas.SelectedIndexChanged
        Dim aAux As Artista
        If lstArtistas.SelectedItem IsNot Nothing Then
            aAux = New Artista(lstArtistas.SelectedItem.ToString())
            Try
                aAux.leerArtista()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            txtIdArt.Text = aAux._idArtista
            txtNombreArt.Text = aAux._nombre
            txtPaisArt.Text = aAux._pais
            Try
                PctArtista.Image = Image.FromFile(completarRutaImagenes(aAux._imagen))
                PctArtista.SizeMode = PictureBoxSizeMode.StretchImage
            Catch ex As Exception
                PctArtista.Image = PctArtista.ErrorImage
            End Try
            btnAñadirArt.Enabled = False
            btnEliminarArt.Enabled = True
            btnModificarArt.Enabled = True
        End If
    End Sub
    Private Sub lstCanciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCanciones.SelectedIndexChanged
        Dim cAux As Cancion
        If lstCanciones.SelectedItem IsNot Nothing Then
            cAux = New Cancion(lstCanciones.SelectedItem.ToString())
            Try
                cAux.leerCancion()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            txtcancion.Text = cAux._idCancion
            txtNombreCancion.Text = cAux._nombre
            txtAlbumCancion.Text = cAux._album
            txtDuracionCancion.Text = cAux._duracion
            btnAñadirCancion.Enabled = False
            btnEliminarCancion.Enabled = True
            btnModificarCancion.Enabled = True
        End If
    End Sub
    Private Sub lstAlbumes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlbumes.SelectedIndexChanged
        Dim aAux As Album
        If lstAlbumes.SelectedItem IsNot Nothing Then
            aAux = New Album(lstAlbumes.SelectedItem.ToString())
            Try
                aAux.leerAlbum()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            TxtIdAlbum.Text = aAux._idAlbum
            TxtNombreAlbum.Text = aAux._nombre
            txtFechaAlbum.Text = aAux._fecha
            txtArtistaAlbum.Text = aAux._artista
            Try
                PctAlbum.Image = Image.FromFile(completarRutaImagenes(aAux._imagen))
                PctAlbum.SizeMode = PictureBoxSizeMode.StretchImage
            Catch ex As Exception
                PctAlbum.Image = PctAlbum.ErrorImage
            End Try
            btnAñadirAlbum.Enabled = False
            btnEliminarAlbum.Enabled = True
            btnModificarAlbum.Enabled = True
        End If
    End Sub
    'Añadir imagenes'
    Private Sub PctArtista_Click(sender As Object, e As EventArgs) Handles PctArtista.Click
        Dim BuscarImagen As OpenFileDialog = New OpenFileDialog
        BuscarImagen.Filter = "Archivos de imágenes|*.jpg"
        BuscarImagen.InitialDirectory = rutaEjecutable

        If (BuscarImagen.ShowDialog() = DialogResult.OK) Then
            Dim direccion As String = BuscarImagen.FileName
            Dim nombre As String = direccion.Substring(rutaEjecutable.Length)
            PctArtista.Image = Image.FromFile(direccion)
            PctArtista.Tag = nombre
            PctArtista.SizeMode = PictureBoxSizeMode.StretchImage

        End If
    End Sub
    Private Sub PctAlbum_Click(sender As Object, e As EventArgs) Handles PctAlbum.Click
        Dim BuscarImagen As OpenFileDialog = New OpenFileDialog
        BuscarImagen.Filter = "Archivos de imágenes|*.jpg"
        BuscarImagen.InitialDirectory = rutaEjecutable

        If (BuscarImagen.ShowDialog() = DialogResult.OK) Then
            Dim direccion As String = BuscarImagen.FileName
            Dim Nombre As String = direccion.Substring(rutaEjecutable.Length)
            PctAlbum.Image = Image.FromFile(direccion)
            PctAlbum.Tag = Nombre
            PctAlbum.SizeMode = PictureBoxSizeMode.StretchImage

        End If
    End Sub

    'botones de limpiar'
    Private Sub btnLimpiarArt_Click(sender As Object, e As EventArgs) Handles btnLimpiarArt.Click
        txtIdArt.Text = String.Empty
        txtNombreArt.Text = String.Empty
        txtPaisArt.Text = String.Empty
        PctArtista.Image = Nothing
        btnAñadirArt.Enabled = True
        btnEliminarArt.Enabled = False
        btnModificarArt.Enabled = False
    End Sub
    Private Sub btnLimpiarAlbum_Click(sender As Object, e As EventArgs) Handles btnLimpiarAlbum.Click
        TxtIdAlbum.Text = String.Empty
        TxtNombreAlbum.Text = String.Empty
        txtFechaAlbum.Text = String.Empty
        txtArtistaAlbum.Text = String.Empty
        PctAlbum.Image = Nothing
        btnAñadirAlbum.Enabled = True
        btnEliminarAlbum.Enabled = False
        btnModificarAlbum.Enabled = False
    End Sub
    Private Sub btnLimpiarCancion_Click(sender As Object, e As EventArgs) Handles btnLimpiarCancion.Click
        txtcancion.Text = String.Empty
        txtNombreCancion.Text = String.Empty
        txtAlbumCancion.Text = String.Empty
        txtDuracionCancion.Text = String.Empty
        btnAñadirCancion.Enabled = True
        btnEliminarCancion.Enabled = False
        btnModificarCancion.Enabled = False
    End Sub
    'botones de eliminar'
    Private Sub btnEliminarArt_Click(sender As Object, e As EventArgs) Handles btnEliminarArt.Click
        Dim aAux As Artista
        If txtIdArt.Text IsNot String.Empty Then
            aAux = New Artista(txtIdArt.Text)
            If MessageBox.Show("¿Desea eliminar el artista " & aAux._idArtista & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If aAux.delete() <> 1 Then
                        MessageBox.Show("Delete Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                lstArtistas.Items.Remove(aAux._idArtista)
                btnLimpiarArt.PerformClick()
            End If
        End If
    End Sub
    Private Sub btnEliminarAlbum_Click(sender As Object, e As EventArgs) Handles btnEliminarAlbum.Click
        Dim aAux As Album
        If TxtIdAlbum.Text IsNot String.Empty Then
            aAux = New Album(TxtIdAlbum.Text)
            If MessageBox.Show("¿Desea eliminar el álbum " & aAux._idAlbum & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If aAux.delete() <> 1 Then
                        MessageBox.Show("Delete Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                lstAlbumes.Items.Remove(aAux._idAlbum)
                btnLimpiarAlbum.PerformClick()
            End If
        End If
    End Sub
    Private Sub btnEliminarCancion_Click(sender As Object, e As EventArgs) Handles btnEliminarCancion.Click
        Dim cAux As Cancion
        If txtcancion.Text IsNot String.Empty Then
            cAux = New Cancion(txtcancion.Text)
            If MessageBox.Show("¿Desea eliminar la cancion " & cAux._idCancion & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If cAux.delete() <> 1 Then
                        MessageBox.Show("Delete Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                lstCanciones.Items.Remove(cAux._idCancion)
                btnLimpiarCancion.PerformClick()
            End If
        End If
    End Sub
    'botones de modificar'
    Private Sub btnModificarArt_Click(sender As Object, e As EventArgs) Handles btnModificarArt.Click
        Dim aAux As Artista
        If txtIdArt.Text IsNot String.Empty And txtNombreArt.Text IsNot String.Empty And txtPaisArt.Text IsNot String.Empty And PctArtista.Tag IsNot String.Empty Then
            aAux = New Artista(txtIdArt.Text)
            aAux._nombre = txtNombreArt.Text
            aAux._pais = txtPaisArt.Text
            aAux._imagen = PctArtista.Tag
            Try
                If aAux.actualizar() <> 1 Then
                    MessageBox.Show("Update Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            MessageBox.Show("El artista con id: " & aAux._idArtista & " se ha actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnModificarAlbum_Click(sender As Object, e As EventArgs) Handles btnModificarAlbum.Click
        Dim aAux As Album
        If TxtIdAlbum.Text IsNot String.Empty And TxtNombreAlbum.Text IsNot String.Empty And txtArtistaAlbum.Text IsNot String.Empty And PctAlbum.Tag IsNot String.Empty Then
            aAux = New Album(TxtIdAlbum.Text)
            aAux._nombre = TxtNombreAlbum.Text
            aAux._artista = txtArtistaAlbum.Text
            aAux._fecha = txtFechaAlbum.Text
            aAux._imagen = PctAlbum.Tag
            Try
                If aAux.actualizar() <> 1 Then
                    MessageBox.Show("Update Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
            MessageBox.Show("El álbum con id: " & aAux._idAlbum & " se ha actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnModificarCancion_Click(sender As Object, e As EventArgs) Handles btnModificarCancion.Click
        Dim cAux As Cancion
        If txtcancion.Text IsNot String.Empty And txtNombreCancion.Text IsNot String.Empty And txtAlbumCancion.Text IsNot String.Empty And txtDuracionCancion.Text IsNot String.Empty Then
            cAux = New Cancion(txtcancion.Text)
            cAux._nombre = txtNombreCancion.Text
            cAux._album = txtAlbumCancion.Text
            cAux._duracion = txtDuracionCancion.Text
            Try
                If cAux.actualizar() <> 1 Then
                    MessageBox.Show("Update Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            MessageBox.Show("La canción con id: " & cAux._idCancion & " se ha actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Botones de añadir'
    Private Sub btnAñadirArt_Click(sender As Object, e As EventArgs) Handles btnAñadirArt.Click
        Dim aAux As Artista
        If txtIdArt.Text IsNot String.Empty And txtNombreArt.Text IsNot String.Empty And txtPaisArt.Text IsNot String.Empty And PctArtista.Tag IsNot String.Empty Then
            aAux = New Artista(txtIdArt.Text)
            aAux._nombre = txtNombreArt.Text
            aAux._pais = txtPaisArt.Text
            aAux._imagen = PctArtista.Tag
            Try
                If aAux.insertar() <> 1 Then
                    MessageBox.Show("Insert Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            lstArtistas.Items.Add(aAux._idArtista)
            gridArtistas.Rows.Add(aAux._idArtista, aAux._nombre, aAux._pais)
        End If
    End Sub
    Private Sub btnAñadirAlbum_Click(sender As Object, e As EventArgs) Handles btnAñadirAlbum.Click
        Dim aAux As Album
        If TxtIdAlbum.Text IsNot String.Empty And TxtNombreAlbum.Text IsNot String.Empty And txtFechaAlbum.Text IsNot String.Empty And txtArtistaAlbum.Text IsNot String.Empty And PctArtista.Tag IsNot String.Empty Then
            aAux = New Album(TxtIdAlbum.Text)
            aAux._nombre = txtNombreArt.Text
            aAux._fecha = txtFechaAlbum.Text
            aAux._artista = txtArtistaAlbum.Text
            aAux._imagen = PctAlbum.Tag
            Try
                If aAux.insertar() <> 1 Then
                    MessageBox.Show("Insert Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            lstAlbumes.Items.Add(aAux._idAlbum)
        End If
    End Sub
    Private Sub btnAñadirCancion_Click(sender As Object, e As EventArgs) Handles btnAñadirCancion.Click
        Dim cAux As Cancion
        If txtcancion.Text IsNot String.Empty And txtNombreCancion.Text IsNot String.Empty And txtAlbumCancion.Text IsNot String.Empty And txtDuracionCancion.Text IsNot Nothing Then
            cAux = New Cancion(txtcancion.Text)
            cAux._nombre = txtNombreCancion.Text
            cAux._album = txtAlbumCancion.Text
            cAux._duracion = txtDuracionCancion.Text
            Try
                If cAux.insertar() <> 1 Then
                    MessageBox.Show("Insert Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            lstCanciones.Items.Add(cAux._idCancion)
        End If
    End Sub

    'PÁGINA DE TU BIBLIOTECA'

    'rellenamos los grid de albumes y canciones'
    Private Sub gridArtistas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridArtistas.CellContentClick
        'seleccionamos el artista'
        Dim aAux As Artista
        If gridArtistas.SelectedRows IsNot Nothing Then
            aAux = New Artista(gridArtistas.Rows(e.RowIndex).Cells(0).Value)
            artSeleccionado = aAux._idArtista
            Try
                aAux.leerArtista()
                boxImagArtista.Image = Image.FromFile(completarRutaImagenes(aAux._imagen))
                boxImagArtista.SizeMode = PictureBoxSizeMode.StretchImage
                checkFavorito.Checked = comprobarFavorito(usuario, aAux._idArtista)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        End If
        'Borramos grid de albumes y canciones por la nueva seleccion del artista'
        'Borramos las duraciones y las imagenes y deshabilitamos el boton de reproducir'
        gridAlbumes.Rows.Clear()
        gridCanciones.Rows.Clear()
        txtDuracionAlbum.Clear()
        txtDurCancion.Clear()
        btnReproducir.Enabled = False
        boxImagAlbum.Image = Nothing
        'rellenamos grid de Albumes'
        Dim alAux As Album = New Album
        Try
            alAux.leerPorCantante(artSeleccionado, Pantalla_BBDD.TbxRuta.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each al As Album In alAux._albumDAO._listaAlbumes
            gridAlbumes.Rows.Add(al._idAlbum, al._nombre, al._fecha, al._artista)
        Next

    End Sub
    Private Sub gridAlbumes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridAlbumes.CellContentClick
        'Seleccionamos el album'
        Dim aAux As Album
        Dim albumSeleccionado As Integer
        Dim duracionAlbum As Integer
        Dim dur As String
        If gridAlbumes.SelectedRows IsNot Nothing Then
            aAux = New Album(gridAlbumes.Rows(e.RowIndex).Cells(0).Value)
            albumSeleccionado = aAux._idAlbum
            Try
                aAux.leerAlbum()
                boxImagAlbum.Image = Image.FromFile(completarRutaImagenes(aAux._imagen))
                boxImagAlbum.SizeMode = PictureBoxSizeMode.StretchImage
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        'Borramos grid de canciones y duracion por la nueva seleccion del album'
        duracionAlbum = 0
        btnReproducir.Enabled = False
        gridCanciones.Rows.Clear()
        txtDuracionAlbum.Clear()
        txtDurCancion.Clear()
        'rellenamos el grid de canciones'
        Dim cAux As Cancion = New Cancion
        Try
            cAux.leerPorAlbum(albumSeleccionado, Pantalla_BBDD.TbxRuta.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each c As Cancion In cAux._cancionDAO._listaCanciones
            gridCanciones.Rows.Add(c._idCancion, c._nombre, c._album, c._duracion)
            duracionAlbum += c._duracion
        Next
        dur = conversor(duracionAlbum)
        txtDuracionAlbum.Text = dur
    End Sub
    Private Sub gridCanciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridCanciones.CellContentClick
        Dim c As Cancion
        Dim duracion As String
        txtDurCancion.Clear()
        If gridCanciones.SelectedRows IsNot Nothing Then
            c = New Cancion(gridCanciones.Rows(e.RowIndex).Cells(0).Value)
            Try
                c.leerCancion()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            duracion = conversor(c._duracion)
            btnReproducir.Enabled = True
            txtDurCancion.Text = duracion
            cancionSonando = c._idCancion
        End If
    End Sub

    'comprobar si el artista es favorito'
    Public Function comprobarFavorito(ByRef usuario As String, ByRef artista As Integer) As Boolean
        Dim existe As Boolean
        Dim artFav As ArtistaFavorito = New ArtistaFavorito(usuario, artista)
        existe = artFav.comprobarFavorito(Pantalla_BBDD.TbxRuta.Text)
        Return existe

    End Function

    'Seleccionar al artista como favorito o eliminarlo'
    Private Sub checkFavorito_CheckedChanged(sender As Object, e As EventArgs) Handles checkFavorito.Click
        Dim artFav As ArtistaFavorito = New ArtistaFavorito(usuario, artSeleccionado)

        If checkFavorito.Checked = True Then
            artFav._fecha = Format(Today, "dd/MM/yyyy")
            artFav.insertar()
        Else
            artFav.delete()
        End If
    End Sub

    Private Sub btnReproducir_Click(sender As Object, e As EventArgs) Handles btnReproducir.Click
        Dim reproduccion As Reproduccion = New Reproduccion
        Dim contador As Integer = 0
        reproduccion._cancion = cancionSonando
        contador = reproduccion.contarReproducciones(Pantalla_BBDD.TbxRuta.Text)
        reproduccion._id = contador + 1
        reproduccion._usuario = usuario
        reproduccion._fecha = Format(Today, "dd/MM/yyyy")

        Try
            If reproduccion.insertar() <> 1 Then
                MessageBox.Show("Insert Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        gridReproducciones.Rows.Add(reproduccion._id, reproduccion._cancion, reproduccion._fecha)
        pctCancionSonando.Image = boxImagAlbum.Image
        pctCancionSonando.SizeMode = PictureBoxSizeMode.StretchImage
        Dim cAux As Cancion = reproduccion.obtenerCancion(reproduccion._cancion, Pantalla_BBDD.TbxRuta.Text)
        txttituloCancion.Text = cAux._nombre
        Timer1.Start()
        TrackBar1.Maximum = cAux._duracion
        Button1.Text = "STOP"

        'actualizamos las listas de cantantes y canciones mas escuchados y usuarios mas activos'
        mostrarFullTop()
        mostrarTopCanciones()
        mostrarTopUsuarios()
        mostrarTopFavoritos()

    End Sub

    'PÁGINA DE REPRODUCIR'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TrackBar1.Value = TrackBar1.Maximum Then
            Timer1.Stop()
            Button1.Text = "PLAY"
        Else
            TrackBar1.Value += 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled = True Then
            Timer1.Stop()
            Button1.Text = "PLAY"
        Else
            Timer1.Start()
            Button1.Text = "STOP"
        End If
    End Sub

    'PAGINA DE EXPLORAR'
    Private Sub comboFiltrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboFiltrar.SelectedIndexChanged

        Dim pais As String
        If comboFiltrar.SelectedItem = "" Then
            mostrarFullTop()
        Else
            pais = comboFiltrar.SelectedItem
            mostrarTopFiltrado(pais)
        End If

    End Sub
    Public Sub mostrarFullTop()
        gridFullTop.Rows.Clear()
        comboFiltrar.SelectedItem = ""
        Dim art As Artista = New Artista
        Dim col, aux As Collection
        col = art.mostrarTop(Pantalla_BBDD.TbxRuta.Text)
        For Each aux In col
            gridFullTop.Rows.Add(aux(1).ToString, aux(2).ToString, aux(3).ToString)
        Next
    End Sub

    Public Sub mostrarTopFiltrado(pais As String)
        gridFullTop.Rows.Clear()
        Dim art As Artista = New Artista
        Dim col, aux As Collection
        col = art.mostrarTopFiltrado(Pantalla_BBDD.TbxRuta.Text, pais)
        For Each aux In col
            gridFullTop.Rows.Add(aux(1).ToString, aux(2).ToString, pais)
        Next
    End Sub

    Public Sub mostrarTopCanciones()
        gridTopCanciones.Rows.Clear()
        Dim cancion As Cancion = New Cancion
        Dim col, aux As Collection
        col = cancion.topCanciones(Pantalla_BBDD.TbxRuta.Text)
        For Each aux In col
            gridTopCanciones.Rows.Add(aux(1).ToString, aux(2).ToString)
        Next
    End Sub
    Public Sub mostrarTopUsuarios()
        gridTopUsuarios.Rows.Clear()
        Dim usuario As Usuario = New Usuario
        Dim tiempo As String
        Dim col, aux As Collection
        col = usuario.topUsuarios(Pantalla_BBDD.TbxRuta.Text)
        For Each aux In col
            tiempo = conversor(aux(2).ToString)
            gridTopUsuarios.Rows.Add(aux(1).ToString, tiempo)
        Next
    End Sub

    'PÁGINA DE TUS ESTADÍSTICAS'
    Public Sub mostrarTopFavoritos()
        gridTopFavoritos.Rows.Clear()
        Dim tiempo As String
        Dim artFav As ArtistaFavorito = New ArtistaFavorito
        artFav._usuario = usuario
        Dim col, aux As Collection
        col = artFav.mostrarTopFavoritos(Pantalla_BBDD.TbxRuta.Text)
        For Each aux In col
            tiempo = conversor(aux(2).ToString)
            gridTopFavoritos.Rows.Add(aux(1).ToString, tiempo)
        Next
    End Sub

    Public Sub mostrarPorFechas()
        gridPorFechas.Rows.Clear()
        Dim inicial As Date = pickerFechaInic.Value
        Dim final As Date = pickerFechaFin.Value
        Dim a As Artista = New Artista
        Dim col, aux As Collection
        col = a.masEscuchadosFechas(Pantalla_BBDD.TbxRuta.Text, usuario, inicial, final)
        For Each aux In col
            gridPorFechas.Rows.Add(aux(1).ToString, aux(2).ToString)
        Next
    End Sub

    Private Sub btnFiltrarFechas_Click(sender As Object, e As EventArgs) Handles btnFiltrarFechas.Click
        mostrarPorFechas()
    End Sub
End Class