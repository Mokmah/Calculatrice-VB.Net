Public Class Calculatrice
    Private CalculEnCours As String = String.Empty
    Private CalculEffectue As String = String.Empty
    Private const Erreur As Int32 = -9999999

    ' Créer l'affichage du calcul en cours
    Public Sub NouveauCalculEnCours(ByVal NouveauCalcul As String)
        CalculEnCours = NouveauCalcul
    End Sub

    'Ajouter des nouvelles valeurs au calcul
    Public sub AjouterAuCalculEnCours(ByVal AddedValue As String)
        CalculEnCours += AddedValue
    End sub

    ' Lire le calcul en cours
    Public Function LireCalculEnCours() As String 
        Return CalculEnCours
    End Function

    ' Lire le calcul une fois complété
    Public Function LireCalculComplet() As String
        Return CalculEffectue
    End Function

    ' Faire le calcul et vérifier s'il a fonctionné
    Public Function EffectuerCalcul(ByVal Valeur1 As String, ByVal Valeur2 As String, ByVal Operation As String) As Boolean
        Dim PremierNombre As Int32
        Dim DeuxiemeNombre As Int32

        'Conversion en int
        Try
            PremierNombre = Int32.Parse(valeur1)
            DeuxiemeNombre  = Int32.Parse(valeur2)
        Catch ex As FormatException 
            MessageBox.Show("Les valeurs à utiliser sont incorrectes.", "Avertissement")
            Return False 
        End Try
        ' Faire le calcul avec l'opérateur
        Select Case Operation.ElementAt(0)
            Case "+"
                PremierNombre = Addition(PremierNombre, DeuxiemeNombre)
            Case "-"
                PremierNombre = Soustraction(PremierNombre, DeuxiemeNombre)
            Case "*"
                PremierNombre = Multiplication(PremierNombre, DeuxiemeNombre)
            Case "/"
                PremierNombre = Division(PremierNombre, DeuxiemeNombre)
                If (PremierNombre = Erreur) Then
                    MessageBox.Show("On ne peut pas faire de division par zéro !", "Avertissement")
                    CalculEffectue += " Erreur"
                    Return False 
                End If
            Case Else
                MessageBox.Show("Opération invalide !", "Avertissement")
        End Select
        Console.WriteLine(PremierNombre.ToString + " " + Operation + " " + DeuxiemeNombre.ToString)
        CalculEffectue = PremierNombre.ToString
        Return True 
    End Function

    #Region "Opérations"

    Private Function Addition(ByVal PremierNombre As Int32, ByVal DeuxiemeNombre As Int32) As Int32
        Return PremierNombre + DeuxiemeNombre
    End Function

    Private Function Soustraction(ByVal PremierNombre As Int32, ByVal DeuxiemeNombre As Int32) As Int32
        Return PremierNombre - DeuxiemeNombre
    End Function

    Private Function Multiplication(ByVal PremierNombre As Int32, ByVal DeuxiemeNombre As Int32) As Int32 
        Return PremierNombre * DeuxiemeNombre
    End Function

    Private Function Division(ByVal PremierNombre As Int32, ByVal DeuxiemeNombre As Int32) As Int32
        If DeuxiemeNombre = 0 Then 
            Return Erreur
        Else
            Return PremierNombre / DeuxiemeNombre
        End If
    End Function
    #End Region


End Class
