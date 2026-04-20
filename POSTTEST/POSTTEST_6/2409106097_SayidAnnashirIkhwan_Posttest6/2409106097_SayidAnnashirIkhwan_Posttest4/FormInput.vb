Public Class FormInput

    Dim pathFoto As String = ""

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            pathFoto = OpenFileDialog1.FileName
        End If
    End Sub

    Function AmbilHobi() As String
        Dim hasil As String = ""
        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    hasil &= CType(ctrl, CheckBox).Text & ", "
                End If
            End If
        Next
        Return hasil
    End Function

    Function AmbilPokemon() As List(Of String)
        Dim hasil As New List(Of String)
        If cbBulbasaur.Checked Then hasil.Add(cbBulbasaur.Text)
        If cbPikachu.Checked Then hasil.Add(cbPikachu.Text)
        If cbCharmander.Checked Then hasil.Add(cbCharmander.Text)
        If cbGyarados.Checked Then hasil.Add(cbGyarados.Text)
        If cbTyranitar.Checked Then hasil.Add(cbTyranitar.Text)
        If cbMachamp.Checked Then hasil.Add(cbMachamp.Text)
        If cbSnorlax.Checked Then hasil.Add(cbSnorlax.Text)
        If cbDitto.Checked Then hasil.Add(cbDitto.Text)
        If cbSquirtle.Checked Then hasil.Add(cbSquirtle.Text)
        Return hasil
    End Function

    Function AmbilPeran() As String
        If rbGym.Checked Then Return rbGym.Text
        If rbTrainer.Checked Then Return rbTrainer.Text
        If rbAdmin.Checked Then Return rbAdmin.Text
        If rbChampion.Checked Then Return rbChampion.Text
        Return ""
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Input tidak boleh kosong")
            Exit Sub
        End If

        If Not mtbHP.MaskCompleted Then
            MessageBox.Show("Nomor HP harus lengkap")
            Exit Sub
        End If

        If InsertData(txtID.Text, txtNama.Text, cmbKomunitas.Text, mtbHP.Text, AmbilHobi(), AmbilPeran(), pathFoto) Then
            For Each pokemon As String In AmbilPokemon()
                InsertPokemon(txtNama.Text, pokemon)
            Next
            MessageBox.Show("Data berhasil disimpan")
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim fk As New FormKartu
        fk.lblNama.Text = txtNama.Text
        fk.lblID.Text = txtID.Text
        fk.lblRegion.Text = cmbKomunitas.Text
        fk.lblKontak.Text = mtbHP.Text
        fk.lblHobi.Text = AmbilHobi()
        fk.lblPeran.Text = AmbilPeran()
        fk.picKartu.Image = picFoto.Image
        fk.Show()
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

End Class