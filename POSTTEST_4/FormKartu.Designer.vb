<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.components = New System.ComponentModel.Container()

        '===========================================================
        ' INSTANSIASI KOMPONEN KARTU
        '===========================================================
        Me.pnlKartu = New System.Windows.Forms.Panel()

        Me.picFotoKartu = New System.Windows.Forms.PictureBox()

        Me.lblNamaHasil = New System.Windows.Forms.Label()
        Me.lblIDHasil = New System.Windows.Forms.Label()
        Me.lblSuaraHasil = New System.Windows.Forms.Label()
        Me.lblKontakHasil = New System.Windows.Forms.Label()
        Me.lblHobbyHasil = New System.Windows.Forms.Label()

        Me.lblHeaderResonance = New System.Windows.Forms.Label()
        Me.lblSubHeader = New System.Windows.Forms.Label()

        Me.btnTutup = New System.Windows.Forms.Button()


        '===========================================================
        ' PENGATURAN PANEL (FRAME ID CARD)
        '===========================================================
        Me.pnlKartu.BackColor = System.Drawing.Color.White
        Me.pnlKartu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlKartu.Location = New System.Drawing.Point(30, 30)
        Me.pnlKartu.Name = "pnlKartu"
        Me.pnlKartu.Size = New System.Drawing.Size(480, 270)
        Me.pnlKartu.TabIndex = 0


        '-----------------------------------------------------------
        ' HEADER DI DALAM KARTU
        '-----------------------------------------------------------
        Me.lblHeaderResonance.AutoSize = True
        Me.lblHeaderResonance.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderResonance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblHeaderResonance.Location = New System.Drawing.Point(20, 15)
        Me.lblHeaderResonance.Text = "RESONANCE CHOIRS"

        Me.lblSubHeader.AutoSize = True
        Me.lblSubHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblSubHeader.Location = New System.Drawing.Point(22, 42)
        Me.lblSubHeader.Text = "Official Identity Card - 2026 Edition"


        '-----------------------------------------------------------
        ' FOTO ANGGOTA
        '-----------------------------------------------------------
        Me.picFotoKartu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picFotoKartu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFotoKartu.Location = New System.Drawing.Point(25, 80)
        Me.picFotoKartu.Name = "picFotoKartu"
        Me.picFotoKartu.Size = New System.Drawing.Size(110, 140)
        Me.picFotoKartu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom


        '-----------------------------------------------------------
        ' DETAIL INFORMASI (LABEL HASIL)
        '-----------------------------------------------------------
        ' Nama Lengkap
        Me.lblNamaHasil.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblNamaHasil.Location = New System.Drawing.Point(150, 80)
        Me.lblNamaHasil.Name = "lblNamaHasil"
        Me.lblNamaHasil.Size = New System.Drawing.Size(300, 30)
        Me.lblNamaHasil.Text = "NAMA LENGKAP"

        ' ID Anggota
        Me.lblIDHasil.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblIDHasil.Location = New System.Drawing.Point(150, 115)
        Me.lblIDHasil.Name = "lblIDHasil"
        Me.lblIDHasil.Size = New System.Drawing.Size(300, 20)
        Me.lblIDHasil.Text = "ID: 000000"

        ' Jenis Suara
        Me.lblSuaraHasil.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSuaraHasil.Location = New System.Drawing.Point(150, 140)
        Me.lblSuaraHasil.Name = "lblSuaraHasil"
        Me.lblSuaraHasil.Size = New System.Drawing.Size(300, 20)
        Me.lblSuaraHasil.Text = "Voice: Bass"

        ' Kontak (Telepon/Email)
        Me.lblKontakHasil.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKontakHasil.Location = New System.Drawing.Point(150, 165)
        Me.lblKontakHasil.Name = "lblKontakHasil"
        Me.lblKontakHasil.Size = New System.Drawing.Size(300, 20)
        Me.lblKontakHasil.Text = "Contact: resonance@choir.com"

        ' Kelebihan / Alat Musik
        Me.lblHobbyHasil.Font = New System.Drawing.Font("Segoe UI Semilight", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lblHobbyHasil.Location = New System.Drawing.Point(150, 195)
        Me.lblHobbyHasil.Name = "lblHobbyHasil"
        Me.lblHobbyHasil.Size = New System.Drawing.Size(310, 55)
        Me.lblHobbyHasil.Text = "Skills: Piano, Singing, Guitar"


        '===========================================================
        ' TOMBOL AKSI (DI LUAR FRAME KARTU)
        '===========================================================
        Me.btnTutup.Location = New System.Drawing.Point(220, 315)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(100, 35)
        Me.btnTutup.TabIndex = 1
        Me.btnTutup.Text = "Tutup Kartu"
        Me.btnTutup.UseVisualStyleBackColor = True


        '===========================================================
        ' FORM SETTINGS
        '===========================================================
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(245, 245, 250)
        Me.ClientSize = New System.Drawing.Size(540, 370)

        Me.Controls.Add(Me.pnlKartu)
        Me.Controls.Add(Me.btnTutup)

        Me.pnlKartu.Controls.Add(Me.lblHeaderResonance)
        Me.pnlKartu.Controls.Add(Me.lblSubHeader)
        Me.pnlKartu.Controls.Add(Me.picFotoKartu)
        Me.pnlKartu.Controls.Add(Me.lblNamaHasil)
        Me.pnlKartu.Controls.Add(Me.lblIDHasil)
        Me.pnlKartu.Controls.Add(Me.lblSuaraHasil)
        Me.pnlKartu.Controls.Add(Me.lblKontakHasil)
        Me.pnlKartu.Controls.Add(Me.lblHobbyHasil)

        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormKartu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ID Card Preview - Resonance Choirs"

        Me.pnlKartu.ResumeLayout(False)
        Me.pnlKartu.PerformLayout()
        CType(Me.picFotoKartu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    '--- Declarations (Friend WithEvents) ---
    Friend WithEvents pnlKartu As Panel
    Friend WithEvents picFotoKartu As PictureBox
    Friend WithEvents lblHeaderResonance, lblSubHeader As Label
    Friend WithEvents lblNamaHasil, lblIDHasil, lblSuaraHasil, lblKontakHasil, lblHobbyHasil As Label
    Friend WithEvents btnTutup As Button
End Class
