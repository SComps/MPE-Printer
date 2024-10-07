<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.connButton = New System.Windows.Forms.Button()
        Me.chkAutoConn = New System.Windows.Forms.CheckBox()
        Me.logBox = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowRcv = New System.Windows.Forms.ToolStripMenuItem()
        Me.status = New System.Windows.Forms.Label()
        Me.loopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.chkText = New System.Windows.Forms.CheckBox()
        Me.chkOpenPdf = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host or IP address"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(257, 22)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(281, 28)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(59, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'connButton
        '
        Me.connButton.Location = New System.Drawing.Point(346, 12)
        Me.connButton.Name = "connButton"
        Me.connButton.Size = New System.Drawing.Size(75, 39)
        Me.connButton.TabIndex = 4
        Me.connButton.Text = "Value"
        Me.connButton.UseVisualStyleBackColor = True
        '
        'chkAutoConn
        '
        Me.chkAutoConn.AutoSize = True
        Me.chkAutoConn.Location = New System.Drawing.Point(15, 56)
        Me.chkAutoConn.Name = "chkAutoConn"
        Me.chkAutoConn.Size = New System.Drawing.Size(103, 20)
        Me.chkAutoConn.TabIndex = 5
        Me.chkAutoConn.Text = "Autoconnect"
        Me.chkAutoConn.UseVisualStyleBackColor = True
        '
        'logBox
        '
        Me.logBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.logBox.Location = New System.Drawing.Point(12, 121)
        Me.logBox.Name = "logBox"
        Me.logBox.Size = New System.Drawing.Size(409, 359)
        Me.logBox.TabIndex = 6
        Me.logBox.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowRcv})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(209, 28)
        '
        'ShowRcv
        '
        Me.ShowRcv.CheckOnClick = True
        Me.ShowRcv.Name = "ShowRcv"
        Me.ShowRcv.Size = New System.Drawing.Size(208, 24)
        Me.ShowRcv.Text = "Show data received"
        '
        'status
        '
        Me.status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.status.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(9, 492)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(412, 23)
        Me.status.TabIndex = 8
        Me.status.Text = "Path not set"
        Me.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'loopTimer
        '
        Me.loopTimer.Enabled = True
        Me.loopTimer.Interval = 1000
        '
        'chkText
        '
        Me.chkText.AutoSize = True
        Me.chkText.Location = New System.Drawing.Point(15, 95)
        Me.chkText.Name = "chkText"
        Me.chkText.Size = New System.Drawing.Size(154, 20)
        Me.chkText.TabIndex = 9
        Me.chkText.Text = "Show text output view"
        Me.chkText.UseVisualStyleBackColor = True
        '
        'chkOpenPdf
        '
        Me.chkOpenPdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkOpenPdf.AutoSize = True
        Me.chkOpenPdf.Location = New System.Drawing.Point(212, 95)
        Me.chkOpenPdf.Name = "chkOpenPdf"
        Me.chkOpenPdf.Size = New System.Drawing.Size(209, 20)
        Me.chkOpenPdf.TabIndex = 10
        Me.chkOpenPdf.Text = "Open PDFs as they're created"
        Me.chkOpenPdf.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(198, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Save Connection Information"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label3, "Click here to save the current connection settings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and options.")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(437, 530)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkOpenPdf)
        Me.Controls.Add(Me.chkText)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.logBox)
        Me.Controls.Add(Me.chkAutoConn)
        Me.Controls.Add(Me.connButton)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "MPE Printer Simulator"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents connButton As Button
    Friend WithEvents chkAutoConn As CheckBox
    Friend WithEvents logBox As RichTextBox
    Friend WithEvents status As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ShowRcv As ToolStripMenuItem
    Friend WithEvents loopTimer As Timer
    Friend WithEvents chkText As CheckBox
    Friend WithEvents chkOpenPdf As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
