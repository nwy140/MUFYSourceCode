Module Module1

    'Declare array by size and type
    Dim Num(9) As String

    'Declare other variables
    Dim number As Integer
    Dim Total As Integer
    Dim Average As Integer

    Sub Main()
        InputNumber()



        Calculate()
    End Sub
    Sub InputNumber()
        'Users input added as elements to array
        For i = 0 To 9
            Console.WriteLine("Enter Number:  " & Str(i))
            Num(i) = Console.ReadLine() + " "
        Next

    End Sub

    Sub Calculate()


        For i = 0 To 9
            Total = Num(i) + Total
        Next
        Average = Total / (9 + 1)
        Console.WriteLine("Total: " & Total)
        Console.WriteLine("Average: " & Average)

    End Sub

End Module



'Sub Search()
'    Console.WriteLine("Enter Friends Number")
'    number = Console.ReadLine()

'    Console.WriteLine(Friends(number))

'End Sub