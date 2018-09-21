Module Module1

    Dim Number As Integer = 1
    Sub Main()


        For i = 1 To 4

            For a = 1 To i
                Console.Write(i)
            Next
            'next line
            Console.WriteLine()
            Number = Number + 1
        Next
        'Extension
        ' Input how many lines of Numbers 
        Console.WriteLine("How many lines of Numbers do you want?")
        Dim Count As Integer = Console.ReadLine()
        For i = 1 To Count
            For a = 1 To i
                Console.Write(i)
            Next
            Console.WriteLine()
            Number = Number + 1
        Next
    End Sub
End Module
