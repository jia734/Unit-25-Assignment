<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        dgvRecords = New DataGridView()
        cboRecordsName = New ComboBox()
        cboRecordsLevel = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        colRecordsStudentsName = New DataGridViewTextBoxColumn()
        colRecordsStudentID = New DataGridViewTextBoxColumn()
        colRecordsLevel = New DataGridViewTextBoxColumn()
        colRecordUnit = New DataGridViewTextBoxColumn()
        colRecordAttendance = New DataGridViewTextBoxColumn()
        CType(dgvRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.Location = New Point(425, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(205, 79)
        Button1.TabIndex = 0
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.Location = New Point(289, 344)
        Button2.Name = "Button2"
        Button2.Size = New Size(205, 79)
        Button2.TabIndex = 1
        Button2.Text = "Main Menu"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' dgvRecords
        ' 
        dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecords.Columns.AddRange(New DataGridViewColumn() {colRecordsStudentsName, colRecordsStudentID, colRecordsLevel, colRecordUnit, colRecordAttendance})
        dgvRecords.Location = New Point(12, 182)
        dgvRecords.Name = "dgvRecords"
        dgvRecords.RowHeadersWidth = 62
        dgvRecords.Size = New Size(800, 122)
        dgvRecords.TabIndex = 2
        ' 
        ' cboRecordsName
        ' 
        cboRecordsName.FormattingEnabled = True
        cboRecordsName.Items.AddRange(New Object() {"James", "Tony", "Maria", "Grace", "Leo"})
        cboRecordsName.Location = New Point(201, 28)
        cboRecordsName.Name = "cboRecordsName"
        cboRecordsName.Size = New Size(182, 33)
        cboRecordsName.TabIndex = 3
        ' 
        ' cboRecordsLevel
        ' 
        cboRecordsLevel.FormattingEnabled = True
        cboRecordsLevel.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3"})
        cboRecordsLevel.Location = New Point(201, 97)
        cboRecordsLevel.Name = "cboRecordsLevel"
        cboRecordsLevel.Size = New Size(182, 33)
        cboRecordsLevel.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 5
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 25)
        Label2.TabIndex = 6
        Label2.Text = "Level"
        ' 
        ' colRecordsStudentsName
        ' 
        colRecordsStudentsName.HeaderText = "Student Name"
        colRecordsStudentsName.MinimumWidth = 8
        colRecordsStudentsName.Name = "colRecordsStudentsName"
        colRecordsStudentsName.Width = 150
        ' 
        ' colRecordsStudentID
        ' 
        colRecordsStudentID.HeaderText = "Student ID"
        colRecordsStudentID.MinimumWidth = 8
        colRecordsStudentID.Name = "colRecordsStudentID"
        colRecordsStudentID.Width = 150
        ' 
        ' colRecordsLevel
        ' 
        colRecordsLevel.HeaderText = "Level"
        colRecordsLevel.MinimumWidth = 8
        colRecordsLevel.Name = "colRecordsLevel"
        colRecordsLevel.Width = 150
        ' 
        ' colRecordUnit
        ' 
        colRecordUnit.HeaderText = "Unit"
        colRecordUnit.MinimumWidth = 8
        colRecordUnit.Name = "colRecordUnit"
        colRecordUnit.Width = 150
        ' 
        ' colRecordAttendance
        ' 
        colRecordAttendance.HeaderText = "Attendance"
        colRecordAttendance.MinimumWidth = 8
        colRecordAttendance.Name = "colRecordAttendance"
        colRecordAttendance.Width = 150
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(858, 460)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cboRecordsLevel)
        Controls.Add(cboRecordsName)
        Controls.Add(dgvRecords)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form5"
        Text = "Form5"
        CType(dgvRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents cboRecordsName As ComboBox
    Friend WithEvents cboRecordsLevel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents colRecordsStudentsName As DataGridViewTextBoxColumn
    Friend WithEvents colRecordsStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colRecordsLevel As DataGridViewTextBoxColumn
    Friend WithEvents colRecordUnit As DataGridViewTextBoxColumn
    Friend WithEvents colRecordAttendance As DataGridViewTextBoxColumn
End Class
