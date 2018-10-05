Module Module1

    'Declare global variables
    'Assign 3 elements to Sales array
    Dim Sales(3) As Decimal
    Dim customerID As String
    Dim salesamount As String

    Dim Average As Decimal
    Dim rewardtext As String

    Sub Main()
        'Call Procedures and functions
        Call Inputdetails()
        Call Display()
    End Sub


    Sub Inputdetails()
        'User inputs customerID
        Console.WriteLine("Enter your CustomerID")
        customerID = UCase(Console.ReadLine)

        While customerID.Length <> 6
            'User inputs customerID
            Console.WriteLine("Enter your CustomerID again, customerID must be 6 characters")
            customerID = UCase(Console.ReadLine)
        End While

        'User inputs salesamount for each sales
        For i = 1 To 3
            Console.WriteLine("Enter your sales amount for sales " & i)
            salesamount = Console.ReadLine

            Sales(i) = FormatCurrency(salesamount)
        Next
    End Sub

    Function Calculate()
        'return true if average > 1000 else false
        Average = Sales.Sum / 3
        If Average > 1000 Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub Display()
        'Set rewardtext if average is greater than 1000
        If Calculate() = True Then
            rewardtext = "You will receive a reward."
        Else
            rewardtext = "You will not receive a reward."
        End If
        'Display overall information for customer
        Console.WriteLine("Customer with ID " & customerID & ",has sales amount " & FormatCurrency(Sales(1)) & " " & FormatCurrency(Sales(2)) & " and " & FormatCurrency(Sales(3)) & ". The Average sales amount is " & FormatCurrency(Average) & ". " + rewardtext)
    End Sub
End Module
