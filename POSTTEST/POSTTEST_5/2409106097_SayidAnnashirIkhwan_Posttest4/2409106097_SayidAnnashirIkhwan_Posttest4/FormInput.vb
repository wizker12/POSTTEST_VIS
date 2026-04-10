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

        For Each tab As TabPage In TabControl1.TabPages
            For Each ctrl As Control In tab.Controls

                If TypeOf ctrl Is CheckBox Then
                    If CType(ctrl, CheckBox).Checked Then
                        hasil &= CType(ctrl, CheckBox).Text & ", "
                    End If
                End If

                If TypeOf ctrl Is GroupBox Then
                    For Each c As Control In ctrl.Controls
                        If TypeOf c Is CheckBox Then
                            If CType(c, CheckBox).Checked Then
                                hasil &= CType(c, CheckBox).Text & ", "
                            End If
                        End If
                    Next
                End If

            Next
        Next

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

End Class