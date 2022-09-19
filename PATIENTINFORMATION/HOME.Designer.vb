<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HOME
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PNLIKALAWANGSLIDE = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PNLIKATLONGSLIDE = New System.Windows.Forms.Panel()
        Me.PNLUNANGSLIDE = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.PNLIKALAWANGSLIDE)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(37, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(1026, 472)
        Me.Panel2.TabIndex = 7
        '
        'PNLIKALAWANGSLIDE
        '
        Me.PNLIKALAWANGSLIDE.BackgroundImage = Global.PATIENTINFORMATION.My.Resources.Resources.ikalawangslide
        Me.PNLIKALAWANGSLIDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PNLIKALAWANGSLIDE, BunifuAnimatorNS.DecorationType.None)
        Me.PNLIKALAWANGSLIDE.Location = New System.Drawing.Point(20, 203)
        Me.PNLIKALAWANGSLIDE.Name = "PNLIKALAWANGSLIDE"
        Me.PNLIKALAWANGSLIDE.Size = New System.Drawing.Size(469, 248)
        Me.PNLIKALAWANGSLIDE.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel4)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.PNLIKATLONGSLIDE)
        Me.Panel3.Controls.Add(Me.PNLUNANGSLIDE)
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel1)
        Me.BunifuTransition1.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1016, 462)
        Me.Panel3.TabIndex = 2
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.BackColor = System.Drawing.Color.Black
        Me.FlowLayoutPanel4.Controls.Add(Me.Panel7)
        Me.BunifuTransition1.SetDecoration(Me.FlowLayoutPanel4, BunifuAnimatorNS.DecorationType.None)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(490, 193)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Padding = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(483, 242)
        Me.FlowLayoutPanel4.TabIndex = 49
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.BunifuTransition1.SetDecoration(Me.Panel7, BunifuAnimatorNS.DecorationType.None)
        Me.Panel7.Location = New System.Drawing.Point(5, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(472, 234)
        Me.Panel7.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(434, 48)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Become the benchmark of comprehensive quality healthcare and effective " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "service " & _
    "that is capable of matching and surpassing the other health " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "industry leaders." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 24)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "OUR VISION STATEMENT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(432, 112)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 24)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "OUR MISSION STATEMENT"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PATIENTINFORMATION.My.Resources.Resources.AMCLOGO
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 178)
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'PNLIKATLONGSLIDE
        '
        Me.PNLIKATLONGSLIDE.BackgroundImage = Global.PATIENTINFORMATION.My.Resources.Resources.ikatlongslide
        Me.PNLIKATLONGSLIDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PNLIKATLONGSLIDE, BunifuAnimatorNS.DecorationType.None)
        Me.PNLIKATLONGSLIDE.Location = New System.Drawing.Point(15, 198)
        Me.PNLIKATLONGSLIDE.Name = "PNLIKATLONGSLIDE"
        Me.PNLIKATLONGSLIDE.Size = New System.Drawing.Size(469, 248)
        Me.PNLIKATLONGSLIDE.TabIndex = 4
        '
        'PNLUNANGSLIDE
        '
        Me.PNLUNANGSLIDE.BackgroundImage = Global.PATIENTINFORMATION.My.Resources.Resources.unangslide
        Me.PNLUNANGSLIDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PNLUNANGSLIDE, BunifuAnimatorNS.DecorationType.None)
        Me.PNLUNANGSLIDE.Location = New System.Drawing.Point(15, 198)
        Me.PNLUNANGSLIDE.Name = "PNLUNANGSLIDE"
        Me.PNLUNANGSLIDE.Size = New System.Drawing.Size(469, 248)
        Me.PNLUNANGSLIDE.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.BunifuTransition1.SetDecoration(Me.FlowLayoutPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(247, 8)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(726, 178)
        Me.FlowLayoutPanel1.TabIndex = 44
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.BunifuTransition1.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(719, 170)
        Me.Panel4.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(13, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(277, 29)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "ATOMS MEDICAL CLINIC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(680, 95)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.BunifuTransition1.Cursor = Nothing
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
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PATIENTINFORMATION.My.Resources.Resources.BACKGROUND01
        Me.Controls.Add(Me.Panel2)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "HOME"
        Me.Size = New System.Drawing.Size(1084, 523)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PNLIKALAWANGSLIDE As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PNLIKATLONGSLIDE As System.Windows.Forms.Panel
    Friend WithEvents PNLUNANGSLIDE As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
