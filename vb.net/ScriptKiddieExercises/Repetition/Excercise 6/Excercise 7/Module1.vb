Module Module1

    Dim userName As String
    Dim password As String
    Dim authMessage As String = "Application Locked"

    Sub Main()
        Console.WriteLine("Authenticating Vault")

        '3 Changes of entering authentication
        For i = 1 To 3
            'User enters authentication
            Console.WriteLine("Please Enter Username")
            userName = Console.ReadLine()

            Console.WriteLine("Please Enter Password")
            password = Console.ReadLine()

            'If statement ensures user enters correct username and password
            If userName <> "dedsec" And password <> "retr0" Then
                Console.WriteLine("Incorrect Username & Password")
            ElseIf userName <> "dedsec" Then
                Console.WriteLine("Incorrect Username")
            ElseIf password <> "retr0" Then
                Console.WriteLine("Incorrect Password ")
            Else
                'Change authentication message
                authMessage = "Vaults Opens"
                'Continue / Break equilavent in vb.net from C++
                Exit For
            End If
        Next
        Console.WriteLine(authMessage)

        'Stop program from exiting on release build
        Console.ReadLine()
    End Sub

End Module