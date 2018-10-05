Module Module1

    'Declare global variables
    'Assign 7 elements to Hoursworked array
    Dim Hoursworked(7) As Decimal
    Dim name As String
    Dim daysworked As Integer
    Dim worktime As Decimal
    Dim Highest As Decimal
    Dim Total As Decimal
    Dim Salary As Decimal
    Dim Bonus As Decimal
    Dim bonustext As String

    Sub Main()
        Call Inputdetails()
        Call Calculate()
        Call Display()
    End Sub


    Sub Inputdetails()
        'User inputs name
        Console.WriteLine("Enter your name")
        name = Console.ReadLine
        'User inputs days worked
        Console.WriteLine("Enter number of days worked in a week")
        daysworked = Console.ReadLine

        'Validate that days worked entered is within 0 to 7 days
        While daysworked < 0 Or daysworked > 7
            Console.WriteLine("Enter number of days worked in a week again")
            daysworked = Console.ReadLine
        End While

        'User inputs worktime for each days worked
        For i = 1 To daysworked
            Console.WriteLine("Enter your working hours for day " & i)
            worktime = Console.ReadLine
            Hoursworked(i) = worktime
            'Validate that hours worked is numeric and is within 0 to 24 hours
            While Hoursworked(i) < 0 Or Hoursworked(i) > 24 Or IsNumeric(Hoursworked(i)) = False
                Console.WriteLine("Enter your working hours for day " & i & " again") ' Invalid Hours, input hours again
                worktime = Console.ReadLine
                'Set worktime input as an element in Hoursworked array for the particular day
                Hoursworked(i) = worktime

            End While
        Next
    End Sub

    Sub Calculate()

        'Get highest from Hoursworked array
        Highest = Hoursworked.Max
        'Get sum from Hoursworked array
        Total = Hoursworked.Sum
        'Salary calculated by multiplying by 10. Each hour earns $10 , formated in currency
        Salary = (Total * 10)
        If Total >= 40 Then
            Bonus = DetermineBonus()



            'Set bonustext to be printed later in display procedure ,                                             'Adds Bonus to salary 
            bonustext = "You qualify for bonus of " & FormatCurrency(Bonus) & " and your post-bonus salary is " & FormatCurrency(Salary + Bonus) & "."
        Else
            bonustext = "You do not qualify for a bonus."
        End If
    End Sub

    Function DetermineBonus()
        'Checks if worked more than 40 hours in total, then return  bonus of 10 percent 
        If Total >= 40 Then

            Return (Salary * 0.1)

        End If



        Return 0
    End Function

    Sub Display()
        'Display overall information for worker
        Console.WriteLine("Hello, " & name & ", you have worked for 7 days. Total hours worked is " & Total & " hours. Your highest number of working hours per day is " & Highest & ". Your salary is " & FormatCurrency(Salary) & ". " & bonustext)
    End Sub
End Module
