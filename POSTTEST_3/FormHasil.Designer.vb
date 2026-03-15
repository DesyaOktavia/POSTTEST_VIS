<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
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
        pbHasilFoto = New PictureBox()
        txtHasilNama = New TextBox()
        txtHasilUmur = New TextBox()
        txtHasilNoTelp = New TextBox()
        txtHasilTglLahir = New TextBox()
        txtHasilJenisKelamin = New TextBox()
        txtHasilHobby = New TextBox()
        panelKartu = New Panel()
        pnlHeaderKartu = New Panel()
        lblKartuJudul = New Label()
        lblKartuSubJudul = New Label()
        CType(pbHasilFoto, ComponentModel.ISupportInitialize).BeginInit()
        panelKartu.SuspendLayout()
        pnlHeaderKartu.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbHasilFoto
        ' 
        pbHasilFoto.BackColor = Color.WhiteSmoke
        pbHasilFoto.BorderStyle = BorderStyle.FixedSingle
        pbHasilFoto.Location = New Point(33, 115)
        pbHasilFoto.Margin = New Padding(4, 5, 4, 5)
        pbHasilFoto.Name = "pbHasilFoto"
        pbHasilFoto.Size = New Size(159, 230)
        pbHasilFoto.SizeMode = PictureBoxSizeMode.Zoom
        pbHasilFoto.TabIndex = 0
        pbHasilFoto.TabStop = False
        ' 
        ' txtHasilNama
        ' 
        txtHasilNama.BackColor = Color.LemonChiffon
        txtHasilNama.BorderStyle = BorderStyle.None
        txtHasilNama.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtHasilNama.ForeColor = Color.Black
        txtHasilNama.Location = New Point(213, 115)
        txtHasilNama.Margin = New Padding(4, 5, 4, 5)
        txtHasilNama.Name = "txtHasilNama"
        txtHasilNama.ReadOnly = True
        txtHasilNama.Size = New Size(373, 29)
        txtHasilNama.TabIndex = 1
        txtHasilNama.Text = "Nama Lengkap"
        ' 
        ' txtHasilUmur
        ' 
        txtHasilUmur.BackColor = Color.LemonChiffon
        txtHasilUmur.BorderStyle = BorderStyle.None
        txtHasilUmur.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHasilUmur.ForeColor = Color.Black
        txtHasilUmur.Location = New Point(213, 162)
        txtHasilUmur.Margin = New Padding(4, 5, 4, 5)
        txtHasilUmur.Name = "txtHasilUmur"
        txtHasilUmur.ReadOnly = True
        txtHasilUmur.Size = New Size(373, 22)
        txtHasilUmur.TabIndex = 2
        txtHasilUmur.Text = "Umur: XX tahun"
        ' 
        ' txtHasilNoTelp
        ' 
        txtHasilNoTelp.BackColor = Color.LemonChiffon
        txtHasilNoTelp.BorderStyle = BorderStyle.None
        txtHasilNoTelp.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHasilNoTelp.ForeColor = Color.Black
        txtHasilNoTelp.Location = New Point(213, 194)
        txtHasilNoTelp.Margin = New Padding(4, 5, 4, 5)
        txtHasilNoTelp.Name = "txtHasilNoTelp"
        txtHasilNoTelp.ReadOnly = True
        txtHasilNoTelp.Size = New Size(373, 22)
        txtHasilNoTelp.TabIndex = 3
        txtHasilNoTelp.Text = "Telp: 08XXXXXXXXXX"
        ' 
        ' txtHasilTglLahir
        ' 
        txtHasilTglLahir.BackColor = Color.LemonChiffon
        txtHasilTglLahir.BorderStyle = BorderStyle.None
        txtHasilTglLahir.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHasilTglLahir.ForeColor = Color.Black
        txtHasilTglLahir.Location = New Point(213, 226)
        txtHasilTglLahir.Margin = New Padding(4, 5, 4, 5)
        txtHasilTglLahir.Name = "txtHasilTglLahir"
        txtHasilTglLahir.ReadOnly = True
        txtHasilTglLahir.Size = New Size(373, 22)
        txtHasilTglLahir.TabIndex = 4
        txtHasilTglLahir.Text = "Lahir: DD/MM/YYYY"
        ' 
        ' txtHasilJenisKelamin
        ' 
        txtHasilJenisKelamin.BackColor = Color.LemonChiffon
        txtHasilJenisKelamin.BorderStyle = BorderStyle.None
        txtHasilJenisKelamin.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHasilJenisKelamin.ForeColor = Color.Black
        txtHasilJenisKelamin.Location = New Point(213, 258)
        txtHasilJenisKelamin.Margin = New Padding(4, 5, 4, 5)
        txtHasilJenisKelamin.Name = "txtHasilJenisKelamin"
        txtHasilJenisKelamin.ReadOnly = True
        txtHasilJenisKelamin.Size = New Size(373, 22)
        txtHasilJenisKelamin.TabIndex = 5
        txtHasilJenisKelamin.Text = "Gender: Laki-Laki"
        ' 
        ' txtHasilHobby
        ' 
        txtHasilHobby.BackColor = Color.LemonChiffon
        txtHasilHobby.BorderStyle = BorderStyle.None
        txtHasilHobby.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHasilHobby.ForeColor = Color.Black
        txtHasilHobby.Location = New Point(213, 291)
        txtHasilHobby.Margin = New Padding(4, 5, 4, 5)
        txtHasilHobby.Multiline = True
        txtHasilHobby.Name = "txtHasilHobby"
        txtHasilHobby.ReadOnly = True
        txtHasilHobby.Size = New Size(373, 69)
        txtHasilHobby.TabIndex = 6
        txtHasilHobby.Text = "Hobi: Koding, Musik, Olahraga"
        ' 
        ' panelKartu
        ' 
        panelKartu.BackColor = Color.LemonChiffon
        panelKartu.BorderStyle = BorderStyle.FixedSingle
        panelKartu.Controls.Add(pnlHeaderKartu)
        panelKartu.Controls.Add(pbHasilFoto)
        panelKartu.Controls.Add(txtHasilHobby)
        panelKartu.Controls.Add(txtHasilNama)
        panelKartu.Controls.Add(txtHasilJenisKelamin)
        panelKartu.Controls.Add(txtHasilUmur)
        panelKartu.Controls.Add(txtHasilTglLahir)
        panelKartu.Controls.Add(txtHasilNoTelp)
        panelKartu.Location = New Point(27, 31)
        panelKartu.Margin = New Padding(4, 5, 4, 5)
        panelKartu.Name = "panelKartu"
        panelKartu.Size = New Size(613, 399)
        panelKartu.TabIndex = 7
        ' 
        ' pnlHeaderKartu
        ' 
        pnlHeaderKartu.BackColor = Color.Gold
        pnlHeaderKartu.Controls.Add(lblKartuJudul)
        pnlHeaderKartu.Controls.Add(lblKartuSubJudul)
        pnlHeaderKartu.Dock = DockStyle.Top
        pnlHeaderKartu.Location = New Point(0, 0)
        pnlHeaderKartu.Margin = New Padding(4, 5, 4, 5)
        pnlHeaderKartu.Name = "pnlHeaderKartu"
        pnlHeaderKartu.Size = New Size(611, 92)
        pnlHeaderKartu.TabIndex = 9
        ' 
        ' lblKartuJudul
        ' 
        lblKartuJudul.AutoSize = True
        lblKartuJudul.Font = New Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKartuJudul.ForeColor = Color.Black
        lblKartuJudul.Location = New Point(20, 15)
        lblKartuJudul.Margin = New Padding(4, 0, 4, 0)
        lblKartuJudul.Name = "lblKartuJudul"
        lblKartuJudul.Size = New Size(279, 38)
        lblKartuJudul.TabIndex = 7
        lblKartuJudul.Text = "KARTU ANGGOTA"
        ' 
        ' lblKartuSubJudul
        ' 
        lblKartuSubJudul.AutoSize = True
        lblKartuSubJudul.Font = New Font("Arial", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblKartuSubJudul.ForeColor = Color.DimGray
        lblKartuSubJudul.Location = New Point(23, 62)
        lblKartuSubJudul.Margin = New Padding(4, 0, 4, 0)
        lblKartuSubJudul.Name = "lblKartuSubJudul"
        lblKartuSubJudul.Size = New Size(150, 16)
        lblKartuSubJudul.TabIndex = 8
        lblKartuSubJudul.Text = "Komunitas Kreatif Indo"
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(667, 462)
        Controls.Add(panelKartu)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4, 5, 4, 5)
        Name = "FormHasil"
        StartPosition = FormStartPosition.CenterParent
        Text = "Kartu Hasil Cetak"
        CType(pbHasilFoto, ComponentModel.ISupportInitialize).EndInit()
        panelKartu.ResumeLayout(False)
        panelKartu.PerformLayout()
        pnlHeaderKartu.ResumeLayout(False)
        pnlHeaderKartu.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pbHasilFoto As PictureBox
    Friend WithEvents txtHasilNama As TextBox
    Friend WithEvents txtHasilUmur As TextBox
    Friend WithEvents txtHasilNoTelp As TextBox
    Friend WithEvents txtHasilTglLahir As TextBox
    Friend WithEvents txtHasilJenisKelamin As TextBox
    Friend WithEvents txtHasilHobby As TextBox
    Friend WithEvents panelKartu As Panel
    Friend WithEvents pnlHeaderKartu As Panel
    Friend WithEvents lblKartuSubJudul As Label
    Friend WithEvents lblKartuJudul As Label
End Class