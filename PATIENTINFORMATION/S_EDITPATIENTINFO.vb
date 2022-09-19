Imports System.Data.OleDb
Public Class S_EDITPATIENTINFO
    'CONNECTION
    Dim CONN As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\BMedina011\Downloads\OHOHCARIE's FILES\THESIS, ASSIGNENT, ETC\PATIENTINFORMATION\addpatient.accdb")
    Public Sub executequery(query As String)
        Dim command As New OleDbCommand(query, conn)
        conn.Open()
        command.ExecuteNonQuery()
    End Sub

    'START UP
    Private Sub S_EDITPATIENTINFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLCLOCK.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    'CHOOSE YOUR PHOTO
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PBPHOTO.Load(Me.OpenFileDialog1.FileName)
        Else
            MsgBox("Please choose your photo")
        End If
    End Sub

    'VALUE CHANGED
    Dim GENDER As String
    Private Sub TXTPATIENTID1_TextChanged(sender As Object, e As EventArgs) Handles TXTPATIENTID1.TextChanged
        TXTLASTNAME1.Enabled = True
        TXTFIRSTNAME1.Enabled = True
        TXTMIDDLENAME1.Enabled = True
        RBTNMALE.Enabled = True
        RBTNFEMALE.Enabled = True
        DTPBIRTHDAY1.Enabled = True
        TXTADDRESS1.Enabled = True
        CMBMD1.Enabled = True
        TXTEMAIL1.Enabled = True
        TXTREASON1.Enabled = True
        TXTPHONE1.Enabled = True
        PBPHOTO.Enabled = True
    End Sub
    Private Sub DTPBIRTHDAY1_ValueChanged(sender As Object, e As EventArgs) Handles DTPBIRTHDAY1.ValueChanged
        Dim FRUM As DateTime
        Dim TU As DateTime
        Dim TSPAN As TimeSpan
        Dim DAYS As Double

        FRUM = DTPBIRTHDAY1.Value
        TU = DateTime.Now.ToString("MM/dd/yy")
        TSPAN = TU - FRUM
        DAYS = TSPAN.TotalDays
        TXTAGE1.Text = (DAYS / 365).ToString("0")
    End Sub
    Private Sub RBTNMALE_CheckedChanged(sender As Object, e As EventArgs)
        GENDER = "MALE"
    End Sub
    Private Sub RBTNFEMALE_CheckedChanged(sender As Object, e As EventArgs)
        GENDER = "FEMALE"
    End Sub

    'SEARCH
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
            TXTPHONE1.Text = (DR("PHONE").ToString())
            TXTEMAIL1.Text = (DR("EMAIL").ToString())
            CMBMD1.Text = (DR("MD").ToString())
            TXTREASON1.Text = (DR("REASON").ToString())
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
            CMBMD1.Text = ""
            TXTPATIENTID1.Text = ""
            TXTEMAIL1.Text = ""
            TXTREASON1.Text = ""
            TXTPHONE1.Text = ""
            TXTPATIENTID1.Enabled = False
            TXTLASTNAME1.Enabled = False
            TXTFIRSTNAME1.Enabled = False
            TXTMIDDLENAME1.Enabled = False
            RBTNMALE.Enabled = False
            RBTNFEMALE.Enabled = False
            DTPBIRTHDAY1.Enabled = False
            TXTAGE1.Enabled = False
            TXTADDRESS1.Enabled = False
            CMBMD1.Enabled = False
            TXTPATIENTID1.Enabled = False
            TXTEMAIL1.Enabled = False
            TXTREASON1.Enabled = False
            TXTPHONE1.Enabled = False
            PBPHOTO.Enabled = False
            TXTSEARCH1.Text = "SEARCH BY PATIENT ID"
        End If
        CONN.Close()
    End Sub

    'UPDATE INFO
    Private Sub BTNSAVEPINFO_Click(sender As Object, e As EventArgs) Handles BTNSAVEPINFO.Click
        Dim QUESTION = MsgBox("ARE YOU SURE TO UPDATE INFORMATION? ", MsgBoxStyle.YesNo, "QUESTION MESSAGE")

        If QUESTION = vbYes Then
            Dim updatequery As String = "UPDATE ADDPATIENTINFORMATION SET LASTNAME= '" & TXTLASTNAME1.Text & "', FIRSTNAME= '" & TXTFIRSTNAME1.Text & "', MIDDLENAME= '" & TXTMIDDLENAME1.Text & "', GENDER='" & GENDER & "', BIRTHDAY= '" & DTPBIRTHDAY1.Text & "', AGE= " & TXTAGE1.Text & ", ADDRESS='" & TXTADDRESS1.Text & "', PHONE= " & TXTPHONE1.Text & ", EMAIL= '" & TXTEMAIL1.Text & "', MD= '" & CMBMD1.Text & "', REASON= '" & TXTREASON1.Text & "' WHERE PATIENT_ID=" & TXTPATIENTID1.Text & ""

            Try
                If TXTPATIENTID1.Text = "" Then
                    MsgBox("SELECT PATIENT INFORMATION FIRST", MsgBoxStyle.Information, "INFORMATION MESSAGE")
                    CONN.Close()

                ElseIf Not TXTPATIENTID1.Text = "" Then
                    executequery(updatequery)
                    CONN.Close()
                    MsgBox("THE PATIENT ID YOU ENTER" & vbNewLine & "ARE NOW UPDATED!", MsgBoxStyle.Information, "INFORMATION MESSAGE")
                    TXTPATIENTID1.Text = ""
                    TXTLASTNAME1.Text = ""
                    TXTFIRSTNAME1.Text = ""
                    TXTMIDDLENAME1.Text = ""
                    RBTNMALE.Checked = False
                    RBTNFEMALE.Checked = False
                    DTPBIRTHDAY1.Value = Date.Now
                    TXTAGE1.Text = ""
                    TXTADDRESS1.Text = ""
                    CMBMD1.Text = ""
                    TXTPATIENTID1.Text = ""
                    TXTEMAIL1.Text = ""
                    TXTREASON1.Text = ""
                    TXTPHONE1.Text = ""
                    PBPHOTO.Image = My.Resources.giphy
                    TXTPATIENTID1.Enabled = False
                    TXTLASTNAME1.Enabled = False
                    TXTFIRSTNAME1.Enabled = False
                    TXTMIDDLENAME1.Enabled = False
                    RBTNMALE.Enabled = False
                    RBTNFEMALE.Enabled = False
                    DTPBIRTHDAY1.Enabled = False
                    TXTAGE1.Enabled = False
                    TXTADDRESS1.Enabled = False
                    CMBMD1.Enabled = False
                    TXTPATIENTID1.Enabled = False
                    TXTEMAIL1.Enabled = False
                    TXTREASON1.Enabled = False
                    TXTPHONE1.Enabled = False
                    PBPHOTO.Enabled = False
                    TXTSEARCH1.Text = "SEARCH BY PATIENT ID"

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                CONN.Close()
            End Try
        End If
    End Sub

    'DELETE INFO
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim ask = MsgBox("ARE YOU SURE TO DELETE PATIENT INFORMATION? ", MsgBoxStyle.YesNo, "QUESTION MESSAGE")

        If ask = vbYes Then
            Dim com As New OleDbCommand("Delete from ADDPATIENTINFORMATION Where [PATIENT_ID]=@PATIENTID ", CONN)
            com.Parameters.AddWithValue("@PATIENTID", TXTPATIENTID1.Text)

            Try
                CONN.Open()
                com.ExecuteNonQuery()
                MsgBox("THE PATIENT NAME YOU ENTER" & vbNewLine & "ARE NOW DELETED!", MsgBoxStyle.Information, "INFORMATION MESSAGE")
                TXTPATIENTID1.Text = ""
                TXTLASTNAME1.Text = ""
                TXTFIRSTNAME1.Text = ""
                TXTMIDDLENAME1.Text = ""
                RBTNMALE.Checked = False
                RBTNFEMALE.Checked = False
                DTPBIRTHDAY1.Value = Date.Now
                TXTAGE1.Text = ""
                TXTADDRESS1.Text = ""
                CMBMD1.Text = ""
                TXTPATIENTID1.Text = ""
                TXTEMAIL1.Text = ""
                TXTREASON1.Text = ""
                TXTPHONE1.Text = ""
                PBPHOTO.Image = My.Resources.giphy
                TXTPATIENTID1.Enabled = False
                TXTLASTNAME1.Enabled = False
                TXTFIRSTNAME1.Enabled = False
                TXTMIDDLENAME1.Enabled = False
                RBTNMALE.Enabled = False
                RBTNFEMALE.Enabled = False
                DTPBIRTHDAY1.Enabled = False
                TXTAGE1.Enabled = False
                TXTADDRESS1.Enabled = False
                CMBMD1.Enabled = False
                TXTPATIENTID1.Enabled = False
                TXTEMAIL1.Enabled = False
                TXTREASON1.Enabled = False
                TXTPHONE1.Enabled = False
                PBPHOTO.Enabled = False
                TXTSEARCH1.Text = "SEARCH BY PATIENT ID"
                CONN.Close()

            Catch EX As Exception
                MsgBox(EX.Message)
            End Try
        End If
    End Sub

    'CANCEL EDIT
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
            CMBMD1.Text = ""
            TXTPATIENTID1.Text = ""
            TXTEMAIL1.Text = ""
            TXTREASON1.Text = ""
            TXTPHONE1.Text = ""
            PBPHOTO.Image = My.Resources.giphy
            TXTPATIENTID1.Enabled = False
            TXTLASTNAME1.Enabled = False
            TXTFIRSTNAME1.Enabled = False
            TXTMIDDLENAME1.Enabled = False
            RBTNMALE.Enabled = False
            RBTNFEMALE.Enabled = False
            DTPBIRTHDAY1.Enabled = False
            TXTAGE1.Enabled = False
            TXTADDRESS1.Enabled = False
            CMBMD1.Enabled = False
            TXTPATIENTID1.Enabled = False
            TXTEMAIL1.Enabled = False
            TXTREASON1.Enabled = False
            TXTPHONE1.Enabled = False
            PBPHOTO.Enabled = False
            TXTSEARCH1.Text = "SEARCH BY PATIENT ID"
        End If
    End Sub
    '//////////////////////  R E S T R I C T I O N ///////////////////////////////////////////
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

    Private Sub TXTPHONE1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPHONE1.KeyPress
        ' when pressing characters a-z they will not be inputted
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MsgBox("YOU CANNOT INPUT CHARACTERS!" & vbNewLine & " " & vbNewLine & "INPUT NUMBERS ONLY", MsgBoxStyle.Exclamation, "INFORMATION MESSAGE")
        End If
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
