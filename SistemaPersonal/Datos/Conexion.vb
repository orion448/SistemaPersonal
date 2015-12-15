Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Public Class Conexion
    Protected ConnectionString As String = My.Settings.conexion.ToString

    Protected connection As New SqlConnection
    Protected Function conectar()
        Try
            connection = New SqlConnection(ConnectionString)
            connection.Open()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Protected Function desconectar()
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
