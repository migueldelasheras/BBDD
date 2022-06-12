Public Class Usuario

    Public Property _email As String
    Public Property _nombre As String
    Public Property _apellidos As String
    Public Property _nacimiento As Date
    Public Property _artistasFavoritos As Collection
    Public Property _reproducciones As Collection

    Public ReadOnly _usuarioDAO As UsuarioDAO

    Public Sub New()
        Me._usuarioDAO = New UsuarioDAO
    End Sub

    Public Sub New(email As String)
        Me._usuarioDAO = New UsuarioDAO
        Me._email = email
    End Sub

    Public Sub leerTodosUsuarios(ruta As String)
        Me._usuarioDAO.leerTodos(ruta)
    End Sub

    Public Sub leerUsuario()
        Me._usuarioDAO.leer(Me)
    End Sub

    Public Function insertar() As Integer
        Return Me._usuarioDAO.insert(Me)
    End Function

    Public Function delete() As Integer
        Return Me._usuarioDAO.delete(Me)
    End Function

    Public Function actualizar() As Integer
        Return Me._usuarioDAO.update(Me)
    End Function
    Public Function topUsuarios(ruta As String) As Collection
        Return Me._usuarioDAO.topUsuarios(ruta)
    End Function

End Class

''dominio con las clases cancion, usuarios, artista y albumes ademas de la clase reproduccion y art favorito
''persistencia Con los Dao de cada clase de de dominio

''Clase reproduccion(clase asociativa de usuario y cancion) y artista favorito(clase asociativa de usuario y artista)
