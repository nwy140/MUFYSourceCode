Module Module1

    'Declare global variables
    Dim Weight As String
    Dim Height As String = 0
    Dim BodyMassIndex As Single = 0

    Sub Main()
        Call InputInfo()
    End Sub

    Sub InputInfo()

        'User inputs Weight , Weight must be present and is number and is between 200 and 0
        While Weight = "" Or IsNumeric(Weight) = False Or Weight > 200 Or Weight < 0
            Console.WriteLine("enter your Weight")
            Weight = Console.ReadLine()
            If Weight = "" Then
                Console.WriteLine("Weight not entered properly - please try again")
                Exit While
                Weight = ""

            End If
            If IsNumeric(Weight) = False Or Weight > 200 Or Weight < 0 Then
                Console.WriteLine("Weight must be entered as a number, Weight must be between 0 and 200 KG")
            End If

        End While

        'User inputs Height , Height must be present and is number and is between 200 and 0
        While Height = "" Or IsNumeric(Height) = False Or Height > 200 Or Height < 0
            Console.WriteLine("enter your Height")
            Height = Console.ReadLine()
            If Height = "" Then
                Console.WriteLine("Height not entered properly - please try again")
            End If
            If IsNumeric(Height) = False Or Height > 200 Or Height < 0 Then
                Console.WriteLine("Height must be entered as a number, Height must be between 0 and 200 KG")
            End If

        End While


        'Display valid BMI text when user enters information correctly
        Call CalculateBMI()
    End Sub

    Sub CalculateBMI()
        BodyMassIndex = Weight / (Height ^ 2)
    End Sub


End Module

