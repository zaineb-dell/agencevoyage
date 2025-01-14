<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class agence
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agence))
        txtUserName = New TextBox()
        cbRole = New ComboBox()
        btnLogin = New Button()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtUserName
        ' 
        txtUserName.BackColor = SystemColors.ControlLightLight
        txtUserName.Location = New Point(245, 114)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(125, 27)
        txtUserName.TabIndex = 0
        ' 
        ' cbRole
        ' 
        cbRole.BackColor = SystemColors.ControlLightLight
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"Utilisateur", "Admin"})
        cbRole.Location = New Point(345, 199)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(151, 28)
        cbRole.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.HotTrack
        btnLogin.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(166, 285)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(489, 41)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = SystemColors.ControlLightLight
        txtPassword.Location = New Point(515, 115)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(125, 27)
        txtPassword.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(125, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 26)
        Label1.TabIndex = 4
        Label1.Text = "UserName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(266, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 26)
        Label2.TabIndex = 5
        Label2.Text = "Role"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Highlight
        Label3.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(387, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 26)
        Label3.TabIndex = 6
        Label3.Text = "Password"
        ' 
        ' agence
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(btnLogin)
        Controls.Add(cbRole)
        Controls.Add(txtUserName)
        Name = "agence"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
