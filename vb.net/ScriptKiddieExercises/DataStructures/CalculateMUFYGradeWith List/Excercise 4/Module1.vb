Module Module1
    ' Declare global variables
    Dim assesmentNum As Integer = 8
    Dim TotalMarks As Single = 100
    Dim allmarks As New List(Of Integer)
    Dim mark As Single
    Dim name As String

    Dim Total As Single
    Dim Average As Single
    Dim Grade As String

    Sub Main()

        '4 Assesments
        InputNumber()
        Calculate()
        DisplayGrade()

    End Sub


    Sub InputNumber()
        'User input name
        Console.WriteLine("Enter student name")
        name = Console.ReadLine()

        'Users input added as elements to array
        For i = 1 To (assesmentNum)
1:          Console.WriteLine("Enter Marks Percentage for student assesment " & Str(i))
            mark = Val(Console.ReadLine())
            If mark < 0 Or mark > TotalMarks Then
                Console.WriteLine("Please enter valid marks ")
                GoTo 1
            Else

                allmarks.Add(mark)
            End If
        Next

    End Sub

    Sub Calculate()
        Average = (allmarks.Average)
        Total = (allmarks.Sum())


        Console.WriteLine("Total: " & (Total))
        Console.WriteLine("Average: " & (Average))
        Console.WriteLine("Minimum: " & allmarks.Min())
        Console.WriteLine("Maximum: " & allmarks.Max())


    End Sub

    Sub DisplayGrade()
        'Display Grade
        If (Average >= 80) Then
            Grade = "HD"
        ElseIf Average >= 70 And Average < 80 Then
            Grade = "D"
        ElseIf Average >= 60 And Average < 70 Then
            Grade = "C"
        ElseIf Average >= 50 And Average <= 60 Then
            Grade = "P"
        ElseIf Average < 50 Then
            Grade = "F"
        End If
        Console.WriteLine("Student " & name & " Percentage: " & Average & " Grade: " & Grade)
    End Sub


End Module


''User input number of Assesments
'Console.WriteLine("Enter Number of assesment ")
'assesmentNum = Console.ReadLine()
