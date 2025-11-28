Imports MySql.Data.MySqlClient

Public Class FormUbahTugasGuru
    Public Property idTugas As Integer

    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub

    Private Sub buttonTambah_Click(sender As Object, e As EventArgs) Handles buttonUbah.Click
        Try
            If textBoxJudul.Text.Trim() = "" OrElse textBoxDeskripsi.Text.Trim() = "" Then
                MsgBox("Judul dan Deskripsi wajib diisi.", vbExclamation)
                Exit Sub
            End If

            bukaKoneksi()

            Dim query As String = "UPDATE tugas SET judul=@judul, deskripsi=@deskripsi, link_materi=@link, deadline=@deadline WHERE id_tugas=@id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@judul", textBoxJudul.Text.Trim())
            cmd.Parameters.AddWithValue("@deskripsi", textBoxDeskripsi.Text.Trim())
            cmd.Parameters.AddWithValue("@link", textBoxLink.Text.Trim())
            cmd.Parameters.AddWithValue("@deadline", datePickerDeadline.Value)
            cmd.Parameters.AddWithValue("@id", idTugas)

            cmd.ExecuteNonQuery()
            MsgBox("Tugas berhasil diperbarui.", vbInformation)

            FormTugasGuru.TampilDataTugas()
            FormTugasGuru.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("Gagal memperbarui tugas: " & ex.Message, vbCritical)
        Finally
            tutupKoneksi()
        End Try
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        textBoxJudul.Clear()
        textBoxDeskripsi.Clear()
        textBoxLink.Clear()
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

    Private Sub FormTambahTugasGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturLabelUser()
    End Sub
End Class