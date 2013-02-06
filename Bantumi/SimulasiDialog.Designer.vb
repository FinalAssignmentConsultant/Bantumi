<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimulasiDialog
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
        Me.inp1 = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.inp2 = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.inp3 = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.inp6 = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.inp5 = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.inp4 = New System.Windows.Forms.NumericUpDown
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.optLev2 = New System.Windows.Forms.RadioButton
        Me.optLev1 = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.inp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inp3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inp6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inp5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inp4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(269, 159)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'inp1
        '
        Me.inp1.Location = New System.Drawing.Point(294, 38)
        Me.inp1.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.inp1.Name = "inp1"
        Me.inp1.Size = New System.Drawing.Size(37, 20)
        Me.inp1.TabIndex = 1
        Me.inp1.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(301, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "P1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "P2"
        '
        'inp2
        '
        Me.inp2.Location = New System.Drawing.Point(240, 38)
        Me.inp2.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.inp2.Name = "inp2"
        Me.inp2.Size = New System.Drawing.Size(37, 20)
        Me.inp2.TabIndex = 3
        Me.inp2.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "P3"
        '
        'inp3
        '
        Me.inp3.Location = New System.Drawing.Point(187, 38)
        Me.inp3.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.inp3.Name = "inp3"
        Me.inp3.Size = New System.Drawing.Size(37, 20)
        Me.inp3.TabIndex = 5
        Me.inp3.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "P6"
        '
        'inp6
        '
        Me.inp6.Location = New System.Drawing.Point(28, 38)
        Me.inp6.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.inp6.Name = "inp6"
        Me.inp6.Size = New System.Drawing.Size(37, 20)
        Me.inp6.TabIndex = 11
        Me.inp6.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "P5"
        '
        'inp5
        '
        Me.inp5.Location = New System.Drawing.Point(81, 38)
        Me.inp5.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.inp5.Name = "inp5"
        Me.inp5.Size = New System.Drawing.Size(37, 20)
        Me.inp5.TabIndex = 9
        Me.inp5.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(142, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "P4"
        '
        'inp4
        '
        Me.inp4.Location = New System.Drawing.Point(135, 38)
        Me.inp4.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.inp4.Name = "inp4"
        Me.inp4.Size = New System.Drawing.Size(37, 20)
        Me.inp4.TabIndex = 7
        Me.inp4.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.optLev2)
        Me.Panel1.Controls.Add(Me.optLev1)
        Me.Panel1.Location = New System.Drawing.Point(126, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 64)
        Me.Panel1.TabIndex = 14
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Level Kecerdasan"
        '
        'SimulasiDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 204)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inp6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.inp5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.inp4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inp3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.inp2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inp1)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SimulasiDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pengaturan"
        CType(Me.inp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inp3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inp6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inp5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inp4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents inp1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents inp2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents inp3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents inp6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents inp5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents inp4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents optLev2 As System.Windows.Forms.RadioButton
    Friend WithEvents optLev1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
