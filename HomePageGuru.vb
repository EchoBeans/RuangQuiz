Public Class HomePageGuru
    Private Sub AturLabelUser()
        Label11.Text = Session.CurrentFullname
        Label11.Left = Panel1.Width \ 2 - Label11.Width \ 2

        Label12.Text = Session.CurrentStatus
        Label12.Left = Panel1.Width \ 2 - Label12.Width \ 2
    End Sub

    Private Sub HomePageGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim namaUser As String = Session.CurrentFullname

        Dim greeting As String
        Dim jam As Integer = Now.Hour

        If jam < 12 Then
            greeting = "Selamat pagi"
        ElseIf jam < 18 Then
            greeting = "Selamat siang"
        Else
            greeting = "Selamat malam"
        End If

        Label6.Text = $"{greeting}, {namaUser}!"
        AturLabelUser()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles labelMateri.Click
        FormMateriGuru.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FormMateriGuru.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        FormQuizGuru.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles labelQuiz.Click
        FormQuizGuru.Show()
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

    Private Sub buttonMateri_Click(sender As Object, e As EventArgs) Handles buttonMateri.Click
        FormMateriGuru.Show()
        Me.Hide()
    End Sub

    Private Sub buttonQuiz_Click(sender As Object, e As EventArgs) Handles buttonQuiz.Click
        FormQuizGuru.Show()
        Me.Hide()
    End Sub

    Private Sub buttonTugas_Click(sender As Object, e As EventArgs) Handles buttonTugas.Click
        FormTugasGuru.Show()
        Me.Hide()
    End Sub

    Private Sub labelHome_Click(sender As Object, e As EventArgs) Handles labelHome.Click

    End Sub
End Class