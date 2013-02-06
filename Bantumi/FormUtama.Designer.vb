<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SimulasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TimerGame = New System.Windows.Forms.Timer(Me.components)
        Me.lblHuman = New System.Windows.Forms.Label
        Me.lblComp = New System.Windows.Forms.Label
        Me.timerBlink = New System.Windows.Forms.Timer(Me.components)
        Me.LblResult = New System.Windows.Forms.Label
        Me.Pengaturan = New System.Windows.Forms.Button
        Me.Petunjuk = New System.Windows.Forms.Button
        Me.Keluar = New System.Windows.Forms.Button
        Me.picComp = New System.Windows.Forms.PictureBox
        Me.picHuman = New System.Windows.Forms.PictureBox
        Me.lblMyHQ = New System.Windows.Forms.Label
        Me.lblEnemyHQ = New System.Windows.Forms.Label
        Me.lblMy6 = New System.Windows.Forms.Label
        Me.lblMy5 = New System.Windows.Forms.Label
        Me.lblMy4 = New System.Windows.Forms.Label
        Me.lblEnemy1 = New System.Windows.Forms.Label
        Me.lblEnemy2 = New System.Windows.Forms.Label
        Me.lblEnemy3 = New System.Windows.Forms.Label
        Me.lblMy3 = New System.Windows.Forms.Label
        Me.lblMy2 = New System.Windows.Forms.Label
        Me.lblMy1 = New System.Windows.Forms.Label
        Me.lblEnemy4 = New System.Windows.Forms.Label
        Me.lblEnemy5 = New System.Windows.Forms.Label
        Me.lblEnemy6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Kembali = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHuman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1130, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.SimulasiToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.NewGameToolStripMenuItem.Text = "&Mulai Baru"
        '
        'SimulasiToolStripMenuItem
        '
        Me.SimulasiToolStripMenuItem.Name = "SimulasiToolStripMenuItem"
        Me.SimulasiToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SimulasiToolStripMenuItem.Text = "Simulasi"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "&Keluar"
        '
        'TimerGame
        '
        Me.TimerGame.Enabled = True
        Me.TimerGame.Interval = 1000
        '
        'lblHuman
        '
        Me.lblHuman.AutoSize = True
        Me.lblHuman.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblHuman.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHuman.Location = New System.Drawing.Point(144, 496)
        Me.lblHuman.Name = "lblHuman"
        Me.lblHuman.Size = New System.Drawing.Size(217, 37)
        Me.lblHuman.TabIndex = 18
        Me.lblHuman.Text = "Human Turn!"
        Me.lblHuman.Visible = False
        '
        'lblComp
        '
        Me.lblComp.AutoSize = True
        Me.lblComp.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComp.Location = New System.Drawing.Point(681, 493)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(257, 37)
        Me.lblComp.TabIndex = 19
        Me.lblComp.Text = "Computer Turn!"
        Me.lblComp.Visible = False
        '
        'timerBlink
        '
        Me.timerBlink.Enabled = True
        Me.timerBlink.Interval = 1000
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.BackColor = System.Drawing.Color.PaleTurquoise
        Me.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblResult.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResult.Location = New System.Drawing.Point(12, 37)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblResult.Size = New System.Drawing.Size(99, 40)
        Me.LblResult.TabIndex = 20
        Me.LblResult.Text = "Result"
        Me.LblResult.Visible = False
        '
        'Pengaturan
        '
        Me.Pengaturan.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Pengaturan.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pengaturan.Location = New System.Drawing.Point(468, 463)
        Me.Pengaturan.Name = "Pengaturan"
        Me.Pengaturan.Size = New System.Drawing.Size(192, 32)
        Me.Pengaturan.TabIndex = 21
        Me.Pengaturan.Text = "Pengaturan"
        Me.Pengaturan.UseVisualStyleBackColor = False
        '
        'Petunjuk
        '
        Me.Petunjuk.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Petunjuk.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Petunjuk.Location = New System.Drawing.Point(468, 501)
        Me.Petunjuk.Name = "Petunjuk"
        Me.Petunjuk.Size = New System.Drawing.Size(192, 34)
        Me.Petunjuk.TabIndex = 22
        Me.Petunjuk.Text = "Petunjuk Permainan"
        Me.Petunjuk.UseVisualStyleBackColor = False
        '
        'Keluar
        '
        Me.Keluar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Keluar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keluar.Location = New System.Drawing.Point(468, 579)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(192, 32)
        Me.Keluar.TabIndex = 23
        Me.Keluar.Text = "Keluar"
        Me.Keluar.UseVisualStyleBackColor = False
        '
        'picComp
        '
        Me.picComp.BackColor = System.Drawing.Color.PaleTurquoise
        Me.picComp.Image = Global.Bantumi.My.Resources.Resources.star3
        Me.picComp.Location = New System.Drawing.Point(971, 493)
        Me.picComp.Name = "picComp"
        Me.picComp.Size = New System.Drawing.Size(116, 118)
        Me.picComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picComp.TabIndex = 17
        Me.picComp.TabStop = False
        '
        'picHuman
        '
        Me.picHuman.BackColor = System.Drawing.Color.PaleTurquoise
        Me.picHuman.Image = Global.Bantumi.My.Resources.Resources.star2
        Me.picHuman.Location = New System.Drawing.Point(22, 496)
        Me.picHuman.Name = "picHuman"
        Me.picHuman.Size = New System.Drawing.Size(116, 115)
        Me.picHuman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picHuman.TabIndex = 16
        Me.picHuman.TabStop = False
        '
        'lblMyHQ
        '
        Me.lblMyHQ.AutoSize = True
        Me.lblMyHQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMyHQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMyHQ.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyHQ.Image = Global.Bantumi.My.Resources.Resources.untitled5
        Me.lblMyHQ.Location = New System.Drawing.Point(987, 225)
        Me.lblMyHQ.Name = "lblMyHQ"
        Me.lblMyHQ.Size = New System.Drawing.Size(48, 55)
        Me.lblMyHQ.TabIndex = 14
        Me.lblMyHQ.Text = "4"
        '
        'lblEnemyHQ
        '
        Me.lblEnemyHQ.AutoSize = True
        Me.lblEnemyHQ.BackColor = System.Drawing.Color.Transparent
        Me.lblEnemyHQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEnemyHQ.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyHQ.ForeColor = System.Drawing.Color.White
        Me.lblEnemyHQ.Image = Global.Bantumi.My.Resources.Resources.untitled51
        Me.lblEnemyHQ.Location = New System.Drawing.Point(90, 214)
        Me.lblEnemyHQ.Name = "lblEnemyHQ"
        Me.lblEnemyHQ.Size = New System.Drawing.Size(48, 55)
        Me.lblEnemyHQ.TabIndex = 13
        Me.lblEnemyHQ.Text = "4"
        '
        'lblMy6
        '
        Me.lblMy6.AutoSize = True
        Me.lblMy6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMy6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMy6.Font = New System.Drawing.Font("Comic Sans MS", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMy6.Image = Global.Bantumi.My.Resources.Resources.untitled5
        Me.lblMy6.Location = New System.Drawing.Point(843, 275)
        Me.lblMy6.Name = "lblMy6"
        Me.lblMy6.Size = New System.Drawing.Size(44, 50)
        Me.lblMy6.TabIndex = 12
        Me.lblMy6.Text = "4"
        '
        'lblMy5
        '
        Me.lblMy5.AutoSize = True
        Me.lblMy5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMy5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMy5.Font = New System.Drawing.Font("Comic Sans MS", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMy5.Image = Global.Bantumi.My.Resources.Resources.untitled5
        Me.lblMy5.Location = New System.Drawing.Point(730, 275)
        Me.lblMy5.Name = "lblMy5"
        Me.lblMy5.Size = New System.Drawing.Size(44, 50)
        Me.lblMy5.TabIndex = 11
        Me.lblMy5.Text = "4"
        '
        'lblMy4
        '
        Me.lblMy4.AutoSize = True
        Me.lblMy4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMy4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMy4.Font = New System.Drawing.Font("Comic Sans MS", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMy4.Image = Global.Bantumi.My.Resources.Resources.untitled5
        Me.lblMy4.Location = New System.Drawing.Point(627, 265)
        Me.lblMy4.Name = "lblMy4"
        Me.lblMy4.Size = New System.Drawing.Size(44, 50)
        Me.lblMy4.TabIndex = 10
        Me.lblMy4.Text = "4"
        '
        'lblEnemy1
        '
        Me.lblEnemy1.AutoSize = True
        Me.lblEnemy1.BackColor = System.Drawing.Color.Transparent
        Me.lblEnemy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEnemy1.Font = New System.Drawing.Font("Comic Sans MS", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemy1.ForeColor = System.Drawing.Color.White
        Me.lblEnemy1.Image = Global.Bantumi.My.Resources.Resources.untitled5
        Me.lblEnemy1.Location = New System.Drawing.Point(854, 167)
        Me.lblEnemy1.Name = "lblEnemy1"
        Me.lblEnemy1.Size = New System.Drawing.Size(44, 50)
        Me.lblEnemy1.TabIndex = 9
        Me.lblEnemy1.Text = "4"
        '
        'lblEnemy2
        '
        Me.lblEnemy2.AutoSize = True
        Me.lblEnemy2.BackColor = System.Drawing.Color.Transparent
        Me.lblEnemy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEnemy2.Font = New System.Drawing.Font("Comic Sans MS", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemy2.ForeColor = System.Drawing.Color.White
        Me.lblEnemy2.Image = Global.Bantumi.My.Resources.Resources.untitled5
        Me.lblEnemy2.Location = New System.Drawing.Point(742, 167)
        Me.lblEnemy2.Name = "lblEnemy2"
        Me.lblEnemy2.Size = New System.Drawing.Size(44, 50)
        Me.lblEnemy2.TabIndex = 8
        Me.lblEnemy2.Text = "4"
        '
        'lblEnemy3
        '
        Me.lblEnemy3.AutoSize = True
        Me.lblEnemy3.BackColor = System.Drawing.Color.Transparent
        Me.lblEnemy3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEnemy3.Font = New System.Drawing.Font("Comic Sans MS", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemy3.ForeColor = System.Drawing.Color.White
        Me.lblEnemy3.Image = Global.Bantumi.My.Resources.Resources.untitled5
        Me.lblEnemy3.Location = New System.Drawing.Point(647, 167)
        Me.lblEnemy3.Name = "lblEnemy3"
        Me.lblEnemy3.Size = New System.Drawing.Size(44, 50)
        Me.lblEnemy3.TabIndex = 7
        Me.lblEnemy3.Text = "4"
        '
        'lblMy3
        '
        Me.lblMy3.AutoSize = True
        Me.lblMy3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMy3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMy3.Font = New System.Drawing.Font("Comic Sans MS", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMy3.Image = Global.Bantumi.My.Resources.Resources.untitled51
        Me.lblMy3.Location = New System.Drawing.Point(449, 265)
        Me.lblMy3.Name = "lblMy3"
        Me.lblMy3.Size = New System.Drawing.Size(44, 50)
        Me.lblMy3.TabIndex = 6
        Me.lblMy3.Text = "4"
        '
        'lblMy2
        '
        Me.lblMy2.AutoSize = True
        Me.lblMy2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMy2.Font = New System.Drawing.Font("Comic Sans MS", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMy2.Image = Global.Bantumi.My.Resources.Resources.untitled51
        Me.lblMy2.Location = New System.Drawing.Point(348, 275)
        Me.lblMy2.Name = "lblMy2"
        Me.lblMy2.Size = New System.Drawing.Size(44, 50)
        Me.lblMy2.TabIndex = 5
        Me.lblMy2.Text = "4"
        '
        'lblMy1
        '
        Me.lblMy1.AutoSize = True
        Me.lblMy1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMy1.Font = New System.Drawing.Font("Comic Sans MS", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMy1.ForeColor = System.Drawing.Color.Black
        Me.lblMy1.Image = Global.Bantumi.My.Resources.Resources.untitled51
        Me.lblMy1.Location = New System.Drawing.Point(235, 275)
        Me.lblMy1.Name = "lblMy1"
        Me.lblMy1.Size = New System.Drawing.Size(44, 50)
        Me.lblMy1.TabIndex = 4
        Me.lblMy1.Text = "4"
        '
        'lblEnemy4
        '
        Me.lblEnemy4.AutoSize = True
        Me.lblEnemy4.BackColor = System.Drawing.Color.Transparent
        Me.lblEnemy4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEnemy4.Font = New System.Drawing.Font("Comic Sans MS", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemy4.ForeColor = System.Drawing.Color.White
        Me.lblEnemy4.Image = Global.Bantumi.My.Resources.Resources.untitled51
        Me.lblEnemy4.Location = New System.Drawing.Point(429, 167)
        Me.lblEnemy4.Name = "lblEnemy4"
        Me.lblEnemy4.Size = New System.Drawing.Size(44, 50)
        Me.lblEnemy4.TabIndex = 3
        Me.lblEnemy4.Text = "4"
        '
        'lblEnemy5
        '
        Me.lblEnemy5.AutoSize = True
        Me.lblEnemy5.BackColor = System.Drawing.Color.Transparent
        Me.lblEnemy5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEnemy5.Font = New System.Drawing.Font("Comic Sans MS", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemy5.ForeColor = System.Drawing.Color.White
        Me.lblEnemy5.Image = Global.Bantumi.My.Resources.Resources.untitled51
        Me.lblEnemy5.Location = New System.Drawing.Point(333, 167)
        Me.lblEnemy5.Name = "lblEnemy5"
        Me.lblEnemy5.Size = New System.Drawing.Size(44, 50)
        Me.lblEnemy5.TabIndex = 2
        Me.lblEnemy5.Text = "4"
        '
        'lblEnemy6
        '
        Me.lblEnemy6.AutoSize = True
        Me.lblEnemy6.BackColor = System.Drawing.Color.Transparent
        Me.lblEnemy6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEnemy6.Font = New System.Drawing.Font("Comic Sans MS", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemy6.ForeColor = System.Drawing.Color.White
        Me.lblEnemy6.Image = Global.Bantumi.My.Resources.Resources.untitled51
        Me.lblEnemy6.Location = New System.Drawing.Point(224, 167)
        Me.lblEnemy6.Name = "lblEnemy6"
        Me.lblEnemy6.Size = New System.Drawing.Size(44, 50)
        Me.lblEnemy6.TabIndex = 1
        Me.lblEnemy6.Text = "4"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bantumi.My.Resources.Resources.my_Bantumi
        Me.PictureBox1.Location = New System.Drawing.Point(11, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1109, 586)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Kembali
        '
        Me.Kembali.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Kembali.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kembali.Location = New System.Drawing.Point(468, 541)
        Me.Kembali.Name = "Kembali"
        Me.Kembali.Size = New System.Drawing.Size(192, 32)
        Me.Kembali.TabIndex = 24
        Me.Kembali.Text = "Kembali"
        Me.Kembali.UseVisualStyleBackColor = False
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 623)
        Me.Controls.Add(Me.Kembali)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.Petunjuk)
        Me.Controls.Add(Me.Pengaturan)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.lblComp)
        Me.Controls.Add(Me.lblHuman)
        Me.Controls.Add(Me.picComp)
        Me.Controls.Add(Me.picHuman)
        Me.Controls.Add(Me.lblMyHQ)
        Me.Controls.Add(Me.lblEnemyHQ)
        Me.Controls.Add(Me.lblMy6)
        Me.Controls.Add(Me.lblMy5)
        Me.Controls.Add(Me.lblMy4)
        Me.Controls.Add(Me.lblEnemy1)
        Me.Controls.Add(Me.lblEnemy2)
        Me.Controls.Add(Me.lblEnemy3)
        Me.Controls.Add(Me.lblMy3)
        Me.Controls.Add(Me.lblMy2)
        Me.Controls.Add(Me.lblMy1)
        Me.Controls.Add(Me.lblEnemy4)
        Me.Controls.Add(Me.lblEnemy5)
        Me.Controls.Add(Me.lblEnemy6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bantumi"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHuman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblEnemy6 As System.Windows.Forms.Label
    Friend WithEvents lblEnemy5 As System.Windows.Forms.Label
    Friend WithEvents lblEnemy4 As System.Windows.Forms.Label
    Friend WithEvents lblMy3 As System.Windows.Forms.Label
    Friend WithEvents lblMy2 As System.Windows.Forms.Label
    Friend WithEvents lblMy1 As System.Windows.Forms.Label
    Friend WithEvents lblMy6 As System.Windows.Forms.Label
    Friend WithEvents lblMy5 As System.Windows.Forms.Label
    Friend WithEvents lblMy4 As System.Windows.Forms.Label
    Friend WithEvents lblEnemy1 As System.Windows.Forms.Label
    Friend WithEvents lblEnemy2 As System.Windows.Forms.Label
    Friend WithEvents lblEnemy3 As System.Windows.Forms.Label
    Friend WithEvents lblEnemyHQ As System.Windows.Forms.Label
    Friend WithEvents lblMyHQ As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerGame As System.Windows.Forms.Timer
    Friend WithEvents picHuman As System.Windows.Forms.PictureBox
    Friend WithEvents picComp As System.Windows.Forms.PictureBox
    Friend WithEvents lblHuman As System.Windows.Forms.Label
    Friend WithEvents lblComp As System.Windows.Forms.Label
    Friend WithEvents timerBlink As System.Windows.Forms.Timer
    Friend WithEvents LblResult As System.Windows.Forms.Label
    Friend WithEvents Pengaturan As System.Windows.Forms.Button
    Friend WithEvents Petunjuk As System.Windows.Forms.Button
    Friend WithEvents Keluar As System.Windows.Forms.Button
    Friend WithEvents SimulasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Kembali As System.Windows.Forms.Button

End Class
