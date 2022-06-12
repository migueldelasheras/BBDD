Public Class Reproduccion
    Public Property _id As Integer
    Public Property _usuario As String
    Public Property _cancion As Integer
    Public Property _fecha As Date
    Public Property ReproduccionDAO As ReproduccionDAO

    Public Sub New()
        Me.ReproduccionDAO = New ReproduccionDAO
    End Sub
    Public Sub New(id As Integer)
        Me.ReproduccionDAO = New ReproduccionDAO
        Me._id = id
    End Sub

    Public Sub leerTodasReproducciones(ruta As String)
        Me.ReproduccionDAO.leerTodas(ruta, _usuario)
    End Sub
    Public Function contarReproducciones(ruta As String) As Integer
        Return Me.ReproduccionDAO.contarReproducciones(ruta)
    End Function
    Public Sub leerReproduccion()
        Me.ReproduccionDAO.leer(Me)
    End Sub

    Public Function insertar() As Integer
        Return Me.ReproduccionDAO.insert(Me)
    End Function

    Public Function delete() As Integer
        Return Me.ReproduccionDAO.delete(Me)
    End Function

    Public Function actualizar() As Integer
        Return Me.ReproduccionDAO.update(Me)
    End Function

    Public Function obtenerCancion(cancion As Integer, ruta As String) As Cancion
        Return ReproduccionDAO.obtenerCancion(cancion, ruta)
    End Function
End Class
