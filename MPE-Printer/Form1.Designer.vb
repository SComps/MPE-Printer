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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.logBox = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowRcv = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.status = New System.Windows.Forms.Label()
        Me.loopTimer = New System.Windows.Forms.Timer(Me.components)
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 56)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(103, 20)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Autoconnect"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'logBox
        '
        Me.logBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.logBox.Location = New System.Drawing.Point(12, 82)
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
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(296, 56)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(129, 20)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Save connection"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'status
        '
        Me.status.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(9, 453)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(437, 478)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.logBox)
        Me.Controls.Add(Me.CheckBox1)
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
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents logBox As RichTextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents status As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ShowRcv As ToolStripMenuItem
    Friend WithEvents loopTimer As Timer
End Class
