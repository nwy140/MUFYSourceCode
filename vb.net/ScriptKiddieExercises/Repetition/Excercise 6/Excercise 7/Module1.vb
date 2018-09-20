Module Module1

    Dim userName As String
    Dim password As String

    Sub Main()



        Console.WriteLine("Please Enter Username")
        userName = Console.ReadLine()


        Console.WriteLine("Please Enter Password")
        password = Console.ReadLine()

        If userName = Not "dedsec" And password = Not "retr0" Then
            Console.WriteLine("Incorrect Username & Password")
        ElseIf userName = Not "dedsec" Then
            Console.WriteLine("Incorrect Username")
        ElseIf password = Not "retro0" Then
            Console.WriteLine("Incorrect Password")
        Else
            Console.WriteLine("Vault Opens")
        End If
    End Sub

End Module