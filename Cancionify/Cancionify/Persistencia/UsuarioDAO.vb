Public Class UsuarioDAO
    Public ReadOnly Property _listaUsuarios As Collection

    Public Sub New()
        Me._listaUsuarios = New Collection
    End Sub


    Public Function delete(ByVal u As Usuario) As Integer
        Return AgenteBD.getAgente().Modificar("DELETE FROM Usuarios WHERE email='" & u._email & "';")
    End Function

    Public Function insert(ByVal u As Usuario) As Integer
        Return AgenteBD.getAgente.Modificar("INSERT INTO Usuarios VALUES ('" & u._email & "', '" & u._nombre & "', '" & u._apellidos & "', '" & u._nacimiento & "');")
    End Function

    Public Function update(ByVal u As Usuario) As Integer
        Return AgenteBD.getAgente().Modificar("UPDATE Usuarios SET nombre='" & u._nombre & "', Apellidos='" & u._apellidos & "', FechaNacimiento='" & u._nacimiento & "' WHERE email='" & u._email & "';")
    End Function

    Public Sub leerTodos(ruta As String)
        Dim u As Usuario
        Dim col, aux As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT * FROM Usuarios ORDER BY email")
        For Each aux In col
            u = New Usuario(aux(1).ToString)
            u._nombre = aux(2).ToString
            u._apellidos = aux(3).ToString
            u._nacimiento = aux(4).ToString
            Me._listaUsuarios.Add(u)
        Next
    End Sub

    Public Sub leer(ByRef u As Usuario)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.getAgente.leer("SELECT * FROM Usuarios WHERE email= '" & u._email & "';")
        For Each aux In col
            u._nombre = aux(2).ToString
            u._apellidos = aux(3).ToString
            u._nacimiento = aux(4).ToString
        Next
    End Sub

    Public Function topUsuarios(ruta As String) As Collection
        Dim col As Collection
        col = AgenteBD.getAgente(ruta).leer("SELECT USUARIOS.Email, Sum(CANCIONES.Duracion) AS SumaDeDuracion
FROM CANCIONES INNER JOIN (USUARIOS INNER JOIN REPRODUCCIONES ON USUARIOS.Email = REPRODUCCIONES.Usuario) ON CANCIONES.IdCancion = REPRODUCCIONES.Cancion
GROUP BY USUARIOS.Email, REPRODUCCIONES.Usuario
ORDER BY Sum(CANCIONES.Duracion) DESC;")
        Return col
    End Function
End Class
