<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans Ultra Bold Condensed", 14.25F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(525, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 26)
        Label1.TabIndex = 0
        Label1.Text = "السلسلة الاولى "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gill Sans Ultra Bold Condensed", 14.25F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(528, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 26)
        Label2.TabIndex = 1
        Label2.Text = "السلسلة الثانية"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Gill Sans Ultra Bold Condensed", 14.25F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(529, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 26)
        Label3.TabIndex = 2
        Label3.Text = "السلسلة الثالثة"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Gill Sans Ultra Bold Condensed", 14.25F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(549, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 26)
        Label4.TabIndex = 3
        Label4.Text = "النتيجة"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Gill Sans Ultra Bold Condensed", 12F)
        TextBox1.Location = New Point(186, 36)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(316, 33)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Gill Sans Ultra Bold Condensed", 12F)
        TextBox2.Location = New Point(186, 75)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(316, 31)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Gill Sans Ultra Bold Condensed", 12F)
        TextBox3.Location = New Point(186, 112)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(316, 36)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Gill Sans Ultra Bold Condensed", 12F)
        TextBox4.Location = New Point(186, 154)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(316, 36)
        TextBox4.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Gill Sans Ultra Bold Condensed", 11.25F)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(507, 211)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 60)
        Button1.TabIndex = 8
        Button1.Text = "Substring عملية "
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.Font = New Font("Gill Sans Ultra Bold Condensed", 11.25F)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(348, 211)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 60)
        Button2.TabIndex = 9
        Button2.Text = "Remove عملية"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Gill Sans Ultra Bold Condensed", 11.25F)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(186, 211)
        Button3.Name = "Button3"
        Button3.Size = New Size(156, 60)
        Button3.TabIndex = 10
        Button3.Text = "Insert عملية"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
