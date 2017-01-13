Imports System.Data
Imports System.Data.SQLite
Imports System.IO


Public Class DbConnection
    Public Shared Function GetConnection() As SQLiteConnection
        Dim connectionString As String = "Data Source=CountyConnections.sqlite;Version=3"
        Return New SQLiteConnection(connectionString)
    End Function

    Public Shared Sub CheckTablesExist()
        Dim dbFile As String = "CountyConnections.sqlite"

        If File.Exists(Path.Combine(Directory.GetCurrentDirectory(), dbFile)) Then
            'do nothing because database exists
        Else
            SQLiteConnection.CreateFile("CountyConnections.sqlite")
        End If

        Dim conn As SQLiteConnection = DbConnection.GetConnection()
        conn.Open()

        Dim checkCountySql As String = "CREATE TABLE IF NOT EXISTS [County] ( [Id] INTEGER NOT NULL, [Name] TEXT NOT NULL, [Domain] TEXT NOT NULL, [Username] TEXT NOT NULL, [IsDefault] INTEGER DEFAULT 0 NOT NULL, CONSTRAINT [PK_County] PRIMARY KEY ([Id]));"
        Dim cmdCheckCountyExists As SQLiteCommand = New SQLiteCommand(checkCountySql, conn)
        Try
            cmdCheckCountyExists.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Dim checkApplicationSql As String = "CREATE TABLE IF NOT EXISTS [Application] ([Id] INTEGER NOT NULL, [Name] TEXT NOT NULL, [Path] TEXT NOT NULL, [IsDefault] INTEGER DEFAULT 0 NOT NULL, CONSTRAINT [PK_Application] PRIMARY KEY ([Id]));"
        Dim cmdCheckApplicationExists As SQLiteCommand = New SQLiteCommand(checkApplicationSql, conn)
        Try
            cmdCheckApplicationExists.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Dim checkAdditionalInfoSql As String = "CREATE TABLE IF NOT EXISTS [AdditionalInfo] ([Id] INTEGER NOT NULL, [ApplicationId] bigint NOT NULL, [CountyId] bigint NOT NULL, [Description] text NOT NULL, CONSTRAINT [sqlite_master_PK_AdditionalInfo] PRIMARY KEY ([Id]), FOREIGN KEY ([ApplicationId]) REFERENCES Application([Id]), FOREIGN KEY ([CountyId]) REFERENCES County([Id]));"
        Dim cmdCheckAdditionalInfoExists As SQLiteCommand = New SQLiteCommand(checkAdditionalInfoSql, conn)
        Try
            cmdCheckAdditionalInfoExists.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub
End Class
