Module Module1

    Sub Main()
        'ScriptEngine Kiddie input your name


        'Ex 1
        Dim YourName As String

        YourName = InputBox("Your are a script kiddie for viewing this, input your name ")
        Console.WriteLine("your name is : " + YourName)

        'Ex 2
        Console.WriteLine("Dexter was named after Dexter from the tv show 'Perfect Match'")

        'Ex 3
        Dim Town As String
        Town = InputBox("What is your town name?")
        Console.WriteLine(Town.ToLower())

        'Ex 4
        Town = "Jakarta"
        Console.WriteLine(Town.Contains("k"))

        'Ex 5
        Dim River As String

        River = "Mississippi"
        Console.WriteLine(River)
        River = River.Replace("s", "0")
        Console.WriteLine(River)

        'Ex 6
        Dim Password As String
        Password = InputBox("Enter Password")
        Console.WriteLine("Length of password : " + Str(Password.Length()))







    End Sub


End Module
