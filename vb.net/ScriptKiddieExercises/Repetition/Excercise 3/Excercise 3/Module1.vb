Module Module1
    Dim Total As Integer = 0
    Sub Main()
        For i = 0 To 10
            Console.WriteLine(Str(i))
            Total = i + Total
        Next
        'Extension of Excercise 3
        Console.WriteLine("Total of 1 to 10 is : " & Total)

    End Sub

End Module