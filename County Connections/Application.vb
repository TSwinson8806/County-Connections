Imports System.Configuration
Imports System.Data.SQLite
Imports System.IO


Public Class Application
    Private _intId As Integer
    Private _strName As String
    Private _strPath As String
    Private _intIsDefault As Integer

    Public Property Id As String
        Get
            Return _intId
        End Get
        Set(value As String)
            _intId = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _strName
        End Get
        Set(value As String)
            _strName = value
        End Set
    End Property

    Public Property Path As String
        Get
            Return _strPath
        End Get
        Set(value As String)
            _strPath = value
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

    Public Shared Sub NewIsDefaultSelection()
        Dim conn As SQLiteConnection = DbConnection.GetConnection()
        Dim SQL As String = "UPDATE Application SET IsDefault = 0 "

        Dim updateCmd As SQLiteCommand = New SQLiteCommand(SQL, conn)

        Dim transcount As Integer
        conn.Open()
        transcount = updateCmd.ExecuteNonQuery()

    End Sub

    Public Shared Function AddApplication(ByVal newApplication As Application) As Integer
        Dim conn As SQLiteConnection = DbConnection.GetConnection()

        Dim SQL As String = "INSERT INTO Application (Name, Path, IsDefault) "
        SQL += "VALUES(@name, @path, @isdefault)"

        Dim insertCmd As SQLiteCommand = New SQLiteCommand(SQL, conn)
        insertCmd.Parameters.AddWithValue("@name", newApplication.Name.ToString())
        insertCmd.Parameters.AddWithValue("@path", newApplication.Path.ToString())
        insertCmd.Parameters.AddWithValue("@isdefault", newApplication.IsDefault)

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

    Public Shared Function DeleteApplication(ByVal application As Application) As Integer
        Dim conn As SQLiteConnection = DbConnection.GetConnection()

        Dim SQL As String = "DELETE FROM Application WHERE Name = @name"

        Dim deleteCmd As SQLiteCommand = New SQLiteCommand(SQL, conn)
        deleteCmd.Parameters.AddWithValue("@name", application.Name.ToString())

        Dim transcount As Integer

        Try
            AdditionalInfo.Delete(application)
            conn.Open()
            transcount = deleteCmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            conn.Close()
        End Try

        Return transcount
    End Function

End Class
