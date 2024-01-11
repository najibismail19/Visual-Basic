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
        Me.cbProdi = New System.Windows.Forms.ComboBox()
        Me.cbKelamin = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bKeluar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.bProses = New System.Windows.Forms.Button()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbProdi
        '
        Me.cbProdi.FormattingEnabled = True
        Me.cbProdi.Location = New System.Drawing.Point(131, 162)
        Me.cbProdi.Name = "cbProdi"
        Me.cbProdi.Size = New System.Drawing.Size(213, 28)
        Me.cbProdi.TabIndex = 31
        '
        'cbKelamin
        '
        Me.cbKelamin.FormattingEnabled = True
        Me.cbKelamin.Location = New System.Drawing.Point(131, 124)
        Me.cbKelamin.Name = "cbKelamin"
        Me.cbKelamin.Size = New System.Drawing.Size(213, 28)
        Me.cbKelamin.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Kelamin"
        '
        'bKeluar
        '
        Me.bKeluar.Location = New System.Drawing.Point(249, 243)
        Me.bKeluar.Name = "bKeluar"
        Me.bKeluar.Size = New System.Drawing.Size(112, 37)
        Me.bKeluar.TabIndex = 28
        Me.bKeluar.Text = "Keluar"
        Me.bKeluar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(35, 326)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(573, 163)
        Me.ListView1.TabIndex = 27
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'bProses
        '
        Me.bProses.Location = New System.Drawing.Point(131, 243)
        Me.bProses.Name = "bProses"
        Me.bProses.Size = New System.Drawing.Size(112, 37)
        Me.bProses.TabIndex = 26
        Me.bProses.Text = "Proses"
        Me.bProses.UseVisualStyleBackColor = True
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(131, 88)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(213, 26)
        Me.TxtNama.TabIndex = 25
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(131, 52)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(155, 26)
        Me.txtNIM.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Prodi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "NIM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 523)
        Me.Controls.Add(Me.cbProdi)
        Me.Controls.Add(Me.cbKelamin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bKeluar)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.bProses)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.txtNIM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbProdi As System.Windows.Forms.ComboBox
    Friend WithEvents cbKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bKeluar As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents bProses As System.Windows.Forms.Button
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNIM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
