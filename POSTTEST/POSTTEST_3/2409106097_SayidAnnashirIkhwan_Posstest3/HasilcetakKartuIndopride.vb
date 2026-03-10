Public Class HasilcetakKartuIndopride

    Private Sub HasilcetakKartuIndopride_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = DataModule.Nama
        Label2.Text = DataModule.Tglahir
        Label3.Text = DataModule.Tinggi
        Label4.Text = DataModule.Goldar
        Label5.Text = DataModule.Alamat
        Label6.Text = DataModule.JK
        Label7.Text = DataModule.Hobi

        PictureBox1.Image = Image.FromFile(DataModule.Foto)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub
End Class