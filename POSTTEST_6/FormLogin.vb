Public Class FormLogin
    Private Sub Blogin_Click(sender As Object, e As EventArgs) Handles Blogin.Click
        EPlogin.Clear()

        If TBusername.Text = "" Then
            EPlogin.SetError(TBusername, "Username harus diisi!")
        ElseIf TBpassword.Text = "" Then
            EPlogin.SetError(TBpassword, "Password harus diisi!")
        Else
            ' Logika Login Sederhana
            If TBusername.Text = "Eca" AndAlso TBpassword.Text = "Cantik111" Then
                MessageBox.Show("Selamat Datang di Kedai Sehat!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FormHome.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username atau Password Salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Bkeluar_Click(sender As Object, e As EventArgs) Handles Bkeluar.Click
        Dim tanya As DialogResult = MessageBox.Show("Yakin ingin menutup aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = DialogResult.Yes Then Application.Exit()
    End Sub
End Class