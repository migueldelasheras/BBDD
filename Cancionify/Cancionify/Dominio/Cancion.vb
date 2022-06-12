Public Class Cancion
    Public Property _idCancion As Integer
    Public Property _nombre As String
    Public Property _album As Integer
    Public Property _duracion As Integer

    Public ReadOnly _cancionDAO As CancionDAO


    Public Sub New()
        Me._cancionDAO = New CancionDAO
    End Sub

    Public Sub New(idCancion As Integer)
        Me._cancionDAO = New CancionDAO
        Me._idCancion = idCancion
    End Sub

    Public Sub leerTodasCanciones(ruta As String)
        Me._cancionDAO.leerTodas(ruta)
    End Sub
    Public Sub leerPorAlbum(a As Integer, ruta As String)
        Me._cancionDAO.leerPorAlbum(a, ruta)
    End Sub

    Public Sub leerCancion()
        Me._cancionDAO.leer(Me)
    End Sub

    Public Function insertar() As Integer
        Return Me._cancionDAO.insert(Me)
    End Function

    Public Function delete() As Integer
        Return Me._cancionDAO.delete(Me)
    End Function

    Public Function actualizar() As Integer
        Return Me._cancionDAO.update(Me)
    End Function

    Public Function topCanciones(ruta As String) As Collection
        Return Me._cancionDAO.topCanciones(ruta)
    End Function
End Class
