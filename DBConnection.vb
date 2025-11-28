Imports MySql.Data.MySqlClient

Module DBConnection
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    Public Sub bukaKoneksi()
        Try
            If conn Is Nothing Then
                Dim str As String = "server=localhost;user id=root;password=;database=kuis_db"
                conn = New MySqlConnection(str)
            End If

            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

        Catch ex As Exception
            MsgBox("Koneksi gagal: " & ex.Message, vbCritical)
        End Try
    End Sub

    Public Sub tutupKoneksi()
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch
        End Try
    End Sub
End Module