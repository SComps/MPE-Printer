Imports System.Text.RegularExpressions
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Public Class Job
    ' Class for a new job
    Private myData As New List(Of String)

    Public Property Data As List(Of String)
        Get
            Return myData
        End Get
        Set(value As List(Of String))
            myData = value
        End Set
    End Property

    Public Sub New()
        ' Just create the object and return
    End Sub
    Public Sub New(indata As List(Of String))
        ' Create the object and load the print job into myData.
        ' Same as :          Dim obj as New Job
        '                    obj.Data = JobData
        '           
        ' Easier:            Dim obj as New Job(JobData)
        '
        myData = indata
    End Sub

    Public Sub View()
        Dim docViewer As New jobView()
        'Insert 3 lines at the beginning of the viewed document
        myData.Insert(0, " ")
        myData.Insert(0, " ")
        myData.Insert(0," ")
        docViewer.ReceiveJob(myData)
        Dim thisJobID As String = docViewer.JobID
        Dim thisOID As String = docViewer.OutputID
        Dim thisUser As String = docViewer.JobUser
        Dim JobTitle As String = String.Format("JOB{0}-{1}-{2}", thisJobID, thisOID, thisUser)
        docViewer.Show()
        CreatePDF("MPETest", myData, Form1.SetPath & "\" & JobTitle & ".pdf")
    End Sub

    Public Function CreatePDF(title As String, outList As List(Of String), filename As String) As String
        Dim JobNumber As String = ""
        Dim JobName As String = ""
        Dim doc As New PdfSharp.Pdf.PdfDocument
        doc.Info.Title = title
        Dim page As PdfPage = doc.AddPage()
        page.Orientation = PdfSharp.PageOrientation.Landscape
        ' Get an XGraphics object for drawing
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)

        ' Create a font
        Dim font As XFont = New XFont("Lucida Console", 8, XFontStyle.Regular)

        ' Set initial coordinates for text
        Dim x As Double = 10
        Dim y As Double = 0
        Dim newHeight As Double = page.Height.Point / 67
        Dim lineHeight As Double = newHeight
        ' Calculate the maximum number of lines that can fit on a page
        Dim maxLinesPerPage As Integer = CInt((page.Height.Point - y) / lineHeight)

        ' Loop through the list of strings and draw each on a new line
        Dim currentLine As Integer = 0

        For Each line As String In outList

            If (line(0) = vbFormFeed) Then
                ' Add a new page
                page = doc.AddPage()
                page.Orientation = PdfSharp.PageOrientation.Landscape
                gfx = XGraphics.FromPdfPage(page)
                y = 0 ' Reset the y-coordinate
                currentLine = 0
                ' For MP3 we'll allow a half inch top margin and let MPE handle
                ' the bottom.
            End If
            line = line.Replace(vbFormFeed, "") 'We've already dealt with the FormFeeds
            line = line.Replace(vbCr, "") 'Get rid of CR
            line = line.Replace(vbLf, "") 'Get rid of LF (we may deal with them later)
            If line = "" Then line = " "  ' Make sure the line contains at least *something*
            ' If the current line exceeds maxLinesPerPage, create a new page
            If currentLine > 0 AndAlso currentLine Mod maxLinesPerPage = 0 Then
                ' Add a new page
                page = doc.AddPage()
                page.Orientation = PdfSharp.PageOrientation.Landscape
                gfx = XGraphics.FromPdfPage(page)
                y = 0 ' Reset the y-coordinate
                currentLine = 0
                For i = 1 To 5
                    gfx.DrawString(" ", font, XBrushes.Black, New XRect(x, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
                    y += lineHeight ' Move to the next line
                    currentLine += 1
                Next
            End If

            ' Draw the current line
            gfx.DrawString(line, font, XBrushes.Black, New XRect(x, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
            y += lineHeight ' Move to the next line
            currentLine += 1
        Next
        Dim outputFile As String = filename
        doc.Save(outputFile)
        doc.Close()
        Return outputFile
    End Function
End Class
