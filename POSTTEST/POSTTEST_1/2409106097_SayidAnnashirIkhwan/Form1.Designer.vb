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
        components = New ComponentModel.Container()
        tek1 = New Label()
        tek2 = New Label()
        lblketerangan = New Label()
        txtipksemester = New TextBox()
        txtipkkumulatif = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' tek1
        ' 
        tek1.AutoSize = True
        tek1.Location = New Point(171, 159)
        tek1.Name = "tek1"
        tek1.Size = New Size(122, 20)
        tek1.TabIndex = 0
        tek1.Text = "IPK SEMESTERRR"
        ' 
        ' tek2
        ' 
        tek2.AutoSize = True
        tek2.Location = New Point(171, 296)
        tek2.Name = "tek2"
        tek2.Size = New Size(111, 20)
        tek2.TabIndex = 1
        tek2.Text = "IPK KUMULATIF"
        ' 
        ' lblketerangan
        ' 
        lblketerangan.AutoSize = True
        lblketerangan.Location = New Point(362, 368)
        lblketerangan.Name = "lblketerangan"
        lblketerangan.Size = New Size(0, 20)
        lblketerangan.TabIndex = 2
        ' 
        ' txtipksemester
        ' 
        txtipksemester.Location = New Point(301, 155)
        txtipksemester.Margin = New Padding(3, 4, 3, 4)
        txtipksemester.Name = "txtipksemester"
        txtipksemester.Size = New Size(171, 27)
        txtipksemester.TabIndex = 3
        ' 
        ' txtipkkumulatif
        ' 
        txtipkkumulatif.Location = New Point(301, 296)
        txtipkkumulatif.Margin = New Padding(3, 4, 3, 4)
        txtipkkumulatif.Name = "txtipkkumulatif"
        txtipkkumulatif.ReadOnly = True
        txtipkkumulatif.Size = New Size(171, 27)
        txtipkkumulatif.TabIndex = 4
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Lime
        btnTambah.Location = New Point(286, 209)
        btnTambah.Margin = New Padding(3, 4, 3, 4)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(86, 31)
        btnTambah.TabIndex = 5
        btnTambah.Text = "TAMBAH"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.IndianRed
        btnReset.Location = New Point(397, 209)
        btnReset.Margin = New Padding(3, 4, 3, 4)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(86, 31)
        btnReset.TabIndex = 6
        btnReset.Text = "RESET"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(231, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(285, 20)
        Label1.TabIndex = 8
        Label1.Text = "Ayooo Perlihatkannnn IPK MU KAWAN!!!!!!"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(802, 605)
        Controls.Add(Label1)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtipkkumulatif)
        Controls.Add(txtipksemester)
        Controls.Add(lblketerangan)
        Controls.Add(tek2)
        Controls.Add(tek1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tek1 As Label
    Friend WithEvents tek2 As Label
    Friend WithEvents lblketerangan As Label
    Friend WithEvents txtipksemester As TextBox
    Friend WithEvents txtipkkumulatif As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label

End Class
