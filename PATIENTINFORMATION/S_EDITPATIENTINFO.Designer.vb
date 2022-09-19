<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_EDITPATIENTINFO
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton2 = New ns1.BunifuFlatButton()
        Me.BunifuImageButton3 = New ns1.BunifuImageButton()
        Me.BTNCANCEL = New ns1.BunifuFlatButton()
        Me.TXTSEARCH1 = New System.Windows.Forms.TextBox()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PBPHOTO = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTMIDDLENAME1 = New System.Windows.Forms.TextBox()
        Me.TXTFIRSTNAME1 = New System.Windows.Forms.TextBox()
        Me.TXTLASTNAME1 = New System.Windows.Forms.TextBox()
        Me.TXTEMAIL1 = New System.Windows.Forms.TextBox()
        Me.TXTPHONE1 = New System.Windows.Forms.TextBox()
        Me.TXTADDRESS1 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BTNSAVEPINFO = New ns1.BunifuFlatButton()
        Me.TXTPATIENTID1 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.RBTNFEMALE = New System.Windows.Forms.RadioButton()
        Me.RBTNMALE = New System.Windows.Forms.RadioButton()
        Me.CMBMD1 = New System.Windows.Forms.ComboBox()
        Me.TXTREASON1 = New System.Windows.Forms.TextBox()
        Me.DTPBIRTHDAY1 = New System.Windows.Forms.DateTimePicker()
        Me.TXTAGE1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBLCLOCK = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PBPHOTO, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel1.Controls.Add(Me.BunifuImageButton3)
        Me.Panel1.Controls.Add(Me.BTNCANCEL)
        Me.Panel1.Controls.Add(Me.TXTSEARCH1)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TXTMIDDLENAME1)
        Me.Panel1.Controls.Add(Me.TXTFIRSTNAME1)
        Me.Panel1.Controls.Add(Me.TXTLASTNAME1)
        Me.Panel1.Controls.Add(Me.TXTEMAIL1)
        Me.Panel1.Controls.Add(Me.TXTPHONE1)
        Me.Panel1.Controls.Add(Me.TXTADDRESS1)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.BTNSAVEPINFO)
        Me.Panel1.Controls.Add(Me.TXTPATIENTID1)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Panel45)
        Me.Panel1.Controls.Add(Me.CMBMD1)
        Me.Panel1.Controls.Add(Me.TXTREASON1)
        Me.Panel1.Controls.Add(Me.DTPBIRTHDAY1)
        Me.Panel1.Controls.Add(Me.TXTAGE1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 462)
        Me.Panel1.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(-39, -35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(720, 55)
        Me.Label8.TabIndex = 299
        Me.Label8.Text = "EDIT PATIENT INFORMATION"
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.Gold
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "DELETE"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gold
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Global.PATIENTINFORMATION.My.Resources.Resources.DELETEBUTTON
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0.0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 50.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(738, 412)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Gold
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(127, 34)
        Me.BunifuFlatButton2.TabIndex = 274
        Me.BunifuFlatButton2.Text = "DELETE"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.SystemColors.Window
        Me.BunifuImageButton3.Image = Global.PATIENTINFORMATION.My.Resources.Resources.HANAPIN
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(985, 11)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(23, 21)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 273
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
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
        Me.BTNCANCEL.Location = New System.Drawing.Point(871, 412)
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
        'TXTSEARCH1
        '
        Me.TXTSEARCH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTSEARCH1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH1.ForeColor = System.Drawing.Color.Black
        Me.TXTSEARCH1.Location = New System.Drawing.Point(785, 8)
        Me.TXTSEARCH1.MaxLength = 50
        Me.TXTSEARCH1.Name = "TXTSEARCH1"
        Me.TXTSEARCH1.Size = New System.Drawing.Size(225, 26)
        Me.TXTSEARCH1.TabIndex = 272
        Me.TXTSEARCH1.Text = "SEARCH BY PATIENT ID"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Gold
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "CHOOSE YOUR PHOTO"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gold
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.PATIENTINFORMATION.My.Resources.Resources.PHOTOBUTTON
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(785, 65)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gold
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(210, 34)
        Me.BunifuFlatButton1.TabIndex = 271
        Me.BunifuFlatButton1.Text = "CHOOSE YOUR PHOTO"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(791, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 54)
        Me.Label5.TabIndex = 270
        Me.Label5.Text = "Adding a photo can help " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to your Doctor/Staff identify " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "record easily."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(790, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 24)
        Me.Label1.TabIndex = 269
        Me.Label1.Text = "( OPTIONAL )"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.PBPHOTO)
        Me.Panel3.Location = New System.Drawing.Point(607, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel3.Size = New System.Drawing.Size(150, 150)
        Me.Panel3.TabIndex = 268
        '
        'PBPHOTO
        '
        Me.PBPHOTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBPHOTO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBPHOTO.Enabled = False
        Me.PBPHOTO.Image = Global.PATIENTINFORMATION.My.Resources.Resources.giphy
        Me.PBPHOTO.Location = New System.Drawing.Point(2, 2)
        Me.PBPHOTO.Name = "PBPHOTO"
        Me.PBPHOTO.Size = New System.Drawing.Size(146, 146)
        Me.PBPHOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPHOTO.TabIndex = 267
        Me.PBPHOTO.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 279)
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
        Me.Label3.Location = New System.Drawing.Point(21, 214)
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
        'TXTEMAIL1
        '
        Me.TXTEMAIL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTEMAIL1.Enabled = False
        Me.TXTEMAIL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTEMAIL1.ForeColor = System.Drawing.Color.Black
        Me.TXTEMAIL1.Location = New System.Drawing.Point(607, 372)
        Me.TXTEMAIL1.MaxLength = 50
        Me.TXTEMAIL1.Name = "TXTEMAIL1"
        Me.TXTEMAIL1.Size = New System.Drawing.Size(258, 26)
        Me.TXTEMAIL1.TabIndex = 260
        '
        'TXTPHONE1
        '
        Me.TXTPHONE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPHONE1.Enabled = False
        Me.TXTPHONE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTPHONE1.ForeColor = System.Drawing.Color.Black
        Me.TXTPHONE1.Location = New System.Drawing.Point(607, 308)
        Me.TXTPHONE1.MaxLength = 9
        Me.TXTPHONE1.Name = "TXTPHONE1"
        Me.TXTPHONE1.Size = New System.Drawing.Size(258, 26)
        Me.TXTPHONE1.TabIndex = 261
        '
        'TXTADDRESS1
        '
        Me.TXTADDRESS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTADDRESS1.Enabled = False
        Me.TXTADDRESS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTADDRESS1.ForeColor = System.Drawing.Color.Black
        Me.TXTADDRESS1.Location = New System.Drawing.Point(607, 240)
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
        Me.Label24.Location = New System.Drawing.Point(613, 214)
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
        Me.Label25.Location = New System.Drawing.Point(603, 282)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(166, 24)
        Me.Label25.TabIndex = 257
        Me.Label25.Text = "Mobile Number :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(611, 346)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(157, 24)
        Me.Label26.TabIndex = 256
        Me.Label26.Text = "Email Address :"
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
        'BTNSAVEPINFO
        '
        Me.BTNSAVEPINFO.Activecolor = System.Drawing.Color.Gold
        Me.BTNSAVEPINFO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNSAVEPINFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSAVEPINFO.BorderRadius = 0
        Me.BTNSAVEPINFO.ButtonText = "UPDATE"
        Me.BTNSAVEPINFO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSAVEPINFO.DisabledColor = System.Drawing.Color.Gold
        Me.BTNSAVEPINFO.Iconcolor = System.Drawing.Color.Transparent
        Me.BTNSAVEPINFO.Iconimage = Global.PATIENTINFORMATION.My.Resources.Resources.MEDICALHISTORYICON
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
        Me.BTNSAVEPINFO.Location = New System.Drawing.Point(592, 412)
        Me.BTNSAVEPINFO.Name = "BTNSAVEPINFO"
        Me.BTNSAVEPINFO.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNSAVEPINFO.OnHovercolor = System.Drawing.Color.Gold
        Me.BTNSAVEPINFO.OnHoverTextColor = System.Drawing.Color.Black
        Me.BTNSAVEPINFO.selected = False
        Me.BTNSAVEPINFO.Size = New System.Drawing.Size(140, 34)
        Me.BTNSAVEPINFO.TabIndex = 253
        Me.BTNSAVEPINFO.Text = "UPDATE"
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
        Me.Panel45.Location = New System.Drawing.Point(315, 172)
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
        'CMBMD1
        '
        Me.CMBMD1.BackColor = System.Drawing.Color.White
        Me.CMBMD1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBMD1.Enabled = False
        Me.CMBMD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CMBMD1.ForeColor = System.Drawing.Color.Black
        Me.CMBMD1.FormattingEnabled = True
        Me.CMBMD1.Items.AddRange(New Object() {"PEDIATRICIANS", "GERIATRICIAN", "INTERNIST", "DENTIST"})
        Me.CMBMD1.Location = New System.Drawing.Point(16, 372)
        Me.CMBMD1.Name = "CMBMD1"
        Me.CMBMD1.Size = New System.Drawing.Size(258, 28)
        Me.CMBMD1.TabIndex = 236
        '
        'TXTREASON1
        '
        Me.TXTREASON1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTREASON1.Enabled = False
        Me.TXTREASON1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTREASON1.ForeColor = System.Drawing.Color.Black
        Me.TXTREASON1.Location = New System.Drawing.Point(316, 372)
        Me.TXTREASON1.MaxLength = 50
        Me.TXTREASON1.Multiline = True
        Me.TXTREASON1.Name = "TXTREASON1"
        Me.TXTREASON1.Size = New System.Drawing.Size(257, 70)
        Me.TXTREASON1.TabIndex = 235
        '
        'DTPBIRTHDAY1
        '
        Me.DTPBIRTHDAY1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DTPBIRTHDAY1.CustomFormat = "MM/dd/yyyy"
        Me.DTPBIRTHDAY1.Enabled = False
        Me.DTPBIRTHDAY1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.DTPBIRTHDAY1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPBIRTHDAY1.Location = New System.Drawing.Point(315, 305)
        Me.DTPBIRTHDAY1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTPBIRTHDAY1.Name = "DTPBIRTHDAY1"
        Me.DTPBIRTHDAY1.Size = New System.Drawing.Size(258, 29)
        Me.DTPBIRTHDAY1.TabIndex = 234
        '
        'TXTAGE1
        '
        Me.TXTAGE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTAGE1.Enabled = False
        Me.TXTAGE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTAGE1.ForeColor = System.Drawing.Color.Black
        Me.TXTAGE1.Location = New System.Drawing.Point(315, 240)
        Me.TXTAGE1.MaxLength = 6
        Me.TXTAGE1.Multiline = True
        Me.TXTAGE1.Name = "TXTAGE1"
        Me.TXTAGE1.Size = New System.Drawing.Size(256, 29)
        Me.TXTAGE1.TabIndex = 233
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(321, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 24)
        Me.Label6.TabIndex = 232
        Me.Label6.Text = "Reason :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 24)
        Me.Label2.TabIndex = 231
        Me.Label2.Text = "MD :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(311, 279)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(97, 24)
        Me.Label27.TabIndex = 230
        Me.Label27.Text = "Birthday :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(321, 214)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(60, 24)
        Me.Label28.TabIndex = 229
        Me.Label28.Text = "Age :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(319, 146)
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
        Me.Label9.Size = New System.Drawing.Size(720, 55)
        Me.Label9.TabIndex = 299
        Me.Label9.Text = "EDIT PATIENT INFORMATION"
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
        Me.LBLCLOCK.TabIndex = 274
        Me.LBLCLOCK.Text = "HH:MM TT"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(720, 55)
        Me.Label7.TabIndex = 298
        Me.Label7.Text = "EDIT PATIENT INFORMATION"
        '
        'S_EDITPATIENTINFO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PATIENTINFORMATION.My.Resources.Resources.BACKGROUND01
        Me.Controls.Add(Me.LBLCLOCK)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "S_EDITPATIENTINFO"
        Me.Size = New System.Drawing.Size(1084, 523)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PBPHOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel45.ResumeLayout(False)
        Me.Panel45.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PBPHOTO As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTMIDDLENAME1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTFIRSTNAME1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTLASTNAME1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTEMAIL1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTPHONE1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTADDRESS1 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents BTNCANCEL As ns1.BunifuFlatButton
    Friend WithEvents BTNSAVEPINFO As ns1.BunifuFlatButton
    Friend WithEvents TXTPATIENTID1 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel45 As System.Windows.Forms.Panel
    Friend WithEvents RBTNFEMALE As System.Windows.Forms.RadioButton
    Friend WithEvents RBTNMALE As System.Windows.Forms.RadioButton
    Friend WithEvents CMBMD1 As System.Windows.Forms.ComboBox
    Friend WithEvents TXTREASON1 As System.Windows.Forms.TextBox
    Friend WithEvents DTPBIRTHDAY1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTAGE1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents BunifuImageButton3 As ns1.BunifuImageButton
    Friend WithEvents TXTSEARCH1 As System.Windows.Forms.TextBox
    Friend WithEvents LBLCLOCK As System.Windows.Forms.Label
    Friend WithEvents BunifuFlatButton2 As ns1.BunifuFlatButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
