Public Class FormHome
    ' Harga per gelas (Konstanta)
    Dim hargaJamu As Integer = 10000

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup Kolom DataGridView jika belum ada di designer
        If DGVjamu.ColumnCount = 0 Then
            DGVjamu.Columns.Add("id", "ID")
            DGVjamu.Columns.Add("nama", "Nama Pembeli")
            DGVjamu.Columns.Add("jamu", "Jenis Jamu")
            DGVjamu.Columns.Add("qty", "Jumlah")
            DGVjamu.Columns.Add("total", "Total Harga")
        End If
    End Sub

    ' Hitung Total Otomatis saat jumlah berubah
    Private Sub NUMjumlah_ValueChanged(sender As Object, e As EventArgs) Handles NUMjumlah.ValueChanged
        Dim total As Integer = NUMjumlah.Value * hargaJamu
        TBtotal.Text = "Rp. " & total.ToString("N0")
    End Sub

    ' CREATE (SIMPAN)
    Private Sub Bsimpan_Click(sender As Object, e As EventArgs) Handles Bsimpan.Click
        If TBnamapembeli.Text = "" Or CBjamu.SelectedIndex = -1 Then
            MessageBox.Show("Lengkapi data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim id As String = "STK-" & Now.ToString("ssmm")
            DGVjamu.Rows.Add(id, TBnamapembeli.Text, CBjamu.Text, NUMjumlah.Value, TBtotal.Text)
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Bclear.PerformClick()
        End If
    End Sub

    ' UPDATE (UBAH)
    Private Sub Bupdate_Click(sender As Object, e As EventArgs) Handles Bupdate.Click
        If DGVjamu.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DGVjamu.SelectedRows(0)
            row.Cells(1).Value = TBnamapembeli.Text
            row.Cells(2).Value = CBjamu.Text
            row.Cells(3).Value = NUMjumlah.Value
            row.Cells(4).Value = TBtotal.Text
            MessageBox.Show("Data berhasil diperbarui!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' DELETE (HAPUS)
    Private Sub Bhapus_Click(sender As Object, e As EventArgs) Handles Bhapus.Click
        If DGVjamu.SelectedRows.Count > 0 Then
            Dim tanya As DialogResult = MessageBox.Show("Hapus data terpilih?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If tanya = DialogResult.Yes Then
                DGVjamu.Rows.Remove(DGVjamu.SelectedRows(0))
            End If
        End If
    End Sub

    ' SEARCH (CARI)
    Private Sub Bseacrh_Click(sender As Object, e As EventArgs) Handles Bseacrh.Click
        Dim keyword As String = TBseacrh.Text.ToLower()
        For Each row As DataGridViewRow In DGVjamu.Rows
            If row.Cells(1).Value.ToString().ToLower().Contains(keyword) Then
                row.Selected = True
                DGVjamu.FirstDisplayedScrollingRowIndex = row.Index
                Exit Sub
            End If
        Next
    End Sub

    ' CLEAR
    Private Sub Bclear_Click(sender As Object, e As EventArgs) Handles Bclear.Click
        TBnamapembeli.Clear()
        CBjamu.SelectedIndex = -1
        NUMjumlah.Value = 0
        TBtotal.Text = "Rp. 0"
    End Sub

    ' PINDAH KE FORM CETAK (POIN PLUS MULTI-FORM)
    Private Sub Bcetak_Click(sender As Object, e As EventArgs) Handles Bcetak.Click
        If DGVjamu.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DGVjamu.SelectedRows(0)

            ' Kirim data ke label di FormCetak
            FormCetak.Lnostruk.Text = "No: " & row.Cells(0).Value.ToString()
            FormCetak.Lnama.Text = "Nama: " & row.Cells(1).Value.ToString()
            FormCetak.Ljamu.Text = row.Cells(2).Value.ToString()
            FormCetak.Ljumlah.Text = "Jumlah: " & row.Cells(3).Value.ToString() & " Gelas"
            FormCetak.Lharga.Text = row.Cells(4).Value.ToString()

            FormCetak.ShowDialog()
        Else
            MessageBox.Show("Pilih data di tabel yang ingin dicetak!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class