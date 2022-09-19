<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D_PRESCRIPTION
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXTADDRESS1 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TXTAGE1 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.BunifuImageButton3 = New ns1.BunifuImageButton()
        Me.TXTSEARCH1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTTREATMENTNAME = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTDRUGNAME = New System.Windows.Forms.TextBox()
        Me.TXTPRESCRIPTIONNO = New System.Windows.Forms.TextBox()
        Me.TXTQTY = New System.Windows.Forms.TextBox()
        Me.TXTDETAILS = New System.Windows.Forms.TextBox()
        Me.TXTTIMING = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTMIDDLENAME1 = New System.Windows.Forms.TextBox()
        Me.TXTFIRSTNAME1 = New System.Windows.Forms.TextBox()
        Me.TXTLASTNAME1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BTNCANCEL = New ns1.BunifuFlatButton()
        Me.BTNSAVEPINFO = New ns1.BunifuFlatButton()
        Me.TXTPATIENTID1 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.RBTNFEMALE = New System.Windows.Forms.RadioButton()
        Me.RBTNMALE = New System.Windows.Forms.RadioButton()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLCLOCK = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel45.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(37, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(1026, 472)
        Me.Panel2.TabIndex = 296
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.TXTADDRESS1)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.TXTAGE1)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.BunifuImageButton3)
        Me.Panel1.Controls.Add(Me.TXTSEARCH1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TXTTREATMENTNAME)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.TXTDRUGNAME)
        Me.Panel1.Controls.Add(Me.TXTPRESCRIPTIONNO)
        Me.Panel1.Controls.Add(Me.TXTQTY)
        Me.Panel1.Controls.Add(Me.TXTDETAILS)
        Me.Panel1.Controls.Add(Me.TXTTIMING)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TXTMIDDLENAME1)
        Me.Panel1.Controls.Add(Me.TXTFIRSTNAME1)
        Me.Panel1.Controls.Add(Me.TXTLASTNAME1)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.BTNCANCEL)
        Me.Panel1.Controls.Add(Me.BTNSAVEPINFO)
        Me.Panel1.Controls.Add(Me.TXTPATIENTID1)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Panel45)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 462)
        Me.Panel1.TabIndex = 2
        '
        'TXTADDRESS1
        '
        Me.TXTADDRESS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTADDRESS1.Enabled = False
        Me.TXTADDRESS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTADDRESS1.ForeColor = System.Drawing.Color.Black
        Me.TXTADDRESS1.Location = New System.Drawing.Point(312, 240)
        Me.TXTADDRESS1.MaxLength = 50
        Me.TXTADDRESS1.Name = "TXTADDRESS1"
        Me.TXTADDRESS1.Size = New System.Drawing.Size(258, 26)
        Me.TXTADDRESS1.TabIndex = 315
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(309, 214)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(99, 24)
        Me.Label24.TabIndex = 314
        Me.Label24.Text = "Address :"
        '
        'TXTAGE1
        '
        Me.TXTAGE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTAGE1.Enabled = False
        Me.TXTAGE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTAGE1.ForeColor = System.Drawing.Color.Black
        Me.TXTAGE1.Location = New System.Drawing.Point(316, 170)
        Me.TXTAGE1.MaxLength = 6
        Me.TXTAGE1.Multiline = True
        Me.TXTAGE1.Name = "TXTAGE1"
        Me.TXTAGE1.Size = New System.Drawing.Size(256, 29)
        Me.TXTAGE1.TabIndex = 313
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(312, 144)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(60, 24)
        Me.Label28.TabIndex = 312
        Me.Label28.Text = "Age :"
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.SystemColors.Window
        Me.BunifuImageButton3.Image = Global.PATIENTINFORMATION.My.Resources.Resources.HANAPIN
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(984, 11)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(23, 21)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 311
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'TXTSEARCH1
        '
        Me.TXTSEARCH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTSEARCH1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH1.ForeColor = System.Drawing.Color.Black
        Me.TXTSEARCH1.Location = New System.Drawing.Point(785, 8)
        Me.TXTSEARCH1.MaxLength = 50
        Me.TXTSEARCH1.Name = "TXTSEARCH1"
        Me.TXTSEARCH1.Size = New System.Drawing.Size(225, 26)
        Me.TXTSEARCH1.TabIndex = 310
        Me.TXTSEARCH1.Text = "SEARCH BY PATIENT ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(311, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 24)
        Me.Label2.TabIndex = 309
        Me.Label2.Text = "Treatment Name :"
        '
        'TXTTREATMENTNAME
        '
        Me.TXTTREATMENTNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTTREATMENTNAME.Enabled = False
        Me.TXTTREATMENTNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTREATMENTNAME.ForeColor = System.Drawing.Color.Black
        Me.TXTTREATMENTNAME.Location = New System.Drawing.Point(315, 304)
        Me.TXTTREATMENTNAME.MaxLength = 50
        Me.TXTTREATMENTNAME.Multiline = True
        Me.TXTTREATMENTNAME.Name = "TXTTREATMENTNAME"
        Me.TXTTREATMENTNAME.Size = New System.Drawing.Size(255, 28)
        Me.TXTTREATMENTNAME.TabIndex = 308
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(584, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(365, 90)
        Me.Panel3.TabIndex = 307
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(15, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 23)
        Me.Label10.TabIndex = 292
        Me.Label10.Text = "PRESCRIPTION"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(16, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(334, 54)
        Me.Label11.TabIndex = 291
        Me.Label11.Text = "an instruction written by a medical practitioner that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "authorizes a patient to be" & _
    " provided a medicine or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "treatment."
        '
        'TXTDRUGNAME
        '
        Me.TXTDRUGNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTDRUGNAME.Enabled = False
        Me.TXTDRUGNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDRUGNAME.ForeColor = System.Drawing.Color.Black
        Me.TXTDRUGNAME.Location = New System.Drawing.Point(618, 175)
        Me.TXTDRUGNAME.MaxLength = 5077
        Me.TXTDRUGNAME.Name = "TXTDRUGNAME"
        Me.TXTDRUGNAME.Size = New System.Drawing.Size(256, 26)
        Me.TXTDRUGNAME.TabIndex = 306
        '
        'TXTPRESCRIPTIONNO
        '
        Me.TXTPRESCRIPTIONNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPRESCRIPTIONNO.Enabled = False
        Me.TXTPRESCRIPTIONNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRESCRIPTIONNO.ForeColor = System.Drawing.Color.Black
        Me.TXTPRESCRIPTIONNO.Location = New System.Drawing.Point(316, 376)
        Me.TXTPRESCRIPTIONNO.MaxLength = 50
        Me.TXTPRESCRIPTIONNO.Name = "TXTPRESCRIPTIONNO"
        Me.TXTPRESCRIPTIONNO.Size = New System.Drawing.Size(256, 26)
        Me.TXTPRESCRIPTIONNO.TabIndex = 305
        '
        'TXTQTY
        '
        Me.TXTQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTQTY.Enabled = False
        Me.TXTQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTQTY.ForeColor = System.Drawing.Color.Black
        Me.TXTQTY.Location = New System.Drawing.Point(618, 240)
        Me.TXTQTY.MaxLength = 675768
        Me.TXTQTY.Name = "TXTQTY"
        Me.TXTQTY.Size = New System.Drawing.Size(256, 26)
        Me.TXTQTY.TabIndex = 304
        '
        'TXTDETAILS
        '
        Me.TXTDETAILS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTDETAILS.Enabled = False
        Me.TXTDETAILS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDETAILS.ForeColor = System.Drawing.Color.Black
        Me.TXTDETAILS.Location = New System.Drawing.Point(619, 371)
        Me.TXTDETAILS.MaxLength = 7576
        Me.TXTDETAILS.Name = "TXTDETAILS"
        Me.TXTDETAILS.Size = New System.Drawing.Size(255, 26)
        Me.TXTDETAILS.TabIndex = 297
        '
        'TXTTIMING
        '
        Me.TXTTIMING.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTTIMING.Enabled = False
        Me.TXTTIMING.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTIMING.ForeColor = System.Drawing.Color.Black
        Me.TXTTIMING.Location = New System.Drawing.Point(618, 304)
        Me.TXTTIMING.MaxLength = 967979
        Me.TXTTIMING.Name = "TXTTIMING"
        Me.TXTTIMING.Size = New System.Drawing.Size(255, 26)
        Me.TXTTIMING.TabIndex = 298
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(614, 278)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 24)
        Me.Label25.TabIndex = 303
        Me.Label25.Text = "Timing :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(615, 345)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 24)
        Me.Label26.TabIndex = 302
        Me.Label26.Text = "Details :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(615, 146)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(117, 24)
        Me.Label27.TabIndex = 301
        Me.Label27.Text = "Drug Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(615, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 300
        Me.Label1.Text = "Quantity :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(311, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 24)
        Me.Label5.TabIndex = 299
        Me.Label5.Text = "Prescription Number :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(-39, -35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(396, 55)
        Me.Label8.TabIndex = 296
        Me.Label8.Text = "PRESCRIPTION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 24)
        Me.Label4.TabIndex = 266
        Me.Label4.Text = "Middle Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 24)
        Me.Label3.TabIndex = 265
        Me.Label3.Text = "First Name :"
        '
        'TXTMIDDLENAME1
        '
        Me.TXTMIDDLENAME1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTMIDDLENAME1.Enabled = False
        Me.TXTMIDDLENAME1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTMIDDLENAME1.ForeColor = System.Drawing.Color.Black
        Me.TXTMIDDLENAME1.Location = New System.Drawing.Point(15, 305)
        Me.TXTMIDDLENAME1.MaxLength = 50
        Me.TXTMIDDLENAME1.Name = "TXTMIDDLENAME1"
        Me.TXTMIDDLENAME1.Size = New System.Drawing.Size(258, 26)
        Me.TXTMIDDLENAME1.TabIndex = 264
        '
        'TXTFIRSTNAME1
        '
        Me.TXTFIRSTNAME1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTFIRSTNAME1.Enabled = False
        Me.TXTFIRSTNAME1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTFIRSTNAME1.ForeColor = System.Drawing.Color.Black
        Me.TXTFIRSTNAME1.Location = New System.Drawing.Point(15, 240)
        Me.TXTFIRSTNAME1.MaxLength = 50
        Me.TXTFIRSTNAME1.Name = "TXTFIRSTNAME1"
        Me.TXTFIRSTNAME1.Size = New System.Drawing.Size(258, 26)
        Me.TXTFIRSTNAME1.TabIndex = 263
        '
        'TXTLASTNAME1
        '
        Me.TXTLASTNAME1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTLASTNAME1.Enabled = False
        Me.TXTLASTNAME1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTLASTNAME1.ForeColor = System.Drawing.Color.Black
        Me.TXTLASTNAME1.Location = New System.Drawing.Point(15, 172)
        Me.TXTLASTNAME1.MaxLength = 50
        Me.TXTLASTNAME1.Name = "TXTLASTNAME1"
        Me.TXTLASTNAME1.Size = New System.Drawing.Size(258, 26)
        Me.TXTLASTNAME1.TabIndex = 259
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(11, 146)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(120, 24)
        Me.Label23.TabIndex = 255
        Me.Label23.Text = "Last Name :"
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNCANCEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCANCEL.BorderRadius = 0
        Me.BTNCANCEL.ButtonText = "CANCEL"
        Me.BTNCANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCANCEL.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNCANCEL.Iconcolor = System.Drawing.Color.Transparent
        Me.BTNCANCEL.Iconimage = Global.PATIENTINFORMATION.My.Resources.Resources.CANCELBUTTON
        Me.BTNCANCEL.Iconimage_right = Nothing
        Me.BTNCANCEL.Iconimage_right_Selected = Nothing
        Me.BTNCANCEL.Iconimage_Selected = Nothing
        Me.BTNCANCEL.IconMarginLeft = 0
        Me.BTNCANCEL.IconMarginRight = 0
        Me.BTNCANCEL.IconRightVisible = True
        Me.BTNCANCEL.IconRightZoom = 0.0R
        Me.BTNCANCEL.IconVisible = True
        Me.BTNCANCEL.IconZoom = 50.0R
        Me.BTNCANCEL.IsTab = False
        Me.BTNCANCEL.Location = New System.Drawing.Point(824, 412)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNCANCEL.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNCANCEL.OnHoverTextColor = System.Drawing.Color.Black
        Me.BTNCANCEL.selected = False
        Me.BTNCANCEL.Size = New System.Drawing.Size(147, 34)
        Me.BTNCANCEL.TabIndex = 254
        Me.BTNCANCEL.Text = "CANCEL"
        Me.BTNCANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNCANCEL.Textcolor = System.Drawing.Color.White
        Me.BTNCANCEL.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BTNSAVEPINFO
        '
        Me.BTNSAVEPINFO.Activecolor = System.Drawing.Color.Gold
        Me.BTNSAVEPINFO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNSAVEPINFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSAVEPINFO.BorderRadius = 0
        Me.BTNSAVEPINFO.ButtonText = "PREVIEW "
        Me.BTNSAVEPINFO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSAVEPINFO.DisabledColor = System.Drawing.Color.Gold
        Me.BTNSAVEPINFO.Iconcolor = System.Drawing.Color.Transparent
        Me.BTNSAVEPINFO.Iconimage = Global.PATIENTINFORMATION.My.Resources.Resources.PREVIEWBUTTON
        Me.BTNSAVEPINFO.Iconimage_right = Nothing
        Me.BTNSAVEPINFO.Iconimage_right_Selected = Nothing
        Me.BTNSAVEPINFO.Iconimage_Selected = Nothing
        Me.BTNSAVEPINFO.IconMarginLeft = 0
        Me.BTNSAVEPINFO.IconMarginRight = 0
        Me.BTNSAVEPINFO.IconRightVisible = True
        Me.BTNSAVEPINFO.IconRightZoom = 0.0R
        Me.BTNSAVEPINFO.IconVisible = True
        Me.BTNSAVEPINFO.IconZoom = 50.0R
        Me.BTNSAVEPINFO.IsTab = False
        Me.BTNSAVEPINFO.Location = New System.Drawing.Point(661, 412)
        Me.BTNSAVEPINFO.Name = "BTNSAVEPINFO"
        Me.BTNSAVEPINFO.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNSAVEPINFO.OnHovercolor = System.Drawing.Color.Gold
        Me.BTNSAVEPINFO.OnHoverTextColor = System.Drawing.Color.Black
        Me.BTNSAVEPINFO.selected = False
        Me.BTNSAVEPINFO.Size = New System.Drawing.Size(147, 34)
        Me.BTNSAVEPINFO.TabIndex = 253
        Me.BTNSAVEPINFO.Text = "PREVIEW "
        Me.BTNSAVEPINFO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNSAVEPINFO.Textcolor = System.Drawing.Color.White
        Me.BTNSAVEPINFO.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TXTPATIENTID1
        '
        Me.TXTPATIENTID1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPATIENTID1.Enabled = False
        Me.TXTPATIENTID1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPATIENTID1.ForeColor = System.Drawing.Color.Maroon
        Me.TXTPATIENTID1.Location = New System.Drawing.Point(15, 50)
        Me.TXTPATIENTID1.MaxLength = 10
        Me.TXTPATIENTID1.Name = "TXTPATIENTID1"
        Me.TXTPATIENTID1.Size = New System.Drawing.Size(530, 80)
        Me.TXTPATIENTID1.TabIndex = 244
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(11, 23)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(191, 24)
        Me.Label22.TabIndex = 239
        Me.Label22.Text = "Patient ID Number :"
        '
        'Panel45
        '
        Me.Panel45.BackColor = System.Drawing.Color.White
        Me.Panel45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel45.Controls.Add(Me.RBTNFEMALE)
        Me.Panel45.Controls.Add(Me.RBTNMALE)
        Me.Panel45.Location = New System.Drawing.Point(15, 374)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(258, 29)
        Me.Panel45.TabIndex = 238
        '
        'RBTNFEMALE
        '
        Me.RBTNFEMALE.AutoSize = True
        Me.RBTNFEMALE.BackColor = System.Drawing.Color.Transparent
        Me.RBTNFEMALE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBTNFEMALE.Enabled = False
        Me.RBTNFEMALE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTNFEMALE.ForeColor = System.Drawing.Color.Black
        Me.RBTNFEMALE.Location = New System.Drawing.Point(128, -1)
        Me.RBTNFEMALE.Name = "RBTNFEMALE"
        Me.RBTNFEMALE.Size = New System.Drawing.Size(92, 28)
        Me.RBTNFEMALE.TabIndex = 90
        Me.RBTNFEMALE.TabStop = True
        Me.RBTNFEMALE.Text = "Female"
        Me.RBTNFEMALE.UseVisualStyleBackColor = False
        '
        'RBTNMALE
        '
        Me.RBTNMALE.AutoSize = True
        Me.RBTNMALE.BackColor = System.Drawing.Color.Transparent
        Me.RBTNMALE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBTNMALE.Enabled = False
        Me.RBTNMALE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTNMALE.ForeColor = System.Drawing.Color.Black
        Me.RBTNMALE.Location = New System.Drawing.Point(37, -1)
        Me.RBTNMALE.Name = "RBTNMALE"
        Me.RBTNMALE.Size = New System.Drawing.Size(69, 28)
        Me.RBTNMALE.TabIndex = 89
        Me.RBTNMALE.TabStop = True
        Me.RBTNMALE.Text = "Male"
        Me.RBTNMALE.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(11, 348)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(92, 24)
        Me.Label29.TabIndex = 228
        Me.Label29.Text = "Gender :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(-34, -30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(396, 55)
        Me.Label9.TabIndex = 296
        Me.Label9.Text = "PRESCRIPTION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(396, 55)
        Me.Label7.TabIndex = 297
        Me.Label7.Text = "PRESCRIPTION"
        '
        'LBLCLOCK
        '
        Me.LBLCLOCK.AutoSize = True
        Me.LBLCLOCK.BackColor = System.Drawing.Color.Transparent
        Me.LBLCLOCK.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCLOCK.ForeColor = System.Drawing.Color.White
        Me.LBLCLOCK.Location = New System.Drawing.Point(964, 7)
        Me.LBLCLOCK.Name = "LBLCLOCK"
        Me.LBLCLOCK.Size = New System.Drawing.Size(112, 24)
        Me.LBLCLOCK.TabIndex = 305
        Me.LBLCLOCK.Text = "HH:MM TT"
        '
        'Timer1
        '
        '
        'D_PRESCRIPTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PATIENTINFORMATION.My.Resources.Resources.BACKGROUND01
        Me.Controls.Add(Me.LBLCLOCK)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "D_PRESCRIPTION"
        Me.Size = New System.Drawing.Size(1084, 523)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel45.ResumeLayout(False)
        Me.Panel45.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TXTDRUGNAME As System.Windows.Forms.TextBox
    Friend WithEvents TXTPRESCRIPTIONNO As System.Windows.Forms.TextBox
    Friend WithEvents TXTQTY As System.Windows.Forms.TextBox
    Friend WithEvents TXTDETAILS As System.Windows.Forms.TextBox
    Friend WithEvents TXTTIMING As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTMIDDLENAME1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTFIRSTNAME1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTLASTNAME1 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents BTNCANCEL As ns1.BunifuFlatButton
    Friend WithEvents BTNSAVEPINFO As ns1.BunifuFlatButton
    Friend WithEvents TXTPATIENTID1 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTTREATMENTNAME As System.Windows.Forms.TextBox
    Friend WithEvents BunifuImageButton3 As ns1.BunifuImageButton
    Friend WithEvents TXTSEARCH1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel45 As System.Windows.Forms.Panel
    Friend WithEvents RBTNFEMALE As System.Windows.Forms.RadioButton
    Friend WithEvents RBTNMALE As System.Windows.Forms.RadioButton
    Friend WithEvents TXTADDRESS1 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TXTAGE1 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents LBLCLOCK As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
