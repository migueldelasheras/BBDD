Public Class Album

    Public Property _idAlbum As Integer
    Public Property _nombre As String
    Public Property _fecha As Date
    Public Property _artista As String
    Public Property _imagen As String
    Public ReadOnly Property _albumDAO As AlbumDAO

    Public Sub New()
        Me._albumDAO = New AlbumDAO
    End Sub

    Public Sub New(idAlbum As Integer)
        Me._albumDAO = New AlbumDAO
        Me._idAlbum = idAlbum
    End Sub

    Public Sub leerTodosAlbumes(ruta As String)
        Me._albumDAO.leerTodos(ruta)
    End Sub

    Public Sub leerAlbum()
        Me._albumDAO.leer(Me)
    End Sub

    Public Sub leerPorCantante(a As Integer, ruta As String)
        Me._albumDAO.leerPorCantante(a, ruta)
    End Sub

    Public Function insertar() As Integer
        Return Me._albumDAO.insert(Me)
    End Function

    Public Function delete() As Integer
        Return Me._albumDAO.delete(Me)
    End Function

    Public Function actualizar() As Integer
        Return Me._albumDAO.update(Me)
    End Function



End Class
