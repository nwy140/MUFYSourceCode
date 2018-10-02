Module Module1

    'Declare Global Variables 
    Dim magicnum As Integer
    Dim guessnum As Integer
    'Main procedure
    Sub Main()
        magicnum = 47
        Call inputnum()

    End Sub

    'User inputs guessnumber and has to enter guessnumber again if it is not within 1 to 100 and it is not the same as the guess number
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

    'Checks if guess number is the same as magic number or it is lower or it is higher or it is out of range
    Sub Evaluate()
        If guessnum < 1 Or guessnum > 100 Then
            Console.WriteLine("Number out of range")

        ElseIf magicnum = guessnum Then
            Console.WriteLine("You guessed the magic number! " & magicnum)
        ElseIf magicnum > guessnum Then
        Console.WriteLine("Higher")
        ElseIf magicnum < guessnum Then
        Console.WriteLine("Lower")
        End If

    End Sub

End Module