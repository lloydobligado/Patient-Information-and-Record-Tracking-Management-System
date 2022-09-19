Public Class RPTPRESCRIPTION

    Private Sub RPTPRESCRIPTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CrystalReportViewer1.Enabled = True
        '  CrystalReportViewer1.ReportSource = "C:\Users\BMedina011\Downloads\OHOHCARIE's FILES\THESIS, ASSIGNENT, ETC\PATIENTINFORMATION\PATIENTINFORMATION\MEDICALCERTIFICATE.rpt"
        ' CrystalReportViewer1.SelectionFormula = "{CERTIFICATE.PATIENT_ID} =" + Form1.D_MEDICALCERTIFICATE1.TXTPATIENTID1.Text.ToString
        '  CrystalReportViewer1.Refresh()
        ' CrystalReportViewer1.RefreshReport()
        Dim MALEPATIENT As New PRESCRIPTION
        MALEPATIENT.Load(Application.StartupPath & "\Reports\prescription.rpt")
        CrystalReportViewer1.ReportSource = MALEPATIENT
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Form1.D_PRESCRIPTION1.TXTPATIENTID1.Text = ""
        Form1.D_PRESCRIPTION1.TXTLASTNAME1.Text = ""
        Form1.D_PRESCRIPTION1.TXTFIRSTNAME1.Text = ""
        Form1.D_PRESCRIPTION1.TXTMIDDLENAME1.Text = ""
        Form1.D_PRESCRIPTION1.RBTNMALE.Checked = False
        Form1.D_PRESCRIPTION1.RBTNFEMALE.Checked = False
        Form1.D_PRESCRIPTION1.TXTAGE1.Text = ""
        Form1.D_PRESCRIPTION1.TXTADDRESS1.Text = ""
        Form1.D_PRESCRIPTION1.TXTTREATMENTNAME.Text = ""
        Form1.D_PRESCRIPTION1.TXTPRESCRIPTIONNO.Text = ""
        Form1.D_PRESCRIPTION1.TXTDRUGNAME.Text = ""
        Form1.D_PRESCRIPTION1.TXTQTY.Text = ""
        Form1.D_PRESCRIPTION1.TXTTIMING.Text = ""
        Form1.D_PRESCRIPTION1.TXTDETAILS.Text = ""
        Form1.D_PRESCRIPTION1.TXTPRESCRIPTIONNO.Enabled = False
        Form1.D_PRESCRIPTION1.TXTDRUGNAME.Enabled = False
        Form1.D_PRESCRIPTION1.TXTQTY.Enabled = False
        Form1.D_PRESCRIPTION1.TXTTIMING.Enabled = False
        Form1.D_PRESCRIPTION1.TXTDETAILS.Enabled = False
        Form1.D_PRESCRIPTION1.TXTSEARCH1.Text = "SEARCH BY PATIENT ID"
        Me.Close()
    End Sub

End Class