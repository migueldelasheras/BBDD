Public Class ReproduccionDAO

    Public ReadOnly Property _listaReproducciones As Collection

    Public Sub New()
        Me._listaReproducciones = New Collection
    End Sub
    Public Function delete(ByVal r As Reproduccion) As Integer
        Return AgenteBD.getAgente().Modificar("DELETE FROM REPRODUCCIONES WHERE IdReproduccion=" & r._id & ";")
    End Function

    Public Function insert(ByVal r As Reproduccion) As Integer
        Return AgenteBD.getAgente().Modificar("INSERT INTO REPRODUCCIONES VALUES (" & r._id & ", '" & r._usuario & "', " & r._cancion & ", '" & r._fecha & "');")
    End Function

    Public Function update(ByVal r As Reproduccion) As Integer
        Return AgenteBD.getAgente().Modificar("UPDATE REPRODUCCIONES SET Usuario='" & r._usuario & "', Cancion=" & r._cancion & ", fecha='" & r._fecha & "' WHERE idReproduccion=" & r._id & ";")
    End Function

    Public Sub leerTodas(ruta As String, ByRef usuario As String)
        Dim r As Reproduccion
        Dim col, aux As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT * FROM REPRODUCCIONES WHERE usuario='" & usuario & "' ORDER BY Fecha")
        For Each aux In col
            r = New Reproduccion(aux(1).ToString)
            r._usuario = aux(2).ToString
            r._cancion = aux(3).ToString
            r._fecha = aux(4).ToString
            Me._listaReproducciones.Add(r)
        Next
    End Sub
    Public Function contarReproducciones(ruta As String) As Integer
        Dim contador As Integer
        Dim col As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT * FROM Reproducciones ORDER BY Fecha")
        contador = col.Count
        Return contador
    End Function

    Public Sub leer(ByRef r As Reproduccion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.getAgente.leer("SELECT * FROM Artistas WHERE idReproduccion= " & r._id & ";")
        For Each aux In col
            r._usuario = aux(2).ToString
            r._cancion = aux(3).ToString
            r._fecha = aux(4).ToString
        Next
    End Sub
    Public Function obtenerCancion(ByRef cancion As Integer, ruta As String) As Cancion
        Dim titulo As Cancion = New Cancion
        Dim col, aux As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT * FROM CANCIONES WHERE IdCancion=" & cancion & ";")
        For Each aux In col
            titulo._idCancion = aux(1).ToString
            titulo._nombre = aux(2).ToString
            titulo._album = aux(3).ToString
            titulo._duracion = aux(4).ToString
        Next
        Return titulo
    End Function
End Class
