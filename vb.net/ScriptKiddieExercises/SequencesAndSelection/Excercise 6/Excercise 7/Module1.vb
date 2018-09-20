Module Module1

    Sub Main()



        Console.WriteLine("Please Enter test score")

        'Declare Local Variables
        Dim Score As Single = Console.ReadLine()
        Dim Grade As String

        'Nested If to evaluate score
        'Condition 1 - score is >=70
        If Score >= 70 Then
            Grade = " Very Good"
        Else
            'Condition 2 - score is 50-69
            If Score >= 50 Then
                Grade = " Good"
            Else
                'Condition 3 - score is < 50
                Grade = " Umm, not very good"
            End If
        End If
        Console.WriteLine("Score:" & Str(Score) & " ,Grade:" & Grade)
    End Sub

End Module