Module Module1

    'Declare global variables

    Dim FirstName As String

    Sub Main()
        Console.WriteLine("Enter your first name")
        FirstName = Console.ReadLine()
        While FirstName =
            ""
            Console.WriteLine("Please enter your first name")
            FirstName = Console.ReadLine()
        End While
        Console.WriteLine("You are " & FirstName)
    End Sub



End Module
















































































































