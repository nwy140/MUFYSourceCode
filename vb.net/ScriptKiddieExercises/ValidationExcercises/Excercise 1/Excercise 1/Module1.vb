Module Module1

    'Declare global variables

    Dim name As String
    Dim age As String

    Sub Main()
        Call InputInfo()
    End Sub

    Sub InputInfo()
        While name = ""
            Console.WriteLine("enter your name")
            name = Console.ReadLine()
        End While
        While age = "" And IsNumeric(age) = False
            Console.WriteLine("enter your age")
            age = Console.ReadLine()

        End While
        Console.WriteLine("Hello, " & name & "you are " & age & "years old.")
    End Sub


End Module
















































































































