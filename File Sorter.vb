Public Class Sorter
    ' potentially add to sort by last name (if statement - boolean last name is valid)
    ' 

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        ' This subroutine allows for the function of the exitBtn when activated or clicked to close the program.
        Me.Close()
    End Sub

    Private Sub readNamesBtn_Click(sender As Object, e As EventArgs) Handles readNamesBtn.Click
        Dim counter As Integer = 10
        Dim fileReader As System.IO.StreamReader
        'fileReader = My.Computer.FileSystem.OpenTextFileReader("names.txt")
        Dim names(100) As String
        'Do While counter <= 100
        Dim lineoftext As String
        fileReader = My.Computer.FileSystem.OpenTextFileReader("names.txt")

        While (Not (fileReader.EndOfStream))
            lineoftext = fileReader.ReadLine()
            namesLstBox.Items.Add(lineoftext)
            counter += 1
        End While


    End Sub
End Class