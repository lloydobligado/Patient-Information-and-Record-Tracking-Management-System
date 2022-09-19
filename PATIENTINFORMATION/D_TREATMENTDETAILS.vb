Imports System.Data.OleDb
Public Class D_TREATMENTDETAILS
    'CONNECTION
    Dim CONN As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\BMedina011\Downloads\OHOHCARIE's FILES\THESIS, ASSIGNENT, ETC\PATIENTINFORMATION\addpatient.accdb")
    Public Sub executequery(query As String)
        Dim command As New OleDbCommand(query, CONN)
        CONN.Open()
        command.ExecuteNonQuery()
    End Sub
    'SAVE
    Private Sub BTNSAVEPINFO_Click(sender As Object, e As EventArgs) Handles BTNSAVEPINFO.Click
        If (CONN.State = ConnectionState.Open) Then
            CONN.Close()
        End If

        Dim QUESTION = MsgBox("ARE YOU SURE TO SAVE TREATMENT DETAILS? ", MsgBoxStyle.YesNo, "QUESTION MESSAGE")
        If QUESTION = vbYes Then

            Dim updatequery As String = "UPDATE TREATMENT_DETAILS SET TREATMENT_DATE= '" & DTPTREATMENTDATE.Text & "', TREATMENTNAME= '" & TXTTREATMENTNAME.Text & "', TIMEPERIOD= '" & TXTAPPROXIMATETIME.Text & "', COST= '" & TXTAPPROXIMATECOST.Text & "' WHERE PATIENT_ID=" & TXTPATIENTID1.Text & ""

            Try
                If TXTPATIENTID1.Text = "" Then
                    MsgBox("SELECT PATIENT INFORMATION FIRST", MsgBoxStyle.Information, "INFORMATION MESSAGE")
                ElseIf Not TXTPATIENTID1.Text = "" Then
                    executequery(updatequery)
                    CONN.Close()
                    MsgBox("THE PATIENT'S TREATMENT DETAILS" & vbNewLine & "ARE NOW SAVED!", MsgBoxStyle.Information, "INFORMATION MESSAGE")
                    TXTPATIENTID1.Text = ""
                    TXTLASTNAME1.Text = ""
                    TXTFIRSTNAME1.Text = ""
                    TXTMIDDLENAME1.Text = ""
                    RBTNMALE.Checked = False
                    RBTNFEMALE.Checked = False
                    TXTAGE1.Text = ""
                    TXTADDRESS1.Text = ""
                    CMBMD1.Text = ""
                    TXTREASON1.Text = ""
                    TXTTREATMENTNAME.Text = ""
                    TXTAPPROXIMATETIME.Text = ""
                    TXTAPPROXIMATECOST.Text = ""
                    TXTSEARCH1.Text = "SEARCH BY PATIENT ID"
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    'CANCEL
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        TXTPATIENTID1.Text = ""
        TXTLASTNAME1.Text = ""
        TXTFIRSTNAME1.Text = ""
        TXTMIDDLENAME1.Text = ""
        RBTNMALE.Checked = False
        RBTNFEMALE.Checked = False
        TXTAGE1.Text = ""
        TXTADDRESS1.Text = ""
        TXTPATIENTID1.Text = ""
        CMBMD1.Text = ""
        TXTREASON1.Text = ""
        TXTTREATMENTNAME.Text = ""
        TXTAPPROXIMATETIME.Text = ""
        TXTAPPROXIMATECOST.Text = ""
        TXTSEARCH1.Text = "SEARCH BY PATIENT ID"
    End Sub
    'NEW
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        TXTTREATMENTNAME.Text = ""
        TXTAPPROXIMATETIME.Text = ""
        TXTAPPROXIMATECOST.Text = ""
        If (CONN.State = ConnectionState.Open) Then
            CONN.Close()
        End If
        Dim INSERT As String = "INSERT INTO TREATMENT_DETAILS (PATIENT_ID) VALUES( @PATIENTID)"
        Dim COMMAND As New OleDbCommand(INSERT, CONN)
        CONN.Open()

        COMMAND.Parameters.Add("@PATIENTID", OleDbType.VarChar).Value = TXTPATIENTID1.Text

        Try
            COMMAND.ExecuteNonQuery()
        Catch ex As Exception
            CONN.Close()
        End Try
        CONN.Close()
    End Sub
    'SEARCH
    Private Sub TXTSEARCH1_MouseEnter(sender As Object, e As EventArgs) Handles TXTSEARCH1.MouseEnter
        TXTSEARCH1.Text = ""
    End Sub
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        CONN.Open()
        Dim SQLQUERY As String
        SQLQUERY = "SELECT ADDPATIENTINFORMATION.PATIENT_ID, ADDPATIENTINFORMATION.LASTNAME, ADDPATIENTINFORMATION.FIRSTNAME, ADDPATIENTINFORMATION.MIDDLENAME, ADDPATIENTINFORMATION.GENDER, ADDPATIENTINFORMATION.BIRTHDAY, ADDPATIENTINFORMATION.AGE, ADDPATIENTINFORMATION.ADDRESS, ADDPATIENTINFORMATION.PHONE, ADDPATIENTINFORMATION.EMAIL, ADDPATIENTINFORMATION.MD, ADDPATIENTINFORMATION.REASON, TREATMENT_DETAILS.TREATMENTNAME, TREATMENT_DETAILS.TIMEPERIOD, TREATMENT_DETAILS.COST FROM ADDPATIENTINFORMATION LEFT JOIN TREATMENT_DETAILS ON ADDPATIENTINFORMATION.PATIENT_ID = TREATMENT_DETAILS.PATIENT_ID WHERE ADDPATIENTINFORMATION.PATIENT_ID LIKE '%" & TXTSEARCH1.Text & "%' ORDER BY TREATMENT_DETAILS.TREATMENT_ID DESC"
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
            CMBMD1.Text = (DR("MD").ToString())
            TXTREASON1.Text = (DR("REASON").ToString())
            TXTTREATMENTNAME.Text = (DR("TREATMENTNAME").ToString())
            TXTAPPROXIMATETIME.Text = (DR("TIMEPERIOD").ToString())
            TXTAPPROXIMATECOST.Text = (DR("COST").ToString())
            MsgBox("PATIENT INFORMATION FOUND", MsgBoxStyle.Information, "INFORMATION MESSAGE")

        ElseIf Not DR.Read() Then
            MsgBox("PATIENT INFORMATION NOT FOUND", MsgBoxStyle.Information, "INFORMATION MESSAGE")
            TXTPATIENTID1.Text = ""
            TXTLASTNAME1.Text = ""
            TXTFIRSTNAME1.Text = ""
            TXTMIDDLENAME1.Text = ""
            RBTNMALE.Checked = False
            RBTNFEMALE.Checked = False
            TXTAGE1.Text = ""
            TXTADDRESS1.Text = ""
            TXTPATIENTID1.Text = ""
            CMBMD1.Text = ""
            TXTREASON1.Text = ""
            TXTSEARCH1.Text = "SEARCH BY PATIENT ID"

        End If
        CONN.Close()
    End Sub
    'VALUE CHANGED
    Private Sub TXTPATIENTID1_TextChanged(sender As Object, e As EventArgs) Handles TXTPATIENTID1.TextChanged

        If TXTPATIENTID1.Text = "" Then
            TXTTREATMENTNAME.Enabled = False
            TXTAPPROXIMATETIME.Enabled = False
            TXTAPPROXIMATECOST.Enabled = False

        Else
            TXTTREATMENTNAME.Enabled = True
            TXTAPPROXIMATETIME.Enabled = True
            TXTAPPROXIMATECOST.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLCLOCK.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub D_TREATMENTDETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub TXTSEARCH1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSEARCH1.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub
End Class
