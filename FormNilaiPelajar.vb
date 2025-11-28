Imports MySql.Data.MySqlClient

Public Class FormNilaiPelajar
    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub

    Private Sub FormNilaiTugasPelajar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanNilaiUser()
        AturLabelUser()
    End Sub

    Private Sub TampilkanNilaiUser()
        Try
            bukaKoneksi()

            Dim query As String =
                "SELECT p.id_pengumpulan, t.judul, p.nilai, p.tanggal_kumpul
             FROM pengumpulan_tugas p
             JOIN tugas t ON p.id_tugas = t.id_tugas
             WHERE p.id_siswa = @id"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", Session.CurrentUserID)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table

        Catch ex As Exception
            MsgBox("Gagal menampilkan nilai: " & ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
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

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub
End Class
