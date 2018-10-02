Module Module1

    'Declare Global Variables 
    Dim add As String
    Dim text As String
    'Main procedure
    Sub Main()

        Call inputs()
        Call Evalutate()
    End Sub

    Sub inputs()
        Console.WriteLine("Enter a character")
        add = Console.ReadLine
        If (add.Contains("#") = False) And add.Length = 1 Then
            text = text + add
        ElseIf add.Length > 1 Then
            Console.WriteLine("Please Enter again with only 1 character  ")
        End If


    End Sub

    Sub Evalutate()
        While add.Contains("#") = False
            Call inputs()
        End While
        Console.WriteLine(text)
    End Sub
End Module