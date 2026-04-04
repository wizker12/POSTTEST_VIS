<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKartu))
        Label1 = New Label()
        picKartu = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblNama = New Label()
        lblID = New Label()
        lblRegion = New Label()
        lblKontak = New Label()
        lblHobi = New Label()
        Label7 = New Label()
        lblPeran = New Label()
        CType(picKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Pokemon Solid", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(315, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(309, 69)
        Label1.TabIndex = 0
        Label1.Text = "POKÉMON TRAINER CARD"
        ' 
        ' picKartu
        ' 
        picKartu.BackgroundImageLayout = ImageLayout.Stretch
        picKartu.Location = New Point(24, 102)
        picKartu.Name = "picKartu"
        picKartu.Size = New Size(248, 349)
        picKartu.SizeMode = PictureBoxSizeMode.StretchImage
        picKartu.TabIndex = 1
        picKartu.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(303, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 14)
        Label2.TabIndex = 2
        Label2.Text = "Nama :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(303, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 14)
        Label3.TabIndex = 3
        Label3.Text = "ID :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(303, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 14)
        Label4.TabIndex = 4
        Label4.Text = "Region :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(303, 302)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 14)
        Label5.TabIndex = 5
        Label5.Text = "Kontak :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(303, 355)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 14)
        Label6.TabIndex = 6
        Label6.Text = "Hobi :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(410, 142)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(67, 14)
        lblNama.TabIndex = 7
        lblNama.Text = "Label7"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.Transparent
        lblID.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblID.Location = New Point(410, 193)
        lblID.Name = "lblID"
        lblID.Size = New Size(67, 14)
        lblID.TabIndex = 8
        lblID.Text = "Label8"
        ' 
        ' lblRegion
        ' 
        lblRegion.AutoSize = True
        lblRegion.BackColor = Color.Transparent
        lblRegion.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRegion.Location = New Point(410, 248)
        lblRegion.Name = "lblRegion"
        lblRegion.Size = New Size(67, 14)
        lblRegion.TabIndex = 9
        lblRegion.Text = "Label9"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.BackColor = Color.Transparent
        lblKontak.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKontak.Location = New Point(410, 302)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(78, 14)
        lblKontak.TabIndex = 10
        lblKontak.Text = "Label10"
        ' 
        ' lblHobi
        ' 
        lblHobi.BackColor = Color.Transparent
        lblHobi.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHobi.Location = New Point(410, 355)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(356, 96)
        lblHobi.TabIndex = 11
        lblHobi.Text = "Label11"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(36, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 14)
        Label7.TabIndex = 12
        Label7.Text = "PERAN :"
        ' 
        ' lblPeran
        ' 
        lblPeran.AutoSize = True
        lblPeran.BackColor = Color.Transparent
        lblPeran.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPeran.Location = New Point(124, 40)
        lblPeran.Name = "lblPeran"
        lblPeran.Size = New Size(73, 14)
        lblPeran.TabIndex = 13
        lblPeran.Text = "Label8"
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(808, 473)
        Controls.Add(lblPeran)
        Controls.Add(Label7)
        Controls.Add(lblHobi)
        Controls.Add(lblKontak)
        Controls.Add(lblRegion)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(picKartu)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormKartu"
        CType(picKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Public WithEvents picKartu As PictureBox
    Public WithEvents lblNama As Label
    Public WithEvents lblID As Label
    Public WithEvents lblRegion As Label
    Public WithEvents lblKontak As Label
    Public WithEvents lblHobi As Label
    Friend WithEvents Label7 As Label
    Public WithEvents lblPeran As Label
End Class
