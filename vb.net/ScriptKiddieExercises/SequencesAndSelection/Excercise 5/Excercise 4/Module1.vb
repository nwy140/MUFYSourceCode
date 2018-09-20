Module Module1

    Sub Main()
    
    'Input Salary
	' 	If Salary < 1000 Then
	'		Tax ← Pay * 0.2
	' 	Else
	'		Tax ← Pay * 0.3
	' 	End if
	'	Print Salary, Tax
	
        Console.WriteLine("Input Salary")
        
        Dim Salary As Integer = CInt(Console.ReadLine())
        Dim Tax As Integer = 0 
        If Salary < 1000 Then 
            Tax = Salary * 0.2
        Else
            Tax = Salary * 0.3
        End If
        Console.WriteLine (Str(Salary))  & " " & Str()Tax)) 
    End Sub

End Module