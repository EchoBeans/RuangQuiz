Imports MySql.Data.MySqlClient

Public Class FormTambahQuiz
    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub

    Private Sub buttonTambah_Click(sender As Object, e As EventArgs) Handles buttonTambah.Click
        If textBoxJudul.Text.Trim() = "" OrElse
           textBoxDeskripsi.Text.Trim() = "" OrElse
           textBoxQuiz.Text.Trim() = "" OrElse
           textBoxTgglDitambahkan.Text.Trim() = "" Then
            MsgBox("Semua field harus diisi.", vbExclamation)
            Exit Sub
        End If

        bukaKoneksi()
        Try
            Dim query As String = "INSERT INTO quiz (judul_quiz, deskripsi_quiz, linkquiz, tanggal_ditambahkan) 
                                   VALUES (@j, @d, @l, @t)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@j", textBoxJudul.Text.Trim())
            cmd.Parameters.AddWithValue("@d", textBoxDeskripsi.Text.Trim())
            cmd.Parameters.AddWithValue("@l", textBoxQuiz.Text.Trim())
            cmd.Parameters.AddWithValue("@t", textBoxTgglDitambahkan.Text.Trim())
            cmd.ExecuteNonQuery()

            MsgBox("Quiz berhasil ditambahkan.", vbInformation)
            textBoxJudul.Clear()
            textBoxDeskripsi.Clear()
            textBoxQuiz.Clear()
            textBoxTgglDitambahkan.Clear()

            Me.Hide()
            FormQuizGuru.Show()
            FormQuizGuru.TampilData()

        Catch ex As Exception
            MsgBox("Gagal menambahkan quiz: " & ex.Message, vbCritical)
        Finally
            tutupKoneksi()
        End Try
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        textBoxJudul.Clear()
        textBoxDeskripsi.Clear()
        textBoxQuiz.Clear()
        textBoxTgglDitambahkan.Clear()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles labelMateri.Click
        FormMateriGuru.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FormMateriGuru.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles labelListSiswa.Click
        FormListSiswa.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles labelTugas.Click
        FormTugasGuru.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles labelNilai.Click
        FormNilaiTugasGuru.Show()
        Me.Hide()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Me.Close()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub labelHome_Click(sender As Object, e As EventArgs) Handles labelHome.Click
        HomePageGuru.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub labelQuiz_Click(sender As Object, e As EventArgs) Handles labelQuiz.Click
        FormQuizGuru.Show()
        Me.Hide()
    End Sub

    Private Sub FormTambahQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturLabelUser()
    End Sub
End Class