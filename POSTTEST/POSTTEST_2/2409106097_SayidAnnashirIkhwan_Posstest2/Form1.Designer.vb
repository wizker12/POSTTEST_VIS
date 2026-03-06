<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        btnhapus = New Button()
        btntambah = New Button()
        ListBox1 = New ListBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        txtgenre = New TextBox()
        txtjudulbuku = New TextBox()
        txthapus = New TextBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label5 = New Label()
        Label7 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(374, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 27)
        Label1.TabIndex = 0
        Label1.Text = "Tambah Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Cyan
        Label2.Location = New Point(279, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 21)
        Label2.TabIndex = 0
        Label2.Text = "Judul Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Cyan
        Label3.Location = New Point(299, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 21)
        Label3.TabIndex = 0
        Label3.Text = "Genre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(714, 49)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 34)
        Label4.TabIndex = 0
        Label4.Text = "Hapus Buku"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Cyan
        Label6.Location = New Point(616, 164)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 21)
        Label6.TabIndex = 0
        Label6.Text = "Judul Buku"
        ' 
        ' btnhapus
        ' 
        btnhapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnhapus.ForeColor = Color.Red
        btnhapus.Location = New Point(714, 241)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(75, 23)
        btnhapus.TabIndex = 1
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btntambah
        ' 
        btntambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btntambah.ForeColor = Color.Lime
        btntambah.Location = New Point(436, 241)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(75, 23)
        btntambah.TabIndex = 2
        btntambah.Text = "Tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(436, 323)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(367, 229)
        ListBox1.TabIndex = 3
        ' 
        ' txtgenre
        ' 
        txtgenre.Location = New Point(395, 195)
        txtgenre.Name = "txtgenre"
        txtgenre.Size = New Size(122, 23)
        txtgenre.TabIndex = 4
        ' 
        ' txtjudulbuku
        ' 
        txtjudulbuku.Location = New Point(395, 132)
        txtjudulbuku.Name = "txtjudulbuku"
        txtjudulbuku.Size = New Size(122, 23)
        txtjudulbuku.TabIndex = 5
        ' 
        ' txthapus
        ' 
        txthapus.Location = New Point(714, 166)
        txthapus.Name = "txthapus"
        txthapus.Size = New Size(148, 23)
        txthapus.TabIndex = 6
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.download1
        PictureBox2.Location = New Point(2, 440)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(168, 141)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Screenshot_2026_03_06_200626
        PictureBox3.Location = New Point(2, 264)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(168, 170)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.pngtree_green_check_mark_icon_flat_style_png_image_1986021
        PictureBox4.Location = New Point(176, 333)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(94, 85)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.images
        PictureBox5.Location = New Point(176, 482)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(94, 80)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label5.Location = New Point(19, 52)
        Label5.Name = "Label5"
        Label5.RightToLeft = RightToLeft.No
        Label5.Size = New Size(318, 21)
        Label5.TabIndex = 12
        Label5.Text = " kalian biar tidak lupa, bisa disini yaa ><"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label7.Location = New Point(12, 26)
        Label7.Name = "Label7"
        Label7.RightToLeft = RightToLeft.No
        Label7.Size = New Size(325, 21)
        Label7.TabIndex = 13
        Label7.Text = "Bagi yang ingin menyimpan Daftar buku "
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.wp16013529_arknights_endfield_wallpapers
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1260, 659)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(txtjudulbuku)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(txthapus)
        Controls.Add(txtgenre)
        Controls.Add(ListBox1)
        Controls.Add(btntambah)
        Controls.Add(btnhapus)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnhapus As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtgenre As TextBox
    Friend WithEvents txtjudulbuku As TextBox
    Friend WithEvents txthapus As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
