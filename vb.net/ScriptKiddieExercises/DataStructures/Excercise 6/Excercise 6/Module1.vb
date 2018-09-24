Module Module1
    Dim Colour As String
    Sub Main()
        Console.WriteLine("Enter Color Name")
        Colour = Console.ReadLine()
        While Colour <> "Green"
            Console.WriteLine(Colour & " is not Green")
        End While
    End Sub

End Module
