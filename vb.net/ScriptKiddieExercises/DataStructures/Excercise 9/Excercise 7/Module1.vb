Module Module1

    Dim Word As String
    Dim Length As Integer

    Sub Main()
        Console.WriteLine("Please enter a word")
        Word = Console.ReadLine()

        Do While Word.Contains("end") = False


            Length = Len(Word)
            Console.WriteLine("The length of " & Word & " is " & Length & ".")
            Console.WriteLine("Enter another word:")
            Word = Console.ReadLine()
        Loop
        Console.WriteLine("The end")
    End Sub

End Module