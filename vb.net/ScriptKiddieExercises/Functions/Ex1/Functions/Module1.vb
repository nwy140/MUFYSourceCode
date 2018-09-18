Module Module1

    'Declare global variables
    Dim name As String
    Dim age As String
    Dim statement As String


    Sub Main()

        'Ex 1
        Console.WriteLine("Ex 1")

        'Print please enter name
        Console.WriteLine("Please enter name")
        'read input
        name = Console.ReadLine()
        'Print please enter age,
        Console.WriteLine("Please enter age")
        'read input
        age = Console.ReadLine()

        'Ensure user input is not numeric
        Do While (IsNumeric(age))
            Console.WriteLine("Please enter age")
            age = Console.ReadLine()
        Loop

        'Set Statement, to be displayed later
        statement = "Hello " & UCase(name) & " you are " & age

        'Calling display
        Display()

        'Update statement
        statement = "Have a nice day"
        'Call display to display statement
        Display()

    End Sub

    Sub Display()
        'Print Statement
        Console.WriteLine(statement)

    End Sub



End Module