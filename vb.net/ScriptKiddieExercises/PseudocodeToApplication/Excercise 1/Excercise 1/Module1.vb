Module Module1
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim number1 As Integer
    Dim number2 As Integer
    Sub Main()

        Call Inputnum()
        Call Calculate()
    End Sub

    Sub Inputnum()


        'User input number1
        Console.WriteLine("Please enter number 1")
        number1 = Console.ReadLine

        'Validate if number 1 is within range and is number
        While number1 > 10 Or number1 < 1 Or (IsNumeric(number1) = False)
            Console.WriteLine("Please enter number 1 again between 1 and 10")
            number1 = Console.ReadLine
        End While

        'User input number2
        Console.WriteLine("Please enter number 2")
        number2 = Console.ReadLine


        'Validate if number 2 is within range and is number
        While number2 > 10 Or number2 < 1 Or (IsNumeric(number2) = False)
            Console.WriteLine("Please enter number 2 again between 1 and 10")
            number2 = Console.ReadLine
        End While
    End Sub

    Sub Calculate()
        'Prints number that is greater than the other
        If number1 > number2 Then
            Console.WriteLine("Highest: " & number1)
        ElseIf number2 > number1 Then
            Console.WriteLine("Highest: " & number2)
        Else
            Console.WriteLine("Number 1 and number 2 are equal")
        End If

    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
End Module
