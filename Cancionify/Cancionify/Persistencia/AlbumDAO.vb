Public Class AlbumDAO
    Public ReadOnly Property _listaAlbumes As Collection

    Public Sub New()
        Me._listaAlbumes = New Collection
    End Sub

    Public Function delete(ByVal a As Album) As Integer
        Return AgenteBD.getAgente().Modificar("DELETE FROM Albumes WHERE IdAlbum=" & a._idAlbum & ";")
    End Function

    Public Function insert(ByVal a As Album) As Integer
        Return AgenteBD.getAgente().Modificar("INSERT INTO Albumes VALUES (" & a._idAlbum & ", '" & a._nombre & "', '" & a._fecha & "', " & a._artista & ", '" & a._imagen & "');")
    End Function

    Public Function update(ByVal a As Album) As Integer
        Return AgenteBD.getAgente().Modificar("UPDATE Albumes SET Nombre='" & a._nombre & "', Fecha='" & a._fecha & "', Artista= " & a._artista & ", Portada='" & a._imagen & "' WHERE IdAlbum=" & a._idAlbum & ";")
    End Function

    Public Sub leerTodos(ruta As String)
        Dim a As Album
        Dim col, aux As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT * FROM Albumes ORDER BY idAlbum")
        For Each aux In col
            a = New Album(aux(1).ToString)
            a._nombre = aux(2).ToString
            a._fecha = aux(3).ToString
            a._artista = aux(4).ToString
            a._imagen = aux(5).ToString
            Me._listaAlbumes.Add(a)
        Next
    End Sub

    Public Sub leer(ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.getAgente.leer("SELECT * FROM Albumes WHERE IdAlbum= " & a._idAlbum & ";")
        For Each aux In col
            a._nombre = aux(2).ToString
            a._fecha = aux(3).ToString
            a._artista = aux(4).ToString
            a._imagen = aux(5).ToString
        Next
    End Sub

    Public Sub leerPorCantante(ByRef a As Integer, ruta As String)
        Dim al As Album
        Dim col, aux As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT * FROM Albumes WHERE Artista= " & a & ";")
        For Each aux In col
            al = New Album(aux(1).ToString)
            al._nombre = aux(2).ToString
            al._fecha = aux(3).ToString
            al._artista = aux(4).ToString
            al._imagen = aux(5).ToString
            Me._listaAlbumes.Add(al)
        Next
    End Sub



End Class
