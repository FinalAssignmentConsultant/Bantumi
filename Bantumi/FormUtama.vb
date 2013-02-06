Public Class FormUtama
    Dim level As Integer
    Dim xoriginSlot0 As Integer
    Dim xoriginSlot1 As Integer
    Dim xoriginSlot2 As Integer
    Dim xoriginSlot3 As Integer
    Dim xoriginSlot4 As Integer
    Dim xoriginSlot5 As Integer
    Dim xoriginHumanBase As Integer

    Dim xoriginSlot7 As Integer
    Dim xoriginSlot8 As Integer
    Dim xoriginSlot9 As Integer
    Dim xoriginSlot10 As Integer
    Dim xoriginSlot11 As Integer
    Dim xoriginSlot12 As Integer
    Dim xoriginComputerBase As Integer

    Dim LAST_DROP As Integer
    Dim JUMLAH_BIJI As Integer = 4
    Dim LOCK_DRAWING As Boolean = False
    Dim moveCount As Integer = 0
    Dim gameInProgress As Boolean = False
    Dim computerBase As Integer = 0
    Const SLEEP = 500
    Const COMPUTER_BASE = 13
    Const HUMAN_BASE = 6
    Const HUMAN = 0
    Const COMPUTER = 1
    Dim game_turn As Integer = HUMAN
    Dim humanBase As Integer = 0
    Dim slot(14) As Integer

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
    Private Sub FormUtama_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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


        If simulateOnly Then
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
        End If

        Dim seed As Integer
        seed = slot(islot)
        slot(islot) = 0
        whoMove = iWhoMove

        ' pada setiap looping, cek di lubang mana jatuhnya
        While seed > 0 'habiskan semua biji yg diambil
            islot = moveNextSlot(islot)  'maju ke slot berikutnya
            slot(islot) = slot(islot) + 1
            'If Not simulateOnly Then drawBoard()
            If Not LOCK_DRAWING Then
                drawBoard()
                System.Threading.Thread.Sleep(SLEEP)
            End If
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
            If slot(islot) > 1 And islot <> COMPUTER_BASE And islot <> HUMAN_BASE Then pickSlot(islot, iWhoMove, False) 'recursive
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
        If Not LOCK_DRAWING Then drawBoard()
        If humanEmpty() And computerEmpty() Then
            If slot(COMPUTER_BASE) > slot(HUMAN_BASE) Then
                If Not simulateOnly Then
                    gameInProgress = False
                    LblResult.Visible = True
                    LblResult.Text = "Komputer Menang!"
                End If

            ElseIf slot(COMPUTER_BASE) < slot(HUMAN_BASE) Then
                If Not simulateOnly Then
                    gameInProgress = False
                    LblResult.Visible = True
                    LblResult.Text = "Pemain Menang!"
                End If
            Else
                If Not simulateOnly Then
                    gameInProgress = False
                    LblResult.Visible = True
                    LblResult.Text = "seri!!!"
                End If
            End If

        End If
        If Not LOCK_DRAWING Then drawBoard()
        Dim retVal As Integer
        If iWhoMove = COMPUTER Then retVal = slot(COMPUTER_BASE)
        If iWhoMove = HUMAN Then retVal = slot(HUMAN_BASE)

        If simulateOnly Then
            slot(0) = originSlot0
            slot(1) = originSlot1
            slot(2) = originSlot2
            slot(3) = originSlot3
            slot(4) = originSlot4
            slot(5) = originSlot5
            slot(HUMAN_BASE) = originHumanBase
            slot(7) = originSlot7
            slot(8) = originSlot8
            slot(9) = originSlot9
            slot(10) = originSlot10
            slot(11) = originSlot11
            slot(12) = originSlot12
            slot(COMPUTER_BASE) = originComputerBase
        End If
        'kembalikan nilai islot, yaitu dimana jatuhnya slot terakhir
        LAST_DROP = islot
        Return retVal
    End Function
    Private Function humanEmpty() As Boolean
        Return slot(0) = 0 And slot(1) = 0 And slot(2) = 0 And slot(3) = 0 And slot(4) = 0 And slot(5) = 0
    End Function
    Private Function computerEmpty() As Boolean
        Return slot(7) = 0 And slot(8) = 0 And slot(9) = 0 And slot(10) = 0 And slot(11) = 0 And slot(12) = 0
    End Function
    Private Sub cekNextTurn(ByVal islot As Integer)
        If islot = HUMAN_BASE Then
            game_turn = HUMAN
        Else
            game_turn = COMPUTER
        End If
    End Sub
    Private Sub cekNextTurnComputer(ByVal islot As Integer)
        If islot = COMPUTER_BASE Then
            game_turn = COMPUTER
        Else
            game_turn = HUMAN
        End If
    End Sub

    Private Sub lblMy1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMy1.Click
        Dim islot As Integer = 0
        pickSlot(islot, HUMAN)
        moveCount = moveCount + 1
        cekNextTurn(islot)

    End Sub

    Private Sub lblMy2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMy2.Click
        Dim islot As Integer = 1
        pickSlot(islot, HUMAN)
        moveCount = moveCount + 1
        cekNextTurn(islot)
    End Sub

    Private Sub lblMy3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMy3.Click
        Dim islot As Integer = 2
        pickSlot(islot, HUMAN)
        moveCount = moveCount + 1
        cekNextTurn(islot)
    End Sub

    Private Sub lblMy4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMy4.Click
        Dim islot As Integer = 3
        pickSlot(islot, HUMAN)
        moveCount = moveCount + 1
        cekNextTurn(islot)
    End Sub

    Private Sub lblMy5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMy5.Click
        Dim islot As Integer = 4
        pickSlot(islot, HUMAN)
        moveCount = moveCount + 1
        cekNextTurn(islot)
    End Sub

    Private Sub lblMy6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMy6.Click
        Dim islot As Integer = 5
        pickSlot(islot, HUMAN)
        moveCount = moveCount + 1
        cekNextTurn(islot)
    End Sub
    Public Sub NewGame()
        If gameInProgress Then
            If MessageBox.Show("Akan memulai game baru?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DialogKonfigurasi.ShowDialog()
                Dim iStartSlot As Integer = DialogKonfigurasi.updnJumlahBiji.Value
                If DialogKonfigurasi.optKomputer.Checked Then game_turn = COMPUTER Else game_turn = HUMAN
                If DialogKonfigurasi.optLev1.Checked Then level = 1 Else level = 2
                JUMLAH_BIJI = iStartSlot
                gameInProgress = True
                moveCount = 0
                initBoard()
                drawBoard()
                LblResult.Visible = False
                TimerGame.Enabled = True
            End If
        Else
            DialogKonfigurasi.ShowDialog()
            Dim iStartSlot As Integer
            iStartSlot = DialogKonfigurasi.updnJumlahBiji.Value
            If DialogKonfigurasi.optKomputer.Checked Then game_turn = COMPUTER Else game_turn = HUMAN
            If DialogKonfigurasi.optLev1.Checked Then level = 1 Else level = 2
            JUMLAH_BIJI = iStartSlot
            initBoard()
            gameInProgress = True
            drawBoard()
            LblResult.Visible = False
            TimerGame.Enabled = True
        End If
    End Sub
    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Keluar Dari Permainan?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub lblEnemy6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnemy1.Click
        'pickSlot(7, COMPUTER)
    End Sub

    Private Sub lblEnemy5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnemy2.Click
        'pickSlot(8, COMPUTER)
    End Sub

    Private Sub lblEnemy4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnemy3.Click
        'pickSlot(9, COMPUTER)
    End Sub

    Private Sub lblEnemy3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnemy4.Click
        'pickSlot(10, COMPUTER)
    End Sub

    Private Sub lblEnemy2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnemy5.Click
        'pickSlot(11, COMPUTER)
    End Sub

    Private Sub lblEnemy1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnemy6.Click
        'pickSlot(12, COMPUTER)
    End Sub

    Private Sub RedrawToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        drawBoard()
    End Sub

    Private Sub ComputerAlmostWinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slot(6) = 0
        slot(7) = 0
        slot(8) = 0
        slot(9) = 0
        slot(10) = 0
        slot(11) = 0
        slot(12) = 1
        slot(COMPUTER_BASE) = 4 * 5 + 3
        drawBoard()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click

        NewGame()
        'lblTotal.Text = "Total Move: " & moveCount
    End Sub
    Private Sub saveState()
        xoriginSlot0 = slot(0)
        xoriginSlot1 = slot(1)
        xoriginSlot2 = slot(2)
        xoriginSlot3 = slot(3)
        xoriginSlot4 = slot(4)
        xoriginSlot5 = slot(5)
        xoriginHumanBase = slot(HUMAN_BASE)
        xoriginSlot7 = slot(7)
        xoriginSlot8 = slot(8)
        xoriginSlot9 = slot(9)
        xoriginSlot10 = slot(10)
        xoriginSlot11 = slot(11)
        xoriginSlot12 = slot(12)
        xoriginComputerBase = slot(COMPUTER_BASE)
    End Sub
    Public Sub restoreState()
        slot(0) = xoriginSlot0
        slot(1) = xoriginSlot1
        slot(2) = xoriginSlot2
        slot(3) = xoriginSlot3
        slot(4) = xoriginSlot4
        slot(5) = xoriginSlot5
        slot(HUMAN_BASE) = xoriginHumanBase
        slot(7) = xoriginSlot7
        slot(8) = xoriginSlot8
        slot(9) = xoriginSlot9
        slot(10) = xoriginSlot10
        slot(11) = xoriginSlot11
        slot(12) = xoriginSlot12
        slot(COMPUTER_BASE) = xoriginComputerBase
    End Sub
    Private Sub TimerGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGame.Tick
        TimerGame.Enabled = False
        If game_turn = COMPUTER Then
            Dim s As SortedList = New SortedList
            Dim terbesarSlot As Integer
            Dim terbesar As Integer
            LOCK_DRAWING = True
            MessageBox.Show("Giliran Komputer")
            'G & T : cek all result
            'SAVE ALL STATES
            Dim q1 As Integer
            Dim q2 As Integer
            Dim q3 As Integer
            Dim q4 As Integer
            Dim q5 As Integer
            Dim q6 As Integer
            saveState()
            Dim s0 As Integer = pickSlot(7, COMPUTER)
            Dim is0 As Integer = LAST_DROP
            If level = 2 And is0 = COMPUTER_BASE Then
                'MessageBox.Show("Berhenti di mangkuk, jalan lagi")
                'MessageBox.Show("slot p1 - p1")
                q1 = pickSlot(7, COMPUTER, True)
                'MessageBox.Show("slot p1 - p2")
                q2 = pickSlot(8, COMPUTER, True)
                'MessageBox.Show("slot p1 - p3")
                q3 = pickSlot(9, COMPUTER, True)
                'MessageBox.Show("slot p1 - p4")
                q4 = pickSlot(10, COMPUTER, True)
                'MessageBox.Show("slot p1 - p5")
                q5 = pickSlot(11, COMPUTER, True)
                'MessageBox.Show("slot p1 - p6")
                q6 = pickSlot(12, COMPUTER, True)
                terbesar = cariTerbesar(s, q1, q2, q3, q4, q5, q6)
                If terbesar > s0 Then s0 = terbesar
            End If
            'MessageBox.Show("Hasil P1,lanjut P2")

            restoreState()
            Dim s1 As Integer = pickSlot(8, COMPUTER)
            Dim is1 As Integer = LAST_DROP
            If level = 2 And is1 = COMPUTER_BASE Then
                'MessageBox.Show("Berhenti di mangkuk, jalan lagi")
                'MessageBox.Show("slot p2 - p1")
                q1 = pickSlot(7, COMPUTER, True)
                'MessageBox.Show("slot p2 - p2")
                q2 = pickSlot(8, COMPUTER, True)
                'MessageBox.Show("slot p2 - p3")
                q3 = pickSlot(9, COMPUTER, True)
                'MessageBox.Show("slot p2 - p4")
                q4 = pickSlot(10, COMPUTER, True)
                'MessageBox.Show("slot p2 - p5")
                q5 = pickSlot(11, COMPUTER, True)
                'MessageBox.Show("slot p2 - p6")
                q6 = pickSlot(12, COMPUTER, True)
                terbesar = cariTerbesar(s, q1, q2, q3, q4, q5, q6)
                If terbesar > s1 Then s1 = terbesar
            End If
            'MessageBox.Show("Hasil P2,lanjut P3")

            restoreState()
            Dim s2 As Integer = pickSlot(9, COMPUTER)
            Dim is2 As Integer = LAST_DROP
            If level = 2 And is2 = COMPUTER_BASE Then
                'MessageBox.Show("Berhenti di mangkuk, jalan lagi")
                'MessageBox.Show("slot p3 - p1")
                q1 = pickSlot(7, COMPUTER, True)
                ' MessageBox.Show("slot p3 - p2")
                q2 = pickSlot(8, COMPUTER, True)
                'MessageBox.Show("slot p3 - p3")
                q3 = pickSlot(9, COMPUTER, True)
                'MessageBox.Show("slot p3 - p4")
                q4 = pickSlot(10, COMPUTER, True)
                'MessageBox.Show("slot p3 - p5")
                q5 = pickSlot(11, COMPUTER, True)
                'MessageBox.Show("slot p3 - p6")
                q6 = pickSlot(12, COMPUTER, True)
                terbesar = cariTerbesar(s, q1, q2, q3, q4, q5, q6)
                If terbesar > s2 Then s2 = terbesar
            End If
            'MessageBox.Show("Hasil P3,lanjut P4")

            restoreState()
            Dim s3 As Integer = pickSlot(10, COMPUTER)
            Dim is3 As Integer = LAST_DROP
            If level = 2 And is3 = COMPUTER_BASE Then
                'MessageBox.Show("Berhenti di mangkuk, jalan lagi")
                'MessageBox.Show("slot p4 - p1")
                q1 = pickSlot(7, COMPUTER, True)
                'MessageBox.Show("slot p4 - p2")
                q2 = pickSlot(8, COMPUTER, True)
                'MessageBox.Show("slot p4 - p3")
                q3 = pickSlot(9, COMPUTER, True)
                'MessageBox.Show("slot p4 - p4")
                q4 = pickSlot(10, COMPUTER, True)
                'MessageBox.Show("slot p4 - p5")
                q5 = pickSlot(11, COMPUTER, True)
                'MessageBox.Show("slot p4 - p6")
                q6 = pickSlot(12, COMPUTER, True)
                terbesar = cariTerbesar(s, q1, q2, q3, q4, q5, q6)
                If terbesar > s3 Then s3 = terbesar
            End If
            'MessageBox.Show("Hasil P4,lanjut P5")

            restoreState()
            Dim s4 As Integer = pickSlot(11, COMPUTER)
            Dim is4 As Integer = LAST_DROP
            If level = 2 And is4 = COMPUTER_BASE Then
                'MessageBox.Show("Berhenti di mangkuk, jalan lagi")
                'MessageBox.Show("slot p5 - p1")
                q1 = pickSlot(7, COMPUTER, True)
                'MessageBox.Show("slot p5 - p2")
                q2 = pickSlot(8, COMPUTER, True)
                'MessageBox.Show("slot p5 - p3")
                q3 = pickSlot(9, COMPUTER, True)
                'MessageBox.Show("slot p5 - p4")
                q4 = pickSlot(10, COMPUTER, True)
                'MessageBox.Show("slot p5 - p5")
                q5 = pickSlot(11, COMPUTER, True)
                'MessageBox.Show("slot p5 - p6")
                q6 = pickSlot(12, COMPUTER, True)
                terbesar = cariTerbesar(s, q1, q2, q3, q4, q5, q6)
                If terbesar > s4 Then s4 = terbesar
            End If
            'MessageBox.Show("Hasil P5,lanjut P6")

            restoreState()
            Dim s5 As Integer = pickSlot(12, COMPUTER)
            Dim is5 As Integer = LAST_DROP
            If level = 2 And is5 = COMPUTER_BASE Then
                'MessageBox.Show("Berhenti di mangkuk, jalan lagi")
                'MessageBox.Show("slot p6 - p1")
                q1 = pickSlot(7, COMPUTER, True)
                'MessageBox.Show("slot p6 - p2")
                q2 = pickSlot(8, COMPUTER, True)
                'MessageBox.Show("slot p6 - p3")
                q3 = pickSlot(9, COMPUTER, True)
                'MessageBox.Show("slot p6 - p4")
                q4 = pickSlot(10, COMPUTER, True)
                'MessageBox.Show("slot p6 - p5")
                q5 = pickSlot(11, COMPUTER, True)
                'MessageBox.Show("slot p6 - p6")
                q6 = pickSlot(12, COMPUTER, True)
                terbesar = cariTerbesar(s, q1, q2, q3, q4, q5, q6)
                If terbesar > s5 Then s5 = terbesar
            End If
            'MessageBox.Show("Hasil P6")
            'drawBoard()
            restoreState()
            LOCK_DRAWING = False
            cariTerbesar(s, s0, s1, s2, s3, s4, s5, terbesarSlot)
            'moveCount = moveCount + 1
            'lblTotal.Text = "Total Move: " & moveCount
            pickSlot(terbesarSlot, COMPUTER)
            cekNextTurnComputer(terbesarSlot)
        End If
        TimerGame.Enabled = True
    End Sub
    Function cariTerbesar(ByVal s As SortedList, ByVal s0 As Integer, ByVal s1 As Integer, ByVal s2 As Integer, ByVal s3 As Integer, ByVal s4 As Integer, ByVal s5 As Integer, Optional ByRef terbesarSlot As Integer = -1) As Integer
        s.Clear()
        s.Add(7, s0)
        s.Add(8, s1)
        s.Add(9, s2)
        s.Add(10, s3)
        s.Add(11, s4)
        s.Add(12, s5)
        Dim de As IDictionaryEnumerator = s.GetEnumerator
        de.MoveNext()
        Dim terbesar As Integer = de.Value
        terbesarSlot = de.Key
        While de.MoveNext
            If de.Value > terbesar Then
                terbesar = de.Value
                terbesarSlot = de.Key
            End If
        End While
        Return terbesar
    End Function
    Private Sub timerBlink_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerBlink.Tick
        'lblTotal.Text = "Total Move: " & moveCount

        If game_turn = COMPUTER Then
            lblComp.Text = "Komputer Jalan"
            lblHuman.Text = "Menunggu..."
            lblComp.Visible = Not lblComp.Visible
            lblHuman.Visible = True
            picHuman.Visible = False
            picComp.Visible = True
        Else
            lblHuman.Text = "Pemain Jalan"
            lblComp.Text = "Menunggu..."
            lblHuman.Visible = Not lblHuman.Visible
            lblComp.Visible = True
            picComp.Visible = False
            picHuman.Visible = True
        End If
    End Sub

    Private Sub Pengaturan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pengaturan.Click
        If gameInProgress Then
            If MessageBox.Show("Akan memulai game baru?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DialogKonfigurasi.ShowDialog()
                Dim iStartSlot As Integer = DialogKonfigurasi.updnJumlahBiji.Value
                If DialogKonfigurasi.optKomputer.Checked Then game_turn = COMPUTER Else game_turn = HUMAN
                If DialogKonfigurasi.optLev1.Checked Then level = 1 Else level = 2
                JUMLAH_BIJI = iStartSlot
                gameInProgress = True
                moveCount = 0
                initBoard()
                drawBoard()
                LblResult.Visible = False
                TimerGame.Enabled = True
            End If
        Else
            DialogKonfigurasi.ShowDialog()
            Dim iStartSlot As Integer
            iStartSlot = DialogKonfigurasi.updnJumlahBiji.Value
            If DialogKonfigurasi.optKomputer.Checked Then game_turn = COMPUTER Else game_turn = HUMAN
            If DialogKonfigurasi.optLev1.Checked Then level = 1 Else level = 2
            JUMLAH_BIJI = iStartSlot
            initBoard()
            gameInProgress = True
            drawBoard()
            LblResult.Visible = False
            TimerGame.Enabled = True
        End If
    End Sub

    Private Sub Petunjuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Petunjuk.Click
        FormPetunjuk.Show()
    End Sub

    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keluar.Click
        If MessageBox.Show("Keluar Dari Permainan?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub SimulasiToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimulasiToolStripMenuItem.Click
        FormSimulasi.Show()
        Me.Hide()
    End Sub
    Private Sub Kembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kembali.Click
        FormMenu.Show()
        Me.Close()
    End Sub
End Class
