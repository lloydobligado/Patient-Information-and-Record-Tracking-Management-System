Imports System.Data.OleDb
Public Class S_ADDPATIENTINFO
    ' /////////////////// C O N N E C T I O N ///////////////////////
    Dim CONN As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\BMedina011\Downloads\OHOHCARIE's FILES\THESIS, ASSIGNENT, ETC\PATIENTINFORMATION\addpatient.accdb")
    Dim CMD As New OleDbCommand
    Dim GENDER As String

    Private Sub RBTNMALE_CheckedChanged(sender As Object, e As EventArgs) Handles RBTNMALE.CheckedChanged
        GENDER = "MALE"
    End Sub

    Private Sub RBTNFEMALE_CheckedChanged(sender As Object, e As EventArgs) Handles RBTNFEMALE.CheckedChanged
        GENDER = "FEMALE"
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblclock.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    '///////////////////////// C H O O S E  P H O T O //////////////////////////
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PBPHOTO.Load(Me.OpenFileDialog1.FileName)
        Else
            MsgBox("Please choose your photo")
        End If
    End Sub

    '//////////////////// P R O D U C T  I D /////////////////////////
    Public PATIENTID As String
    Public QUERY As String

    Public Sub GETPRODUCTID()
        Try
            If (CONN.State = ConnectionState.Open) Then
                CONN.Close()
            End If

            Dim SQL As String = "SELECT PATIENT_ID FROM ADDPATIENTINFORMATION ORDER BY PATIENT_ID DESC"
            CONN.Open()
            Dim COMMAND As New OleDbCommand(SQL, CONN)
            Dim DR As OleDbDataReader = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)

            If (DR.Read) = True Then
                Dim ID As Integer
                ID = (DR(0) + 1)
                PATIENTID = ID.ToString("000000")

            ElseIf IsDBNull(DR) Then
                PATIENTID = ("000001")

            Else
                PATIENTID = ("000001")

            End If
        Catch EX As Exception

            MsgBox(EX.Message, "GETPRODUCTID()")
        Finally
            CONN.Close()
            TXTPATIENTID1.Text = PATIENTID
        End Try


    End Sub

    '/////////////////////////////// S A V E  I N F O /////////////////////////////////////////////
    Private Sub BTNSAVEPINFO_Click(sender As Object, e As EventArgs) Handles BTNSAVEPINFO.Click
        If (CONN.State = ConnectionState.Open) Then
            CONN.Close()
        End If
        Dim INSERT As String = "INSERT INTO ADDPATIENTINFORMATION (LASTNAME,FIRSTNAME,MIDDLENAME,GENDER,BIRTHDAY,AGE,ADDRESS,PHONE,EMAIL,MD,REASON) VALUES( @LNAME,@FNAME,@MNAME,@GENDER,@BIRTHDAY,@AGE,@ADDRESS,@PHONE,@EMAIL,@MD,@REASON)"
        Dim COMMAND As New OleDbCommand(INSERT, CONN)
        CONN.Open()

        COMMAND.Parameters.Add("@LNAME", OleDbType.VarChar).Value = TXTLASTNAME1.Text
        COMMAND.Parameters.Add("@FNAME", OleDbType.VarChar).Value = TXTFIRSTNAME1.Text
        COMMAND.Parameters.Add("@MNAME", OleDbType.VarChar).Value = TXTMIDDLENAME1.Text
        COMMAND.Parameters.Add("@GENDER", OleDbType.VarChar).Value = GENDER
        COMMAND.Parameters.Add("@BIRTHDAY", OleDbType.VarChar).Value = DTPBIRTHDAY1.Text
        COMMAND.Parameters.Add("@AGE", OleDbType.VarChar).Value = TXTAGE1.Text
        COMMAND.Parameters.Add("@ADDRESS", OleDbType.VarChar).Value = TXTADDRESS1.Text
        COMMAND.Parameters.Add("@PHONE", OleDbType.VarChar).Value = TXTPHONE1.Text
        COMMAND.Parameters.Add("@EMAIL", OleDbType.VarChar).Value = TXTEMAIL1.Text
        COMMAND.Parameters.Add("@MD", OleDbType.VarChar).Value = CMBMD1.Text
        COMMAND.Parameters.Add("@REASON", OleDbType.VarChar).Value = TXTREASON1.Text

        Try
            COMMAND.ExecuteNonQuery()
            MsgBox("PATIENT INFO WAS ADDED", MsgBoxStyle.Information, "INFORMATION")
            Dim com As New OleDbCommand("INSERT INTO TREATMENT_DETAILS (PATIENT_ID) VALUES( @PATIENTID)", CONN)
            com.Parameters.AddWithValue("@PATIENTID", TXTPATIENTID1.Text)

            Try
                com.ExecuteNonQuery()
                TXTPATIENTID1.Text = ""
                TXTLASTNAME1.Text = ""
                TXTFIRSTNAME1.Text = ""
                TXTMIDDLENAME1.Text = ""
                RBTNFEMALE.Checked = False
                RBTNMALE.Checked = False
                DTPBIRTHDAY1.Text = ""
                TXTAGE1.Text = ""
                TXTADDRESS1.Text = ""
                TXTPATIENTID1.Text = ""
                TXTEMAIL1.Text = ""
                CMBMD1.Text = ""
                TXTREASON1.Text = ""
                TXTPHONE1.Text = ""
                PBPHOTO.Image = My.Resources.giphy
                GETPRODUCTID()

            Catch ex As Exception
                CONN.Close()
            End Try
            CONN.Close()

        Catch ex As Exception
            CONN.Close()
        End Try
        CONN.Close()

    End Sub


    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        MsgBox("ARE YOU SURE YOU WANT TO CLEAR ALL DATA?", MsgBoxStyle.YesNo, "CLEAR INFORMATION")
        If (MsgBoxResult.Yes) Then
            TXTLASTNAME1.Text = ""
            TXTFIRSTNAME1.Text = ""
            TXTMIDDLENAME1.Text = ""
            RBTNFEMALE.Checked = False
            RBTNMALE.Checked = False
            DTPBIRTHDAY1.Text = ""
            TXTAGE1.Text = ""
            TXTADDRESS1.Text = ""
            TXTEMAIL1.Text = ""
            CMBMD1.Text = ""
            TXTREASON1.Text = ""
            TXTPHONE1.Text = ""
            PBPHOTO.Image = My.Resources.giphy
            GETPRODUCTID()
        End If
    End Sub

    Private Sub S_ADDPATIENTINFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
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


    Private Sub TXTPATIENTID1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPATIENTID1.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub
End Class
