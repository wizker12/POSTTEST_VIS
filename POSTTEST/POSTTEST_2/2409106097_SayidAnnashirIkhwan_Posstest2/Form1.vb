Public Class Form1

    Private Sub TampilDaftar()

        ListBox1.Items.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            ListBox1.Items.Add(daftarBuku(i, 0) & " (" & daftarBuku(i, 1) & ")")
        Next

    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click

        TambahBuku(txtjudulbuku.Text, txtgenre.Text)
        TampilDaftar()

    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click

        Dim judul As String = txthapus.Text
        HapusBuku(judul)
        TampilDaftar()

    End Sub

End Class