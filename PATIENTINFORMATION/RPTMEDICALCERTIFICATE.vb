Imports CrystalDecisions.CrystalReports.Engine

Public Class RPTMEDICALCERTIFICATE

    Private Sub RPTMEDICALCERTIFICATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Enabled = True
        CrystalReportViewer1.ReportSource = "C:\Users\BMedina011\Downloads\OHOHCARIE's FILES\THESIS, ASSIGNENT, ETC\PATIENTINFORMATION\PATIENTINFORMATION\MEDICALCERTIFICATE.rpt"
        CrystalReportViewer1.SelectionFormula = "{CERTIFICATE.PATIENT_ID} =" + Form1.D_MEDICALCERTIFICATE1.TXTPATIENTID1.Text.ToString
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Form1.D_MEDICALCERTIFICATE1.TXTPATIENTID1.Text = ""
        Form1.D_MEDICALCERTIFICATE1.TXTLASTNAME1.Text = ""
        Form1.D_MEDICALCERTIFICATE1.TXTFIRSTNAME1.Text = ""
        Form1.D_MEDICALCERTIFICATE1.TXTMIDDLENAME1.Text = ""
        Form1.D_MEDICALCERTIFICATE1.TXTADDRESS1.Text = ""
        Form1.D_MEDICALCERTIFICATE1.DTPREQUEST.Value = Date.Now
        Form1.D_MEDICALCERTIFICATE1.TXTATTENDINGPHYSICIAN.Text = ""
        Form1.D_MEDICALCERTIFICATE1.TXTPAYMENT.Text = ""
        Form1.D_MEDICALCERTIFICATE1.TXTDIAGNOSIS.Text = ""
        Form1.D_MEDICALCERTIFICATE1.TXTPATIENTID1.Enabled = False
        Form1.D_MEDICALCERTIFICATE1.TXTLASTNAME1.Enabled = False
        Form1.D_MEDICALCERTIFICATE1.TXTFIRSTNAME1.Enabled = False
        Form1.D_MEDICALCERTIFICATE1.TXTMIDDLENAME1.Enabled = False
        Form1.D_MEDICALCERTIFICATE1.TXTADDRESS1.Enabled = False
        Form1.D_MEDICALCERTIFICATE1.DTPREQUEST.Enabled = False
        Form1.D_MEDICALCERTIFICATE1.TXTATTENDINGPHYSICIAN.Enabled = False
        Form1.D_MEDICALCERTIFICATE1.TXTPAYMENT.Enabled = False
        Form1.D_MEDICALCERTIFICATE1.TXTDIAGNOSIS.Enabled = False
        Form1.D_MEDICALCERTIFICATE1.TXTSEARCH.Text = "SEARCH BY PATIENT ID"
        Me.Close()
    End Sub

    
End Class