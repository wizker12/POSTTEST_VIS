Public Class FormData

    Sub TampilData()
        dgvData.DataSource = GetAllData()
    End Sub

    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvData.DataSource = SearchData(txtSearch.Text)
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If dgvData.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data dulu (klik sampai biru)")
            Exit Sub
        End If

        Dim row = dgvData.CurrentRow

        Dim id = row.Cells("id").Value.ToString()
        Dim nama = row.Cells("nama").Value.ToString()
        Dim region = row.Cells("region").Value.ToString()
        Dim kontak = row.Cells("kontak").Value.ToString()
        Dim hobi = row.Cells("hobi").Value.ToString()
        Dim peran = row.Cells("peran").Value.ToString()
        Dim foto = row.Cells("foto").Value.ToString()

        If UpdateData(id, nama, region, kontak, hobi, peran, foto) Then
            MessageBox.Show("Data berhasil diupdate")
            TampilData()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvData.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data dulu (klik sampai biru)")
            Exit Sub
        End If

        Dim id = dgvData.CurrentRow.Cells("id").Value.ToString()

        If DeleteData(id) Then
            MessageBox.Show("Data berhasil dihapus")
            TampilData()
        End If
    End Sub

    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        If dgvData.CurrentRow IsNot Nothing Then
            FormInput.txtID.Text = dgvData.CurrentRow.Cells("id").Value.ToString()
            FormInput.txtNama.Text = dgvData.CurrentRow.Cells("nama").Value.ToString()
            FormInput.cmbKomunitas.Text = dgvData.CurrentRow.Cells("region").Value.ToString()
            FormInput.mtbHP.Text = dgvData.CurrentRow.Cells("kontak").Value.ToString()
        End If
    End Sub

End Class