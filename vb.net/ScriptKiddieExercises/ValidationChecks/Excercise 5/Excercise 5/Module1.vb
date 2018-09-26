Module Module1

    'Declare array by size and type
    Dim Month As String

    Sub Main()
        Console.WriteLine("Please enter Month")
        Month = Console.ReadLine()
        If IsNumeric(Month) = True Then
            Console.WriteLine("Month is not a string - please try again")
            Exit Sub
        End If
        Console.WriteLine("Month is " & Month)
    End Sub

End Module
