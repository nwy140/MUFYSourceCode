Module Module1

    'Declare global variables
    Dim Name(10) As String
    Dim nameDisplay As String

    Dim Age As New List(Of String)
    Dim ageDisplay As String
    Dim ageAdd As String
    Sub Main()

        Call InputName()
        Call InputAge()
        Call DisplayNamewithAge()


    End Sub

    Sub InputName()
        For i = 1 To Name.Length() - 1
            Console.WriteLine("Please enter name of person " & i)
            Name(i) = Console.ReadLine
        Next

    End Sub

    Sub DisplayNamewithAge()

        Console.WriteLine("Who's information do you want to display? Enter their name...")
        nameDisplay = Console.ReadLine()
        For i = 1 To Name.Length() - 1

            If Name(i) = nameDisplay Then
                Console.WriteLine("Person's name is " & Name(i) & ", the person is" & Age.Item(i - 1) & " years old")
            End If
        Next

    End Sub

    Sub InputAge()
        For i = 1 To Name.Length() - 1
            Console.WriteLine("Please enter age of person " & i)
2:          ageAdd = Console.ReadLine()
            If IsNumeric(ageAdd) = True Then
                Age.Add(Str(ageAdd))
            Else
                Console.WriteLine("Invalid input, please enter again")
                GoTo 2
            End If
        Next

    End Sub


End Module
'Sub DisplayAge()
'    Console.WriteLine("Enter age of person to get")
'    ageDisplay = Console.ReadLine()
'    For i = 1 To Age.Length() - 1

'        If Age(i) = ageDisplay Then
'            Console.WriteLine("Person's age is " & Age(i))
'        End If
'    Next

'End Sub