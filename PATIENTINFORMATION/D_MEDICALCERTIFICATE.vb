Imports System.Data.OleDb
Public Class D_MEDICALCERTIFICATE
    'CONNECTION
    Dim CONN As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\BMedina011\Downloads\OHOHCARIE's FILES\THESIS, ASSIGNENT, ETC\PATIENTINFORMATION\addpatient.accdb")
    Public Sub executequery(query As String)
        Dim command As New OleDbCommand(query, CONN)
        CONN.Open()
        command.ExecuteNonQuery()
        'SEARCH
    End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        CONN.Open()
        Dim SQLQUERY As String
        SQLQUERY = "SELECT * FROM CERTIFICATE WHERE PATIENT_ID LIKE '%" & TXTPANEL.Text & "%' ORDER BY ID DESC "
        Dim cmd1 As New OleDbCommand(SQLQUERY, CONN)
        Dim DR As OleDbDataReader
        DR = cmd1.ExecuteReader()

        If DR.Read() Then
            TXTPATIENTID1.Text = (DR("PATIENT_ID").ToString())
            TXTLASTNAME1.Text = (DR("LASTNAME").ToString())
            TXTFIRSTNAME1.Text = (DR("FIRSTNAME").ToString())
            TXTMIDDLENAME1.Text = (DR("MIDDLENAME").ToString())
            TXTADDRESS1.Text = (DR("ADDRESS").ToString())
            TXTATTENDINGPHYSICIAN.Text = (DR("ATTENDINGPHYSICIAN").ToString())
            TXTPAYMENT.Text = (DR("PAYMENT").ToString())
            DTPREQUEST.Value = (DR(9))
            TXTPANEL.Text = "SEARCH BY PATIENT ID"
            MsgBox("PATIENT INFORMATION FOUND", MsgBoxStyle.Information, "INFORMATION MESSAGE")
            TXTDIAGNOSIS.Enabled = True

        ElseIf Not DR.Read() Then
            MsgBox("PATIENT INFORMATION NOT FOUND", MsgBoxStyle.Information, "INFORMATION MESSAGE")
            TXTPATIENTID1.Text = ""
            TXTLASTNAME1.Text = ""
            TXTFIRSTNAME1.Text = ""
            TXTMIDDLENAME1.Text = ""
            TXTADDRESS1.Text = ""
            DTPREQUEST.Value = Date.Now
            TXTATTENDINGPHYSICIAN.Text = ""
            TXTPAYMENT.Text = ""
            TXTPATIENTID1.Enabled = False
            TXTLASTNAME1.Enabled = False
            TXTFIRSTNAME1.Enabled = False
            TXTMIDDLENAME1.Enabled = False
            TXTADDRESS1.Enabled = False
            DTPREQUEST.Enabled = False
            TXTATTENDINGPHYSICIAN.Enabled = False
            TXTPAYMENT.Enabled = False
            TXTSEARCH.Text = "SEARCH BY PATIENT ID"
        End If
        CONN.Close()
    End Sub

    Private Sub TextBox2_MouseEnter(sender As Object, e As EventArgs) Handles TXTSEARCH.MouseEnter
        TXTSEARCH.Text = ""
    End Sub

    Private Sub BTNSAVEPINFO_Click(sender As Object, e As EventArgs) Handles BTNSAVEPINFO.Click
        Dim QUESTION = MsgBox("ARE YOU SURE TO PREVIEW MEDICAL CERTIFICATE? ", MsgBoxStyle.YesNo, "QUESTION MESSAGE")

        If QUESTION = vbYes Then
            Dim updatequery As String = "UPDATE CERTIFICATE SET DIAGNOSIS= '" & TXTDIAGNOSIS.Text & "' WHERE PATIENT_ID=" & TXTPATIENTID1.Text & ""

            Try
                If TXTPATIENTID1.Text = "" Then
                    MsgBox("SELECT PATIENT INFORMATION FIRST", MsgBoxStyle.Information, "INFORMATION MESSAGE")
                    CONN.Close()

                ElseIf Not TXTPATIENTID1.Text = "" Then
                    executequery(updatequery)
                    CONN.Close()
                    RPTMEDICALCERTIFICATE.Show()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                CONN.Close()
            End Try
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLCLOCK.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub D_MEDICALCERTIFICATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub TXTSEARCH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSEARCH.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub
End Class
