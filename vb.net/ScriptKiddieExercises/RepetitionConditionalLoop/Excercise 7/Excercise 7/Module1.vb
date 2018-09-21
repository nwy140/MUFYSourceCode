Module Module1

    Dim Toppings As String = {}
    Sub Main()
        Console.WriteLine("Enter Toppings Name")
        Toppings.Insert(Toppings.Last, Console.ReadLine())


        While Toppings <> "Green"
            Console.WriteLine(Toppings & " is not Green")
        End While
        Console.WriteLine("Bye for now")
    End Sub

End Module