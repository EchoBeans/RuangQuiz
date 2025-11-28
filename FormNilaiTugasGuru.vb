Imports MySql.Data.MySqlClient

Public Class FormNilaiTugasGuru
    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub

    Private Sub FormNilaiTugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDataPengumpulan()
        AturLabelUser()
    End Sub

    Private Sub TampilDataPengumpulan()
        Try
            bukaKoneksi()

            Dim query As String = "
                SELECT 
                    p.id_pengumpulan,
                    t.judul AS 'Judul Tugas',
                    u.fullname AS 'Nama Siswa',
                    p.link_pengumpulan AS 'Link',
                    p.tanggal_kumpul AS 'Tanggal Kumpul',
                    IFNULL(p.nilai, '-') AS 'Nilai',
                    p.status AS 'Status'
                FROM pengumpulan_tugas p
                INNER JOIN users u ON p.id_siswa = u.id
                INNER JOIN tugas t ON p.id_tugas = t.id_tugas
                ORDER BY p.tanggal_kumpul ASC;
            "

            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            DataGridView1.DataSource = dt
            With DataGridView1
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .ReadOnly = True
                .AllowUserToAddRows = False
            End With

        Catch ex As Exception
            MsgBox("Gagal menampilkan data pengumpulan: " & ex.Message, vbCritical)
        Finally
            tutupKoneksi()
        End Try
    End Sub

    Private Sub buttonTambah_Click(sender As Object, e As EventArgs) Handles buttonSimpan.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MsgBox("Pilih siswa yang ingin diberi nilai.", vbExclamation)
            Exit Sub
        End If

        Dim idPengumpulan As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells("id_pengumpulan").Value)
        Dim nilai As Integer

        If Not Integer.TryParse(textBoxNilai.Text.Trim(), nilai) Then
            MsgBox("Masukkan nilai yang valid.", vbExclamation)
            Exit Sub
        End If

        Try
            bukaKoneksi()
            Dim query As String = "
            UPDATE pengumpulan_tugas 
            SET nilai = @nilai, status = 'Sudah Dinilai'
            WHERE id_pengumpulan = @id;
        "

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nilai", nilai)
            cmd.Parameters.AddWithValue("@id", idPengumpulan)
            cmd.ExecuteNonQuery()

            MsgBox("Nilai berhasil disimpan!", vbInformation)
            textBoxNilai.Clear()
            TampilDataPengumpulan()

        Catch ex As Exception
            MsgBox("Gagal menyimpan nilai: " & ex.Message, vbCritical)
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
        FormTugasGuru.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles labelNilai.Click

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