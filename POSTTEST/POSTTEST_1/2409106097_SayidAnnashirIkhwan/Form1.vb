Public Class Form1


    Dim totalIPK As Double = 0
    Dim jumlahIPK As Integer = 0
    Dim ipk As Double = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ipSemester As Double


        If Double.TryParse(txtipksemester.Text, ipSemester) Then


            totalIPK = totalIPK + ipSemester
            jumlahIPK = jumlahIPK + 1


            ipk = totalIPK / jumlahIPK


            txtipkkumulatif.Text = ipk.ToString("0.00")


            If ipk >= 2.0 And ipk <= 2.75 Then
                lblketerangan.Text = "Mending DO kata ulun 👎"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                lblketerangan.Text = "B aja tapi good👍 "
            ElseIf ipk >= 3.01 Then
                lblketerangan.Text = "FIXXX CUMLAUDE BAGUS BANAR. AUTO JADI CEO IKAM 👍"
            Else
                lblketerangan.Text = "-"
            End If


            txtipksemester.Clear()

        Else
            MessageBox.Show("Input harus berupa angka nyet!")
        End If

    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click


        totalIPK = 0
        jumlahIPK = 0
        ipk = 0

        txtipksemester.Clear()
        txtipkkumulatif.Clear()
        lblketerangan.Text = ""

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub tek1_Click(sender As Object, e As EventArgs) Handles tek1.Click

    End Sub
End Class