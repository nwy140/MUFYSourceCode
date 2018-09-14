Module Module1

    Sub Main()
        'Manipulating Numbers
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

        'Combining numbers and strings
        'Ex1
        Dim A As String = CInt(5)
        Dim B As String = CInt(4)
        Console.WriteLine("A+B = " + Str(CInt(A) + CInt(B)))

        'Ex2
        Dim C As Double = CInt(InputBox("Enter Number C"))

        Dim D As Double = CInt(InputBox("Enter Number D"))


        Console.WriteLine(C + D)

        'Ex3
        Dim Name As String = InputBox("What is your Name?")
        Dim Number As Integer = 1001

        Dim UserName As String = Name + Str(Number)

        Console.WriteLine(UserName)

        'Ex4
        Dim yourname As String = InputBox("Enter your name")
        Dim yearofBirth As Integer = InputBox("Enter your year of birth")
        Dim age As Integer = Date.Today.Year - yearofBirth
        Console.WriteLine("Hi, " + yourname + ", you were born in " + Str(yearofBirth) + ", so this year on your birthday, you will be " + Str(age) + " years old.")


        'Ex5
        Dim newA As Integer = 4
        Dim newB As Integer = 9
        Dim newC As Integer = newA + newB
        Dim newD As Decimal = CDec(newC / 7)

        Console.WriteLine(Str(Math.Round((newD), 2)))

    End Sub

End Module