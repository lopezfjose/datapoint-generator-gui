﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.txtXValue = New System.Windows.Forms.TextBox()
        Me.txtYValue = New System.Windows.Forms.TextBox()
        Me.gbBulkGenerator = New System.Windows.Forms.GroupBox()
        Me.gbBulkOptions = New System.Windows.Forms.GroupBox()
        Me.lblMagnitude = New System.Windows.Forms.Label()
        Me.numMagnitude = New System.Windows.Forms.NumericUpDown()
        Me.lblMinimumMantissa = New System.Windows.Forms.Label()
        Me.numMinMantissa = New System.Windows.Forms.NumericUpDown()
        Me.cbAllowNegatives = New System.Windows.Forms.CheckBox()
        Me.cbCommaDelimiters = New System.Windows.Forms.CheckBox()
        Me.btnBulkGenerate = New System.Windows.Forms.Button()
        Me.txtIterations = New System.Windows.Forms.TextBox()
        Me.lblBulkGenerate = New System.Windows.Forms.Label()
        Me.btnAddDatapoint = New System.Windows.Forms.Button()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.btnSetUsername = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.gbFileOperations = New System.Windows.Forms.GroupBox()
        Me.btnCreateFile = New System.Windows.Forms.Button()
        Me.cbPromptToSaveOnExit = New System.Windows.Forms.CheckBox()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.txtOutputFileName = New System.Windows.Forms.TextBox()
        Me.lblOutputFileName = New System.Windows.Forms.Label()
        Me.sfdSaveDataset = New System.Windows.Forms.SaveFileDialog()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.btnUseConsole = New System.Windows.Forms.Button()
        Me.ttMagnitude = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttMantissa = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbSystem = New System.Windows.Forms.GroupBox()
        Me.gbProcesses = New System.Windows.Forms.GroupBox()
        Me.lbProcessList = New System.Windows.Forms.ListBox()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.statusstripMain_lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnOpenCmd = New System.Windows.Forms.Button()
        Me.btnPurgeProcesses = New System.Windows.Forms.Button()
        Me.lblProcessName = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblProcessID = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.processController = New System.Diagnostics.Process()
        Me.btnProcessController = New System.Windows.Forms.Button()
        Me.Process1 = New System.Diagnostics.Process()
        Me.gbBulkGenerator.SuspendLayout()
        Me.gbBulkOptions.SuspendLayout()
        CType(Me.numMagnitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinMantissa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSettings.SuspendLayout()
        Me.gbFileOperations.SuspendLayout()
        Me.gbSystem.SuspendLayout()
        Me.gbProcesses.SuspendLayout()
        Me.statusstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblX
        '
        Me.lblX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(12, 9)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(14, 13)
        Me.lblX.TabIndex = 0
        Me.lblX.Text = "X"
        '
        'lblY
        '
        Me.lblY.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(12, 35)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(14, 13)
        Me.lblY.TabIndex = 1
        Me.lblY.Text = "Y"
        '
        'txtXValue
        '
        Me.txtXValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtXValue.Location = New System.Drawing.Point(57, 6)
        Me.txtXValue.Name = "txtXValue"
        Me.txtXValue.Size = New System.Drawing.Size(100, 20)
        Me.txtXValue.TabIndex = 2
        Me.txtXValue.Text = "0.00"
        '
        'txtYValue
        '
        Me.txtYValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtYValue.Location = New System.Drawing.Point(57, 32)
        Me.txtYValue.Name = "txtYValue"
        Me.txtYValue.Size = New System.Drawing.Size(100, 20)
        Me.txtYValue.TabIndex = 3
        Me.txtYValue.Text = "0.00"
        '
        'gbBulkGenerator
        '
        Me.gbBulkGenerator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbBulkGenerator.Controls.Add(Me.btnProcessController)
        Me.gbBulkGenerator.Controls.Add(Me.gbBulkOptions)
        Me.gbBulkGenerator.Controls.Add(Me.btnBulkGenerate)
        Me.gbBulkGenerator.Controls.Add(Me.txtIterations)
        Me.gbBulkGenerator.Controls.Add(Me.lblBulkGenerate)
        Me.gbBulkGenerator.Location = New System.Drawing.Point(163, 6)
        Me.gbBulkGenerator.Name = "gbBulkGenerator"
        Me.gbBulkGenerator.Size = New System.Drawing.Size(228, 371)
        Me.gbBulkGenerator.TabIndex = 4
        Me.gbBulkGenerator.TabStop = False
        Me.gbBulkGenerator.Text = "Bulk Generator"
        '
        'gbBulkOptions
        '
        Me.gbBulkOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBulkOptions.Controls.Add(Me.lblMagnitude)
        Me.gbBulkOptions.Controls.Add(Me.numMagnitude)
        Me.gbBulkOptions.Controls.Add(Me.lblMinimumMantissa)
        Me.gbBulkOptions.Controls.Add(Me.numMinMantissa)
        Me.gbBulkOptions.Controls.Add(Me.cbAllowNegatives)
        Me.gbBulkOptions.Controls.Add(Me.cbCommaDelimiters)
        Me.gbBulkOptions.Location = New System.Drawing.Point(9, 210)
        Me.gbBulkOptions.Name = "gbBulkOptions"
        Me.gbBulkOptions.Size = New System.Drawing.Size(214, 123)
        Me.gbBulkOptions.TabIndex = 3
        Me.gbBulkOptions.TabStop = False
        Me.gbBulkOptions.Text = "Bulk Generation Options"
        '
        'lblMagnitude
        '
        Me.lblMagnitude.AutoSize = True
        Me.lblMagnitude.Location = New System.Drawing.Point(113, 62)
        Me.lblMagnitude.Name = "lblMagnitude"
        Me.lblMagnitude.Size = New System.Drawing.Size(57, 13)
        Me.lblMagnitude.TabIndex = 5
        Me.lblMagnitude.Text = "Magnitude"
        '
        'numMagnitude
        '
        Me.numMagnitude.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numMagnitude.Location = New System.Drawing.Point(108, 78)
        Me.numMagnitude.Name = "numMagnitude"
        Me.numMagnitude.Size = New System.Drawing.Size(100, 20)
        Me.numMagnitude.TabIndex = 4
        Me.ttMagnitude.SetToolTip(Me.numMagnitude, resources.GetString("numMagnitude.ToolTip"))
        Me.numMagnitude.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblMinimumMantissa
        '
        Me.lblMinimumMantissa.AutoSize = True
        Me.lblMinimumMantissa.Location = New System.Drawing.Point(6, 62)
        Me.lblMinimumMantissa.Name = "lblMinimumMantissa"
        Me.lblMinimumMantissa.Size = New System.Drawing.Size(93, 13)
        Me.lblMinimumMantissa.TabIndex = 3
        Me.lblMinimumMantissa.Text = "Minimum Mantissa"
        '
        'numMinMantissa
        '
        Me.numMinMantissa.Location = New System.Drawing.Point(6, 78)
        Me.numMinMantissa.Name = "numMinMantissa"
        Me.numMinMantissa.Size = New System.Drawing.Size(100, 20)
        Me.numMinMantissa.TabIndex = 2
        Me.ttMantissa.SetToolTip(Me.numMinMantissa, resources.GetString("numMinMantissa.ToolTip"))
        Me.numMinMantissa.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'cbAllowNegatives
        '
        Me.cbAllowNegatives.AutoSize = True
        Me.cbAllowNegatives.ForeColor = System.Drawing.Color.Red
        Me.cbAllowNegatives.Location = New System.Drawing.Point(21, 42)
        Me.cbAllowNegatives.Name = "cbAllowNegatives"
        Me.cbAllowNegatives.Size = New System.Drawing.Size(102, 17)
        Me.cbAllowNegatives.TabIndex = 1
        Me.cbAllowNegatives.Text = "Allow Negatives"
        Me.cbAllowNegatives.UseVisualStyleBackColor = True
        '
        'cbCommaDelimiters
        '
        Me.cbCommaDelimiters.AutoSize = True
        Me.cbCommaDelimiters.Checked = True
        Me.cbCommaDelimiters.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCommaDelimiters.Location = New System.Drawing.Point(21, 19)
        Me.cbCommaDelimiters.Name = "cbCommaDelimiters"
        Me.cbCommaDelimiters.Size = New System.Drawing.Size(131, 17)
        Me.cbCommaDelimiters.TabIndex = 0
        Me.cbCommaDelimiters.Text = "Use Comma Delimiters"
        Me.cbCommaDelimiters.UseVisualStyleBackColor = True
        '
        'btnBulkGenerate
        '
        Me.btnBulkGenerate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBulkGenerate.Location = New System.Drawing.Point(9, 339)
        Me.btnBulkGenerate.Name = "btnBulkGenerate"
        Me.btnBulkGenerate.Size = New System.Drawing.Size(213, 26)
        Me.btnBulkGenerate.TabIndex = 2
        Me.btnBulkGenerate.Text = "Bulk Generate"
        Me.btnBulkGenerate.UseVisualStyleBackColor = True
        '
        'txtIterations
        '
        Me.txtIterations.Location = New System.Drawing.Point(6, 32)
        Me.txtIterations.Name = "txtIterations"
        Me.txtIterations.Size = New System.Drawing.Size(100, 20)
        Me.txtIterations.TabIndex = 1
        Me.txtIterations.Text = "0"
        '
        'lblBulkGenerate
        '
        Me.lblBulkGenerate.AutoSize = True
        Me.lblBulkGenerate.Location = New System.Drawing.Point(6, 16)
        Me.lblBulkGenerate.Name = "lblBulkGenerate"
        Me.lblBulkGenerate.Size = New System.Drawing.Size(155, 13)
        Me.lblBulkGenerate.TabIndex = 0
        Me.lblBulkGenerate.Text = "Generate N random data points"
        '
        'btnAddDatapoint
        '
        Me.btnAddDatapoint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddDatapoint.Location = New System.Drawing.Point(12, 58)
        Me.btnAddDatapoint.Name = "btnAddDatapoint"
        Me.btnAddDatapoint.Size = New System.Drawing.Size(145, 23)
        Me.btnAddDatapoint.TabIndex = 5
        Me.btnAddDatapoint.Text = "Add Datapoint"
        Me.btnAddDatapoint.UseVisualStyleBackColor = True
        '
        'gbSettings
        '
        Me.gbSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbSettings.Controls.Add(Me.btnPurgeProcesses)
        Me.gbSettings.Controls.Add(Me.btnOpenCmd)
        Me.gbSettings.Controls.Add(Me.btnSetUsername)
        Me.gbSettings.Controls.Add(Me.txtUsername)
        Me.gbSettings.Controls.Add(Me.lblUsername)
        Me.gbSettings.Controls.Add(Me.gbFileOperations)
        Me.gbSettings.Controls.Add(Me.cbPromptToSaveOnExit)
        Me.gbSettings.Controls.Add(Me.btnSet)
        Me.gbSettings.Controls.Add(Me.txtOutputFileName)
        Me.gbSettings.Controls.Add(Me.lblOutputFileName)
        Me.gbSettings.Location = New System.Drawing.Point(12, 119)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Size = New System.Drawing.Size(145, 220)
        Me.gbSettings.TabIndex = 6
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Settings"
        '
        'btnSetUsername
        '
        Me.btnSetUsername.Location = New System.Drawing.Point(95, 71)
        Me.btnSetUsername.Name = "btnSetUsername"
        Me.btnSetUsername.Size = New System.Drawing.Size(45, 20)
        Me.btnSetUsername.TabIndex = 7
        Me.btnSetUsername.Text = "Set"
        Me.btnSetUsername.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(6, 71)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(83, 20)
        Me.txtUsername.TabIndex = 6
        Me.txtUsername.Text = "user"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(9, 55)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(81, 13)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username: (PC)"
        '
        'gbFileOperations
        '
        Me.gbFileOperations.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFileOperations.Controls.Add(Me.btnCreateFile)
        Me.gbFileOperations.Location = New System.Drawing.Point(6, 159)
        Me.gbFileOperations.Name = "gbFileOperations"
        Me.gbFileOperations.Size = New System.Drawing.Size(133, 55)
        Me.gbFileOperations.TabIndex = 4
        Me.gbFileOperations.TabStop = False
        Me.gbFileOperations.Text = "File Operations"
        '
        'btnCreateFile
        '
        Me.btnCreateFile.Location = New System.Drawing.Point(6, 19)
        Me.btnCreateFile.Name = "btnCreateFile"
        Me.btnCreateFile.Size = New System.Drawing.Size(121, 23)
        Me.btnCreateFile.TabIndex = 0
        Me.btnCreateFile.Text = "Create File"
        Me.btnCreateFile.UseVisualStyleBackColor = True
        '
        'cbPromptToSaveOnExit
        '
        Me.cbPromptToSaveOnExit.AutoSize = True
        Me.cbPromptToSaveOnExit.Location = New System.Drawing.Point(6, 229)
        Me.cbPromptToSaveOnExit.Name = "cbPromptToSaveOnExit"
        Me.cbPromptToSaveOnExit.Size = New System.Drawing.Size(134, 17)
        Me.cbPromptToSaveOnExit.TabIndex = 3
        Me.cbPromptToSaveOnExit.Text = "Prompt to Save on Exit"
        Me.cbPromptToSaveOnExit.UseVisualStyleBackColor = True
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(95, 31)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(44, 20)
        Me.btnSet.TabIndex = 2
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'txtOutputFileName
        '
        Me.txtOutputFileName.Location = New System.Drawing.Point(6, 32)
        Me.txtOutputFileName.Name = "txtOutputFileName"
        Me.txtOutputFileName.Size = New System.Drawing.Size(83, 20)
        Me.txtOutputFileName.TabIndex = 1
        Me.txtOutputFileName.Text = "default.dat"
        '
        'lblOutputFileName
        '
        Me.lblOutputFileName.AutoSize = True
        Me.lblOutputFileName.Location = New System.Drawing.Point(6, 16)
        Me.lblOutputFileName.Name = "lblOutputFileName"
        Me.lblOutputFileName.Size = New System.Drawing.Size(92, 13)
        Me.lblOutputFileName.TabIndex = 0
        Me.lblOutputFileName.Text = "Output File Name:"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(12, 345)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(145, 32)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'btnUseConsole
        '
        Me.btnUseConsole.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUseConsole.Location = New System.Drawing.Point(12, 87)
        Me.btnUseConsole.Name = "btnUseConsole"
        Me.btnUseConsole.Size = New System.Drawing.Size(145, 23)
        Me.btnUseConsole.TabIndex = 8
        Me.btnUseConsole.Text = "Use Console"
        Me.btnUseConsole.UseVisualStyleBackColor = True
        '
        'ttMagnitude
        '
        Me.ttMagnitude.StripAmpersands = True
        Me.ttMagnitude.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttMagnitude.ToolTipTitle = "Random Numbers' Base Magnitude"
        '
        'ttMantissa
        '
        Me.ttMantissa.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttMantissa.ToolTipTitle = "Set Precision"
        '
        'gbSystem
        '
        Me.gbSystem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbSystem.Controls.Add(Me.TreeView1)
        Me.gbSystem.Controls.Add(Me.gbProcesses)
        Me.gbSystem.Location = New System.Drawing.Point(397, 12)
        Me.gbSystem.Name = "gbSystem"
        Me.gbSystem.Size = New System.Drawing.Size(295, 365)
        Me.gbSystem.TabIndex = 4
        Me.gbSystem.TabStop = False
        Me.gbSystem.Text = "System"
        '
        'gbProcesses
        '
        Me.gbProcesses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProcesses.Controls.Add(Me.lblProcessID)
        Me.gbProcesses.Controls.Add(Me.ListBox1)
        Me.gbProcesses.Controls.Add(Me.lblProcessName)
        Me.gbProcesses.Controls.Add(Me.lbProcessList)
        Me.gbProcesses.Location = New System.Drawing.Point(6, 178)
        Me.gbProcesses.Name = "gbProcesses"
        Me.gbProcesses.Size = New System.Drawing.Size(283, 181)
        Me.gbProcesses.TabIndex = 0
        Me.gbProcesses.TabStop = False
        Me.gbProcesses.Text = "Processes"
        '
        'lbProcessList
        '
        Me.lbProcessList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbProcessList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbProcessList.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProcessList.FormattingEnabled = True
        Me.lbProcessList.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lbProcessList.Location = New System.Drawing.Point(6, 45)
        Me.lbProcessList.Margin = New System.Windows.Forms.Padding(1)
        Me.lbProcessList.Name = "lbProcessList"
        Me.lbProcessList.Size = New System.Drawing.Size(134, 132)
        Me.lbProcessList.TabIndex = 0
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.statusstripMain_lblStatus})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 383)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(703, 22)
        Me.statusstripMain.TabIndex = 9
        Me.statusstripMain.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'statusstripMain_lblStatus
        '
        Me.statusstripMain_lblStatus.Name = "statusstripMain_lblStatus"
        Me.statusstripMain_lblStatus.Size = New System.Drawing.Size(77, 17)
        Me.statusstripMain_lblStatus.Text = "Status: Ready"
        '
        'btnOpenCmd
        '
        Me.btnOpenCmd.Location = New System.Drawing.Point(6, 97)
        Me.btnOpenCmd.Name = "btnOpenCmd"
        Me.btnOpenCmd.Size = New System.Drawing.Size(134, 23)
        Me.btnOpenCmd.TabIndex = 9
        Me.btnOpenCmd.Text = "Open Cmd"
        Me.btnOpenCmd.UseVisualStyleBackColor = True
        '
        'btnPurgeProcesses
        '
        Me.btnPurgeProcesses.Location = New System.Drawing.Point(6, 126)
        Me.btnPurgeProcesses.Name = "btnPurgeProcesses"
        Me.btnPurgeProcesses.Size = New System.Drawing.Size(134, 23)
        Me.btnPurgeProcesses.TabIndex = 10
        Me.btnPurgeProcesses.Text = "Purge Processes"
        Me.btnPurgeProcesses.UseVisualStyleBackColor = True
        '
        'lblProcessName
        '
        Me.lblProcessName.AutoSize = True
        Me.lblProcessName.Location = New System.Drawing.Point(6, 26)
        Me.lblProcessName.Name = "lblProcessName"
        Me.lblProcessName.Size = New System.Drawing.Size(35, 13)
        Me.lblProcessName.TabIndex = 1
        Me.lblProcessName.Text = "Name"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ListBox1.Location = New System.Drawing.Point(142, 45)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(137, 132)
        Me.ListBox1.TabIndex = 2
        '
        'lblProcessID
        '
        Me.lblProcessID.AutoSize = True
        Me.lblProcessID.Location = New System.Drawing.Point(139, 26)
        Me.lblProcessID.Name = "lblProcessID"
        Me.lblProcessID.Size = New System.Drawing.Size(59, 13)
        Me.lblProcessID.TabIndex = 3
        Me.lblProcessID.Text = "Process ID"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(6, 19)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(283, 153)
        Me.TreeView1.TabIndex = 1
        '
        'processController
        '
        Me.processController.StartInfo.Domain = ""
        Me.processController.StartInfo.LoadUserProfile = False
        Me.processController.StartInfo.Password = Nothing
        Me.processController.StartInfo.StandardErrorEncoding = Nothing
        Me.processController.StartInfo.StandardOutputEncoding = Nothing
        Me.processController.StartInfo.UserName = ""
        Me.processController.SynchronizingObject = Me
        '
        'btnProcessController
        '
        Me.btnProcessController.Location = New System.Drawing.Point(9, 181)
        Me.btnProcessController.Name = "btnProcessController"
        Me.btnProcessController.Size = New System.Drawing.Size(219, 23)
        Me.btnProcessController.TabIndex = 4
        Me.btnProcessController.Text = "Process Controller"
        Me.btnProcessController.UseVisualStyleBackColor = True
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 405)
        Me.Controls.Add(Me.statusstripMain)
        Me.Controls.Add(Me.gbSystem)
        Me.Controls.Add(Me.btnUseConsole)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.gbSettings)
        Me.Controls.Add(Me.btnAddDatapoint)
        Me.Controls.Add(Me.gbBulkGenerator)
        Me.Controls.Add(Me.txtYValue)
        Me.Controls.Add(Me.txtXValue)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regression Datapoint Generator"
        Me.gbBulkGenerator.ResumeLayout(False)
        Me.gbBulkGenerator.PerformLayout()
        Me.gbBulkOptions.ResumeLayout(False)
        Me.gbBulkOptions.PerformLayout()
        CType(Me.numMagnitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinMantissa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSettings.ResumeLayout(False)
        Me.gbSettings.PerformLayout()
        Me.gbFileOperations.ResumeLayout(False)
        Me.gbSystem.ResumeLayout(False)
        Me.gbProcesses.ResumeLayout(False)
        Me.gbProcesses.PerformLayout()
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents txtXValue As TextBox
    Friend WithEvents txtYValue As TextBox
    Friend WithEvents gbBulkGenerator As GroupBox
    Friend WithEvents gbBulkOptions As GroupBox
    Friend WithEvents cbCommaDelimiters As CheckBox
    Friend WithEvents btnBulkGenerate As Button
    Friend WithEvents txtIterations As TextBox
    Friend WithEvents lblBulkGenerate As Label
    Friend WithEvents btnAddDatapoint As Button
    Friend WithEvents gbSettings As GroupBox
    Friend WithEvents btnSet As Button
    Friend WithEvents txtOutputFileName As TextBox
    Friend WithEvents lblOutputFileName As Label
    Friend WithEvents sfdSaveDataset As SaveFileDialog
    Friend WithEvents cmdExit As Button
    Friend WithEvents cbPromptToSaveOnExit As CheckBox
    Friend WithEvents gbFileOperations As GroupBox
    Friend WithEvents btnCreateFile As Button
    Friend WithEvents btnUseConsole As Button
    Friend WithEvents btnSetUsername As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents numMagnitude As NumericUpDown
    Friend WithEvents lblMinimumMantissa As Label
    Friend WithEvents numMinMantissa As NumericUpDown
    Friend WithEvents cbAllowNegatives As CheckBox
    Friend WithEvents lblMagnitude As Label
    Friend WithEvents ttMagnitude As ToolTip
    Friend WithEvents ttMantissa As ToolTip
    Friend WithEvents gbSystem As GroupBox
    Friend WithEvents gbProcesses As GroupBox
    Friend WithEvents lbProcessList As ListBox
    Protected WithEvents statusstripMain As StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents statusstripMain_lblStatus As ToolStripStatusLabel
    Friend WithEvents btnPurgeProcesses As Button
    Friend WithEvents btnOpenCmd As Button
    Friend WithEvents btnProcessController As Button
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents lblProcessID As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblProcessName As Label
    Friend WithEvents processController As Process
    Friend WithEvents Process1 As Process
End Class
