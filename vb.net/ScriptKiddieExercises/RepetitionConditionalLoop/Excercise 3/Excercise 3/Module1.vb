Module Module1
    Dim Total As Integer = 0
    Sub Main()
        Dim A As Integer = 1
        Dim B As Integer = 5
        While B > A
            A = A + 2
            B = B + 1

        End While
        Console.WriteLine("A = " & A & " B = " & B)
    End Sub

End Module