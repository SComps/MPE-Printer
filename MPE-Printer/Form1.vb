Imports System.IO
Imports System.Net.Sockets
Imports System.Text

Public Class Form1

    Public host As String = "localhost"
    Public port As Integer = 1043   ' default printer port for turnkey MPE V
    Public autoconnect As Boolean = False
    Public configFile As Boolean = False
    Dim client As New TcpClient()
    Private buttonOff As String = "Start"
    Private buttonOn As String = "Stop"
    Public SetPath As String = Application.StartupPath & "\pdf"
    Private RTBColor As Color = DefaultBackColor
    Dim WaitUntil As DateTime
    Private LastData As DateTime = Now()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make sure output path exists.
        If Not Directory.Exists(SetPath) Then
            Directory.CreateDirectory(SetPath)
        End If
        ' Check to see if there's a config file
        ' If so, load it up.
        configFile = False  ' Simulate no config file
        status.Text = "Loading..."
        TextBox1.Text = host
        TextBox2.Text = port

        If Not configFile Then
            status.Text = "No setup information."
        Else
            status.Text = "Ready."
        End If
        RTBColor = logBox.BackColor
        connButton.Focus()
    End Sub

    Private Sub ShowRcv_Click(sender As Object, e As EventArgs) Handles ShowRcv.Click
        If ShowRcv.Checked Then
            logBox.BackColor = Color.Beige
        Else
            logBox.BackColor = RTBColor
        End If
    End Sub

    Private Sub connButton_Click(sender As Object, e As EventArgs) Handles connButton.Click
        If Not client.Connected Then
            ' Connect 
            Try
                client.Connect(host, port)
            Catch ex As Exception
                logBox.AppendText("Unable to connect to remote." & vbCrLf)
                Exit Sub
            End Try
            logBox.AppendText("Connected." & vbCrLf)
            WaitUntil = Now().AddSeconds(2)
            ' We'll wait 2 seconds before we consider any data to be valid
            ' because SIMH has a connection banner.  
        Else
            ' Disconnect
            client.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        host = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        port = Val(TextBox2.Text)
    End Sub

    Private Function GetOutput() As List(Of String)
        ' Shut off the timer while we're reading the data
        loopTimer.Enabled = False
        Dim thisOutput As New List(Of String)
        Dim myStream As NetworkStream = Nothing
        If client.Connected Then

            myStream = client.GetStream()
            Do
                Dim newLine As String = ReadLine(myStream)
                If (newLine Is Nothing) Then
                    Exit Do
                End If
                ' Look for embedded FF 
                Dim FFPos As Integer = 0
                While newLine.IndexOf(vbFormFeed) <> -1
                    FFPos = newLine.IndexOf(vbFormFeed)
                    Dim tempLine = newLine.Substring(0, FFPos - 1)
                    If tempLine <> "" Then
                        thisOutput.Add(tempLine)
                        Debug.Print("<FF proc> " & tempLine)
                    End If
                    thisOutput.Add(vbFormFeed)
                    Debug.Print("<FF proc> Adding raw FF")
                    thisOutput.Add(vbLf)
                    thisOutput.Add(vbLf)
                    thisOutput.Add(vbLf)
                    newLine = newLine.Substring(FFPos + 1, (newLine.Length - (FFPos + 1)))
                    Debug.Print("<FF proc> Leaving with " & newLine)
                End While
                'Add what's left of newline (or the original if no FF found)
                If newLine <> "" Then
                    thisOutput.Add(newLine)
                    Debug.Print("Fallthrough add: " & newLine)
                End If
            Loop
        End If
        ' Turn the timer back on
        loopTimer.Enabled = True
        Return thisOutput
    End Function

    Private Function ReadLine(thisStream As NetworkStream) As String
        'Reads one line from the network stream.  What's the point of taking
        'ReadLine out of the Network Stream?  Somebody at Microsoft thought
        'that was a good idea.  Probably the same guy that came up with CoPilot.
        'because nobody ever reads whole lines of text from a network stream.

        If Not thisStream.DataAvailable Then
            'Sometimes the output stream is a little slow
            'so lets check things out a bit.  If LastData was recent
            'then we'll wait one second.  If not, then we'll bail out.
            If LastData.AddSeconds(1) < Now() Then Return Nothing
            While LastData.AddSeconds(1) > Now()
                Application.DoEvents()
            End While
        End If
        Dim MyString As String = ""
        If thisStream.DataAvailable Then
            While thisStream.DataAvailable
                Dim thisByte(1) As Byte
                thisStream.Read(thisByte, 0, 1)
                Dim thisChar As String = Encoding.ASCII.GetString(thisByte, 0, 1)
                LastData = Now()
                MyString = MyString & thisChar
                If thisChar = vbLf Then
                    Debug.Print(MyString)
                    If ShowRcv.Checked Then
                        logBox.AppendText("RCV: " & MyString)
                    End If
                    Return MyString
                End If
            End While
        Else
            Return Nothing
        End If
        Debug.Print(MyString)
        If ShowRcv.Checked Then
            logBox.AppendText("RCV:" & MyString)
        End If
        Return MyString
    End Function

    Private Sub loopTimer_Tick(sender As Object, e As EventArgs) Handles loopTimer.Tick
        loopTimer.Enabled = False     ' Turn it off incase this takes longer than the interval

        If client.Client Is Nothing Then
            connButton.Text = buttonOff
        Else
            If (client.Connected = False) Then
                connButton.Text = buttonOff

            Else
                connButton.Text = buttonOn

                Dim myJob As List(Of String) = GetOutput()
                If Now < WaitUntil Then
                    Debug.Print("Patiently waiting for banners")
                    loopTimer.Enabled = True
                    Exit Sub
                    'Don't do anything
                End If
                If myJob.Count > 0 Then
                    ' A job has been printed.  It might be ours, it might not.
                    Debug.Print("Sending job to printer")
                    Dim thisJob As New Job(myJob)
                    thisJob.View()
                End If
            End If
        End If
        loopTimer.Enabled = True
    End Sub

    Private Sub logBox_TextChanged(sender As Object, e As EventArgs) Handles logBox.TextChanged
        logBox.ScrollToCaret()
    End Sub
End Class
