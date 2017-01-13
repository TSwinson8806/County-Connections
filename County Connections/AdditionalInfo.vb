Imports System.Data.SQLite
Imports System.IO
Imports System.Configuration

Public Class AdditionalInfo
    Private _intId As Integer
    Private _applicationId As Integer
    Private _countyId As Integer
    Private _description As String

    Public Property Id As String
        Get
            Return _intId
        End Get
        Set(value As String)
            _intId = value
        End Set
    End Property

    Public Property ApplicationId As String
        Get
            Return _applicationId
        End Get
        Set(value As String)
            _applicationId = value
        End Set
    End Property

    Public Property CountyId As String
        Get
            Return _countyId
        End Get
        Set(value As String)
            _countyId = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Shared Sub New()
        Dim additionalInfo As AdditionalInfo = New AdditionalInfo()

        additionalInfo.Id = 0
        additionalInfo.ApplicationId = 0
        additionalInfo.CountyId = 0
        additionalInfo.Description = ""
    End Sub

    Public Shared Function Delete(ByVal county As County) As Integer
        Dim conn As SQLiteConnection = DbConnection.GetConnection()

        Dim SQL As String = "DELETE FROM AdditionalInfo WHERE CountyId = @countyId"

        Dim deleteCmd As SQLiteCommand = New SQLiteCommand(SQL, conn)
        deleteCmd.Parameters.AddWithValue("@countyId", county.Id)

        Dim transcount As Integer

        Try
            conn.Open()
            transcount = deleteCmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            conn.Close()
        End Try

        Return transcount
    End Function

    Public Shared Function Delete(ByVal application As Application) As Integer
        Dim conn As SQLiteConnection = DbConnection.GetConnection()

        Dim SQL As String = "DELETE FROM AdditionalInfo WHERE ApplicationId = @applicationId"

        Dim deleteCmd As SQLiteCommand = New SQLiteCommand(SQL, conn)
        deleteCmd.Parameters.AddWithValue("@applicationId", application.Id)

        Dim transcount As Integer

        Try
            conn.Open()
            transcount = deleteCmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            conn.Close()
        End Try

        Return transcount
    End Function

    Public Shared Function Delete(ByVal additionalInfo As AdditionalInfo) As Integer
        Dim conn As SQLiteConnection = DbConnection.GetConnection()

        Dim SQL As String = "DELETE FROM AdditionalInfo WHERE Id = @id"

        Dim deleteCmd As SQLiteCommand = New SQLiteCommand(SQL, conn)
        deleteCmd.Parameters.AddWithValue("@id", additionalInfo.Id)

        Dim transcount As Integer

        Try
            conn.Open()
            transcount = deleteCmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            conn.Close()
        End Try

        Return transcount
    End Function

End Class
