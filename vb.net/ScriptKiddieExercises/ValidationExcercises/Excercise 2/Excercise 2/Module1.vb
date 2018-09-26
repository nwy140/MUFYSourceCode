Module Module1

    'Declare global variables
    Dim userName As String
    Dim password As String

    Sub Main()
        Call InputInfo()
    End Sub

    Sub InputInfo()

        'User inputs username , username must be present
        While userName = ""
            Console.WriteLine("enter your username")
            userName = Console.ReadLine()
        End While
        'User inputs pasword , pasword must be present and greater than 8
        While password = "" And Len(password) < 8
            Console.WriteLine("enter your password")
            password = Console.ReadLine()

        End While

        'Display valid text when user enters information correctly
        Console.WriteLine("Username and password valid - access now open")
    End Sub


End Module
















































































































