Module Module1
    Sub Main()
        'Declare private variables
        Dim Hours As Decimal
        Dim Rate As Decimal
        Dim Total As Decimal

        'Print please enter hoursworked
        Console.WriteLine("Please input hours worked")
        'read input
        Hours = CDec(Console.ReadLine())

        'Print please enter Rate
        Console.WriteLine("Please enter Rate")
        'read input
        Rate = CDec(Console.ReadLine())

        'Calling display
        Total = Calculate(Hours, Rate)

        'Format printed Total by 2 dp
        Console.WriteLine("The total is " & Format(Total, "0.00"))

    End Sub

    Function Calculate(Hours As Decimal, Rate As Decimal)
        'return Statement
        Return (Hours * Rate)

    End Function

End Module