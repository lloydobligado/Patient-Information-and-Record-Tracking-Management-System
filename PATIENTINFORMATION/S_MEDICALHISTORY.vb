Public Class S_MEDICALHISTORY

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Dim MEDICALHISTORY As New MEDICALHISTORY
        MEDICALHISTORY.Load(Application.StartupPath & "\Reports\HISTORY.rpt")
        CrystalReportViewerMEDICALHISTORY.ReportSource = MEDICALHISTORY
        CrystalReportViewerMEDICALHISTORY.RefreshReport()



    End Sub

    Private Sub TXTSEARCH1_MouseEnter(sender As Object, e As EventArgs) Handles TXTSEARCH1.MouseEnter
        TXTSEARCH1.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLCLOCK.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub S_MEDICALHISTORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub TXTSEARCH1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSEARCH1.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If

    End Sub
End Class
