Module Module1

    'Declare array by size and type
    Dim password As String

    Sub Main()
        Console.WriteLine("Please enter your password")
        password = Console.ReadLine()
        If Len(password) < 8 Then
            Console.WriteLine("Password needs to be at least 8 characters")
            Return
        End If
        Console.WriteLine("Your password is " & password)
    End Sub

End Module
