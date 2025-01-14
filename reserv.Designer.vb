<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reserv
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtName = New TextBox()
        cbDispo = New ComboBox()
        btnReserver = New Button()
        txtEmail = New TextBox()
        txtTel = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(187, 129)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 0
        ' 
        ' cbDispo
        ' 
        cbDispo.FormattingEnabled = True
        cbDispo.Items.AddRange(New Object() {"12/2/2025 france", "12/5/2025italie", "1//03/2025"})
        cbDispo.Location = New Point(326, 198)
        cbDispo.Name = "cbDispo"
        cbDispo.Size = New Size(151, 28)
        cbDispo.TabIndex = 2
        ' 
        ' btnReserver
        ' 
        btnReserver.BackColor = SystemColors.Highlight
        btnReserver.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReserver.Location = New Point(207, 288)
        btnReserver.Name = "btnReserver"
        btnReserver.Size = New Size(406, 44)
        btnReserver.TabIndex = 3
        btnReserver.Text = "reserver"
        btnReserver.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(578, 130)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 4
        ' 
        ' txtTel
        ' 
        txtTel.Location = New Point(371, 129)
        txtTel.Name = "txtTel"
        txtTel.Size = New Size(125, 27)
        txtTel.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Highlight
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(34, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 26)
        Label1.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Highlight
        Label2.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(167, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 26)
        Label2.TabIndex = 7
        Label2.Text = "Places Dispo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Highlight
        Label3.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(502, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 26)
        Label3.TabIndex = 8
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Highlight
        Label4.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(318, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 26)
        Label4.TabIndex = 9
        Label4.Text = "Tel"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Highlight
        Label5.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(116, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 26)
        Label5.TabIndex = 10
        Label5.Text = "Name"
        ' 
        ' reserv
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.v31
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTel)
        Controls.Add(txtEmail)
        Controls.Add(btnReserver)
        Controls.Add(cbDispo)
        Controls.Add(txtName)
        Name = "reserv"
        Text = "reserv"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents cbDispo As ComboBox
    Friend WithEvents btnReserver As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
