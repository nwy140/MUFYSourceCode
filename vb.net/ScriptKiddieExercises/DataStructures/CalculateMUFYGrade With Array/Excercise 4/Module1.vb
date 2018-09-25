Module Module1
    ' Declare global variables
    Dim assesmentNum As Integer = 4
    Dim TotalMarks As Single = 100
    Dim marksNum(20) As Integer

    Dim Total As Single
    Dim Average As Single
    Dim Grade As String
    Sub Main()

        '4 Assesments

        InputNumber()
        Calculate()


    End Sub


    Sub InputNumber()
        'User input number of Assesments
        Console.WriteLine("Enter Number of assesment ")
        assesmentNum = Console.ReadLine()

        'Users input added as elements to array
        For i = 1 To (assesmentNum)
            Console.WriteLine("Enter Marks Percentage for assesment " & Str(i))
            marksNum(i) = Console.ReadLine() + " "
        Next

    End Sub

    Sub Calculate()
        For i = 1 To (assesmentNum)
            Console.WriteLine(marksNum(i))

        Next

        For i = 1 To (assesmentNum)
            Total = marksNum(i) + Total
        Next
        Average = Total / (assesmentNum * TotalMarks)
        Console.WriteLine("Total: " & Total)
        Console.WriteLine("Average: " & FormatPercent(Average))
        Console.WriteLine("Minimum: " & marksNum.Min())
        Console.WriteLine("Maximum: " & marksNum.Max())

        'Calculate Grade
        If (Average >= 0.8) Then
            Grade = "HD"
        ElseIf Average >= 0.7 And Average <= 0.8 Then
            Grade = "D"
        ElseIf Average >= 0.6 And Average <= 0.7 Then
            Grade = "C"
        ElseIf Average >= 0.5 And Average <= 0.6 Then
            Grade = "P"
        ElseIf Average < 0.5 Then
            Grade = "F"
        End If
        Console.WriteLine("Students Grade: " & Grade)

    End Sub



End Module


''User input number of Assesments
'Console.WriteLine("Enter Number of assesment ")
'assesmentNum = Console.ReadLine()
