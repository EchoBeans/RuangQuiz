Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormRegister.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If textBoxUsername.Text.Trim() = "" OrElse
       textBoxPass.Text.Trim() = "" OrElse
       comboBoxStatus.Text.Trim() = "" Then

            MsgBox("Semua field harus diisi!", vbExclamation, "Peringatan")
            Exit Sub
        End If

        Try
            bukaKoneksi()

            Dim query As String =
            "SELECT * FROM users WHERE username=@u AND password=@p AND status=@s"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@u", textBoxUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@p", textBoxPass.Text.Trim())
            cmd.Parameters.AddWithValue("@s", comboBoxStatus.Text.Trim())

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                Session.CurrentUserID = reader("id")
                Session.CurrentUsername = reader("username").ToString()
                Session.CurrentFullname = reader("fullname").ToString()
                Session.CurrentStatus = reader("status").ToString()

                MsgBox("Login Berhasil! Selamat datang, " & Session.CurrentFullname,
                   vbInformation, "Sukses")

                If Session.CurrentStatus = "Pelajar" Then
                    Dim f As New HomePagePelajar
                    f.Show()
                ElseIf Session.CurrentStatus = "Guru" Then
                    Dim f As New HomePageGuru
                    f.Show()
                End If

                Me.Hide()

            Else
                MsgBox("Username, password, atau status salah!",
                   vbCritical, "Gagal Login")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Kesalahan")

        Finally
            conn.Close()
        End Try
    End Sub
End Class
