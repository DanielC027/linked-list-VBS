Public Class Node
    Private Per As Person
    Private NextNode As Node

    Public Sub New()
        Me.Per = Nothing
        Me.NextNode = Nothing
    End Sub

    ' SETTERS
    Public Sub SetPerson(Pe As Person)
        Me.Per = Pe
    End Sub

    Public Sub SetNextNode(Nn As Node)
        Me.NextNode = Nn
    End Sub
    ' GETTERS
    Public Function GetPerson()
        Return Me.Per
    End Function

    Public Function GetNextNode()
        Return Me.NextNode
    End Function
End Class
