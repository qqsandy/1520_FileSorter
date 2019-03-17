Public Class Sorter
    ' potentially add to sort by last name (if statement - boolean last name is valid)
    ' 
    Dim counter As Integer = 0
    Dim fileReader As System.IO.StreamReader
    Dim names As String

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        ' This subroutine allows for the function of the exitBtn when activated or clicked to close the program.
        Me.Close()
    End Sub

    Private Sub readNamesBtn_Click(sender As Object, e As EventArgs) Handles readNamesBtn.Click

        fileReader = My.Computer.FileSystem.OpenTextFileReader("names.txt")

        While (Not (fileReader.EndOfStream))
            names = fileReader.ReadLine()
            namesLstBox.Items.Add(names)
            counter += 1
        End While

        contentAmountLbl.Text = "Content Amount: " & counter

    End Sub
End Class