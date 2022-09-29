Public Class fTimer
    Dim x As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If txt3.Text <> 60 Then
            txt3.Text = txt3.Text + 1
        Else
            txt3.Text = 0
            If txt2.Text <> 60 Then
                txt2.Text = txt2.Text + 1
            Else
                txt2.Text = 0
                If txt1.Text <> 60 Then
                    txt1.Text = txt1.Text + 1
                Else
                    txt1.Text = 0
                    If txt0.Text <> 60 Then
                        txt0.Text = txt0.Text + 1
                    Else
                        txt0.Text = 0
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
        Timer1.Interval = 20

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Timer1.Stop()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSpeak.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.SPVOICE")
        SAPI.SPEAK("THE TIME IS    " & txt0.Text & "time and" & txt1.Text & " minute and" & txt2.Text & "second and" & txt3.Text & "micro second")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        X = X + 1
        ListBox1.Items.Add(x & "," & txt0.Text & ":" & txt1.Text & ":" & txt2.Text & ":" & txt3.Text)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txt0.Text = "00"
        txt1.Text = "00"
        txt2.Text = "00"
        txt3.Text = "00"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
