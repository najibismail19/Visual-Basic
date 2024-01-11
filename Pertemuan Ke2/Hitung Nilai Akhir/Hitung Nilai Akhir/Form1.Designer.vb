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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAbsensi = New System.Windows.Forms.TextBox()
        Me.TxtTugas = New System.Windows.Forms.TextBox()
        Me.TxtUts = New System.Windows.Forms.TextBox()
        Me.TxtUas = New System.Windows.Forms.TextBox()
        Me.txtHasilAbs = New System.Windows.Forms.TextBox()
        Me.txtHasilTugas = New System.Windows.Forms.TextBox()
        Me.txtHasilUts = New System.Windows.Forms.TextBox()
        Me.txtHasilUAS = New System.Windows.Forms.TextBox()
        Me.TxtNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai Absen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai Tugas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai UTS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nilai UAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nilai Akhir"
        '
        'TxtAbsensi
        '
        Me.TxtAbsensi.Location = New System.Drawing.Point(152, 61)
        Me.TxtAbsensi.Name = "TxtAbsensi"
        Me.TxtAbsensi.Size = New System.Drawing.Size(100, 26)
        Me.TxtAbsensi.TabIndex = 5
        '
        'TxtTugas
        '
        Me.TxtTugas.Location = New System.Drawing.Point(152, 134)
        Me.TxtTugas.Name = "TxtTugas"
        Me.TxtTugas.Size = New System.Drawing.Size(100, 26)
        Me.TxtTugas.TabIndex = 6
        '
        'TxtUts
        '
        Me.TxtUts.Location = New System.Drawing.Point(152, 209)
        Me.TxtUts.Name = "TxtUts"
        Me.TxtUts.Size = New System.Drawing.Size(100, 26)
        Me.TxtUts.TabIndex = 7
        '
        'TxtUas
        '
        Me.TxtUas.Location = New System.Drawing.Point(152, 291)
        Me.TxtUas.Name = "TxtUas"
        Me.TxtUas.Size = New System.Drawing.Size(100, 26)
        Me.TxtUas.TabIndex = 8
        '
        'txtHasilAbs
        '
        Me.txtHasilAbs.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHasilAbs.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtHasilAbs.Location = New System.Drawing.Point(258, 61)
        Me.txtHasilAbs.Name = "txtHasilAbs"
        Me.txtHasilAbs.Size = New System.Drawing.Size(100, 26)
        Me.txtHasilAbs.TabIndex = 10
        '
        'txtHasilTugas
        '
        Me.txtHasilTugas.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHasilTugas.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtHasilTugas.Location = New System.Drawing.Point(258, 134)
        Me.txtHasilTugas.Name = "txtHasilTugas"
        Me.txtHasilTugas.Size = New System.Drawing.Size(100, 26)
        Me.txtHasilTugas.TabIndex = 11
        '
        'txtHasilUts
        '
        Me.txtHasilUts.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHasilUts.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtHasilUts.Location = New System.Drawing.Point(258, 209)
        Me.txtHasilUts.Name = "txtHasilUts"
        Me.txtHasilUts.Size = New System.Drawing.Size(100, 26)
        Me.txtHasilUts.TabIndex = 12
        '
        'txtHasilUAS
        '
        Me.txtHasilUAS.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHasilUAS.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtHasilUAS.Location = New System.Drawing.Point(258, 291)
        Me.txtHasilUAS.Name = "txtHasilUAS"
        Me.txtHasilUAS.Size = New System.Drawing.Size(100, 26)
        Me.txtHasilUAS.TabIndex = 13
        '
        'TxtNilaiAkhir
        '
        Me.TxtNilaiAkhir.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtNilaiAkhir.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtNilaiAkhir.Location = New System.Drawing.Point(152, 376)
        Me.TxtNilaiAkhir.Name = "TxtNilaiAkhir"
        Me.TxtNilaiAkhir.Size = New System.Drawing.Size(206, 26)
        Me.TxtNilaiAkhir.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 56)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 599)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtNilaiAkhir)
        Me.Controls.Add(Me.txtHasilUAS)
        Me.Controls.Add(Me.txtHasilUts)
        Me.Controls.Add(Me.txtHasilTugas)
        Me.Controls.Add(Me.txtHasilAbs)
        Me.Controls.Add(Me.TxtUas)
        Me.Controls.Add(Me.TxtUts)
        Me.Controls.Add(Me.TxtTugas)
        Me.Controls.Add(Me.TxtAbsensi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Hitung Nilai Akhir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtAbsensi As System.Windows.Forms.TextBox
    Friend WithEvents TxtTugas As System.Windows.Forms.TextBox
    Friend WithEvents TxtUts As System.Windows.Forms.TextBox
    Friend WithEvents TxtUas As System.Windows.Forms.TextBox
    Friend WithEvents txtHasilAbs As System.Windows.Forms.TextBox
    Friend WithEvents txtHasilTugas As System.Windows.Forms.TextBox
    Friend WithEvents txtHasilUts As System.Windows.Forms.TextBox
    Friend WithEvents txtHasilUAS As System.Windows.Forms.TextBox
    Friend WithEvents TxtNilaiAkhir As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
