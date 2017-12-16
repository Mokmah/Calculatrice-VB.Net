Public Class Historique
    Private Operations() as String

    'Ajouter une nouvelle opération au tableau d'opérations
    Public Sub Operation(ByVal Op As String)
        Try
            ReDim Preserve Operations(UBound(operations)+1) ' Refaire la grandeur du tableau
            Operations(Operations.Count -1) = Op ' Ajouter l'opération
        Catch ex As ArgumentNullException
            Operations = New String() {Op} ' Initialiser l'opération
        End Try
    End Sub

    'Sauvegarder toutes les opérations dans l'historique
    Public Sub SauvegarderOperations()
        FileSave.Sauvegarder(Operations)
    End Sub
End Class
