Module Module1

    'Declare array by size and type
    Dim Year As String

    Sub Main()
        Console.WriteLine("Please enter your Year")
        Year = Console.ReadLine()
        If IsNumeric(Year) = False Then
            Console.WriteLine("Year is not a number - please try again")
            Exit Sub
        End If
        Console.WriteLine("The year is " & Year)
    End Sub

End Module
