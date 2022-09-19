Imports System.Data.OleDb
Public Class Form1
    ' /////////////////// C O N N E C T I O N ///////////////////////
    Dim CONN As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\BMedina011\Downloads\OHOHCARIE's FILES\THESIS, ASSIGNENT, ETC\PATIENTINFORMATION\addpatient.accdb")
    Dim CMD As New OleDbCommand
    'PATIENT INFO 
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        If PNLPATIENTINFO.Visible = False Then
            BunifuTransitionSETTINGS.HideSync(PNLLOGOUT)
            BunifuTransitionSTAFFREQUEST.HideSync(PNLMEDICALCERT)
            PNLPATIENTINFO.BringToFront()
            BunifuTransitionPATIENTINFO.ShowSync(PNLPATIENTINFO)
        ElseIf PNLPATIENTINFO.Visible = True Then
            BunifuTransitionPATIENTINFO.HideSync(PNLPATIENTINFO)
            BunifuTransitionSTAFFREQUEST.HideSync(PNLMEDICALCERT)
        End If
    End Sub
    'ADD PATIENT INFORMATION
    Private Sub BunifuFlatButton13_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton13.Click
        BunifuTransitionSTAFFREQUEST.HideSync(PNLMEDICALCERT)
        BunifuTransitionPATIENTINFO.HideSync(PNLPATIENTINFO)
        BunifuTransitionEDITPATIENT.HideSync(S_EDITPATIENTINFO1)
        BunifuTransitionhome.HideSync(S_HOME1)
        BunifuTransitionMEDRECORD.HideSync(S_MEDICALRECORD1)
        BunifuTransitionMEDRECORD.HideSync(S_MEDICALHISTORY1)
        BunifuTransitionADDPATIENT.HideSync(S_MEDICALCERTIFICATE1)
        BunifuTransitionADDPATIENT.ShowSync(S_ADDPATIENTINFO1)
    End Sub
    'HOME
    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        BunifuTransitionSETTINGS.HideSync(PNLLOGOUT)
        BunifuTransitionSTAFFREQUEST.HideSync(PNLMEDICALCERT)
        BunifuTransitionSTAFFREQUEST.HideSync(PNLMEDICALCERT)
        BunifuTransitionPATIENTINFO.HideSync(PNLPATIENTINFO)
        BunifuTransitionADDPATIENT.HideSync(S_ADDPATIENTINFO1)
        BunifuTransitionEDITPATIENT.HideSync(S_EDITPATIENTINFO1)
        BunifuTransitionMEDRECORD.HideSync(S_MEDICALRECORD1)
        BunifuTransitionMEDRECORD.HideSync(S_MEDICALHISTORY1)
        BunifuTransitionADDPATIENT.HideSync(S_MEDICALCERTIFICATE1)
        BunifuTransitionhome.ShowSync(S_HOME1)
    End Sub
    'EDIT PATIENT INFO
    Private Sub BunifuFlatButton12_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton12.Click
        BunifuTransitionSTAFFREQUEST.HideSync(PNLMEDICALCERT)
        BunifuTransitionPATIENTINFO.HideSync(PNLPATIENTINFO)
        BunifuTransitionADDPATIENT.HideSync(S_ADDPATIENTINFO1)
        BunifuTransitionhome.HideSync(S_HOME1)
        BunifuTransitionMEDRECORD.HideSync(S_MEDICALRECORD1)
        BunifuTransitionMEDRECORD.HideSync(S_MEDICALHISTORY1)
        BunifuTransitionADDPATIENT.HideSync(S_MEDICALCERTIFICATE1)
        BunifuTransitionEDITPATIENT.ShowSync(S_EDITPATIENTINFO1)

    End Sub
    'MEDCAL RECORD
    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        BunifuTransitionSTAFFREQUEST.HideSync(PNLMEDICALCERT)
        BunifuTransitionPATIENTINFO.HideSync(PNLPATIENTINFO)
        BunifuTransitionADDPATIENT.HideSync(S_ADDPATIENTINFO1)
        BunifuTransitionhome.HideSync(S_HOME1)
        BunifuTransitionEDITPATIENT.HideSync(S_EDITPATIENTINFO1)
        BunifuTransitionMEDRECORD.HideSync(S_MEDICALHISTORY1)
        BunifuTransitionADDPATIENT.HideSync(S_MEDICALCERTIFICATE1)
        BunifuTransitionMEDRECORD.ShowSync(S_MEDICALRECORD1)
    End Sub
    'MEDICAL HISTORY
    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        BunifuTransitionSTAFFREQUEST.HideSync(PNLMEDICALCERT)
        BunifuTransitionSETTINGS.HideSync(PNLLOGOUT)
        BunifuTransitionPATIENTINFO.HideSync(PNLPATIENTINFO)
        BunifuTransitionADDPATIENT.HideSync(S_ADDPATIENTINFO1)
        BunifuTransitionhome.HideSync(S_HOME1)
        BunifuTransitionEDITPATIENT.HideSync(S_EDITPATIENTINFO1)
        BunifuTransitionMEDRECORD.HideSync(S_MEDICALRECORD1)
        BunifuTransitionADDPATIENT.HideSync(S_MEDICALCERTIFICATE1)
        BunifuTransitionMEDRECORD.ShowSync(S_MEDICALHISTORY1)
    End Sub
    'TREATMENT DETAILS
    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        BunifuTransitionPNLPRESCRIPTION.HideSync(PNLPRESCRIPTION)
        BunifuTransitionSETTINGS.HideSync(PNLLOGOUT)
        BunifuTransitionhome.HideSync(S_HOME1)
        BunifuTransitionDMEDCERT.HideSync(D_MEDICALCERTIFICATE1)
        BunifuTransitionDMEDHISTORY.HideSync(S_MEDICALHISTORY1)
        BunifuTransitionPRESCRIPTION.HideSync(D_PRESCRIPTION1)
        BunifuTransitionADDPATIENT.HideSync(S_MEDICALCERTIFICATE1)
        BunifuTransitionADDPATIENT.ShowSync(D_TREATMENTDETAILS1)
    End Sub
    'HOME
    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        BunifuTransitionSETTINGS.HideSync(PNLLOGOUT)
        BunifuTransitionDMEDCERT.HideSync(D_MEDICALCERTIFICATE1)
        BunifuTransitionADDPATIENT.HideSync(D_TREATMENTDETAILS1)
        BunifuTransitionPRESCRIPTION.HideSync(D_PRESCRIPTION1)
        BunifuTransitionDMEDHISTORY.HideSync(S_MEDICALHISTORY1)
        BunifuTransitionPNLPRESCRIPTION.HideSync(PNLPRESCRIPTION)
        BunifuTransitionhome.ShowSync(S_HOME1)
    End Sub
    'EXIT
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        RPTPRESCRIPTION.Close()
    End Sub
    'PANEL MEDICAL CERTIFICATE
    'STAFF
    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        If PNLMEDICALCERT.Visible = False Then
            BunifuTransitionPATIENTINFO.HideSync(PNLPATIENTINFO)
            BunifuTransitionSETTINGS.HideSync(PNLLOGOUT)
            PNLMEDICALCERT.BringToFront()
            BunifuTransitionSTAFFREQUEST.ShowSync(PNLMEDICALCERT)
        ElseIf PNLMEDICALCERT.Visible = True Then
            BunifuTransitionPATIENTINFO.HideSync(PNLPATIENTINFO)
            BunifuTransitionSTAFFREQUEST.HideSync(PNLMEDICALCERT)
        End If
    End Sub
    'DOCTOR
    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        If PNLPRESCRIPTION.Visible = False Then
            BunifuTransitionSETTINGS.HideSync(PNLLOGOUT)
            PNLPRESCRIPTION.BringToFront()
            BunifuTransitionPNLPRESCRIPTION.ShowSync(PNLPRESCRIPTION)
        ElseIf PNLPRESCRIPTION.Visible = True Then
            BunifuTransitionPNLPRESCRIPTION.HideSync(PNLPRESCRIPTION)
        End If
    End Sub
    'MEDICAL CERTIFICATE
    Private Sub BunifuFlatButton16_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton16.Click
        BunifuTransitionSTAFFREQUEST.HideSync(PNLMEDICALCERT)
        BunifuTransitionPATIENTINFO.HideSync(PNLPATIENTINFO)
        BunifuTransitionEDITPATIENT.HideSync(S_EDITPATIENTINFO1)
        BunifuTransitionhome.HideSync(S_HOME1)
        BunifuTransitionMEDRECORD.HideSync(S_MEDICALRECORD1)
        BunifuTransitionMEDRECORD.HideSync(S_MEDICALHISTORY1)
        BunifuTransitionADDPATIENT.HideSync(S_ADDPATIENTINFO1)
        BunifuTransitionADDPATIENT.ShowSync(S_MEDICALCERTIFICATE1)
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        BunifuTransitionPNLPRESCRIPTION.HideSync(PNLPRESCRIPTION)
        BunifuTransitionSETTINGS.HideSync(PNLLOGOUT)
        BunifuTransitionhome.HideSync(S_HOME1)
        BunifuTransitionADDPATIENT.HideSync(D_TREATMENTDETAILS1)
        BunifuTransitionPRESCRIPTION.HideSync(D_PRESCRIPTION1)
        BunifuTransitionDMEDCERT.HideSync(D_MEDICALCERTIFICATE1)
        BunifuTransitionDMEDHISTORY.ShowSync(S_MEDICALHISTORY1)
    End Sub

    Private Sub BunifuFlatButton14_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton14.Click
        BunifuTransitionPNLPRESCRIPTION.HideSync(PNLPRESCRIPTION)
        BunifuTransitionADDPATIENT.HideSync(D_TREATMENTDETAILS1)
        BunifuTransitionDMEDHISTORY.HideSync(S_MEDICALHISTORY1)
        BunifuTransitionhome.HideSync(S_HOME1)
        BunifuTransitionDMEDCERT.HideSync(D_MEDICALCERTIFICATE1)
        BunifuTransitionPRESCRIPTION.ShowSync(D_PRESCRIPTION1)
    End Sub

    Private Sub BunifuFlatButton15_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton15.Click
        BunifuTransitionPNLPRESCRIPTION.HideSync(PNLPRESCRIPTION)
        BunifuTransitionADDPATIENT.HideSync(D_TREATMENTDETAILS1)
        BunifuTransitionDMEDHISTORY.HideSync(S_MEDICALHISTORY1)
        BunifuTransitionhome.HideSync(S_HOME1)
        BunifuTransitionPRESCRIPTION.HideSync(D_PRESCRIPTION1)
        BunifuTransitionDMEDCERT.ShowSync(D_MEDICALCERTIFICATE1)
    End Sub
    'time
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Date.Now.ToString("dddd,  dd MMM yyyy  hh:mm:ss tt")
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        GETPRODUCTID()
    End Sub

    'PRODUCT ID
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
            S_ADDPATIENTINFO1.TXTPATIENTID1.Text = PATIENTID
        End Try
    End Sub
    'SETTINGS
    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        If PNLLOGOUT.Visible = False Then
            BunifuTransitionPNLPRESCRIPTION.HideSync(PNLPRESCRIPTION)
            PNLLOGOUT.BringToFront()
            BunifuTransitionSETTINGS.ShowSync(PNLLOGOUT)
        ElseIf PNLLOGOUT.Visible = True Then
            BunifuTransitionSETTINGS.HideSync(PNLLOGOUT)
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If PNLLOGOUT.Visible = False Then
            BunifuTransitionSTAFFREQUEST.HideSync(PNLMEDICALCERT)
            BunifuTransitionPATIENTINFO.HideSync(PNLPATIENTINFO)
            PNLLOGOUT.BringToFront()
            BunifuTransitionSETTINGS.ShowSync(PNLLOGOUT)
        ElseIf PNLLOGOUT.Visible = True Then
            BunifuTransitionSETTINGS.HideSync(PNLLOGOUT)
        End If
    End Sub


    Private Sub BunifuFlatButton17_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton17.Click
        BunifuTransitionSETTINGS.HideSync(PNLLOGOUT)
        BunifuTransitionSTAFFREQUEST.HideSync(PNLMEDICALCERT)
        BunifuTransitionPATIENTINFO.HideSync(PNLPATIENTINFO)
        BunifuTransitionADDPATIENT.HideSync(S_ADDPATIENTINFO1)
        BunifuTransitionEDITPATIENT.HideSync(S_EDITPATIENTINFO1)
        BunifuTransitionMEDRECORD.HideSync(S_MEDICALRECORD1)
        BunifuTransitionMEDRECORD.HideSync(S_MEDICALHISTORY1)
        BunifuTransitionADDPATIENT.HideSync(S_MEDICALCERTIFICATE1)
        BunifuTransitionDMEDCERT.HideSync(D_MEDICALCERTIFICATE1)
        BunifuTransitionADDPATIENT.HideSync(D_TREATMENTDETAILS1)
        BunifuTransitionPRESCRIPTION.HideSync(D_PRESCRIPTION1)
        BunifuTransitionDMEDHISTORY.HideSync(S_MEDICALHISTORY1)
        BunifuTransitionPNLPRESCRIPTION.HideSync(PNLPRESCRIPTION)
        BunifuTransitionhome.HideSync(S_HOME1)
        PNLSTAFFMENU.Visible = False
        PNLDOCTORMENU.Visible = False
        Login1.PNLLOGASDOCTOR.Visible = False
        Login1.PNLLOGASSTAFF.Visible = False
        BunifuTransition1.HideSync(S_HOME1)
        BunifuTransition1.ShowSync(Login1)
    End Sub
End Class
