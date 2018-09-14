Module Module1

    Sub Main()
        'Ex1
        Console.WriteLine((4 + 5).ToString())
        Console.WriteLine((3 - 4).ToString())
        Console.WriteLine((45 / 9).ToString())
        Console.WriteLine((3 * 6).ToString())

        'Ex2
        Console.WriteLine((3 + 4 * 2).ToString())
        Console.WriteLine((40 / 8 - 2).ToString())
        Console.WriteLine((7 - 5 * 2).ToString())
        Console.WriteLine((7 * 7 + 7).ToString())

        'Ex3
        Console.WriteLine(((3 + 4) * 2).ToString())
        Console.WriteLine((45 - (8 - 2)).ToString())
        Console.WriteLine((7 - (5 * 2)).ToString())
        Console.WriteLine((7 * 7 + 7).ToString())

        'Ex4
        Dim Num1 As Integer = CInt(InputBox("Enter Number 1"))


        Dim Num2 As Integer = CInt(InputBox("Enter Number 2"))

        Dim Num3 As Integer = CInt(InputBox("Enter Number 3"))

        Dim Total As Integer = Num1 + Num2 + Num3

        Dim Average As Integer = Total / 3
        Console.WriteLine("Total: " + (Total).ToString() + " Average: " + (Average).ToString())

        'Ex5
        Dim daysHired As Integer = CInt(InputBox("Enter Number of Days a game is hired"))
        Dim output As Double = 5.5 + 4.5 * daysHired
        Console.WriteLine("Days Hired: " + (daysHired).ToString() + " Output: " + (output).ToString())

        'Ex6
        Console.WriteLine((2 ^ 2).ToString())
        Console.WriteLine((3 ^ 2).ToString())
        Console.WriteLine((4 ^ 2).ToString())
        Console.WriteLine((5 ^ 2).ToString())

        Console.WriteLine("Alternate way using for loop3")
        'Alternate way

        For index As Integer = 1 To 5
            Console.WriteLine((index) ^ 2.ToString)
        Next

        'Ex7
        'Set hourly rate at 15.25
        Dim Rate As Double = 15.25
        'User input hours worked
        Dim Hours As Double = InputBox("Enter hours worked")
        'Calculate Pay based on Rate and Hours
        Dim Pay As Double = Rate * Hours
        'Display Pay
        Console.WriteLine("Pay: " + Str(CDec(Pay)))

    End Sub

End Module