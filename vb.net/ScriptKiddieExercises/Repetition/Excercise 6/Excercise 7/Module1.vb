Module Module1

    Dim userName As String
    Dim password As String
    Dim authMessage As String = "Application Locked - Ring into network manager for assistance"

    Sub Main()
        Console.WriteLine("Authenticating Vault")

        auth()

        Console.WriteLine(authMessage)
        'Stop program from exiting on release build
        Console.ReadLine()
    End Sub

    Sub auth()
        '3 Changes of entering authentication
        For i = 1 To 3
            'User enters authentication
            Console.WriteLine("Please Enter Username")
            userName = LCase(Console.ReadLine())

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
                authMessage = "Correct username and password. Vaults Opens"
                'Continue / Break equilavent for loop in vb.net from C++
                'Exit For
                'Exit sub returns null for the procedure
                Exit Sub

            End If
        Next
        
    End Sub
End Module