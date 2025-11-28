<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegister))
        Me.buttonLogin = New System.Windows.Forms.Button()
        Me.textBoxPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonSignUp = New System.Windows.Forms.Button()
        Me.comboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.textBoxUsername = New System.Windows.Forms.TextBox()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.labelUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelFullname = New System.Windows.Forms.Label()
        Me.textBoxFullname = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonLogin
        '
        Me.buttonLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonLogin.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.buttonLogin.Location = New System.Drawing.Point(647, 453)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(75, 32)
        Me.buttonLogin.TabIndex = 21
        Me.buttonLogin.Text = "Login"
        Me.buttonLogin.UseVisualStyleBackColor = True
        '
        'textBoxPass
        '
        Me.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBoxPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxPass.Location = New System.Drawing.Point(526, 262)
        Me.textBoxPass.Multiline = True
        Me.textBoxPass.Name = "textBoxPass"
        Me.textBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBoxPass.Size = New System.Drawing.Size(347, 36)
        Me.textBoxPass.TabIndex = 16
        Me.textBoxPass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(522, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "I Have An Account"
        '
        'ButtonSignUp
        '
        Me.ButtonSignUp.BackColor = System.Drawing.Color.Indigo
        Me.ButtonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSignUp.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.ButtonSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSignUp.Location = New System.Drawing.Point(526, 390)
        Me.ButtonSignUp.Name = "ButtonSignUp"
        Me.ButtonSignUp.Size = New System.Drawing.Size(92, 54)
        Me.ButtonSignUp.TabIndex = 19
        Me.ButtonSignUp.Text = "Sign Up"
        Me.ButtonSignUp.UseVisualStyleBackColor = False
        '
        'comboBoxStatus
        '
        Me.comboBoxStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.comboBoxStatus.FormattingEnabled = True
        Me.comboBoxStatus.Items.AddRange(New Object() {"Guru", "Pelajar"})
        Me.comboBoxStatus.Location = New System.Drawing.Point(526, 327)
        Me.comboBoxStatus.Name = "comboBoxStatus"
        Me.comboBoxStatus.Size = New System.Drawing.Size(347, 36)
        Me.comboBoxStatus.TabIndex = 18
        '
        'labelStatus
        '
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.labelStatus.Location = New System.Drawing.Point(522, 301)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(56, 23)
        Me.labelStatus.TabIndex = 17
        Me.labelStatus.Text = "Status"
        '
        'textBoxUsername
        '
        Me.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBoxUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxUsername.Location = New System.Drawing.Point(526, 199)
        Me.textBoxUsername.Multiline = True
        Me.textBoxUsername.Name = "textBoxUsername"
        Me.textBoxUsername.Size = New System.Drawing.Size(347, 35)
        Me.textBoxUsername.TabIndex = 15
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.labelPassword.Location = New System.Drawing.Point(522, 237)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(80, 23)
        Me.labelPassword.TabIndex = 14
        Me.labelPassword.Text = "Password"
        '
        'labelUsername
        '
        Me.labelUsername.AutoSize = True
        Me.labelUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUsername.Location = New System.Drawing.Point(522, 172)
        Me.labelUsername.Name = "labelUsername"
        Me.labelUsername.Size = New System.Drawing.Size(87, 23)
        Me.labelUsername.TabIndex = 13
        Me.labelUsername.Text = "Username"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(487, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(423, 56)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Create Account"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 506)
        Me.Panel1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 40)
        Me.Label3.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(13, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(425, 258)
        Me.Label4.TabIndex = 13
        '
        'labelFullname
        '
        Me.labelFullname.AutoSize = True
        Me.labelFullname.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFullname.Location = New System.Drawing.Point(522, 108)
        Me.labelFullname.Name = "labelFullname"
        Me.labelFullname.Size = New System.Drawing.Size(87, 23)
        Me.labelFullname.TabIndex = 22
        Me.labelFullname.Text = "Full Name"
        '
        'textBoxFullname
        '
        Me.textBoxFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBoxFullname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxFullname.Location = New System.Drawing.Point(526, 134)
        Me.textBoxFullname.Multiline = True
        Me.textBoxFullname.Name = "textBoxFullname"
        Me.textBoxFullname.Size = New System.Drawing.Size(347, 35)
        Me.textBoxFullname.TabIndex = 23
        '
        'FormRegister
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(932, 503)
        Me.Controls.Add(Me.labelFullname)
        Me.Controls.Add(Me.labelPassword)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.textBoxFullname)
        Me.Controls.Add(Me.buttonLogin)
        Me.Controls.Add(Me.labelUsername)
        Me.Controls.Add(Me.textBoxPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonSignUp)
        Me.Controls.Add(Me.comboBoxStatus)
        Me.Controls.Add(Me.textBoxUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(932, 503)
        Me.Name = "FormRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRegister"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonLogin As Button
    Friend WithEvents textBoxPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonSignUp As Button
    Friend WithEvents comboBoxStatus As ComboBox
    Friend WithEvents labelStatus As Label
    Friend WithEvents textBoxUsername As TextBox
    Friend WithEvents labelPassword As Label
    Friend WithEvents labelUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelFullname As Label
    Friend WithEvents textBoxFullname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
