Imports System.Configuration
Imports System.Data.SQLite
Imports System.IO

Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnection.CheckTablesExist()

        LoadCountyList()
        LoadApplicationList()

        lstCounty.Items.Add("CUC")
        lstCounty.Items.Add("Dallas")
        lstCounty.Items.Add("Midland")
        lstCounty.Items.Add("Tarrant")
        lstCounty.Items.Add("Travis")

        lstApplication.Items.Add("DB")
        lstApplication.Items.Add("Excel")
        lstApplication.Items.Add("Firefox")
        lstApplication.Items.Add("Profiler")
        lstApplication.Items.Add("Visual Studio 2012")
        lstApplication.Items.Add("Visual Studio 2015")

        lstCounty.SelectedIndex = 4
        lstApplication.SelectedIndex = 0



    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click

        Dim connMakeDB As SQLiteConnection = New SQLiteConnection("CountyConnections.sqlite")
        Dim conn = New SQLiteConnection("Data Source=CountyConnections.sqlite;Version3")
        conn.Open()

        Dim strPart1 As String
        Dim strPart2 As String
        Dim strFullString As String

        strPart1 = GetCounty()
        strPart2 = GetApplication()

        If strPart1 = String.Empty Or strPart2 = String.Empty Then
            MsgBox("Please select a county and an application from the lists")
        Else
            Me.ShowOrHideServerList()
            strFullString = strPart1 + strPart2

            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " /C " + strFullString
            pi.FileName = "cmd.exe"
            p.StartInfo = pi
            p.Start()
        End If


    End Sub


    Function GetCounty() As String
        Dim strPart1 As String

        If lstCounty.SelectedIndex < 0 Then
            strPart1 = String.Empty
        ElseIf lstCounty.SelectedItem.ToString() = "CUC" Then
            strPart1 = "runas /netonly /user:Prosecutor\tony.swinson"
        ElseIf lstCounty.SelectedItem.ToString() = "Dallas" Then
            strPart1 = "runas /netonly /user:Dallascounty\jimmy.puckett"
        ElseIf lstCounty.SelectedItem.ToString() = "Midland" Then
            strPart1 = "runas /netonly /user:midco\daapp"
        ElseIf lstCounty.SelectedItem.ToString() = "Tarrant" Then
            strPart1 = "runas /netonly /user:tarrantcounty\nce_tswinson"
        ElseIf lstCounty.SelectedItem.ToString() = "Travis" Then
            strPart1 = "runas /netonly /user:travis\SwinsoT"
        Else
            strPart1 = String.Empty
        End If

        Return strPart1
    End Function


    Function GetApplication() As String
        Dim strPart2 As String

        If lstApplication.SelectedIndex < 0 Then
            strPart2 = String.Empty
        ElseIf lstApplication.SelectedItem.ToString() = "DB" Then
            strPart2 = " ""C:\Program Files (x86)\Microsoft SQL Server\110\Tools\Binn\ManagementStudio\Ssms.exe"" "
        ElseIf lstApplication.SelectedItem.ToString() = "Excel" Then
            strPart2 = " ""C:\Program Files\Microsoft Office 15\root\office15\excel.exe"" "
        ElseIf lstApplication.SelectedItem.ToString() = "Firefox" Then
            strPart2 = " ""C:\Program Files (x86)\Mozilla Firefox\firefox.exe"" "
        ElseIf lstApplication.SelectedItem.ToString() = "Profiler" Then
            strPart2 = " ""C:\Program Files (x86)\Microsoft SQL Server\110\Tools\Binn\PROFILER.EXE"" "
        ElseIf lstApplication.SelectedItem.ToString() = "Visual Studio 2012" Then
            strPart2 = " ""C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\devenv.exe"" "
        ElseIf lstApplication.SelectedItem.ToString() = "Visual Studio 2015" Then
            strPart2 = " ""C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe"" "
        Else
            strPart2 = String.Empty
        End If

        Return strPart2
    End Function

    Private Sub ShowOrHideServerList()
        If lstApplication.SelectedItem.ToString() = "DB" Then
            PopulateServerList()
            lstServerList.Show()
            lblAdditionalInfo.Show()
            btnCopyServerSelection.Show()
            btnAddAdditionalInfo.Show()
            btnDeleteAdditionalInfo.Show()
        Else
            lstServerList.Hide()
            lblAdditionalInfo.Hide()
            btnCopyServerSelection.Hide()
            btnAddAdditionalInfo.Hide()
            btnDeleteAdditionalInfo.Hide()
        End If
    End Sub

    Private Sub PopulateServerList()
        lstServerList.Items.Clear()

        If lstCounty.SelectedItem.ToString() = "CUC" Then
            lstServerList.Items.Add("67.192.100.49")
            lstServerList.Items.Add("67.192.100.49\SQL2012")
        ElseIf lstCounty.SelectedItem.ToString() = "Dallas" Then
            lstServerList.Items.Add("C1CRSQL103\CRDB1i3")
        ElseIf lstCounty.SelectedItem.ToString() = "Midland" Then
            lstServerList.Items.Add("SQLUCS01\DA")
        ElseIf lstCounty.SelectedItem.ToString() = "Tarrant" Then
            lstServerList.Items.Add("S08JUSTICETST01\S08JUSTICETST01")
            lstServerList.Items.Add("S08JUSTICEDEV01\S08JUSTICEDEV01")
        ElseIf lstCounty.SelectedItem.ToString() = "Travis" Then
            lstServerList.Items.Add("SandwortDev")
            lstServerList.Items.Add("SandwortTest")
            lstServerList.Items.Add("SandwortTPT")
            lstServerList.Items.Add("FirewheelT")
        Else

        End If
    End Sub

    Private Sub btnCopyServerSelection_Click(sender As Object, e As EventArgs) Handles btnCopyServerSelection.Click
        Dim data_object As New DataObject
        Dim copyString As String

        If lstServerList.SelectedIndex < 0 Then

        Else
            copyString = lstServerList.SelectedItem.ToString
            data_object.SetData(DataFormats.Text, copyString)
            Clipboard.SetDataObject(data_object)
        End If
    End Sub

    Private Sub btnShowConnectionText_Click(sender As Object, e As EventArgs) Handles btnShowConnectionText.Click
        Dim strPart1 As String
        Dim strPart2 As String
        Dim strFullString As String

        If btnShowConnectionText.Text = "Show Connection Text" Then
            txtConnectionText.Text = String.Empty
            lblConnectionText.Visible = True
            txtConnectionText.Visible = True

            strPart1 = GetCounty()
            strPart2 = GetApplication()

            If strPart1 = String.Empty Or strPart2 = String.Empty Then
                MsgBox("Please select a county and an application from the lists")
            Else
                strFullString = strPart1 + strPart2
                txtConnectionText.Text = strFullString
            End If


            btnShowConnectionText.Text = "Hide Connection Text"
        Else
            txtConnectionText.Text = String.Empty
            lblConnectionText.Visible = False
            txtConnectionText.Visible = False
            btnShowConnectionText.Text = "Show Connection Text"
        End If

    End Sub

    Private Sub btnAddCounty_Click(sender As Object, e As EventArgs) Handles btnAddCounty.Click
        Me.Hide()
        County_Editor.Show()
    End Sub

    Private Sub btnDeleteCounty_Click(sender As Object, e As EventArgs) Handles btnDeleteCounty.Click
        If ListBox1.SelectedIndex > 0 Then
            Dim selection As String = ListBox1.SelectedItem.ToString()
            Dim message As String = "Are you sure you want to delete " & selection & "?"
            Dim response = MsgBox(message, MsgBoxStyle.OkCancel, "Confirm Delete")

            If response = MsgBoxResult.Ok Then
                County.DeleteCounty(Me.GetSelectedCounty())
            End If

            LoadCountyList()

        Else
            Dim message As String = "Please select a county to delete."
            MsgBox(message, MsgBoxStyle.OkOnly)
        End If

    End Sub

    Private Function GetSelectedCounty() As County
        Dim conn As SQLiteConnection = DbConnection.GetConnection()
        Dim SQL As String = "SELECT * FROM County WHERE Name = @name"

        Dim county As County = New County()
        Dim selectedName As String

        TextBox6.Text = ListBox1.SelectedItem.ToString
        selectedName = ListBox1.SelectedItem.ToString

        Dim selectCmd As SQLiteCommand = New SQLiteCommand(SQL, conn)
        selectCmd.Parameters.AddWithValue("@name", selectedName)

        conn.Open()
        Dim reader As SQLiteDataReader = selectCmd.ExecuteReader()

        While (reader.Read())
            county.Id = reader("Id")
            county.CountyName = reader("Name").ToString()
            county.Domain = reader("Domain").ToString()
            county.Username = reader("Username").ToString()
            county.IsDefault = reader("IsDefault")
        End While

        conn.Close()
        Return county
    End Function

    Private Function GetSelectedApplication() As Application
        Dim conn As SQLiteConnection = DbConnection.GetConnection()
        Dim SQL As String = "SELECT * FROM Application WHERE Name = @name"

        Dim application As New Application()

        Dim selectedName As String

        TextBox7.Text = ListBox2.SelectedItem.ToString
        selectedName = ListBox2.SelectedItem.ToString

        Dim selectCmd As SQLiteCommand = New SQLiteCommand(SQL, conn)
        selectCmd.Parameters.AddWithValue("@name", selectedName)

        conn.Open()
        Dim reader As SQLiteDataReader = selectCmd.ExecuteReader()

        While (reader.Read())
            application.Id = reader("Id")
            application.Name = reader("Name").ToString()
            application.Path = reader("Path").ToString()
            application.IsDefault = reader("IsDefault")
        End While

        conn.Close()
        Return application
    End Function

    Public Sub LoadCountyList()
        Dim conn As SQLiteConnection = DbConnection.GetConnection()
        conn.Open()
        Dim sql As String = "SELECT Name FROM County ORDER BY Name"
        Dim selectCmd As SQLiteCommand = New SQLiteCommand(sql, conn)
        Dim reader As SQLiteDataReader = selectCmd.ExecuteReader()

        ListBox1.Items.Clear()
        While (reader.Read())
            ListBox1.Items.Add(reader("Name"))
        End While
        conn.Close()
    End Sub

    Public Sub LoadApplicationList()
        Dim conn As SQLiteConnection = DbConnection.GetConnection()
        conn.Open()
        Dim sql As String = "SELECT Name FROM Application ORDER BY Name"
        Dim selectCmd As SQLiteCommand = New SQLiteCommand(sql, conn)
        Dim reader As SQLiteDataReader = selectCmd.ExecuteReader()

        ListBox2.Items.Clear()
        While (reader.Read())
            ListBox2.Items.Add(reader("Name"))
        End While
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim county As New County

        county = Me.GetSelectedCounty()

        TextBox1.Text = county.Id
        TextBox2.Text = county.CountyName
        TextBox3.Text = county.Domain
        TextBox4.Text = county.Username
        TextBox5.Text = county.IsDefault
    End Sub

    Private Sub btnAddApplication_Click(sender As Object, e As EventArgs) Handles btnAddApplication.Click
        Me.Hide()
        Application_Editor.Show()
    End Sub

    Public Shared Sub Reload()
        'LoadApplicationList()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()

    End Sub
End Class
