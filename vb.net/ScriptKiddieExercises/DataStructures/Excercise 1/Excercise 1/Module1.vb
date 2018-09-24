Module Module1

    'Declare array by size and type
    Dim Animal(3) As String

    'Declare other variables
    Dim number As Integer
    Dim output As String

    Sub Main()

        'Users input added as elements to array
        For i = 1 To 3
            Console.WriteLine("Enter Animal " & Str(i))
            Animal(i) = Console.ReadLine()
            output = output + Animal(i) + " "

        Next
        Console.WriteLine(output)
        Console.WriteLine("")

        Search()
    End Sub

    Sub Search()
        Console.WriteLine("Enter Animal Number")
        number = Console.ReadLine()

        Console.WriteLine(Animal(number))

    End Sub

End Module
















































































































