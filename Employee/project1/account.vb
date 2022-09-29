Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Module connect
    Public conn As New SqlConnection("Data Source=ABDREHMAN-PC;Initial Catalog=hu;Integrated Security=True")
    ' making account table connection publuic 
    Public dslogin As New DataSet
    Public strSelectaccount As String = "Select * FROM account"
    Public dalogin As New SqlDataAdapter(strSelectaccount, conn)
    Public dtlogin As New DataTable
    ' making employeee table connection publuic 
    Public dsemp As New DataSet
    Public strSelectemployee As String = "Select * FROM employee"
    Public daemp As New SqlDataAdapter(strSelectemployee, conn)
    Public dtemp As New DataTable
    Public row As Integer
End Module
Public Class frmLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Hide()
        lblload.Hide()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUserName.Text <> "" Then
                If txtPassword.Text <> "" Then
                    strSelectaccount = "select * from account where username='" & txtUserName.Text & "' and password='" & txtPassword.Text & "'"
                    Dim dalogin As New SqlDataAdapter(strSelectaccount, conn)
                    conn.Open()
                    dalogin.Fill(dslogin, "accounttable")
                    conn.Close()
                    dtlogin = dslogin.Tables("accounttable")
                    row = dtlogin.Rows.Count
                    If row > 0 Then
                        Timer1.Start()
                        lblload.Show()
                        ProgressBar1.Show()
                    Else
                        MessageBox.Show("User name or Password is Incorrect!", "Infoming", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        If DialogResult.OK Then
                            txtUserName.Text = ""
                            txtPassword.Text = ""
                            txtUserName.Focus()
                        End If
                    End If
                Else
                    MessageBox.Show("Password is required", "Informing", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    If DialogResult.OK Then
                        txtPassword.Focus()
                    End If
                End If
            Else
                MessageBox.Show("User Name is required", "Informing", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If DialogResult.OK Then
                    txtUserName.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtUserName.Focus()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            txtUserName.Clear()
            txtPassword.Clear()
            ProgressBar1.Hide()
            lblload.Hide()
            employee.Show()
        End If
    End Sub
End Class
