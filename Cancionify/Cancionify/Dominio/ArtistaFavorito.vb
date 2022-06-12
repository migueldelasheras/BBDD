Public Class ArtistaFavorito
    Public Property _usuario As String
    Public Property _artista As Integer
    Public Property _fecha As Date
    Public Property _ArtistaFavoritoDAO As ArtistaFavoritoDAO

    Public Sub New()
        Me._ArtistaFavoritoDAO = New ArtistaFavoritoDAO
    End Sub
    Public Sub New(usuario As String, artista As Integer)
        Me._ArtistaFavoritoDAO = New ArtistaFavoritoDAO
        Me._usuario = usuario
        Me._artista = artista
    End Sub
    Public Sub leerTodosArtistasFavoritos(ruta As String)
        Me._ArtistaFavoritoDAO.leerTodos(ruta)
    End Sub
    Public Sub leerArtistaFavorito()
        Me._ArtistaFavoritoDAO.leer(Me)
    End Sub
    Public Sub leerPorUsuario(usuario As String, ruta As String)
        Me._ArtistaFavoritoDAO.leerPorUsuario(ruta, usuario)
    End Sub
    Public Function insertar() As Integer
        Return Me._ArtistaFavoritoDAO.insert(Me)
    End Function

    Public Function delete() As Integer
        Return Me._ArtistaFavoritoDAO.delete(Me)
    End Function

    Public Function actualizar() As Integer
        Return Me._ArtistaFavoritoDAO.update(Me)
    End Function

    Public Function comprobarFavorito(ByRef ruta As String) As Boolean
        Return Me._ArtistaFavoritoDAO.comprobarFavorito(ruta, Me._usuario, Me._artista)
    End Function
    Public Function mostrarTopFavoritos(ruta As String) As Collection
        Return Me._ArtistaFavoritoDAO.mostrarTopFavoritos(ruta, _usuario)
    End Function
End Class
