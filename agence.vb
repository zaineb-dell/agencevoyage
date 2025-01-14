Public Class agence
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUserName.Text
        Dim password As String = txtPassword.Text
        Dim role As String = cbRole.SelectedItem


        If username = "" Or password = "" Or role = "" Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If username = "admin" And password = "1234" And role = "Admin" Then
            MessageBox.Show("Connexion réussie en tant qu'Admin.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Dim adminForm As New admin()
            adminForm.Show()
            Me.Hide()

        ElseIf username = "user" And password = "1234" And role = "Utilisateur" Then
            MessageBox.Show("Connexion réussie en tant qu'Utilisateur.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Dim utilisateurForm As New reserv()
            utilisateurForm.Show()
            Me.Hide()

        Else

            MessageBox.Show("Identifiants ou rôle incorrects.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
