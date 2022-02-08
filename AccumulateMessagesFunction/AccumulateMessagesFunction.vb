Module AccumulateMessagesFunction

    Sub Main()
        Dim userInput As String

        Console.WriteLine("Type out your thoughts: " & Chr(34) & "C" & Chr(34) & " will clear & " & Chr(34) & "Q" & Chr(34) & " will quit program")

        Do
            userInput = Console.ReadLine
            Select Case userInput
                Case "Q"
                    UserMessage("", False)
                Case "C"
                    UserMessage("", True)
                Case Else
                    UserMessage(userInput, False)
            End Select
        Loop While userInput <> "Q"

        Console.WriteLine(UserMessage("", False))

        Console.Read()
    End Sub

    Function UserMessage(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static message As String
        If clear = False Then
            message &= newMessage & vbNewLine
        Else
            message = ""
        End If
        Return message
    End Function

End Module
