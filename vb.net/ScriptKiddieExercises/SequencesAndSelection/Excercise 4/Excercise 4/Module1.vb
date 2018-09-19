Module Module1

    Sub Main()
        Console.WriteLine("Input Test Score")
        Dim testScore As Integer = CInt(Console.ReadLine())
        If testScore >= 75 Then
            Console.WriteLine("You passed Dexter!")
        Else
            Console.WriteLine("Dexter, you need to " & """" & "Complete the test again" & """")
        End If


    End Sub

End Module
