<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pantalla_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla_Principal))
        Me.tbMenu = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.boxImagAlbum = New System.Windows.Forms.PictureBox()
        Me.boxImagArtista = New System.Windows.Forms.PictureBox()
        Me.checkFavorito = New System.Windows.Forms.CheckBox()
        Me.txtDurCancion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnReproducir = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDuracionAlbum = New System.Windows.Forms.TextBox()
        Me.gridCanciones = New System.Windows.Forms.DataGridView()
        Me.IDcancion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCancion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlbumCancion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DuracionCancion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridAlbumes = New System.Windows.Forms.DataGridView()
        Me.IDalbum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreAlbum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAlbum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdArtistaAlbum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridArtistas = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gridReproducciones = New System.Windows.Forms.DataGridView()
        Me.IdReproduccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrReproduccion = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.txttituloCancion = New System.Windows.Forms.Label()
        Me.pctCancionSonando = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gridTopUsuarios = New System.Windows.Forms.DataGridView()
        Me.emailUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gridTopCanciones = New System.Windows.Forms.DataGridView()
        Me.NomCanc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReproduccionesCan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.comboFiltrar = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gridFullTop = New System.Windows.Forms.DataGridView()
        Me.NomArtista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NReproducciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaísArtista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnFiltrarFechas = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.pickerFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.pickerFechaInic = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.gridPorFechas = New System.Windows.Forms.DataGridView()
        Me.nomArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NReprod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.gridTopFavoritos = New System.Windows.Forms.DataGridView()
        Me.NombArtFav = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoArtFav = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grAlbumes = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarAlbum = New System.Windows.Forms.Button()
        Me.PctAlbum = New System.Windows.Forms.PictureBox()
        Me.btnEliminarAlbum = New System.Windows.Forms.Button()
        Me.btnModificarAlbum = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAñadirAlbum = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtArtistaAlbum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtIdAlbum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFechaAlbum = New System.Windows.Forms.TextBox()
        Me.TxtNombreAlbum = New System.Windows.Forms.TextBox()
        Me.lstAlbumes = New System.Windows.Forms.ListBox()
        Me.grCanciones = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarCancion = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEliminarCancion = New System.Windows.Forms.Button()
        Me.lstCanciones = New System.Windows.Forms.ListBox()
        Me.btnModificarCancion = New System.Windows.Forms.Button()
        Me.txtDuracionCancion = New System.Windows.Forms.TextBox()
        Me.btnAñadirCancion = New System.Windows.Forms.Button()
        Me.txtcancion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNombreCancion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAlbumCancion = New System.Windows.Forms.TextBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.grboxArtistas = New System.Windows.Forms.GroupBox()
        Me.PctArtista = New System.Windows.Forms.PictureBox()
        Me.btnLimpiarArt = New System.Windows.Forms.Button()
        Me.btnEliminarArt = New System.Windows.Forms.Button()
        Me.btnModificarArt = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPaisArt = New System.Windows.Forms.TextBox()
        Me.btnAñadirArt = New System.Windows.Forms.Button()
        Me.txtNombreArt = New System.Windows.Forms.TextBox()
        Me.txtIdArt = New System.Windows.Forms.TextBox()
        Me.lstArtistas = New System.Windows.Forms.ListBox()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tbMenu.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.boxImagAlbum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boxImagArtista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCanciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAlbumes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridArtistas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.gridReproducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrReproduccion.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCancionSonando, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.gridTopUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTopCanciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFullTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.gridPorFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTopFavoritos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.grAlbumes.SuspendLayout()
        CType(Me.PctAlbum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grCanciones.SuspendLayout()
        Me.grboxArtistas.SuspendLayout()
        CType(Me.PctArtista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbMenu
        '
        Me.tbMenu.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tbMenu.Controls.Add(Me.TabPage2)
        Me.tbMenu.Controls.Add(Me.TabPage3)
        Me.tbMenu.Controls.Add(Me.TabPage4)
        Me.tbMenu.Controls.Add(Me.TabPage5)
        Me.tbMenu.Controls.Add(Me.TabPage1)
        Me.tbMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbMenu.HotTrack = True
        Me.tbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tbMenu.Name = "tbMenu"
        Me.tbMenu.SelectedIndex = 0
        Me.tbMenu.Size = New System.Drawing.Size(812, 417)
        Me.tbMenu.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GrayText
        Me.TabPage2.Controls.Add(Me.boxImagAlbum)
        Me.TabPage2.Controls.Add(Me.boxImagArtista)
        Me.TabPage2.Controls.Add(Me.checkFavorito)
        Me.TabPage2.Controls.Add(Me.txtDurCancion)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.btnReproducir)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtDuracionAlbum)
        Me.TabPage2.Controls.Add(Me.gridCanciones)
        Me.TabPage2.Controls.Add(Me.gridAlbumes)
        Me.TabPage2.Controls.Add(Me.gridArtistas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(804, 388)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tu biblioteca"
        '
        'boxImagAlbum
        '
        Me.boxImagAlbum.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxImagAlbum.Location = New System.Drawing.Point(282, 281)
        Me.boxImagAlbum.Name = "boxImagAlbum"
        Me.boxImagAlbum.Size = New System.Drawing.Size(143, 101)
        Me.boxImagAlbum.TabIndex = 10
        Me.boxImagAlbum.TabStop = False
        '
        'boxImagArtista
        '
        Me.boxImagArtista.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxImagArtista.Location = New System.Drawing.Point(42, 281)
        Me.boxImagArtista.Name = "boxImagArtista"
        Me.boxImagArtista.Size = New System.Drawing.Size(143, 101)
        Me.boxImagArtista.TabIndex = 9
        Me.boxImagArtista.TabStop = False
        '
        'checkFavorito
        '
        Me.checkFavorito.AutoSize = True
        Me.checkFavorito.Location = New System.Drawing.Point(685, 30)
        Me.checkFavorito.Name = "checkFavorito"
        Me.checkFavorito.Size = New System.Drawing.Size(96, 17)
        Me.checkFavorito.TabIndex = 8
        Me.checkFavorito.Text = "Artista Favorito"
        Me.checkFavorito.UseVisualStyleBackColor = True
        '
        'txtDurCancion
        '
        Me.txtDurCancion.Location = New System.Drawing.Point(685, 126)
        Me.txtDurCancion.Name = "txtDurCancion"
        Me.txtDurCancion.Size = New System.Drawing.Size(100, 20)
        Me.txtDurCancion.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(682, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Duración de canción"
        '
        'btnReproducir
        '
        Me.btnReproducir.Enabled = False
        Me.btnReproducir.Location = New System.Drawing.Point(676, 305)
        Me.btnReproducir.Name = "btnReproducir"
        Me.btnReproducir.Size = New System.Drawing.Size(120, 29)
        Me.btnReproducir.TabIndex = 5
        Me.btnReproducir.Text = "Reproducir"
        Me.btnReproducir.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(682, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Duración del Álbum"
        '
        'txtDuracionAlbum
        '
        Me.txtDuracionAlbum.Location = New System.Drawing.Point(685, 77)
        Me.txtDuracionAlbum.Name = "txtDuracionAlbum"
        Me.txtDuracionAlbum.Size = New System.Drawing.Size(100, 20)
        Me.txtDuracionAlbum.TabIndex = 3
        '
        'gridCanciones
        '
        Me.gridCanciones.AllowUserToAddRows = False
        Me.gridCanciones.AllowUserToDeleteRows = False
        Me.gridCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCanciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDcancion, Me.NombreCancion, Me.AlbumCancion, Me.DuracionCancion})
        Me.gridCanciones.Location = New System.Drawing.Point(485, 3)
        Me.gridCanciones.MultiSelect = False
        Me.gridCanciones.Name = "gridCanciones"
        Me.gridCanciones.ReadOnly = True
        Me.gridCanciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridCanciones.Size = New System.Drawing.Size(185, 382)
        Me.gridCanciones.TabIndex = 2
        '
        'IDcancion
        '
        Me.IDcancion.HeaderText = "ID"
        Me.IDcancion.Name = "IDcancion"
        Me.IDcancion.ReadOnly = True
        Me.IDcancion.Width = 30
        '
        'NombreCancion
        '
        Me.NombreCancion.HeaderText = "Nombre"
        Me.NombreCancion.Name = "NombreCancion"
        Me.NombreCancion.ReadOnly = True
        '
        'AlbumCancion
        '
        Me.AlbumCancion.HeaderText = "Album"
        Me.AlbumCancion.Name = "AlbumCancion"
        Me.AlbumCancion.ReadOnly = True
        Me.AlbumCancion.Width = 50
        '
        'DuracionCancion
        '
        Me.DuracionCancion.HeaderText = "Duracion"
        Me.DuracionCancion.Name = "DuracionCancion"
        Me.DuracionCancion.ReadOnly = True
        Me.DuracionCancion.Width = 50
        '
        'gridAlbumes
        '
        Me.gridAlbumes.AllowUserToAddRows = False
        Me.gridAlbumes.AllowUserToDeleteRows = False
        Me.gridAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAlbumes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDalbum, Me.NombreAlbum, Me.FechaAlbum, Me.IdArtistaAlbum})
        Me.gridAlbumes.Location = New System.Drawing.Point(236, 3)
        Me.gridAlbumes.Name = "gridAlbumes"
        Me.gridAlbumes.ReadOnly = True
        Me.gridAlbumes.Size = New System.Drawing.Size(243, 272)
        Me.gridAlbumes.TabIndex = 1
        '
        'IDalbum
        '
        Me.IDalbum.HeaderText = "ID"
        Me.IDalbum.Name = "IDalbum"
        Me.IDalbum.ReadOnly = True
        Me.IDalbum.Width = 30
        '
        'NombreAlbum
        '
        Me.NombreAlbum.HeaderText = "Nombre"
        Me.NombreAlbum.Name = "NombreAlbum"
        Me.NombreAlbum.ReadOnly = True
        '
        'FechaAlbum
        '
        Me.FechaAlbum.HeaderText = "Fecha"
        Me.FechaAlbum.Name = "FechaAlbum"
        Me.FechaAlbum.ReadOnly = True
        '
        'IdArtistaAlbum
        '
        Me.IdArtistaAlbum.HeaderText = "Artista"
        Me.IdArtistaAlbum.Name = "IdArtistaAlbum"
        Me.IdArtistaAlbum.ReadOnly = True
        '
        'gridArtistas
        '
        Me.gridArtistas.AllowUserToAddRows = False
        Me.gridArtistas.AllowUserToDeleteRows = False
        Me.gridArtistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridArtistas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Pais})
        Me.gridArtistas.Location = New System.Drawing.Point(3, 3)
        Me.gridArtistas.MultiSelect = False
        Me.gridArtistas.Name = "gridArtistas"
        Me.gridArtistas.ReadOnly = True
        Me.gridArtistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridArtistas.Size = New System.Drawing.Size(227, 272)
        Me.gridArtistas.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ID.Width = 30
        '
        'Nombre
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle1
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Pais
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Pais.DefaultCellStyle = DataGridViewCellStyle2
        Me.Pais.HeaderText = "Pais"
        Me.Pais.Name = "Pais"
        Me.Pais.ReadOnly = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gridReproducciones)
        Me.TabPage3.Controls.Add(Me.GrReproduccion)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(804, 388)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Reproducir"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gridReproducciones
        '
        Me.gridReproducciones.AllowUserToAddRows = False
        Me.gridReproducciones.AllowUserToDeleteRows = False
        Me.gridReproducciones.AllowUserToOrderColumns = True
        Me.gridReproducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridReproducciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdReproduccion, Me.Cancion, Me.Fecha})
        Me.gridReproducciones.Location = New System.Drawing.Point(8, 25)
        Me.gridReproducciones.MultiSelect = False
        Me.gridReproducciones.Name = "gridReproducciones"
        Me.gridReproducciones.ReadOnly = True
        Me.gridReproducciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridReproducciones.Size = New System.Drawing.Size(271, 355)
        Me.gridReproducciones.TabIndex = 3
        '
        'IdReproduccion
        '
        Me.IdReproduccion.HeaderText = "ID"
        Me.IdReproduccion.Name = "IdReproduccion"
        Me.IdReproduccion.ReadOnly = True
        Me.IdReproduccion.Width = 30
        '
        'Cancion
        '
        Me.Cancion.HeaderText = "Cancion"
        Me.Cancion.Name = "Cancion"
        Me.Cancion.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'GrReproduccion
        '
        Me.GrReproduccion.Controls.Add(Me.Button1)
        Me.GrReproduccion.Controls.Add(Me.TrackBar1)
        Me.GrReproduccion.Controls.Add(Me.txttituloCancion)
        Me.GrReproduccion.Controls.Add(Me.pctCancionSonando)
        Me.GrReproduccion.Location = New System.Drawing.Point(285, 9)
        Me.GrReproduccion.Name = "GrReproduccion"
        Me.GrReproduccion.Size = New System.Drawing.Size(511, 371)
        Me.GrReproduccion.TabIndex = 2
        Me.GrReproduccion.TabStop = False
        Me.GrReproduccion.Text = "Está sonando:"
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(383, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "PLAY"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.TrackBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TrackBar1.Location = New System.Drawing.Point(3, 323)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(505, 45)
        Me.TrackBar1.TabIndex = 2
        '
        'txttituloCancion
        '
        Me.txttituloCancion.AutoSize = True
        Me.txttituloCancion.Location = New System.Drawing.Point(70, 284)
        Me.txttituloCancion.Name = "txttituloCancion"
        Me.txttituloCancion.Size = New System.Drawing.Size(96, 13)
        Me.txttituloCancion.TabIndex = 1
        Me.txttituloCancion.Text = "titulo de la cancion"
        '
        'pctCancionSonando
        '
        Me.pctCancionSonando.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pctCancionSonando.Location = New System.Drawing.Point(73, 16)
        Me.pctCancionSonando.Name = "pctCancionSonando"
        Me.pctCancionSonando.Size = New System.Drawing.Size(360, 255)
        Me.pctCancionSonando.TabIndex = 0
        Me.pctCancionSonando.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Historial de reproducciones"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.gridTopUsuarios)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.gridTopCanciones)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.comboFiltrar)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.gridFullTop)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(804, 388)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Explorar"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(520, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Usuarios más activos"
        '
        'gridTopUsuarios
        '
        Me.gridTopUsuarios.AllowUserToAddRows = False
        Me.gridTopUsuarios.AllowUserToDeleteRows = False
        Me.gridTopUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTopUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.emailUsuario, Me.Tiempo})
        Me.gridTopUsuarios.Location = New System.Drawing.Point(523, 25)
        Me.gridTopUsuarios.Name = "gridTopUsuarios"
        Me.gridTopUsuarios.ReadOnly = True
        Me.gridTopUsuarios.Size = New System.Drawing.Size(273, 338)
        Me.gridTopUsuarios.TabIndex = 6
        '
        'emailUsuario
        '
        Me.emailUsuario.HeaderText = "email"
        Me.emailUsuario.Name = "emailUsuario"
        Me.emailUsuario.ReadOnly = True
        Me.emailUsuario.Width = 130
        '
        'Tiempo
        '
        Me.Tiempo.HeaderText = "Tiempo"
        Me.Tiempo.Name = "Tiempo"
        Me.Tiempo.ReadOnly = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(313, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Top Canciones"
        '
        'gridTopCanciones
        '
        Me.gridTopCanciones.AllowUserToAddRows = False
        Me.gridTopCanciones.AllowUserToDeleteRows = False
        Me.gridTopCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTopCanciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomCanc, Me.ReproduccionesCan})
        Me.gridTopCanciones.Location = New System.Drawing.Point(316, 25)
        Me.gridTopCanciones.Name = "gridTopCanciones"
        Me.gridTopCanciones.ReadOnly = True
        Me.gridTopCanciones.Size = New System.Drawing.Size(201, 338)
        Me.gridTopCanciones.TabIndex = 4
        '
        'NomCanc
        '
        Me.NomCanc.HeaderText = "Nombre"
        Me.NomCanc.Name = "NomCanc"
        Me.NomCanc.ReadOnly = True
        '
        'ReproduccionesCan
        '
        Me.ReproduccionesCan.HeaderText = "NºReproducciones"
        Me.ReproduccionesCan.Name = "ReproduccionesCan"
        Me.ReproduccionesCan.ReadOnly = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(107, 345)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "FILTRAR"
        '
        'comboFiltrar
        '
        Me.comboFiltrar.FormattingEnabled = True
        Me.comboFiltrar.Items.AddRange(New Object() {"", "Alemania", "Argentina", "Australia", "Belgica", "Brasil", "Inglaterra", "Camerun", "Chile", "China", "Colombia", "España", "Estados Unidos", "Francia", "Mexico", "Portugal", "Suecia"})
        Me.comboFiltrar.Location = New System.Drawing.Point(189, 342)
        Me.comboFiltrar.Name = "comboFiltrar"
        Me.comboFiltrar.Size = New System.Drawing.Size(121, 21)
        Me.comboFiltrar.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Top Artistas"
        '
        'gridFullTop
        '
        Me.gridFullTop.AllowUserToAddRows = False
        Me.gridFullTop.AllowUserToDeleteRows = False
        Me.gridFullTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridFullTop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomArtista, Me.NReproducciones, Me.PaísArtista})
        Me.gridFullTop.Location = New System.Drawing.Point(8, 25)
        Me.gridFullTop.Name = "gridFullTop"
        Me.gridFullTop.ReadOnly = True
        Me.gridFullTop.Size = New System.Drawing.Size(302, 301)
        Me.gridFullTop.TabIndex = 0
        '
        'NomArtista
        '
        Me.NomArtista.HeaderText = "Nombre"
        Me.NomArtista.Name = "NomArtista"
        Me.NomArtista.ReadOnly = True
        '
        'NReproducciones
        '
        Me.NReproducciones.HeaderText = "NºReproducciones"
        Me.NReproducciones.Name = "NReproducciones"
        Me.NReproducciones.ReadOnly = True
        '
        'PaísArtista
        '
        Me.PaísArtista.HeaderText = "Pais"
        Me.PaísArtista.Name = "PaísArtista"
        Me.PaísArtista.ReadOnly = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnFiltrarFechas)
        Me.TabPage5.Controls.Add(Me.Label24)
        Me.TabPage5.Controls.Add(Me.Label23)
        Me.TabPage5.Controls.Add(Me.pickerFechaFin)
        Me.TabPage5.Controls.Add(Me.pickerFechaInic)
        Me.TabPage5.Controls.Add(Me.Label22)
        Me.TabPage5.Controls.Add(Me.gridPorFechas)
        Me.TabPage5.Controls.Add(Me.Label21)
        Me.TabPage5.Controls.Add(Me.gridTopFavoritos)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(804, 388)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Tus estadísticas"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnFiltrarFechas
        '
        Me.btnFiltrarFechas.Location = New System.Drawing.Point(323, 277)
        Me.btnFiltrarFechas.Name = "btnFiltrarFechas"
        Me.btnFiltrarFechas.Size = New System.Drawing.Size(96, 43)
        Me.btnFiltrarFechas.TabIndex = 8
        Me.btnFiltrarFechas.Text = "FILTRAR"
        Me.btnFiltrarFechas.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(270, 200)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 13)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Fecha final"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(270, 123)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Fecha inicial"
        '
        'pickerFechaFin
        '
        Me.pickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.pickerFechaFin.Location = New System.Drawing.Point(273, 216)
        Me.pickerFechaFin.Name = "pickerFechaFin"
        Me.pickerFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.pickerFechaFin.TabIndex = 5
        '
        'pickerFechaInic
        '
        Me.pickerFechaInic.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.pickerFechaInic.Location = New System.Drawing.Point(273, 139)
        Me.pickerFechaInic.Name = "pickerFechaInic"
        Me.pickerFechaInic.Size = New System.Drawing.Size(200, 20)
        Me.pickerFechaInic.TabIndex = 4
        Me.pickerFechaInic.Value = New Date(2021, 4, 25, 0, 0, 0, 0)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(488, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(127, 13)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Artistas  más escuchados"
        '
        'gridPorFechas
        '
        Me.gridPorFechas.AllowUserToAddRows = False
        Me.gridPorFechas.AllowUserToDeleteRows = False
        Me.gridPorFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPorFechas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomArt, Me.NReprod})
        Me.gridPorFechas.Location = New System.Drawing.Point(491, 28)
        Me.gridPorFechas.Name = "gridPorFechas"
        Me.gridPorFechas.ReadOnly = True
        Me.gridPorFechas.Size = New System.Drawing.Size(305, 352)
        Me.gridPorFechas.TabIndex = 2
        '
        'nomArt
        '
        Me.nomArt.HeaderText = "Nombre"
        Me.nomArt.Name = "nomArt"
        Me.nomArt.ReadOnly = True
        Me.nomArt.Width = 130
        '
        'NReprod
        '
        Me.NReprod.HeaderText = "Nº Reproducciones"
        Me.NReprod.Name = "NReprod"
        Me.NReprod.ReadOnly = True
        Me.NReprod.Width = 130
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(170, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Artistas Favoritos más escuchados"
        '
        'gridTopFavoritos
        '
        Me.gridTopFavoritos.AllowUserToAddRows = False
        Me.gridTopFavoritos.AllowUserToDeleteRows = False
        Me.gridTopFavoritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTopFavoritos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombArtFav, Me.TiempoArtFav})
        Me.gridTopFavoritos.Location = New System.Drawing.Point(8, 28)
        Me.gridTopFavoritos.Name = "gridTopFavoritos"
        Me.gridTopFavoritos.ReadOnly = True
        Me.gridTopFavoritos.Size = New System.Drawing.Size(244, 352)
        Me.gridTopFavoritos.TabIndex = 0
        '
        'NombArtFav
        '
        Me.NombArtFav.HeaderText = "Nombre"
        Me.NombArtFav.Name = "NombArtFav"
        Me.NombArtFav.ReadOnly = True
        '
        'TiempoArtFav
        '
        Me.TiempoArtFav.HeaderText = "Tiempo"
        Me.TiempoArtFav.Name = "TiempoArtFav"
        Me.TiempoArtFav.ReadOnly = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.grAlbumes)
        Me.TabPage1.Controls.Add(Me.grCanciones)
        Me.TabPage1.Controls.Add(Me.grboxArtistas)
        Me.TabPage1.Controls.Add(Me.btnCerrarSesion)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(804, 388)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Configuración"
        '
        'grAlbumes
        '
        Me.grAlbumes.Controls.Add(Me.btnLimpiarAlbum)
        Me.grAlbumes.Controls.Add(Me.PctAlbum)
        Me.grAlbumes.Controls.Add(Me.btnEliminarAlbum)
        Me.grAlbumes.Controls.Add(Me.btnModificarAlbum)
        Me.grAlbumes.Controls.Add(Me.Label9)
        Me.grAlbumes.Controls.Add(Me.btnAñadirAlbum)
        Me.grAlbumes.Controls.Add(Me.Label5)
        Me.grAlbumes.Controls.Add(Me.txtArtistaAlbum)
        Me.grAlbumes.Controls.Add(Me.Label6)
        Me.grAlbumes.Controls.Add(Me.Label7)
        Me.grAlbumes.Controls.Add(Me.TxtIdAlbum)
        Me.grAlbumes.Controls.Add(Me.Label8)
        Me.grAlbumes.Controls.Add(Me.txtFechaAlbum)
        Me.grAlbumes.Controls.Add(Me.TxtNombreAlbum)
        Me.grAlbumes.Controls.Add(Me.lstAlbumes)
        Me.grAlbumes.Location = New System.Drawing.Point(277, 30)
        Me.grAlbumes.Name = "grAlbumes"
        Me.grAlbumes.Size = New System.Drawing.Size(249, 355)
        Me.grAlbumes.TabIndex = 3
        Me.grAlbumes.TabStop = False
        Me.grAlbumes.Text = "ÁLbumes"
        '
        'btnLimpiarAlbum
        '
        Me.btnLimpiarAlbum.BackColor = System.Drawing.Color.Green
        Me.btnLimpiarAlbum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiarAlbum.FlatAppearance.BorderSize = 0
        Me.btnLimpiarAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarAlbum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiarAlbum.Location = New System.Drawing.Point(140, 320)
        Me.btnLimpiarAlbum.Name = "btnLimpiarAlbum"
        Me.btnLimpiarAlbum.Size = New System.Drawing.Size(103, 23)
        Me.btnLimpiarAlbum.TabIndex = 17
        Me.btnLimpiarAlbum.Text = "Limpiar"
        Me.btnLimpiarAlbum.UseVisualStyleBackColor = False
        '
        'PctAlbum
        '
        Me.PctAlbum.BackColor = System.Drawing.Color.White
        Me.PctAlbum.Location = New System.Drawing.Point(83, 221)
        Me.PctAlbum.Name = "PctAlbum"
        Me.PctAlbum.Size = New System.Drawing.Size(160, 64)
        Me.PctAlbum.TabIndex = 15
        Me.PctAlbum.TabStop = False
        '
        'btnEliminarAlbum
        '
        Me.btnEliminarAlbum.BackColor = System.Drawing.Color.Green
        Me.btnEliminarAlbum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarAlbum.FlatAppearance.BorderSize = 0
        Me.btnEliminarAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarAlbum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEliminarAlbum.Location = New System.Drawing.Point(6, 320)
        Me.btnEliminarAlbum.Name = "btnEliminarAlbum"
        Me.btnEliminarAlbum.Size = New System.Drawing.Size(103, 23)
        Me.btnEliminarAlbum.TabIndex = 16
        Me.btnEliminarAlbum.Text = "Eliminar"
        Me.btnEliminarAlbum.UseVisualStyleBackColor = False
        '
        'btnModificarAlbum
        '
        Me.btnModificarAlbum.BackColor = System.Drawing.Color.Green
        Me.btnModificarAlbum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarAlbum.FlatAppearance.BorderSize = 0
        Me.btnModificarAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarAlbum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificarAlbum.Location = New System.Drawing.Point(140, 291)
        Me.btnModificarAlbum.Name = "btnModificarAlbum"
        Me.btnModificarAlbum.Size = New System.Drawing.Size(103, 23)
        Me.btnModificarAlbum.TabIndex = 15
        Me.btnModificarAlbum.Text = "Modificar"
        Me.btnModificarAlbum.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Imagen"
        '
        'btnAñadirAlbum
        '
        Me.btnAñadirAlbum.BackColor = System.Drawing.Color.Green
        Me.btnAñadirAlbum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAñadirAlbum.FlatAppearance.BorderSize = 0
        Me.btnAñadirAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAñadirAlbum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAñadirAlbum.Location = New System.Drawing.Point(6, 291)
        Me.btnAñadirAlbum.Name = "btnAñadirAlbum"
        Me.btnAñadirAlbum.Size = New System.Drawing.Size(103, 23)
        Me.btnAñadirAlbum.TabIndex = 14
        Me.btnAñadirAlbum.Text = "Añadir"
        Me.btnAñadirAlbum.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "ID artista"
        '
        'txtArtistaAlbum
        '
        Me.txtArtistaAlbum.Location = New System.Drawing.Point(83, 195)
        Me.txtArtistaAlbum.Name = "txtArtistaAlbum"
        Me.txtArtistaAlbum.Size = New System.Drawing.Size(160, 20)
        Me.txtArtistaAlbum.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nombre"
        '
        'TxtIdAlbum
        '
        Me.TxtIdAlbum.Location = New System.Drawing.Point(83, 117)
        Me.TxtIdAlbum.Name = "TxtIdAlbum"
        Me.TxtIdAlbum.Size = New System.Drawing.Size(160, 20)
        Me.TxtIdAlbum.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "ID Album"
        '
        'txtFechaAlbum
        '
        Me.txtFechaAlbum.Location = New System.Drawing.Point(83, 169)
        Me.txtFechaAlbum.Name = "txtFechaAlbum"
        Me.txtFechaAlbum.Size = New System.Drawing.Size(160, 20)
        Me.txtFechaAlbum.TabIndex = 15
        '
        'TxtNombreAlbum
        '
        Me.TxtNombreAlbum.Location = New System.Drawing.Point(83, 143)
        Me.TxtNombreAlbum.Name = "TxtNombreAlbum"
        Me.TxtNombreAlbum.Size = New System.Drawing.Size(160, 20)
        Me.TxtNombreAlbum.TabIndex = 14
        '
        'lstAlbumes
        '
        Me.lstAlbumes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstAlbumes.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstAlbumes.FormattingEnabled = True
        Me.lstAlbumes.Location = New System.Drawing.Point(3, 16)
        Me.lstAlbumes.Name = "lstAlbumes"
        Me.lstAlbumes.ScrollAlwaysVisible = True
        Me.lstAlbumes.Size = New System.Drawing.Size(243, 95)
        Me.lstAlbumes.TabIndex = 0
        '
        'grCanciones
        '
        Me.grCanciones.Controls.Add(Me.btnLimpiarCancion)
        Me.grCanciones.Controls.Add(Me.Label10)
        Me.grCanciones.Controls.Add(Me.btnEliminarCancion)
        Me.grCanciones.Controls.Add(Me.lstCanciones)
        Me.grCanciones.Controls.Add(Me.btnModificarCancion)
        Me.grCanciones.Controls.Add(Me.txtDuracionCancion)
        Me.grCanciones.Controls.Add(Me.btnAñadirCancion)
        Me.grCanciones.Controls.Add(Me.txtcancion)
        Me.grCanciones.Controls.Add(Me.Label11)
        Me.grCanciones.Controls.Add(Me.txtNombreCancion)
        Me.grCanciones.Controls.Add(Me.Label12)
        Me.grCanciones.Controls.Add(Me.txtAlbumCancion)
        Me.grCanciones.Controls.Add(Me.label20)
        Me.grCanciones.Dock = System.Windows.Forms.DockStyle.Right
        Me.grCanciones.Location = New System.Drawing.Point(550, 30)
        Me.grCanciones.Name = "grCanciones"
        Me.grCanciones.Size = New System.Drawing.Size(251, 355)
        Me.grCanciones.TabIndex = 2
        Me.grCanciones.TabStop = False
        Me.grCanciones.Text = "Canciones"
        '
        'btnLimpiarCancion
        '
        Me.btnLimpiarCancion.BackColor = System.Drawing.Color.Green
        Me.btnLimpiarCancion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiarCancion.FlatAppearance.BorderSize = 0
        Me.btnLimpiarCancion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarCancion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiarCancion.Location = New System.Drawing.Point(140, 320)
        Me.btnLimpiarCancion.Name = "btnLimpiarCancion"
        Me.btnLimpiarCancion.Size = New System.Drawing.Size(103, 23)
        Me.btnLimpiarCancion.TabIndex = 21
        Me.btnLimpiarCancion.Text = "Limpiar"
        Me.btnLimpiarCancion.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Duración"
        '
        'btnEliminarCancion
        '
        Me.btnEliminarCancion.BackColor = System.Drawing.Color.Green
        Me.btnEliminarCancion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarCancion.FlatAppearance.BorderSize = 0
        Me.btnEliminarCancion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarCancion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEliminarCancion.Location = New System.Drawing.Point(6, 320)
        Me.btnEliminarCancion.Name = "btnEliminarCancion"
        Me.btnEliminarCancion.Size = New System.Drawing.Size(103, 23)
        Me.btnEliminarCancion.TabIndex = 20
        Me.btnEliminarCancion.Text = "Eliminar"
        Me.btnEliminarCancion.UseVisualStyleBackColor = False
        '
        'lstCanciones
        '
        Me.lstCanciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstCanciones.FormattingEnabled = True
        Me.lstCanciones.Location = New System.Drawing.Point(4, 16)
        Me.lstCanciones.Name = "lstCanciones"
        Me.lstCanciones.ScrollAlwaysVisible = True
        Me.lstCanciones.Size = New System.Drawing.Size(243, 95)
        Me.lstCanciones.TabIndex = 1
        '
        'btnModificarCancion
        '
        Me.btnModificarCancion.BackColor = System.Drawing.Color.Green
        Me.btnModificarCancion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarCancion.FlatAppearance.BorderSize = 0
        Me.btnModificarCancion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarCancion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificarCancion.Location = New System.Drawing.Point(140, 291)
        Me.btnModificarCancion.Name = "btnModificarCancion"
        Me.btnModificarCancion.Size = New System.Drawing.Size(103, 23)
        Me.btnModificarCancion.TabIndex = 19
        Me.btnModificarCancion.Text = "Modificar"
        Me.btnModificarCancion.UseVisualStyleBackColor = False
        '
        'txtDuracionCancion
        '
        Me.txtDuracionCancion.Location = New System.Drawing.Point(85, 198)
        Me.txtDuracionCancion.Name = "txtDuracionCancion"
        Me.txtDuracionCancion.Size = New System.Drawing.Size(160, 20)
        Me.txtDuracionCancion.TabIndex = 23
        '
        'btnAñadirCancion
        '
        Me.btnAñadirCancion.BackColor = System.Drawing.Color.Green
        Me.btnAñadirCancion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAñadirCancion.FlatAppearance.BorderSize = 0
        Me.btnAñadirCancion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAñadirCancion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAñadirCancion.Location = New System.Drawing.Point(6, 291)
        Me.btnAñadirCancion.Name = "btnAñadirCancion"
        Me.btnAñadirCancion.Size = New System.Drawing.Size(103, 23)
        Me.btnAñadirCancion.TabIndex = 18
        Me.btnAñadirCancion.Text = "Añadir"
        Me.btnAñadirCancion.UseVisualStyleBackColor = False
        '
        'txtcancion
        '
        Me.txtcancion.Location = New System.Drawing.Point(85, 120)
        Me.txtcancion.Name = "txtcancion"
        Me.txtcancion.Size = New System.Drawing.Size(160, 20)
        Me.txtcancion.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Album"
        '
        'txtNombreCancion
        '
        Me.txtNombreCancion.Location = New System.Drawing.Point(85, 146)
        Me.txtNombreCancion.Name = "txtNombreCancion"
        Me.txtNombreCancion.Size = New System.Drawing.Size(160, 20)
        Me.txtNombreCancion.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Nombre"
        '
        'txtAlbumCancion
        '
        Me.txtAlbumCancion.Location = New System.Drawing.Point(85, 172)
        Me.txtAlbumCancion.Name = "txtAlbumCancion"
        Me.txtAlbumCancion.Size = New System.Drawing.Size(160, 20)
        Me.txtAlbumCancion.TabIndex = 22
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(29, 123)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(59, 13)
        Me.label20.TabIndex = 19
        Me.label20.Text = "ID canción"
        '
        'grboxArtistas
        '
        Me.grboxArtistas.Controls.Add(Me.PctArtista)
        Me.grboxArtistas.Controls.Add(Me.btnLimpiarArt)
        Me.grboxArtistas.Controls.Add(Me.btnEliminarArt)
        Me.grboxArtistas.Controls.Add(Me.btnModificarArt)
        Me.grboxArtistas.Controls.Add(Me.Label4)
        Me.grboxArtistas.Controls.Add(Me.Label3)
        Me.grboxArtistas.Controls.Add(Me.Label2)
        Me.grboxArtistas.Controls.Add(Me.Label1)
        Me.grboxArtistas.Controls.Add(Me.txtPaisArt)
        Me.grboxArtistas.Controls.Add(Me.btnAñadirArt)
        Me.grboxArtistas.Controls.Add(Me.txtNombreArt)
        Me.grboxArtistas.Controls.Add(Me.txtIdArt)
        Me.grboxArtistas.Controls.Add(Me.lstArtistas)
        Me.grboxArtistas.Dock = System.Windows.Forms.DockStyle.Left
        Me.grboxArtistas.Location = New System.Drawing.Point(3, 30)
        Me.grboxArtistas.Name = "grboxArtistas"
        Me.grboxArtistas.Size = New System.Drawing.Size(249, 355)
        Me.grboxArtistas.TabIndex = 1
        Me.grboxArtistas.TabStop = False
        Me.grboxArtistas.Text = "Artistas"
        '
        'PctArtista
        '
        Me.PctArtista.BackColor = System.Drawing.Color.White
        Me.PctArtista.Location = New System.Drawing.Point(80, 195)
        Me.PctArtista.Name = "PctArtista"
        Me.PctArtista.Size = New System.Drawing.Size(163, 90)
        Me.PctArtista.TabIndex = 13
        Me.PctArtista.TabStop = False
        '
        'btnLimpiarArt
        '
        Me.btnLimpiarArt.BackColor = System.Drawing.Color.Green
        Me.btnLimpiarArt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiarArt.FlatAppearance.BorderSize = 0
        Me.btnLimpiarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarArt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiarArt.Location = New System.Drawing.Point(140, 320)
        Me.btnLimpiarArt.Name = "btnLimpiarArt"
        Me.btnLimpiarArt.Size = New System.Drawing.Size(103, 23)
        Me.btnLimpiarArt.TabIndex = 12
        Me.btnLimpiarArt.Text = "Limpiar"
        Me.btnLimpiarArt.UseVisualStyleBackColor = False
        '
        'btnEliminarArt
        '
        Me.btnEliminarArt.BackColor = System.Drawing.Color.Green
        Me.btnEliminarArt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarArt.FlatAppearance.BorderSize = 0
        Me.btnEliminarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarArt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEliminarArt.Location = New System.Drawing.Point(6, 320)
        Me.btnEliminarArt.Name = "btnEliminarArt"
        Me.btnEliminarArt.Size = New System.Drawing.Size(103, 23)
        Me.btnEliminarArt.TabIndex = 11
        Me.btnEliminarArt.Text = "Eliminar"
        Me.btnEliminarArt.UseVisualStyleBackColor = False
        '
        'btnModificarArt
        '
        Me.btnModificarArt.BackColor = System.Drawing.Color.Green
        Me.btnModificarArt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarArt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModificarArt.FlatAppearance.BorderSize = 0
        Me.btnModificarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarArt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificarArt.Location = New System.Drawing.Point(140, 291)
        Me.btnModificarArt.Name = "btnModificarArt"
        Me.btnModificarArt.Size = New System.Drawing.Size(103, 23)
        Me.btnModificarArt.TabIndex = 10
        Me.btnModificarArt.Text = "Modificar"
        Me.btnModificarArt.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Imagen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "País"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID Artista"
        '
        'txtPaisArt
        '
        Me.txtPaisArt.Location = New System.Drawing.Point(80, 169)
        Me.txtPaisArt.Name = "txtPaisArt"
        Me.txtPaisArt.Size = New System.Drawing.Size(163, 20)
        Me.txtPaisArt.TabIndex = 3
        '
        'btnAñadirArt
        '
        Me.btnAñadirArt.BackColor = System.Drawing.Color.Green
        Me.btnAñadirArt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAñadirArt.FlatAppearance.BorderSize = 0
        Me.btnAñadirArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAñadirArt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAñadirArt.Location = New System.Drawing.Point(6, 291)
        Me.btnAñadirArt.Name = "btnAñadirArt"
        Me.btnAñadirArt.Size = New System.Drawing.Size(103, 23)
        Me.btnAñadirArt.TabIndex = 9
        Me.btnAñadirArt.Text = "Añadir"
        Me.btnAñadirArt.UseVisualStyleBackColor = False
        '
        'txtNombreArt
        '
        Me.txtNombreArt.Location = New System.Drawing.Point(80, 143)
        Me.txtNombreArt.Name = "txtNombreArt"
        Me.txtNombreArt.Size = New System.Drawing.Size(163, 20)
        Me.txtNombreArt.TabIndex = 2
        '
        'txtIdArt
        '
        Me.txtIdArt.Location = New System.Drawing.Point(80, 117)
        Me.txtIdArt.Name = "txtIdArt"
        Me.txtIdArt.Size = New System.Drawing.Size(163, 20)
        Me.txtIdArt.TabIndex = 1
        '
        'lstArtistas
        '
        Me.lstArtistas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstArtistas.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstArtistas.FormattingEnabled = True
        Me.lstArtistas.Location = New System.Drawing.Point(3, 16)
        Me.lstArtistas.Name = "lstArtistas"
        Me.lstArtistas.ScrollAlwaysVisible = True
        Me.lstArtistas.Size = New System.Drawing.Size(243, 95)
        Me.lstArtistas.TabIndex = 0
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.Gray
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrarSesion.Location = New System.Drawing.Point(3, 3)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(798, 27)
        Me.btnCerrarSesion.TabIndex = 0
        Me.btnCerrarSesion.Text = "CERRAR SESIÓN"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Pantalla_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(812, 417)
        Me.Controls.Add(Me.tbMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pantalla_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pantalla_Principal"
        Me.tbMenu.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.boxImagAlbum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxImagArtista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCanciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAlbumes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridArtistas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.gridReproducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrReproduccion.ResumeLayout(False)
        Me.GrReproduccion.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCancionSonando, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.gridTopUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTopCanciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFullTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.gridPorFechas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTopFavoritos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.grAlbumes.ResumeLayout(False)
        Me.grAlbumes.PerformLayout()
        CType(Me.PctAlbum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grCanciones.ResumeLayout(False)
        Me.grCanciones.PerformLayout()
        Me.grboxArtistas.ResumeLayout(False)
        Me.grboxArtistas.PerformLayout()
        CType(Me.PctArtista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbMenu As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents grCanciones As GroupBox
    Friend WithEvents grboxArtistas As GroupBox
    Friend WithEvents lstArtistas As ListBox
    Friend WithEvents btnAñadirArt As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPaisArt As TextBox
    Friend WithEvents txtNombreArt As TextBox
    Friend WithEvents txtIdArt As TextBox
    Friend WithEvents btnLimpiarArt As Button
    Friend WithEvents btnEliminarArt As Button
    Friend WithEvents btnModificarArt As Button
    Friend WithEvents PctArtista As PictureBox
    Friend WithEvents grAlbumes As GroupBox
    Friend WithEvents lstAlbumes As ListBox
    Friend WithEvents lstCanciones As ListBox
    Friend WithEvents PctAlbum As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtArtistaAlbum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtIdAlbum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFechaAlbum As TextBox
    Friend WithEvents TxtNombreAlbum As TextBox
    Friend WithEvents btnLimpiarAlbum As Button
    Friend WithEvents btnEliminarAlbum As Button
    Friend WithEvents btnModificarAlbum As Button
    Friend WithEvents btnAñadirAlbum As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDuracionCancion As TextBox
    Friend WithEvents txtcancion As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNombreCancion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAlbumCancion As TextBox
    Friend WithEvents label20 As Label
    Friend WithEvents btnLimpiarCancion As Button
    Friend WithEvents btnEliminarCancion As Button
    Friend WithEvents btnModificarCancion As Button
    Friend WithEvents btnAñadirCancion As Button
    Friend WithEvents gridArtistas As DataGridView
    Friend WithEvents gridAlbumes As DataGridView
    Friend WithEvents gridCanciones As DataGridView
    Friend WithEvents IDcancion As DataGridViewTextBoxColumn
    Friend WithEvents NombreCancion As DataGridViewTextBoxColumn
    Friend WithEvents AlbumCancion As DataGridViewTextBoxColumn
    Friend WithEvents DuracionCancion As DataGridViewTextBoxColumn
    Friend WithEvents txtDuracionAlbum As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDurCancion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnReproducir As Button
    Friend WithEvents checkFavorito As CheckBox
    Friend WithEvents boxImagAlbum As PictureBox
    Friend WithEvents boxImagArtista As PictureBox
    Friend WithEvents IDalbum As DataGridViewTextBoxColumn
    Friend WithEvents NombreAlbum As DataGridViewTextBoxColumn
    Friend WithEvents FechaAlbum As DataGridViewTextBoxColumn
    Friend WithEvents IdArtistaAlbum As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Pais As DataGridViewTextBoxColumn
    Friend WithEvents GrReproduccion As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents gridReproducciones As DataGridView
    Friend WithEvents IdReproduccion As DataGridViewTextBoxColumn
    Friend WithEvents Cancion As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents txttituloCancion As Label
    Friend WithEvents pctCancionSonando As PictureBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents gridFullTop As DataGridView
    Friend WithEvents comboFiltrar As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents NomArtista As DataGridViewTextBoxColumn
    Friend WithEvents NReproducciones As DataGridViewTextBoxColumn
    Friend WithEvents PaísArtista As DataGridViewTextBoxColumn
    Friend WithEvents Label18 As Label
    Friend WithEvents gridTopCanciones As DataGridView
    Friend WithEvents NomCanc As DataGridViewTextBoxColumn
    Friend WithEvents ReproduccionesCan As DataGridViewTextBoxColumn
    Friend WithEvents Label19 As Label
    Friend WithEvents gridTopUsuarios As DataGridView
    Friend WithEvents emailUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Tiempo As DataGridViewTextBoxColumn
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label21 As Label
    Friend WithEvents gridTopFavoritos As DataGridView
    Friend WithEvents NombArtFav As DataGridViewTextBoxColumn
    Friend WithEvents TiempoArtFav As DataGridViewTextBoxColumn
    Friend WithEvents gridPorFechas As DataGridView
    Friend WithEvents nomArt As DataGridViewTextBoxColumn
    Friend WithEvents NReprod As DataGridViewTextBoxColumn
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents pickerFechaFin As DateTimePicker
    Friend WithEvents pickerFechaInic As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents btnFiltrarFechas As Button
End Class
