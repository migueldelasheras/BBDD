Public Class ArtistaDAO
    Public ReadOnly Property _listaArtistas As Collection

    Public Sub New()
        Me._listaArtistas = New Collection
    End Sub

    Public Function delete(ByVal a As Artista) As Integer
        Return AgenteBD.getAgente().Modificar("DELETE FROM ARTISTAS WHERE IdArtista=" & a._idArtista & ";")
    End Function

    Public Function insert(ByVal a As Artista) As Integer
        Return AgenteBD.getAgente().Modificar("INSERT INTO ARTISTAS VALUES (" & a._idArtista & ", '" & a._nombre & "', '" & a._pais & "', '" & a._imagen & "');")
    End Function

    Public Function update(ByVal a As Artista) As Integer
        Return AgenteBD.getAgente().Modificar("UPDATE ARTISTAS SET Nombre='" & a._nombre & "', Pais='" & a._pais & "', Imagen='" & a._imagen & "' WHERE idArtista=" & a._idArtista & ";")
    End Function

    Public Sub leerTodos(ruta As String)
        Dim a As Artista
        Dim col, aux As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT * FROM ARTISTAS ORDER BY idArtista")
        For Each aux In col
            a = New Artista(aux(1).ToString)
            a._nombre = aux(2).ToString
            a._pais = aux(3).ToString
            a._imagen = aux(4).ToString
            Me._listaArtistas.Add(a)
        Next
    End Sub

    Public Sub leer(ByRef a As Artista)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.getAgente.leer("SELECT * FROM Artistas WHERE idArtista= " & a._idArtista & ";")
        For Each aux In col
            a._nombre = aux(2).ToString
            a._pais = aux(3).ToString
            a._imagen = aux(4).ToString
        Next
    End Sub

    Public Function mostrarTop(ruta As String) As Collection
        Dim col As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT ARTISTAS.Nombre, Count(REPRODUCCIONES.Cancion) AS CuentaDeCancion, ARTISTAS.Pais
FROM (ARTISTAS INNER JOIN (ALBUMES INNER JOIN CANCIONES ON ALBUMES.IdAlbum = CANCIONES.Album) ON ARTISTAS.IdArtista = ALBUMES.Artista) INNER JOIN REPRODUCCIONES ON CANCIONES.IdCancion = REPRODUCCIONES.Cancion
GROUP BY ARTISTAS.Nombre, ARTISTAS.Pais
ORDER BY Count(REPRODUCCIONES.Cancion) DESC;")
        Return col
    End Function

    Public Function mostrarTopFiltrado(ruta As String, pais As String) As Collection
        Dim col As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT ARTISTAS.Nombre, Count(REPRODUCCIONES.Cancion) AS CuentaDeCancion
FROM (ARTISTAS INNER JOIN (ALBUMES INNER JOIN CANCIONES ON ALBUMES.IdAlbum = CANCIONES.Album) ON ARTISTAS.IdArtista = ALBUMES.Artista) INNER JOIN REPRODUCCIONES ON CANCIONES.IdCancion = REPRODUCCIONES.Cancion
WHERE (((ARTISTAS.Pais)='" & pais & "'))
GROUP BY ARTISTAS.Nombre
ORDER BY Count(REPRODUCCIONES.Cancion) DESC;")
        Return col
    End Function

    Public Function MasEscuchadosFechas(ruta As String, usuario As String, finicial As Date, ffinal As Date) As Collection
        Dim col As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT ARTISTAS.Nombre, Count(REPRODUCCIONES.Fecha) AS CuentaDeFecha
FROM ARTISTAS INNER JOIN (ALBUMES INNER JOIN (CANCIONES INNER JOIN (USUARIOS INNER JOIN REPRODUCCIONES ON USUARIOS.Email = REPRODUCCIONES.Usuario) ON CANCIONES.IdCancion = REPRODUCCIONES.Cancion) ON ALBUMES.IdAlbum = CANCIONES.Album) ON ARTISTAS.IdArtista = ALBUMES.Artista
WHERE (((REPRODUCCIONES.Fecha)<=#" & ffinal & "# And (REPRODUCCIONES.Fecha)>=#" & finicial & "#))
GROUP BY ARTISTAS.Nombre, REPRODUCCIONES.Usuario
HAVING (((REPRODUCCIONES.Usuario)='" & usuario & "'))
ORDER BY Count(REPRODUCCIONES.Fecha) DESC;")
        Return col
    End Function

End Class
