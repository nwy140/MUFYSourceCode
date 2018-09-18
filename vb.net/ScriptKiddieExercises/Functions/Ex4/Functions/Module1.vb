Module Module1
    'Declare global variables
    Dim Days As Integer
    Dim Cost As Single
    Const charge As Single = 10
    Const rental As Single = 66

    Sub Main()

        Call Input()
        ' Set days as input's return value

        'proocess days
        Call Processing(Days)

        'Call output to display
        Call Output()
    End Sub

    Sub Input()
        Console.WriteLine("How many days do you want the hire ski? ")

        Days = Console.ReadLine
    End Sub

    Function Processing(Days As String )
   ' Calculate rental by day and add charges 
        Cost = (Days* rental) + charge
    End Function

    Sub Output()
        Console.WriteLine("The cost of the ski hire is" & FormatCurrency(Cost))
    End Sub



End Module
