<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelUsername = New System.Windows.Forms.Label()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.textBoxUsername = New System.Windows.Forms.TextBox()
        Me.textBoxPass = New System.Windows.Forms.TextBox()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.comboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 506)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(13, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(425, 258)
        Me.Label4.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 40)
        Me.Label3.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(583, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 72)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelUsername
        '
        Me.labelUsername.AutoSize = True
        Me.labelUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUsername.Location = New System.Drawing.Point(521, 116)
        Me.labelUsername.Name = "labelUsername"
        Me.labelUsername.Size = New System.Drawing.Size(87, 23)
        Me.labelUsername.TabIndex = 2
        Me.labelUsername.Text = "Username"
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.labelPassword.Location = New System.Drawing.Point(521, 195)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(80, 23)
        Me.labelPassword.TabIndex = 3
        Me.labelPassword.Text = "Password"
        '
        'textBoxUsername
        '
        Me.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBoxUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxUsername.Location = New System.Drawing.Point(525, 143)
        Me.textBoxUsername.Multiline = True
        Me.textBoxUsername.Name = "textBoxUsername"
        Me.textBoxUsername.Size = New System.Drawing.Size(347, 35)
        Me.textBoxUsername.TabIndex = 4
        '
        'textBoxPass
        '
        Me.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBoxPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxPass.Location = New System.Drawing.Point(525, 221)
        Me.textBoxPass.Name = "textBoxPass"
        Me.textBoxPass.Size = New System.Drawing.Size(347, 34)
        Me.textBoxPass.TabIndex = 5
        Me.textBoxPass.UseSystemPasswordChar = True
        '
        'labelStatus
        '
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.labelStatus.Location = New System.Drawing.Point(521, 273)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(56, 23)
        Me.labelStatus.TabIndex = 6
        Me.labelStatus.Text = "Status"
        '
        'comboBoxStatus
        '
        Me.comboBoxStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.comboBoxStatus.FormattingEnabled = True
        Me.comboBoxStatus.Items.AddRange(New Object() {"Guru", "Pelajar"})
        Me.comboBoxStatus.Location = New System.Drawing.Point(525, 299)
        Me.comboBoxStatus.Name = "comboBoxStatus"
        Me.comboBoxStatus.Size = New System.Drawing.Size(347, 36)
        Me.comboBoxStatus.TabIndex = 7
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.Indigo
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLogin.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.ButtonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonLogin.Location = New System.Drawing.Point(525, 362)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(92, 54)
        Me.ButtonLogin.TabIndex = 8
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(521, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Create An Account"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.Button1.Location = New System.Drawing.Point(646, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "SignUp"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(932, 503)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textBoxPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.comboBoxStatus)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.textBoxUsername)
        Me.Controls.Add(Me.labelPassword)
        Me.Controls.Add(Me.labelUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(932, 503)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents labelUsername As Label
    Friend WithEvents labelPassword As Label
    Friend WithEvents textBoxUsername As TextBox
    Friend WithEvents textBoxPass As TextBox
    Friend WithEvents labelStatus As Label
    Friend WithEvents comboBoxStatus As ComboBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
