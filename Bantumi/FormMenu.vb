Public Class FormMenu

    Private Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
       
    End Sub

    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keluar.Click
        If MessageBox.Show("Keluar Dari Permainan?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Petunjuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Petunjuk.Click
        FormPetunjuk.Show()
    End Sub

    Private Sub Komputer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Komputer.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub Pemain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pemain.Click
        FormPemain.Show()
        Me.Hide()
    End Sub
End Class