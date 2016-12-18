<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Launch_Btn = New System.Windows.Forms.Button()
        Me.Model_lbl = New System.Windows.Forms.Label()
        Me.ECID_lbl = New System.Windows.Forms.Label()
        Me.iosVer_lbl = New System.Windows.Forms.Label()
        Me.identifier_txt = New System.Windows.Forms.TextBox()
        Me.ECID_txt = New System.Windows.Forms.TextBox()
        Me.iosVer_txt = New System.Windows.Forms.TextBox()
        Me.identifier_lbl_EX = New System.Windows.Forms.Label()
        Me.ECID_lbl_EX = New System.Windows.Forms.Label()
        Me.iosVer_lbl_EX = New System.Windows.Forms.Label()
        Me.Browse_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RstLocation_btn = New System.Windows.Forms.Button()
        Me.LocOpen_btn = New System.Windows.Forms.Button()
        Me.SaveLoc_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NoCache_chbx = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Launch_Btn
        '
        Me.Launch_Btn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Launch_Btn.Location = New System.Drawing.Point(220, 292)
        Me.Launch_Btn.Name = "Launch_Btn"
        Me.Launch_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Launch_Btn.TabIndex = 4
        Me.Launch_Btn.Text = "Launch"
        Me.Launch_Btn.UseVisualStyleBackColor = True
        '
        'Model_lbl
        '
        Me.Model_lbl.AutoSize = True
        Me.Model_lbl.Location = New System.Drawing.Point(38, 32)
        Me.Model_lbl.Name = "Model_lbl"
        Me.Model_lbl.Size = New System.Drawing.Size(82, 13)
        Me.Model_lbl.TabIndex = 1
        Me.Model_lbl.Text = "Model Identifier:"
        '
        'ECID_lbl
        '
        Me.ECID_lbl.AutoSize = True
        Me.ECID_lbl.Location = New System.Drawing.Point(38, 65)
        Me.ECID_lbl.Name = "ECID_lbl"
        Me.ECID_lbl.Size = New System.Drawing.Size(72, 13)
        Me.ECID_lbl.TabIndex = 2
        Me.ECID_lbl.Text = "Device ECID:"
        '
        'iosVer_lbl
        '
        Me.iosVer_lbl.AutoSize = True
        Me.iosVer_lbl.Location = New System.Drawing.Point(38, 98)
        Me.iosVer_lbl.Name = "iosVer_lbl"
        Me.iosVer_lbl.Size = New System.Drawing.Size(65, 13)
        Me.iosVer_lbl.TabIndex = 3
        Me.iosVer_lbl.Text = "iOS Version:"
        '
        'identifier_txt
        '
        Me.identifier_txt.Location = New System.Drawing.Point(136, 29)
        Me.identifier_txt.Name = "identifier_txt"
        Me.identifier_txt.Size = New System.Drawing.Size(197, 20)
        Me.identifier_txt.TabIndex = 0
        '
        'ECID_txt
        '
        Me.ECID_txt.Location = New System.Drawing.Point(136, 62)
        Me.ECID_txt.Name = "ECID_txt"
        Me.ECID_txt.Size = New System.Drawing.Size(197, 20)
        Me.ECID_txt.TabIndex = 1
        '
        'iosVer_txt
        '
        Me.iosVer_txt.Location = New System.Drawing.Point(136, 95)
        Me.iosVer_txt.Name = "iosVer_txt"
        Me.iosVer_txt.Size = New System.Drawing.Size(197, 20)
        Me.iosVer_txt.TabIndex = 2
        '
        'identifier_lbl_EX
        '
        Me.identifier_lbl_EX.AutoSize = True
        Me.identifier_lbl_EX.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.identifier_lbl_EX.Location = New System.Drawing.Point(353, 32)
        Me.identifier_lbl_EX.Name = "identifier_lbl_EX"
        Me.identifier_lbl_EX.Size = New System.Drawing.Size(101, 13)
        Me.identifier_lbl_EX.TabIndex = 9
        Me.identifier_lbl_EX.Text = "Example: iPhone7,2"
        '
        'ECID_lbl_EX
        '
        Me.ECID_lbl_EX.AutoSize = True
        Me.ECID_lbl_EX.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ECID_lbl_EX.Location = New System.Drawing.Point(353, 65)
        Me.ECID_lbl_EX.Name = "ECID_lbl_EX"
        Me.ECID_lbl_EX.Size = New System.Drawing.Size(123, 13)
        Me.ECID_lbl_EX.TabIndex = 10
        Me.ECID_lbl_EX.Text = "Example: 1C5302C10AC"
        '
        'iosVer_lbl_EX
        '
        Me.iosVer_lbl_EX.AutoSize = True
        Me.iosVer_lbl_EX.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.iosVer_lbl_EX.Location = New System.Drawing.Point(353, 98)
        Me.iosVer_lbl_EX.Name = "iosVer_lbl_EX"
        Me.iosVer_lbl_EX.Size = New System.Drawing.Size(83, 13)
        Me.iosVer_lbl_EX.TabIndex = 11
        Me.iosVer_lbl_EX.Text = "Example: 10.1.1"
        '
        'Browse_btn
        '
        Me.Browse_btn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Browse_btn.Location = New System.Drawing.Point(320, 11)
        Me.Browse_btn.Name = "Browse_btn"
        Me.Browse_btn.Size = New System.Drawing.Size(75, 23)
        Me.Browse_btn.TabIndex = 1
        Me.Browse_btn.Text = "Browse..."
        Me.Browse_btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RstLocation_btn)
        Me.GroupBox1.Controls.Add(Me.LocOpen_btn)
        Me.GroupBox1.Controls.Add(Me.SaveLoc_txt)
        Me.GroupBox1.Controls.Add(Me.Browse_btn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 66)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Save Location"
        '
        'RstLocation_btn
        '
        Me.RstLocation_btn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RstLocation_btn.Location = New System.Drawing.Point(320, 37)
        Me.RstLocation_btn.Name = "RstLocation_btn"
        Me.RstLocation_btn.Size = New System.Drawing.Size(156, 23)
        Me.RstLocation_btn.TabIndex = 3
        Me.RstLocation_btn.Text = "Reset to Default"
        Me.RstLocation_btn.UseVisualStyleBackColor = True
        '
        'LocOpen_btn
        '
        Me.LocOpen_btn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LocOpen_btn.Location = New System.Drawing.Point(401, 11)
        Me.LocOpen_btn.Name = "LocOpen_btn"
        Me.LocOpen_btn.Size = New System.Drawing.Size(75, 23)
        Me.LocOpen_btn.TabIndex = 2
        Me.LocOpen_btn.Text = "Open"
        Me.LocOpen_btn.UseVisualStyleBackColor = True
        '
        'SaveLoc_txt
        '
        Me.SaveLoc_txt.Location = New System.Drawing.Point(17, 29)
        Me.SaveLoc_txt.Name = "SaveLoc_txt"
        Me.SaveLoc_txt.Size = New System.Drawing.Size(284, 20)
        Me.SaveLoc_txt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(404, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Simalary Studios"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NoCache_chbx)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 68)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options // Actions"
        '
        'NoCache_chbx
        '
        Me.NoCache_chbx.AutoSize = True
        Me.NoCache_chbx.Location = New System.Drawing.Point(17, 19)
        Me.NoCache_chbx.Name = "NoCache_chbx"
        Me.NoCache_chbx.Size = New System.Drawing.Size(74, 17)
        Me.NoCache_chbx.TabIndex = 0
        Me.NoCache_chbx.Text = "No Cache"
        Me.NoCache_chbx.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 331)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.iosVer_lbl_EX)
        Me.Controls.Add(Me.ECID_lbl_EX)
        Me.Controls.Add(Me.identifier_lbl_EX)
        Me.Controls.Add(Me.iosVer_txt)
        Me.Controls.Add(Me.ECID_txt)
        Me.Controls.Add(Me.identifier_txt)
        Me.Controls.Add(Me.iosVer_lbl)
        Me.Controls.Add(Me.ECID_lbl)
        Me.Controls.Add(Me.Model_lbl)
        Me.Controls.Add(Me.Launch_Btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(531, 240)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TSS Checker Assistant"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Launch_Btn As Button
    Friend WithEvents Model_lbl As Label
    Friend WithEvents ECID_lbl As Label
    Friend WithEvents iosVer_lbl As Label
    Friend WithEvents identifier_txt As TextBox
    Friend WithEvents ECID_txt As TextBox
    Friend WithEvents iosVer_txt As TextBox
    Friend WithEvents identifier_lbl_EX As Label
    Friend WithEvents ECID_lbl_EX As Label
    Friend WithEvents iosVer_lbl_EX As Label
    Friend WithEvents Browse_btn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SaveLoc_txt As TextBox
    Friend WithEvents LocOpen_btn As Button
    Friend WithEvents RstLocation_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NoCache_chbx As CheckBox
End Class
