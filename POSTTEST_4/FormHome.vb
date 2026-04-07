Imports System.IO

Public Class FormHome
    Private fotoProfilPath As String = ""

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControlUtama.SelectedTab = tabDataUtama

        If My.Resources.Screenshot_2026_04_07_224001 IsNot Nothing Then
            picLogoApp.Image = My.Resources.Screenshot_2026_04_07_224001
        End If
    End Sub

    Private Sub MenuInputData_Click(sender As Object, e As EventArgs) Handles MenuInputData.Click
        TabControlUtama.SelectedTab = tabDataUtama
    End Sub

    Private Sub MenuKeluar_Click(sender As Object, e As EventArgs) Handles MenuKeluar.Click
        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function CekValidasi() As Boolean
        ErrorProvider1.Clear()
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtID.Text) Then
            ErrorProvider1.SetError(txtID, "Inputan tidak boleh kosong")
            isValid = False
        End If

        If Not mtbNoHP.MaskCompleted Then
            ErrorProvider1.SetError(mtbNoHP, "Inputan tidak boleh kosong")
            isValid = False
        End If

        Dim hobiDicentang As Boolean = False
        For Each ctrl In gbKelebihan.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                hobiDicentang = True
                Exit For
            End If
        Next

        If Not hobiDicentang Then
            ErrorProvider1.SetError(gbKelebihan, "Inputan tidak boleh kosong")
            isValid = False
        End If

        Return isValid
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                fotoProfilPath = OpenFileDialog1.FileName
                picProfil.ImageLocation = fotoProfilPath
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat gambar: " & ex.Message)
        End Try
    End Sub

    Private Sub KirimDataKeKartu()
        FormKartu.lblNamaHasil.Text = txtNama.Text.ToUpper()
        FormKartu.lblIDHasil.Text = "ID: " & txtID.Text
        FormKartu.lblSuaraHasil.Text = "Voice: " & cmbJenisSuara.Text
        FormKartu.lblKontakHasil.Text = mtbNoHP.Text

        Dim kelebihanList As New List(Of String)
        For Each chk In gbKelebihan.Controls
            If TypeOf chk Is CheckBox AndAlso DirectCast(chk, CheckBox).Checked Then
                kelebihanList.Add(DirectCast(chk, CheckBox).Text)
            End If
        Next
        FormKartu.lblHobbyHasil.Text = "Skills: " & String.Join(", ", kelebihanList)

        If Not String.IsNullOrEmpty(fotoProfilPath) Then
            FormKartu.picFotoKartu.ImageLocation = fotoProfilPath
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If CekValidasi() Then
            Dim konfirmasi As DialogResult = MessageBox.Show("Simpan data dan tampilkan kartu?", "Cetak Kartu", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If konfirmasi = DialogResult.Yes Then
                KirimDataKeKartu()
                FormKartu.Show()
            End If
        End If
    End Sub

    Private Sub MenuSimpanData_Click(sender As Object, e As EventArgs) Handles MenuSimpanData.Click
        If CekValidasi() Then
            SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    Dim konten As String = "Resonance Choirs - Member Data" & vbCrLf &
                                         "Nama: " & txtNama.Text & vbCrLf &
                                         "ID: " & txtID.Text
                    File.WriteAllText(SaveFileDialog1.FileName, konten)
                    MessageBox.Show("Data berhasil disimpan!", "Sukses")
                Catch ex As Exception
                    MessageBox.Show("Gagal menyimpan file: " & ex.Message)
                End Try
            End If
        End If
    End Sub
End Class