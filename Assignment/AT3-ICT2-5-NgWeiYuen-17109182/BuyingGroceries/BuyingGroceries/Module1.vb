Module Module1

    'Declare Global Variables
    Dim name As String
    Dim itemsnum As Integer

    'Declare price array with 5 elements
    Dim price(5) As Decimal
    Dim highest As Decimal
    Dim total As Decimal
    Dim discount As Decimal
    Dim postdiscprice As Decimal

    'Main procedure to call functions and procedures
    Sub Main()
        'Assign name as returned value from Function inputname
        name = inputname()

        'Call Procedure to input number of items bought
        Call inputitemsnum()

        'Call procedure to input price
        Call inputprice()

        'Assign highest as returned value from Function highprice
        highest = highprice()

        'Assign total as returned value from Function totalprice
        total = totalprice()

        'Assign discount as returned value from Function evaluate
        discount = evaluate()

        'Assign postdiscprice as returned value from Function calpostdisc
        postdiscprice = calpostdisc()

        'Display Overall Information
        display()
    End Sub

    '' Function that returns user input for name. Name is returned to Main procedure.
    Function inputname()
        'User input name
        Console.WriteLine("Please enter your name")
        name = Console.ReadLine
        Return name
    End Function

    '' Procedure where user input number of items bought. itemsnum is validated to only accept 0-5 in numeric values.
    Sub inputitemsnum()
        'User input number of items bought
        Console.WriteLine("Please enter number of items bought")
        itemsnum = Console.ReadLine
        'Validaties if itemsnum input is reasonable,  itemsnum must be between 0 to 5 ,  user input must be numeric
        While itemsnum < 0 Or itemsnum > 5 Or IsNumeric(itemsnum) = False
            'display error message
            Console.WriteLine("Invalid, input must be between 0 to 5, try again")
            Console.WriteLine("Please enter number of items bought")
            itemsnum = Console.ReadLine
        End While

    End Sub


    '' Procedure where user input price for each items bought.price input for each items bought is validated to only accept positive numbers.
    Sub inputprice()
        'For loop iterates over number of items bought , and the user input the price for each of the items
        For i = 1 To itemsnum
            'User input price
            Console.WriteLine("Please enter price for item " & i)
            price(i) = Console.ReadLine
            'Validaties if price input is numeric or price is positive
            While price(i) < 0 Or IsNumeric(price(i)) = False
                'display error message
                Console.WriteLine("Invalid, input must be equal to or above 0, try again")
                Console.WriteLine("Please enter price for item " & i)
                price(i) = Console.ReadLine
            End While
        Next
    End Sub

    '' Function that return highestprice based on highest of the elements in price array. Highest price is returned to Main procedure
    Function highprice()
        highest = price.Max
        Return highest
    End Function

    '' Function that return totalprice based on sum of the elements in price array. Total price is returned to Main procedure
    Function totalprice()
        total = price.Sum
        Return total
    End Function

    '' Function that will return 5% discount of totalprice only when total price > 40. Discount is returned to Main procedure
    Function evaluate()
        ' 5% discount of totalprice if totalprice > 40
        If total > 40 Then
            discount = total * 0.05
            Return discount
            'Else no discount provided
        Else
            discount = 0
            Return discount
        End If
    End Function
    '' Function that return post-discount price . Post-discount price is returned to Main procedure
    Function calpostdisc()
        'subract total by discount
        postdiscprice = total - discount
        Return postdiscprice
    End Function

    ''Procedure that display overall information based of application including name, highest price, total price and discount informations
    Sub display()
        'Display Overall Information
        If discount > 0 Then
            'Qualify for discount if discount > 0 which means if there is discount
            Console.WriteLine("Hello, " & name & ", the price of the most expensive item you bought is " & FormatCurrency(highprice()) & " and your total grocery bill is " & FormatCurrency(total) & ". You qualify for a discount of " & FormatCurrency(discount) & " and your post-discount bill is " & FormatCurrency(postdiscprice) & ".")
        Else
            'Else Will not Qualify for discount if there is no discount 
            Console.WriteLine("Hello, " & name & ", the price of the most expensive item you bought is " & FormatCurrency(highprice()) & " and your total grocery bill is " & FormatCurrency(total) & ". You do not qualify for a discount.")

        End If
    End Sub

End Module