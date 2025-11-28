Imports MySql.Data.MySqlClient

Public Class FormTugasGuru
    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub

    Private Sub FormTugasGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDataTugas()
        AturLabelUser()
    End Sub
    Public Sub TampilDataTugas()
        Try
            bukaKoneksi()

            Dim query As String = "SELECT id_tugas, judul, deskripsi, link_materi, deadline FROM tugas"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            DataGridViewTugas.DataSource = dt
            With DataGridViewTugas
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .ReadOnly = True
                .AllowUserToAddRows = False
            End With

        Catch ex As Exception
            MsgBox("Gagal menampilkan data: " & ex.Message, vbCritical)
        Finally
            tutupKoneksi()
        End Try
    End Sub

    Private Sub DataGridViewTugas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTugas.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridViewTugas.Rows(e.RowIndex)

            Dim idTugas As Integer = Convert.ToInt32(row.Cells("ID Tugas").Value)
            Dim judul As String = row.Cells("Judul").Value.ToString()
            Dim deskripsi As String = row.Cells("Deskripsi").Value.ToString()
            Dim deadline As Date = Convert.ToDateTime(row.Cells("Deadline").Value)
            Dim link As String = row.Cells("Link Materi").Value.ToString()

            MsgBox("Judul: " & judul & vbCrLf &
                   "Deskripsi: " & deskripsi & vbCrLf &
                   "Deadline: " & deadline)
        End If
    End Sub

    Private Sub buttonTambah_Click(sender As Object, e As EventArgs) Handles buttonTambah.Click
        FormTambahTugasGuru.Show()
        Me.Hide()
    End Sub

    Private Sub buttonEdit_Click(sender As Object, e As EventArgs) Handles buttonEdit.Click
        If DataGridViewTugas.CurrentRow Is Nothing Then
            MsgBox("Pilih data tugas yang ingin diedit.", vbExclamation)
            Exit Sub
        End If

        Dim idTugas As Integer = Convert.ToInt32(DataGridViewTugas.CurrentRow.Cells("id_tugas").Value)
        Dim judul As String = DataGridViewTugas.CurrentRow.Cells("judul").Value.ToString()
        Dim deskripsi As String = DataGridViewTugas.CurrentRow.Cells("deskripsi").Value.ToString()
        Dim link As String = DataGridViewTugas.CurrentRow.Cells("link_materi").Value.ToString()
        Dim deadline As String = DataGridViewTugas.CurrentRow.Cells("deadline").Value.ToString()

        Dim formUbah As New FormUbahTugasGuru()
        formUbah.textBoxJudul.Text = judul
        formUbah.textBoxDeskripsi.Text = deskripsi
        formUbah.textBoxLink.Text = link
        formUbah.datePickerDeadline.Value = Convert.ToDateTime(deadline)
        formUbah.idTugas = idTugas

        formUbah.Show()
        Me.Hide()
    End Sub

    Private Sub buttonHapus_Click(sender As Object, e As EventArgs) Handles buttonHapus.Click
        If DataGridViewTugas.CurrentRow Is Nothing Then
            MsgBox("Pilih data tugas yang ingin dihapus.", vbExclamation)
            Exit Sub
        End If

        Dim idTugas As Integer = Convert.ToInt32(DataGridViewTugas.CurrentRow.Cells("id_tugas").Value)

        Dim hasil As DialogResult = MessageBox.Show("Yakin ingin menghapus tugas ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            Try
                bukaKoneksi()

                Dim query As String = "DELETE FROM tugas WHERE id_tugas = @id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", idTugas)
                cmd.ExecuteNonQuery()

                MsgBox("Tugas berhasil dihapus.", vbInformation)
                TampilDataTugas()

            Catch ex As Exception
                MsgBox("Gagal menghapus tugas: " & ex.Message, vbCritical)
            Finally
                tutupKoneksi()
            End Try
        End If
    End Sub

    Private Sub textBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles textBoxSearch.TextChanged
        Try
            bukaKoneksi()

            Dim query As String = "SELECT id_tugas, judul, deskripsi, link_materi, deadline 
                               FROM tugas 
                               WHERE judul LIKE @keyword OR deskripsi LIKE @keyword"

            Dim da As New MySqlDataAdapter(query, conn)
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & textBoxSearch.Text & "%")

            Dim dt As New DataTable
            da.Fill(dt)

            DataGridViewTugas.DataSource = dt
            DataGridViewTugas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox("Gagal melakukan pencarian: " & ex.Message, vbCritical)
        Finally
            tutupKoneksi()
        End Try
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