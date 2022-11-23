Imports System.Runtime.Remoting.Messaging

Public Class FrmMain

    Dim QuestionList As New List(Of String), CorrectAnswerList As New List(Of Long), UserAnswerList As New List(Of Long)
    Dim NumCorrect As Long, isValidated As Boolean, S As String

    Private Sub BtnDisplayResults_Click(sender As Object, e As EventArgs) Handles BtnDisplayResults.Click

        Dim X As Integer, S As String

        If QuestionList.Count = 0 Then
            MessageBox.Show("There are no results to display.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        FrmDisplayResults.Activate()

        FrmDisplayResults.RtfResults.Text = ""

        For X = 0 To QuestionList.Count - 1
            If UserAnswerList(X) = CorrectAnswerList(X) Then
                S = "CORRECT"
            Else
                S = "INCORRECT"
            End If
            FrmDisplayResults.RtfResults.Text &= "Q" & X + 1 & ": " & QuestionList(X) & vbNewLine &
                                    "Correct Answer: " & CorrectAnswerList(X) & vbNewLine &
                                    "User Answer: " & UserAnswerList(X) & " (" & S & ")" & vbNewLine & vbNewLine
        Next

        If QuestionList.Count < Val(TxtIterations.Text) Then
            FrmDisplayResults.RtfResults.Text &= "The test was ended early by the user!" & vbNewLine & vbNewLine
        End If

        FrmDisplayResults.RtfResults.Text &= "Total Questions: " & QuestionList.Count & vbNewLine &
                                                "Correct Answers: " & NumCorrect & vbNewLine &
                                                "Incorrect Answers: " & QuestionList.Count - NumCorrect & vbNewLine &
                                                "Percent Correct: " & FormatPercent(NumCorrect / QuestionList.Count, 2)
        FrmDisplayResults.ShowDialog()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Application.Exit()

    End Sub

    Private Sub ValidateData()

        isValidated = True
        S = ""

        ' validate number to test
        If Not IsNumeric(TxtNumberToTest.Text) Then
            S &= "The number to test must be numeric." & vbNewLine
            isValidated = False
        End If

        If Val(TxtNumberToTest.Text) < 2 Or Val(TxtNumberToTest.Text) > 100 Then
            S &= "The number to test must be between 2 and 100." & vbNewLine
            isValidated = False
        End If

        ' validate iterations
        If Not IsNumeric(TxtIterations.Text) Then
            S &= "The number of iterations must be numeric." & vbNewLine
            isValidated = False
        End If

        If Val(TxtIterations.Text) < 3 Or Val(TxtIterations.Text) > 20 Then
            S &= "The number of iterations must be between 3 and 20." & vbNewLine
            isValidated = False
        End If

    End Sub

    Private Sub BtnStartTest_Click(sender As Object, e As EventArgs) Handles BtnStartTest.Click

        Dim myQuestion As String, myAnswer As String, actualAnswer As Long, X As Integer

        ValidateData()

        If Not isValidated Then
            MessageBox.Show("Invalid values. Cannot run the test." & vbNewLine &
                            "See error list below." & vbNewLine & vbNewLine & S,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        QuestionList.Clear()
        CorrectAnswerList.Clear()
        UserAnswerList.Clear()
        NumCorrect = 0

        For X = 1 To Val(TxtIterations.Text)
AskQuestion:
            myQuestion = "What is " & TxtNumberToTest.Text & " times " & X & "?"
            myAnswer = InputBox(myQuestion)
            If myAnswer = "" Then Exit For
            If Not IsNumeric(myAnswer) Then
                MessageBox.Show("Enter numeric values only." & vbNewLine &
                                "Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GoTo AskQuestion
            End If
            myAnswer = CLng(myAnswer)
            actualAnswer = Val(TxtNumberToTest.Text) * X
            If myAnswer = actualAnswer Then NumCorrect += 1
            QuestionList.Add(myQuestion)
            CorrectAnswerList.Add(actualAnswer)
            UserAnswerList.Add(myAnswer)
        Next

        MessageBox.Show("The test has ended!", "Multiplication Test", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
