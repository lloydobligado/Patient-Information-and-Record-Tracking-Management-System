<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.BunifuTransitionADMIN = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PNLLOGASSTAFF = New System.Windows.Forms.Panel()
        Me.BTNMATA = New ns1.BunifuImageButton()
        Me.BunifuCustomLabel10 = New ns1.BunifuCustomLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton4 = New ns1.BunifuFlatButton()
        Me.BunifuMaterialSTAFFPASSWORD = New ns1.BunifuMaterialTextbox()
        Me.BunifuMaterialSTAFFUSERNAME = New ns1.BunifuMaterialTextbox()
        Me.PNLLOGASDOCTOR = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel8 = New ns1.BunifuCustomLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton3 = New ns1.BunifuFlatButton()
        Me.BunifuMaterialTextboxDOCPassword = New ns1.BunifuMaterialTextbox()
        Me.BunifuMaterialTextboxDOCUsername = New ns1.BunifuMaterialTextbox()
        Me.BunifuCustomLabel9 = New ns1.BunifuCustomLabel()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton2 = New ns1.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel5 = New ns1.BunifuCustomLabel()
        Me.BunifuTransitionSTAFF = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BTNNOMATA = New ns1.BunifuImageButton()
        Me.BunifuImageButton1 = New ns1.BunifuImageButton()
        Me.BunifuImageButton2 = New ns1.BunifuImageButton()
        Me.Panel1.SuspendLayout()
        Me.PNLLOGASSTAFF.SuspendLayout()
        CType(Me.BTNMATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLLOGASDOCTOR.SuspendLayout()
        CType(Me.BTNNOMATA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuTransitionADMIN
        '
        Me.BunifuTransitionADMIN.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind
        Me.BunifuTransitionADMIN.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0.0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0.0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0.0!
        Animation2.RotateLimit = 0.0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0.0!
        Animation2.TransparencyCoeff = 0.0!
        Me.BunifuTransitionADMIN.DefaultAnimation = Animation2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.PATIENTINFORMATION.My.Resources.Resources.TOP6
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.PNLLOGASSTAFF)
        Me.Panel1.Controls.Add(Me.PNLLOGASDOCTOR)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.BunifuTransitionSTAFF.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 523)
        Me.Panel1.TabIndex = 0
        '
        'PNLLOGASSTAFF
        '
        Me.PNLLOGASSTAFF.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PNLLOGASSTAFF.Controls.Add(Me.BTNNOMATA)
        Me.PNLLOGASSTAFF.Controls.Add(Me.BTNMATA)
        Me.PNLLOGASSTAFF.Controls.Add(Me.BunifuCustomLabel10)
        Me.PNLLOGASSTAFF.Controls.Add(Me.Label4)
        Me.PNLLOGASSTAFF.Controls.Add(Me.Label5)
        Me.PNLLOGASSTAFF.Controls.Add(Me.BunifuFlatButton4)
        Me.PNLLOGASSTAFF.Controls.Add(Me.BunifuMaterialSTAFFPASSWORD)
        Me.PNLLOGASSTAFF.Controls.Add(Me.BunifuMaterialSTAFFUSERNAME)
        Me.BunifuTransitionSTAFF.SetDecoration(Me.PNLLOGASSTAFF, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.PNLLOGASSTAFF, BunifuAnimatorNS.DecorationType.None)
        Me.PNLLOGASSTAFF.Location = New System.Drawing.Point(777, 273)
        Me.PNLLOGASSTAFF.Name = "PNLLOGASSTAFF"
        Me.PNLLOGASSTAFF.Size = New System.Drawing.Size(290, 247)
        Me.PNLLOGASSTAFF.TabIndex = 69
        Me.PNLLOGASSTAFF.Visible = False
        '
        'BTNMATA
        '
        Me.BTNMATA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BTNMATA, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.BTNMATA, BunifuAnimatorNS.DecorationType.None)
        Me.BTNMATA.Image = Global.PATIENTINFORMATION.My.Resources.Resources.PREVIEWBUTTON
        Me.BTNMATA.ImageActive = Nothing
        Me.BTNMATA.Location = New System.Drawing.Point(247, 141)
        Me.BTNMATA.Name = "BTNMATA"
        Me.BTNMATA.Size = New System.Drawing.Size(25, 25)
        Me.BTNMATA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTNMATA.TabIndex = 69
        Me.BTNMATA.TabStop = False
        Me.BTNMATA.Zoom = 10
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(261, 217)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(16, 19)
        Me.BunifuCustomLabel10.TabIndex = 68
        Me.BunifuCustomLabel10.Text = "<"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionADMIN.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionSTAFF.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(133, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "as Staff"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionADMIN.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionSTAFF.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 48)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "LOGIN"
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.Gold
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "SIGN IN"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gold
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = Nothing
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0.0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 50.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(83, 206)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.Gold
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(124, 34)
        Me.BunifuFlatButton4.TabIndex = 66
        Me.BunifuFlatButton4.Text = "SIGN IN"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuMaterialSTAFFPASSWORD
        '
        Me.BunifuMaterialSTAFFPASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuMaterialSTAFFPASSWORD, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuMaterialSTAFFPASSWORD, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMaterialSTAFFPASSWORD.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialSTAFFPASSWORD.ForeColor = System.Drawing.Color.White
        Me.BunifuMaterialSTAFFPASSWORD.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialSTAFFPASSWORD.HintText = ""
        Me.BunifuMaterialSTAFFPASSWORD.isPassword = False
        Me.BunifuMaterialSTAFFPASSWORD.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuMaterialSTAFFPASSWORD.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialSTAFFPASSWORD.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuMaterialSTAFFPASSWORD.LineThickness = 3
        Me.BunifuMaterialSTAFFPASSWORD.Location = New System.Drawing.Point(21, 129)
        Me.BunifuMaterialSTAFFPASSWORD.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BunifuMaterialSTAFFPASSWORD.Name = "BunifuMaterialSTAFFPASSWORD"
        Me.BunifuMaterialSTAFFPASSWORD.Size = New System.Drawing.Size(256, 46)
        Me.BunifuMaterialSTAFFPASSWORD.TabIndex = 64
        Me.BunifuMaterialSTAFFPASSWORD.Text = "Password"
        Me.BunifuMaterialSTAFFPASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialSTAFFUSERNAME
        '
        Me.BunifuMaterialSTAFFUSERNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuMaterialSTAFFUSERNAME, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuMaterialSTAFFUSERNAME, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMaterialSTAFFUSERNAME.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialSTAFFUSERNAME.ForeColor = System.Drawing.Color.White
        Me.BunifuMaterialSTAFFUSERNAME.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialSTAFFUSERNAME.HintText = ""
        Me.BunifuMaterialSTAFFUSERNAME.isPassword = False
        Me.BunifuMaterialSTAFFUSERNAME.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuMaterialSTAFFUSERNAME.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialSTAFFUSERNAME.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuMaterialSTAFFUSERNAME.LineThickness = 3
        Me.BunifuMaterialSTAFFUSERNAME.Location = New System.Drawing.Point(21, 75)
        Me.BunifuMaterialSTAFFUSERNAME.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BunifuMaterialSTAFFUSERNAME.Name = "BunifuMaterialSTAFFUSERNAME"
        Me.BunifuMaterialSTAFFUSERNAME.Size = New System.Drawing.Size(256, 46)
        Me.BunifuMaterialSTAFFUSERNAME.TabIndex = 63
        Me.BunifuMaterialSTAFFUSERNAME.Text = "Username"
        Me.BunifuMaterialSTAFFUSERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PNLLOGASDOCTOR
        '
        Me.PNLLOGASDOCTOR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PNLLOGASDOCTOR.Controls.Add(Me.BunifuImageButton1)
        Me.PNLLOGASDOCTOR.Controls.Add(Me.BunifuImageButton2)
        Me.PNLLOGASDOCTOR.Controls.Add(Me.BunifuCustomLabel8)
        Me.PNLLOGASDOCTOR.Controls.Add(Me.Label3)
        Me.PNLLOGASDOCTOR.Controls.Add(Me.Label2)
        Me.PNLLOGASDOCTOR.Controls.Add(Me.BunifuFlatButton3)
        Me.PNLLOGASDOCTOR.Controls.Add(Me.BunifuMaterialTextboxDOCPassword)
        Me.PNLLOGASDOCTOR.Controls.Add(Me.BunifuMaterialTextboxDOCUsername)
        Me.BunifuTransitionSTAFF.SetDecoration(Me.PNLLOGASDOCTOR, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.PNLLOGASDOCTOR, BunifuAnimatorNS.DecorationType.None)
        Me.PNLLOGASDOCTOR.Location = New System.Drawing.Point(777, 273)
        Me.PNLLOGASDOCTOR.Name = "PNLLOGASDOCTOR"
        Me.PNLLOGASDOCTOR.Size = New System.Drawing.Size(290, 247)
        Me.PNLLOGASDOCTOR.TabIndex = 66
        Me.PNLLOGASDOCTOR.Visible = False
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(261, 217)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(16, 19)
        Me.BunifuCustomLabel8.TabIndex = 68
        Me.BunifuCustomLabel8.Text = "<"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionADMIN.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionSTAFF.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(133, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "as Doctor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionADMIN.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionSTAFF.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 48)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "LOGIN"
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.Gold
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "SIGN IN"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gold
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Nothing
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0.0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 50.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(83, 206)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Gold
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(124, 34)
        Me.BunifuFlatButton3.TabIndex = 66
        Me.BunifuFlatButton3.Text = "SIGN IN"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuMaterialTextboxDOCPassword
        '
        Me.BunifuMaterialTextboxDOCPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuMaterialTextboxDOCPassword, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuMaterialTextboxDOCPassword, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMaterialTextboxDOCPassword.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextboxDOCPassword.ForeColor = System.Drawing.Color.White
        Me.BunifuMaterialTextboxDOCPassword.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextboxDOCPassword.HintText = ""
        Me.BunifuMaterialTextboxDOCPassword.isPassword = False
        Me.BunifuMaterialTextboxDOCPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuMaterialTextboxDOCPassword.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextboxDOCPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuMaterialTextboxDOCPassword.LineThickness = 3
        Me.BunifuMaterialTextboxDOCPassword.Location = New System.Drawing.Point(21, 129)
        Me.BunifuMaterialTextboxDOCPassword.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BunifuMaterialTextboxDOCPassword.Name = "BunifuMaterialTextboxDOCPassword"
        Me.BunifuMaterialTextboxDOCPassword.Size = New System.Drawing.Size(256, 46)
        Me.BunifuMaterialTextboxDOCPassword.TabIndex = 64
        Me.BunifuMaterialTextboxDOCPassword.Text = "Password"
        Me.BunifuMaterialTextboxDOCPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextboxDOCUsername
        '
        Me.BunifuMaterialTextboxDOCUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuMaterialTextboxDOCUsername, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuMaterialTextboxDOCUsername, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMaterialTextboxDOCUsername.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextboxDOCUsername.ForeColor = System.Drawing.Color.White
        Me.BunifuMaterialTextboxDOCUsername.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextboxDOCUsername.HintText = ""
        Me.BunifuMaterialTextboxDOCUsername.isPassword = False
        Me.BunifuMaterialTextboxDOCUsername.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuMaterialTextboxDOCUsername.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextboxDOCUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuMaterialTextboxDOCUsername.LineThickness = 3
        Me.BunifuMaterialTextboxDOCUsername.Location = New System.Drawing.Point(21, 75)
        Me.BunifuMaterialTextboxDOCUsername.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BunifuMaterialTextboxDOCUsername.Name = "BunifuMaterialTextboxDOCUsername"
        Me.BunifuMaterialTextboxDOCUsername.Size = New System.Drawing.Size(256, 46)
        Me.BunifuMaterialTextboxDOCUsername.TabIndex = 63
        Me.BunifuMaterialTextboxDOCUsername.Text = "Username"
        Me.BunifuMaterialTextboxDOCUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Bahnschrift SemiLight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(807, 395)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(237, 48)
        Me.BunifuCustomLabel9.TabIndex = 66
        Me.BunifuCustomLabel9.Text = "BY LOGIN ACCOUNT, YOU AGREE TO OUR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TERMS , DATA POLICY AND COOKIES " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "POLICY ."
        Me.BunifuCustomLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Gold
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "   DOCTOR"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gold
        Me.BunifuFlatButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.PATIENTINFORMATION.My.Resources.Resources.DOCTOR1
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(799, 346)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gold
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(124, 34)
        Me.BunifuFlatButton1.TabIndex = 62
        Me.BunifuFlatButton1.Text = "   DOCTOR"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.Gold
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "   STAFF"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gold
        Me.BunifuFlatButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Global.PATIENTINFORMATION.My.Resources.Resources.SECRETARY1
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
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(929, 346)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Gold
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(124, 34)
        Me.BunifuFlatButton2.TabIndex = 63
        Me.BunifuFlatButton2.Text = "   STAFF"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionADMIN.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionSTAFF.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(791, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 48)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "LOGIN"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Bahnschrift SemiLight", 10.0!)
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(14, 187)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(237, 102)
        Me.BunifuCustomLabel5.TabIndex = 8
        Me.BunifuCustomLabel5.Text = "For standing us by wearing black " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mask and black ribbons in hospitals" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "while you" & _
    " are on duty." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You show us there is always light at" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the end of the darkest tu" & _
    "nnel."
        '
        'BunifuTransitionSTAFF
        '
        Me.BunifuTransitionSTAFF.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.BunifuTransitionSTAFF.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 1.0!
        Me.BunifuTransitionSTAFF.DefaultAnimation = Animation1
        '
        'BTNNOMATA
        '
        Me.BTNNOMATA.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BTNNOMATA, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.BTNNOMATA, BunifuAnimatorNS.DecorationType.None)
        Me.BTNNOMATA.Image = Global.PATIENTINFORMATION.My.Resources.Resources.NOPREVIEWBUTTON
        Me.BTNNOMATA.ImageActive = Nothing
        Me.BTNNOMATA.Location = New System.Drawing.Point(247, 141)
        Me.BTNNOMATA.Name = "BTNNOMATA"
        Me.BTNNOMATA.Size = New System.Drawing.Size(25, 25)
        Me.BTNNOMATA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BTNNOMATA.TabIndex = 70
        Me.BTNNOMATA.TabStop = False
        Me.BTNNOMATA.Visible = False
        Me.BTNNOMATA.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = Global.PATIENTINFORMATION.My.Resources.Resources.NOPREVIEWBUTTON
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(251, 144)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(25, 25)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 72
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Visible = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuTransitionSTAFF.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionADMIN.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = Global.PATIENTINFORMATION.My.Resources.Resources.PREVIEWBUTTON
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(251, 144)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(25, 25)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 71
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.BunifuTransitionADMIN.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransitionSTAFF.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "LOGIN"
        Me.Size = New System.Drawing.Size(1084, 523)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PNLLOGASSTAFF.ResumeLayout(False)
        Me.PNLLOGASSTAFF.PerformLayout()
        CType(Me.BTNMATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLLOGASDOCTOR.ResumeLayout(False)
        Me.PNLLOGASDOCTOR.PerformLayout()
        CType(Me.BTNNOMATA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents BunifuCustomLabel5 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As ns1.BunifuFlatButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PNLLOGASDOCTOR As System.Windows.Forms.Panel
    Friend WithEvents BunifuTransitionADMIN As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BunifuFlatButton3 As ns1.BunifuFlatButton
    Friend WithEvents BunifuMaterialTextboxDOCPassword As ns1.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextboxDOCUsername As ns1.BunifuMaterialTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomLabel8 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As ns1.BunifuCustomLabel
    Friend WithEvents PNLLOGASSTAFF As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel10 As ns1.BunifuCustomLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BunifuFlatButton4 As ns1.BunifuFlatButton
    Friend WithEvents BunifuMaterialSTAFFPASSWORD As ns1.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialSTAFFUSERNAME As ns1.BunifuMaterialTextbox
    Friend WithEvents BunifuTransitionSTAFF As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BTNMATA As ns1.BunifuImageButton
    Friend WithEvents BTNNOMATA As ns1.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As ns1.BunifuImageButton

End Class
