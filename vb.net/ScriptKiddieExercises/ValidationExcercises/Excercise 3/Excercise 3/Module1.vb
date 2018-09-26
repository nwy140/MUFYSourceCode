Module Module1

    'Declare global variables
    Dim townName As String
    Dim postcode As String = 0

    Sub Main()
        Call InputInfo()
    End Sub

    Sub InputInfo()

        'User inputs townName , townName must be present and has more than  3 characters
        While Len(townName) < 3
            Console.WriteLine("enter your townName")
            townName = Console.ReadLine()
            If townName = "" Then
                Console.WriteLine("Town not present - please try again")
            End If
            If Len(townName) < 3 Then
                Console.WriteLine("Town needs to be at least 3 characters")
            End If
        End While

        'User inputs pasword , pasword must be present and between 3000 and 3999
        While postcode < 3000 Or postcode > 3999
            Console.WriteLine("enter your postcode")
            postcode = Console.ReadLine()

            If postcode < 3000 Or postcode > 3999 Then
                Console.WriteLine("Postcode needs to be between 3000 and 3999")
            End If
        End While

        'Display valid text when user enters information correctly
        Console.WriteLine("All good boss")
    End Sub


End Module

