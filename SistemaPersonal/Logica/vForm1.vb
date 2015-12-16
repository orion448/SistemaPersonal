Public Class vForm1
    Inherits Conexion

    Public Sub probarConexion()
        MsgBox("Conectando...")
        Try
            If conectar() Then

            Else
                Throw New Exception("No se pudo conectar")
            End If
        Catch ex As Exception
            MsgBox("Error:" + ex.Message + "En: " + ex.TargetSite.ToString)
        End Try
    End Sub

End Class
