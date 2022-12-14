Module Module1
    Public accLvl As String
    Public cn As New OleDb.OleDbConnection
    Public cm As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader

    Public Sub connection()
        cn = New OleDb.OleDbConnection
        With cn
            'Provider must be Microsoft.Jet.OLEDB.4.0, find the access file, and test the connection
            .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\VSSdatabase.mdb"
            .Open()
        End With

    End Sub


End Module
