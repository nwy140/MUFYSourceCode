Module Module1

    Dim Number As Integer = 1
    Sub Main()

        For i = 1 To 5
            For a = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()

        Next
        'Extension
        ' Input how many lines of asterisks 
        Console.WriteLine("How many lines of Asterisks do you want?")
        Dim Count As Integer = Console.ReadLine()
        For i = 1 To Count



            For a = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()

        Next
    End Sub

End Module
