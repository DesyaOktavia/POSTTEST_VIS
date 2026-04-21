<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        components = New ComponentModel.Container()
        Plogin = New Panel()
        Bkeluar = New Button()
        Blogin = New Button()
        TBpassword = New TextBox()
        TBusername = New TextBox()
        Lpassword = New Label()
        Lusername = New Label()
        Lkedai = New Label()
        Ljamu = New Label()
        EPlogin = New ErrorProvider(components)
        PBlogin = New PictureBox()
        Plogin.SuspendLayout()
        CType(EPlogin, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBlogin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Plogin
        ' 
        Plogin.BackColor = Color.YellowGreen
        Plogin.Controls.Add(Bkeluar)
        Plogin.Controls.Add(Blogin)
        Plogin.Controls.Add(TBpassword)
        Plogin.Controls.Add(TBusername)
        Plogin.Controls.Add(Lpassword)
        Plogin.Controls.Add(Lusername)
        Plogin.Location = New Point(0, 228)
        Plogin.Name = "Plogin"
        Plogin.Size = New Size(565, 249)
        Plogin.TabIndex = 0
        ' 
        ' Bkeluar
        ' 
        Bkeluar.BackColor = Color.Salmon
        Bkeluar.Location = New Point(316, 173)
        Bkeluar.Name = "Bkeluar"
        Bkeluar.Size = New Size(119, 45)
        Bkeluar.TabIndex = 8
        Bkeluar.Text = "Keluar"
        Bkeluar.UseVisualStyleBackColor = False
        ' 
        ' Blogin
        ' 
        Blogin.BackColor = Color.MediumSpringGreen
        Blogin.Location = New Point(117, 174)
        Blogin.Name = "Blogin"
        Blogin.Size = New Size(119, 45)
        Blogin.TabIndex = 7
        Blogin.Text = "Login"
        Blogin.UseVisualStyleBackColor = False
        ' 
        ' TBpassword
        ' 
        TBpassword.Location = New Point(211, 89)
        TBpassword.Name = "TBpassword"
        TBpassword.Size = New Size(258, 27)
        TBpassword.TabIndex = 6
        ' 
        ' TBusername
        ' 
        TBusername.Location = New Point(211, 16)
        TBusername.Name = "TBusername"
        TBusername.Size = New Size(258, 27)
        TBusername.TabIndex = 5
        ' 
        ' Lpassword
        ' 
        Lpassword.AutoSize = True
        Lpassword.Font = New Font("Segoe UI", 12.0F)
        Lpassword.Location = New Point(38, 78)
        Lpassword.Name = "Lpassword"
        Lpassword.Size = New Size(93, 28)
        Lpassword.TabIndex = 4
        Lpassword.Text = "Password"
        ' 
        ' Lusername
        ' 
        Lusername.AutoSize = True
        Lusername.Font = New Font("Segoe UI", 12.0F)
        Lusername.Location = New Point(39, 12)
        Lusername.Name = "Lusername"
        Lusername.Size = New Size(99, 28)
        Lusername.TabIndex = 3
        Lusername.Text = "Username"
        ' 
        ' Lkedai
        ' 
        Lkedai.AutoSize = True
        Lkedai.Font = New Font("Segoe UI", 24.0F)
        Lkedai.Location = New Point(239, 58)
        Lkedai.Name = "Lkedai"
        Lkedai.Size = New Size(230, 54)
        Lkedai.TabIndex = 1
        Lkedai.Text = "Kedai Sehat"
        ' 
        ' Ljamu
        ' 
        Ljamu.AutoSize = True
        Ljamu.Font = New Font("Segoe UI", 20.0F)
        Ljamu.Location = New Point(355, 120)
        Ljamu.Name = "Ljamu"
        Ljamu.Size = New Size(152, 46)
        Ljamu.TabIndex = 2
        Ljamu.Text = "Jamoean"
        ' 
        ' EPlogin
        ' 
        EPlogin.ContainerControl = Me
        ' 
        ' PBlogin
        ' 
        PBlogin.Image = My.Resources.Resources.jamoean
        PBlogin.Location = New Point(39, 23)
        PBlogin.Name = "PBlogin"
        PBlogin.Size = New Size(171, 181)
        PBlogin.SizeMode = PictureBoxSizeMode.StretchImage
        PBlogin.TabIndex = 3
        PBlogin.TabStop = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Peru
        ClientSize = New Size(560, 458)
        Controls.Add(PBlogin)
        Controls.Add(Ljamu)
        Controls.Add(Lkedai)
        Controls.Add(Plogin)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "FormLogin"
        Text = "KedaiSehat - Menu"
        Plogin.ResumeLayout(False)
        Plogin.PerformLayout()
        CType(EPlogin, ComponentModel.ISupportInitialize).EndInit()
        CType(PBlogin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Plogin As Panel
    Friend WithEvents Lpassword As Label
    Friend WithEvents Lusername As Label
    Friend WithEvents Lkedai As Label
    Friend WithEvents Ljamu As Label
    Friend WithEvents TBpassword As TextBox
    Friend WithEvents TBusername As TextBox
    Friend WithEvents Bkeluar As Button
    Friend WithEvents Blogin As Button
    Friend WithEvents EPlogin As ErrorProvider
    Friend WithEvents PBlogin As PictureBox

End Class
