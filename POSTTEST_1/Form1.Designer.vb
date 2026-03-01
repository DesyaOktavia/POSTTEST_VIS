<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        TBipk = New TextBox()
        Btambah = New Button()
        Breset = New Button()
        Lsumipk = New Label()
        Lpredikat = New Label()
        Riwayat_Perkuliahan = New ListBox()
        SuspendLayout()
        ' 
        ' TBipk
        ' 
        TBipk.Location = New Point(165, 87)
        TBipk.Name = "TBipk"
        TBipk.Size = New Size(139, 27)
        TBipk.TabIndex = 0
        ' 
        ' Btambah
        ' 
        Btambah.BackColor = Color.Aquamarine
        Btambah.FlatStyle = FlatStyle.Popup
        Btambah.Location = New Point(95, 138)
        Btambah.Name = "Btambah"
        Btambah.Size = New Size(124, 29)
        Btambah.TabIndex = 1
        Btambah.Text = "Tambah"
        Btambah.UseVisualStyleBackColor = False
        ' 
        ' Breset
        ' 
        Breset.BackColor = Color.LightCoral
        Breset.FlatStyle = FlatStyle.Popup
        Breset.Location = New Point(245, 138)
        Breset.Name = "Breset"
        Breset.Size = New Size(124, 29)
        Breset.TabIndex = 2
        Breset.Text = "Reset"
        Breset.UseVisualStyleBackColor = False
        ' 
        ' Lsumipk
        ' 
        Lsumipk.BackColor = SystemColors.Window
        Lsumipk.FlatStyle = FlatStyle.Popup
        Lsumipk.Font = New Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lsumipk.ForeColor = Color.Indigo
        Lsumipk.Location = New Point(513, 77)
        Lsumipk.Name = "Lsumipk"
        Lsumipk.Size = New Size(147, 90)
        Lsumipk.TabIndex = 3
        Lsumipk.Text = "0.00"
        Lsumipk.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lpredikat
        ' 
        Lpredikat.ForeColor = SystemColors.ControlLightLight
        Lpredikat.Location = New Point(513, 184)
        Lpredikat.Name = "Lpredikat"
        Lpredikat.Size = New Size(147, 30)
        Lpredikat.TabIndex = 4
        Lpredikat.Text = "Predikat"
        Lpredikat.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Riwayat_Perkuliahan
        ' 
        Riwayat_Perkuliahan.Font = New Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Riwayat_Perkuliahan.FormattingEnabled = True
        Riwayat_Perkuliahan.Location = New Point(120, 266)
        Riwayat_Perkuliahan.Name = "Riwayat_Perkuliahan"
        Riwayat_Perkuliahan.Size = New Size(505, 157)
        Riwayat_Perkuliahan.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SlateBlue
        ClientSize = New Size(800, 450)
        Controls.Add(Riwayat_Perkuliahan)
        Controls.Add(Lpredikat)
        Controls.Add(Lsumipk)
        Controls.Add(Breset)
        Controls.Add(Btambah)
        Controls.Add(TBipk)
        ForeColor = SystemColors.ControlText
        Name = "Form1"
        Text = "IPK Perkuliahan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TBipk As TextBox
    Friend WithEvents Btambah As Button
    Friend WithEvents Breset As Button
    Friend WithEvents Lsumipk As Label
    Friend WithEvents Lpredikat As Label
    Friend WithEvents Riwayat_Perkuliahan As ListBox
    Friend WithEvents Label2 As Label

End Class
