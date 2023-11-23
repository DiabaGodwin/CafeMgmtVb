<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOrders
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
        Panel1 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(158, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(888, 657)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.ForeColor = SystemColors.HotTrack
        Button1.Location = New Point(541, 748)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 47)
        Button1.TabIndex = 1
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(544, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 33)
        Label1.TabIndex = 2
        Label1.Text = "Orders List"
        ' 
        ' ViewOrders
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(1372, 831)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ViewOrders"
        Text = "ViewOrders"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
