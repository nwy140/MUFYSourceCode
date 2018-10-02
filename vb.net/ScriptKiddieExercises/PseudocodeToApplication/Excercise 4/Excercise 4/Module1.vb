Module Module1

    'Declare Global Variables 
    Dim magicnum As Integer
    Dim guessnum As Integer
    'Main procedure
    Sub Main()
        magicnum = 47
        Call inputnum()

    End Sub

    Sub inputnum()
        Console.WriteLine("Guess the magic number")
        guessnum = Console.ReadLine
        Call Evaluate()
        While magicnum <> guessnum Or guessnum < 1 Or guessnum > 100
            Console.WriteLine("Guess the magic number")
            guessnum = Console.ReadLine
            Call Evaluate()
        End While
    End Sub

    Sub Evaluate()
        If guessnum < 1 Or guessnum > 100 Then
            Console.WriteLine("Number out of range")
        End If
        If magicnum = guessnum Then
            Console.WriteLine("You guess the magic number! " & magicnum)
        ElseIf magicnum > guessnum Then
            Console.WriteLine("Higher")
        ElseIf magicnum < guessnum Then
            Console.WriteLine("Lower")
        End If

    End Sub
End Module