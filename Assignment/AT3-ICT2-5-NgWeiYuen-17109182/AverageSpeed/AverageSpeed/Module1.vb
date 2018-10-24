Module Module1

    'Declare Global Variables
    Dim vehreg As String
    'Declare array speed
    Dim speed(2) As Decimal
    Dim averagespeed As Decimal
    Dim fine As Boolean

    'Main procedure to call functions and procedures
    Sub Main()
        'Call procedure to input vehicle registration 
        Call inputvehreg()
        'Call function that returns vehicle registration in Upper Case, then assign it to vehreg variable 
        vehreg = upvehreg()

        'Call procedure to input speed
        Call inputspeed()
        'Call getavgspeed function that returns Average speed based on speed array, then assign it to averagespeed variable 
        averagespeed = getavgspeed()
        'Call evaluate function that determines if vehicle gets a fine or not
        fine = evaluate()

        'Display Overall Information
        display()
    End Sub

    '' Procedure where user inputs vehicle registration details. vehicle registration is validated to only accept 6 characters
    Sub inputvehreg()
        'User input vehicle registration 
        Console.WriteLine("Please enter registration number")
        vehreg = Console.ReadLine
        'Validaties if vehicle registration has 6 characters, 
        While Len(vehreg) <> 6
            'display error message
            Console.WriteLine("Invalid, input must be 6 characters, try again")
            Console.WriteLine("Please enter registration number")
            vehreg = Console.ReadLine
        End While
        ''/
    End Sub

    '' Function that converts vehicle registration to upper case and returns vehicle registration at upper case. Vehicle registration at upper case is returned to Main procedure
    Function upvehreg()
        Return UCase(vehreg)
        ''/
    End Function

    '' Procedure where user input speed(1) and speed(2). Speed input is validated to only accept 0-400 numberic values.                  ''Km/h or mph?
    Sub inputspeed()
        For i = 1 To 2
            'User input speed
            Console.WriteLine("Please enter speed " & i)
            speed(i) = Console.ReadLine
            'Validaties if speed input is reasonable,  between 0 to 400 or user input is numeric
            While speed(i) < 0 Or speed(i) > 400 Or IsNumeric(speed(i)) = False
                'display error message
                Console.WriteLine("Invalid, input must be between 0 to 400, try again")
                Console.WriteLine("Please enter speed " & i)
                speed(i) = Console.ReadLine
            End While
        Next
    End Sub

    '' Function that return averagespeed based on elements in speed array. averagespeed is returned to Main procedure
    Function getavgspeed()
        'Get Total of elements in speed array / 2
        averagespeed = speed.Sum / 2
        Return averagespeed
    End Function

    '' Function that is called to return true only when average>80. Function returns boolean to main procedure which is assigned to Fine variable
    Function evaluate()
        'Set boolean fine variable based on value of average speed
        If (averagespeed > 80) Then
            'Return as true if average > 80
            fine = True
            Return fine
        Else
            'Return as false otherwise
            fine = False
            Return fine
        End If
        'Return false again in case function has not returned anything
        fine = False
        Return fine
    End Function

    ''Procedure that display overall information based on what the user has input such as vehicle registration and averagespeed
    Sub display()
        'Display Overall Information
        If fine = True Then
            'Receive fine if fine is true
            Console.WriteLine("Vehicle with registration number, " & vehreg & ", had an average speed of " & averagespeed & ". You will receive a fine.")
        Else
            'Will not Receive fine if fine is false
            Console.WriteLine("Vehicle with registration number, " & vehreg & ", had an average speed of " & averagespeed & ". You will not receive a fine.")
        End If
    End Sub

End Module