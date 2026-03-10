Imports System.IO

Public Class Form1

    Private Sub btnGambar_Click(sender As Object, e As EventArgs) Handles btnGambar.Click

        Dim open As New OpenFileDialog
        open.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If open.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(open.FileName)
            DataModule.Foto = open.FileName
        End If

    End Sub


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtTinggi.Text = "" Or txtGoldar.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("tidak boleh kosong yaa ")
            Exit Sub
        End If


        Dim gender As String

        If rbLaki.Checked Then
            gender = "Laki - Laki"
        ElseIf rbPerempuan.Checked Then
            gender = "Perempuan"
        Else
            MessageBox.Show("Pilih jenis kelamin")
            Exit Sub
        End If


        Dim hobi As String = ""

        For Each ctrl As Control In GroupBoxHobi.Controls

            If TypeOf ctrl Is CheckBox Then

                Dim cb As CheckBox = ctrl

                If cb.Checked Then
                    hobi &= cb.Text & ", "
                End If

            End If

        Next


        If hobi = "" Then
            MessageBox.Show("Pilih minimal 1 hobby")
            Exit Sub
        End If


        DataModule.Nama = txtNama.Text
        DataModule.Tglahir = DateTimePicker1.Value.ToShortDateString
        DataModule.Tinggi = txtTinggi.Text
        DataModule.Goldar = txtGoldar.Text
        DataModule.Alamat = txtAlamat.Text
        DataModule.JK = gender
        DataModule.Hobi = hobi


        HasilcetakKartuIndopride.Show()

    End Sub

End Class