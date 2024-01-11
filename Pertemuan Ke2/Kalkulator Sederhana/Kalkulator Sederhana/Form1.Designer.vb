<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Tambah = New System.Windows.Forms.Button()
        Me.Kurang = New System.Windows.Forms.Button()
        Me.Bagi = New System.Windows.Forms.Button()
        Me.Kali = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kalkulator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Input Angka Pertama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Input Angka Ke-Dua"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(350, 139)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(227, 36)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(350, 213)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(227, 36)
        Me.TextBox2.TabIndex = 4
        '
        'Tambah
        '
        Me.Tambah.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tambah.Location = New System.Drawing.Point(121, 278)
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Size = New System.Drawing.Size(81, 59)
        Me.Tambah.TabIndex = 5
        Me.Tambah.Text = "+"
        Me.Tambah.UseVisualStyleBackColor = False
        '
        'Kurang
        '
        Me.Kurang.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Kurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kurang.Location = New System.Drawing.Point(234, 278)
        Me.Kurang.Name = "Kurang"
        Me.Kurang.Size = New System.Drawing.Size(81, 59)
        Me.Kurang.TabIndex = 6
        Me.Kurang.Text = "-"
        Me.Kurang.UseVisualStyleBackColor = False
        '
        'Bagi
        '
        Me.Bagi.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bagi.Location = New System.Drawing.Point(359, 278)
        Me.Bagi.Name = "Bagi"
        Me.Bagi.Size = New System.Drawing.Size(81, 59)
        Me.Bagi.TabIndex = 7
        Me.Bagi.Text = "/"
        Me.Bagi.UseVisualStyleBackColor = False
        '
        'Kali
        '
        Me.Kali.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Kali.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kali.Location = New System.Drawing.Point(476, 278)
        Me.Kali.Name = "Kali"
        Me.Kali.Size = New System.Drawing.Size(81, 59)
        Me.Kali.TabIndex = 8
        Me.Kali.Text = "X"
        Me.Kali.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 36)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Hasil Perhitungan"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(350, 366)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(227, 36)
        Me.TextBox3.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(605, 437)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Kali)
        Me.Controls.Add(Me.Bagi)
        Me.Controls.Add(Me.Kurang)
        Me.Controls.Add(Me.Tambah)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kalkulator Sederhana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Tambah As System.Windows.Forms.Button
    Friend WithEvents Kurang As System.Windows.Forms.Button
    Friend WithEvents Bagi As System.Windows.Forms.Button
    Friend WithEvents Kali As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
