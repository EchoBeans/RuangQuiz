Imports MySql.Data.MySqlClient

Public Class FormTugasPelajar
    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub
    Private Sub FormTugasSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDataTugas()
        AturLabelUser()
    End Sub
    Private Sub TampilDataTugas()
        Try
            bukaKoneksi()

            Dim query As String = "
                SELECT 
                    t.id_tugas, 
                    t.judul, 
                    t.deskripsi, 
                    t.deadline,
                    COALESCE(p.status, 'Belum Dikumpulkan') AS status
                FROM tugas t
                LEFT JOIN pengumpulan_tugas p 
                    ON t.id_tugas = p.id_tugas 
                    AND p.id_siswa = @id_siswa
                WHERE 
                    (p.status IS NULL OR p.status <> 'Sudah Dikumpulkan')  -- Filter biar yang sudah dikumpul nggak muncul
                    AND t.deadline >= CURDATE()                             -- Filter biar yang sudah lewat deadline nggak muncul
                ORDER BY t.deadline ASC;
            "


            Dim da As New MySqlDataAdapter(query, conn)
            da.SelectCommand.Parameters.AddWithValue("@id_siswa", Session.CurrentUserID)

            Dim dt As New DataTable
            da.Fill(dt)

            DataGridViewTugas.DataSource = dt
            With DataGridViewTugas
                .Columns("id_tugas").HeaderText = "ID"
                .Columns("judul").HeaderText = "Judul"
                .Columns("deskripsi").HeaderText = "Deskripsi"
                .Columns("deadline").HeaderText = "Deadline"
                .Columns("status").HeaderText = "Status"
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .ReadOnly = True
                .AllowUserToAddRows = False
            End With

        Catch ex As Exception
            MsgBox("Gagal menampilkan tugas: " & ex.Message, vbCritical)
        Finally
            tutupKoneksi()
        End Try
    End Sub
    Private Sub buttonAkses_Click(sender As Object, e As EventArgs) Handles buttonKumpulkan.Click
        If DataGridViewTugas.CurrentRow Is Nothing Then
            MsgBox("Pilih tugas yang ingin dikumpulkan.", vbExclamation)
            Exit Sub
        End If

        Dim idTugas As Integer = Convert.ToInt32(DataGridViewTugas.CurrentRow.Cells("id_tugas").Value)
        Dim formKumpul As New FormKumpulTugas()
        formKumpul.idTugas = idTugas
        formKumpul.Show()
        Me.Hide()
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
End Class
