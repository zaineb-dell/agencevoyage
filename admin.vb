Public Class admin
    Public Class Vol
        Public Property Numero As Integer
        Public Property Destination As String
        Public Property DateHeure As DateTime
        Public Property PlacesDispo As Integer
        Public Property Prix As Decimal
    End Class
    Private vols(99) As Vol
    Private nbVols As Integer = 0

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

        Dim nouveauVol As New Vol()
        nouveauVol.Numero = Integer.Parse(txtNumVol.Text)
        nouveauVol.Destination = txtDestination.Text
        nouveauVol.DateHeure = txtDate.Text
        nouveauVol.PlacesDispo = Integer.Parse(txtPlaces.Text)
        nouveauVol.Prix = Decimal.Parse(txtPrix.Text)


        vols(nbVols) = nouveauVol
        nbVols += 1


        AfficherVols()
        MessageBox.Show("Vol ajouté avec succès.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AfficherVols()

        dgvVols.Rows.Clear()
        For i As Integer = 0 To nbVols - 1
            dgvVols.Rows.Add(vols(i).Numero, vols(i).Destination, vols(i).DateHeure, vols(i).PlacesDispo, vols(i).Prix)
        Next
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Dim numero As Integer = Integer.Parse(txtNumVol.Text)
        Dim index As Integer = -1

        For i As Integer = 0 To nbVols - 1
            If vols(i).Numero = numero Then
                index = i
                Exit For
            End If
        Next

        If index = -1 Then
            MessageBox.Show("Vol introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        vols(index).Destination = txtDestination.Text
        vols(index).DateHeure = txtDate.Text
        vols(index).PlacesDispo = Integer.Parse(txtPlaces.Text)
        vols(index).Prix = Decimal.Parse(txtPrix.Text)

        MessageBox.Show("Vol modifié avec succès.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        Dim numero As Integer = Integer.Parse(txtNumVol.Text)
        Dim index As Integer = -1

        For i As Integer = 0 To nbVols - 1
            If vols(i).Numero = numero Then
                index = i
                Exit For
            End If
        Next

        If index = -1 Then
            MessageBox.Show("Vol introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        For i As Integer = index To nbVols - 2
            vols(i) = vols(i + 1)
        Next
        nbVols -= 1

        MessageBox.Show("Vol supprimé avec succès.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class