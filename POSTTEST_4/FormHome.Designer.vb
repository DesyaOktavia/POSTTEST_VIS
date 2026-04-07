<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        MenuInputData = New ToolStripMenuItem()
        MenuLihatKartu = New ToolStripMenuItem()
        MenuSimpanData = New ToolStripMenuItem()
        MenuBukaData = New ToolStripMenuItem()
        MenuKeluar = New ToolStripMenuItem()
        TabControlUtama = New TabControl()
        tabDataUtama = New TabPage()
        lblNama = New Label()
        txtNama = New TextBox()
        lblID = New Label()
        txtID = New TextBox()
        lblLahir = New Label()
        dtpLahir = New DateTimePicker()
        gbGender = New GroupBox()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        lblSuara = New Label()
        cmbJenisSuara = New ComboBox()
        tabKontakInfo = New TabPage()
        lblTelp = New Label()
        mtbNoHP = New MaskedTextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        tabProfilAktivitas = New TabPage()
        picProfil = New PictureBox()
        btnBrowse = New Button()
        gbPeran = New GroupBox()
        rbPembimbing = New RadioButton()
        rbKonduktor = New RadioButton()
        rbAnggota = New RadioButton()
        gbKelebihan = New GroupBox()
        chkBernyanyi = New CheckBox()
        chkGitarAkustik = New CheckBox()
        chkGitarBasDrum = New CheckBox()
        chkPiano = New CheckBox()
        chkKeyboard = New CheckBox()
        chkCajon = New CheckBox()
        chkDrum = New CheckBox()
        chkBiola = New CheckBox()
        chkSaksofon = New CheckBox()
        chkLainnya = New CheckBox()
        btnSimpanCetak = New Button()
        lblJudulApp = New Label()
        picLogoApp = New PictureBox()
        MenuStrip1.SuspendLayout()
        TabControlUtama.SuspendLayout()
        tabDataUtama.SuspendLayout()
        gbGender.SuspendLayout()
        tabKontakInfo.SuspendLayout()
        tabProfilAktivitas.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        gbPeran.SuspendLayout()
        gbKelebihan.SuspendLayout()
        CType(picLogoApp, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuInputData, MenuLihatKartu, MenuSimpanData, MenuBukaData, MenuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(971, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuInputData
        ' 
        MenuInputData.Name = "MenuInputData"
        MenuInputData.Size = New Size(93, 24)
        MenuInputData.Text = "Input Data"
        ' 
        ' MenuLihatKartu
        ' 
        MenuLihatKartu.Name = "MenuLihatKartu"
        MenuLihatKartu.Size = New Size(94, 24)
        MenuLihatKartu.Text = "Lihat Kartu"
        ' 
        ' MenuSimpanData
        ' 
        MenuSimpanData.Name = "MenuSimpanData"
        MenuSimpanData.Size = New Size(109, 24)
        MenuSimpanData.Text = "Simpan Data"
        ' 
        ' MenuBukaData
        ' 
        MenuBukaData.Name = "MenuBukaData"
        MenuBukaData.Size = New Size(91, 24)
        MenuBukaData.Text = "Buka Data"
        ' 
        ' MenuKeluar
        ' 
        MenuKeluar.Name = "MenuKeluar"
        MenuKeluar.Size = New Size(65, 24)
        MenuKeluar.Text = "Keluar"
        ' 
        ' TabControlUtama
        ' 
        TabControlUtama.Controls.Add(tabDataUtama)
        TabControlUtama.Controls.Add(tabKontakInfo)
        TabControlUtama.Controls.Add(tabProfilAktivitas)
        TabControlUtama.Location = New Point(29, 173)
        TabControlUtama.Margin = New Padding(3, 4, 3, 4)
        TabControlUtama.Name = "TabControlUtama"
        TabControlUtama.SelectedIndex = 0
        TabControlUtama.Size = New Size(891, 560)
        TabControlUtama.TabIndex = 1
        ' 
        ' tabDataUtama
        ' 
        tabDataUtama.BackColor = Color.White
        tabDataUtama.Controls.Add(lblNama)
        tabDataUtama.Controls.Add(txtNama)
        tabDataUtama.Controls.Add(lblID)
        tabDataUtama.Controls.Add(txtID)
        tabDataUtama.Controls.Add(lblLahir)
        tabDataUtama.Controls.Add(dtpLahir)
        tabDataUtama.Controls.Add(gbGender)
        tabDataUtama.Controls.Add(lblSuara)
        tabDataUtama.Controls.Add(cmbJenisSuara)
        tabDataUtama.Location = New Point(4, 29)
        tabDataUtama.Margin = New Padding(3, 4, 3, 4)
        tabDataUtama.Name = "tabDataUtama"
        tabDataUtama.Size = New Size(883, 527)
        tabDataUtama.TabIndex = 0
        tabDataUtama.Text = "Data Utama"
        ' 
        ' lblNama
        ' 
        lblNama.Location = New Point(29, 27)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(114, 31)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama Lengkap"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(29, 60)
        txtNama.Margin = New Padding(3, 4, 3, 4)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(319, 27)
        txtNama.TabIndex = 1
        ' 
        ' lblID
        ' 
        lblID.Location = New Point(29, 113)
        lblID.Name = "lblID"
        lblID.Size = New Size(114, 31)
        lblID.TabIndex = 2
        lblID.Text = "ID Anggota"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(29, 147)
        txtID.Margin = New Padding(3, 4, 3, 4)
        txtID.Name = "txtID"
        txtID.Size = New Size(171, 27)
        txtID.TabIndex = 3
        ' 
        ' lblLahir
        ' 
        lblLahir.Location = New Point(29, 200)
        lblLahir.Name = "lblLahir"
        lblLahir.Size = New Size(114, 31)
        lblLahir.TabIndex = 4
        lblLahir.Text = "Tanggal Lahir"
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(29, 233)
        dtpLahir.Margin = New Padding(3, 4, 3, 4)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(228, 27)
        dtpLahir.TabIndex = 5
        ' 
        ' gbGender
        ' 
        gbGender.Controls.Add(rbLaki)
        gbGender.Controls.Add(rbPerempuan)
        gbGender.Location = New Point(400, 47)
        gbGender.Margin = New Padding(3, 4, 3, 4)
        gbGender.Name = "gbGender"
        gbGender.Padding = New Padding(3, 4, 3, 4)
        gbGender.Size = New Size(206, 120)
        gbGender.TabIndex = 6
        gbGender.TabStop = False
        gbGender.Text = "Jenis Kelamin"
        ' 
        ' rbLaki
        ' 
        rbLaki.Location = New Point(23, 33)
        rbLaki.Margin = New Padding(3, 4, 3, 4)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(119, 32)
        rbLaki.TabIndex = 0
        rbLaki.Text = "Laki-laki"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.Location = New Point(23, 73)
        rbPerempuan.Margin = New Padding(3, 4, 3, 4)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(119, 32)
        rbPerempuan.TabIndex = 1
        rbPerempuan.Text = "Perempuan"
        ' 
        ' lblSuara
        ' 
        lblSuara.Location = New Point(400, 200)
        lblSuara.Name = "lblSuara"
        lblSuara.Size = New Size(114, 31)
        lblSuara.TabIndex = 7
        lblSuara.Text = "Jenis Suara"
        ' 
        ' cmbJenisSuara
        ' 
        cmbJenisSuara.Items.AddRange(New Object() {"Alto", "MexoSopran", "Sopran", "Bass", "Bariton", "Tenor"})
        cmbJenisSuara.Location = New Point(400, 233)
        cmbJenisSuara.Margin = New Padding(3, 4, 3, 4)
        cmbJenisSuara.Name = "cmbJenisSuara"
        cmbJenisSuara.Size = New Size(205, 28)
        cmbJenisSuara.TabIndex = 8
        ' 
        ' tabKontakInfo
        ' 
        tabKontakInfo.BackColor = Color.White
        tabKontakInfo.Controls.Add(lblTelp)
        tabKontakInfo.Controls.Add(mtbNoHP)
        tabKontakInfo.Controls.Add(lblEmail)
        tabKontakInfo.Controls.Add(txtEmail)
        tabKontakInfo.Controls.Add(lblAlamat)
        tabKontakInfo.Controls.Add(txtAlamat)
        tabKontakInfo.Location = New Point(4, 29)
        tabKontakInfo.Margin = New Padding(3, 4, 3, 4)
        tabKontakInfo.Name = "tabKontakInfo"
        tabKontakInfo.Size = New Size(883, 527)
        tabKontakInfo.TabIndex = 1
        tabKontakInfo.Text = "Kontak & Info"
        ' 
        ' lblTelp
        ' 
        lblTelp.Location = New Point(29, 27)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(114, 31)
        lblTelp.TabIndex = 0
        lblTelp.Text = "Nomor Telepon"
        ' 
        ' mtbNoHP
        ' 
        mtbNoHP.Location = New Point(29, 60)
        mtbNoHP.Margin = New Padding(3, 4, 3, 4)
        mtbNoHP.Mask = "0000-0000-0000"
        mtbNoHP.Name = "mtbNoHP"
        mtbNoHP.Size = New Size(228, 27)
        mtbNoHP.TabIndex = 1
        ' 
        ' lblEmail
        ' 
        lblEmail.Location = New Point(29, 113)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(114, 31)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email Address"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(29, 147)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(285, 27)
        txtEmail.TabIndex = 3
        ' 
        ' lblAlamat
        ' 
        lblAlamat.Location = New Point(29, 200)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(114, 31)
        lblAlamat.TabIndex = 4
        lblAlamat.Text = "Alamat Lengkap"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(29, 233)
        txtAlamat.Margin = New Padding(3, 4, 3, 4)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(457, 132)
        txtAlamat.TabIndex = 5
        ' 
        ' tabProfilAktivitas
        ' 
        tabProfilAktivitas.BackColor = Color.White
        tabProfilAktivitas.Controls.Add(picProfil)
        tabProfilAktivitas.Controls.Add(btnBrowse)
        tabProfilAktivitas.Controls.Add(gbPeran)
        tabProfilAktivitas.Controls.Add(gbKelebihan)
        tabProfilAktivitas.Controls.Add(btnSimpanCetak)
        tabProfilAktivitas.Location = New Point(4, 29)
        tabProfilAktivitas.Margin = New Padding(3, 4, 3, 4)
        tabProfilAktivitas.Name = "tabProfilAktivitas"
        tabProfilAktivitas.Size = New Size(883, 527)
        tabProfilAktivitas.TabIndex = 2
        tabProfilAktivitas.Text = "Profil & Aktivitas"
        ' 
        ' picProfil
        ' 
        picProfil.BorderStyle = BorderStyle.Fixed3D
        picProfil.Location = New Point(29, 33)
        picProfil.Margin = New Padding(3, 4, 3, 4)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(125, 185)
        picProfil.SizeMode = PictureBoxSizeMode.Zoom
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(29, 233)
        btnBrowse.Margin = New Padding(3, 4, 3, 4)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(126, 40)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbPembimbing)
        gbPeran.Controls.Add(rbKonduktor)
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Location = New Point(183, 27)
        gbPeran.Margin = New Padding(3, 4, 3, 4)
        gbPeran.Name = "gbPeran"
        gbPeran.Padding = New Padding(3, 4, 3, 4)
        gbPeran.Size = New Size(206, 160)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        gbPeran.Text = "Peran"
        ' 
        ' rbPembimbing
        ' 
        rbPembimbing.AutoSize = True
        rbPembimbing.Location = New Point(17, 33)
        rbPembimbing.Margin = New Padding(3, 4, 3, 4)
        rbPembimbing.Name = "rbPembimbing"
        rbPembimbing.Size = New Size(153, 24)
        rbPembimbing.TabIndex = 0
        rbPembimbing.Text = "Pembimbing Choir"
        ' 
        ' rbKonduktor
        ' 
        rbKonduktor.Location = New Point(17, 73)
        rbKonduktor.Margin = New Padding(3, 4, 3, 4)
        rbKonduktor.Name = "rbKonduktor"
        rbKonduktor.Size = New Size(119, 32)
        rbKonduktor.TabIndex = 1
        rbKonduktor.Text = "Konduktor"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.Checked = True
        rbAnggota.Location = New Point(17, 113)
        rbAnggota.Margin = New Padding(3, 4, 3, 4)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(119, 32)
        rbAnggota.TabIndex = 2
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        ' 
        ' gbKelebihan
        ' 
        gbKelebihan.Controls.Add(chkBernyanyi)
        gbKelebihan.Controls.Add(chkGitarAkustik)
        gbKelebihan.Controls.Add(chkGitarBasDrum)
        gbKelebihan.Controls.Add(chkPiano)
        gbKelebihan.Controls.Add(chkKeyboard)
        gbKelebihan.Controls.Add(chkCajon)
        gbKelebihan.Controls.Add(chkDrum)
        gbKelebihan.Controls.Add(chkBiola)
        gbKelebihan.Controls.Add(chkSaksofon)
        gbKelebihan.Controls.Add(chkLainnya)
        gbKelebihan.Location = New Point(411, 27)
        gbKelebihan.Margin = New Padding(3, 4, 3, 4)
        gbKelebihan.Name = "gbKelebihan"
        gbKelebihan.Padding = New Padding(3, 4, 3, 4)
        gbKelebihan.Size = New Size(434, 240)
        gbKelebihan.TabIndex = 3
        gbKelebihan.TabStop = False
        gbKelebihan.Text = "Kelebihan Yang Dimiliki"
        ' 
        ' chkBernyanyi
        ' 
        chkBernyanyi.Location = New Point(6, 33)
        chkBernyanyi.Margin = New Padding(3, 4, 3, 4)
        chkBernyanyi.Name = "chkBernyanyi"
        chkBernyanyi.Size = New Size(119, 32)
        chkBernyanyi.TabIndex = 0
        chkBernyanyi.Text = "Bernyanyi"
        ' 
        ' chkGitarAkustik
        ' 
        chkGitarAkustik.Location = New Point(126, 34)
        chkGitarAkustik.Margin = New Padding(3, 4, 3, 4)
        chkGitarAkustik.Name = "chkGitarAkustik"
        chkGitarAkustik.Size = New Size(119, 32)
        chkGitarAkustik.TabIndex = 1
        chkGitarAkustik.Text = "Gitar Akustik"
        ' 
        ' chkGitarBasDrum
        ' 
        chkGitarBasDrum.AutoSize = True
        chkGitarBasDrum.Location = New Point(270, 34)
        chkGitarBasDrum.Margin = New Padding(3, 4, 3, 4)
        chkGitarBasDrum.Name = "chkGitarBasDrum"
        chkGitarBasDrum.Size = New Size(158, 24)
        chkGitarBasDrum.TabIndex = 2
        chkGitarBasDrum.Text = "Gitar Bas/Drum Set"
        ' 
        ' chkPiano
        ' 
        chkPiano.Location = New Point(6, 74)
        chkPiano.Margin = New Padding(3, 4, 3, 4)
        chkPiano.Name = "chkPiano"
        chkPiano.Size = New Size(119, 32)
        chkPiano.TabIndex = 3
        chkPiano.Text = "Piano"
        ' 
        ' chkKeyboard
        ' 
        chkKeyboard.AutoSize = True
        chkKeyboard.Location = New Point(126, 73)
        chkKeyboard.Margin = New Padding(3, 4, 3, 4)
        chkKeyboard.Name = "chkKeyboard"
        chkKeyboard.Size = New Size(142, 24)
        chkKeyboard.TabIndex = 4
        chkKeyboard.Text = "Organ/Keyboard"
        ' 
        ' chkCajon
        ' 
        chkCajon.Location = New Point(270, 73)
        chkCajon.Margin = New Padding(3, 4, 3, 4)
        chkCajon.Name = "chkCajon"
        chkCajon.Size = New Size(119, 32)
        chkCajon.TabIndex = 5
        chkCajon.Text = "Cajon"
        ' 
        ' chkDrum
        ' 
        chkDrum.Location = New Point(6, 114)
        chkDrum.Margin = New Padding(3, 4, 3, 4)
        chkDrum.Name = "chkDrum"
        chkDrum.Size = New Size(119, 32)
        chkDrum.TabIndex = 6
        chkDrum.Text = "Drum"
        ' 
        ' chkBiola
        ' 
        chkBiola.Location = New Point(126, 113)
        chkBiola.Margin = New Padding(3, 4, 3, 4)
        chkBiola.Name = "chkBiola"
        chkBiola.Size = New Size(119, 32)
        chkBiola.TabIndex = 7
        chkBiola.Text = "Biola"
        ' 
        ' chkSaksofon
        ' 
        chkSaksofon.Location = New Point(270, 113)
        chkSaksofon.Margin = New Padding(3, 4, 3, 4)
        chkSaksofon.Name = "chkSaksofon"
        chkSaksofon.Size = New Size(119, 32)
        chkSaksofon.TabIndex = 8
        chkSaksofon.Text = "Saksofon"
        ' 
        ' chkLainnya
        ' 
        chkLainnya.Location = New Point(6, 154)
        chkLainnya.Margin = New Padding(3, 4, 3, 4)
        chkLainnya.Name = "chkLainnya"
        chkLainnya.Size = New Size(119, 32)
        chkLainnya.TabIndex = 9
        chkLainnya.Text = "Lainnya"
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.Navy
        btnSimpanCetak.FlatStyle = FlatStyle.Flat
        btnSimpanCetak.ForeColor = Color.White
        btnSimpanCetak.Location = New Point(411, 287)
        btnSimpanCetak.Margin = New Padding(3, 4, 3, 4)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(251, 67)
        btnSimpanCetak.TabIndex = 4
        btnSimpanCetak.Text = "SIMPAN & CETAK KARTU"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' lblJudulApp
        ' 
        lblJudulApp.AutoSize = True
        lblJudulApp.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblJudulApp.ForeColor = Color.MidnightBlue
        lblJudulApp.Location = New Point(137, 60)
        lblJudulApp.Name = "lblJudulApp"
        lblJudulApp.Size = New Size(539, 50)
        lblJudulApp.TabIndex = 1
        lblJudulApp.Text = "RESONANCE CHOIRS"
        ' 
        ' picLogoApp
        ' 
        picLogoApp.BorderStyle = BorderStyle.FixedSingle
        picLogoApp.Image = My.Resources.Resources.Screenshot_2026_04_07_224001
        picLogoApp.Location = New Point(29, 44)
        picLogoApp.Margin = New Padding(3, 4, 3, 4)
        picLogoApp.Name = "picLogoApp"
        picLogoApp.Size = New Size(91, 106)
        picLogoApp.SizeMode = PictureBoxSizeMode.Zoom
        picLogoApp.TabIndex = 2
        picLogoApp.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(971, 800)
        Controls.Add(MenuStrip1)
        Controls.Add(lblJudulApp)
        Controls.Add(picLogoApp)
        Controls.Add(TabControlUtama)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Resonance Choirs - Member Identity System v2026"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControlUtama.ResumeLayout(False)
        tabDataUtama.ResumeLayout(False)
        tabDataUtama.PerformLayout()
        gbGender.ResumeLayout(False)
        tabKontakInfo.ResumeLayout(False)
        tabKontakInfo.PerformLayout()
        tabProfilAktivitas.ResumeLayout(False)
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        gbKelebihan.ResumeLayout(False)
        gbKelebihan.PerformLayout()
        CType(picLogoApp, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    '--- Declarations (Friend WithEvents) ---
    ' [Header & Navigation]
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuInputData, MenuLihatKartu, MenuSimpanData, MenuBukaData, MenuKeluar As ToolStripMenuItem
    Friend WithEvents lblJudulApp As Label
    Friend WithEvents picLogoApp As PictureBox
    Friend WithEvents TabControlUtama As TabControl
    Friend WithEvents tabDataUtama, tabKontakInfo, tabProfilAktivitas As TabPage

    ' [Tab 1 Controls]
    Friend WithEvents lblNama, lblID, lblLahir, lblSuara As Label
    Friend WithEvents txtNama, txtID As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents rbLaki, rbPerempuan As RadioButton
    Friend WithEvents cmbJenisSuara As ComboBox

    ' [Tab 2 Controls]
    Friend WithEvents lblTelp, lblEmail, lblAlamat As Label
    Friend WithEvents mtbNoHP As MaskedTextBox
    Friend WithEvents txtEmail, txtAlamat As TextBox

    ' [Tab 3 Controls]
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents btnBrowse, btnSimpanCetak As Button
    Friend WithEvents gbPeran, gbKelebihan As GroupBox
    Friend WithEvents rbPembimbing, rbKonduktor, rbAnggota As RadioButton
    Friend WithEvents chkBernyanyi, chkGitarAkustik, chkGitarBasDrum, chkPiano, chkKeyboard, chkCajon, chkDrum, chkBiola, chkSaksofon, chkLainnya As CheckBox

    ' [Dialogs & Providers]
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
