Module Module1

    'Declare Global Variables 
    Dim HoursWorked(5) As Integer
    Dim total As Integer
    Dim Average As Decimal
    'Main procedure
    Sub Main()

        Call inputhours()
        Call Calculate()
    End Sub

    Sub inputhours()
        For i = 1 To HoursWorked.Length - 1

            Console.WriteLine("Enter hours worked on day " & i)
            HoursWorked(i) = Console.ReadLine

        Next
    End Sub

    Sub Calculate()
        total = HoursWorked.Sum()
        Average = total / (HoursWorked.Length - 1)
        Console.WriteLine("Total: " & total & " Average: " & Average)
    End Sub
End Module