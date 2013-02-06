<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.Start = New System.Windows.Forms.Button
        Me.Petunjuk = New System.Windows.Forms.Button
        Me.Keluar = New System.Windows.Forms.Button
        Me.Pemain = New System.Windows.Forms.Button
        Me.Komputer = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Start.Enabled = False
        Me.Start.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.Location = New System.Drawing.Point(36, 26)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(162, 37)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Mulai Permainan :"
        Me.Start.UseVisualStyleBackColor = False
        '
        'Petunjuk
        '
        Me.Petunjuk.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Petunjuk.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Petunjuk.Location = New System.Drawing.Point(36, 179)
        Me.Petunjuk.Name = "Petunjuk"
        Me.Petunjuk.Size = New System.Drawing.Size(192, 34)
        Me.Petunjuk.TabIndex = 1
        Me.Petunjuk.Text = "Petunjuk Permainan"
        Me.Petunjuk.UseVisualStyleBackColor = False
        '
        'Keluar
        '
        Me.Keluar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Keluar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keluar.Location = New System.Drawing.Point(371, 242)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(150, 32)
        Me.Keluar.TabIndex = 2
        Me.Keluar.Text = "Keluar"
        Me.Keluar.UseVisualStyleBackColor = False
        '
        'Pemain
        '
        Me.Pemain.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Pemain.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pemain.Location = New System.Drawing.Point(76, 69)
        Me.Pemain.Name = "Pemain"
        Me.Pemain.Size = New System.Drawing.Size(192, 42)
        Me.Pemain.TabIndex = 3
        Me.Pemain.Text = "Pemain Lawan Pemain"
        Me.Pemain.UseVisualStyleBackColor = False
        '
        'Komputer
        '
        Me.Komputer.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Komputer.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Komputer.Location = New System.Drawing.Point(76, 117)
        Me.Komputer.Name = "Komputer"
        Me.Komputer.Size = New System.Drawing.Size(192, 42)
        Me.Komputer.TabIndex = 4
        Me.Komputer.Text = "Pemain Lawan Komputer"
        Me.Komputer.UseVisualStyleBackColor = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bantumi.My.Resources.Resources.menuawal
        Me.ClientSize = New System.Drawing.Size(547, 305)
        Me.Controls.Add(Me.Komputer)
        Me.Controls.Add(Me.Pemain)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.Petunjuk)
        Me.Controls.Add(Me.Start)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bantumi Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Petunjuk As System.Windows.Forms.Button
    Friend WithEvents Keluar As System.Windows.Forms.Button
    Friend WithEvents Pemain As System.Windows.Forms.Button
    Friend WithEvents Komputer As System.Windows.Forms.Button
End Class
