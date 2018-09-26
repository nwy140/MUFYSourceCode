Module Module1

    Dim age As Integer
    Dim ticketPrice As Single

    Sub Main()


        Do While age <> -1
            Console.WriteLine("Please enter age for next ticket")
            Console.WriteLine("(Enter -1 to exit application)")
            age = Console.ReadLine()
            If age < 3 And age >= 0 Then
                ticketPrice = 0
            ElseIf age > 3 And age < 12 Then
                ticketPrice = 10
            ElseIf age > 12 Then
                ticketPrice = 15
            End If
        Loop
        Console.WriteLine("Ticket price is " & ticketPrice)
    End Sub

End Module