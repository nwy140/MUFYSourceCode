Module Module1
    ' Declare global variables
    Dim i As Integer = 0
    Dim Total As Integer = 0
    Dim Average As Integer = 0
    Sub Main()
        Console.Write("Please enter number: ")
        i = Console.ReadLine()
        While i <> 999
    
            i = i + 1
            Console.WriteLine("The number is " & i)
            Total = Total + i
            Console.WriteLine("The total is " & Total)
            Average = Total / i
            Console.WriteLine("The Average is " & Average)
        End While
        Console.WriteLine("The end")
    End Sub

End Module
