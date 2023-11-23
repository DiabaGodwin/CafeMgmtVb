<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Orders))
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        Label3 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        ItemDGV = New DataGridView()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label8 = New Label()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(ItemDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1143, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(57, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(98, 397)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(864, 249)
        DataGridView1.TabIndex = 8
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(40, 119)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(175, 28)
        ComboBox1.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.HotTrack
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(221, 108)
        Button2.Name = "Button2"
        Button2.Size = New Size(130, 42)
        Button2.TabIndex = 7
        Button2.Text = "Refresh"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(402, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 31)
        Label3.TabIndex = 1
        Label3.Text = "Manage Items"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Underline, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(38, 782)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 31)
        Label7.TabIndex = 4
        Label7.Text = "LogOut"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(40, 287)
        Button1.Name = "Button1"
        Button1.Size = New Size(203, 42)
        Button1.TabIndex = 7
        Button1.Text = "Add Category"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(ItemDGV)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(150, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1026, 722)
        Panel1.TabIndex = 3
        ' 
        ' ItemDGV
        ' 
        ItemDGV.BackgroundColor = Color.White
        ItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemDGV.Location = New Point(406, 96)
        ItemDGV.Name = "ItemDGV"
        ItemDGV.RowHeadersWidth = 51
        ItemDGV.RowTemplate.Height = 29
        ItemDGV.Size = New Size(535, 177)
        ItemDGV.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.HotTrack
        Label5.Location = New Point(417, 662)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 31)
        Label5.TabIndex = 1
        Label5.Text = "Total"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.HotTrack
        Label4.Location = New Point(384, 360)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 31)
        Label4.TabIndex = 1
        Label4.Text = "Your Order"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(462, 287)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 31)
        Label2.TabIndex = 1
        Label2.Text = "Quantity"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(40, 184)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 31)
        Label1.TabIndex = 1
        Label1.Text = "Name Categories"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.HotTrack
        Label8.Location = New Point(577, 62)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 31)
        Label8.TabIndex = 1
        Label8.Text = "Items List"
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.HotTrack
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(631, 662)
        Button5.Name = "Button5"
        Button5.Size = New Size(130, 42)
        Button5.TabIndex = 7
        Button5.Text = "View Orders"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.HotTrack
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(196, 662)
        Button4.Name = "Button4"
        Button4.Size = New Size(130, 42)
        Button4.TabIndex = 7
        Button4.Text = "Print"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.HotTrack
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(745, 287)
        Button3.Name = "Button3"
        Button3.Size = New Size(130, 42)
        Button3.TabIndex = 7
        Button3.Text = "Add To Bill"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(40, 241)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(203, 32)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(574, 289)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(145, 32)
        TextBox1.TabIndex = 2
        ' 
        ' Orders
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(1235, 826)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Orders"
        Text = "Orders"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ItemDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
End Class
