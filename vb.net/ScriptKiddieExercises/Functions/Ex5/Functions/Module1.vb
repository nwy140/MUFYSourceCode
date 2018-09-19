Module Module1
    'Declare global variables
    Dim Hours As Single
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
        bikeNum = Console.ReadLine
        Console.WriteLine("How many hours do you want the hire bicycle? ")
        Hours = Console.ReadLine
    End Sub

    Sub Processing(Hours As Single, bikeNum As Integer)
        ' Calculate rental by hour and add charges 
        Cost = bikeNum * Hours * rental + charge
    End Sub

    Sub Output()
        ' Display name,  bicycle number and total cost
        Console.WriteLine("""" & UCase(name) & """" & ", the cost of " & bikeNum & " bicycles for " & Hours & " hours is a TOTAL of " & FormatCurrency(Cost))
    End Sub
End Module

'Module Module1
'    'Declaring global variables which allows the variables to be used by all procedures and functions
'    Dim name As String
'    Dim number As Integer
'    Dim hours As Integer
'    Dim cost As Single

'    'Main procedure call input and calculate functions and display procedure
'    Sub Main()
'        name = inputname()
'        number = inputnumber()
'        hours = inputhours()
'        cost = CalculateCost()
'        display()
'    End Sub

'    'Function to input name
'    Function inputname()
'        Console.WriteLine("Please enter your name: ")
'        name = Console.ReadLine
'        Return name
'    End Function

'    'Function to input nuumber of bicycles
'    Function inputnumber()
'        Console.WriteLine("Please enter the number of bicycles needed:")
'        number = Console.ReadLine
'        Return number
'    End Function

'    'FUnction to input hours
'    Function inputhours()
'        Console.WriteLine("Enter the number of hours:")
'        hours = Console.ReadLine
'        Return hours
'    End Function

'    'Function to calculate cost
'    Function CalculateCost()
'        cost = (number * (hours * 4.4)) + 10
'        Return cost
'    End Function

'    'Procedure to display statement
'    Sub display()
'        Console.WriteLine("""" & UCase(name) & """, the cost of" & Str(number) & " bicycles for" & Str(hours) & " hours is a TOTAL of $" & Format(cost, "0.00"))
'    End Sub

'End Module