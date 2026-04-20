<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormData))
        txtSearch = New TextBox()
        btnHapus = New Button()
        btnUbah = New Button()
        Label1 = New Label()
        dgvData = New DataGridView()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(171, 34)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(329, 23)
        txtSearch.TabIndex = 1
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.OrangeRed
        btnHapus.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(568, 27)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(100, 36)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.GreenYellow
        btnUbah.Font = New Font("PKMN RBYGSC", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUbah.Location = New Point(704, 27)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(102, 36)
        btnUbah.TabIndex = 3
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("PKMN RBYGSC", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 18)
        Label1.TabIndex = 4
        Label1.Text = "Cari Data :"
        ' 
        ' dgvData
        ' 
        dgvData.AllowUserToAddRows = False
        dgvData.AllowUserToDeleteRows = False
        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvData.BackgroundColor = SystemColors.ActiveCaption
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(12, 110)
        dgvData.MultiSelect = False
        dgvData.Name = "dgvData"
        dgvData.Size = New Size(794, 389)
        dgvData.TabIndex = 0
        ' 
        ' FormData
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(931, 593)
        Controls.Add(Label1)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(txtSearch)
        Controls.Add(dgvData)
        MaximizeBox = False
        Name = "FormData"
        Text = "FormData"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvData As DataGridView
End Class
