<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        menuInput = New ToolStripMenuItem()
        menuLihat = New ToolStripMenuItem()
        menuSimpan = New ToolStripMenuItem()
        menuBuka = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {menuInput, menuLihat, menuSimpan, menuBuka, menuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(862, 24)
        MenuStrip1.TabIndex = 1
        ' 
        ' menuInput
        ' 
        menuInput.Name = "menuInput"
        menuInput.Size = New Size(73, 20)
        menuInput.Text = "Input data"
        ' 
        ' menuLihat
        ' 
        menuLihat.Name = "menuLihat"
        menuLihat.Size = New Size(75, 20)
        menuLihat.Text = "Lihat kartu"
        ' 
        ' menuSimpan
        ' 
        menuSimpan.Name = "menuSimpan"
        menuSimpan.Size = New Size(86, 20)
        menuSimpan.Text = "Simpan Data"
        ' 
        ' menuBuka
        ' 
        menuBuka.Name = "menuBuka"
        menuBuka.Size = New Size(71, 20)
        menuBuka.Text = "Buka data"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(52, 20)
        menuKeluar.Text = "Keluar"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("PKMN RBYGSC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(274, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(367, 21)
        Label1.TabIndex = 2
        Label1.Text = "Selamat Datang Trainer!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("PKMN RBYGSC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(240, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(441, 21)
        Label2.TabIndex = 3
        Label2.Text = "Mulai Petualanganmu Sekarang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("PKMN RBYGSC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(274, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(369, 21)
        Label3.TabIndex = 4
        Label3.Text = "Buat Kartu Komunitasmu!"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(305, 419)
        Label4.Name = "Label4"
        Label4.Size = New Size(247, 14)
        Label4.TabIndex = 5
        Label4.Text = "Your Journey Starts Here!"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Desain_tanpa_judul
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(862, 536)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuInput As ToolStripMenuItem
    Friend WithEvents menuLihat As ToolStripMenuItem
    Friend WithEvents menuSimpan As ToolStripMenuItem
    Friend WithEvents menuBuka As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class