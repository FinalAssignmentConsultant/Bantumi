<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogPemain
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
        Me.PemainBiji = New System.Windows.Forms.NumericUpDown
        Me.PemainI = New System.Windows.Forms.RadioButton
        Me.PemainII = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.PemainBiji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(184, 136)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jumlah Biji :"
        '
        'PemainBiji
        '
        Me.PemainBiji.Location = New System.Drawing.Point(130, 28)
        Me.PemainBiji.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.PemainBiji.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PemainBiji.Name = "PemainBiji"
        Me.PemainBiji.Size = New System.Drawing.Size(41, 20)
        Me.PemainBiji.TabIndex = 2
        Me.PemainBiji.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'PemainI
        '
        Me.PemainI.AutoSize = True
        Me.PemainI.Checked = True
        Me.PemainI.Location = New System.Drawing.Point(130, 74)
        Me.PemainI.Name = "PemainI"
        Me.PemainI.Size = New System.Drawing.Size(66, 17)
        Me.PemainI.TabIndex = 3
        Me.PemainI.TabStop = True
        Me.PemainI.Text = "Pemain I"
        Me.PemainI.UseVisualStyleBackColor = True
        '
        'PemainII
        '
        Me.PemainII.AutoSize = True
        Me.PemainII.Location = New System.Drawing.Point(130, 97)
        Me.PemainII.Name = "PemainII"
        Me.PemainII.Size = New System.Drawing.Size(69, 17)
        Me.PemainII.TabIndex = 4
        Me.PemainII.Text = "Pemain II"
        Me.PemainII.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Giliran Pertama :"
        '
        'DialogPemain
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 171)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PemainII)
        Me.Controls.Add(Me.PemainI)
        Me.Controls.Add(Me.PemainBiji)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogPemain"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pengaturan"
        CType(Me.PemainBiji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PemainBiji As System.Windows.Forms.NumericUpDown
    Friend WithEvents PemainI As System.Windows.Forms.RadioButton
    Friend WithEvents PemainII As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
