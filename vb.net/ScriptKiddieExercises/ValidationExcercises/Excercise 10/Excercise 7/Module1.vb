Module Module1

    Dim score As Integer
    Dim result As String

    Sub Main()

        Console.WriteLine("Please enter score ")
        score = Console.ReadLine()

        Do While score >= 10


            score = Console.ReadLine()
            If score > 100 Then
                result = "Great score"
            ElseIf score <= 100 And score >= 50 Then
                result = "OK score"
            ElseIf score < 50 Then
                result = "Poor score"
            End If
        Loop

        Console.WriteLine("Score: " & score & result)
        Console.WriteLine("Game Stops")

    End Sub

End Module