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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        btnGambar = New Button()
        txtGoldar = New TextBox()
        txtAlamat = New TextBox()
        txtTinggi = New TextBox()
        txtNama = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        GroupBoxHobi = New GroupBox()
        cbOtomotif = New CheckBox()
        cbGame = New CheckBox()
        cbMelukis = New CheckBox()
        cbMembaca = New CheckBox()
        cbBersosialisasi = New CheckBox()
        cbBerdebat = New CheckBox()
        cbMenonton = New CheckBox()
        cbPatem = New CheckBox()
        cbBalapan = New CheckBox()
        cbOlahraga = New CheckBox()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        GroupBoxJK = New GroupBox()
        btnCetak = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxHobi.SuspendLayout()
        GroupBoxJK.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 156)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 303)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnGambar
        ' 
        btnGambar.Font = New Font("OCR-B", 9F)
        btnGambar.Location = New Point(32, 483)
        btnGambar.Name = "btnGambar"
        btnGambar.Size = New Size(146, 36)
        btnGambar.TabIndex = 1
        btnGambar.Text = "Ambil Gambar"
        btnGambar.UseVisualStyleBackColor = True
        ' 
        ' txtGoldar
        ' 
        txtGoldar.Location = New Point(406, 335)
        txtGoldar.Name = "txtGoldar"
        txtGoldar.Size = New Size(200, 23)
        txtGoldar.TabIndex = 2
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(406, 385)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(200, 23)
        txtAlamat.TabIndex = 3
        ' 
        ' txtTinggi
        ' 
        txtTinggi.Location = New Point(406, 292)
        txtTinggi.Name = "txtTinggi"
        txtTinggi.Size = New Size(200, 23)
        txtTinggi.TabIndex = 4
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(406, 195)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 23)
        txtNama.TabIndex = 5
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(406, 242)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 6
        ' 
        ' GroupBoxHobi
        ' 
        GroupBoxHobi.BackColor = Color.Transparent
        GroupBoxHobi.Controls.Add(cbOtomotif)
        GroupBoxHobi.Controls.Add(cbGame)
        GroupBoxHobi.Controls.Add(cbMelukis)
        GroupBoxHobi.Controls.Add(cbMembaca)
        GroupBoxHobi.Controls.Add(cbBersosialisasi)
        GroupBoxHobi.Controls.Add(cbBerdebat)
        GroupBoxHobi.Controls.Add(cbMenonton)
        GroupBoxHobi.Controls.Add(cbPatem)
        GroupBoxHobi.Controls.Add(cbBalapan)
        GroupBoxHobi.Controls.Add(cbOlahraga)
        GroupBoxHobi.Location = New Point(658, 227)
        GroupBoxHobi.Name = "GroupBoxHobi"
        GroupBoxHobi.Size = New Size(276, 177)
        GroupBoxHobi.TabIndex = 7
        GroupBoxHobi.TabStop = False
        GroupBoxHobi.Text = "Hobby kamu"
        ' 
        ' cbOtomotif
        ' 
        cbOtomotif.AutoSize = True
        cbOtomotif.BackColor = SystemColors.ButtonHighlight
        cbOtomotif.Location = New Point(151, 137)
        cbOtomotif.Name = "cbOtomotif"
        cbOtomotif.Size = New Size(75, 19)
        cbOtomotif.TabIndex = 21
        cbOtomotif.Text = "Otomotif"
        cbOtomotif.UseVisualStyleBackColor = False
        ' 
        ' cbGame
        ' 
        cbGame.AutoSize = True
        cbGame.BackColor = SystemColors.ButtonHighlight
        cbGame.Location = New Point(40, 36)
        cbGame.Name = "cbGame"
        cbGame.Size = New Size(57, 19)
        cbGame.TabIndex = 11
        cbGame.Text = "Game"
        cbGame.UseVisualStyleBackColor = False
        ' 
        ' cbMelukis
        ' 
        cbMelukis.AutoSize = True
        cbMelukis.BackColor = SystemColors.ButtonHighlight
        cbMelukis.Location = New Point(151, 111)
        cbMelukis.Name = "cbMelukis"
        cbMelukis.Size = New Size(67, 19)
        cbMelukis.TabIndex = 20
        cbMelukis.Text = "Melukis"
        cbMelukis.UseVisualStyleBackColor = False
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.BackColor = SystemColors.ButtonHighlight
        cbMembaca.Location = New Point(40, 61)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(79, 19)
        cbMembaca.TabIndex = 13
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = False
        ' 
        ' cbBersosialisasi
        ' 
        cbBersosialisasi.AutoSize = True
        cbBersosialisasi.BackColor = SystemColors.ButtonHighlight
        cbBersosialisasi.Location = New Point(151, 86)
        cbBersosialisasi.Name = "cbBersosialisasi"
        cbBersosialisasi.Size = New Size(94, 19)
        cbBersosialisasi.TabIndex = 19
        cbBersosialisasi.Text = "Bersosialisasi"
        cbBersosialisasi.UseVisualStyleBackColor = False
        ' 
        ' cbBerdebat
        ' 
        cbBerdebat.AutoSize = True
        cbBerdebat.BackColor = SystemColors.ButtonHighlight
        cbBerdebat.Location = New Point(40, 86)
        cbBerdebat.Name = "cbBerdebat"
        cbBerdebat.Size = New Size(73, 19)
        cbBerdebat.TabIndex = 14
        cbBerdebat.Text = "Berdebat"
        cbBerdebat.UseVisualStyleBackColor = False
        ' 
        ' cbMenonton
        ' 
        cbMenonton.AutoSize = True
        cbMenonton.BackColor = SystemColors.ButtonHighlight
        cbMenonton.Location = New Point(151, 61)
        cbMenonton.Name = "cbMenonton"
        cbMenonton.Size = New Size(106, 19)
        cbMenonton.TabIndex = 18
        cbMenonton.Text = "Menonton film"
        cbMenonton.UseVisualStyleBackColor = False
        ' 
        ' cbPatem
        ' 
        cbPatem.AutoSize = True
        cbPatem.BackColor = SystemColors.ButtonHighlight
        cbPatem.Location = New Point(40, 111)
        cbPatem.Name = "cbPatem"
        cbPatem.Size = New Size(63, 19)
        cbPatem.TabIndex = 15
        cbPatem.Text = "PATEM"
        cbPatem.UseVisualStyleBackColor = False
        ' 
        ' cbBalapan
        ' 
        cbBalapan.AutoSize = True
        cbBalapan.BackColor = SystemColors.ButtonHighlight
        cbBalapan.Location = New Point(151, 36)
        cbBalapan.Name = "cbBalapan"
        cbBalapan.Size = New Size(68, 19)
        cbBalapan.TabIndex = 17
        cbBalapan.Text = "Balapan"
        cbBalapan.UseVisualStyleBackColor = False
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.BackColor = SystemColors.ButtonHighlight
        cbOlahraga.Location = New Point(40, 136)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(74, 19)
        cbOlahraga.TabIndex = 16
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = False
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.BackColor = Color.SkyBlue
        rbLaki.Font = New Font("OCR-B", 9F)
        rbLaki.Location = New Point(6, 22)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(137, 23)
        rbLaki.TabIndex = 8
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.UseVisualStyleBackColor = False
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.BackColor = Color.SkyBlue
        rbPerempuan.Font = New Font("OCR-B", 9F)
        rbPerempuan.Location = New Point(161, 21)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(117, 23)
        rbPerempuan.TabIndex = 9
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = False
        ' 
        ' GroupBoxJK
        ' 
        GroupBoxJK.BackColor = Color.Transparent
        GroupBoxJK.Controls.Add(rbPerempuan)
        GroupBoxJK.Controls.Add(rbLaki)
        GroupBoxJK.Font = New Font("OCR-B", 9F)
        GroupBoxJK.Location = New Point(230, 433)
        GroupBoxJK.Name = "GroupBoxJK"
        GroupBoxJK.Size = New Size(297, 58)
        GroupBoxJK.TabIndex = 10
        GroupBoxJK.TabStop = False
        GroupBoxJK.Text = "Jenis Kelamin"
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.Lime
        btnCetak.Font = New Font("OCR-B", 9F)
        btnCetak.Location = New Point(539, 447)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(367, 36)
        btnCetak.TabIndex = 12
        btnCetak.Text = "CETAK!"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("OCR-B", 9F)
        Label1.Location = New Point(237, 199)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 19)
        Label1.TabIndex = 13
        Label1.Text = "Nama Lengkap"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Font = New Font("OCR-B", 9F)
        Label2.Location = New Point(237, 338)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 19)
        Label2.TabIndex = 14
        Label2.Text = "Golongan Darah"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaption
        Label3.Font = New Font("OCR-B", 9F)
        Label3.Location = New Point(237, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 19)
        Label3.TabIndex = 15
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaption
        Label4.Font = New Font("OCR-B", 9F)
        Label4.Location = New Point(237, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 19)
        Label4.TabIndex = 16
        Label4.Text = "Tinggi Badan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaption
        Label5.Font = New Font("OCR-B", 9F)
        Label5.Location = New Point(252, 385)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 19)
        Label5.TabIndex = 17
        Label5.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("OCR-B", 15.75F, FontStyle.Bold)
        Label6.Location = New Point(237, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(490, 34)
        Label6.TabIndex = 18
        Label6.Text = "SELAMAT DATANG WARGA BARU"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("OCR-B", 11.25F, FontStyle.Bold)
        Label7.Location = New Point(315, 43)
        Label7.Name = "Label7"
        Label7.Size = New Size(332, 24)
        Label7.TabIndex = 19
        Label7.Text = "SILAHKAN BUAT KTP KAMU "
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.banner
        PictureBox2.Location = New Point(12, -29)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(220, 209)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(965, 586)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCetak)
        Controls.Add(GroupBoxJK)
        Controls.Add(GroupBoxHobi)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtNama)
        Controls.Add(txtTinggi)
        Controls.Add(txtAlamat)
        Controls.Add(txtGoldar)
        Controls.Add(btnGambar)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxHobi.ResumeLayout(False)
        GroupBoxHobi.PerformLayout()
        GroupBoxJK.ResumeLayout(False)
        GroupBoxJK.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGambar As Button
    Friend WithEvents txtGoldar As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBoxHobi As GroupBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents GroupBoxJK As GroupBox
    Friend WithEvents cbGame As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbBerdebat As CheckBox
    Friend WithEvents cbPatem As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbBalapan As CheckBox
    Friend WithEvents cbMenonton As CheckBox
    Friend WithEvents cbBersosialisasi As CheckBox
    Friend WithEvents cbMelukis As CheckBox
    Friend WithEvents cbOtomotif As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbLaki.CheckedChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBoxJK.Enter

    End Sub

    Friend WithEvents PictureBox2 As PictureBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
