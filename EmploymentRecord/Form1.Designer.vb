<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbMiddleName = New System.Windows.Forms.TextBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbSalary = New System.Windows.Forms.TextBox()
        Me.tbEmpID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvEmployeeList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middle_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobtitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbJobTitle = New System.Windows.Forms.ComboBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbSearchInput = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbSearchBy = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.dgvEmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(182, 66)
        Me.tbFirstName.Multiline = True
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(236, 33)
        Me.tbFirstName.TabIndex = 0
        '
        'tbMiddleName
        '
        Me.tbMiddleName.Location = New System.Drawing.Point(182, 127)
        Me.tbMiddleName.Multiline = True
        Me.tbMiddleName.Name = "tbMiddleName"
        Me.tbMiddleName.Size = New System.Drawing.Size(236, 33)
        Me.tbMiddleName.TabIndex = 1
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(182, 187)
        Me.tbLastName.Multiline = True
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(236, 33)
        Me.tbLastName.TabIndex = 2
        '
        'tbSalary
        '
        Me.tbSalary.Location = New System.Drawing.Point(182, 319)
        Me.tbSalary.Multiline = True
        Me.tbSalary.Name = "tbSalary"
        Me.tbSalary.Size = New System.Drawing.Size(236, 33)
        Me.tbSalary.TabIndex = 4
        '
        'tbEmpID
        '
        Me.tbEmpID.Location = New System.Drawing.Point(576, 418)
        Me.tbEmpID.Multiline = True
        Me.tbEmpID.Name = "tbEmpID"
        Me.tbEmpID.Size = New System.Drawing.Size(236, 33)
        Me.tbEmpID.TabIndex = 5
        Me.tbEmpID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(444, 419)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Employee ID :"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(39, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "First Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(41, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Last Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(15, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Middle Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(59, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Job Title :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(73, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Salary : "
        '
        'dgvEmployeeList
        '
        Me.dgvEmployeeList.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.middle_name, Me.last_name, Me.jobtitle, Me.salary, Me.DataGridViewTextBoxColumn1})
        Me.dgvEmployeeList.Location = New System.Drawing.Point(449, 57)
        Me.dgvEmployeeList.Name = "dgvEmployeeList"
        Me.dgvEmployeeList.RowTemplate.Height = 25
        Me.dgvEmployeeList.Size = New System.Drawing.Size(643, 338)
        Me.dgvEmployeeList.TabIndex = 12
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "first_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'middle_name
        '
        Me.middle_name.DataPropertyName = "middle_name"
        Me.middle_name.HeaderText = "Middle Name"
        Me.middle_name.Name = "middle_name"
        '
        'last_name
        '
        Me.last_name.DataPropertyName = "last_name"
        Me.last_name.HeaderText = "Last Name"
        Me.last_name.Name = "last_name"
        '
        'jobtitle
        '
        Me.jobtitle.DataPropertyName = "jobtitle"
        Me.jobtitle.HeaderText = "Job Title"
        Me.jobtitle.Name = "jobtitle"
        '
        'salary
        '
        Me.salary.DataPropertyName = "salary"
        Me.salary.HeaderText = "Salary"
        Me.salary.Name = "salary"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "emp_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'tbJobTitle
        '
        Me.tbJobTitle.FormattingEnabled = True
        Me.tbJobTitle.Items.AddRange(New Object() {"Front End Engineer", "Back End Engineer", "Full Stack Engineer", "Database Administrator", "Cloud Engineer", "Security Manager"})
        Me.tbJobTitle.Location = New System.Drawing.Point(182, 255)
        Me.tbJobTitle.Name = "tbJobTitle"
        Me.tbJobTitle.Size = New System.Drawing.Size(236, 23)
        Me.tbJobTitle.TabIndex = 13
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Location = New System.Drawing.Point(96, 397)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(91, 47)
        Me.btnCreate.TabIndex = 14
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(959, 480)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(133, 47)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Lime
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(210, 397)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 47)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(327, 397)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 47)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.Yellow
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReload.ForeColor = System.Drawing.Color.White
        Me.btnReload.Location = New System.Drawing.Point(959, 418)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(133, 47)
        Me.btnReload.TabIndex = 18
        Me.btnReload.Text = "Show All"
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'emp_id
        '
        Me.emp_id.DataPropertyName = "emp_id"
        Me.emp_id.HeaderText = "Employee ID"
        Me.emp_id.Name = "emp_id"
        '
        'first_name
        '
        Me.first_name.DataPropertyName = "first_name"
        Me.first_name.HeaderText = "First Name"
        Me.first_name.Name = "first_name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(24, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(251, 32)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Employee Information"
        '
        'tbSearchInput
        '
        Me.tbSearchInput.Location = New System.Drawing.Point(441, 16)
        Me.tbSearchInput.Multiline = True
        Me.tbSearchInput.Name = "tbSearchInput"
        Me.tbSearchInput.Size = New System.Drawing.Size(268, 32)
        Me.tbSearchInput.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(709, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 25)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Search by :"
        '
        'cbSearchBy
        '
        Me.cbSearchBy.FormattingEnabled = True
        Me.cbSearchBy.Items.AddRange(New Object() {"ID", "Name"})
        Me.cbSearchBy.Location = New System.Drawing.Point(808, 21)
        Me.cbSearchBy.Name = "cbSearchBy"
        Me.cbSearchBy.Size = New System.Drawing.Size(121, 23)
        Me.cbSearchBy.TabIndex = 23
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(935, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(91, 32)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 544)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cbSearchBy)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbSearchInput)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.tbJobTitle)
        Me.Controls.Add(Me.dgvEmployeeList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbEmpID)
        Me.Controls.Add(Me.tbSalary)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbMiddleName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvEmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbMiddleName As TextBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbSalary As TextBox
    Friend WithEvents tbEmpID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvEmployeeList As DataGridView
    Friend WithEvents tbJobTitle As ComboBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnReload As Button
    Friend WithEvents emp_id As DataGridViewTextBoxColumn
    Friend WithEvents first_name As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents tbSearchInput As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbSearchBy As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents middle_name As DataGridViewTextBoxColumn
    Friend WithEvents last_name As DataGridViewTextBoxColumn
    Friend WithEvents jobtitle As DataGridViewTextBoxColumn
    Friend WithEvents salary As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
