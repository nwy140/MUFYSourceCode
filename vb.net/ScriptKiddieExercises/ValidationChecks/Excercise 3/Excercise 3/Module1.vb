Module Module1

    'Declare array by size and type
    Dim Age As String

    Sub Main()
        Console.WriteLine("Please enter your Age")
        Age = Console.ReadLine()
        If (Age) < 18 Then
            Console.WriteLine("You must be 18 or over to access this site")
            Return
        End If
        Console.WriteLine("Welcome to the 18 or over site"
                          )
    End Sub

End Module
