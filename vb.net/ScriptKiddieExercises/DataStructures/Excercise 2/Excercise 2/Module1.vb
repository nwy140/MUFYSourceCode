Module Module1

    'Declare array by size and type
    Dim Friends(12) As String

    'Declare other variables
    Dim number As Integer
    Dim output As String

    Sub Main()

        'Users input added as elements to array
        For i = 1 To 12
            Console.WriteLine("Enter Friends " & Str(i))
            Friends(i) = Console.ReadLine()
            output = UCase(output + Friends(i) + " ")

        Next
        Console.WriteLine("Guest List : " & output)

        For Each value As String In Friends
            Console.WriteLine(UCase(value))
        Next
        Console.WriteLine()


        Search()
    End Sub

    Sub Search()
        Console.WriteLine("Enter Friends Number")
        number = Console.ReadLine()

        Console.WriteLine(Friends(number))

    End Sub

End Module
