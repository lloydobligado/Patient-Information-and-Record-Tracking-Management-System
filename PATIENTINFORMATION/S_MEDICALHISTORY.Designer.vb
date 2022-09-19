<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_MEDICALHISTORY
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewerMEDICALHISTORY = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BunifuImageButton3 = New ns1.BunifuImageButton()
        Me.TXTSEARCH1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLCLOCK = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(37, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(1026, 472)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CrystalReportViewerMEDICALHISTORY)
        Me.Panel1.Controls.Add(Me.BunifuImageButton3)
        Me.Panel1.Controls.Add(Me.TXTSEARCH1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 462)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-39, -35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(479, 55)
        Me.Label1.TabIndex = 297
        Me.Label1.Text = "MEDICAL HISTORY"
        '
        'CrystalReportViewerMEDICALHISTORY
        '
        Me.CrystalReportViewerMEDICALHISTORY.ActiveViewIndex = -1
        Me.CrystalReportViewerMEDICALHISTORY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerMEDICALHISTORY.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerMEDICALHISTORY.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewerMEDICALHISTORY.Location = New System.Drawing.Point(0, 41)
        Me.CrystalReportViewerMEDICALHISTORY.Name = "CrystalReportViewerMEDICALHISTORY"
        Me.CrystalReportViewerMEDICALHISTORY.Size = New System.Drawing.Size(1016, 421)
        Me.CrystalReportViewerMEDICALHISTORY.TabIndex = 290
        Me.CrystalReportViewerMEDICALHISTORY.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-34, -30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(479, 55)
        Me.Label2.TabIndex = 298
        Me.Label2.Text = "MEDICAL HISTORY"
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
        Me.LBLCLOCK.TabIndex = 276
        Me.LBLCLOCK.Text = "HH:MM TT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(479, 55)
        Me.Label7.TabIndex = 297
        Me.Label7.Text = "MEDICAL HISTORY"
        '
        'Timer1
        '
        '
        'S_MEDICALHISTORY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PATIENTINFORMATION.My.Resources.Resources.BACKGROUND01
        Me.Controls.Add(Me.LBLCLOCK)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "S_MEDICALHISTORY"
        Me.Size = New System.Drawing.Size(1084, 523)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LBLCLOCK As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton3 As ns1.BunifuImageButton
    Friend WithEvents TXTSEARCH1 As System.Windows.Forms.TextBox
    Friend WithEvents CrystalReportViewerMEDICALHISTORY As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
