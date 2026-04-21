<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Phome = New Panel()
        Ljudul = New Label()
        GBsearch = New GroupBox()
        TBseacrh = New TextBox()
        Bseacrh = New Button()
        GBinput = New GroupBox()
        Lnamapembeli = New Label()
        TBnamapembeli = New TextBox()
        Ljamu = New Label()
        CBjamu = New ComboBox()
        Ljumlah = New Label()
        NUMjumlah = New NumericUpDown()
        Ltotal = New Label()
        TBtotal = New TextBox()
        Bsimpan = New Button()
        Bupdate = New Button()
        Bhapus = New Button()
        Bclear = New Button()
        DGVjamu = New DataGridView()
        Bcetak = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Phome.SuspendLayout()
        GBsearch.SuspendLayout()
        GBinput.SuspendLayout()
        CType(NUMjumlah, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVjamu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Phome
        ' 
        Phome.BackColor = Color.DarkSeaGreen
        Phome.Controls.Add(Ljudul)
        Phome.Controls.Add(GBsearch)
        Phome.Dock = DockStyle.Top
        Phome.Location = New Point(0, 0)
        Phome.Name = "Phome"
        Phome.Size = New Size(1082, 80)
        Phome.TabIndex = 0
        ' 
        ' Ljudul
        ' 
        Ljudul.AutoSize = True
        Ljudul.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Ljudul.ForeColor = Color.White
        Ljudul.Location = New Point(21, 18)
        Ljudul.Name = "Ljudul"
        Ljudul.Size = New Size(454, 41)
        Ljudul.TabIndex = 0
        Ljudul.Text = "KEDAI SEHAT - MANAGEMENT"
        ' 
        ' GBsearch
        ' 
        GBsearch.Controls.Add(TBseacrh)
        GBsearch.Controls.Add(Bseacrh)
        GBsearch.ForeColor = Color.White
        GBsearch.Location = New Point(735, 12)
        GBsearch.Name = "GBsearch"
        GBsearch.Size = New Size(326, 56)
        GBsearch.TabIndex = 1
        GBsearch.TabStop = False
        GBsearch.Text = "Cari Nama Pembeli"
        ' 
        ' TBseacrh
        ' 
        TBseacrh.Location = New Point(15, 21)
        TBseacrh.Name = "TBseacrh"
        TBseacrh.Size = New Size(214, 27)
        TBseacrh.TabIndex = 0
        ' 
        ' Bseacrh
        ' 
        Bseacrh.BackColor = Color.SeaGreen
        Bseacrh.FlatStyle = FlatStyle.Flat
        Bseacrh.Location = New Point(235, 20)
        Bseacrh.Name = "Bseacrh"
        Bseacrh.Size = New Size(75, 29)
        Bseacrh.TabIndex = 1
        Bseacrh.Text = "Cari"
        Bseacrh.UseVisualStyleBackColor = False
        ' 
        ' GBinput
        ' 
        GBinput.Controls.Add(Lnamapembeli)
        GBinput.Controls.Add(TBnamapembeli)
        GBinput.Controls.Add(Ljamu)
        GBinput.Controls.Add(CBjamu)
        GBinput.Controls.Add(Ljumlah)
        GBinput.Controls.Add(NUMjumlah)
        GBinput.Controls.Add(Ltotal)
        GBinput.Controls.Add(TBtotal)
        GBinput.Controls.Add(Bsimpan)
        GBinput.Controls.Add(Bupdate)
        GBinput.Controls.Add(Bhapus)
        GBinput.Controls.Add(Bclear)
        GBinput.Location = New Point(21, 100)
        GBinput.Name = "GBinput"
        GBinput.Size = New Size(320, 500)
        GBinput.TabIndex = 1
        GBinput.TabStop = False
        GBinput.Text = "Input Pesanan Baru"
        ' 
        ' Lnamapembeli
        ' 
        Lnamapembeli.Location = New Point(15, 30)
        Lnamapembeli.Name = "Lnamapembeli"
        Lnamapembeli.Size = New Size(100, 23)
        Lnamapembeli.TabIndex = 0
        Lnamapembeli.Text = "Nama Pembeli"
        ' 
        ' TBnamapembeli
        ' 
        TBnamapembeli.Location = New Point(15, 55)
        TBnamapembeli.Name = "TBnamapembeli"
        TBnamapembeli.Size = New Size(280, 27)
        TBnamapembeli.TabIndex = 1
        ' 
        ' Ljamu
        ' 
        Ljamu.Location = New Point(15, 100)
        Ljamu.Name = "Ljamu"
        Ljamu.Size = New Size(100, 23)
        Ljamu.TabIndex = 2
        Ljamu.Text = "Pilih Jamu"
        ' 
        ' CBjamu
        ' 
        CBjamu.DropDownStyle = ComboBoxStyle.DropDownList
        CBjamu.Items.AddRange(New Object() {"Kunyit Asam", "Beras Kencur", "Temulawak", "Gula Asam", "Pahitan"})
        CBjamu.Location = New Point(15, 125)
        CBjamu.Name = "CBjamu"
        CBjamu.Size = New Size(280, 28)
        CBjamu.TabIndex = 3
        ' 
        ' Ljumlah
        ' 
        Ljumlah.Location = New Point(15, 175)
        Ljumlah.Name = "Ljumlah"
        Ljumlah.Size = New Size(100, 23)
        Ljumlah.TabIndex = 4
        Ljumlah.Text = "Jumlah (Gelas)"
        ' 
        ' NUMjumlah
        ' 
        NUMjumlah.Location = New Point(15, 200)
        NUMjumlah.Name = "NUMjumlah"
        NUMjumlah.Size = New Size(120, 27)
        NUMjumlah.TabIndex = 5
        ' 
        ' Ltotal
        ' 
        Ltotal.Location = New Point(15, 250)
        Ltotal.Name = "Ltotal"
        Ltotal.Size = New Size(100, 23)
        Ltotal.TabIndex = 6
        Ltotal.Text = "Total Harga"
        ' 
        ' TBtotal
        ' 
        TBtotal.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TBtotal.Location = New Point(15, 275)
        TBtotal.Name = "TBtotal"
        TBtotal.ReadOnly = True
        TBtotal.Size = New Size(280, 27)
        TBtotal.TabIndex = 7
        ' 
        ' Bsimpan
        ' 
        Bsimpan.BackColor = Color.MediumSeaGreen
        Bsimpan.ForeColor = Color.White
        Bsimpan.Location = New Point(15, 330)
        Bsimpan.Name = "Bsimpan"
        Bsimpan.Size = New Size(135, 40)
        Bsimpan.TabIndex = 8
        Bsimpan.Text = "SIMPAN"
        Bsimpan.UseVisualStyleBackColor = False
        ' 
        ' Bupdate
        ' 
        Bupdate.BackColor = Color.Yellow
        Bupdate.Location = New Point(160, 330)
        Bupdate.Name = "Bupdate"
        Bupdate.Size = New Size(135, 40)
        Bupdate.TabIndex = 9
        Bupdate.Text = "UPDATE"
        Bupdate.UseVisualStyleBackColor = False
        ' 
        ' Bhapus
        ' 
        Bhapus.BackColor = Color.HotPink
        Bhapus.ForeColor = Color.White
        Bhapus.Location = New Point(15, 380)
        Bhapus.Name = "Bhapus"
        Bhapus.Size = New Size(135, 40)
        Bhapus.TabIndex = 10
        Bhapus.Text = "HAPUS"
        Bhapus.UseVisualStyleBackColor = False
        ' 
        ' Bclear
        ' 
        Bclear.BackColor = Color.Silver
        Bclear.Location = New Point(160, 380)
        Bclear.Name = "Bclear"
        Bclear.Size = New Size(135, 40)
        Bclear.TabIndex = 11
        Bclear.Text = "CLEAR"
        Bclear.UseVisualStyleBackColor = False
        ' 
        ' DGVjamu
        ' 
        DGVjamu.AllowUserToAddRows = False
        DGVjamu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVjamu.BackgroundColor = Color.White
        DGVjamu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVjamu.Location = New Point(360, 109)
        DGVjamu.Name = "DGVjamu"
        DGVjamu.ReadOnly = True
        DGVjamu.RowHeadersWidth = 51
        DGVjamu.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVjamu.Size = New Size(701, 420)
        DGVjamu.TabIndex = 2
        ' 
        ' Bcetak
        ' 
        Bcetak.BackColor = Color.RoyalBlue
        Bcetak.FlatStyle = FlatStyle.Flat
        Bcetak.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Bcetak.ForeColor = Color.White
        Bcetak.Location = New Point(360, 540)
        Bcetak.Name = "Bcetak"
        Bcetak.Size = New Size(701, 60)
        Bcetak.TabIndex = 3
        Bcetak.Text = "LIHAT DETAIL && CETAK STRUK"
        Bcetak.UseVisualStyleBackColor = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' FormHome
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1082, 630)
        Controls.Add(Bcetak)
        Controls.Add(DGVjamu)
        Controls.Add(GBinput)
        Controls.Add(Phome)
        Name = "FormHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "KedaiSehat - Menu"
        Phome.ResumeLayout(False)
        Phome.PerformLayout()
        GBsearch.ResumeLayout(False)
        GBsearch.PerformLayout()
        GBinput.ResumeLayout(False)
        GBinput.PerformLayout()
        CType(NUMjumlah, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVjamu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Phome As Panel
    Friend WithEvents Ljudul As Label
    Friend WithEvents GBsearch As GroupBox
    Friend WithEvents TBseacrh As TextBox
    Friend WithEvents Bseacrh As Button
    Friend WithEvents GBinput As GroupBox
    Friend WithEvents Lnamapembeli, Ljamu, Ljumlah, Ltotal As Label
    Friend WithEvents TBnamapembeli, TBtotal As TextBox
    Friend WithEvents CBjamu As ComboBox
    Friend WithEvents NUMjumlah As NumericUpDown
    Friend WithEvents Bsimpan, Bupdate, Bhapus, Bclear As Button
    Friend WithEvents DGVjamu As DataGridView
    Friend WithEvents Bcetak As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class