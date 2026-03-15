Public Class FormHasil

    Public Sub TampilkanData(foto As Image, nama As String, umur As String, telp As String, tgl As String, jk As String, hobi As String, alamat As String)

        pbHasilFoto.Image = foto
        txtHasilNama.Text = nama
        txtHasilUmur.Text = "Umur: " & umur & " Tahun"
        txtHasilNoTelp.Text = "Telp: " & telp
        txtHasilTglLahir.Text = "Lahir: " & tgl
        txtHasilJenisKelamin.Text = "Gender: " & jk
        txtHasilHobby.Text = "Hobi: " & hobi & vbCrLf & "Alamat: " & alamat

    End Sub

End Class