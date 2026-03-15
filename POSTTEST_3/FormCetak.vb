Imports System.IO

Public Class FormCetak

    ' --- Validasi Inputan Huruf Saja untuk Nama ---
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' --- Validasi Inputan Angka Saja untuk Umur dan Telepon ---
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtNoTelp.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' --- Tombol Browse Foto ---
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
            ofd.Title = "Pilih Foto Profil"
            If ofd.ShowDialog() = DialogResult.OK Then
                pbProfile.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    ' --- Tombol Cetak Kartu ---
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim isHobbyChecked As Boolean = False
        Dim listHobby As New List(Of String)

        ' Cek hobby di dalam FlowLayoutPanel
        For Each ctrl As Control In flpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    isHobbyChecked = True
                    listHobby.Add(chk.Text)
                End If
            End If
        Next

        ' Validasi Kosong
        If pbProfile.Image Is Nothing OrElse
           String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           String.IsNullOrWhiteSpace(txtUmur.Text) OrElse
           String.IsNullOrWhiteSpace(txtNoTelp.Text) OrElse
           String.IsNullOrWhiteSpace(txtAlamat.Text) OrElse
           (Not rbLakiLaki.Checked AndAlso Not rbPerempuan.Checked) OrElse
           Not isHobbyChecked Then

            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim gender As String = If(rbLakiLaki.Checked, "Laki-laki", "Perempuan")
        Dim hobbyGabungan As String = String.Join(", ", listHobby)
        Dim tglLahir As String = dtpTglLahir.Value.ToString("dd MMMM yyyy")

        ' Passing Data ke Form Hasil
        Dim frmHasil As New FormHasil()
        frmHasil.TampilkanData(pbProfile.Image, txtNama.Text, txtUmur.Text, txtNoTelp.Text, tglLahir, gender, hobbyGabungan, txtAlamat.Text)
        frmHasil.ShowDialog()
    End Sub

End Class