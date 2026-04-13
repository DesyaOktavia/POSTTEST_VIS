<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetak
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
        Pcetak = New Panel()
        Lgaris = New Label()
        Lterimakasih = New Label()
        Ltotal = New Label()
        Lharga = New Label()
        Ljumlah = New Label()
        Ljamu = New Label()
        Lnama = New Label()
        Lnostruk = New Label()
        Lsub = New Label()
        Ljudulstruk = New Label()
        Btutup = New Button()
        Pcetak.SuspendLayout()
        SuspendLayout()
        ' 
        ' Pcetak
        ' 
        Pcetak.BackColor = Color.White
        Pcetak.BorderStyle = BorderStyle.FixedSingle
        Pcetak.Controls.Add(Lgaris)
        Pcetak.Controls.Add(Lterimakasih)
        Pcetak.Controls.Add(Ltotal)
        Pcetak.Controls.Add(Lharga)
        Pcetak.Controls.Add(Ljumlah)
        Pcetak.Controls.Add(Ljamu)
        Pcetak.Controls.Add(Lnama)
        Pcetak.Controls.Add(Lnostruk)
        Pcetak.Controls.Add(Lsub)
        Pcetak.Controls.Add(Ljudulstruk)
        Pcetak.Location = New Point(30, 25)
        Pcetak.Name = "Pcetak"
        Pcetak.Size = New Size(420, 520)
        Pcetak.TabIndex = 0
        ' 
        ' Lgaris
        ' 
        Lgaris.AutoSize = True
        Lgaris.Location = New Point(25, 420)
        Lgaris.Name = "Lgaris"
        Lgaris.Size = New Size(369, 20)
        Lgaris.TabIndex = 9
        Lgaris.Text = "------------------------------------------------------------"
        ' 
        ' Lterimakasih
        ' 
        Lterimakasih.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        Lterimakasih.Location = New Point(25, 470)
        Lterimakasih.Name = "Lterimakasih"
        Lterimakasih.Size = New Size(370, 25)
        Lterimakasih.TabIndex = 8
        Lterimakasih.Text = "Semoga Sehat Selalu - KedaiSehat"
        Lterimakasih.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Ltotal
        ' 
        Ltotal.AutoSize = True
        Ltotal.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Ltotal.Location = New Point(25, 440)
        Ltotal.Name = "Ltotal"
        Ltotal.Size = New Size(130, 28)
        Ltotal.TabIndex = 7
        Ltotal.Text = "Total Bayar :"
        ' 
        ' Lharga
        ' 
        Lharga.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Lharga.ForeColor = Color.DarkGreen
        Lharga.Location = New Point(175, 440)
        Lharga.Name = "Lharga"
        Lharga.Size = New Size(220, 28)
        Lharga.TabIndex = 6
        Lharga.Text = "Rp. 0"
        Lharga.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Ljumlah
        ' 
        Ljumlah.AutoSize = True
        Ljumlah.Location = New Point(25, 330)
        Ljumlah.Name = "Ljumlah"
        Ljumlah.Size = New Size(114, 20)
        Ljumlah.TabIndex = 5
        Ljumlah.Text = "Jumlah : 0 Gelas"
        ' 
        ' Ljamu
        ' 
        Ljamu.AutoSize = True
        Ljamu.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Ljamu.Location = New Point(25, 300)
        Ljamu.Name = "Ljamu"
        Ljamu.Size = New Size(107, 25)
        Ljamu.TabIndex = 4
        Ljamu.Text = "Jenis Jamu"
        ' 
        ' Lnama
        ' 
        Lnama.AutoSize = True
        Lnama.Location = New Point(25, 220)
        Lnama.Name = "Lnama"
        Lnama.Size = New Size(122, 20)
        Lnama.TabIndex = 3
        Lnama.Text = "Nama Pelanggan"
        ' 
        ' Lnostruk
        ' 
        Lnostruk.AutoSize = True
        Lnostruk.ForeColor = Color.Gray
        Lnostruk.Location = New Point(25, 130)
        Lnostruk.Name = "Lnostruk"
        Lnostruk.Size = New Size(131, 20)
        Lnostruk.TabIndex = 2
        Lnostruk.Text = "No: STK-20260413"
        ' 
        ' Lsub
        ' 
        Lsub.Location = New Point(25, 60)
        Lsub.Name = "Lsub"
        Lsub.Size = New Size(370, 45)
        Lsub.TabIndex = 1
        Lsub.Text = "Jl. Bengkuring Raya 1 No. 111, Samarinda" & vbCrLf & "Telp: (0541) 111-777"
        Lsub.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Ljudulstruk
        ' 
        Ljudulstruk.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        Ljudulstruk.Location = New Point(25, 15)
        Ljudulstruk.Name = "Ljudulstruk"
        Ljudulstruk.Size = New Size(370, 40)
        Ljudulstruk.TabIndex = 0
        Ljudulstruk.Text = "KEDAI SEHAT"
        Ljudulstruk.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Btutup
        ' 
        Btutup.BackColor = Color.Crimson
        Btutup.FlatStyle = FlatStyle.Flat
        Btutup.ForeColor = Color.White
        Btutup.Location = New Point(30, 560)
        Btutup.Name = "Btutup"
        Btutup.Size = New Size(420, 40)
        Btutup.TabIndex = 1
        Btutup.Text = "TUTUP STRUK"
        Btutup.UseVisualStyleBackColor = False
        ' 
        ' FormCetak
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(482, 620)
        Controls.Add(Btutup)
        Controls.Add(Pcetak)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormCetak"
        StartPosition = FormStartPosition.CenterParent
        Text = "Struk Pembayaran"
        Pcetak.ResumeLayout(False)
        Pcetak.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Pcetak As Panel
    Friend WithEvents Ljudulstruk As Label
    Friend WithEvents Lsub As Label
    Friend WithEvents Lnostruk As Label
    Friend WithEvents Lnama As Label
    Friend WithEvents Ljamu As Label
    Friend WithEvents Ljumlah As Label
    Friend WithEvents Lharga As Label
    Friend WithEvents Ltotal As Label
    Friend WithEvents Lterimakasih As Label
    Friend WithEvents Lgaris As Label
    Friend WithEvents Btutup As Button
End Class
