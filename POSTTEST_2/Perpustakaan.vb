Public Class Perpustakaan
    Private Sub RefreshListBox(ByRef lb As ListBox)
        lb.Items.Clear()
        Dim i As Integer
        For i = 0 To jumlahBuku - 1
            lb.Items.Add(FormatTampilBuku(i))
        Next i
    End Sub

    Private Sub Perpustakaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TambahBuku("BK001", "Hujan", "Tere Liye", "2016")
        TambahBuku("BK002", "Bumi", "Tere Liye", "2014")
        RefreshListBox(LBdaftarbuku)
    End Sub

    Private Sub Btambah_Click(sender As Object, e As EventArgs) Handles Btambah.Click
        Dim kode As String
        Dim judul As String
        Dim pengarang As String
        Dim tahun As String
        kode = TBkodeTambah.Text.Trim()
        judul = TBjudulTambah.Text.Trim()
        pengarang = TBpengarangTambah.Text.Trim()
        tahun = TBterbitTambah.Text.Trim()

        If kode = "" Or judul = "" Or pengarang = "" Or tahun = "" Then
            MessageBox.Show("Semua wajib diisi", "Peringatan")
            Exit Sub
        End If

        If CekDuplikat(kode, judul) = True Then
            MessageBox.Show("Kode atau Judul buku sudah ada di daftar", "Duplikat")
            Exit Sub
        End If

        TambahBuku(kode, judul, pengarang, tahun)
        RefreshListBox(LBdaftarbuku)
        TBkodeTambah.Text = ""
        TBjudulTambah.Text = ""
        TBpengarangTambah.Text = ""
        TBterbitTambah.Text = ""

        MessageBox.Show("Buku berhasil ditambahkan", "Berhasil")

    End Sub

    Private Sub Bhapus_Click(sender As Object, e As EventArgs) Handles Bhapus.Click
        Dim kodeHapus As String
        Dim judulHapus As String
        Dim berhasil As Boolean
        kodeHapus = TBkodeHapus.Text.Trim()
        judulHapus = TBjudulHapus.Text.Trim()

        If kodeHapus = "" Or judulHapus = "" Then
            MessageBox.Show("Kode dan Judul wajib diisi", "Peringatan")
            Exit Sub
        End If

        HapusBuku(kodeHapus, judulHapus, berhasil)

        If berhasil = True Then
            RefreshListBox(LBdaftarbuku)
            TBkodeHapus.Text = ""
            TBjudulHapus.Text = ""
            MessageBox.Show("Buku berhasil dihapus", "Berhasil")
        Else
            MessageBox.Show("Buku tidak ditemukan" & vbCrLf &
                            "Pastikan Kode dan Judul sama persis", "Gagal")
        End If

    End Sub

    Private Sub GBtambah_Enter(sender As Object, e As EventArgs) Handles GBtambah.Enter
    End Sub

    Private Sub LkodeTambah_Click(sender As Object, e As EventArgs) Handles LkodeTambah.Click
    End Sub

    Private Sub TBkodeTambah_TextChanged(sender As Object, e As EventArgs) Handles TBkodeTambah.TextChanged
    End Sub

    Private Sub LjudulTambah_Click(sender As Object, e As EventArgs) Handles LjudulTambah.Click
    End Sub

    Private Sub TBjudulTambah_TextChanged(sender As Object, e As EventArgs) Handles TBjudulTambah.TextChanged
    End Sub

    Private Sub LpengaranTambah_Click(sender As Object, e As EventArgs) Handles LpengaranTambah.Click
    End Sub

    Private Sub TBpengarangTambah_TextChanged(sender As Object, e As EventArgs) Handles TBpengarangTambah.TextChanged
    End Sub

    Private Sub LterbitTambah_Click(sender As Object, e As EventArgs) Handles LterbitTambah.Click
    End Sub

    Private Sub TBterbitTambah_TextChanged(sender As Object, e As EventArgs) Handles TBterbitTambah.TextChanged
    End Sub

    Private Sub GBhapus_Enter(sender As Object, e As EventArgs) Handles GBhapus.Enter
    End Sub

    Private Sub LkodeHapus_Click(sender As Object, e As EventArgs) Handles LkodeHapus.Click
    End Sub

    Private Sub TBkodeHapus_TextChanged(sender As Object, e As EventArgs) Handles TBkodeHapus.TextChanged
    End Sub

    Private Sub LjudulHapus_Click(sender As Object, e As EventArgs) Handles LjudulHapus.Click
    End Sub

    Private Sub TBjudulHapus_TextChanged(sender As Object, e As EventArgs) Handles TBjudulHapus.TextChanged
    End Sub

    Private Sub LBdaftarbuku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBdaftarbuku.SelectedIndexChanged
    End Sub

    Private Sub Ldaftarbuku_Click(sender As Object, e As EventArgs) Handles Ldaftarbuku.Click
    End Sub

End Class