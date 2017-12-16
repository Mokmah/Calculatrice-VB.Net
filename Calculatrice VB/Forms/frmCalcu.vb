Public Class frmCalculatrice
    Private calculatrice As New Calculatrice
    Private historique As New Historique

    ' Pour recevoir les entrées du formulaire
    Private PremierNombre As String = ""
    Private DeuxiemeNombre As String = ""
    Private Resultat As String = ""
    Private Operateur As Char

    ' Pour formatter les sorties au formulaire
    Private Nombre As String = ""
    Private CalculActuel As String = ""

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        PremierNombre = ""
        DeuxiemeNombre = ""
        Resultat = ""
        Operateur = ""
        Nombre = ""
        CalculActuel = ""
        UpdateText("")
    End Sub

    #Region "Méthodes"
    Private Sub UpdateText(ByVal num As String)
        If (Resultat.Length > 0) Then ' Pour enlever le nombre actuel
            Nombre = ""
            Resultat = ""
        End If
        Nombre += num
        calculationTextBox.Text = ""
        calculationTextBox.AppendText(Nombre &Environment.NewLine &CalculActuel)
    End Sub

    Private Sub UpdateOperator(ByVal op As String)
        If (CalculActuel.Length>0) Then
            If (Nombre.Length>0) Then
                Calculer()
                PremierNombre = Resultat
            End If
            Operateur = op
            CalculActuel = PremierNombre & " " & Operateur
            UpdateText("")
        Else If (Nombre.Length>0) Then
            PremierNombre = Nombre
            Nombre = ""
            Operateur = op
            CalculActuel = Nombre & " " & Operateur
            UpdateText("")
        End If
    End Sub

    Private Sub Calculer()
        If (CalculActuel.Length>0)
            DeuxiemeNombre = Nombre
            Nombre = ""
            If (calculatrice.EffectuerCalcul(PremierNombre,DeuxiemeNombre,Operateur)) Then
                Resultat = calculatrice.LireCalculComplet
                historique.Operation(PremierNombre & " " & Operateur & " " & DeuxiemeNombre & " = " & Resultat & Environment.NewLine)
                PremierNombre = ""
                DeuxiemeNombre = ""
                Operateur = ""
                CalculActuel = ""
                calculationTextBox.Text = Resultat
                Nombre = Resultat
            Else
                calculationTextBox.Text = PremierNombre
                Nombre = PremierNombre
                PremierNombre = ""
                CalculActuel = ""
                Operateur = ""
            End If
        End If
    End Sub
#End Region
End Class
