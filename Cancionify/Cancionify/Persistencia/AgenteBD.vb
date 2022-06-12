Imports System.Data.OleDb

Public Class AgenteBD

    Private Const CadConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared mConexion As OleDb.OleDbConnection
    Private Shared mInstancia As AgenteBD
    Private Shared cadenaConexion As String

    Private Sub New()
        AgenteBD.mConexion = New OleDbConnection(AgenteBD.cadenaConexion)
        AgenteBD.mConexion.Open()
    End Sub

    Public Shared Function getAgente() As AgenteBD
        If AgenteBD.mInstancia Is Nothing Then
            AgenteBD.mInstancia = New AgenteBD
        End If
        Return AgenteBD.mInstancia
    End Function

    Public Shared Function getAgente(ruta As String) As AgenteBD
        AgenteBD.cadenaConexion = AgenteBD.CadConexion & ruta
        Return AgenteBD.getAgente
    End Function

    'funcion leer*****'

    Public Function Modificar(sql As String) As Integer
        Dim com As New OleDb.OleDbCommand(sql, AgenteBD.mConexion)
        Dim resultado As Integer
        MsgBox(com.CommandText)
        Conectar()
        resultado = com.ExecuteNonQuery
        Desconectar()
        Return resultado
    End Function

    Public Sub Conectar()
        If AgenteBD.mConexion.State = ConnectionState.Closed Then
            AgenteBD.mConexion.Open()
        End If
    End Sub

    Public Sub Desconectar()
        If AgenteBD.mConexion.State = ConnectionState.Open Then
            AgenteBD.mConexion.Close()
        End If
    End Sub

    Public Function leer(sql As String) As Collection
        Dim result As New Collection
        Dim fila As Collection
        Dim i As Integer
        Dim reader As OleDb.OleDbDataReader
        Dim com As New OleDb.OleDbCommand(sql, AgenteBD.mConexion)
        Conectar()
        reader = com.ExecuteReader
        While reader.Read
            fila = New Collection
            For i = 0 To reader.FieldCount - 1
                fila.Add(reader(i).ToString)
            Next
            result.Add(fila)
        End While
        Desconectar()
        Return result
    End Function

End Class