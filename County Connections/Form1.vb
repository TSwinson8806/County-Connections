Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            lblServerList.Show()
            btnCopyServerSelection.Show()
        Else
            lstServerList.Hide()
            lblServerList.Hide()
            btnCopyServerSelection.Hide()
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
End Class
