Imports System.Data.OleDb
Public Class D_PRESCRIPTION
    'CONNECTION
    Dim CONN As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\BMedina011\Downloads\OHOHCARIE's FILES\THESIS, ASSIGNENT, ETC\PATIENTINFORMATION\addpatient.accdb")
    Public Sub executequery(query As String)
        Dim command As New OleDbCommand(query, CONN)
        CONN.Open()
        command.ExecuteNonQuery()
    End Sub
    'SEARCH
    Private Sub TXTSEARCH1_MouseEnter(sender As Object, e As EventArgs) Handles TXTSEARCH1.MouseEnter
        TXTSEARCH1.Text = ""
    End Sub
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        CONN.Open()
        Dim SQLQUERY As String
        SQLQUERY = "SELECT ADDPATIENTINFORMATION.PATIENT_ID, ADDPATIENTINFORMATION.LASTNAME, ADDPATIENTINFORMATION.FIRSTNAME, ADDPATIENTINFORMATION.MIDDLENAME, ADDPATIENTINFORMATION.GENDER, ADDPATIENTINFORMATION.AGE, ADDPATIENTINFORMATION.ADDRESS, TREATMENT_DETAILS.TREATMENTNAME FROM ADDPATIENTINFORMATION LEFT JOIN TREATMENT_DETAILS ON ADDPATIENTINFORMATION.PATIENT_ID = TREATMENT_DETAILS.PATIENT_ID WHERE ADDPATIENTINFORMATION.PATIENT_ID LIKE '%" & TXTSEARCH1.Text & "%' ORDER BY TREATMENT_DETAILS.TREATMENT_ID DESC"
        Dim cmd1 As New OleDbCommand(SQLQUERY, CONN)
        Dim DR As OleDbDataReader
        DR = cmd1.ExecuteReader()

        If DR.Read() Then
            TXTPATIENTID1.Text = (DR("PATIENT_ID").ToString())
            TXTLASTNAME1.Text = (DR("LASTNAME").ToString())
            TXTFIRSTNAME1.Text = (DR("FIRSTNAME").ToString())
            TXTMIDDLENAME1.Text = (DR("MIDDLENAME").ToString())
            If (DR("GENDER").ToString()) = "FEMALE" Then
                RBTNFEMALE.Checked = True
            ElseIf (DR("GENDER").ToString()) = "MALE" Then
                RBTNMALE.Checked = True
            End If
            TXTAGE1.Text = (DR("AGE").ToString())
            TXTADDRESS1.Text = (DR("ADDRESS").ToString())
            TXTTREATMENTNAME.Text = (DR("TREATMENTNAME").ToString())
            MsgBox("PATIENT INFORMATION FOUND", MsgBoxStyle.Information, "INFORMATION MESSAGE")
            TXTPRESCRIPTIONNO.Enabled = True
            TXTDRUGNAME.Enabled = True
            TXTQTY.Enabled = True
            TXTTIMING.Enabled = True
            TXTDETAILS.Enabled = True

        ElseIf Not DR.Read() Then
            MsgBox("PATIENT INFORMATION NOT FOUND", MsgBoxStyle.Information, "INFORMATION MESSAGE")
            TXTPATIENTID1.Text = ""
            TXTLASTNAME1.Text = ""
            TXTFIRSTNAME1.Text = ""
            TXTMIDDLENAME1.Text = ""
            RBTNMALE.Checked = False
            RBTNFEMALE.Checked = False
            TXTPRESCRIPTIONNO.Text = ""
            TXTDRUGNAME.Text = ""
            TXTQTY.Text = ""
            TXTTIMING.Text = ""
            TXTDETAILS.Text = ""
            TXTPRESCRIPTIONNO.Enabled = False
            TXTDRUGNAME.Enabled = False
            TXTQTY.Enabled = False
            TXTTIMING.Enabled = False
            TXTDETAILS.Enabled = False
            TXTSEARCH1.Text = "SEARCH BY PATIENT ID"

        End If
        CONN.Close()
    End Sub
    'CANCEL
    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        TXTPATIENTID1.Text = ""
        TXTLASTNAME1.Text = ""
        TXTFIRSTNAME1.Text = ""
        TXTMIDDLENAME1.Text = ""
        RBTNMALE.Checked = False
        RBTNFEMALE.Checked = False
        TXTAGE1.Text = ""
        TXTADDRESS1.Text = ""
        TXTTREATMENTNAME.Text = ""
        TXTPRESCRIPTIONNO.Text = ""
        TXTDRUGNAME.Text = ""
        TXTQTY.Text = ""
        TXTTIMING.Text = ""
        TXTDETAILS.Text = ""
        TXTPRESCRIPTIONNO.Enabled = False
        TXTDRUGNAME.Enabled = False
        TXTQTY.Enabled = False
        TXTTIMING.Enabled = False
        TXTDETAILS.Enabled = False
        TXTSEARCH1.Text = "SEARCH BY PATIENT ID"
    End Sub

    Private Sub BTNSAVEPINFO_Click(sender As Object, e As EventArgs) Handles BTNSAVEPINFO.Click
        If (CONN.State = ConnectionState.Open) Then
            CONN.Close()
        End If
        CONN.Open()
        Dim com As New OleDbCommand("INSERT INTO PRESCRIPTION_DETAILS(PATIENT_ID, LASTNAME, FIRSTNAME, MIDDLENAME, AGE, ADDRESS, PRESCRIPTIONNUMBER, DRUGNAME, QUANTITY,TIMING,DETAILS) VALUES(@ID, @LN, @FN, @MN, @A, @AD, @PN, @DN, @QTY, @T, @DT)", CONN)
        com.Parameters.AddWithValue("@ID", TXTPATIENTID1.Text)
        com.Parameters.AddWithValue("@LN", TXTLASTNAME1.Text)
        com.Parameters.AddWithValue("@FN", TXTFIRSTNAME1.Text)
        com.Parameters.AddWithValue("@MN", TXTMIDDLENAME1.Text)
        com.Parameters.AddWithValue("@A", TXTAGE1.Text)
        com.Parameters.AddWithValue("@AD", TXTADDRESS1.Text)
        com.Parameters.AddWithValue("@PN", TXTPRESCRIPTIONNO.Text)
        com.Parameters.AddWithValue("@DN", TXTDRUGNAME.Text)
        com.Parameters.AddWithValue("@QTY", TXTQTY.Text)
        com.Parameters.AddWithValue("@T", TXTTIMING.Text)
        com.Parameters.AddWithValue("@DT", TXTDETAILS.Text)
        Try
            com.ExecuteNonQuery()
            MsgBox("YOUR REQUEST HAS BEEN SUCCESSFULLY PRESCRIBED" & vbNewLine & "BY THE DOCTOR.", MsgBoxStyle.Information, "INFORMATION")
            RPTPRESCRIPTION.Show()
            CONN.Close()
        Catch ex As Exception

            CONN.Close()
        End Try
        CONN.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLCLOCK.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub D_PRESCRIPTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub TXTSEARCH1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSEARCH1.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub
End Class
