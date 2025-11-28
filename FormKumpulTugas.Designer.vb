<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKumpulTugas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKumpulTugas))
        Me.textBoxLink = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.buttonClear = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.buttonKumpulkan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.labelNilai = New System.Windows.Forms.Label()
        Me.labelTugas = New System.Windows.Forms.Label()
        Me.labelQuiz = New System.Windows.Forms.Label()
        Me.labelMateri = New System.Windows.Forms.Label()
        Me.labelHome = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBoxLink
        '
        Me.textBoxLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBoxLink.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxLink.Location = New System.Drawing.Point(307, 161)
        Me.textBoxLink.Multiline = True
        Me.textBoxLink.Name = "textBoxLink"
        Me.textBoxLink.Size = New System.Drawing.Size(347, 35)
        Me.textBoxLink.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(303, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 23)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Link "
        '
        'Label7
        '
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(246, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 54)
        Me.Label7.TabIndex = 88
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(985, 27)
        Me.Panel2.TabIndex = 79
        '
        'buttonClear
        '
        Me.buttonClear.BackColor = System.Drawing.Color.DimGray
        Me.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonClear.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonClear.Location = New System.Drawing.Point(467, 240)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(137, 57)
        Me.buttonClear.TabIndex = 83
        Me.buttonClear.Text = "Clear"
        Me.buttonClear.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(301, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(332, 31)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Halaman Pengumpulan Tugas"
        '
        'buttonKumpulkan
        '
        Me.buttonKumpulkan.BackColor = System.Drawing.Color.Indigo
        Me.buttonKumpulkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonKumpulkan.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.buttonKumpulkan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonKumpulkan.Location = New System.Drawing.Point(307, 240)
        Me.buttonKumpulkan.Name = "buttonKumpulkan"
        Me.buttonKumpulkan.Size = New System.Drawing.Size(137, 57)
        Me.buttonKumpulkan.TabIndex = 82
        Me.buttonKumpulkan.Text = "Kumpulkan"
        Me.buttonKumpulkan.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.Label5.Location = New System.Drawing.Point(307, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(647, 23)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Silakan unggah tugas ke Google Drive, lalu salin link dan tempel di kolom di bawa" &
    "h."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.labelNilai)
        Me.Panel1.Controls.Add(Me.labelTugas)
        Me.Panel1.Controls.Add(Me.labelQuiz)
        Me.Panel1.Controls.Add(Me.labelMateri)
        Me.Panel1.Controls.Add(Me.labelHome)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(-1, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 562)
        Me.Panel1.TabIndex = 91
        '
        'Label13
        '
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(9, 520)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 28)
        Me.Label13.TabIndex = 78
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(47, 525)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 23)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Logout"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(89, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 23)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(77, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 23)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Username"
        '
        'Label10
        '
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(3, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(233, 101)
        Me.Label10.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(39, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 28)
        Me.Label1.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(39, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 28)
        Me.Label2.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(39, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 28)
        Me.Label4.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(39, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 28)
        Me.Label3.TabIndex = 69
        '
        'Label9
        '
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(39, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 28)
        Me.Label9.TabIndex = 66
        '
        'labelNilai
        '
        Me.labelNilai.AutoSize = True
        Me.labelNilai.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNilai.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelNilai.Location = New System.Drawing.Point(77, 383)
        Me.labelNilai.Name = "labelNilai"
        Me.labelNilai.Size = New System.Drawing.Size(47, 23)
        Me.labelNilai.TabIndex = 68
        Me.labelNilai.Text = "Nilai"
        '
        'labelTugas
        '
        Me.labelTugas.AutoSize = True
        Me.labelTugas.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTugas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelTugas.Location = New System.Drawing.Point(77, 343)
        Me.labelTugas.Name = "labelTugas"
        Me.labelTugas.Size = New System.Drawing.Size(56, 23)
        Me.labelTugas.TabIndex = 67
        Me.labelTugas.Text = "Tugas"
        '
        'labelQuiz
        '
        Me.labelQuiz.AutoSize = True
        Me.labelQuiz.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelQuiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelQuiz.Location = New System.Drawing.Point(77, 303)
        Me.labelQuiz.Name = "labelQuiz"
        Me.labelQuiz.Size = New System.Drawing.Size(46, 23)
        Me.labelQuiz.TabIndex = 14
        Me.labelQuiz.Text = "Quiz"
        '
        'labelMateri
        '
        Me.labelMateri.AutoSize = True
        Me.labelMateri.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMateri.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelMateri.Location = New System.Drawing.Point(77, 263)
        Me.labelMateri.Name = "labelMateri"
        Me.labelMateri.Size = New System.Drawing.Size(63, 23)
        Me.labelMateri.TabIndex = 13
        Me.labelMateri.Text = "Materi"
        '
        'labelHome
        '
        Me.labelHome.AutoSize = True
        Me.labelHome.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelHome.Location = New System.Drawing.Point(77, 223)
        Me.labelHome.Name = "labelHome"
        Me.labelHome.Size = New System.Drawing.Size(58, 23)
        Me.labelHome.TabIndex = 12
        Me.labelHome.Text = "Home"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel3.Location = New System.Drawing.Point(0, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(236, 27)
        Me.Panel3.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.BlueViolet
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.Location = New System.Drawing.Point(956, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 26)
        Me.Label15.TabIndex = 92
        '
        'FormKumpulTugas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textBoxLink)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.buttonClear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.buttonKumpulkan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormKumpulTugas"
        Me.Text = "FormKumpulTugas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textBoxLink As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents buttonClear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents buttonKumpulkan As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Private WithEvents Label13 As Label
    Private WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents labelNilai As Label
    Friend WithEvents labelTugas As Label
    Friend WithEvents labelQuiz As Label
    Friend WithEvents labelMateri As Label
    Friend WithEvents labelHome As Label
    Friend WithEvents Panel3 As Panel
    Private WithEvents Label15 As Label
End Class
