Module Module1

    'Declare Global Variables 
    Dim daypass As String
    'Main procedure
    Sub Main()

        Call inputpass()
        Call evaluate()
    End Sub

    Sub inputpass()
        Console.WriteLine("Select 7 , 14 or 30 Day Pass, Enter Exit to exit")
        daypass = Console.ReadLine

    End Sub

    Sub evaluate()
        While daypass <> "exit"

            If daypass = "exit" Then
                Exit While
      
            ElseIf daypass = 7 Then
                Console.WriteLine("7 Day Pass cost $136.55")
            ElseIf daypass = 14 Then
                Console.WriteLine("14 Day Pass cost $239.95")
            ElseIf daypass = 30 Then
                Console.WriteLine("30 Day Pass cost $500.00")

            End If
            Call inputpass()
        End While
    End Sub
End Module