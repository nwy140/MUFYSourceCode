Module Module1

    Sub Main()

        'declare script kiddie text as string
        Dim FirstName As String = " Script"
        Dim LastName As String = " Kiddie"


        For i As Integer = 0 To 100000000
            'print script kiddie text
            Console.WriteLine("Hello" + FirstName + LastName + Str(100 / 2) + " Iterating: " + Str(i)
                              )
        Next
    End Sub

End Module
