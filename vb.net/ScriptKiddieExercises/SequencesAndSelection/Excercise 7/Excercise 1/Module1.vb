Module Module1

    Sub Main()

        Console.WriteLine("Input Name")

        Dim Name As String = Console.ReadLine()
        Dim Age As Integer = 99
        If LCase(Name) = "dexter" Then
            Console.WriteLine(Name & " you are so cool")
        Else
            Console.WriteLine(Name & ", you are " & Age & ", dude your are really old")

        End If
    End Sub

End Module