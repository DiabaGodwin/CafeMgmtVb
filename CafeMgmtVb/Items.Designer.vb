<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Items))
        Panel1 = New Panel()
        ItemDGV = New DataGridView()
        Button1 = New Button()
        Panel2 = New Panel()
        ResetBtn = New Button()
        DeleteBtn = New Button()
        CatCb = New ComboBox()
        EditBtn = New Button()
        Label1 = New Label()
        AddBtn = New Button()
        QuantityTb = New TextBox()
        ItPriceTb = New TextBox()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        ItNameTb = New TextBox()
        Label4 = New Label()
        Label8 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        CatTb = New TextBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(ItemDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(ItemDGV)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(CatTb)
        Panel1.Location = New Point(123, 58)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1026, 722)
        Panel1.TabIndex = 0
        ' 
        ' ItemDGV
        ' 
        ItemDGV.BackgroundColor = Color.White
        ItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemDGV.Location = New Point(77, 457)
        ItemDGV.Name = "ItemDGV"
        ItemDGV.RowHeadersWidth = 51
        ItemDGV.RowTemplate.Height = 29
        ItemDGV.Size = New Size(864, 249)
        ItemDGV.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(486, 139)
        Button1.Name = "Button1"
        Button1.Size = New Size(203, 42)
        Button1.TabIndex = 7
        Button1.Text = "Add Category"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(ResetBtn)
        Panel2.Controls.Add(DeleteBtn)
        Panel2.Controls.Add(CatCb)
        Panel2.Controls.Add(EditBtn)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(AddBtn)
        Panel2.Controls.Add(QuantityTb)
        Panel2.Controls.Add(ItPriceTb)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(ItNameTb)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(77, 202)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(864, 201)
        Panel2.TabIndex = 6
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = SystemColors.HotTrack
        ResetBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ResetBtn.ForeColor = Color.White
        ResetBtn.Location = New Point(588, 147)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(130, 42)
        ResetBtn.TabIndex = 7
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = SystemColors.HotTrack
        DeleteBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DeleteBtn.ForeColor = Color.White
        DeleteBtn.Location = New Point(414, 147)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(130, 42)
        DeleteBtn.TabIndex = 7
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' CatCb
        ' 
        CatCb.FormattingEnabled = True
        CatCb.Location = New Point(276, 104)
        CatCb.Name = "CatCb"
        CatCb.Size = New Size(175, 28)
        CatCb.TabIndex = 5
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = SystemColors.HotTrack
        EditBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EditBtn.ForeColor = Color.White
        EditBtn.Location = New Point(244, 147)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(130, 42)
        EditBtn.TabIndex = 7
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(318, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 31)
        Label1.TabIndex = 1
        Label1.Text = "Categories"
        ' 
        ' AddBtn
        ' 
        AddBtn.BackColor = SystemColors.HotTrack
        AddBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        AddBtn.ForeColor = Color.White
        AddBtn.Location = New Point(73, 147)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(130, 42)
        AddBtn.TabIndex = 7
        AddBtn.Text = "Add"
        AddBtn.UseVisualStyleBackColor = False
        ' 
        ' QuantityTb
        ' 
        QuantityTb.Font = New Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point)
        QuantityTb.Location = New Point(703, 100)
        QuantityTb.Name = "QuantityTb"
        QuantityTb.Size = New Size(142, 32)
        QuantityTb.TabIndex = 3
        ' 
        ' ItPriceTb
        ' 
        ItPriceTb.Font = New Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ItPriceTb.Location = New Point(524, 101)
        ItPriceTb.Name = "ItPriceTb"
        ItPriceTb.Size = New Size(142, 32)
        ItPriceTb.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.HotTrack
        Label5.Location = New Point(62, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 31)
        Label5.TabIndex = 1
        Label5.Text = "Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(395, 207)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(142, 32)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(558, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 31)
        Label2.TabIndex = 1
        Label2.Text = "Price"
        ' 
        ' ItNameTb
        ' 
        ItNameTb.Font = New Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ItNameTb.Location = New Point(15, 100)
        ItNameTb.Name = "ItNameTb"
        ItNameTb.Size = New Size(185, 32)
        ItNameTb.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.HotTrack
        Label4.Location = New Point(716, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 31)
        Label4.TabIndex = 1
        Label4.Text = "Quantity"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.HotTrack
        Label8.Location = New Point(384, 423)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 31)
        Label8.TabIndex = 1
        Label8.Text = "Items List"
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.HotTrack
        Label6.Location = New Point(149, 150)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 31)
        Label6.TabIndex = 1
        Label6.Text = "Name"
        ' 
        ' CatTb
        ' 
        CatTb.Font = New Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CatTb.Location = New Point(285, 149)
        CatTb.Name = "CatTb"
        CatTb.Size = New Size(185, 32)
        CatTb.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Underline, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(12, 792)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 31)
        Label7.TabIndex = 1
        Label7.Text = "LogOut"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1206, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(67, 59)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Items
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(1336, 848)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        FormBorderStyle = FormBorderStyle.None
        Name = "Items"
        Text = "Items"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ItemDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CatCb As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ItNameTb As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ItPriceTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CatTb As TextBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents QuantityTb As TextBox
    Friend WithEvents ResetBtn As Button
End Class
