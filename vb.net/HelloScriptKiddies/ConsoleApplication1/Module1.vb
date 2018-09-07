Module Module1

    Sub Main()

        'ScriptEngine Kiddie input your name
        Dim YourName As String
        Dim StatusDate As String
        StatusDate = InputBox("Your are a script kiddie for viewing this, input your name")
        If StatusDate = " " Then
            MessageBox.Show("Null")

        ElseIf StatusDate = "" Then

        End If

        'declare script kiddie text as string
        Dim FirstName As String = " Script"
        Dim LastName As String = " Kiddie"


        For i As Integer = 0 To 100000000
            'print script kiddie text
            Console.WriteLine("Hello " + StatusDate + " is a " + FirstName + LastName + ": " + Str(100 / 2) + " Iterating: " + Str(i))
        Next
    End Sub

    Private Function MessageBox() As Object
        Throw New NotImplementedException
    End Function

End Module
