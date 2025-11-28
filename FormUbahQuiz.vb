Imports MySql.Data.MySqlClient

Public Class FormUbahQuiz
    Public Property QuizID As Integer

    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub

    Private Sub FormUbahQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If QuizID <> 0 Then
            TampilDataLama()
        End If

        AturLabelUser()
    End Sub
    Private Sub TampilDataLama()
        bukaKoneksi()
        Try
            Dim query As String = "SELECT * FROM quiz WHERE id=@id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", QuizID)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                textBoxJudul.Text = dr("judul_quiz").ToString()
                textBoxDeskripsi.Text = dr("deskripsi_quiz").ToString()
                textBoxQuiz.Text = dr("linkquiz").ToString()
            End If
        Catch ex As Exception
            MsgBox("Gagal mengambil data: " & ex.Message, vbCritical)
        Finally
            dr.Close()
            tutupKoneksi()
        End Try
    End Sub
    Private Sub buttonUbah_Click(sender As Object, e As EventArgs) Handles buttonUbah.Click
        If textBoxJudul.Text.Trim() = "" OrElse
           textBoxDeskripsi.Text.Trim() = "" OrElse
           textBoxQuiz.Text.Trim() = "" Then
            MsgBox("Semua field harus diisi.", vbExclamation)
            Exit Sub
        End If

        bukaKoneksi()
        Try
            Dim query As String = "UPDATE quiz 
                               SET judul_quiz=@j, deskripsi_quiz=@d, linkquiz=@l 
                               WHERE id=@id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@j", textBoxJudul.Text.Trim())
            cmd.Parameters.AddWithValue("@d", textBoxDeskripsi.Text.Trim())
            cmd.Parameters.AddWithValue("@l", textBoxQuiz.Text.Trim())
            cmd.Parameters.AddWithValue("@id", QuizID)
            cmd.ExecuteNonQuery()

            MsgBox("Data quiz berhasil diubah.", vbInformation)
            Me.Hide()
            FormQuizGuru.Show()
            FormQuizGuru.TampilData()

        Catch ex As Exception
            MsgBox("Gagal mengubah quiz: " & ex.Message, vbCritical)
        Finally
            tutupKoneksi()
        End Try
    End Sub
    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        textBoxJudul.Clear()
        textBoxDeskripsi.Clear()
        textBoxQuiz.Clear()
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
End Class
