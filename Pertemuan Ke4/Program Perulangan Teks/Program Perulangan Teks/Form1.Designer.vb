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
        Me.txtTeks = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.bProses = New System.Windows.Forms.Button()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.bKeluar = New System.Windows.Forms.Button()
        Me.bClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tuliskan Teks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumlah Pengulangan"
        '
        'txtTeks
        '
        Me.txtTeks.Location = New System.Drawing.Point(250, 47)
        Me.txtTeks.Name = "txtTeks"
        Me.txtTeks.Size = New System.Drawing.Size(173, 29)
        Me.txtTeks.TabIndex = 2
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(250, 96)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(173, 29)
        Me.txtJumlah.TabIndex = 3
        '
        'bProses
        '
        Me.bProses.Location = New System.Drawing.Point(52, 169)
        Me.bProses.Name = "bProses"
        Me.bProses.Size = New System.Drawing.Size(104, 45)
        Me.bProses.TabIndex = 4
        Me.bProses.Text = "Proses"
        Me.bProses.UseVisualStyleBackColor = True
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.ItemHeight = 24
        Me.List1.Location = New System.Drawing.Point(52, 257)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(395, 148)
        Me.List1.TabIndex = 5
        '
        'bKeluar
        '
        Me.bKeluar.Location = New System.Drawing.Point(319, 439)
        Me.bKeluar.Name = "bKeluar"
        Me.bKeluar.Size = New System.Drawing.Size(104, 45)
        Me.bKeluar.TabIndex = 6
        Me.bKeluar.Text = "Keluar"
        Me.bKeluar.UseVisualStyleBackColor = True
        '
        'bClear
        '
        Me.bClear.Location = New System.Drawing.Point(52, 439)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(104, 45)
        Me.bClear.TabIndex = 7
        Me.bClear.Text = "Clear"
        Me.bClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 592)
        Me.Controls.Add(Me.bClear)
        Me.Controls.Add(Me.bKeluar)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.bProses)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtTeks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTeks As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents bProses As System.Windows.Forms.Button
    Friend WithEvents List1 As System.Windows.Forms.ListBox
    Friend WithEvents bKeluar As System.Windows.Forms.Button
    Friend WithEvents bClear As System.Windows.Forms.Button

End Class
