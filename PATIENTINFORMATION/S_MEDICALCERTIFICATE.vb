Imports System.Data.OleDb
Public Class S_MEDICALCERTIFICATE
    'CONNECTION
    Dim CONN As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\BMedina011\Downloads\OHOHCARIE's FILES\THESIS, ASSIGNENT, ETC\PATIENTINFORMATION\addpatient.accdb")
    Public Sub executequery(query As String)
        Dim command As New OleDbCommand(query, conn)
        conn.Open()
        command.ExecuteNonQuery()
    End Sub
    'SEARCH
    Private Sub TXTSEARCH_MouseEnter(sender As Object, e As EventArgs) Handles TXTSEARCH.MouseEnter
        TXTSEARCH.Text = ""
    End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        CONN.Open()
        Dim SQLQUERY As String
        SQLQUERY = "SELECT * FROM ADDPATIENTINFORMATION WHERE PATIENT_ID LIKE '%" & TXTSEARCH.Text & "%' "
        Dim cmd1 As New OleDbCommand(SQLQUERY, CONN)
        Dim DR As OleDbDataReader
        DR = cmd1.ExecuteReader()

        If DR.Read() Then
            TXTPATIENTID1.Text = (DR("PATIENT_ID").ToString())
            TXTLASTNAME1.Text = (DR("LASTNAME").ToString())
            TXTFIRSTNAME1.Text = (DR("FIRSTNAME").ToString())
            TXTMIDDLENAME1.Text = (DR("MIDDLENAME").ToString())
            TXTADDRESS1.Text = (DR("ADDRESS").ToString())
            MsgBox("PATIENT INFORMATION FOUND", MsgBoxStyle.Information, "INFORMATION MESSAGE")
            DTPREQUEST.Enabled = True
            TXTATTENDINGPHYSICIAN.Enabled = True

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
    'VALUE CHANGED
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TXTPAYMENT.Text = "75 PESOS"
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TXTPAYMENT.Text = "115 PESOS"
        End If
    End Sub
    'REQUEST
    Private Sub BTNSAVEPINFO_Click(sender As Object, e As EventArgs) Handles BTNSAVEPINFO.Click
        If (CONN.State = ConnectionState.Open) Then
            CONN.Close()
        End If
        CONN.Open()
        Dim com As New OleDbCommand("INSERT INTO CERTIFICATE(PATIENT_ID, LASTNAME, FIRSTNAME, MIDDLENAME, ADDRESS, ATTENDINGPHYSICIAN, PAYMENT, DATEOFREQUEST) VALUES(@ID, @LN, @FN, @MN, @A, @AP, @P, @D)", CONN)
        com.Parameters.AddWithValue("@ID", TXTPATIENTID1.Text)
        com.Parameters.AddWithValue("@LN", TXTLASTNAME1.Text)
        com.Parameters.AddWithValue("@FN", TXTFIRSTNAME1.Text)
        com.Parameters.AddWithValue("@MN", TXTMIDDLENAME1.Text)
        com.Parameters.AddWithValue("@A", TXTADDRESS1.Text)
        com.Parameters.AddWithValue("@AP", TXTATTENDINGPHYSICIAN.Text)
        com.Parameters.AddWithValue("@P", TXTPAYMENT.Text)
        com.Parameters.AddWithValue("@D", DTPREQUEST.Text)
        Try
            com.ExecuteNonQuery()
            MsgBox("YOUR REQUEST HAS BEEN SUCCESSFULLY SUBMITTED" & vbNewLine & "AND BEING PROCESSED BY THE DOCTOR.", MsgBoxStyle.Information, "INFORMATION")
            TXTPATIENTID1.Text = ""
            TXTLASTNAME1.Text = ""
            TXTFIRSTNAME1.Text = ""
            TXTMIDDLENAME1.Text = ""
            TXTADDRESS1.Text = ""
            DTPREQUEST.Value = Date.Now
            TXTATTENDINGPHYSICIAN.Text = ""
            TXTPAYMENT.Text = ""
            DTPREQUEST.Enabled = False
            TXTATTENDINGPHYSICIAN.Enabled = False
            TXTSEARCH.Text = "SEARCH BY PATIENT ID"
            CONN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CONN.Close()
        End Try
        CONN.Close()

    End Sub
    ' ÇANCEL
    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        TXTPATIENTID1.Text = ""
        TXTLASTNAME1.Text = ""
        TXTFIRSTNAME1.Text = ""
        TXTMIDDLENAME1.Text = ""
        TXTADDRESS1.Text = ""
        DTPREQUEST.Value = Date.Now
        TXTATTENDINGPHYSICIAN.Text = ""
        TXTPAYMENT.Text = ""
        DTPREQUEST.Enabled = False
        TXTATTENDINGPHYSICIAN.Enabled = False
        TXTSEARCH.Text = "SEARCH BY PATIENT ID"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLCLOCK.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub S_MEDICALCERTIFICATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged

    End Sub

    Private Sub TXTSEARCH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSEARCH.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub
End Class
