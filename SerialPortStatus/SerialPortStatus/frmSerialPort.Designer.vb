<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerialPort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSerialPort))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tbcSerial = New System.Windows.Forms.TabControl()
        Me.tpSerial = New System.Windows.Forms.TabPage()
        Me.tpSettings = New System.Windows.Forms.TabPage()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.rtbSerialOutput = New System.Windows.Forms.RichTextBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.cbxSerialPort = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1.SuspendLayout()
        Me.tbcSerial.SuspendLayout()
        Me.tpSerial.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 379)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(434, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tbcSerial
        '
        Me.tbcSerial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcSerial.Controls.Add(Me.tpSerial)
        Me.tbcSerial.Controls.Add(Me.tpSettings)
        Me.tbcSerial.Location = New System.Drawing.Point(12, 8)
        Me.tbcSerial.Name = "tbcSerial"
        Me.tbcSerial.SelectedIndex = 0
        Me.tbcSerial.Size = New System.Drawing.Size(410, 360)
        Me.tbcSerial.TabIndex = 1
        '
        'tpSerial
        '
        Me.tpSerial.Controls.Add(Me.cbxSerialPort)
        Me.tpSerial.Controls.Add(Me.btnRead)
        Me.tpSerial.Controls.Add(Me.rtbSerialOutput)
        Me.tpSerial.Controls.Add(Me.btnOpen)
        Me.tpSerial.Controls.Add(Me.btnRefresh)
        Me.tpSerial.Location = New System.Drawing.Point(4, 22)
        Me.tpSerial.Name = "tpSerial"
        Me.tpSerial.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSerial.Size = New System.Drawing.Size(402, 334)
        Me.tpSerial.TabIndex = 0
        Me.tpSerial.Text = "SerialPort"
        Me.tpSerial.UseVisualStyleBackColor = True
        '
        'tpSettings
        '
        Me.tpSettings.Location = New System.Drawing.Point(4, 22)
        Me.tpSettings.Name = "tpSettings"
        Me.tpSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSettings.Size = New System.Drawing.Size(402, 334)
        Me.tpSettings.TabIndex = 1
        Me.tpSettings.Text = "Einstellungen"
        Me.tpSettings.UseVisualStyleBackColor = True
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Status"
        '
        'tslStatus
        '
        Me.tslStatus.Name = "tslStatus"
        Me.tslStatus.Size = New System.Drawing.Size(380, 17)
        Me.tslStatus.Spring = True
        Me.tslStatus.Text = "..."
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(6, 297)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(106, 31)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Aktualisieren"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(290, 297)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(106, 31)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "Öffnen"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'rtbSerialOutput
        '
        Me.rtbSerialOutput.Location = New System.Drawing.Point(6, 55)
        Me.rtbSerialOutput.Name = "rtbSerialOutput"
        Me.rtbSerialOutput.Size = New System.Drawing.Size(390, 228)
        Me.rtbSerialOutput.TabIndex = 3
        Me.rtbSerialOutput.Text = ""
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(146, 297)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(106, 31)
        Me.btnRead.TabIndex = 4
        Me.btnRead.Text = "Lesen"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'cbxSerialPort
        '
        Me.cbxSerialPort.FormattingEnabled = True
        Me.cbxSerialPort.Location = New System.Drawing.Point(6, 19)
        Me.cbxSerialPort.Name = "cbxSerialPort"
        Me.cbxSerialPort.Size = New System.Drawing.Size(148, 21)
        Me.cbxSerialPort.TabIndex = 5
        '
        'frmSerialPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 401)
        Me.Controls.Add(Me.tbcSerial)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 440)
        Me.MinimumSize = New System.Drawing.Size(450, 440)
        Me.Name = "frmSerialPort"
        Me.Text = "SerialPortStatus"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tbcSerial.ResumeLayout(False)
        Me.tpSerial.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tbcSerial As System.Windows.Forms.TabControl
    Friend WithEvents tpSerial As System.Windows.Forms.TabPage
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents tpSettings As System.Windows.Forms.TabPage
    Friend WithEvents rtbSerialOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents cbxSerialPort As System.Windows.Forms.ComboBox

End Class
