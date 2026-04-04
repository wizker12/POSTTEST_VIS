Public Class Form1

    Private Sub menuInput_Click(sender As Object, e As EventArgs) Handles menuInput.Click
        FormInput.Show()
    End Sub

    Private Sub menuLihat_Click(sender As Object, e As EventArgs) Handles menuLihat.Click
        Dim fk As New FormKartu
        fk.Show()
    End Sub

    Private Sub menuSimpan_Click(sender As Object, e As EventArgs) Handles menuSimpan.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(SaveFileDialog1.FileName, "Data berhasil disimpan")
            MessageBox.Show("Data berhasil disimpan")
        End If
    End Sub

    Private Sub menuBuka_Click(sender As Object, e As EventArgs) Handles menuBuka.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim isi As String = IO.File.ReadAllText(OpenFileDialog1.FileName)
            MessageBox.Show(isi)
        End If
    End Sub

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class