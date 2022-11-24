Public Class FrmDisplayResults
    Private Sub FrmDisplayResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim X As Integer

        For X = 0 To RtfResults.Lines.Count - 1
            RtfResults.SelectionStart = RtfResults.GetFirstCharIndexFromLine(X)
            RtfResults.SelectionLength = RtfResults.Lines(X).Length
            If InStr(RtfResults.Lines(X), "(CORRECT)") Then
                RtfResults.SelectionColor = Color.Green
            ElseIf InStr(RtfResults.Lines(X), "(INCORRECT)") Then
                RtfResults.SelectionColor = Color.Red
            ElseIf InStr(RtfResults.Lines(X), "Total Questions:") Or
                InStr(RtfResults.Lines(X), "Correct Answers:") Or
                InStr(RtfResults.Lines(X), "Incorrect Answers:") Or
                InStr(RtfResults.Lines(X), "Percent Correct:") Then
                RtfResults.SelectionColor = Color.Blue
            Else
                RtfResults.SelectionColor = Color.Black
            End If
        Next

    End Sub
End Class