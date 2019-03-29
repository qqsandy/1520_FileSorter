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

        ' This while loop will at for the reader and the if loop will be the limit for names imported at 100. (expands descrip.)
        While (Not (fileReader.EndOfStream))
            If (namesLstBox.Items.Count >= 100) Then
                names = fileReader.ReadLine()
                namesLstBox.Items.Remove(Name)
            ElseIf (namesLstBox.Items.Count <= 100) Then
                names = fileReader.ReadLine()
                namesLstBox.Items.Add(names)
                counter += 1
            End If
        End While


        ' MAYBE CHANGE THIS? ERROR POPS UP BEFORE COUNTER IS REFRESHED
        If (namesLstBox.Items.Count = 100) Then
            MsgBox("ERROR: You're now at the maximum capacity of names at 100.")
        End If

        ' extra work: to display the name counter
        contentAmountLbl.Text = "Content Amount: " & counter

    End Sub

    Private Sub ascendingBtn_Click(sender As Object, e As EventArgs) Handles ascendingBtn.Click

        Dim names As New List(Of String)

        'get the names from the list box to List
        For Each item In namesLstBox.Items
            names.Add(item.ToString())
        Next
        Dim swap As Boolean = True


        'This while loop will repeat the process untill all swaps are finished.
        While swap = True
            swap = False

            'sort the list into ascending order
            For i As Integer = 0 To names.Count - 2
                If names(i) > names(i + 1) Then
                    Dim temp As String = names(i + 1)
                    names(i + 1) = names(i)
                    names(i) = temp
                    swap = True
                End If
            Next
        End While

        'bind the lsit to the listbox
        sortedLstBox.DataSource = names

    End Sub
End Class