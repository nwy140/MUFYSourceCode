Module Module1

    Sub Main()
        'Manipulating Numbers
        'Ex1
        'Console.WriteLine((4 + 5).ToString())
        'Console.WriteLine((3 - 4).ToString())
        'Console.WriteLine((45 / 9).ToString())
        'Console.WriteLine((3 * 6).ToString())

        ''Ex2
        'Console.WriteLine((3 + 4 * 2).ToString())
        'Console.WriteLine((40 / 8 - 2).ToString())
        'Console.WriteLine((7 - 5 * 2).ToString())
        'Console.WriteLine((7 * 7 + 7).ToString())

        ''Ex3
        'Console.WriteLine(((3 + 4) * 2).ToString())
        'Console.WriteLine((45 - (8 - 2)).ToString())
        'Console.WriteLine((7 - (5 * 2)).ToString())
        'Console.WriteLine((7 * 7 + 7).ToString())

        ''Ex4
        'Dim Num1 As Integer = CInt(InputBox("Enter Number 1"))


        'Dim Num2 As Integer = CInt(InputBox("Enter Number 2"))

        'Dim Num3 As Integer = CInt(InputBox("Enter Number 3"))

        'Dim Total As Integer = Num1 + Num2 + Num3

        'Dim Average As Integer = Total / 3
        'Console.WriteLine("Total: " + (Total).ToString() + " Average: " + (Average).ToString())

        ''Ex5
        'Dim daysHired As Integer = CInt(InputBox("Enter Number of Days a game is hired"))
        'Dim output As Double = 5.5 + 4.5 * daysHired
        'Console.WriteLine("Days Hired: " + (daysHired).ToString() + " Output: " + (output).ToString())

        ''Ex6
        'Console.WriteLine((2 ^ 2).ToString())
        'Console.WriteLine((3 ^ 2).ToString())
        'Console.WriteLine((4 ^ 2).ToString())
        'Console.WriteLine((5 ^ 2).ToString())

        'Console.WriteLine("Alternate way using for loop3")
        ''Alternate way

        'For index As Integer = 1 To 5
        '    Console.WriteLine((index) ^ 2.ToString)
        'Next

        ''Ex7
        ''Set hourly rate at 15.25
        'Dim Rate As Double = 15.25
        ''User input hours worked
        'Dim Hours As Double = InputBox("Enter hours worked")
        ''Calculate Pay based on Rate and Hours
        'Dim Pay As Double = Rate * Hours
        ''Display Pay
        'Console.WriteLine("Pay: " + Str(CDec(Pay)))

        'Combining numbers and strings
        'Ex1

        Console.WriteLine("Combining numbers and strings")
        Console.WriteLine("Ex1")
        Dim A As String = CInt(5)
        Dim B As String = CInt(4)
        Console.WriteLine("A+B = " + Str(CInt(A) + CInt(B)))

        'Ex2
        Console.WriteLine("Ex2")
        Dim C As Double = CInt(InputBox("Enter Number C"))

        Dim D As Double = CInt(InputBox("Enter Number D"))

        'Display calculation
        Console.WriteLine(C + D)

        'Ex3
        Console.WriteLine("Ex3")
        Dim Name As String = InputBox("What is your username?")
        Dim Number As Integer = 1001

        Dim UserName As String = Name + Str(Number)

        'Display username followed by number
        Console.WriteLine(UserName)

        'Ex4
        Console.WriteLine("Ex4")
        Dim yourname As String = InputBox("Enter your real name")
        Dim yearofBirth As Integer = InputBox("Enter your year of birth")
        Dim age As Integer = Date.Today.Year - yearofBirth

        'Display details of your birthday
        Console.WriteLine("Hi, " + yourname + ", you were born in " + Str(yearofBirth) + ", so this year on your birthday, you will be " + Str(age) + " years old.")


        'Ex5
        Console.WriteLine("Ex5")
        Dim newA As Integer = 4
        Dim newB As Integer = 9
        Dim newC As Integer = newA + newB
        Dim newD As Decimal = CDec(newC / 7)

        'Display calculation
        Console.WriteLine(Str(Math.Round((newD), 2)))

        'Extension Activity
        Console.WriteLine("Extension Activity")
        Dim EXUSERNAME As String = InputBox("Enter your username")
        Dim length As Integer = Len(EXUSERNAME)
        EXUSERNAME = EXUSERNAME.ToUpper()
        Dim email As String = InputBox("Enter your email")
        Dim trueorfalse As Boolean = email.Contains("@")
        Dim password As String = InputBox("Enter your Password")
        password = password.Replace("o", "#")
        Dim salary As String = InputBox("Enter your salary")
        Dim loanamount As Double = salary ^ 2

        Console.WriteLine("Hi " + EXUSERNAME + ", the length of your username is " + Str(length) + ", your email address contains a '@' symbol is " + Str(trueorfalse) + " and your password is " + password + ". With your weekly salary being" + Str(salary) + " you can borrow $" + Str(loanamount))



    End Sub

End Module