Module Module1

    'Declare Global Variables 
    Dim passchar As String
    Dim i As Integer
    Dim passgen As String
    'Main procedure
    Sub Main()

        Call inputpass()
        Call Generate()
    End Sub

    Sub inputpass()
        For i = 1 To 4
            Console.WriteLine("Enter a string that are between 1 to 4 characters long. Entering String " & i)
            passchar = Console.ReadLine()

            Call evaluate()
            If i = 1 Then
                passchar = UCase(passchar)
            End If
            passgen = passgen + passchar
        Next
    End Sub

    Sub evaluate()
        While passchar.Length < 1 Or passchar.Length > 4
            Console.WriteLine("Enter a string that are between 1 to 4 characters long. Entering String " & i)
            passchar = Console.ReadLine()

        End While

    End Sub

    Sub Generate()
        passgen = passgen.Replace("a", "@")
        passgen = passgen.Replace("A", "@")
        passgen = passgen + """"
        Console.WriteLine(passgen)
        If passgen.Length < 9 Then
            Console.WriteLine("Password not long enough, please generate password again")
            passgen = ""
            Call Main()
        End If
    End Sub
End Module