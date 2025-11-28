Imports MySql.Data.MySqlClient

Public Class FormMateriPelajar
    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub

    Private Sub FormMateriPelajar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        AturLabelUser()
    End Sub
    Public Sub TampilData()
        bukaKoneksi()
        Dim da As New MySqlDataAdapter("SELECT * FROM materi", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = dt
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        tutupKoneksi()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim link As String = DataGridView1.Rows(e.RowIndex).Cells("link").Value.ToString()

            If link <> "" Then
                Try
                    Process.Start(link)
                Catch ex As Exception
                    MsgBox("Gagal membuka link: " & ex.Message, vbCritical)
                End Try
            Else
                MsgBox("Data ini tidak memiliki link.", vbExclamation)
            End If
        End If
    End Sub

    Private Sub buttonAkses_Click(sender As Object, e As EventArgs) Handles buttonAkses.Click
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim link As String = DataGridView1.CurrentRow.Cells("link").Value.ToString()

            If link <> "" Then
                Try
                    Process.Start(link)
                Catch ex As Exception
                    MsgBox("Gagal membuka link: " & ex.Message, vbCritical)
                End Try
            Else
                MsgBox("Data ini tidak memiliki link.", vbExclamation)
            End If
        Else
            MsgBox("Pilih materi terlebih dahulu.", vbExclamation)
        End If
    End Sub

    Private Sub textBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles textBoxSearch.TextChanged
        bukaKoneksi()
        Try
            Dim keyword As String = textBoxSearch.Text.Trim()
            Dim query As String

            If keyword = "" Then
                query = "SELECT * FROM materi"
            Else
                query = "SELECT * FROM materi WHERE judul LIKE @keyword OR deskripsi LIKE @keyword"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            DataGridView1.Columns.Clear()
            DataGridView1.DataSource = dt
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox("Gagal melakukan pencarian: " & ex.Message, vbCritical)
        Finally
            tutupKoneksi()
        End Try

    End Sub

    Private Sub labelHome_Click(sender As Object, e As EventArgs) Handles labelHome.Click
        HomePagePelajar.Show()
        Me.Hide()
    End Sub

    Private Sub labelMateri_Click(sender As Object, e As EventArgs) Handles labelMateri.Click

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
End Class