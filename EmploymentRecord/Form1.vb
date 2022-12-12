
Public Class Form1



    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            create("INSERT INTO employees(first_name,middle_name,last_name,jobtitle,salary) 
            VALUES('" & tbFirstName.Text & "', '" & tbMiddleName.Text & "', '" & tbLastName.Text & "', '" & tbJobTitle.Text & "', ' " & Convert.ToDecimal(tbSalary.Text) & "' )")

            tbFirstName.Text = ""
            tbMiddleName.Text = ""
            tbLastName.Text = ""
            tbJobTitle.Text = ""
            tbSalary.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        reload("SELECT * FROM employees", dgvEmployeeList)
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Try
            reload("SELECT * FROM employees", dgvEmployeeList)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            updates("UPDATE employees SET first_name = '" & tbFirstName.Text & "', middle_name = '" & tbMiddleName.Text & "', last_name = '" & tbLastName.Text & "', jobtitle = '" & tbJobTitle.Text & "', salary = '" & Convert.ToDecimal(tbSalary.Text) & "' WHERE id = '" & tbEmpID.Text & "' ")
            tbFirstName.Text = ""
            tbMiddleName.Text = ""
            tbLastName.Text = ""
            tbJobTitle.Text = ""
            tbSalary.Text = ""
            tbEmpID.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        reload("SELECT * FROM employees", dgvEmployeeList)
    End Sub

    Private Sub dgvEmployeeList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellContentClick
        tbEmpID.Text = dgvEmployeeList.CurrentRow.Cells(0).Value
        tbFirstName.Text = dgvEmployeeList.CurrentRow.Cells(2).Value
        tbMiddleName.Text = dgvEmployeeList.CurrentRow.Cells(3).Value
        tbLastName.Text = dgvEmployeeList.CurrentRow.Cells(4).Value
        tbJobTitle.Text = dgvEmployeeList.CurrentRow.Cells(5).Value
        tbSalary.Text = dgvEmployeeList.CurrentRow.Cells(6).Value
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete("DELETE FROM employees WHERE id = '" & Convert.ToInt32(tbEmpID.Text) & "'")
            tbFirstName.Text = ""
            tbMiddleName.Text = ""
            tbLastName.Text = ""
            tbJobTitle.Text = ""
            tbSalary.Text = ""
            tbEmpID.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        reload("SELECT * FROM employees", dgvEmployeeList)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            reload("SELECT * FROM employees", dgvEmployeeList)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbSearchBy.Text = "ID" Then
            Try
                reload("SELECT * FROM employees WHERE id = ' " & tbSearchInput.Text & " '", dgvEmployeeList)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                reload("SELECT * FROM employees WHERE CONCAT(first_name, ' ', middle_name, ' ', last_name) LIKE '%" & tbSearchInput.Text & "%'", dgvEmployeeList)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
