Imports MySql.Data.MySqlClient

Public Class FormListSiswa
    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub

    Private Sub FormListSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDataSiswa()
        AturLabelUser()
    End Sub

    Private Sub TampilDataSiswa()
        Try
            bukaKoneksi()

            Dim query As String = "SELECT fullname, username, status FROM users WHERE status = 'Pelajar'"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            DataGridViewSiswa.DataSource = dt

            With DataGridViewSiswa
                .Columns(0).HeaderText = "Nama Lengkap"
                .Columns(1).HeaderText = "Username"
                .Columns(2).HeaderText = "Status"
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

    Private Sub textBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles textBoxSearch.TextChanged
        bukaKoneksi()
        Dim query As String = "SELECT fullname, username, status FROM users " &
                          "WHERE status = 'Pelajar' AND fullname LIKE @nama"
        Dim da As New MySqlDataAdapter(query, conn)
        da.SelectCommand.Parameters.AddWithValue("@nama", "%" & textBoxSearch.Text & "%")
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridViewSiswa.DataSource = dt
        tutupKoneksi()
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