Public Class Form1

    Private Sub menuInput_Click(sender As Object, e As EventArgs) Handles menuInput.Click
        FormInput.Show()
    End Sub

    Private Sub menuLihat_Click(sender As Object, e As EventArgs) Handles menuLihat.Click
        Dim fk As New FormKartu
        fk.Show()
    End Sub

    Private Sub menuSimpan_Click(sender As Object, e As EventArgs) Handles menuSimpan.Click
        MessageBox.Show("Data sudah tersimpan di database")
    End Sub

    Private Sub menuBuka_Click(sender As Object, e As EventArgs) Handles menuBuka.Click
        Dim f As New FormData
        f.Show()
    End Sub

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        If MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub menuPokemon_Click(sender As Object, e As EventArgs) Handles menuPokemon.Click
        Dim fk As New FormPokemon
        fk.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class