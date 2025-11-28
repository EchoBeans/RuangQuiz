Imports MySql.Data.MySqlClient

Public Class FormKumpulTugas
    Public Property idTugas As Integer

    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub

    Private Sub buttonKumpulkan_Click(sender As Object, e As EventArgs) Handles buttonKumpulkan.Click
        If textBoxLink.Text.Trim() = "" Then
            MsgBox("Masukkan link pengumpulan tugas.", vbExclamation)
            Exit Sub
        End If

        Try
            bukaKoneksi()

            Dim checkQuery As String = "SELECT COUNT(*) FROM pengumpulan_tugas WHERE id_tugas=@id_tugas AND id_siswa=@id_siswa"
            Dim cmdCheck As New MySqlCommand(checkQuery, conn)
            cmdCheck.Parameters.AddWithValue("@id_tugas", idTugas)
            cmdCheck.Parameters.AddWithValue("@id_siswa", Session.CurrentUserID)
            Dim sudahKumpul As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

            If sudahKumpul > 0 Then
                Dim updateQuery As String = "
                    UPDATE pengumpulan_tugas 
                    SET link_pengumpulan=@link, tanggal_kumpul=NOW(), status='Sudah Dikumpulkan'
                    WHERE id_tugas=@id_tugas AND id_siswa=@id_siswa"
                Dim cmdUpdate As New MySqlCommand(updateQuery, conn)
                cmdUpdate.Parameters.AddWithValue("@link", textBoxLink.Text.Trim())
                cmdUpdate.Parameters.AddWithValue("@id_tugas", idTugas)
                cmdUpdate.Parameters.AddWithValue("@id_siswa", Session.CurrentUserID)
                cmdUpdate.ExecuteNonQuery()
                MsgBox("Tugas berhasil diperbarui!", vbInformation)
            Else
                Dim insertQuery As String = "
                    INSERT INTO pengumpulan_tugas (id_tugas, id_siswa, link_pengumpulan, tanggal_kumpul, status)
                    VALUES (@id_tugas, @id_siswa, @link, NOW(), 'Sudah Dikumpulkan')"
                Dim cmdInsert As New MySqlCommand(insertQuery, conn)
                cmdInsert.Parameters.AddWithValue("@id_tugas", idTugas)
                cmdInsert.Parameters.AddWithValue("@id_siswa", Session.CurrentUserID)
                cmdInsert.Parameters.AddWithValue("@link", textBoxLink.Text.Trim())
                cmdInsert.ExecuteNonQuery()
                MsgBox("Tugas berhasil dikumpulkan!", vbInformation)
            End If

            Dim formTugas As New FormTugasPelajar()
            formTugas.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("Gagal mengumpulkan tugas: " & ex.Message, vbCritical)
        Finally
            tutupKoneksi()
        End Try
    End Sub

    Private Sub labelHome_Click(sender As Object, e As EventArgs) Handles labelHome.Click
        HomePagePelajar.Show()
        Me.Hide()
    End Sub

    Private Sub labelMateri_Click(sender As Object, e As EventArgs) Handles labelMateri.Click
        FormMateriPelajar.Show()
        Me.Hide()
    End Sub

    Private Sub labelQuiz_Click(sender As Object, e As EventArgs) Handles labelQuiz.Click
        FormQuizPelajar.Show()
        Me.Hide()
    End Sub

    Private Sub labelTugas_Click(sender As Object, e As EventArgs) Handles labelTugas.Click
        FormTugasPelajar.Show()
        Me.Hide()
    End Sub

    Private Sub labelNilai_Click(sender As Object, e As EventArgs) Handles labelNilai.Click
        FormNilaiPelajar.Show()
        Me.Hide()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub FormKumpulTugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturLabelUser()
    End Sub
End Class