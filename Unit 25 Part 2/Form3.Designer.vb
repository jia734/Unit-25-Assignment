<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        CheckedListBox1 = New CheckedListBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.Location = New Point(37, 499)
        Button1.Name = "Button1"
        Button1.Size = New Size(233, 77)
        Button1.TabIndex = 0
        Button1.Text = "Create"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.Location = New Point(306, 499)
        Button2.Name = "Button2"
        Button2.Size = New Size(233, 77)
        Button2.TabIndex = 1
        Button2.Text = "Main Menu"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Unit 1: Online World", "Unit 2: Technology Systems", "Unit 3: Digital Portfolio", "Unit 4: Creating Digital Animation", "Unit 5: Creating Digital Audio", "Unit 6: Creating Digital Graphics", "Unit 7: Creating Digital Video", "Unit 8: Mobile Apps Development", "Unit 9: Spreadsheet Development", "Unit 10: Database Development", "Unit 11: Computer Networks", "Unit 12: Software Development", "Unit 13: websute Development", "Unit 14: Installing and Maintaining Computer Hardware", ""})
        CheckedListBox1.Location = New Point(63, 184)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(401, 256)
        CheckedListBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(83, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 32)
        Label1.TabIndex = 3
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(109, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 32)
        Label2.TabIndex = 4
        Label2.Text = "ID"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(196, 46)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(193, 31)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(196, 105)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(193, 31)
        TextBox2.TabIndex = 6
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(575, 617)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CheckedListBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
