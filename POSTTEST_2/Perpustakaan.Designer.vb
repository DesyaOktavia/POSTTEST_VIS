<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpustakaan
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
        GBtambah = New GroupBox()
        Btambah = New Button()
        LterbitTambah = New Label()
        TBterbitTambah = New TextBox()
        LpengaranTambah = New Label()
        TBpengarangTambah = New TextBox()
        LjudulTambah = New Label()
        TBjudulTambah = New TextBox()
        LkodeTambah = New Label()
        TBkodeTambah = New TextBox()
        GBhapus = New GroupBox()
        Bhapus = New Button()
        LjudulHapus = New Label()
        TBjudulHapus = New TextBox()
        LkodeHapus = New Label()
        TBkodeHapus = New TextBox()
        LBdaftarbuku = New ListBox()
        Ldaftarbuku = New Label()
        GBtambah.SuspendLayout()
        GBhapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' GBtambah
        ' 
        GBtambah.Controls.Add(Btambah)
        GBtambah.Controls.Add(LterbitTambah)
        GBtambah.Controls.Add(TBterbitTambah)
        GBtambah.Controls.Add(LpengaranTambah)
        GBtambah.Controls.Add(TBpengarangTambah)
        GBtambah.Controls.Add(LjudulTambah)
        GBtambah.Controls.Add(TBjudulTambah)
        GBtambah.Controls.Add(LkodeTambah)
        GBtambah.Controls.Add(TBkodeTambah)
        GBtambah.Location = New Point(12, 25)
        GBtambah.Name = "GBtambah"
        GBtambah.Size = New Size(335, 235)
        GBtambah.TabIndex = 0
        GBtambah.TabStop = False
        GBtambah.Text = "Tambah Buku"
        ' 
        ' Btambah
        ' 
        Btambah.Location = New Point(219, 203)
        Btambah.Name = "Btambah"
        Btambah.Size = New Size(94, 29)
        Btambah.TabIndex = 11
        Btambah.Text = "Tambah"
        Btambah.UseVisualStyleBackColor = True
        ' 
        ' LterbitTambah
        ' 
        LterbitTambah.AutoSize = True
        LterbitTambah.Location = New Point(6, 164)
        LterbitTambah.Name = "LterbitTambah"
        LterbitTambah.Size = New Size(83, 20)
        LterbitTambah.TabIndex = 2
        LterbitTambah.Text = "Terbit Buku"
        ' 
        ' TBterbitTambah
        ' 
        TBterbitTambah.Location = New Point(146, 161)
        TBterbitTambah.Name = "TBterbitTambah"
        TBterbitTambah.Size = New Size(167, 27)
        TBterbitTambah.TabIndex = 6
        ' 
        ' LpengaranTambah
        ' 
        LpengaranTambah.AutoSize = True
        LpengaranTambah.Location = New Point(6, 122)
        LpengaranTambah.Name = "LpengaranTambah"
        LpengaranTambah.Size = New Size(115, 20)
        LpengaranTambah.TabIndex = 5
        LpengaranTambah.Text = "Pengarang Buku"
        ' 
        ' TBpengarangTambah
        ' 
        TBpengarangTambah.Location = New Point(146, 119)
        TBpengarangTambah.Name = "TBpengarangTambah"
        TBpengarangTambah.Size = New Size(167, 27)
        TBpengarangTambah.TabIndex = 4
        ' 
        ' LjudulTambah
        ' 
        LjudulTambah.AutoSize = True
        LjudulTambah.Location = New Point(6, 80)
        LjudulTambah.Name = "LjudulTambah"
        LjudulTambah.Size = New Size(79, 20)
        LjudulTambah.TabIndex = 3
        LjudulTambah.Text = "Judul Buku"
        ' 
        ' TBjudulTambah
        ' 
        TBjudulTambah.Location = New Point(146, 77)
        TBjudulTambah.Name = "TBjudulTambah"
        TBjudulTambah.Size = New Size(167, 27)
        TBjudulTambah.TabIndex = 2
        ' 
        ' LkodeTambah
        ' 
        LkodeTambah.AutoSize = True
        LkodeTambah.Location = New Point(6, 38)
        LkodeTambah.Name = "LkodeTambah"
        LkodeTambah.Size = New Size(80, 20)
        LkodeTambah.TabIndex = 1
        LkodeTambah.Text = "Kode Buku"
        ' 
        ' TBkodeTambah
        ' 
        TBkodeTambah.Location = New Point(146, 35)
        TBkodeTambah.Name = "TBkodeTambah"
        TBkodeTambah.Size = New Size(167, 27)
        TBkodeTambah.TabIndex = 0
        ' 
        ' GBhapus
        ' 
        GBhapus.Controls.Add(Bhapus)
        GBhapus.Controls.Add(LjudulHapus)
        GBhapus.Controls.Add(TBjudulHapus)
        GBhapus.Controls.Add(LkodeHapus)
        GBhapus.Controls.Add(TBkodeHapus)
        GBhapus.Location = New Point(370, 25)
        GBhapus.Name = "GBhapus"
        GBhapus.Size = New Size(335, 235)
        GBhapus.TabIndex = 1
        GBhapus.TabStop = False
        GBhapus.Text = "Hapus Buku"
        ' 
        ' Bhapus
        ' 
        Bhapus.Location = New Point(224, 203)
        Bhapus.Name = "Bhapus"
        Bhapus.Size = New Size(94, 29)
        Bhapus.TabIndex = 12
        Bhapus.Text = "Hapus"
        Bhapus.UseVisualStyleBackColor = True
        ' 
        ' LjudulHapus
        ' 
        LjudulHapus.AutoSize = True
        LjudulHapus.Location = New Point(6, 80)
        LjudulHapus.Name = "LjudulHapus"
        LjudulHapus.Size = New Size(79, 20)
        LjudulHapus.TabIndex = 2
        LjudulHapus.Text = "Judul Buku"
        ' 
        ' TBjudulHapus
        ' 
        TBjudulHapus.Location = New Point(151, 77)
        TBjudulHapus.Name = "TBjudulHapus"
        TBjudulHapus.Size = New Size(167, 27)
        TBjudulHapus.TabIndex = 8
        ' 
        ' LkodeHapus
        ' 
        LkodeHapus.AutoSize = True
        LkodeHapus.Location = New Point(6, 38)
        LkodeHapus.Name = "LkodeHapus"
        LkodeHapus.Size = New Size(80, 20)
        LkodeHapus.TabIndex = 2
        LkodeHapus.Text = "Kode Buku"
        ' 
        ' TBkodeHapus
        ' 
        TBkodeHapus.Location = New Point(151, 35)
        TBkodeHapus.Name = "TBkodeHapus"
        TBkodeHapus.Size = New Size(167, 27)
        TBkodeHapus.TabIndex = 7
        ' 
        ' LBdaftarbuku
        ' 
        LBdaftarbuku.FormattingEnabled = True
        LBdaftarbuku.Location = New Point(18, 303)
        LBdaftarbuku.Name = "LBdaftarbuku"
        LBdaftarbuku.Size = New Size(670, 124)
        LBdaftarbuku.TabIndex = 9
        ' 
        ' Ldaftarbuku
        ' 
        Ldaftarbuku.AutoSize = True
        Ldaftarbuku.Location = New Point(18, 280)
        Ldaftarbuku.Name = "Ldaftarbuku"
        Ldaftarbuku.Size = New Size(87, 20)
        Ldaftarbuku.TabIndex = 10
        Ldaftarbuku.Text = "Daftar Buku"
        ' 
        ' Perpustakaan
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(733, 450)
        Controls.Add(Ldaftarbuku)
        Controls.Add(LBdaftarbuku)
        Controls.Add(GBhapus)
        Controls.Add(GBtambah)
        Name = "Perpustakaan"
        Text = "Sistem Perpustakaan"
        GBtambah.ResumeLayout(False)
        GBtambah.PerformLayout()
        GBhapus.ResumeLayout(False)
        GBhapus.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GBtambah As GroupBox
    Friend WithEvents GBhapus As GroupBox
    Friend WithEvents TBkodeTambah As TextBox
    Friend WithEvents LkodeTambah As Label
    Friend WithEvents TBjudulTambah As TextBox
    Friend WithEvents LjudulTambah As Label
    Friend WithEvents TBpengarangTambah As TextBox
    Friend WithEvents LpengaranTambah As Label
    Friend WithEvents TBterbitTambah As TextBox
    Friend WithEvents LterbitTambah As Label
    Friend WithEvents TBkodeHapus As TextBox
    Friend WithEvents LkodeHapus As Label
    Friend WithEvents TBjudulHapus As TextBox
    Friend WithEvents LjudulHapus As Label
    Friend WithEvents LBdaftarbuku As ListBox
    Friend WithEvents Ldaftarbuku As Label
    Friend WithEvents Btambah As Button
    Friend WithEvents Bhapus As Button

End Class
