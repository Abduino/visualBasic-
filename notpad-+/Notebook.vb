Public Class frm1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWToolStripMenuItem.Click
        If rtxt.Text <> "" Then
            MessageBox.Show("Do you want to save the file", "notepad", MessageBoxButtons.YesNo, MessageBoxIcon.None)
            If DialogResult.Yes Then
                SaveFileDialog1.ShowDialog()


            Else
                rtxt.Clear()

            End If
        End If

    End Sub

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        Try
            Dim a As OpenFileDialog = New OpenFileDialog
            a.Title = "open"
            a.Filter = "rich text file|*.rtf"
            If a.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                rtxt.LoadFile(a.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        Try
            Dim a As SaveFileDialog = New SaveFileDialog
            a.Title = "save"
            a.Filter = "rich text file|*.rtf"
            If a.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                rtxt.SaveFile(a.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SAVEASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEASToolStripMenuItem.Click
        Try
            Dim a As SaveFileDialog = New SaveFileDialog
            a.Title = "save"
            a.Filter = "rich text file|*.rtf"
            If a.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                rtxt.SaveFile(a.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub PRINTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRINTToolStripMenuItem.Click
        PrintDialog1.ShowDialog()

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub UNDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UNDOToolStripMenuItem.Click
        If rtxt.CanUndo Then

            rtxt.Undo()

        End If


    End Sub

    Private Sub REDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REDOToolStripMenuItem.Click
        rtxt.Redo()

    End Sub

    Private Sub CUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUTToolStripMenuItem.Click
        rtxt.Cut()

    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click

    End Sub

    Private Sub COPYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COPYToolStripMenuItem.Click
        rtxt.Copy()

    End Sub

    Private Sub PASTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PASTEToolStripMenuItem.Click
        rtxt.Paste()

    End Sub

    Private Sub SELECTALLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTALLToolStripMenuItem.Click
        rtxt.SelectAll()

    End Sub

    Private Sub FONTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FONTToolStripMenuItem.Click
        Try
            Dim a As FontDialog = New FontDialog
            a.Font = rtxt.Font
            If a.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                rtxt.Font = a.Font
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub COLORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLORToolStripMenuItem.Click
        Try
            Dim a As ColorDialog = New ColorDialog
            a.Color = rtxt.ForeColor
            If a.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                rtxt.ForeColor = a.Color
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ABOUTNOTPADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTNOTPADToolStripMenuItem.Click
        zContact.Show()



    End Sub

    Private Sub HELPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HELPToolStripMenuItem.Click

    End Sub

    Private Sub rtxt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FILEToolStripMenuItem.Click

    End Sub

    Private Sub EDITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub WORDWRAPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WORDWRAPToolStripMenuItem.Click
        If WORDWRAPToolStripMenuItem.CheckOnClick Then
            rtxt.WordWrap = True
        Else
            rtxt.WordWrap = False
        End If
    End Sub

    Private Sub PAGESETUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PAGESETUPToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub FINDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FINDToolStripMenuItem.Click
        Dim a As String
        Dim b As String

        a = InputBox("Enter text to be found")
        b = InStr(rtxt.Text, a)

        If b Then

            rtxt.Focus()
            rtxt.SelectionStart = b - 1
            rtxt.SelectionLength = Len(a)
        Else

            MsgBox("Text not found.")
        End If

    End Sub

    Private Sub GOTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GOTOToolStripMenuItem.Click
        Dim input As String = InputBox("Enter a Number between 1 and" & rtxt.Lines.Length & " to goto that postion", " Select At ", rtxt.SelectionStart)

        If IsNumeric(input) AndAlso input <= rtxt.Lines.Length AndAlso input > 0 Then
            rtxt.SelectionStart = rtxt.GetFirstCharIndexFromLine(input - 1)
            rtxt.ScrollToCaret()
        End If
    End Sub

    Private Sub TIMEDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TIMEDATEToolStripMenuItem.Click
        Dim h As String = My.Computer.Clock.LocalTime.Hour
        Dim m As String = My.Computer.Clock.LocalTime.Minute
        Dim d As String = My.Computer.Clock.LocalTime.Date
        If m < 10 Then m = "0" + m
        If h > 12 Then h = h - 12
        Dim time As String = h + ":" + m
        If h > 12 Then time = time + "AM"
        If h < 12 Then time = time + "PM"
        rtxt.Text = rtxt.Text + time + "," + d

    End Sub
End Class
