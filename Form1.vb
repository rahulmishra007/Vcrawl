Imports System
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions


Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Private Property btnParse As Object

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDocumentName As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblFindCount As System.Windows.Forms.Label
    Friend WithEvents txtResults As System.Windows.Forms.TextBox
    Friend WithEvents urlLabel As System.Windows.Forms.Label
    Friend WithEvents urlField As System.Windows.Forms.TextBox
    Friend WithEvents go As System.Windows.Forms.Button
    Friend WithEvents orLabel As System.Windows.Forms.Label
    Friend WithEvents clearList As System.Windows.Forms.Button
    Friend WithEvents parse As System.Windows.Forms.Button
    Friend WithEvents txtDocContents As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.lblFindCount = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtDocContents = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDocumentName = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.urlLabel = New System.Windows.Forms.Label()
        Me.urlField = New System.Windows.Forms.TextBox()
        Me.go = New System.Windows.Forms.Button()
        Me.orLabel = New System.Windows.Forms.Label()
        Me.clearList = New System.Windows.Forms.Button()
        Me.parse = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 157)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(599, 441)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtResults)
        Me.TabPage1.Controls.Add(Me.lblFindCount)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(591, 415)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "EMail Addresses"
        '
        'txtResults
        '
        Me.txtResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResults.Location = New System.Drawing.Point(8, 40)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResults.Size = New System.Drawing.Size(575, 369)
        Me.txtResults.TabIndex = 2
        '
        'lblFindCount
        '
        Me.lblFindCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFindCount.Location = New System.Drawing.Point(8, 8)
        Me.lblFindCount.Name = "lblFindCount"
        Me.lblFindCount.Size = New System.Drawing.Size(575, 23)
        Me.lblFindCount.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtDocContents)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(591, 415)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Document Content"
        '
        'txtDocContents
        '
        Me.txtDocContents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDocContents.Location = New System.Drawing.Point(8, 8)
        Me.txtDocContents.Multiline = True
        Me.txtDocContents.Name = "txtDocContents"
        Me.txtDocContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDocContents.Size = New System.Drawing.Size(575, 401)
        Me.txtDocContents.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(527, 604)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Document:"
        '
        'txtDocumentName
        '
        Me.txtDocumentName.Location = New System.Drawing.Point(89, 94)
        Me.txtDocumentName.Name = "txtDocumentName"
        Me.txtDocumentName.Size = New System.Drawing.Size(264, 20)
        Me.txtDocumentName.TabIndex = 3
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(376, 92)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(56, 23)
        Me.btnBrowse.TabIndex = 5
        Me.btnBrowse.Text = "Browse"
        '
        'urlLabel
        '
        Me.urlLabel.AutoSize = True
        Me.urlLabel.Location = New System.Drawing.Point(36, 36)
        Me.urlLabel.Name = "urlLabel"
        Me.urlLabel.Size = New System.Drawing.Size(35, 13)
        Me.urlLabel.TabIndex = 6
        Me.urlLabel.Text = "URL :"
        '
        'urlField
        '
        Me.urlField.Location = New System.Drawing.Point(89, 36)
        Me.urlField.Name = "urlField"
        Me.urlField.Size = New System.Drawing.Size(264, 20)
        Me.urlField.TabIndex = 3
        '
        'go
        '
        Me.go.Location = New System.Drawing.Point(376, 36)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(56, 23)
        Me.go.TabIndex = 4
        Me.go.Text = "Go"
        '
        'orLabel
        '
        Me.orLabel.AutoSize = True
        Me.orLabel.Location = New System.Drawing.Point(211, 66)
        Me.orLabel.Name = "orLabel"
        Me.orLabel.Size = New System.Drawing.Size(23, 13)
        Me.orLabel.TabIndex = 6
        Me.orLabel.Text = "OR"
        '
        'clearList
        '
        Me.clearList.Location = New System.Drawing.Point(376, 144)
        Me.clearList.Name = "clearList"
        Me.clearList.Size = New System.Drawing.Size(75, 23)
        Me.clearList.TabIndex = 7
        Me.clearList.Text = "ClearList"
        Me.clearList.UseVisualStyleBackColor = True
        '
        'parse
        '
        Me.parse.Location = New System.Drawing.Point(460, 94)
        Me.parse.Name = "parse"
        Me.parse.Size = New System.Drawing.Size(75, 23)
        Me.parse.TabIndex = 8
        Me.parse.Text = "Parse"
        Me.parse.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(615, 642)
        Me.Controls.Add(Me.parse)
        Me.Controls.Add(Me.clearList)
        Me.Controls.Add(Me.orLabel)
        Me.Controls.Add(Me.urlLabel)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.go)
        Me.Controls.Add(Me.urlField)
        Me.Controls.Add(Me.txtDocumentName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Vcrawl"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub enableParseButton()
        Try
            btnParse.Enabled = (txtDocumentName.Text.Length > 0)
        Catch ex As Exception
        End Try
    End Sub

    Private Function ExtractEmailAddressesFromString(ByVal source As String) As String()
        Dim mc As MatchCollection
        Dim i As Integer

        ' expression garnered from www.regexlib.com - thanks guys!
        mc = Regex.Matches(source, "([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})")
        Dim results(mc.Count - 1) As String
        For i = 0 To results.Length - 1
            results(i) = mc(i).Value
        Next

        Return results
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDocumentName.Text = ""
        enableParseButton()
    End Sub

    Private Sub txtDocumentName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocumentName.TextChanged, urlField.TextChanged
        enableParseButton()
    End Sub

    Private Sub btnParse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        ' Dim app As Word.Application
        ' Dim doc As Word.Document
        'Url of the website
        Dim url As String = urlField.Text
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(url)
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim sourceString As String = sr.ReadToEnd()
        Cursor.Current = Cursors.WaitCursor
        Try
            ' init UI controls
            lblFindCount.Text = ""
            txtResults.Text = ""
            txtDocContents.Text = ""
            ' search for email addresses
            Dim emails As String()
            Dim email As String
            Dim results As New StringBuilder
            emails = ExtractEmailAddressesFromString(sourceString)
            For Each email In emails
                results.Append(email & vbNewLine)
            Next

            ' display results
            lblFindCount.Text = String.Format("{0} match(es) found.", emails.Length)
            txtResults.Text = results.ToString
            txtDocContents.Text = sourceString
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog

        Try
            ofd.CheckFileExists = True
            ofd.CheckPathExists = True
            ofd.Filter = "Word Documents (*.doc)|*.doc|Rich Text Documents (*.rtf)|*.rtf|Text Documents (*.txt)|*.txt"
            ofd.Title = "Select Document"
            If ofd.ShowDialog = DialogResult.OK Then
                txtDocumentName.Text = ofd.FileName
            End If
        Finally
            If Not ofd Is Nothing Then ofd.Dispose()
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub clearList_Click(sender As Object, e As EventArgs) Handles clearList.Click
        txtResults.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles parse.Click
        Dim app As Object
        Dim doc As Object
        Dim docFileName As String
        Dim docPath As String
        Dim contents As String

        Cursor.Current = Cursors.WaitCursor

        Try
            ' init UI controls
            lblFindCount.Text = ""
            txtResults.Text = ""
            txtDocContents.Text = ""

            ' validate file name
            docFileName = txtDocumentName.Text
            If docFileName.Length = 0 Then
                MsgBox("Please enter a file name")
                txtDocumentName.Focus()
                Return
            End If

            ' if no path use APP_BASE
            docPath = Path.GetDirectoryName(docFileName)
            If docPath.Length = 0 Then
                docFileName = Application.StartupPath & "\" & docFileName
            End If

            ' ensure file exists
            If Not File.Exists(docFileName) Then
                MsgBox("File does not exist")
                txtDocumentName.SelectAll()
                txtDocumentName.Focus()
                Return
            End If

            ' extract contents of file
            contents = ""
            If Path.GetExtension(docFileName).ToLower = ".txt" Then
                Dim fs As StreamReader = New StreamReader(docFileName)

                Try
                    contents = fs.ReadToEnd
                Catch ex As Exception
                    MsgBox("Unable to read from text input file")
                    contents = ""
                Finally
                    If Not fs Is Nothing Then fs.Close()
                End Try
            Else

                Try
                    Try
                        app = New Microsoft.Office.Interop.Word.Application
                        app = CreateObject("Word.Application")
                    Catch ex As Exception
                        MsgBox("Unable to start Word")
                        Throw ex
                    End Try

                    Try
                        doc = app.Documents.Open(docFileName)
                    Catch ex As Exception
                        MsgBox("Unable to load document in Word")
                        Throw ex
                    End Try

                    contents = doc.Content.Text
                Catch ex As Exception
                    contents = ""
                End Try
            End If

            If contents.Length = 0 Then Return

            ' search for email addresses
            Dim emails As String()
            Dim email As String
            Dim results As New StringBuilder
            emails = ExtractEmailAddressesFromString(contents)
            For Each email In emails
                results.Append(email & vbNewLine)
            Next

            ' display results
            lblFindCount.Text = String.Format("{0} match(es) found.", emails.Length)
            txtResults.Text = results.ToString
            txtDocContents.Text = contents
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub
End Class
