<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Lusername = New Label()
        Lpassword = New Label()
        PBlogin = New PictureBox()
        TBusername = New TextBox()
        TBpassword = New TextBox()
        Blogin = New Button()
        Bkeluar = New Button()
        Plogin = New Panel()
        Lkedai = New Label()
        Ljamu = New Label()
        EPlogin = New ErrorProvider(components)
        CType(PBlogin, ComponentModel.ISupportInitialize).BeginInit()
        Plogin.SuspendLayout()
        CType(EPlogin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Lusername
        ' 
        Lusername.AutoSize = True
        Lusername.BackColor = Color.YellowGreen
        Lusername.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lusername.Location = New Point(39, 12)
        Lusername.Name = "Lusername"
        Lusername.Size = New Size(99, 28)
        Lusername.TabIndex = 0
        Lusername.Text = "Username"
        ' 
        ' Lpassword
        ' 
        Lpassword.AutoSize = True
        Lpassword.BackColor = Color.YellowGreen
        Lpassword.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lpassword.Location = New Point(39, 78)
        Lpassword.Name = "Lpassword"
        Lpassword.Size = New Size(93, 28)
        Lpassword.TabIndex = 1
        Lpassword.Text = "Password"
        ' 
        ' PBlogin
        ' 
        PBlogin.Image = My.Resources.Resources.jamoean1
        PBlogin.Location = New Point(39, 23)
        PBlogin.Name = "PBlogin"
        PBlogin.Size = New Size(171, 181)
        PBlogin.SizeMode = PictureBoxSizeMode.StretchImage
        PBlogin.TabIndex = 2
        PBlogin.TabStop = False
        ' 
        ' TBusername
        ' 
        TBusername.Location = New Point(211, 16)
        TBusername.Name = "TBusername"
        TBusername.Size = New Size(258, 27)
        TBusername.TabIndex = 3
        ' 
        ' TBpassword
        ' 
        TBpassword.Location = New Point(211, 82)
        TBpassword.Name = "TBpassword"
        TBpassword.Size = New Size(258, 27)
        TBpassword.TabIndex = 4
        ' 
        ' Blogin
        ' 
        Blogin.BackColor = Color.MediumSpringGreen
        Blogin.Location = New Point(117, 174)
        Blogin.Name = "Blogin"
        Blogin.Size = New Size(119, 45)
        Blogin.TabIndex = 5
        Blogin.Text = "Login"
        Blogin.UseVisualStyleBackColor = False
        ' 
        ' Bkeluar
        ' 
        Bkeluar.BackColor = Color.Salmon
        Bkeluar.Location = New Point(316, 173)
        Bkeluar.Name = "Bkeluar"
        Bkeluar.Size = New Size(119, 45)
        Bkeluar.TabIndex = 6
        Bkeluar.Text = "Keluar"
        Bkeluar.UseVisualStyleBackColor = False
        ' 
        ' Plogin
        ' 
        Plogin.BackColor = Color.YellowGreen
        Plogin.Controls.Add(Bkeluar)
        Plogin.Controls.Add(TBpassword)
        Plogin.Controls.Add(Blogin)
        Plogin.Controls.Add(TBusername)
        Plogin.Controls.Add(Lusername)
        Plogin.Controls.Add(Lpassword)
        Plogin.Location = New Point(0, 228)
        Plogin.Name = "Plogin"
        Plogin.Size = New Size(567, 284)
        Plogin.TabIndex = 7
        ' 
        ' Lkedai
        ' 
        Lkedai.AutoSize = True
        Lkedai.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lkedai.Location = New Point(239, 58)
        Lkedai.Name = "Lkedai"
        Lkedai.Size = New Size(230, 54)
        Lkedai.TabIndex = 8
        Lkedai.Text = "Kedai Sehat"
        ' 
        ' Ljamu
        ' 
        Ljamu.AutoSize = True
        Ljamu.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Ljamu.Location = New Point(355, 120)
        Ljamu.Name = "Ljamu"
        Ljamu.Size = New Size(152, 46)
        Ljamu.TabIndex = 9
        Ljamu.Text = "Jamoean"
        ' 
        ' EPlogin
        ' 
        EPlogin.ContainerControl = Me
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Peru
        ClientSize = New Size(560, 458)
        Controls.Add(Ljamu)
        Controls.Add(Lkedai)
        Controls.Add(PBlogin)
        Controls.Add(Plogin)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Login"
        Text = "KedaiSehat - Menu"
        CType(PBlogin, ComponentModel.ISupportInitialize).EndInit()
        Plogin.ResumeLayout(False)
        Plogin.PerformLayout()
        CType(EPlogin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Lpassword As Label
    Friend WithEvents Lusername As Label
    Friend WithEvents PBlogin As PictureBox
    Friend WithEvents Bkeluar As Button
    Friend WithEvents Blogin As Button
    Friend WithEvents TBpassword As TextBox
    Friend WithEvents TBusername As TextBox
    Friend WithEvents Plogin As Panel
    Friend WithEvents Ljamu As Label
    Friend WithEvents Lkedai As Label
    Friend WithEvents EPlogin As ErrorProvider

End Class
