Public Class Menu
    Private listRef = New PeopleList()
    Sub MainMenu()
        Dim op As String
        op = " "
        While op <> "0"
            ClearScreen()
            op = GetOption()
            If op Like "1" Then
                AddPerson()
            ElseIf op Like "2" Then
                ShowPeople()
            ElseIf op Like "0" Then
                Console.WriteLine("Exit...")
            Else
                Console.WriteLine("Option not found, try again...")
            End If
            KeyToContinue()
        End While
    End Sub

    Sub AddPerson()
        ClearScreen()
        Dim Name As String
        Dim Age As Integer

        Dim Per = New Person()

        Console.WriteLine("  ADD PERSON")
        Console.WriteLine("Introduce the information required.")
        Console.Write("Name: ")
        Name = Console.ReadLine()
        Console.Write("Age: ")
        Age = Console.ReadLine()

        Per.SetName(Name)
        Per.SetAge(Age)

        ' Call to people list to add a person
        Me.listRef.AddPerson(Per)

    End Sub

    Sub ShowPeople()
        ClearScreen()

        Console.WriteLine("  PEOPLE LIST")

        ' Call to people list to show all
        Console.WriteLine(Me.listRef.ShowPeopleList())
    End Sub

    Function GetOption()
        Dim op As String
        Console.WriteLine("  PEOPLE LIST")
        Console.WriteLine("1) Add person")
        Console.WriteLine("2) Show people list")
        Console.WriteLine("0) exit")
        Console.Write("Choose an option: ")
        op = Console.ReadLine()
        Return op
    End Function

    Sub KeyToContinue()
        Console.Write("Press a key to continue.")
        Console.ReadKey()
    End Sub
    Sub ClearScreen()
        Console.Clear()
    End Sub

End Class
