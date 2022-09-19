<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_MEDICALCERTIFICATE
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
        Me.LBLCLOCK = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DTPREQUEST = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTPAYMENT = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTMIDDLENAME1 = New System.Windows.Forms.TextBox()
        Me.TXTFIRSTNAME1 = New System.Windows.Forms.TextBox()
        Me.TXTLASTNAME1 = New System.Windows.Forms.TextBox()
        Me.TXTATTENDINGPHYSICIAN = New System.Windows.Forms.TextBox()
        Me.TXTADDRESS1 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TXTPATIENTID1 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuImageButton1 = New ns1.BunifuImageButton()
        Me.BTNCANCEL = New ns1.BunifuFlatButton()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.BTNSAVEPINFO = New ns1.BunifuFlatButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.LBLCLOCK.TabIndex = 300
        Me.LBLCLOCK.Text = "HH:MM TT"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(37, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(595, 472)
        Me.Panel2.TabIndex = 299
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.DTPREQUEST)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TXTPAYMENT)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TXTMIDDLENAME1)
        Me.Panel1.Controls.Add(Me.TXTFIRSTNAME1)
        Me.Panel1.Controls.Add(Me.TXTLASTNAME1)
        Me.Panel1.Controls.Add(Me.TXTATTENDINGPHYSICIAN)
        Me.Panel1.Controls.Add(Me.TXTADDRESS1)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.TXTPATIENTID1)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 462)
        Me.Panel1.TabIndex = 2
        '
        'DTPREQUEST
        '
        Me.DTPREQUEST.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DTPREQUEST.CustomFormat = "MM/dd/yyyy"
        Me.DTPREQUEST.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.DTPREQUEST.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPREQUEST.Location = New System.Drawing.Point(313, 172)
        Me.DTPREQUEST.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTPREQUEST.Name = "DTPREQUEST"
        Me.DTPREQUEST.Size = New System.Drawing.Size(258, 29)
        Me.DTPREQUEST.TabIndex = 304
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(309, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 303
        Me.Label1.Text = "Payment :"
        '
        'TXTPAYMENT
        '
        Me.TXTPAYMENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPAYMENT.Enabled = False
        Me.TXTPAYMENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.TXTPAYMENT.ForeColor = System.Drawing.Color.Black
        Me.TXTPAYMENT.Location = New System.Drawing.Point(315, 305)
        Me.TXTPAYMENT.MaxLength = 50
        Me.TXTPAYMENT.Name = "TXTPAYMENT"
        Me.TXTPAYMENT.Size = New System.Drawing.Size(258, 44)
        Me.TXTPAYMENT.TabIndex = 302
        Me.TXTPAYMENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(311, 146)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(170, 24)
        Me.Label27.TabIndex = 300
        Me.Label27.Text = "Date of Request :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(-39, -35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(534, 55)
        Me.Label8.TabIndex = 299
        Me.Label8.Text = "REQUESTER'S FORM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 279)
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
        'TXTATTENDINGPHYSICIAN
        '
        Me.TXTATTENDINGPHYSICIAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTATTENDINGPHYSICIAN.Enabled = False
        Me.TXTATTENDINGPHYSICIAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTATTENDINGPHYSICIAN.ForeColor = System.Drawing.Color.Black
        Me.TXTATTENDINGPHYSICIAN.Location = New System.Drawing.Point(315, 240)
        Me.TXTATTENDINGPHYSICIAN.MaxLength = 934343
        Me.TXTATTENDINGPHYSICIAN.Name = "TXTATTENDINGPHYSICIAN"
        Me.TXTATTENDINGPHYSICIAN.Size = New System.Drawing.Size(258, 26)
        Me.TXTATTENDINGPHYSICIAN.TabIndex = 261
        '
        'TXTADDRESS1
        '
        Me.TXTADDRESS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTADDRESS1.Enabled = False
        Me.TXTADDRESS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTADDRESS1.ForeColor = System.Drawing.Color.Black
        Me.TXTADDRESS1.Location = New System.Drawing.Point(15, 372)
        Me.TXTADDRESS1.MaxLength = 50
        Me.TXTADDRESS1.Name = "TXTADDRESS1"
        Me.TXTADDRESS1.Size = New System.Drawing.Size(258, 26)
        Me.TXTADDRESS1.TabIndex = 262
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(11, 346)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(99, 24)
        Me.Label24.TabIndex = 258
        Me.Label24.Text = "Address :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(311, 214)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(206, 24)
        Me.Label25.TabIndex = 257
        Me.Label25.Text = "Attending Physician :"
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
        'TXTPATIENTID1
        '
        Me.TXTPATIENTID1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPATIENTID1.Enabled = False
        Me.TXTPATIENTID1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPATIENTID1.ForeColor = System.Drawing.Color.Maroon
        Me.TXTPATIENTID1.Location = New System.Drawing.Point(15, 50)
        Me.TXTPATIENTID1.MaxLength = 10
        Me.TXTPATIENTID1.Name = "TXTPATIENTID1"
        Me.TXTPATIENTID1.Size = New System.Drawing.Size(558, 80)
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(-34, -30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(534, 55)
        Me.Label9.TabIndex = 299
        Me.Label9.Text = "REQUESTER'S FORM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(534, 55)
        Me.Label7.TabIndex = 301
        Me.Label7.Text = "REQUESTER'S FORM"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(638, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(420, 472)
        Me.Panel3.TabIndex = 302
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Controls.Add(Me.RadioButton2)
        Me.Panel4.Controls.Add(Me.RadioButton1)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.BunifuImageButton1)
        Me.Panel4.Controls.Add(Me.BTNCANCEL)
        Me.Panel4.Controls.Add(Me.TXTSEARCH)
        Me.Panel4.Controls.Add(Me.BTNSAVEPINFO)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(5, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(410, 462)
        Me.Panel4.TabIndex = 2
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(38, 366)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 316
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(38, 312)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 315
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(54, 361)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 20)
        Me.Label13.TabIndex = 312
        Me.Label13.Text = "Others"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(53, 298)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 40)
        Me.Label12.TabIndex = 311
        Me.Label12.Text = "Students" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Senior Citizens"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(217, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 30)
        Me.Label6.TabIndex = 310
        Me.Label6.Text = "  P100.00 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+ P15.00 doc stamp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(217, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 30)
        Me.Label5.TabIndex = 309
        Me.Label5.Text = "  P50.00 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+ P15.00 doc stamp" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Location = New System.Drawing.Point(19, 44)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(365, 90)
        Me.Panel5.TabIndex = 308
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(15, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 23)
        Me.Label10.TabIndex = 292
        Me.Label10.Text = "MEDICAL CERTIFICATE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(16, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(321, 54)
        Me.Label11.TabIndex = 291
        Me.Label11.Text = "A written statement from a physician or another " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "medically qualified health care" & _
    " provider which " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "attests to the result of a medical examination."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 110)
        Me.Label2.TabIndex = 304
        Me.Label2.Text = "RATES " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AND FEES"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.SystemColors.Window
        Me.BunifuImageButton1.Image = Global.PATIENTINFORMATION.My.Resources.Resources.HANAPIN
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(381, 9)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(23, 21)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 273
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
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
        Me.BTNCANCEL.Location = New System.Drawing.Point(273, 410)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNCANCEL.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNCANCEL.OnHoverTextColor = System.Drawing.Color.Black
        Me.BTNCANCEL.selected = False
        Me.BTNCANCEL.Size = New System.Drawing.Size(124, 34)
        Me.BTNCANCEL.TabIndex = 254
        Me.BTNCANCEL.Text = "CANCEL"
        Me.BTNCANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNCANCEL.Textcolor = System.Drawing.Color.White
        Me.BTNCANCEL.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTSEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH.ForeColor = System.Drawing.Color.Black
        Me.TXTSEARCH.Location = New System.Drawing.Point(181, 6)
        Me.TXTSEARCH.MaxLength = 50
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(225, 26)
        Me.TXTSEARCH.TabIndex = 272
        Me.TXTSEARCH.Text = "SEARCH BY PATIENT ID"
        '
        'BTNSAVEPINFO
        '
        Me.BTNSAVEPINFO.Activecolor = System.Drawing.Color.Gold
        Me.BTNSAVEPINFO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNSAVEPINFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSAVEPINFO.BorderRadius = 0
        Me.BTNSAVEPINFO.ButtonText = "REQUEST"
        Me.BTNSAVEPINFO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSAVEPINFO.DisabledColor = System.Drawing.Color.Gold
        Me.BTNSAVEPINFO.Iconcolor = System.Drawing.Color.Transparent
        Me.BTNSAVEPINFO.Iconimage = Global.PATIENTINFORMATION.My.Resources.Resources.DOCUMENTSREQUESTSICON
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
        Me.BTNSAVEPINFO.Location = New System.Drawing.Point(107, 410)
        Me.BTNSAVEPINFO.Name = "BTNSAVEPINFO"
        Me.BTNSAVEPINFO.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNSAVEPINFO.OnHovercolor = System.Drawing.Color.Gold
        Me.BTNSAVEPINFO.OnHoverTextColor = System.Drawing.Color.Black
        Me.BTNSAVEPINFO.selected = False
        Me.BTNSAVEPINFO.Size = New System.Drawing.Size(157, 34)
        Me.BTNSAVEPINFO.TabIndex = 253
        Me.BTNSAVEPINFO.Text = "REQUEST"
        Me.BTNSAVEPINFO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNSAVEPINFO.Textcolor = System.Drawing.Color.White
        Me.BTNSAVEPINFO.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Timer1
        '
        '
        'S_MEDICALCERTIFICATE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PATIENTINFORMATION.My.Resources.Resources.BACKGROUND01
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LBLCLOCK)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "S_MEDICALCERTIFICATE"
        Me.Size = New System.Drawing.Size(1084, 523)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLCLOCK As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTMIDDLENAME1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTFIRSTNAME1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTLASTNAME1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTATTENDINGPHYSICIAN As System.Windows.Forms.TextBox
    Friend WithEvents TXTADDRESS1 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TXTPATIENTID1 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTPAYMENT As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents BTNCANCEL As ns1.BunifuFlatButton
    Friend WithEvents TXTSEARCH As System.Windows.Forms.TextBox
    Friend WithEvents BTNSAVEPINFO As ns1.BunifuFlatButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents DTPREQUEST As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
