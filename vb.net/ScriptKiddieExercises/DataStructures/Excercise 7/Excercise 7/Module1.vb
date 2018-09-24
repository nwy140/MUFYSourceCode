Module Module1

    Dim Toppings As String
    Dim AllToppings As String

    Sub Main()

        Do While UCase(Toppings) <> "STOP"
            AllToppings = AllToppings + Toppings + " "
            Console.WriteLine("Enter Toppings FOR YOUR PIZZA. Enter STOP to end the application")
            Toppings = UCase(Console.ReadLine())
        Loop
        Console.WriteLine("Your chosen Toppings are " & AllToppings)
        Console.WriteLine("Bye for now")
    End Sub

End Module