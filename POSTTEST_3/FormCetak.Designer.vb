<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.lblUmur = New System.Windows.Forms.Label()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.lblNoTelp = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblTglLahir = New System.Windows.Forms.Label()
        Me.dtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.gbJenisKelamin = New System.Windows.Forms.GroupBox()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLakiLaki = New System.Windows.Forms.RadioButton()
        Me.gbHobby = New System.Windows.Forms.GroupBox()
        Me.flpHobby = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkBaca = New System.Windows.Forms.CheckBox()
        Me.chkTulis = New System.Windows.Forms.CheckBox()
        Me.chkOlahraga = New System.Windows.Forms.CheckBox()
        Me.chkMusik = New System.Windows.Forms.CheckBox()
        Me.chkGame = New System.Windows.Forms.CheckBox()
        Me.chkMasak = New System.Windows.Forms.CheckBox()
        Me.chkFoto = New System.Windows.Forms.CheckBox()
        Me.chkTravel = New System.Windows.Forms.CheckBox()
        Me.chkMenggambar = New System.Windows.Forms.CheckBox()
        Me.chkKoding = New System.Windows.Forms.CheckBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.panelInput = New System.Windows.Forms.Panel()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbJenisKelamin.SuspendLayout()
        Me.gbHobby.SuspendLayout()
        Me.flpHobby.SuspendLayout()
        Me.panelInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbProfile
        '
        Me.pbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbProfile.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pbProfile.Location = New System.Drawing.Point(20, 60)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(150, 180)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProfile.TabIndex = 0
        Me.pbProfile.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnBrowse.FlatAppearance.BorderSize = 1
        Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Location = New System.Drawing.Point(20, 246)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(150, 28)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Pilih Foto"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(200, 60)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(39, 15)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(300, 57)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(250, 23)
        Me.txtNama.TabIndex = 3
        '
        'txtUmur
        '
        Me.txtUmur.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUmur.Location = New System.Drawing.Point(300, 86)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(60, 23)
        Me.txtUmur.TabIndex = 5
        '
        'lblUmur
        '
        Me.lblUmur.AutoSize = True
        Me.lblUmur.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUmur.Location = New System.Drawing.Point(200, 89)
        Me.lblUmur.Name = "lblUmur"
        Me.lblUmur.Size = New System.Drawing.Size(37, 15)
        Me.lblUmur.TabIndex = 4
        Me.lblUmur.Text = "Umur"
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoTelp.Location = New System.Drawing.Point(300, 115)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(250, 23)
        Me.txtNoTelp.TabIndex = 7
        '
        'lblNoTelp
        '
        Me.lblNoTelp.AutoSize = True
        Me.lblNoTelp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoTelp.Location = New System.Drawing.Point(200, 118)
        Me.lblNoTelp.Name = "lblNoTelp"
        Me.lblNoTelp.Size = New System.Drawing.Size(91, 15)
        Me.lblNoTelp.TabIndex = 6
        Me.lblNoTelp.Text = "Nomor Telepon"
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(300, 173)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(250, 60)
        Me.txtAlamat.TabIndex = 9
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamat.Location = New System.Drawing.Point(200, 176)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(45, 15)
        Me.lblAlamat.TabIndex = 8
        Me.lblAlamat.Text = "Alamat"
        '
        'lblTglLahir
        '
        Me.lblTglLahir.AutoSize = True
        Me.lblTglLahir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTglLahir.Location = New System.Drawing.Point(200, 147)
        Me.lblTglLahir.Name = "lblTglLahir"
        Me.lblTglLahir.Size = New System.Drawing.Size(77, 15)
        Me.lblTglLahir.TabIndex = 10
        Me.lblTglLahir.Text = "Tanggal Lahir"
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTglLahir.Location = New System.Drawing.Point(300, 144)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(120, 23)
        Me.dtpTglLahir.TabIndex = 11
        '
        'gbJenisKelamin
        '
        Me.gbJenisKelamin.Controls.Add(Me.rbPerempuan)
        Me.gbJenisKelamin.Controls.Add(Me.rbLakiLaki)
        Me.gbJenisKelamin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbJenisKelamin.Location = New System.Drawing.Point(580, 50)
        Me.gbJenisKelamin.Name = "gbJenisKelamin"
        Me.gbJenisKelamin.Size = New System.Drawing.Size(200, 80)
        Me.gbJenisKelamin.TabIndex = 12
        Me.gbJenisKelamin.TabStop = False
        Me.gbJenisKelamin.Text = "Jenis Kelamin"
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(20, 50)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(86, 19)
        Me.rbPerempuan.TabIndex = 1
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'rbLakiLaki
        '
        Me.rbLakiLaki.AutoSize = True
        Me.rbLakiLaki.Location = New System.Drawing.Point(20, 25)
        Me.rbLakiLaki.Name = "rbLakiLaki"
        Me.rbLakiLaki.Size = New System.Drawing.Size(71, 19)
        Me.rbLakiLaki.TabIndex = 0
        Me.rbLakiLaki.TabStop = True
        Me.rbLakiLaki.Text = "Laki-Laki"
        Me.rbLakiLaki.UseVisualStyleBackColor = True
        '
        'gbHobby
        '
        Me.gbHobby.Controls.Add(Me.flpHobby)
        Me.gbHobby.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHobby.Location = New System.Drawing.Point(580, 140)
        Me.gbHobby.Name = "gbHobby"
        Me.gbHobby.Size = New System.Drawing.Size(200, 150)
        Me.gbHobby.TabIndex = 13
        Me.gbHobby.TabStop = False
        Me.gbHobby.Text = "Hobby"
        '
        'flpHobby
        '
        Me.flpHobby.Controls.Add(Me.chkBaca)
        Me.flpHobby.Controls.Add(Me.chkTulis)
        Me.flpHobby.Controls.Add(Me.chkOlahraga)
        Me.flpHobby.Controls.Add(Me.chkMusik)
        Me.flpHobby.Controls.Add(Me.chkGame)
        Me.flpHobby.Controls.Add(Me.chkMasak)
        Me.flpHobby.Controls.Add(Me.chkFoto)
        Me.flpHobby.Controls.Add(Me.chkTravel)
        Me.flpHobby.Controls.Add(Me.chkMenggambar)
        Me.flpHobby.Controls.Add(Me.chkKoding)
        Me.flpHobby.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpHobby.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpHobby.Location = New System.Drawing.Point(3, 19)
        Me.flpHobby.Name = "flpHobby"
        Me.flpHobby.Size = New System.Drawing.Size(194, 128)
        Me.flpHobby.TabIndex = 0
        '
        'chkBaca
        '
        Me.chkBaca.AutoSize = True
        Me.chkBaca.Location = New System.Drawing.Point(3, 3)
        Me.chkBaca.Name = "chkBaca"
        Me.chkBaca.Size = New System.Drawing.Size(77, 19)
        Me.chkBaca.TabIndex = 0
        Me.chkBaca.Text = "Membaca"
        Me.chkBaca.UseVisualStyleBackColor = True
        '
        'chkTulis
        '
        Me.chkTulis.AutoSize = True
        Me.chkTulis.Location = New System.Drawing.Point(3, 28)
        Me.chkTulis.Name = "chkTulis"
        Me.chkTulis.Size = New System.Drawing.Size(69, 19)
        Me.chkTulis.TabIndex = 1
        Me.chkTulis.Text = "Menulis"
        Me.chkTulis.UseVisualStyleBackColor = True
        '
        'chkOlahraga
        '
        Me.chkOlahraga.AutoSize = True
        Me.chkOlahraga.Location = New System.Drawing.Point(3, 53)
        Me.chkOlahraga.Name = "chkOlahraga"
        Me.chkOlahraga.Size = New System.Drawing.Size(73, 19)
        Me.chkOlahraga.TabIndex = 2
        Me.chkOlahraga.Text = "Olahraga"
        Me.chkOlahraga.UseVisualStyleBackColor = True
        '
        'chkMusik
        '
        Me.chkMusik.AutoSize = True
        Me.chkMusik.Location = New System.Drawing.Point(3, 78)
        Me.chkMusik.Name = "chkMusik"
        Me.chkMusik.Size = New System.Drawing.Size(58, 19)
        Me.chkMusik.TabIndex = 3
        Me.chkMusik.Text = "Musik"
        Me.chkMusik.UseVisualStyleBackColor = True
        '
        'chkGame
        '
        Me.chkGame.AutoSize = True
        Me.chkGame.Location = New System.Drawing.Point(3, 103)
        Me.chkGame.Name = "chkGame"
        Me.chkGame.Size = New System.Drawing.Size(69, 19)
        Me.chkGame.TabIndex = 4
        Me.chkGame.Text = "Gaming"
        Me.chkGame.UseVisualStyleBackColor = True
        '
        'chkMasak
        '
        Me.chkMasak.AutoSize = True
        Me.chkMasak.Location = New System.Drawing.Point(86, 3)
        Me.chkMasak.Name = "chkMasak"
        Me.chkMasak.Size = New System.Drawing.Size(73, 19)
        Me.chkMasak.TabIndex = 5
        Me.chkMasak.Text = "Memasak"
        Me.chkMasak.UseVisualStyleBackColor = True
        '
        'chkFoto
        '
        Me.chkFoto.AutoSize = True
        Me.chkFoto.Location = New System.Drawing.Point(86, 28)
        Me.chkFoto.Name = "chkFoto"
        Me.chkFoto.Size = New System.Drawing.Size(66, 19)
        Me.chkFoto.TabIndex = 6
        Me.chkFoto.Text = "Fotografi"
        Me.chkFoto.UseVisualStyleBackColor = True
        '
        'chkTravel
        '
        Me.chkTravel.AutoSize = True
        Me.chkTravel.Location = New System.Drawing.Point(86, 53)
        Me.chkTravel.Name = "chkTravel"
        Me.chkTravel.Size = New System.Drawing.Size(81, 19)
        Me.chkTravel.TabIndex = 7
        Me.chkTravel.Text = "Travelling"
        Me.chkTravel.UseVisualStyleBackColor = True
        '
        'chkMenggambar
        '
        Me.chkMenggambar.AutoSize = True
        Me.chkMenggambar.Location = New System.Drawing.Point(86, 78)
        Me.chkMenggambar.Name = "chkMenggambar"
        Me.chkMenggambar.Size = New System.Drawing.Size(92, 19)
        Me.chkMenggambar.TabIndex = 8
        Me.chkMenggambar.Text = "Menggambar"
        Me.chkMenggambar.UseVisualStyleBackColor = True
        '
        'chkKoding
        '
        Me.chkKoding.AutoSize = True
        Me.chkKoding.Location = New System.Drawing.Point(86, 103)
        Me.chkKoding.Name = "chkKoding"
        Me.chkKoding.Size = New System.Drawing.Size(65, 19)
        Me.chkKoding.TabIndex = 9
        Me.chkKoding.Text = "Coding"
        Me.chkKoding.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.Gold
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.ForeColor = System.Drawing.Color.Black
        Me.btnCetak.Location = New System.Drawing.Point(300, 310)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(250, 45)
        Me.btnCetak.TabIndex = 14
        Me.btnCetak.Text = "CETAK KARTU"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Gold
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Black
        Me.lblJudul.Location = New System.Drawing.Point(0, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lblJudul.Size = New System.Drawing.Size(800, 50)
        Me.lblJudul.TabIndex = 15
        Me.lblJudul.Text = "Pendaftaran Anggota Komunitas"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelInput
        '
        Me.panelInput.BackColor = System.Drawing.Color.White
        Me.panelInput.Controls.Add(Me.btnBrowse)
        Me.panelInput.Controls.Add(Me.pbProfile)
        Me.panelInput.Controls.Add(Me.btnCetak)
        Me.panelInput.Controls.Add(Me.lblNama)
        Me.panelInput.Controls.Add(Me.gbHobby)
        Me.panelInput.Controls.Add(Me.txtNama)
        Me.panelInput.Controls.Add(Me.gbJenisKelamin)
        Me.panelInput.Controls.Add(Me.lblUmur)
        Me.panelInput.Controls.Add(Me.dtpTglLahir)
        Me.panelInput.Controls.Add(Me.txtUmur)
        Me.panelInput.Controls.Add(Me.lblTglLahir)
        Me.panelInput.Controls.Add(Me.lblNoTelp)
        Me.panelInput.Controls.Add(Me.txtAlamat)
        Me.panelInput.Controls.Add(Me.txtNoTelp)
        Me.panelInput.Controls.Add(Me.lblAlamat)
        Me.panelInput.Location = New System.Drawing.Point(0, 50)
        Me.panelInput.Name = "panelInput"
        Me.panelInput.Size = New System.Drawing.Size(800, 370)
        Me.panelInput.TabIndex = 16
        '
        'FormCetak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 420)
        Me.Controls.Add(Me.panelInput)
        Me.Controls.Add(Me.lblJudul)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormCetak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Cetak Kartu"
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbJenisKelamin.ResumeLayout(False)
        Me.gbJenisKelamin.PerformLayout()
        Me.gbHobby.ResumeLayout(False)
        Me.flpHobby.ResumeLayout(False)
        Me.flpHobby.PerformLayout()
        Me.panelInput.ResumeLayout(False)
        Me.panelInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents lblUmur As Label
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents gbJenisKelamin As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLakiLaki As RadioButton
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents flpHobby As FlowLayoutPanel
    Friend WithEvents chkBaca As CheckBox
    Friend WithEvents chkTulis As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkMusik As CheckBox
    Friend WithEvents chkGame As CheckBox
    Friend WithEvents chkMasak As CheckBox
    Friend WithEvents chkFoto As CheckBox
    Friend WithEvents chkTravel As CheckBox
    Friend WithEvents chkMenggambar As CheckBox
    Friend WithEvents chkKoding As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents lblJudul As Label
    Friend WithEvents panelInput As Panel
End Class