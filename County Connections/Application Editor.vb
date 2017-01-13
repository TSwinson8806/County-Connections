Imports System.Configuration
Imports System.Data.SQLite
Imports System.IO

Public Class Application_Editor

    Private Sub Application_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newApplication As New Application
        newApplication.Name = txtApplicationName.Text

        Dim strPath As String = " """ & txtApplicationPath.Text & " """
        newApplication.Path = strPath.ToString()

        If chkApplicationIsDefault.Checked = True Then
            Application.NewIsDefaultSelection()
            newApplication.IsDefault = 1
        Else
            newApplication.IsDefault = 0
        End If

        Application.AddApplication(newApplication)

        Dim f1 As New Main
        Me.Close()
        f1.Show()
    End Sub
End Class