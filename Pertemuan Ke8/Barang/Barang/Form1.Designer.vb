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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNamaBrg = New System.Windows.Forms.TextBox()
        Me.TxtKodeBrg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTotalHarga = New System.Windows.Forms.TextBox()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSatuan = New System.Windows.Forms.TextBox()
        Me.TxtHrgSatuan = New System.Windows.Forms.TextBox()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Satuan"
        '
        'TxtNamaBrg
        '
        Me.TxtNamaBrg.Location = New System.Drawing.Point(184, 72)
        Me.TxtNamaBrg.Name = "TxtNamaBrg"
        Me.TxtNamaBrg.Size = New System.Drawing.Size(213, 26)
        Me.TxtNamaBrg.TabIndex = 36
        '
        'TxtKodeBrg
        '
        Me.TxtKodeBrg.Location = New System.Drawing.Point(184, 36)
        Me.TxtKodeBrg.Name = "TxtKodeBrg"
        Me.TxtKodeBrg.Size = New System.Drawing.Size(75, 26)
        Me.TxtKodeBrg.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Harga Satuan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Kode Barang"
        '
        'TxtTotalHarga
        '
        Me.TxtTotalHarga.Location = New System.Drawing.Point(184, 227)
        Me.TxtTotalHarga.Name = "TxtTotalHarga"
        Me.TxtTotalHarga.Size = New System.Drawing.Size(213, 26)
        Me.TxtTotalHarga.TabIndex = 43
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(184, 185)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(75, 26)
        Me.TxtJumlah.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Total Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Jumlah"
        '
        'TxtSatuan
        '
        Me.TxtSatuan.Location = New System.Drawing.Point(184, 108)
        Me.TxtSatuan.Name = "TxtSatuan"
        Me.TxtSatuan.Size = New System.Drawing.Size(75, 26)
        Me.TxtSatuan.TabIndex = 44
        '
        'TxtHrgSatuan
        '
        Me.TxtHrgSatuan.Location = New System.Drawing.Point(184, 146)
        Me.TxtHrgSatuan.Name = "TxtHrgSatuan"
        Me.TxtHrgSatuan.Size = New System.Drawing.Size(213, 26)
        Me.TxtHrgSatuan.TabIndex = 45
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(184, 287)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(75, 40)
        Me.BtnHitung.TabIndex = 46
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(265, 287)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 40)
        Me.BtnClear.TabIndex = 47
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(346, 287)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 40)
        Me.BtnExit.TabIndex = 48
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 353)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtHrgSatuan)
        Me.Controls.Add(Me.TxtSatuan)
        Me.Controls.Add(Me.TxtTotalHarga)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNamaBrg)
        Me.Controls.Add(Me.TxtKodeBrg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNamaBrg As System.Windows.Forms.TextBox
    Friend WithEvents TxtKodeBrg As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents TxtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents TxtHrgSatuan As System.Windows.Forms.TextBox
    Friend WithEvents BtnHitung As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button

End Class
