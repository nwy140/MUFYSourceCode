Module Module1

    'Declare global variables

    Dim name As String
    Dim age As String
    Dim plsRepeat1 As String
    Dim plsRepeat2 As String
    Sub Main()
        Call InputInfo()
    End Sub

    Sub InputInfo()
        While name = ""
            Console.WriteLine("enter your name " & plsRepeat1)
            name = Console.ReadLine()
            plsRepeat1 = "again"
        End While
        While age = "" And IsNumeric(age) = False
            Console.WriteLine("enter your age 
                              " & plsRepeat2)
            age = Console.ReadLine()
            plsRepeat2 = "again"
        End While
        Console.WriteLine("Hello, " & name & " you are " & age & " years old.")
    End Sub


End Module
















































































































