<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        dgvAttendance = New DataGridView()
        colStudentsName = New DataGridViewTextBoxColumn()
        colStudentID = New DataGridViewTextBoxColumn()
        colLevel = New DataGridViewTextBoxColumn()
        colUnits = New DataGridViewTextBoxColumn()
        colPresent = New DataGridViewCheckBoxColumn()
        cboNameSelect = New ComboBox()
        cboLevelSelect = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendance.Columns.AddRange(New DataGridViewColumn() {colStudentsName, colStudentID, colLevel, colUnits, colPresent})
        dgvAttendance.Location = New Point(12, 201)
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.RowHeadersWidth = 62
        dgvAttendance.Size = New Size(809, 121)
        dgvAttendance.TabIndex = 0
        ' 
        ' colStudentsName
        ' 
        colStudentsName.HeaderText = "Students Name"
        colStudentsName.MinimumWidth = 8
        colStudentsName.Name = "colStudentsName"
        colStudentsName.Width = 150
        ' 
        ' colStudentID
        ' 
        colStudentID.HeaderText = "Student ID"
        colStudentID.MinimumWidth = 8
        colStudentID.Name = "colStudentID"
        colStudentID.Width = 150
        ' 
        ' colLevel
        ' 
        colLevel.HeaderText = "Level"
        colLevel.MinimumWidth = 8
        colLevel.Name = "colLevel"
        colLevel.Width = 150
        ' 
        ' colUnits
        ' 
        colUnits.HeaderText = "Units"
        colUnits.MinimumWidth = 8
        colUnits.Name = "colUnits"
        colUnits.Width = 150
        ' 
        ' colPresent
        ' 
        colPresent.HeaderText = "Present"
        colPresent.MinimumWidth = 8
        colPresent.Name = "colPresent"
        colPresent.Width = 150
        ' 
        ' cboNameSelect
        ' 
        cboNameSelect.FormattingEnabled = True
        cboNameSelect.Items.AddRange(New Object() {"James", "Tony", "Maria", "Grace", "Loe"})
        cboNameSelect.Location = New Point(140, 40)
        cboNameSelect.Name = "cboNameSelect"
        cboNameSelect.Size = New Size(194, 33)
        cboNameSelect.TabIndex = 1
        ' 
        ' cboLevelSelect
        ' 
        cboLevelSelect.FormattingEnabled = True
        cboLevelSelect.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3"})
        cboLevelSelect.Location = New Point(140, 105)
        cboLevelSelect.Name = "cboLevelSelect"
        cboLevelSelect.Size = New Size(194, 33)
        cboLevelSelect.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(27, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 32)
        Label1.TabIndex = 3
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(50, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 32)
        Label2.TabIndex = 4
        Label2.Text = "Level"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Button1.Location = New Point(470, 64)
        Button1.Name = "Button1"
        Button1.Size = New Size(204, 66)
        Button1.TabIndex = 5
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Button2.Location = New Point(164, 362)
        Button2.Name = "Button2"
        Button2.Size = New Size(197, 66)
        Button2.TabIndex = 6
        Button2.Text = "Mark Attendance "
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Button3.Location = New Point(496, 362)
        Button3.Name = "Button3"
        Button3.Size = New Size(204, 66)
        Button3.TabIndex = 7
        Button3.Text = "Main Menu"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(858, 467)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cboLevelSelect)
        Controls.Add(cboNameSelect)
        Controls.Add(dgvAttendance)
        Name = "Form4"
        Text = "Form4"
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents colStudentsName As DataGridViewTextBoxColumn
    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colLevel As DataGridViewTextBoxColumn
    Friend WithEvents colUnits As DataGridViewTextBoxColumn
    Friend WithEvents colPresent As DataGridViewCheckBoxColumn
    Friend WithEvents cboNameSelect As ComboBox
    Friend WithEvents cboLevelSelect As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
