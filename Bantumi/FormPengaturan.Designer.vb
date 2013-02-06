<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengaturan
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Biji4 = New System.Windows.Forms.Button
        Me.Biji5 = New System.Windows.Forms.Button
        Me.Biji6 = New System.Windows.Forms.Button
        Me.TextBiji = New System.Windows.Forms.TextBox
        Me.TeksBiji = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilihan Biji :"
        '
        'Biji4
        '
        Me.Biji4.Location = New System.Drawing.Point(15, 25)
        Me.Biji4.Name = "Biji4"
        Me.Biji4.Size = New System.Drawing.Size(75, 23)
        Me.Biji4.TabIndex = 1
        Me.Biji4.Text = "4"
        Me.Biji4.UseVisualStyleBackColor = True
        '
        'Biji5
        '
        Me.Biji5.Location = New System.Drawing.Point(96, 25)
        Me.Biji5.Name = "Biji5"
        Me.Biji5.Size = New System.Drawing.Size(75, 23)
        Me.Biji5.TabIndex = 2
        Me.Biji5.Text = "5"
        Me.Biji5.UseVisualStyleBackColor = True
        '
        'Biji6
        '
        Me.Biji6.Location = New System.Drawing.Point(177, 25)
        Me.Biji6.Name = "Biji6"
        Me.Biji6.Size = New System.Drawing.Size(75, 23)
        Me.Biji6.TabIndex = 3
        Me.Biji6.Text = "6"
        Me.Biji6.UseVisualStyleBackColor = True
        '
        'TextBiji
        '
        Me.TextBiji.Location = New System.Drawing.Point(177, 58)
        Me.TextBiji.Name = "TextBiji"
        Me.TextBiji.Size = New System.Drawing.Size(75, 20)
        Me.TextBiji.TabIndex = 4
        '
        'TeksBiji
        '
        Me.TeksBiji.AutoSize = True
        Me.TeksBiji.Location = New System.Drawing.Point(12, 61)
        Me.TeksBiji.Name = "TeksBiji"
        Me.TeksBiji.Size = New System.Drawing.Size(160, 13)
        Me.TeksBiji.TabIndex = 5
        Me.TeksBiji.Text = "Masukkan Biji Yang Diinginkan :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(177, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormPengaturan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TeksBiji)
        Me.Controls.Add(Me.TextBiji)
        Me.Controls.Add(Me.Biji6)
        Me.Controls.Add(Me.Biji5)
        Me.Controls.Add(Me.Biji4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPengaturan"
        Me.Text = "FormPengaturan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Biji4 As System.Windows.Forms.Button
    Friend WithEvents Biji5 As System.Windows.Forms.Button
    Friend WithEvents Biji6 As System.Windows.Forms.Button
    Friend WithEvents TextBiji As System.Windows.Forms.TextBox
    Friend WithEvents TeksBiji As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class
