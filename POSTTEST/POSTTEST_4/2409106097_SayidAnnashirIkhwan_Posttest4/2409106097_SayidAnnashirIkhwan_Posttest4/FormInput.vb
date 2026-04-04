Public Class FormInput

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Input tidak boleh kosong")
            Exit Sub
        End If

        If Not mtbHP.MaskCompleted Then
            MessageBox.Show("Nomor HP harus lengkap")
            Exit Sub
        End If

        Dim cek As Boolean = False

        For Each tab As TabPage In TabControl1.TabPages
            For Each ctrl As Control In tab.Controls

                If TypeOf ctrl Is CheckBox Then
                    If CType(ctrl, CheckBox).Checked Then
                        cek = True
                    End If
                End If

                If TypeOf ctrl Is GroupBox Then
                    For Each c As Control In ctrl.Controls
                        If TypeOf c Is CheckBox Then
                            If CType(c, CheckBox).Checked Then
                                cek = True
                            End If
                        End If
                    Next
                End If

            Next
        Next

        If cek = False Then
            MessageBox.Show("Pilih minimal 1 hobi")
            Exit Sub
        End If

        MessageBox.Show("Data valid")
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

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

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim fk As New FormKartu

        fk.lblNama.Text = txtNama.Text
        fk.lblID.Text = txtID.Text
        fk.lblRegion.Text = cmbKomunitas.Text
        fk.lblKontak.Text = mtbHP.Text
        fk.lblHobi.Text = ""

        If rbGym.Checked Then
            fk.lblPeran.Text = rbGym.Text
        ElseIf rbTrainer.Checked Then
            fk.lblPeran.Text = rbTrainer.Text
        ElseIf rbAdmin.Checked Then
            fk.lblPeran.Text = rbAdmin.Text
        ElseIf rbChampion.Checked Then
            fk.lblPeran.Text = rbChampion.Text
        End If

        For Each tab As TabPage In TabControl1.TabPages
            For Each ctrl As Control In tab.Controls

                If TypeOf ctrl Is CheckBox Then
                    If CType(ctrl, CheckBox).Checked Then
                        fk.lblHobi.Text &= CType(ctrl, CheckBox).Text & ", "
                    End If
                End If

                If TypeOf ctrl Is GroupBox Then
                    For Each c As Control In ctrl.Controls
                        If TypeOf c Is CheckBox Then
                            If CType(c, CheckBox).Checked Then
                                fk.lblHobi.Text &= CType(c, CheckBox).Text & ", "
                            End If
                        End If
                    Next
                End If

            Next
        Next

        fk.picKartu.Image = picFoto.Image

        fk.Show()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class