<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListBox
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BtnRemoveSelected = New System.Windows.Forms.Button()
        Me.BtnMoveSelected = New System.Windows.Forms.Button()
        Me.BtnMoveAll = New System.Windows.Forms.Button()
        Me.BtnUp = New System.Windows.Forms.Button()
        Me.BtnDown = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Mahasiswa"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(162, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add To List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(16, 163)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(169, 304)
        Me.ListBox1.TabIndex = 3
        '
        'BtnRemoveSelected
        '
        Me.BtnRemoveSelected.Location = New System.Drawing.Point(16, 473)
        Me.BtnRemoveSelected.Name = "BtnRemoveSelected"
        Me.BtnRemoveSelected.Size = New System.Drawing.Size(169, 40)
        Me.BtnRemoveSelected.TabIndex = 4
        Me.BtnRemoveSelected.Text = "Remove Selected"
        Me.BtnRemoveSelected.UseVisualStyleBackColor = True
        '
        'BtnMoveSelected
        '
        Me.BtnMoveSelected.Location = New System.Drawing.Point(191, 217)
        Me.BtnMoveSelected.Name = "BtnMoveSelected"
        Me.BtnMoveSelected.Size = New System.Drawing.Size(169, 40)
        Me.BtnMoveSelected.TabIndex = 5
        Me.BtnMoveSelected.Text = "Move Selected>"
        Me.BtnMoveSelected.UseVisualStyleBackColor = True
        '
        'BtnMoveAll
        '
        Me.BtnMoveAll.Location = New System.Drawing.Point(191, 263)
        Me.BtnMoveAll.Name = "BtnMoveAll"
        Me.BtnMoveAll.Size = New System.Drawing.Size(169, 40)
        Me.BtnMoveAll.TabIndex = 6
        Me.BtnMoveAll.Text = "Move All>>"
        Me.BtnMoveAll.UseVisualStyleBackColor = True
        '
        'BtnUp
        '
        Me.BtnUp.Location = New System.Drawing.Point(191, 381)
        Me.BtnUp.Name = "BtnUp"
        Me.BtnUp.Size = New System.Drawing.Size(73, 40)
        Me.BtnUp.TabIndex = 7
        Me.BtnUp.Text = "Up"
        Me.BtnUp.UseVisualStyleBackColor = True
        '
        'BtnDown
        '
        Me.BtnDown.Location = New System.Drawing.Point(191, 427)
        Me.BtnDown.Name = "BtnDown"
        Me.BtnDown.Size = New System.Drawing.Size(73, 40)
        Me.BtnDown.TabIndex = 8
        Me.BtnDown.Text = "Down"
        Me.BtnDown.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(366, 163)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(169, 304)
        Me.ListBox2.TabIndex = 9
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(366, 473)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(169, 40)
        Me.BtnReset.TabIndex = 10
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FormListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 544)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.BtnDown)
        Me.Controls.Add(Me.BtnUp)
        Me.Controls.Add(Me.BtnMoveAll)
        Me.Controls.Add(Me.BtnMoveSelected)
        Me.Controls.Add(Me.BtnRemoveSelected)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormListBox"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents BtnRemoveSelected As System.Windows.Forms.Button
    Friend WithEvents BtnMoveSelected As System.Windows.Forms.Button
    Friend WithEvents BtnMoveAll As System.Windows.Forms.Button
    Friend WithEvents BtnUp As System.Windows.Forms.Button
    Friend WithEvents BtnDown As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents BtnReset As System.Windows.Forms.Button

End Class
