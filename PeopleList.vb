Public Class PeopleList
    Private Anchor As Node

    Public Sub New()
        Me.Anchor = Nothing
    End Sub

    Public Sub AddPerson(Pr As Person)
        Dim Nde = New Node()
        Nde.SetPerson(Pr)

        If IsEmptyList() Then
            Me.Anchor = Nde
        Else
            Dim Aux = Me.Anchor
            While Aux.GetNextNode() IsNot Nothing
                Aux = Aux.GetNextNode()
            End While
            Aux.SetNextNode(Nde)
        End If
    End Sub

    Public Function ShowPeopleList()
        Dim Aux = Me.Anchor
        Dim str As String
        str = ""

        If IsEmptyList() Then
            Return str
        End If

        While Aux IsNot Nothing
            str = str + " " + Aux.GetPerson().ToStringP() + vbCrLf
            Aux = Aux.GetNextNode()
        End While

        Return str
    End Function

    Public Sub UpdatePerson(Nme As String, Prsn As Person)
        Dim Aux = Me.Anchor

        If IsEmptyList() <> True Then
            While Aux IsNot Nothing
                If Aux.GetPerson().GetName() Like Nme Then
                    Aux.SetPerson(Prsn)
                    Aux = Nothing
                Else
                    Aux = Aux.GetNextNode()
                End If
            End While
        End If
    End Sub

    Public Function IsEmptyList()
        Return Me.Anchor Is Nothing
    End Function
End Class
