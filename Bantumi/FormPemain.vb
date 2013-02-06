Public Class FormPemain
    Dim computerBase As Integer = 0
    Const SLEEP = 500
    Const COMPUTER_BASE = 13
    Const HUMAN_BASE = 6
    Const HUMAN = 0
    Const COMPUTER = 1
    Dim game_turn As Integer = COMPUTER
    Dim humanBase As Integer = 0
    Dim slot(14) As Integer
    Dim JUMLAH_BIJI As Integer = 4
    Dim gameInProgress As Boolean = False
    Dim whoMove As Integer
    Dim enemyCoord(5, 2) As Integer
    Dim myCoord(5, 2) As Integer
    Dim initEnemyCoordX As Integer = 254
    Dim initEnemyCoordY As Integer = 78

    Dim initMyCoordX As Integer = 252
    Dim initMyCoordY As Integer = 224
    Dim collectionSlot As New Collection
    'urutan slot pada bantumi, dari kiri ke kanan adalah 0..14, 
    ' 0 .. 5 kita, 6 mangkok kita
    ' 7 ..12 komputer, 13 mangkok komputer

    Private Sub drawBoard()

        lblMy1.Text = slot(0)
        lblMy2.Text = slot(1)
        lblMy3.Text = slot(2)
        lblMy4.Text = slot(3)
        lblMy5.Text = slot(4)
        lblMy6.Text = slot(5)
        lblMyHQ.Text = slot(6)
        lblEnemy1.Text = slot(7)
        lblEnemy2.Text = slot(8)
        lblEnemy3.Text = slot(9)
        lblEnemy4.Text = slot(10)
        lblEnemy5.Text = slot(11)
        lblEnemy6.Text = slot(12)
        lblEnemyHQ.Text = slot(13)

    End Sub
    Private Sub FormPemain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        drawBoard()
    End Sub
    Private Sub initBoard()
        humanBase = 0
        computerBase = 0
        For i As Integer = 0 To 13
            slot(i) = JUMLAH_BIJI
        Next
        slot(6) = 0
        slot(13) = 0
    End Sub
    Private Sub FormUtama_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        initBoard()
    End Sub
    Private Function moveNextSlot(ByVal i As Integer) As Integer
        Dim nextI As Integer

        nextI = i + 1
        If nextI = 14 Then nextI = 0

        If whoMove = 0 And nextI = COMPUTER_BASE Then nextI = nextI + 1
        If whoMove = 1 And nextI = HUMAN_BASE Then nextI = nextI + 1
        If nextI = 14 Then nextI = 0
        Return nextI
    End Function
    Public Function isHuman(ByVal i As Integer)
        Return i >= 0 And i <= 5
    End Function
    Public Function isComputer(ByVal i As Integer)
        Return i >= 7 And i <= 12
    End Function
    Public Function isHumanBase(ByVal i As Integer)
        Return i = 6
    End Function
    Public Function isComputerBase(ByVal i As Integer)
        Return i = 0
    End Function
    Public Function mirror(ByVal i As Integer)
        Return 12 - i

    End Function
    Private Function humanEmpty() As Boolean
        Return slot(0) = 0 And slot(1) = 0 And slot(2) = 0 And slot(3) = 0 And slot(4) = 0 And slot(5) = 0
    End Function
    Private Function computerEmpty() As Boolean
        Return slot(7) = 0 And slot(8) = 0 And slot(9) = 0 And slot(10) = 0 And slot(11) = 0 And slot(12) = 0
    End Function
    Private Function pickSlot(ByRef islot As Integer, ByVal iWhoMove As Integer, Optional ByVal simulateOnly As Boolean = False) As Integer
        If game_turn <> iWhoMove Then
            MessageBox.Show("Maaf, tunggu giliran Anda", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function

        End If

        Dim originSlot0 As Integer
        Dim originSlot1 As Integer
        Dim originSlot2 As Integer
        Dim originSlot3 As Integer
        Dim originSlot4 As Integer
        Dim originSlot5 As Integer
        Dim originHumanBase As Integer

        Dim originSlot7 As Integer
        Dim originSlot8 As Integer
        Dim originSlot9 As Integer
        Dim originSlot10 As Integer
        Dim originSlot11 As Integer
        Dim originSlot12 As Integer
        Dim originComputerBase As Integer

        originSlot0 = slot(0)
        originSlot1 = slot(1)
        originSlot2 = slot(2)
        originSlot3 = slot(3)
        originSlot4 = slot(4)
        originSlot5 = slot(5)
        originHumanBase = slot(HUMAN_BASE)
        originSlot7 = slot(7)
        originSlot8 = slot(8)
        originSlot9 = slot(9)
        originSlot10 = slot(10)
        originSlot11 = slot(11)
        originSlot12 = slot(12)
        originComputerBase = slot(COMPUTER_BASE)


        Dim seed As Integer
        seed = slot(islot)
        slot(islot) = 0
        whoMove = iWhoMove

        ' pada setiap looping, cek di lubang mana jatuhnya
        While seed > 0 'habiskan semua biji yg diambil
            islot = moveNextSlot(islot)  'maju ke slot berikutnya
            slot(islot) = slot(islot) + 1
            drawBoard()
            System.Threading.Thread.Sleep(SLEEP)
            Application.DoEvents()
            seed = seed - 1 'jumlah noktah di tangan dikurangi
        End While

        If islot <> COMPUTER_BASE And islot <> HUMAN_BASE And slot(islot) = 1 Then 'berarti jatuh di tempat kosong, maka kemungkinan mikul atau nembak
            'nembak 
            If whoMove = HUMAN Then
                slot(HUMAN_BASE) = slot(HUMAN_BASE) + slot(islot) + slot(mirror(islot))
                slot(islot) = 0
                slot(mirror(islot)) = 0
            End If

            'nembak 
            If whoMove = COMPUTER Then
                slot(COMPUTER_BASE) = slot(COMPUTER_BASE) + slot(islot) + slot(mirror(islot))
                slot(islot) = 0
                slot(mirror(islot)) = 0
            End If


            'mikul, udah nembak dulu
            If whoMove = HUMAN And isComputer(islot) And islot <= COMPUTER_BASE - 2 And islot >= HUMAN_BASE + 2 Then
                slot(HUMAN_BASE) = slot(HUMAN_BASE) + slot(islot) + slot(islot + 1) + slot(islot - 1)
                slot(islot) = 0
                slot(islot + 1) = 0
                slot(islot - 1) = 0
            End If

            If whoMove = COMPUTER And isHuman(islot) And islot <= HUMAN_BASE - 2 And islot >= 1 Then
                slot(COMPUTER_BASE) = slot(COMPUTER_BASE) + slot(islot) + slot(islot + 1) + slot(islot - 1)
                slot(islot) = 0
                slot(islot + 1) = 0
                slot(islot - 1) = 0
            End If
        Else
            'ambil lagi, kalau...
            If slot(islot) > 1 And islot <> COMPUTER_BASE And islot <> HUMAN_BASE Then pickSlot(islot, iWhoMove)
        End If

        'winning condition
        If humanEmpty() Then
            slot(COMPUTER_BASE) = slot(COMPUTER_BASE) + slot(7) + slot(8) + slot(9) + slot(10) + slot(11) + slot(12)
            slot(7) = 0
            slot(8) = 0
            slot(9) = 0
            slot(10) = 0
            slot(11) = 0
            slot(12) = 0
        End If
        If computerEmpty() Then
            slot(HUMAN_BASE) = slot(HUMAN_BASE) + slot(0) + slot(1) + slot(2) + slot(3) + slot(4) + slot(5)
            slot(0) = 0
            slot(1) = 0
            slot(2) = 0
            slot(3) = 0
            slot(4) = 0
            slot(5) = 0
        End If
        drawBoard()
        If humanEmpty() And computerEmpty() Then
            If slot(COMPUTER_BASE) > slot(HUMAN_BASE) Then
                LblResult.Visible = True
                LblResult.Text = "Pemain II Menang!"
            ElseIf slot(COMPUTER_BASE) < slot(HUMAN_BASE) Then
                LblResult.Visible = True
                LblResult.Text = "Pemain I Menang!"
            Else
                LblResult.Visible = True
                LblResult.Text = "seri!!!"
            End If
        End If
        drawBoard()
    End Function
    Private Sub cekNextTurn(ByVal islot As Integer)
        If islot = HUMAN_BASE Then
            MessageBox.Show("Jalan Lagi")
            game_turn = HUMAN
        Else
            MessageBox.Show("Giliran Pemain II")
            game_turn = COMPUTER
        End If
    End Sub
    Private Sub cekNextTurnComputer(ByVal islot As Integer)
        If islot = COMPUTER_BASE Then
            MessageBox.Show("Jalan Lagi")
            game_turn = COMPUTER
        Else
            MessageBox.Show("Giliran Pemain I")
            game_turn = HUMAN
        End If
    End Sub
    Private Sub lblMy1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMy1.Click
        Dim islot As Integer = 0
        pickSlot(islot, HUMAN)
        'moveCount = moveCount + 1
        cekNextTurn(islot)
    End Sub

    Private Sub lblMy2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMy2.Click
        Dim islot As Integer = 1
        pickSlot(islot, HUMAN)
        'moveCount = moveCount + 1
        cekNextTurn(islot)
    End Sub

    Private Sub lblMy3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMy3.Click
        Dim islot As Integer = 2
        pickSlot(islot, HUMAN)
        'moveCount = moveCount + 1
        cekNextTurn(islot)
    End Sub

    Private Sub lblMy4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMy4.Click
        Dim islot As Integer = 3
        pickSlot(islot, HUMAN)
        'moveCount = moveCount + 1
        cekNextTurn(islot)
    End Sub

    Private Sub lblMy5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMy5.Click
        Dim islot As Integer = 4
        pickSlot(islot, HUMAN)
        'moveCount = moveCount + 1
        cekNextTurn(islot)
    End Sub

    Private Sub lblMy6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMy6.Click
        Dim islot As Integer = 5
        pickSlot(islot, HUMAN)
        'moveCount = moveCount + 1
        cekNextTurn(islot)
    End Sub
    Private Sub lblEnemy6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnemy1.Click
        Dim islot As Integer = 7
        pickSlot(islot, COMPUTER)
        'moveCount = moveCount + 1
        cekNextTurnComputer(islot)
    End Sub

    Private Sub lblEnemy5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnemy2.Click
        Dim islot As Integer = 8
        pickSlot(islot, COMPUTER)
        'moveCount = moveCount + 1
        cekNextTurnComputer(islot)
    End Sub

    Private Sub lblEnemy4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnemy3.Click
        Dim islot As Integer = 9
        pickSlot(islot, COMPUTER)
        'moveCount = moveCount + 1
        cekNextTurnComputer(islot)
    End Sub

    Private Sub lblEnemy3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnemy4.Click
        Dim islot As Integer = 10
        pickSlot(islot, COMPUTER)
        'moveCount = moveCount + 1
        cekNextTurnComputer(islot)
    End Sub

    Private Sub lblEnemy2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnemy5.Click
        Dim islot As Integer = 11
        pickSlot(islot, COMPUTER)
        'moveCount = moveCount + 1
        cekNextTurnComputer(islot)
    End Sub

    Private Sub lblEnemy1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnemy6.Click
        Dim islot As Integer = 12
        pickSlot(islot, COMPUTER)
        'moveCount = moveCount + 1
        cekNextTurnComputer(islot)
    End Sub

    Private Sub timerBlink_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerBlink.Tick
        If game_turn = COMPUTER Then
            lblComp.Text = "Pemain II Jalan"
            lblHuman.Text = "Menunggu..."
            lblComp.Visible = Not lblComp.Visible
            lblHuman.Visible = True
            picHuman.Visible = False
            picComp.Visible = True
        Else
            lblHuman.Text = "Pemain I Jalan"
            lblComp.Text = "Menunggu..."
            lblHuman.Visible = Not lblHuman.Visible
            lblComp.Visible = True
            picComp.Visible = False
            picHuman.Visible = True
        End If
    End Sub

    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keluar.Click
        If MessageBox.Show("Keluar Dari Permainan?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Petunjuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Petunjuk.Click
        FormPetunjuk.Show()
    End Sub

    Private Sub TimerGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGame.Tick
        TimerGame.Enabled = False
        If game_turn = COMPUTER Then
            MessageBox.Show("Giliran Pemain II")
        Else
            MessageBox.Show("Giliran Pemain I")
        End If
    End Sub

    Private Sub Pengaturan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pengaturan.Click
        If gameInProgress Then
            If MessageBox.Show("Akan memulai game baru?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DialogPemain.ShowDialog()
                Dim iStartSlot As Integer = DialogPemain.PemainBiji.Value
                If DialogPemain.PemainII.Checked Then game_turn = COMPUTER Else game_turn = HUMAN
                'If DialogKonfigurasi.optLev1.Checked Then level = 1 Else level = 2
                JUMLAH_BIJI = iStartSlot
                gameInProgress = True
                'moveCount = 0
                initBoard()
                drawBoard()
                LblResult.Visible = False
                TimerGame.Enabled = True
            End If
        Else
            DialogPemain.ShowDialog()
            Dim iStartSlot As Integer = DialogPemain.PemainBiji.Value
            If DialogPemain.PemainII.Checked Then game_turn = COMPUTER Else game_turn = HUMAN
            'If DialogKonfigurasi.optLev1.Checked Then level = 1 Else level = 2
            JUMLAH_BIJI = iStartSlot
            gameInProgress = True
            'moveCount = 0
            initBoard()
            drawBoard()
            LblResult.Visible = False
            TimerGame.Enabled = True
        End If
    End Sub

    Private Sub Kembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kembali.Click
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class