Module Module1

    'Declare array by size and type
    Dim email As String

    Sub Main()
        Console.WriteLine("Please enter email")
        email = Console.ReadLine()
        If email.Contains("@") = False Then
            Console.WriteLine("email does not contain @ symbol")
            Exit Sub
        End If
        Console.WriteLine("email is " & email)
    End Sub

End Module












