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
                historique.Operation(PremierNombre & " " & Operateur & " " & DeuxiemeNombre & " = " & Resultat)
                historyTextBox.AppendText(PremierNombre & " " & Operateur & " " & DeuxiemeNombre & " = " & Resultat & Environment.NewLine)
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

    #Region "Events"
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        PremierNombre = ""
        DeuxiemeNombre = ""
        Resultat = ""
        Operateur = ""
        Nombre = ""
        CalculActuel = ""
        UpdateText("")
    End Sub

    Private Sub clearEntryButton_Click(sender As Object, e As EventArgs) Handles clearEntryButton.Click
        Nombre = ""
        UpdateText("")
    End Sub

    Private Sub backspaceButton_Click(sender As Object, e As EventArgs) Handles backspaceButton.Click
        If (Nombre.Length>0) Then
            Nombre = Nombre.Substring(0,Nombre.Length-1)
            UpdateText("")
        End If
    End Sub

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        UpdateOperator("+")
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        UpdateOperator("-")
    End Sub

    Private Sub multiplyButton_Click(sender As Object, e As EventArgs) Handles multiplyButton.Click
        UpdateOperator("*")
    End Sub

    Private Sub divideButton_Click(sender As Object, e As EventArgs) Handles divideButton.Click
        UpdateOperator("/")
    End Sub

    Private Sub nineButton_Click(sender As Object, e As EventArgs) Handles nineButton.Click
        UpdateText("9")
    End Sub

    Private Sub eightButton_Click(sender As Object, e As EventArgs) Handles eightButton.Click
        UpdateText("8")
    End Sub

    Private Sub sevenButton_Click(sender As Object, e As EventArgs) Handles sevenButton.Click
        UpdateText("7")
    End Sub

    Private Sub sixButton_Click(sender As Object, e As EventArgs) Handles sixButton.Click
        UpdateText("6")
    End Sub

    Private Sub fiveButton_Click(sender As Object, e As EventArgs) Handles fiveButton.Click
        UpdateText("5")
    End Sub

    Private Sub fourButton_Click(sender As Object, e As EventArgs) Handles fourButton.Click
        UpdateText("4")
    End Sub

    Private Sub threeButton_Click(sender As Object, e As EventArgs) Handles threeButton.Click
        UpdateText("3")
    End Sub

    Private Sub twoButton_Click(sender As Object, e As EventArgs) Handles twoButton.Click
        UpdateText("2")
    End Sub

    Private Sub oneButton_Click(sender As Object, e As EventArgs) Handles oneButton.Click
        UpdateText("1")
    End Sub

    Private Sub zeroButton_Click(sender As Object, e As EventArgs) Handles zeroButton.Click
        UpdateText("0")
    End Sub

    Private Sub equalButton_Click(sender As Object, e As EventArgs) Handles equalButton.Click
        Calculer()
    End Sub

    Private Sub saveHistoryButton_Click(sender As Object, e As EventArgs) Handles saveHistoryButton.Click
        historique.SauvegarderOperations()
    End Sub

#End Region

End Class
