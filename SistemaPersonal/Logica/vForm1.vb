Public Class vForm1
    Inherits Conexion

    Public Sub probarConexion()
        Try
            If conectar() Then
                MsgBox("Conectado")
            Else
                Throw New Exception("No se pudo conectar")
            End If
        Catch ex As Exception
            MsgBox("Error:" + ex.Message + "En: " + ex.TargetSite.ToString)
        End Try
    End Sub

End Class
