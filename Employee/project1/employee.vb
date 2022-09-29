Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class employee
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        frmLogin.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dtemp.Clear()
        Try
            Dim strselectemployee As String = "Select * FROM employee where Number='" & txtid.Text & "'"
            Dim daemploylee As New SqlDataAdapter(strselectemployee, conn)
            conn.Open()
            daemploylee.Fill(dsemp, "studenttable")
            conn.Close()
            dtemp = dsemp.Tables("studenttable")
            row = dtemp.Rows.Count
            If row = 0 Then
                Dim cmdInsert As New SqlCommand
                cmdInsert.CommandText = "INSERT INTO employee(Fname, Lname, Number, Job_type, gender, Start_date ,salary) VALUES ('" & txtFname.Text & "','" & txtLname.Text & "','" & txtid.Text & "', '" & txtJob.Text & "','" & cbogender.Text & "', '" & CDate(dtpdate.Text) & "','" & txtSalary.Text & "')"
                cmdInsert.CommandType = CommandType.Text
                cmdInsert.Connection = conn
                daemp.InsertCommand = cmdInsert
                conn.Open()
                cmdInsert.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("' " & txtFname.Text & "' is registered successfully", "Informing", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("The student is allready exist,duplication is not allowed!", "Informing", MessageBoxButtons.OK)
                If DialogResult.OK Then
                    txtFname.Text = ""
                    txtLname.Text = ""
                    txtid.Text = ""
                    txtJob.Text = ""
                    cbogender.Text = ""
                    dtpdate.Text = ""
                    txtSalary.Text = ""
                    txtFname.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dtemp.Clear()
        Try
            Dim strselectempm As String = "Select * FROM employee where number='" & txtsearch.Text & "'"
            Dim damemp As New SqlDataAdapter(strselectempm, conn)
            conn.Open()
            damemp.Fill(dsemp, "updateStudentTable")
            conn.Close()
            dtemp = dsemp.Tables("updateStudentTable")
            row = dtemp.Rows.Count
            If row > 0 Then
                txtF.Text = Convert.ToString(dtemp.Rows(0)(0))
                txtL.Text = Convert.ToString(dtemp.Rows(0)(1))
                txti.Text = Convert.ToString(dtemp.Rows(0)(2))
                txtJ.Text = Convert.ToString(dtemp.Rows(0)(3))
                cbog.Text = Convert.ToString(dtemp.Rows(0)(4))
                dtpd.Text = Convert.ToString(dtemp.Rows(0)(5))
                txtSa.Text = Convert.ToString(dtemp.Rows(0)(6))
                GroupBox2.Visible = True
                PictureBox1.Visible = False
            Else
                MessageBox.Show("There is no student with Id number ' " & txtsearch.Text & "' in the database", "Informing", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dtemp.Clear()
        Try
            Dim cmdUpdate As New SqlCommand
            cmdUpdate.CommandText = "UPDATE employee SET Fname='" & txtF.Text & "',Lname='" & txtL.Text & "', Number='" & txti.Text & "', Job_type='" & txtJ.Text & "', gender='" & cbog.Text & "', Start_date='" & CDate(dtpd.Text) & "',Salary='" & txtSa.Text & "' where Number='" & txtsearch.Text & "'"
            cmdUpdate.CommandType = CommandType.Text
            cmdUpdate.Connection = conn
            daemp.UpdateCommand = cmdUpdate
            conn.Open()
            cmdUpdate.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("modification on '" & txtF.Text & "' is compelete successfully!", "informing success of modification", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            MessageBox.Show("Are you sure you want to delete employeee with id number ' " & txtsearch.Text & "'?", "warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If DialogResult.Yes Then
                Dim cmdDelete As New SqlCommand
                cmdDelete.CommandText = "DELETE FROM employee WHERE id='" & txtsearch.Text & "'"
                cmdDelete.CommandType = CommandType.Text
                cmdDelete.Connection = conn
                daemp.DeleteCommand = cmdDelete
                conn.Open()
                cmdDelete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Deleted successfully !", "Informing", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If DialogResult.OK Then
                    GroupBox2.Visible = False
                    txtsearch.Text = ""
                    PictureBox1.Visible = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFname.Clear()
        txtLname.Clear()
        txtid.Clear()
        txtJob.Clear()
        txtSalary.Clear()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btne.Click
        Me.Close()

    End Sub
End Class