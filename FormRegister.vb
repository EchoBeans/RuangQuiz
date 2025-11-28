Imports MySql.Data.MySqlClient

Public Class FormRegister
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub ButtonSignUp_Click(sender As Object, e As EventArgs) Handles ButtonSignUp.Click
        If textBoxFullname.Text.Trim() = "" OrElse
           textBoxUsername.Text.Trim() = "" OrElse
           textBoxPass.Text.Trim() = "" OrElse
           comboBoxStatus.Text.Trim() = "" Then

            MsgBox("Semua field harus diisi!", vbExclamation, "Peringatan")
            Exit Sub
        End If

        bukaKoneksi()
        If conn Is Nothing OrElse conn.State <> ConnectionState.Open Then
            MsgBox("Koneksi database belum terbuka.", vbCritical)
            Exit Sub
        End If

        Try
            Dim exists As Integer = 0
            cmd = New MySqlCommand("SELECT COUNT(*) FROM users WHERE username=@u", conn)
            cmd.Parameters.AddWithValue("@u", textBoxUsername.Text.Trim())
            exists = Convert.ToInt32(cmd.ExecuteScalar())

            If exists > 0 Then
                MsgBox("Username sudah digunakan!", vbExclamation, "Peringatan")
                Exit Sub
            End If

            cmd = New MySqlCommand(
                "INSERT INTO users (fullname, username, password, status)
                 VALUES (@f, @u, @p, @s)", conn)
            cmd.Parameters.AddWithValue("@f", textBoxFullname.Text.Trim())
            cmd.Parameters.AddWithValue("@u", textBoxUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@p", textBoxPass.Text)
            cmd.Parameters.AddWithValue("@s", comboBoxStatus.Text.Trim())

            cmd.ExecuteNonQuery()

            MsgBox("Registrasi berhasil! Silakan login menggunakan akun Anda.", vbInformation, "Sukses")

            textBoxFullname.Clear()
            textBoxUsername.Clear()
            textBoxPass.Clear()
            comboBoxStatus.SelectedIndex = -1

            Me.Hide()
            FormLogin.textBoxUsername.Text = textBoxUsername.Text
            FormLogin.Show()

        Catch ex As MySqlException
            MsgBox("Gagal menyimpan: " & ex.Message, vbCritical, "Error")
        Finally
            tutupKoneksi()
        End Try
    End Sub
End Class
