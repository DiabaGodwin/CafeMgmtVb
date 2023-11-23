<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        LoginBtn = New Button()
        PasswordTb = New TextBox()
        UnameTb = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.HotTrack
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(450, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(384, 430)
        Panel1.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(316, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 46)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(79, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 31)
        Label2.TabIndex = 0
        Label2.Text = "ByMyCodeSpace"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(46, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(283, 31)
        Label1.TabIndex = 0
        Label1.Text = "CafeManagementSystem"
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = SystemColors.HotTrack
        LoginBtn.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LoginBtn.ForeColor = Color.White
        LoginBtn.Location = New Point(90, 312)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(181, 43)
        LoginBtn.TabIndex = 11
        LoginBtn.Text = "LoginBtn"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' PasswordTb
        ' 
        PasswordTb.Font = New Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PasswordTb.Location = New Point(200, 250)
        PasswordTb.Name = "PasswordTb"
        PasswordTb.Size = New Size(185, 32)
        PasswordTb.TabIndex = 8
        ' 
        ' UnameTb
        ' 
        UnameTb.Font = New Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point)
        UnameTb.Location = New Point(200, 184)
        UnameTb.Name = "UnameTb"
        UnameTb.Size = New Size(185, 32)
        UnameTb.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.HotTrack
        Label6.Location = New Point(139, 386)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 31)
        Label6.TabIndex = 4
        Label6.Text = "Seller"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.HotTrack
        Label5.Location = New Point(42, 248)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 31)
        Label5.TabIndex = 5
        Label5.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.HotTrack
        Label4.Location = New Point(42, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 31)
        Label4.TabIndex = 6
        Label4.Text = "UserName"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(153, 79)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 68)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(139, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 31)
        Label3.TabIndex = 7
        Label3.Text = "MyCafe"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(827, 426)
        Controls.Add(Panel1)
        Controls.Add(LoginBtn)
        Controls.Add(PasswordTb)
        Controls.Add(UnameTb)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents UnameTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
