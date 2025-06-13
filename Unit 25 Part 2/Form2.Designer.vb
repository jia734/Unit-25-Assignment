<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        CheckedListBox2 = New CheckedListBox()
        Level2Combobox = New ComboBox()
        Name = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Button1.Location = New Point(90, 311)
        Button1.Name = "Button1"
        Button1.Size = New Size(230, 61)
        Button1.TabIndex = 0
        Button1.Text = "Create"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Button2.Location = New Point(362, 311)
        Button2.Name = "Button2"
        Button2.Size = New Size(230, 61)
        Button2.TabIndex = 1
        Button2.Text = "Main Menu"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.Font = New Font("Segoe UI", 10F)
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Unit 12 Software Developement"})
        CheckedListBox1.Location = New Point(329, 179)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(335, 97)
        CheckedListBox1.TabIndex = 2
        ' 
        ' CheckedListBox2
        ' 
        CheckedListBox2.FormattingEnabled = True
        CheckedListBox2.Items.AddRange(New Object() {"James"})
        CheckedListBox2.Location = New Point(90, 179)
        CheckedListBox2.Name = "CheckedListBox2"
        CheckedListBox2.Size = New Size(202, 88)
        CheckedListBox2.TabIndex = 3
        ' 
        ' Level2Combobox
        ' 
        Level2Combobox.FormattingEnabled = True
        Level2Combobox.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3"})
        Level2Combobox.Location = New Point(433, 89)
        Level2Combobox.Name = "Level2Combobox"
        Level2Combobox.Size = New Size(159, 33)
        Level2Combobox.TabIndex = 4
        ' 
        ' Name
        ' 
        Name.Location = New Point(129, 60)
        Name.Name = "Name"
        Name.PlaceholderText = "Name"
        Name.Size = New Size(178, 31)
        Name.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(129, 107)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "ID"
        TextBox2.Size = New Size(178, 31)
        TextBox2.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(351, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 25)
        Label1.TabIndex = 7
        Label1.Text = "Level"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(713, 434)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(Name)
        Controls.Add(Level2Combobox)
        Controls.Add(CheckedListBox2)
        Controls.Add(CheckedListBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents Level2Combobox As ComboBox
    Friend WithEvents Name As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
End Class
