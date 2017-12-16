Imports System
Imports System.IO

Public Class FileSave
    Private const Path = "Operations.txt"

    ' Sauvegarder un tableau de string qui contient l'historique des opérations

    Public Shared Sub Sauvegarder(ByVal Operation() As String)
        Dim Stream As StreamWriter = New StreamWriter(Path)
        ' Créer un string à partir du tableau des opérations
        For Each Op As String In Operation
            Stream.Write(Op & Environment.NewLine)
        Next
        MessageBox.Show("Enregistrement effectué !")
        Stream.Close()
    End Sub
End Class
