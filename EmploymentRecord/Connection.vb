Imports MySql.Data.MySqlClient


Module Connection

    Public Function connection() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=root;password=balboa_1234!$#;database=employment_db")
    End Function
    Public conn As MySqlConnection = connection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub create(ByVal sql As String)
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed To save the Data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Success To save the Data", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub reload(ByVal sql As String, ByVal dgv As Object)
        Try
            dt = New DataTable
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            dgv.datasource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub updates(ByVal sql As String)
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = sql

                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MessageBox.Show("Failed To update the Data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Success To update the Data", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = sql

                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MessageBox.Show("Failed To delete the Data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Success To delete the Data", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Module
