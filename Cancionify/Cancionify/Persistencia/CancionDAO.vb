Public Class CancionDAO
    Public ReadOnly Property _listaCanciones As Collection
    Public Sub New()
        Me._listaCanciones = New Collection
    End Sub
    Public Function delete(ByVal c As Cancion) As Integer
        Return AgenteBD.getAgente().Modificar("DELETE FROM Canciones WHERE idCancion=" & c._idCancion & ";")
    End Function

    Public Function insert(ByVal c As Cancion) As Integer
        Return AgenteBD.getAgente.Modificar("INSERT INTO Canciones VALUES (" & c._idCancion & ", '" & c._nombre & "', " & c._album & ", " & c._duracion & ");")
    End Function

    Public Function update(ByVal c As Cancion) As Integer
        Return AgenteBD.getAgente().Modificar("UPDATE Canciones SET nombre='" & c._nombre & "', album=" & c._album & ", duracion=" & c._duracion & " WHERE idCancion=" & c._idCancion & ";")
    End Function

    Public Sub leerTodas(ruta As String)
        Dim c As Cancion
        Dim col, aux As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT * FROM Canciones ORDER BY idCancion")
        For Each aux In col
            c = New Cancion(aux(1).ToString)
            c._nombre = aux(2).ToString
            c._album = aux(3).ToString
            c._duracion = aux(4).ToString
            Me._listaCanciones.Add(c)
        Next
    End Sub

    Public Sub leer(ByRef c As Cancion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.getAgente.leer("SELECT * FROM Canciones WHERE idCancion= " & c._idCancion & ";")
        For Each aux In col
            c._nombre = aux(2).ToString
            c._album = aux(3).ToString
            c._duracion = aux(4).ToString
        Next
    End Sub
    Public Sub leerPorAlbum(ByRef a As Integer, ruta As String)
        Dim c As Cancion
        Dim col, aux As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT * FROM Canciones WHERE Album=" & a & ";")
        For Each aux In col
            c = New Cancion(aux(1).ToString)
            c._nombre = aux(2).ToString
            c._album = aux(3).ToString
            c._duracion = aux(4).ToString
            Me._listaCanciones.Add(c)
        Next
    End Sub

    Public Function topCanciones(ruta As String) As Collection
        Dim col As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT CANCIONES.Nombre, Count(REPRODUCCIONES.Cancion) AS CuentaDeCancion
FROM CANCIONES INNER JOIN REPRODUCCIONES ON CANCIONES.IdCancion = REPRODUCCIONES.Cancion
GROUP BY CANCIONES.Nombre
ORDER BY Count(REPRODUCCIONES.Cancion) DESC;")
        Return col
    End Function

End Class
