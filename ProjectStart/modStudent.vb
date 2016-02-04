Imports System.IO   'DO NOT DELETE

'Name: Death by taxes
'Purpose: Show the number of deaths, and tax rate for users brand of cigarettes.
'Author: Travis Seal
'Date: 02/04/16

Module modStudent

    Public Sub RunProject()
        'Project Header:

        DisplayLine("Cigarette Brands")

        'Variables
        Dim sBrand1Name As String = "BreatheEasy"
        Dim sBrand2Name As String = "BlackLung"
        Dim sBrand3Name As String = "CancerStix"
        Dim sBrand4Name As String = "TastySmokes"

        Dim sBrand1Deaths As String = "1,000,000"
        Dim sBrand2Deaths As String = "2,000,000"
        Dim sBrand3Deaths As String = "5,000,000"
        Dim sBrand4Deaths As String = "10,000,000"

        Dim sBrand1Tax As String = "1.80"
        Dim sBrand2Tax As String = "4.50"
        Dim sBrand3Tax As String = "10.00"
        Dim sBrand4Tax As String = "20.00"
        Dim sAnswer As String = ""

        'Begin Code
        DisplayLine()

        SetBackgroundColor(Color.Red)
        DisplayLine("1-BreathEasy")
        DisplayLine("2-BlackLung")
        DisplayLine("3-CancerStix")
        DisplayLine("4-TastySmokes")
        ResetBackgroundColor()

        DisplayLine()

        Display("Enter the number of your brand: ")

        sAnswer = ReadChar()

        'conditions
        If sAnswer = "1" Then
            DisplayLine()
            SetBackgroundColor(Color.Red)
            DisplayLine(sBrand1Name & " causes " & sBrand1Deaths & " deaths per year")
            DisplayLine("Your death tax is " & sBrand1Tax)
        ElseIf sAnswer = "2" Then
            DisplayLine()
            SetBackgroundColor(Color.Red)
            DisplayLine(sBrand2Name & " causes " & sBrand2Deaths & " deaths per year")
            DisplayLine("Your death tax is " & sBrand2Tax)
        ElseIf sAnswer = "3" Then
            DisplayLine()
            SetBackgroundColor(Color.Red)
            DisplayLine(sBrand3Name & " causes " & sBrand3Deaths & " deaths per year")
            DisplayLine("Your death tax is " & sBrand3Tax)
        ElseIf sAnswer = "4" Then
            DisplayLine()
            SetBackgroundColor(Color.Red)
            DisplayLine(sBrand4Name & " causes " & sBrand4Deaths & " deaths per year")
            DisplayLine("Your death tax is " & sBrand4Tax)
        Else
            SetBackgroundColor(Color.Red)
            DisplayLine("Error: Enter 1 through 4")
        End If


    End Sub

End Module