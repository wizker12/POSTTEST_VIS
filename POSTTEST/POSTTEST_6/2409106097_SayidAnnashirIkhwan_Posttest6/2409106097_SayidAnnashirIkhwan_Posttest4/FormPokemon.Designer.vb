<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPokemon
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Label1 = New Label()
        btnUbahPokemon = New Button()
        btnHapusPokemon = New Button()
        txtSearchPokemon = New TextBox()
        dgvData = New DataGridView()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("PKMN RBYGSC", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(46, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 18)
        Label1.TabIndex = 9
        Label1.Text = "Cari Data :"
        btnUbahPokemon.BackColor = Color.GreenYellow
        btnUbahPokemon.Font = New Font("PKMN RBYGSC", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUbahPokemon.Location = New Point(699, 33)
        btnUbahPokemon.Name = "btnUbahPokemon"
        btnUbahPokemon.Size = New Size(102, 36)
        btnUbahPokemon.TabIndex = 8
        btnUbahPokemon.Text = "Ubah"
        btnUbahPokemon.UseVisualStyleBackColor = False
        btnHapusPokemon.BackColor = Color.OrangeRed
        btnHapusPokemon.Font = New Font("PKMN RBYGSC", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapusPokemon.Location = New Point(563, 33)
        btnHapusPokemon.Name = "btnHapusPokemon"
        btnHapusPokemon.Size = New Size(100, 36)
        btnHapusPokemon.TabIndex = 7
        btnHapusPokemon.Text = "Hapus"
        btnHapusPokemon.UseVisualStyleBackColor = False
        txtSearchPokemon.Location = New Point(205, 46)
        txtSearchPokemon.Name = "txtSearchPokemon"
        txtSearchPokemon.Size = New Size(329, 23)
        txtSearchPokemon.TabIndex = 6
        dgvData.AllowUserToAddRows = False
        dgvData.AllowUserToDeleteRows = False
        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvData.BackgroundColor = SystemColors.ActiveCaption
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(29, 133)
        dgvData.MultiSelect = False
        dgvData.Name = "dgvData"
        dgvData.Size = New Size(794, 389)
        dgvData.TabIndex = 5
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(923, 586)
        Controls.Add(Label1)
        Controls.Add(btnUbahPokemon)
        Controls.Add(btnHapusPokemon)
        Controls.Add(txtSearchPokemon)
        Controls.Add(dgvData)
        ForeColor = SystemColors.ControlText
        MaximizeBox = False
        Name = "FormPokemon"
        Text = "FormPokemon"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnUbahPokemon As Button
    Friend WithEvents btnHapusPokemon As Button
    Friend WithEvents txtSearchPokemon As TextBox
    Friend WithEvents dgvData As DataGridView

End Class