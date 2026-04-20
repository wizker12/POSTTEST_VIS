<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInput))
        OpenFileDialog1 = New OpenFileDialog()
        TabPage3 = New TabPage()
        GroupBox1 = New GroupBox()
        Label9 = New Label()
        picFoto = New PictureBox()
        btnBrowse = New Button()
        btnCetak = New Button()
        btnSimpan = New Button()
        chkPvp = New CheckBox()
        chkBadge = New CheckBox()
        chkBreeding = New CheckBox()
        chkExploring = New CheckBox()
        chkTraining = New CheckBox()
        chkTrading = New CheckBox()
        chkBattle = New CheckBox()
        chkTangkap = New CheckBox()
        rbChampion = New RadioButton()
        rbAdmin = New RadioButton()
        rbTrainer = New RadioButton()
        rbGym = New RadioButton()
        TabPage2 = New TabPage()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        mtbHP = New MaskedTextBox()
        TabPage1 = New TabPage()
        Label5 = New Label()
        cmbKomunitas = New ComboBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label4 = New Label()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        txtID = New TextBox()
        txtNama = New TextBox()
        Label1 = New Label()
        TabPokemon = New TabControl()
        TabPage4 = New TabPage()
        PictureBox9 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        cbTyranitar = New CheckBox()
        cbMachamp = New CheckBox()
        cbCharmander = New CheckBox()
        cbDitto = New CheckBox()
        cbSnorlax = New CheckBox()
        cbPikachu = New CheckBox()
        cbGyarados = New CheckBox()
        cbSquirtle = New CheckBox()
        cbBulbasaur = New CheckBox()
        TabPage3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPokemon.SuspendLayout()
        TabPage4.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(865, 495)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = My.Resources.Resources.pikachuuu
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(picFoto)
        GroupBox1.Controls.Add(btnBrowse)
        GroupBox1.Controls.Add(btnCetak)
        GroupBox1.Controls.Add(btnSimpan)
        GroupBox1.Controls.Add(chkPvp)
        GroupBox1.Controls.Add(chkBadge)
        GroupBox1.Controls.Add(chkBreeding)
        GroupBox1.Controls.Add(chkExploring)
        GroupBox1.Controls.Add(chkTraining)
        GroupBox1.Controls.Add(chkTrading)
        GroupBox1.Controls.Add(chkBattle)
        GroupBox1.Controls.Add(chkTangkap)
        GroupBox1.Controls.Add(rbChampion)
        GroupBox1.Controls.Add(rbAdmin)
        GroupBox1.Controls.Add(rbTrainer)
        GroupBox1.Controls.Add(rbGym)
        GroupBox1.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Gold
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(869, 504)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.Orange
        Label9.Location = New Point(17, 151)
        Label9.Name = "Label9"
        Label9.Size = New Size(148, 18)
        Label9.TabIndex = 16
        Label9.Text = "Hobby kamu"
        ' 
        ' picFoto
        ' 
        picFoto.BackgroundImageLayout = ImageLayout.Stretch
        picFoto.Location = New Point(556, 49)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(196, 310)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 15
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.ForeColor = Color.Red
        btnBrowse.Location = New Point(580, 383)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(131, 23)
        btnBrowse.TabIndex = 14
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.ForeColor = Color.Lime
        btnCetak.Location = New Point(249, 383)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(120, 23)
        btnCetak.TabIndex = 13
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.ForeColor = Color.Blue
        btnSimpan.Location = New Point(79, 383)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(109, 23)
        btnSimpan.TabIndex = 12
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' chkPvp
        ' 
        chkPvp.AutoSize = True
        chkPvp.Location = New Point(311, 243)
        chkPvp.Name = "chkPvp"
        chkPvp.Size = New Size(147, 22)
        chkPvp.TabIndex = 11
        chkPvp.Text = "PvP Online"
        chkPvp.UseVisualStyleBackColor = True
        ' 
        ' chkBadge
        ' 
        chkBadge.AutoSize = True
        chkBadge.Location = New Point(311, 306)
        chkBadge.Name = "chkBadge"
        chkBadge.Size = New Size(196, 22)
        chkBadge.TabIndex = 10
        chkBadge.Text = "Koleksi Badge"
        chkBadge.UseVisualStyleBackColor = True
        ' 
        ' chkBreeding
        ' 
        chkBreeding.AutoSize = True
        chkBreeding.Location = New Point(311, 184)
        chkBreeding.Name = "chkBreeding"
        chkBreeding.Size = New Size(137, 22)
        chkBreeding.TabIndex = 9
        chkBreeding.Text = "Breeding"
        chkBreeding.UseVisualStyleBackColor = True
        ' 
        ' chkExploring
        ' 
        chkExploring.AutoSize = True
        chkExploring.Location = New Point(148, 306)
        chkExploring.Name = "chkExploring"
        chkExploring.Size = New Size(144, 22)
        chkExploring.TabIndex = 8
        chkExploring.Text = "Exploring"
        chkExploring.UseVisualStyleBackColor = True
        ' 
        ' chkTraining
        ' 
        chkTraining.AutoSize = True
        chkTraining.Location = New Point(18, 243)
        chkTraining.Name = "chkTraining"
        chkTraining.Size = New Size(125, 22)
        chkTraining.TabIndex = 7
        chkTraining.Text = "Training"
        chkTraining.UseVisualStyleBackColor = True
        ' 
        ' chkTrading
        ' 
        chkTrading.AutoSize = True
        chkTrading.Location = New Point(149, 243)
        chkTrading.Name = "chkTrading"
        chkTrading.Size = New Size(122, 22)
        chkTrading.TabIndex = 6
        chkTrading.Text = "Trading"
        chkTrading.UseVisualStyleBackColor = True
        ' 
        ' chkBattle
        ' 
        chkBattle.AutoSize = True
        chkBattle.Location = New Point(17, 296)
        chkBattle.Name = "chkBattle"
        chkBattle.Size = New Size(105, 22)
        chkBattle.TabIndex = 5
        chkBattle.Text = "Battle"
        chkBattle.UseVisualStyleBackColor = True
        ' 
        ' chkTangkap
        ' 
        chkTangkap.AutoSize = True
        chkTangkap.Location = New Point(18, 184)
        chkTangkap.Name = "chkTangkap"
        chkTangkap.Size = New Size(274, 22)
        chkTangkap.TabIndex = 4
        chkTangkap.Text = "Menangkap Pokémon"
        chkTangkap.UseVisualStyleBackColor = True
        ' 
        ' rbChampion
        ' 
        rbChampion.AutoSize = True
        rbChampion.Location = New Point(194, 94)
        rbChampion.Name = "rbChampion"
        rbChampion.Size = New Size(136, 22)
        rbChampion.TabIndex = 3
        rbChampion.TabStop = True
        rbChampion.Text = "Champion"
        rbChampion.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(18, 94)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(93, 22)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbTrainer
        ' 
        rbTrainer.AutoSize = True
        rbTrainer.Location = New Point(194, 49)
        rbTrainer.Name = "rbTrainer"
        rbTrainer.Size = New Size(121, 22)
        rbTrainer.TabIndex = 1
        rbTrainer.TabStop = True
        rbTrainer.Text = "Trainer"
        rbTrainer.UseVisualStyleBackColor = True
        ' 
        ' rbGym
        ' 
        rbGym.AutoSize = True
        rbGym.Location = New Point(18, 49)
        rbGym.Name = "rbGym"
        rbGym.Size = New Size(170, 22)
        rbGym.TabIndex = 0
        rbGym.TabStop = True
        rbGym.Text = "Gym Leader"
        rbGym.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = My.Resources.Resources.pikachuuu
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(mtbHP)
        TabPage2.Font = New Font("PKMN RBYGSC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabPage2.ForeColor = Color.Gold
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(865, 495)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("PKMN RBYGSC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAlamat.Location = New Point(401, 164)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(235, 23)
        txtAlamat.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("PKMN RBYGSC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(401, 109)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(235, 22)
        txtEmail.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(75, 144)
        Label8.Name = "Label8"
        Label8.Size = New Size(107, 21)
        Label8.TabIndex = 4
        Label8.Text = "Alamat"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(75, 98)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 21)
        Label7.TabIndex = 2
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(71, 56)
        Label6.Name = "Label6"
        Label6.Size = New Size(220, 21)
        Label6.TabIndex = 1
        Label6.Text = "Nomot Telepon"
        ' 
        ' mtbHP
        ' 
        mtbHP.Font = New Font("PKMN RBYGSC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mtbHP.Location = New Point(401, 56)
        mtbHP.Mask = "0000-0000-0000"
        mtbHP.Name = "mtbHP"
        mtbHP.Size = New Size(235, 22)
        mtbHP.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources.pikachuuu
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(cmbKomunitas)
        TabPage1.Controls.Add(RadioButton2)
        TabPage1.Controls.Add(RadioButton1)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(Label1)
        TabPage1.Font = New Font("PKMN RBYGSC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabPage1.ForeColor = Color.Gold
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(865, 495)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(41, 239)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 21)
        Label5.TabIndex = 9
        Label5.Text = "Region"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Kanto", "Johto", "Hoenn", "Sinnoh", "Unova", "Kalos", "Alola", "Galar"})
        cmbKomunitas.Location = New Point(315, 239)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(171, 26)
        cmbKomunitas.TabIndex = 1
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.ForeColor = Color.HotPink
        RadioButton2.Location = New Point(312, 184)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(188, 25)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.ForeColor = Color.Blue
        RadioButton1.Location = New Point(506, 186)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(176, 25)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki -Laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(41, 188)
        Label4.Name = "Label4"
        Label4.Size = New Size(196, 21)
        Label4.TabIndex = 6
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(206, 21)
        Label3.TabIndex = 5
        Label3.Text = "Tanggal Lahir"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("PKMN RBYGSC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(315, 133)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(385, 22)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 21)
        Label2.TabIndex = 3
        Label2.Text = "Trainer ID"
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("PKMN RBYGSC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtID.Location = New Point(315, 80)
        txtID.Name = "txtID"
        txtID.Size = New Size(336, 22)
        txtID.TabIndex = 2
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("PKMN RBYGSC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(315, 38)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(336, 22)
        txtNama.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(41, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 18)
        Label1.TabIndex = 0
        Label1.Text = "Nama Trainer"
        ' 
        ' TabPokemon
        ' 
        TabPokemon.Controls.Add(TabPage1)
        TabPokemon.Controls.Add(TabPage2)
        TabPokemon.Controls.Add(TabPage4)
        TabPokemon.Controls.Add(TabPage3)
        TabPokemon.Cursor = Cursors.IBeam
        TabPokemon.Location = New Point(0, 2)
        TabPokemon.Name = "TabPokemon"
        TabPokemon.SelectedIndex = 0
        TabPokemon.Size = New Size(873, 523)
        TabPokemon.TabIndex = 0
        ' 
        ' TabPage4
        ' 
        TabPage4.BackgroundImage = My.Resources.Resources.download
        TabPage4.BackgroundImageLayout = ImageLayout.Stretch
        TabPage4.Controls.Add(PictureBox9)
        TabPage4.Controls.Add(PictureBox8)
        TabPage4.Controls.Add(PictureBox7)
        TabPage4.Controls.Add(PictureBox6)
        TabPage4.Controls.Add(PictureBox5)
        TabPage4.Controls.Add(PictureBox4)
        TabPage4.Controls.Add(PictureBox3)
        TabPage4.Controls.Add(PictureBox2)
        TabPage4.Controls.Add(PictureBox1)
        TabPage4.Controls.Add(cbTyranitar)
        TabPage4.Controls.Add(cbMachamp)
        TabPage4.Controls.Add(cbCharmander)
        TabPage4.Controls.Add(cbDitto)
        TabPage4.Controls.Add(cbSnorlax)
        TabPage4.Controls.Add(cbPikachu)
        TabPage4.Controls.Add(cbGyarados)
        TabPage4.Controls.Add(cbSquirtle)
        TabPage4.Controls.Add(cbBulbasaur)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(865, 495)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Pilih Pokemon"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), Image)
        PictureBox9.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox9.Location = New Point(676, 363)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(134, 101)
        PictureBox9.TabIndex = 17
        PictureBox9.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Location = New Point(43, 363)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(136, 101)
        PictureBox8.TabIndex = 16
        PictureBox8.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(353, 363)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(132, 101)
        PictureBox7.TabIndex = 15
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(669, 211)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(141, 94)
        PictureBox6.TabIndex = 14
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(680, 83)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(137, 77)
        PictureBox5.TabIndex = 13
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(353, 211)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(132, 94)
        PictureBox4.TabIndex = 12
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(38, 211)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(137, 94)
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(353, 83)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(132, 77)
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(43, 83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(136, 77)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' cbTyranitar
        ' 
        cbTyranitar.AutoSize = True
        cbTyranitar.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Bold)
        cbTyranitar.ForeColor = Color.DarkOrange
        cbTyranitar.Location = New Point(353, 187)
        cbTyranitar.Name = "cbTyranitar"
        cbTyranitar.Size = New Size(148, 22)
        cbTyranitar.TabIndex = 8
        cbTyranitar.Text = "Tyranitar"
        cbTyranitar.UseVisualStyleBackColor = True
        ' 
        ' cbMachamp
        ' 
        cbMachamp.AutoSize = True
        cbMachamp.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Bold)
        cbMachamp.ForeColor = Color.DarkOrange
        cbMachamp.Location = New Point(676, 185)
        cbMachamp.Name = "cbMachamp"
        cbMachamp.Size = New Size(134, 22)
        cbMachamp.TabIndex = 7
        cbMachamp.Text = "Machamp"
        cbMachamp.UseVisualStyleBackColor = True
        ' 
        ' cbCharmander
        ' 
        cbCharmander.AutoSize = True
        cbCharmander.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Bold)
        cbCharmander.ForeColor = Color.DarkOrange
        cbCharmander.Location = New Point(662, 46)
        cbCharmander.Name = "cbCharmander"
        cbCharmander.Size = New Size(177, 22)
        cbCharmander.TabIndex = 6
        cbCharmander.Text = "Charmander"
        cbCharmander.UseVisualStyleBackColor = True
        ' 
        ' cbDitto
        ' 
        cbDitto.AutoSize = True
        cbDitto.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Bold)
        cbDitto.ForeColor = Color.DarkOrange
        cbDitto.Location = New Point(353, 326)
        cbDitto.Name = "cbDitto"
        cbDitto.Size = New Size(90, 22)
        cbDitto.TabIndex = 5
        cbDitto.Text = "Ditto"
        cbDitto.UseVisualStyleBackColor = True
        ' 
        ' cbSnorlax
        ' 
        cbSnorlax.AutoSize = True
        cbSnorlax.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Bold)
        cbSnorlax.ForeColor = Color.DarkOrange
        cbSnorlax.Location = New Point(42, 326)
        cbSnorlax.Name = "cbSnorlax"
        cbSnorlax.Size = New Size(124, 22)
        cbSnorlax.TabIndex = 4
        cbSnorlax.Text = "Snorlax"
        cbSnorlax.UseVisualStyleBackColor = True
        ' 
        ' cbPikachu
        ' 
        cbPikachu.AutoSize = True
        cbPikachu.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Bold)
        cbPikachu.ForeColor = Color.DarkOrange
        cbPikachu.Location = New Point(353, 46)
        cbPikachu.Name = "cbPikachu"
        cbPikachu.Size = New Size(120, 22)
        cbPikachu.TabIndex = 3
        cbPikachu.Text = "Pikachu"
        cbPikachu.UseVisualStyleBackColor = True
        ' 
        ' cbGyarados
        ' 
        cbGyarados.AutoSize = True
        cbGyarados.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Bold)
        cbGyarados.ForeColor = Color.DarkOrange
        cbGyarados.Location = New Point(40, 182)
        cbGyarados.Name = "cbGyarados"
        cbGyarados.Size = New Size(132, 22)
        cbGyarados.TabIndex = 2
        cbGyarados.Text = "Gyrados"
        cbGyarados.UseVisualStyleBackColor = True
        ' 
        ' cbSquirtle
        ' 
        cbSquirtle.AutoSize = True
        cbSquirtle.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Bold)
        cbSquirtle.ForeColor = Color.DarkOrange
        cbSquirtle.Location = New Point(680, 326)
        cbSquirtle.Name = "cbSquirtle"
        cbSquirtle.Size = New Size(125, 22)
        cbSquirtle.TabIndex = 1
        cbSquirtle.Text = "Squirtle"
        cbSquirtle.UseVisualStyleBackColor = True
        ' 
        ' cbBulbasaur
        ' 
        cbBulbasaur.AutoSize = True
        cbBulbasaur.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Bold)
        cbBulbasaur.ForeColor = Color.DarkOrange
        cbBulbasaur.Location = New Point(42, 46)
        cbBulbasaur.Name = "cbBulbasaur"
        cbBulbasaur.Size = New Size(150, 22)
        cbBulbasaur.TabIndex = 0
        cbBulbasaur.Text = "Bulbasaur"
        cbBulbasaur.UseVisualStyleBackColor = True
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(871, 526)
        Controls.Add(TabPokemon)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormInput"
        Text = "FormInput"
        TabPage3.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPokemon.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents chkPvp As CheckBox
    Friend WithEvents chkBadge As CheckBox
    Friend WithEvents chkBreeding As CheckBox
    Friend WithEvents chkExploring As CheckBox
    Friend WithEvents chkTraining As CheckBox
    Friend WithEvents chkTrading As CheckBox
    Friend WithEvents chkBattle As CheckBox
    Friend WithEvents chkTangkap As CheckBox
    Friend WithEvents rbChampion As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbTrainer As RadioButton
    Friend WithEvents rbGym As RadioButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mtbHP As MaskedTextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPokemon As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents cbTyranitar As CheckBox
    Friend WithEvents cbMachamp As CheckBox
    Friend WithEvents cbCharmander As CheckBox
    Friend WithEvents cbDitto As CheckBox
    Friend WithEvents cbSnorlax As CheckBox
    Friend WithEvents cbPikachu As CheckBox
    Friend WithEvents cbGyarados As CheckBox
    Friend WithEvents cbSquirtle As CheckBox
    Friend WithEvents cbBulbasaur As CheckBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
