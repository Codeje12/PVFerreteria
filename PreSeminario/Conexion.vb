'Imports MySql.Data.MySqlClient

Module Conexion

    Public ConexionMysql As New MySql.Data.MySqlClient.MySqlConnection
    Public Comando As New MySql.Data.MySqlClient.MySqlCommand
    Public DataReader As MySql.Data.MySqlClient.MySqlDataReader



    Function ConectarMySql() As Boolean
        Dim usuario As String = "root"
        Dim Contraseña As String = ""
        Try
            If ConexionMysql.State = ConnectionState.Closed Then
                ConexionMysql.ConnectionString = "Server=localhost;Database=puntoventa;Uid='" & usuario & "' ;Pwd='" & Contraseña & "';"
                ConexionMysql.Open()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub EjecutarSql(ByRef SQL As String)
        Try
            If ConectarMySql() Then
                Comando.CommandText = SQL
                Comando.CommandType = CommandType.Text
                Comando.Connection = ConexionMysql
                Comando.ExecuteNonQuery()
                ConexionMysql.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            ' MsgBox("Verifique los datos y vuelva a intentarlo. Acuerdese que no se pueden duplicar datos.", MsgBoxStyle.Information, "Error")
            ConexionMysql.Close()
        End Try
    End Sub
End Module
