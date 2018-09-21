Module Module1

    'Declare Global Variables
    Dim MagicNumber As Integer = 4
    Dim Number As Integer = 4
    'Main procedure
    Sub Main()

        'Input MagicNumber
        Console.WriteLine("Enter MagicNumber")
        Number = Console.ReadLine()

        While Number <> MagicNumber
            'Input Number
            Console.WriteLine("Not the Magic Number")
            Console.WriteLine("Enter MagicNumber")
            Number = Console.ReadLine()
        End While
        Console.WriteLine("Congratulations you have guessed the magic number")
    End Sub

End Module