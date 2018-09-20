Module Module1

    'Declare Global Variables
    Dim Count As Single = 0
    Dim Number As Single = 0
    Dim Total As Single = 0

    'Main procedure
    Sub Main()

        'Input Count
        Console.WriteLine("Enter Count")
        Count = Console.ReadLine()

        'Iterate Count
        For i As Integer = 0 To Count - 1
            'Input Number
            Console.WriteLine("Enter Number")
            Number = Console.ReadLine()

            'Add number to total
            Total = Total + Number
        Next

        'Display Total after executing loop
        Console.WriteLine("The Total is " & Str(Total))
    End Sub

End Module