Public Class Person
    Private Name As String
    Private Age As Integer

    ' SETTERS
    Public Sub SetName(name As String)
        Me.Name = name
    End Sub

    Public Sub SetAge(Age As Integer)
        Me.Age = Age
    End Sub
    ' GETTERS
    Public Function GetName()
        Return Me.Name
    End Function

    Public Function GetAge()
        Return Me.Age
    End Function

    ' TO STRING
    Public Function ToStringP()
        Dim str As String
        str = "" + Me.Name + " " + CStr(Me.Age)
        Return str
    End Function
End Class
