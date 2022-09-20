<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAGESETUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRINTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UNDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PASTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELECTALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FINDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GOTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TIMEDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FORMATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WORDWRAPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FONTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COLORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STATUSBARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWHELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTNOTPADToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.rtxt = New System.Windows.Forms.RichTextBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Menu
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.EDITToolStripMenuItem, Me.FORMATToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(662, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NEWToolStripMenuItem, Me.OPENToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.SAVEASToolStripMenuItem, Me.PAGESETUPToolStripMenuItem, Me.PRINTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "&FILE"
        '
        'NEWToolStripMenuItem
        '
        Me.NEWToolStripMenuItem.Name = "NEWToolStripMenuItem"
        Me.NEWToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NEWToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NEWToolStripMenuItem.Text = "&NEW"
        '
        'OPENToolStripMenuItem
        '
        Me.OPENToolStripMenuItem.Name = "OPENToolStripMenuItem"
        Me.OPENToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OPENToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OPENToolStripMenuItem.Text = "&OPEN"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SAVEToolStripMenuItem.Text = "&SAVE"
        '
        'SAVEASToolStripMenuItem
        '
        Me.SAVEASToolStripMenuItem.Name = "SAVEASToolStripMenuItem"
        Me.SAVEASToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SAVEASToolStripMenuItem.Text = "SAVE AS.."
        '
        'PAGESETUPToolStripMenuItem
        '
        Me.PAGESETUPToolStripMenuItem.Name = "PAGESETUPToolStripMenuItem"
        Me.PAGESETUPToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PAGESETUPToolStripMenuItem.Text = "PAGE SETUP"
        '
        'PRINTToolStripMenuItem
        '
        Me.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem"
        Me.PRINTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PRINTToolStripMenuItem.Text = "&PRINT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EXITToolStripMenuItem.Text = "E&XIT"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UNDOToolStripMenuItem, Me.REDOToolStripMenuItem, Me.CUTToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.COPYToolStripMenuItem, Me.PASTEToolStripMenuItem, Me.SELECTALLToolStripMenuItem, Me.FINDToolStripMenuItem, Me.GOTOToolStripMenuItem, Me.TIMEDATEToolStripMenuItem})
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.EDITToolStripMenuItem.Text = "&EDIT"
        '
        'UNDOToolStripMenuItem
        '
        Me.UNDOToolStripMenuItem.Name = "UNDOToolStripMenuItem"
        Me.UNDOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UNDOToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UNDOToolStripMenuItem.Text = "&UNDO"
        '
        'REDOToolStripMenuItem
        '
        Me.REDOToolStripMenuItem.Name = "REDOToolStripMenuItem"
        Me.REDOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.REDOToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.REDOToolStripMenuItem.Text = "&REDO"
        '
        'CUTToolStripMenuItem
        '
        Me.CUTToolStripMenuItem.Name = "CUTToolStripMenuItem"
        Me.CUTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CUTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CUTToolStripMenuItem.Text = "CU&T"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DELETEToolStripMenuItem.Text = "&DELETE"
        '
        'COPYToolStripMenuItem
        '
        Me.COPYToolStripMenuItem.Name = "COPYToolStripMenuItem"
        Me.COPYToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.COPYToolStripMenuItem.Text = "&COPY"
        '
        'PASTEToolStripMenuItem
        '
        Me.PASTEToolStripMenuItem.Name = "PASTEToolStripMenuItem"
        Me.PASTEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PASTEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PASTEToolStripMenuItem.Text = "P&ASTE"
        '
        'SELECTALLToolStripMenuItem
        '
        Me.SELECTALLToolStripMenuItem.Name = "SELECTALLToolStripMenuItem"
        Me.SELECTALLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SELECTALLToolStripMenuItem.Text = "S&ELECT ALL"
        '
        'FINDToolStripMenuItem
        '
        Me.FINDToolStripMenuItem.Name = "FINDToolStripMenuItem"
        Me.FINDToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FINDToolStripMenuItem.Text = "FIND"
        '
        'GOTOToolStripMenuItem
        '
        Me.GOTOToolStripMenuItem.Name = "GOTOToolStripMenuItem"
        Me.GOTOToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GOTOToolStripMenuItem.Text = "GOTO"
        '
        'TIMEDATEToolStripMenuItem
        '
        Me.TIMEDATEToolStripMenuItem.Name = "TIMEDATEToolStripMenuItem"
        Me.TIMEDATEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TIMEDATEToolStripMenuItem.Text = "TIME/DATE"
        '
        'FORMATToolStripMenuItem
        '
        Me.FORMATToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WORDWRAPToolStripMenuItem, Me.FONTToolStripMenuItem, Me.COLORToolStripMenuItem})
        Me.FORMATToolStripMenuItem.Name = "FORMATToolStripMenuItem"
        Me.FORMATToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.FORMATToolStripMenuItem.Text = "F&ORMAT"
        '
        'WORDWRAPToolStripMenuItem
        '
        Me.WORDWRAPToolStripMenuItem.Checked = True
        Me.WORDWRAPToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WORDWRAPToolStripMenuItem.Name = "WORDWRAPToolStripMenuItem"
        Me.WORDWRAPToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.WORDWRAPToolStripMenuItem.Text = "WORD WRAP"
        '
        'FONTToolStripMenuItem
        '
        Me.FONTToolStripMenuItem.Name = "FONTToolStripMenuItem"
        Me.FONTToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FONTToolStripMenuItem.Text = "FONT"
        '
        'COLORToolStripMenuItem
        '
        Me.COLORToolStripMenuItem.Name = "COLORToolStripMenuItem"
        Me.COLORToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.COLORToolStripMenuItem.Text = "COLOR"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STATUSBARToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "&VIEW"
        '
        'STATUSBARToolStripMenuItem
        '
        Me.STATUSBARToolStripMenuItem.Name = "STATUSBARToolStripMenuItem"
        Me.STATUSBARToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.STATUSBARToolStripMenuItem.Text = "STATUS BAR"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWHELPToolStripMenuItem, Me.ABOUTNOTPADToolStripMenuItem})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HELPToolStripMenuItem.Text = "&HELP"
        '
        'VIEWHELPToolStripMenuItem
        '
        Me.VIEWHELPToolStripMenuItem.Name = "VIEWHELPToolStripMenuItem"
        Me.VIEWHELPToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.VIEWHELPToolStripMenuItem.Text = "VIEW HELP"
        '
        'ABOUTNOTPADToolStripMenuItem
        '
        Me.ABOUTNOTPADToolStripMenuItem.Name = "ABOUTNOTPADToolStripMenuItem"
        Me.ABOUTNOTPADToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ABOUTNOTPADToolStripMenuItem.Text = "ABOUT NOTPAD-+"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'rtxt
        '
        Me.rtxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxt.Location = New System.Drawing.Point(0, 24)
        Me.rtxt.Name = "rtxt"
        Me.rtxt.Size = New System.Drawing.Size(662, 393)
        Me.rtxt.TabIndex = 2
        Me.rtxt.Text = ""
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frm1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(662, 417)
        Me.Controls.Add(Me.rtxt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Notebook"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Silver
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPENToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAVEASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRINTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UNDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COPYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PASTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SELECTALLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FORMATToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WORDWRAPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FONTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STATUSBARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWHELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTNOTPADToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents COLORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtxt As System.Windows.Forms.RichTextBox
    Friend WithEvents PAGESETUPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FINDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GOTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents TIMEDATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
