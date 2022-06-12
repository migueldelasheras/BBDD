Public Class Artista

    Public Property _idArtista As Integer
    Public Property _nombre As String
    Public Property _pais As String
    Public Property _imagen As String

    Public ReadOnly _artistaDAO As ArtistaDAO

    Public Sub New()
        Me._artistaDAO = New ArtistaDAO
    End Sub

    Public Sub New(idArtista As Integer)
        Me._artistaDAO = New ArtistaDAO
        Me._idArtista = idArtista
    End Sub

    Public Sub leerTodosArtistas(ruta As String)
        Me._artistaDAO.leerTodos(ruta)
    End Sub

    Public Sub leerArtista()
        Me._artistaDAO.leer(Me)
    End Sub

    Public Function mostrarTop(ruta As String) As Collection
        Return Me._artistaDAO.mostrarTop(ruta)
    End Function
    Public Function mostrarTopFiltrado(ruta As String, pais As String) As Collection
        Return Me._artistaDAO.mostrarTopFiltrado(ruta, pais)
    End Function
    Public Function masEscuchadosFechas(ruta As String, usuario As String, finicial As Date, ffinal As Date) As Collection
        Return Me._artistaDAO.MasEscuchadosFechas(ruta, usuario, finicial, ffinal)
    End Function
    Public Function insertar() As Integer
        Return Me._artistaDAO.insert(Me)
    End Function

    Public Function delete() As Integer
        Return Me._artistaDAO.delete(Me)
    End Function

    Public Function actualizar() As Integer
        Return Me._artistaDAO.update(Me)
    End Function

End Class
