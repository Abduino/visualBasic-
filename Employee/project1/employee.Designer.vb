<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employee))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpd = New System.Windows.Forms.DateTimePicker()
        Me.cbog = New System.Windows.Forms.ComboBox()
        Me.txtJ = New System.Windows.Forms.TextBox()
        Me.txti = New System.Windows.Forms.TextBox()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblJobtype = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.txtSa = New System.Windows.Forms.TextBox()
        Me.lblSal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lblSid = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblsalary = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.txtJob = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.lblSdate = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblJob = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btne = New System.Windows.Forms.Button()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(91, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(465, 24)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome  To HU Employee Managment sysytem"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(585, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modify"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btne)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.dtpd)
        Me.GroupBox2.Controls.Add(Me.cbog)
        Me.GroupBox2.Controls.Add(Me.txtJ)
        Me.GroupBox2.Controls.Add(Me.txti)
        Me.GroupBox2.Controls.Add(Me.txtF)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblJobtype)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtL)
        Me.GroupBox2.Controls.Add(Me.txtSa)
        Me.GroupBox2.Controls.Add(Me.lblSal)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 284)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modify Employee profile "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(486, 284)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'dtpd
        '
        Me.dtpd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpd.Location = New System.Drawing.Point(109, 214)
        Me.dtpd.Name = "dtpd"
        Me.dtpd.Size = New System.Drawing.Size(230, 29)
        Me.dtpd.TabIndex = 16
        '
        'cbog
        '
        Me.cbog.FormattingEnabled = True
        Me.cbog.Items.AddRange(New Object() {"Female", "Male"})
        Me.cbog.Location = New System.Drawing.Point(109, 176)
        Me.cbog.Name = "cbog"
        Me.cbog.Size = New System.Drawing.Size(230, 32)
        Me.cbog.TabIndex = 15
        Me.cbog.Text = "select"
        '
        'txtJ
        '
        Me.txtJ.Location = New System.Drawing.Point(109, 141)
        Me.txtJ.Name = "txtJ"
        Me.txtJ.Size = New System.Drawing.Size(230, 29)
        Me.txtJ.TabIndex = 14
        '
        'txti
        '
        Me.txti.Location = New System.Drawing.Point(109, 106)
        Me.txti.Name = "txti"
        Me.txti.Size = New System.Drawing.Size(230, 29)
        Me.txti.TabIndex = 13
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(109, 36)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(230, 29)
        Me.txtF.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(356, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 33)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(356, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 39)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Start date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Gender"
        '
        'lblJobtype
        '
        Me.lblJobtype.AutoSize = True
        Me.lblJobtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobtype.Location = New System.Drawing.Point(6, 150)
        Me.lblJobtype.Name = "lblJobtype"
        Me.lblJobtype.Size = New System.Drawing.Size(74, 20)
        Me.lblJobtype.TabIndex = 7
        Me.lblJobtype.Text = "Job_type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 20)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 20)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Fname"
        '
        'txtL
        '
        Me.txtL.Location = New System.Drawing.Point(109, 71)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(230, 29)
        Me.txtL.TabIndex = 20
        '
        'txtSa
        '
        Me.txtSa.Location = New System.Drawing.Point(109, 249)
        Me.txtSa.Name = "txtSa"
        Me.txtSa.Size = New System.Drawing.Size(230, 29)
        Me.txtSa.TabIndex = 21
        '
        'lblSal
        '
        Me.lblSal.AutoSize = True
        Me.lblSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSal.Location = New System.Drawing.Point(8, 254)
        Me.lblSal.Name = "lblSal"
        Me.lblSal.Size = New System.Drawing.Size(53, 20)
        Me.lblSal.TabIndex = 19
        Me.lblSal.Text = "Salary"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Lname"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Controls.Add(Me.lblSid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search by ID"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(356, 34)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 26)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(131, 31)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(219, 29)
        Me.txtsearch.TabIndex = 1
        '
        'lblSid
        '
        Me.lblSid.AutoSize = True
        Me.lblSid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSid.Location = New System.Drawing.Point(25, 40)
        Me.lblSid.Name = "lblSid"
        Me.lblSid.Size = New System.Drawing.Size(100, 20)
        Me.lblSid.TabIndex = 0
        Me.lblSid.Text = "Employee ID"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage1.Controls.Add(Me.txtLname)
        Me.TabPage1.Controls.Add(Me.lblLname)
        Me.TabPage1.Controls.Add(Me.txtSalary)
        Me.TabPage1.Controls.Add(Me.lblsalary)
        Me.TabPage1.Controls.Add(Me.btnLogout)
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.dtpdate)
        Me.TabPage1.Controls.Add(Me.cbogender)
        Me.TabPage1.Controls.Add(Me.txtJob)
        Me.TabPage1.Controls.Add(Me.txtid)
        Me.TabPage1.Controls.Add(Me.txtFname)
        Me.TabPage1.Controls.Add(Me.lblSdate)
        Me.TabPage1.Controls.Add(Me.lblGender)
        Me.TabPage1.Controls.Add(Me.lblJob)
        Me.TabPage1.Controls.Add(Me.lblId)
        Me.TabPage1.Controls.Add(Me.lblFname)
        Me.TabPage1.Controls.Add(Me.ShapeContainer1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(585, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registration"
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(127, 77)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(254, 26)
        Me.txtLname.TabIndex = 24
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(17, 83)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(63, 20)
        Me.lblLname.TabIndex = 23
        Me.lblLname.Text = "Lname"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(127, 319)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(254, 26)
        Me.txtSalary.TabIndex = 20
        '
        'lblsalary
        '
        Me.lblsalary.AutoSize = True
        Me.lblsalary.Location = New System.Drawing.Point(17, 325)
        Me.lblsalary.Name = "lblsalary"
        Me.lblsalary.Size = New System.Drawing.Size(80, 20)
        Me.lblsalary.TabIndex = 19
        Me.lblsalary.Text = "SALARY"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(405, 319)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(156, 26)
        Me.btnLogout.TabIndex = 12
        Me.btnLogout.Text = "EXIT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(405, 31)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(156, 29)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(405, 77)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(156, 221)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "ADD EMPLOYEE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtpdate
        '
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdate.Location = New System.Drawing.Point(127, 273)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(254, 26)
        Me.dtpdate.TabIndex = 9
        '
        'cbogender
        '
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cbogender.Location = New System.Drawing.Point(127, 224)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(254, 28)
        Me.cbogender.TabIndex = 8
        Me.cbogender.Text = "select"
        '
        'txtJob
        '
        Me.txtJob.Location = New System.Drawing.Point(127, 173)
        Me.txtJob.Name = "txtJob"
        Me.txtJob.Size = New System.Drawing.Size(254, 26)
        Me.txtJob.TabIndex = 7
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(127, 127)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(254, 26)
        Me.txtid.TabIndex = 6
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(127, 29)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(254, 26)
        Me.txtFname.TabIndex = 5
        '
        'lblSdate
        '
        Me.lblSdate.AutoSize = True
        Me.lblSdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSdate.Location = New System.Drawing.Point(17, 278)
        Me.lblSdate.Name = "lblSdate"
        Me.lblSdate.Size = New System.Drawing.Size(95, 20)
        Me.lblSdate.TabIndex = 4
        Me.lblSdate.Text = "Start_date"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(17, 232)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(69, 20)
        Me.lblGender.TabIndex = 3
        Me.lblGender.Text = "Gender"
        '
        'lblJob
        '
        Me.lblJob.AutoSize = True
        Me.lblJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJob.Location = New System.Drawing.Point(17, 179)
        Me.lblJob.Name = "lblJob"
        Me.lblJob.Size = New System.Drawing.Size(77, 20)
        Me.lblJob.TabIndex = 2
        Me.lblJob.Text = "Job type"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(17, 133)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(71, 20)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "Number"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.Location = New System.Drawing.Point(17, 35)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(64, 20)
        Me.lblFname.TabIndex = 0
        Me.lblFname.Text = "Fname"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(579, 395)
        Me.ShapeContainer1.TabIndex = 22
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(11, 5)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(557, 348)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 47)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(593, 427)
        Me.TabControl1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btne
        '
        Me.btne.Location = New System.Drawing.Point(369, 223)
        Me.btne.Name = "btne"
        Me.btne.Size = New System.Drawing.Size(102, 51)
        Me.btne.TabIndex = 2
        Me.btne.Text = "Exit"
        Me.btne.UseVisualStyleBackColor = True
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(621, 486)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "employee"
        Me.Text = "employee registration"
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblSdate As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblJob As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents txtJob As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblJobtype As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSid As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dtpd As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbog As System.Windows.Forms.ComboBox
    Friend WithEvents txtJ As System.Windows.Forms.TextBox
    Friend WithEvents txti As System.Windows.Forms.TextBox
    Friend WithEvents txtF As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents lblsalary As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents txtSa As System.Windows.Forms.TextBox
    Friend WithEvents txtL As System.Windows.Forms.TextBox
    Friend WithEvents lblSal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btne As System.Windows.Forms.Button
End Class
