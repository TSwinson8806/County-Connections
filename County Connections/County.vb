Imports System.Data.SQLite
Imports System.IO
Imports System.Configuration

Public Class County
    Private _intId As Integer
    Private _strCountyName As String
    Private _strDomain As String
    Private _strUsername As String
    Private _intIsDefault As Integer

    Public Property Id As Integer
        Get
            Return _intId
        End Get
        Set(value As Integer)
            _intId = value
        End Set
    End Property

    Public Property CountyName As String
        Get
            Return _strCountyName
        End Get
        Set(value As String)
            _strCountyName = value
        End Set
    End Property

    Public Property Domain As String
        Get
            Return _strDomain
        End Get
        Set(value As String)
            _strDomain = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _strUsername
        End Get
        Set(value As String)
            _strUsername = value
        End Set
    End Property

    Public Property IsDefault As Integer
        Get
            Return _intIsDefault
        End Get
        Set(value As Integer)
            _intIsDefault = value
        End Set
    End Property

    Public Shared Function GetCounties() As List(Of County)
        Dim conn As SQLiteConnection = DbConnection.GetConnection()

        Dim SQL As String = "SELECT * FROM County ORDER BY Name "

        Dim selectCmd As SQLiteCommand = New SQLiteCommand(SQL, conn)

        Try
            conn.Open()
            selectCmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            conn.Close()
        End Try

    End Function

    Public Shared Function AddCounty(ByVal newCounty As County) As Integer
        Dim conn As SQLiteConnection = DbConnection.GetConnection()

        Dim SQL As String = "INSERT INTO County (Name, Domain, Username, IsDefault) "
        SQL += "VALUES(@name, @domain, @username, @isdefault)"

        Dim insertCmd As SQLiteCommand = New SQLiteCommand(SQL, conn)
        insertCmd.Parameters.AddWithValue("@name", newCounty.CountyName.ToString())
        insertCmd.Parameters.AddWithValue("@domain", newCounty.Domain.ToString())
        insertCmd.Parameters.AddWithValue("@username", newCounty.Username.ToString())
        insertCmd.Parameters.AddWithValue("@isdefault", newCounty.IsDefault)

        Dim transcount As Integer

        Try
            conn.Open()
            transcount = insertCmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            conn.Close()
        End Try

        Return transcount
    End Function

    Public Shared Function DeleteCounty(ByVal county As County) As Integer
        Dim conn As SQLiteConnection = DbConnection.GetConnection()

        Dim SQL As String = "DELETE FROM County WHERE Name = @name"

        Dim deleteCmd As SQLiteCommand = New SQLiteCommand(SQL, conn)
        deleteCmd.Parameters.AddWithValue("@name", county.CountyName.ToString())

        Dim transcount As Integer

        Try
            AdditionalInfo.Delete(county)
            conn.Open()
            transcount = deleteCmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            conn.Close()
        End Try

        Return transcount
    End Function

    Public Shared Sub NewIsDefaultSelection()
        Dim conn As SQLiteConnection = DbConnection.GetConnection()
        Dim SQL As String = "UPDATE County SET IsDefault = 0 "

        Dim updateCmd As SQLiteCommand = New SQLiteCommand(SQL, conn)

        Dim transcount As Integer

        Try
            conn.Open()
            transcount = updateCmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            conn.Close()
        End Try
    End Sub
End Class
