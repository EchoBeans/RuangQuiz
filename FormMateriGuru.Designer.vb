<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMateriGuru
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMateriGuru))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deskripsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.link = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buttonTambah = New System.Windows.Forms.Button()
        Me.buttonHapus = New System.Windows.Forms.Button()
        Me.buttonEdit = New System.Windows.Forms.Button()
        Me.textBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelNilai = New System.Windows.Forms.Label()
        Me.labelTugas = New System.Windows.Forms.Label()
        Me.labelListSiswa = New System.Windows.Forms.Label()
        Me.labelQuiz = New System.Windows.Forms.Label()
        Me.labelMateri = New System.Windows.Forms.Label()
        Me.labelHome = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(985, 27)
        Me.Panel2.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.judul, Me.deskripsi, Me.link})
        Me.DataGridView1.Location = New System.Drawing.Point(232, 165)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(753, 392)
        Me.DataGridView1.TabIndex = 4
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 125
        '
        'judul
        '
        Me.judul.HeaderText = "Judul"
        Me.judul.MinimumWidth = 6
        Me.judul.Name = "judul"
        Me.judul.ReadOnly = True
        Me.judul.Width = 125
        '
        'deskripsi
        '
        Me.deskripsi.HeaderText = "Deskripsi"
        Me.deskripsi.MinimumWidth = 6
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.ReadOnly = True
        Me.deskripsi.Width = 125
        '
        'link
        '
        Me.link.HeaderText = "Link"
        Me.link.MinimumWidth = 6
        Me.link.Name = "link"
        Me.link.ReadOnly = True
        Me.link.Width = 125
        '
        'buttonTambah
        '
        Me.buttonTambah.BackColor = System.Drawing.Color.Indigo
        Me.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonTambah.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.buttonTambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonTambah.Location = New System.Drawing.Point(242, 102)
        Me.buttonTambah.Name = "buttonTambah"
        Me.buttonTambah.Size = New System.Drawing.Size(137, 57)
        Me.buttonTambah.TabIndex = 9
        Me.buttonTambah.Text = "Tambah "
        Me.buttonTambah.UseVisualStyleBackColor = False
        '
        'buttonHapus
        '
        Me.buttonHapus.BackColor = System.Drawing.Color.Red
        Me.buttonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonHapus.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.buttonHapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonHapus.Location = New System.Drawing.Point(395, 102)
        Me.buttonHapus.Name = "buttonHapus"
        Me.buttonHapus.Size = New System.Drawing.Size(137, 57)
        Me.buttonHapus.TabIndex = 10
        Me.buttonHapus.Text = "Hapus"
        Me.buttonHapus.UseVisualStyleBackColor = False
        '
        'buttonEdit
        '
        Me.buttonEdit.BackColor = System.Drawing.Color.Orange
        Me.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonEdit.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonEdit.Location = New System.Drawing.Point(552, 102)
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Size = New System.Drawing.Size(137, 57)
        Me.buttonEdit.TabIndex = 11
        Me.buttonEdit.Text = "Edit"
        Me.buttonEdit.UseVisualStyleBackColor = False
        '
        'textBoxSearch
        '
        Me.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBoxSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxSearch.Location = New System.Drawing.Point(749, 124)
        Me.textBoxSearch.Multiline = True
        Me.textBoxSearch.Name = "textBoxSearch"
        Me.textBoxSearch.Size = New System.Drawing.Size(221, 35)
        Me.textBoxSearch.TabIndex = 12
        Me.textBoxSearch.Text = "Search"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(297, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 31)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Halaman Materi"
        '
        'Label7
        '
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(239, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 54)
        Me.Label7.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.BlueViolet
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.Location = New System.Drawing.Point(956, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 26)
        Me.Label15.TabIndex = 85
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
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.labelNilai)
        Me.Panel1.Controls.Add(Me.labelTugas)
        Me.Panel1.Controls.Add(Me.labelListSiswa)
        Me.Panel1.Controls.Add(Me.labelQuiz)
        Me.Panel1.Controls.Add(Me.labelMateri)
        Me.Panel1.Controls.Add(Me.labelHome)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(-1, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 562)
        Me.Panel1.TabIndex = 84
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
        Me.Label11.Location = New System.Drawing.Point(76, 152)
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
        Me.Label1.Location = New System.Drawing.Point(39, 418)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 28)
        Me.Label1.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(39, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 28)
        Me.Label3.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(39, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 28)
        Me.Label4.TabIndex = 71
        '
        'Label16
        '
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.Location = New System.Drawing.Point(39, 298)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 28)
        Me.Label16.TabIndex = 70
        '
        'Label17
        '
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(39, 258)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 28)
        Me.Label17.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(39, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 28)
        Me.Label2.TabIndex = 66
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
        'labelListSiswa
        '
        Me.labelListSiswa.AutoSize = True
        Me.labelListSiswa.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelListSiswa.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelListSiswa.Location = New System.Drawing.Point(77, 423)
        Me.labelListSiswa.Name = "labelListSiswa"
        Me.labelListSiswa.Size = New System.Drawing.Size(88, 23)
        Me.labelListSiswa.TabIndex = 66
        Me.labelListSiswa.Text = "List Siswa"
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
        'FormMateriGuru
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.textBoxSearch)
        Me.Controls.Add(Me.buttonEdit)
        Me.Controls.Add(Me.buttonHapus)
        Me.Controls.Add(Me.buttonTambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMateriGuru"
        Me.Text = "FormMateri"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents buttonTambah As Button
    Friend WithEvents buttonHapus As Button
    Friend WithEvents buttonEdit As Button
    Friend WithEvents textBoxSearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents judul As DataGridViewTextBoxColumn
    Friend WithEvents deskripsi As DataGridViewTextBoxColumn
    Friend WithEvents link As DataGridViewTextBoxColumn
    Private WithEvents Label15 As Label
    Friend WithEvents Panel1 As Panel
    Private WithEvents Label13 As Label
    Private WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelNilai As Label
    Friend WithEvents labelTugas As Label
    Friend WithEvents labelListSiswa As Label
    Friend WithEvents labelQuiz As Label
    Friend WithEvents labelMateri As Label
    Friend WithEvents labelHome As Label
    Friend WithEvents Panel3 As Panel
End Class
