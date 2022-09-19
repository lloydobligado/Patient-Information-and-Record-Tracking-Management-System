Imports System.Data.OleDb
Public Class S_MEDICALRECORD
    'CONNECTION
    Dim CONN As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\BMedina011\Downloads\OHOHCARIE's FILES\THESIS, ASSIGNENT, ETC\PATIENTINFORMATION\addpatient.accdb")
    Public Sub executequery(query As String)
        Dim command As New OleDbCommand(query, CONN)
        CONN.Open()
        command.ExecuteNonQuery()
    End Sub
    'START UP
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLCLOCK.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub
    Private Sub S_MEDICALRECORD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    'VALUE CHANGED
    Dim GENDER As String
    Private Sub RBTNMALE_CheckedChanged(sender As Object, e As EventArgs)
        GENDER = "MALE"
    End Sub
    Private Sub RBTNFEMALE_CheckedChanged(sender As Object, e As EventArgs)
        GENDER = "FEMALE"
    End Sub
    'SEARCH INFO
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        CONN.Open()
        Dim SQLQUERY As String
        SQLQUERY = "SELECT * FROM ADDPATIENTINFORMATION WHERE PATIENT_ID LIKE '%" & TXTSEARCH1.Text & "%' "
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
            DTPBIRTHDAY1.Value = DR(5)
            TXTAGE1.Text = (DR("AGE").ToString())
            TXTADDRESS1.Text = (DR("ADDRESS").ToString())
            TXTHEIGHT2.Text = (DR("HEIGHT").ToString())
            TXTWEIGHT2.Text = (DR("WEIGHT").ToString())
            TXTBP2.Text = (DR("BLOOD_PRESSURE").ToString())
            TXTFINDINGS2.Text = (DR("FINDINGS").ToString())
            TXTSTATUSOFDISEASE2.Text = (DR("STATUS_OF_DISEASE").ToString())

            MsgBox("PATIENT INFORMATION FOUND", MsgBoxStyle.Information, "INFORMATION MESSAGE")

        ElseIf Not DR.Read() Then
            MsgBox("PATIENT INFORMATION NOT FOUND", MsgBoxStyle.Information, "INFORMATION MESSAGE")
            TXTPATIENTID1.Text = ""
            TXTLASTNAME1.Text = ""
            TXTFIRSTNAME1.Text = ""
            TXTMIDDLENAME1.Text = ""
            RBTNMALE.Checked = False
            RBTNFEMALE.Checked = False
            DTPBIRTHDAY1.Value = Date.Now
            TXTAGE1.Text = ""
            TXTADDRESS1.Text = ""
            TXTPATIENTID1.Text = ""
            TXTHEIGHT2.Text = ""
            TXTWEIGHT2.Text = ""
            TXTBP2.Text = ""
            TXTFINDINGS2.Text = ""
            TXTSTATUSOFDISEASE2.Text = ""
            TXTPATIENTID1.Enabled = False
            TXTLASTNAME1.Enabled = False
            TXTFIRSTNAME1.Enabled = False
            TXTMIDDLENAME1.Enabled = False
            RBTNFEMALE.Enabled = False
            RBTNMALE.Enabled = False
            DTPBIRTHDAY1.Enabled = False
            TXTAGE1.Enabled = False
            TXTADDRESS1.Enabled = False
            TXTPATIENTID1.Enabled = False
            TXTHEIGHT2.Enabled = False
            TXTWEIGHT2.Enabled = False
            TXTFINDINGS2.Enabled = False
            TXTSTATUSOFDISEASE2.Enabled = False
            TXTBP2.Enabled = False
            TXTSEARCH1.Text = "SEARCH BY PATIENT ID"
        End If
        CONN.Close()
    End Sub

    Private Sub BTNSAVEPINFO_Click(sender As Object, e As EventArgs) Handles BTNSAVEPINFO.Click
        Dim QUESTION = MsgBox("ARE YOU SURE TO SAVE RECORD? ", MsgBoxStyle.YesNo, "QUESTION MESSAGE")
        If QUESTION = vbYes Then

            Dim updatequery As String = "UPDATE ADDPATIENTINFORMATION SET LASTNAME= '" & TXTLASTNAME1.Text & "', FIRSTNAME= '" & TXTFIRSTNAME1.Text & "', MIDDLENAME= '" & TXTMIDDLENAME1.Text & "', GENDER='" & GENDER & "', BIRTHDAY= '" & DTPBIRTHDAY1.Text & "', AGE= " & TXTAGE1.Text & ", ADDRESS='" & TXTADDRESS1.Text & "', HEIGHT= '" & TXTHEIGHT2.Text & "', WEIGHT= '" & TXTWEIGHT2.Text & "', BLOOD_PRESSURE= '" & TXTBP2.Text & "', FINDINGS= '" & TXTFINDINGS2.Text & "', STATUS_OF_DISEASE= '" & TXTSTATUSOFDISEASE2.Text & "' WHERE PATIENT_ID=" & TXTPATIENTID1.Text & ""

            Try
                If TXTPATIENTID1.Text = "" Then
                    MsgBox("SELECT PATIENT INFORMATION FIRST", MsgBoxStyle.Information, "INFORMATION MESSAGE")
                    CONN.Close()
                ElseIf Not TXTPATIENTID1.Text = "" Then
                    executequery(updatequery)
                    CONN.Close()
                    MsgBox("THE PATIENT ID YOU ENTER" & vbNewLine & "ARE NOW SAVED!", MsgBoxStyle.Information, "INFORMATION MESSAGE")
                    TXTPATIENTID1.Text = ""
                    TXTLASTNAME1.Text = ""
                    TXTFIRSTNAME1.Text = ""
                    TXTMIDDLENAME1.Text = ""
                    RBTNMALE.Checked = False
                    RBTNFEMALE.Checked = False
                    DTPBIRTHDAY1.Value = Date.Now
                    TXTAGE1.Text = ""
                    TXTADDRESS1.Text = ""
                    TXTPATIENTID1.Text = ""
                    TXTHEIGHT2.Text = ""
                    TXTWEIGHT2.Text = ""
                    TXTBP2.Text = ""
                    TXTFINDINGS2.Text = ""
                    TXTSTATUSOFDISEASE2.Text = ""
                    TXTPATIENTID1.Enabled = False
                    TXTLASTNAME1.Enabled = False
                    TXTFIRSTNAME1.Enabled = False
                    TXTMIDDLENAME1.Enabled = False
                    RBTNFEMALE.Enabled = False
                    RBTNMALE.Enabled = False
                    DTPBIRTHDAY1.Enabled = False
                    TXTAGE1.Enabled = False
                    TXTADDRESS1.Enabled = False
                    TXTPATIENTID1.Enabled = False
                    TXTHEIGHT2.Enabled = False
                    TXTWEIGHT2.Enabled = False
                    TXTFINDINGS2.Enabled = False
                    TXTSTATUSOFDISEASE2.Enabled = False
                    TXTBP2.Enabled = False
                    TXTSEARCH1.Text = "SEARCH BY PATIENT ID"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                CONN.Close()
            End Try
        End If
    End Sub
    'CANCEL
    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        MsgBox("ARE YOU SURE YOU WANT TO CLEAR ALL DATA?", MsgBoxStyle.YesNo, "CLEAR INFORMATION")
        If (MsgBoxResult.Yes) Then
          TXTPATIENTID1.Text = ""
            TXTLASTNAME1.Text = ""
            TXTFIRSTNAME1.Text = ""
            TXTMIDDLENAME1.Text = ""
            RBTNMALE.Checked = False
            RBTNFEMALE.Checked = False
            DTPBIRTHDAY1.Value = Date.Now
            TXTAGE1.Text = ""
            TXTADDRESS1.Text = ""
            TXTPATIENTID1.Text = ""
            TXTHEIGHT2.Text = ""
            TXTWEIGHT2.Text = ""
            TXTBP2.Text = ""
            TXTFINDINGS2.Text = ""
            TXTSTATUSOFDISEASE2.Text = ""
            TXTPATIENTID1.Enabled = False
            TXTLASTNAME1.Enabled = False
            TXTFIRSTNAME1.Enabled = False
            TXTMIDDLENAME1.Enabled = False
            RBTNFEMALE.Enabled = False
            RBTNMALE.Enabled = False
            DTPBIRTHDAY1.Enabled = False
            TXTAGE1.Enabled = False
            TXTADDRESS1.Enabled = False
            TXTPATIENTID1.Enabled = False
            TXTHEIGHT2.Enabled = False
            TXTWEIGHT2.Enabled = False
            TXTFINDINGS2.Enabled = False
            TXTSTATUSOFDISEASE2.Enabled = False
            TXTBP2.Enabled = False
            TXTSEARCH1.Text = "SEARCH BY PATIENT ID"
        End If
    End Sub
    'RESTRICTION
    Private Sub TXTLASTNAME1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTLASTNAME1.KeyPress
        ' when pressing characters 0-9 they will not be inputted
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("YOU CANNOT INPUT NUMBERS!" & vbNewLine & "INPUT LETTERS ONLY", MsgBoxStyle.Exclamation, "INFORMATION MESSAGE")
        End If
    End Sub
    Private Sub TXTFIRSTNAME1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTFIRSTNAME1.KeyPress
        ' when pressing characters 0-9 they will not be inputted
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("YOU CANNOT INPUT NUMBERS!" & vbNewLine & "INPUT LETTERS ONLY", MsgBoxStyle.Exclamation, "INFORMATION MESSAGE")
        End If
    End Sub
    Private Sub TXTMIDDLENAME1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTMIDDLENAME1.KeyPress
        ' when pressing characters 0-9 they will not be inputted
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("YOU CANNOT INPUT NUMBERS!" & vbNewLine & "INPUT LETTERS ONLY", MsgBoxStyle.Exclamation, "INFORMATION MESSAGE")
        End If
    End Sub
    Private Sub TXTFINDINGS2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTFINDINGS2.KeyPress
        ' when pressing characters 0-9 they will not be inputted
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("YOU CANNOT INPUT NUMBERS!" & vbNewLine & "INPUT LETTERS ONLY", MsgBoxStyle.Exclamation, "INFORMATION MESSAGE")
        End If
    End Sub
    Private Sub TXTSTATUSOFDISEASE2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSTATUSOFDISEASE2.KeyPress
        ' when pressing characters 0-9 they will not be inputted
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("YOU CANNOT INPUT NUMBERS!" & vbNewLine & "INPUT LETTERS ONLY", MsgBoxStyle.Exclamation, "INFORMATION MESSAGE")
        End If
    End Sub

    Private Sub TXTPATIENTID1_TextChanged(sender As Object, e As EventArgs) Handles TXTPATIENTID1.TextChanged
        TXTLASTNAME1.Enabled = True
        TXTFIRSTNAME1.Enabled = True
        TXTMIDDLENAME1.Enabled = True
        RBTNMALE.Enabled = True
        RBTNFEMALE.Enabled = True
        DTPBIRTHDAY1.Enabled = True
        TXTADDRESS1.Enabled = True
        TXTHEIGHT2.Enabled = True
        TXTWEIGHT2.Enabled = True
        TXTBP2.Enabled = True
        TXTFINDINGS2.Enabled = True
        TXTSTATUSOFDISEASE2.Enabled = True
    End Sub

    Private Sub TXTSEARCH1_MouseEnter(sender As Object, e As EventArgs) Handles TXTSEARCH1.MouseEnter
        TXTSEARCH1.Text = ""
    End Sub

    Private Sub TXTSEARCH1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSEARCH1.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub
End Class
