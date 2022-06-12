Public Class ArtistaFavoritoDAO

    Public ReadOnly Property _listaArtistas As Collection

    Public Sub New()
        Me._listaArtistas = New Collection
    End Sub

    Public Function delete(ByVal a As ArtistaFavorito) As Integer
        Return AgenteBD.getAgente().Modificar("DELETE FROM ARTISTAS_FAVORITOS WHERE Usuario='" & a._usuario & "' AND Artista=" & a._artista & ";")
    End Function

    Public Function insert(ByVal a As ArtistaFavorito) As Integer
        Return AgenteBD.getAgente().Modificar("INSERT INTO ARTISTAS_FAVORITOS VALUES ('" & a._usuario & "', " & a._artista & ", '" & a._fecha & "');")
    End Function

    Public Function update(ByVal a As ArtistaFavorito) As Integer
        Return AgenteBD.getAgente().Modificar("UPDATE ARTISTAS_FAVORITOS SET fecha='" & a._fecha & "' WHERE Usuario='" & a._usuario & "' AND Artista=" & a._artista & ";")
    End Function

    Public Sub leerTodos(ruta As String)
        Dim a As ArtistaFavorito
        Dim col, aux As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT * FROM ARTISTAS_FAVORITOS ORDER BY Artista")
        For Each aux In col
            a = New ArtistaFavorito(aux(1).ToString, aux(2).ToString)
            a._fecha = aux(3).ToString
            Me._listaArtistas.Add(a)
        Next
    End Sub

    Public Sub leerPorUsuario(ruta As String, ByRef usuario As String)
        Dim a As ArtistaFavorito
        Dim col, aux As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT * FROM ARTISTAS_FAVORITOS WHERE Usuario='" & usuario & "';")
        For Each aux In col
            a = New ArtistaFavorito(aux(1).ToString, aux(2).ToString)
            a._fecha = aux(3).ToString
            Me._listaArtistas.Add(a)
        Next
    End Sub

    Public Sub leer(ByRef a As ArtistaFavorito)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.getAgente.leer("SELECT * FROM Artistas_Favoritos WHERE Usuario='" & a._usuario & "' AND Artista=" & a._artista & ";")
        For Each aux In col
            a._fecha = aux(3).ToString
        Next
    End Sub

    'funcion para saber si es artista favorito del usuario seleccionado en la pagina principal'
    Public Function comprobarFavorito(ruta As String, ByRef usuario As String, ByRef artista As Integer) As Boolean
        Dim existe As Integer
        Dim col As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT * FROM ARTISTAS_FAVORITOS WHERE Usuario='" & usuario & "' AND Artista=" & artista & ";")
        existe = col.Count
        If existe > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function mostrarTopFavoritos(ruta As String, usuario As String) As Collection
        Dim col As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT ARTISTAS.Nombre, Sum(CANCIONES.Duracion) AS SumaDeDuracion
FROM ((ARTISTAS INNER JOIN (ALBUMES INNER JOIN CANCIONES ON ALBUMES.IdAlbum = CANCIONES.Album) ON ARTISTAS.IdArtista = ALBUMES.Artista) INNER JOIN ARTISTAS_FAVORITOS ON ARTISTAS.IdArtista = ARTISTAS_FAVORITOS.Artista) INNER JOIN REPRODUCCIONES ON CANCIONES.IdCancion = REPRODUCCIONES.Cancion
WHERE (((REPRODUCCIONES.Usuario)='" & usuario & "') AND ((ARTISTAS_FAVORITOS.Usuario)='" & usuario & "'))
GROUP BY ARTISTAS.Nombre, ARTISTAS.IdArtista
ORDER BY Sum(CANCIONES.Duracion) DESC;")
        Return col
    End Function
End Class
