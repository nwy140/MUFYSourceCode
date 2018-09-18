Module Module1
    'Declare global variables
    Dim Cost As Decimal
    Sub Main()
        'Declare private variables
        Dim Days As Integer

        ' Set days as input's return value
        Days = Input()
        'proocess days

        Cost = CDec(Processing(Days))

        'Call output to display
        Call Output()
    End Sub

    Function Input()
        Console.WriteLine("How many days do you want the hire car?")

        Return (Console.ReadLine())
    End Function

    Function Processing(Days As Integer)
        Return (Days * 54) + 10
    End Function

    Sub Output()
        Console.WriteLine("The cost of the car hire is" + Str(Cost))
    End Sub



End Module