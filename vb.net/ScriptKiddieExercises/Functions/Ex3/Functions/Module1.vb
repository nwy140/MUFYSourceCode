Module Module1
    'Declare global variables
    Dim Days As Integer
    Dim Cost As Single
    Const charge As Single = 15
    Const rental As Single = 54

    Sub Main()

        Call Input()
        ' Set days as input's return value

        'proocess days
        Call Processing()

        'Call output to display
        Call Output()
    End Sub

    Sub Input()
        Console.WriteLine("How many days do you want the hire car?")

        Days = Console.ReadLine
    End Sub

    Function Processing()
        Cost = (Days * rental) + charge
    End Function

    Sub Output()
        Console.WriteLine("The cost of the car hire is" & FormatCurrency(Cost))
    End Sub



End Module