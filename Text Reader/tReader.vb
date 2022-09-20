Public Class tReader

   
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.SPVOICE")
        SAPI.SPEAK(txtRead.Text)
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRead.Clear()
        txtGet.Clear()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ProgressBar1.Value = 0
        OpenFileDialog1.ShowDialog()

        txtGet.Text = OpenFileDialog1.FileName
        If System.IO.File.Exists(txtGet.Text) = True Then
            For X As Integer = 1 To 100

                ProgressBar1.Value = ProgressBar1.Value + 1
            Next
            Dim objreader As New System.IO.StreamReader(txtGet.Text)
            txtRead.Text = objreader.ReadToEnd
            objreader.Close()
        End If

    End Sub

    Private Sub btnRead_MouseHover(sender As Object, e As EventArgs) Handles btnRead.MouseHover
        Dim SAPI
        SAPI = CreateObject("SAPI.SPVOICE")
        SAPI.SPEAK(btnRead.Text)

    End Sub

    Private Sub btnBrowse_MouseHover(sender As Object, e As EventArgs) Handles btnBrowse.MouseHover
        Dim SAPI
        SAPI = CreateObject("SAPI.SPVOICE")
        SAPI.SPEAK(btnBrowse.Text)
    End Sub

 

    Private Sub btnClear_MouseHover(sender As Object, e As EventArgs) Handles btnClear.MouseHover
        Dim SAPI
        SAPI = CreateObject("SAPI.SPVOICE")
        SAPI.SPEAK(btnClear.Text)
    End Sub



   
    Private Sub tReader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim SAPI
        SAPI = CreateObject("SAPI.SPVOICE")
        SAPI.SPEAK("the program is shuting down")
    End Sub




    Private Sub tReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SAPI
        SAPI = CreateObject("SAPI.SPVOICE")
        SAPI.SPEAK("well come to T reader")
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click



    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Dim SAPI
        SAPI = CreateObject("SAPI.SPVOICE")
        SAPI.SPEAK("close the program")
    End Sub
End Class
