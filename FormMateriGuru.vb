Imports MySql.Data.MySqlClient

Public Class FormMateriGuru
    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub

    Private Sub FormMateriGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = True
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

    Private Sub buttonTambah_Click(sender As Object, e As EventArgs) Handles buttonTambah.Click
        FormTambahMateriGuru.Show()
        Me.Hide()
    End Sub

    Private Sub buttonHapus_Click(sender As Object, e As EventArgs) Handles buttonHapus.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MsgBox("Pilih data yang ingin dihapus.", vbExclamation)
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells("id").Value)
        Dim hasil As DialogResult = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            bukaKoneksi()
            Try
                cmd = New MySqlCommand("DELETE FROM materi WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus.", vbInformation)
                TampilData()
            Catch ex As Exception
                MsgBox("Gagal menghapus data: " & ex.Message, vbCritical)
            Finally
                tutupKoneksi()
            End Try
        End If
    End Sub

    Private Sub buttonEdit_Click(sender As Object, e As EventArgs) Handles buttonEdit.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MsgBox("Pilih data yang ingin diedit.", vbExclamation)
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells("id").Value)
        Dim formUbah As New FormUbahMateriGuru()
        formUbah.MateriID = id
        formUbah.Show()
        Me.Hide()
    End Sub

    Private Sub textBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles textBoxSearch.TextChanged
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


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles labelMateri.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

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