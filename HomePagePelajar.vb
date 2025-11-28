Public Class HomePagePelajar
    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub

    Private Sub HomePagePelajar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim namaUser As String = CurrentFullname
        Dim greeting As String
        Dim jam As Integer = Now.Hour

        If jam < 12 Then
            greeting = "Selamat pagi"
        ElseIf jam < 18 Then
            greeting = "Selamat sore"
        Else
            greeting = "Selamat malam"
        End If

        Label6.Text = $"{greeting}, {namaUser}!"
        AturLabelUser()
    End Sub

    Private Sub labelHome_Click(sender As Object, e As EventArgs) Handles labelHome.Click

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
        Session.CurrentUserID = 0
        Session.CurrentUsername = ""
        Session.CurrentFullname = ""
        Session.CurrentStatus = ""

        FormLogin.Show()
        Me.Hide()
    End Sub

End Class