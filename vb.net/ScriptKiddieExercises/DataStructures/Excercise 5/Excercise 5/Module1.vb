Module Module1
    ' Declare global variables
    Dim items(20) As String
    Dim choice As Integer
    Dim Number As Integer
    Dim x As Integer = 0

    Sub main()
        ' x = 0
        Console.WriteLine("Please enter 1 to ADD ITEM, 999 to exit")
        Console.WriteLine("Please enter choice ")
        choice = Console.ReadLine()

        While choice <> 999
            If choice = 1 Then
                Call AddItem()
            Else
                Call FindItem()
            End If
            Console.WriteLine("Please enter choice ")
            choice = Console.ReadLine()
        End While

    End Sub

    Sub AddItem()
        Console.WriteLine("Please enter new Item ")
        items(x) = Console.ReadLine()
        If x < 20 Then
            x = x + 1
        End If
    End Sub

    Sub FindItem()
        Console.WriteLine("Please enter menu item number")
        Number = Console.ReadLine()
        Console.WriteLine(items(Number))
    End Sub
End Module
