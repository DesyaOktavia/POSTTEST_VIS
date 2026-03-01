Public Class Form1
    Dim totalIP As Double
    Dim jumlahSemester As Integer

    Private Sub IP_Perkuliahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalIP = 0
        jumlahSemester = 0
        Lsumipk.Text = "0.00"
        Lpredikat.Text = "Predikat"
    End Sub

    Private Sub TBipk_TextChanged(sender As Object, e As EventArgs) Handles TBipk.TextChanged

    End Sub

    Private Sub Btambah_Click(sender As Object, e As EventArgs) Handles Btambah.Click
        Dim inputTeks As String
        Dim ipSemester As Double
        Dim ipk As Double
        Dim predikat As String

        inputTeks = TBipk.Text

        If inputTeks = "" Then
            MessageBox.Show("Masukkan nilai IP Semester dulu!")
            Exit Sub
        End If

        If Double.TryParse(inputTeks, ipSemester) Then

            If ipSemester < 0 Or ipSemester > 4 Then
                MessageBox.Show("Nilai IP harus antara 0.00 - 4.00 !")
                TBipk.Clear()
                Exit Sub
            End If

            totalIP = totalIP + ipSemester
            jumlahSemester = jumlahSemester + 1

            ipk = totalIP / jumlahSemester

            If ipk >= 3.01 Then
                predikat = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 Then
                predikat = "Memuaskan"
            ElseIf ipk >= 2.0 Then
                predikat = "Cukup"
            Else
                predikat = "Di Bawah Standar"
            End If

            Lsumipk.Text = ipk.ToString("F2")
            Lpredikat.Text = predikat
            Riwayat_Perkuliahan.Items.Add("Semester " & jumlahSemester & "  |  IP : " & ipSemester.ToString("F2"))

            TBipk.Clear()
            TBipk.Focus()

        Else
            MessageBox.Show("Input harus angka! Contoh: 3.75")
            TBipk.Clear()
        End If
    End Sub

    Private Sub Breset_Click(sender As Object, e As EventArgs) Handles Breset.Click
        totalIP = 0
        jumlahSemester = 0
        TBipk.Clear()
        Lsumipk.Text = "0.00"
        Lpredikat.Text = "Predikat"
        Riwayat_Perkuliahan.Items.Clear()
        TBipk.Focus()
    End Sub

    Private Sub Lpredikat_Click(sender As Object, e As EventArgs) Handles Lpredikat.Click

    End Sub

    Private Sub Riwayat_Perkuliahan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Riwayat_Perkuliahan.SelectedIndexChanged

    End Sub

    Private Sub Lsumipk_Click(sender As Object, e As EventArgs) Handles Lsumipk.Click

    End Sub
End Class
