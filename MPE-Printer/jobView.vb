Public Class jobView
    Private sID As String = ""
    Private oID As String = ""
    Private Username As String = ""

    ReadOnly Property JobID As String
        Get
            Return sID
        End Get
    End Property
    ReadOnly Property OutputID As String
        Get
            Return oID
        End Get
    End Property
    ReadOnly Property JobUser As String
        Get
            Return Username
        End Get
    End Property

    Private Sub jobView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ReceiveJob(indata As List(Of String))
        Dim separator As New String("=", 132)
        ' Try to get the job information.  MPE at least makes
        ' the first line a header, so we should be able to parse that
        ' first.
        'Get the 4th line (index 3)
        Dim myJob As String = indata(3).Trim
        Dim parse As String() = myJob.Split(";")
        Dim parse2 As String() = parse(1).Split("*")

        sID = parse(0).Trim
        oID = parse2(0).Trim
        Username = parse2(1).Trim
        For Each l As String In indata
            If l.Substring(0, 1) = vbFormFeed Then
                'This is just a formfeed character
                Viewer.AppendText(separator & vbLf)
                Viewer.ScrollToCaret()
            Else
                Viewer.AppendText(l)
                Viewer.ScrollToCaret()
            End If
        Next

    End Sub
End Class