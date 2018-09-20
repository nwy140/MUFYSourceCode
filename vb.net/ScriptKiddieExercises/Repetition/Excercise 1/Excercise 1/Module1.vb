Module Module1

    Sub Main()

        Console.WriteLine("Input Name")

        Dim Name As String = Console.ReadLine()
        Dim Age As Integer = 99
        If Name = "Dexter" Then
            Console.WriteLine(Name & " you are so cool")
        End If
        Console.WriteLine(Name & ", you are " & Age & ", dude your are really old")
    End Sub

End Module