Imports System.Configuration
Imports System.Data.SQLite
Imports System.IO

Public Class County_Editor
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newCounty As New County
        newCounty.CountyName = txtCountyName.Text
        newCounty.Domain = txtCountyDomain.Text
        newCounty.Username = txtCountyUsername.Text

        If chkCountyIsDefault.Checked = True Then
            County.NewIsDefaultSelection()
            newCounty.IsDefault = 1
        Else
            newCounty.IsDefault = 0
        End If

        County.AddCounty(newCounty)

        Dim f1 As New Main
        Me.Close()
        f1.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
End Class