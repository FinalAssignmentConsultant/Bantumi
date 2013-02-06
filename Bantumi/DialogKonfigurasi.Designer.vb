<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogKonfigurasi
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
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.updnJumlahBiji = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.optPemain = New System.Windows.Forms.RadioButton
        Me.optKomputer = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.optLev2 = New System.Windows.Forms.RadioButton
        Me.optLev1 = New System.Windows.Forms.RadioButton
        CType(Me.updnJumlahBiji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(211, 158)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jumlah Biji"
        '
        'updnJumlahBiji
        '
        Me.updnJumlahBiji.Location = New System.Drawing.Point(123, 23)
        Me.updnJumlahBiji.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.updnJumlahBiji.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updnJumlahBiji.Name = "updnJumlahBiji"
        Me.updnJumlahBiji.Size = New System.Drawing.Size(41, 20)
        Me.updnJumlahBiji.TabIndex = 2
        Me.updnJumlahBiji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.updnJumlahBiji.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Giliran Pertama"
        '
        'optPemain
        '
        Me.optPemain.AutoSize = True
        Me.optPemain.Checked = True
        Me.optPemain.Location = New System.Drawing.Point(123, 58)
        Me.optPemain.Name = "optPemain"
        Me.optPemain.Size = New System.Drawing.Size(60, 17)
        Me.optPemain.TabIndex = 4
        Me.optPemain.TabStop = True
        Me.optPemain.Text = "Pemain"
        Me.optPemain.UseVisualStyleBackColor = True
        '
        'optKomputer
        '
        Me.optKomputer.AutoSize = True
        Me.optKomputer.Location = New System.Drawing.Point(189, 58)
        Me.optKomputer.Name = "optKomputer"
        Me.optKomputer.Size = New System.Drawing.Size(70, 17)
        Me.optKomputer.TabIndex = 5
        Me.optKomputer.Text = "Komputer"
        Me.optKomputer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Level Kecerdasan"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.optLev2)
        Me.Panel1.Controls.Add(Me.optLev1)
        Me.Panel1.Location = New System.Drawing.Point(126, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 64)
        Me.Panel1.TabIndex = 7
        '
        'optLev2
        '
        Me.optLev2.AutoSize = True
        Me.optLev2.Location = New System.Drawing.Point(3, 26)
        Me.optLev2.Name = "optLev2"
        Me.optLev2.Size = New System.Drawing.Size(60, 17)
        Me.optLev2.TabIndex = 6
        Me.optLev2.Text = "Level 2"
        Me.optLev2.UseVisualStyleBackColor = True
        '
        'optLev1
        '
        Me.optLev1.AutoSize = True
        Me.optLev1.Checked = True
        Me.optLev1.Location = New System.Drawing.Point(3, 3)
        Me.optLev1.Name = "optLev1"
        Me.optLev1.Size = New System.Drawing.Size(60, 17)
        Me.optLev1.TabIndex = 5
        Me.optLev1.TabStop = True
        Me.optLev1.Text = "Level 1"
        Me.optLev1.UseVisualStyleBackColor = True
        '
        'DialogKonfigurasi
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 187)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.optKomputer)
        Me.Controls.Add(Me.optPemain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.updnJumlahBiji)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogKonfigurasi"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pengaturan"
        CType(Me.updnJumlahBiji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents updnJumlahBiji As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents optPemain As System.Windows.Forms.RadioButton
    Friend WithEvents optKomputer As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents optLev2 As System.Windows.Forms.RadioButton
    Friend WithEvents optLev1 As System.Windows.Forms.RadioButton

End Class
