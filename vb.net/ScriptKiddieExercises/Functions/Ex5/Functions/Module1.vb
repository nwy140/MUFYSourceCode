Module Module1
    'Declare global variables
    Dim Hours As Integer
    Dim Cost As Single
    Const charge As Single = 10
    Const rental As Single = 4.50
    Dim bikeNum As Integer = 0
    Dim name As String =""

    Sub Main()

        Call Input()
        ' Set hours as input's return value

        'proocess hours
        Call Processing(Hours, bikeNum)

        'Call output to display
        Call Output()
    End Sub

    Sub Input()
        Console.WriteLine("Enter Name ")
        
        name = Console.ReadLine
        Console.WriteLine("How many bicycles do you want to hire? ")

        bikeNum = Cint(Console.ReadLine) 
        Console.WriteLine("How many hours do you want the hire bicycle? ")

        Hours = Console.ReadLine
    End Sub

    Function Processing(Hours As String , bikeNum)
   ' Calculate rental by hour and add charges 
        Cost = bikeNum * Hours* rental + charge
    End Function

    Sub Output()
       ' Display name,  bicycle number and total cost
        Console.WriteLine("""name"""& ", the cost of " & bikeNum & " bicycles for 2 hours is a TOTAL of " & FormatCurrency(Cost))
    End Sub



End Module
