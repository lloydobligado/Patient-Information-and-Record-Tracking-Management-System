Public Class LOGIN

    '////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////// D O C T O R  S E C T I O N///////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        If BunifuMaterialTextboxDOCUsername.Text = "DOCTOR" Or BunifuMaterialTextboxDOCUsername.Text = "doctor" And BunifuMaterialTextboxDOCPassword.Text = "123" Then
            Form1.S_HOME1.Visible = True
            Form1.PNLDOCTORMENU.Visible = True
            Form1.Login1.Visible = False
            BunifuMaterialTextboxDOCUsername.Text = "Username"
            BunifuMaterialTextboxDOCPassword.Text = "Password"
            BunifuMaterialTextboxDOCPassword.isPassword = False
        Else
            MsgBox("INVALID USERNAME", MsgBoxStyle.Information, "INFORMATION")

        End If
    End Sub

    '///////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////// S TA F F  S E C T I O N ///////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        If BunifuMaterialSTAFFUSERNAME.Text = "STAFF" Or BunifuMaterialSTAFFUSERNAME.Text = "staff" And BunifuMaterialSTAFFPASSWORD.Text = "123" Then
            If Form1.Login1.Visible = True Then
                BunifuTransitionSTAFF.ShowSync(Form1.S_HOME1)
                Form1.PNLSTAFFMENU.Visible = True
                Form1.Login1.Visible = False
                BunifuMaterialSTAFFUSERNAME.Text = "Username"
                BunifuMaterialSTAFFPASSWORD.Text = "Password"
                BunifuMaterialSTAFFPASSWORD.isPassword = False
            End If
        Else
            MsgBox("INVALID USERNAME", MsgBoxStyle.Information, "INFORMATION")

        End If
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        If PNLLOGASDOCTOR.Visible = False Then
            BunifuTransitionADMIN.ShowSync(PNLLOGASDOCTOR)
        End If

    End Sub

    Private Sub BunifuCustomLabel8_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.Click
        BunifuTransitionADMIN.HideSync(PNLLOGASDOCTOR)
    End Sub

    Private Sub BunifuCustomLabel8_MouseHover(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.MouseHover
        BunifuCustomLabel8.BackColor = Color.Gold
        BunifuCustomLabel8.ForeColor = Color.Black
    End Sub

    Private Sub BunifuCustomLabel8_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.MouseLeave
        BunifuCustomLabel8.BackColor = Color.White
        BunifuCustomLabel8.ForeColor = Color.Black
    End Sub

    Private Sub BunifuMaterialSTAFFPASSWORD_MouseEnter(sender As Object, e As EventArgs) Handles BunifuMaterialSTAFFPASSWORD.MouseEnter
        Dim PASS5 As String = BunifuMaterialSTAFFPASSWORD.Text
        If PASS5.Trim().ToLower() = "password" Or PASS5.Trim() = "" Then
            BunifuMaterialSTAFFPASSWORD.Text = ""
            BunifuMaterialSTAFFPASSWORD.isPassword = True
        End If
    End Sub


    Private Sub BunifuMaterialSTAFFPASSWORD_MouseLeave(sender As Object, e As EventArgs) Handles BunifuMaterialSTAFFPASSWORD.MouseLeave
        Dim PASS5 As String = BunifuMaterialSTAFFPASSWORD.Text
        If PASS5.Trim().ToLower() = "Password" Or PASS5.Trim() = "" Then
            BunifuMaterialSTAFFPASSWORD.Text = "Password"
            BunifuMaterialSTAFFPASSWORD.isPassword = False
        End If
    End Sub

    Private Sub BunifuMaterialTextboxDOCPassword_MouseLeave(sender As Object, e As EventArgs) Handles BunifuMaterialTextboxDOCPassword.MouseLeave
        Dim PASS5 As String = BunifuMaterialTextboxDOCPassword.Text
        If PASS5.Trim().ToLower() = "Password" Or PASS5.Trim() = "" Then
            BunifuMaterialTextboxDOCPassword.Text = "Password"
            BunifuMaterialTextboxDOCPassword.isPassword = False
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        If PNLLOGASSTAFF.Visible = False Then
            BunifuTransitionADMIN.ShowSync(PNLLOGASSTAFF)
        End If
    End Sub

    Private Sub BunifuCustomLabel10_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel10.Click
        BunifuTransitionADMIN.HideSync(PNLLOGASSTAFF)
    End Sub

    Private Sub BunifuCustomLabel10_MouseHover(sender As Object, e As EventArgs) Handles BunifuCustomLabel10.MouseHover
        BunifuCustomLabel10.BackColor = Color.Gold
    End Sub

    Private Sub BunifuCustomLabel10_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel10.MouseLeave
        BunifuCustomLabel10.BackColor = Color.White
    End Sub


    Private Sub BunifuMaterialSTAFFUSERNAME_MouseEnter(sender As Object, e As EventArgs) Handles BunifuMaterialSTAFFUSERNAME.MouseEnter
        If BunifuMaterialSTAFFUSERNAME.Text = "Username" Then
            BunifuMaterialSTAFFUSERNAME.Text = ""
        End If
    End Sub

    Private Sub BunifuMaterialSTAFFUSERNAME_MouseLeave(sender As Object, e As EventArgs) Handles BunifuMaterialSTAFFUSERNAME.MouseLeave
        If BunifuMaterialSTAFFUSERNAME.Text = "" Then
            BunifuMaterialSTAFFUSERNAME.Text = "Username"
        End If
    End Sub

    Private Sub BunifuMaterialTextboxDOCUsername_MouseEnter(sender As Object, e As EventArgs) Handles BunifuMaterialTextboxDOCUsername.MouseEnter
        If BunifuMaterialTextboxDOCUsername.Text = "Username" Then
            BunifuMaterialTextboxDOCUsername.Text = ""
        End If
    End Sub

    Private Sub BunifuMaterialTextboxDOCUsername_MouseLeave(sender As Object, e As EventArgs) Handles BunifuMaterialTextboxDOCUsername.MouseLeave
        If BunifuMaterialTextboxDOCUsername.Text = "" Then
            BunifuMaterialTextboxDOCUsername.Text = "Username"
        End If
    End Sub

    Private Sub BunifuMaterialTextboxDOCPassword_MouseEnter(sender As Object, e As EventArgs) Handles BunifuMaterialTextboxDOCPassword.MouseEnter
        Dim PASS5 As String = BunifuMaterialTextboxDOCPassword.Text
        If PASS5.Trim().ToLower() = "password" Or PASS5.Trim() = "" Then
            BunifuMaterialTextboxDOCPassword.Text = ""
            BunifuMaterialTextboxDOCPassword.isPassword = True
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BTNMATA.Click
        If BTNMATA.Visible = True Then
            BTNMATA.Visible = False
            BTNNOMATA.Visible = True
            BunifuMaterialSTAFFPASSWORD.isPassword = False
        End If
    End Sub

    Private Sub BTNNOMATA_Click(sender As Object, e As EventArgs) Handles BTNNOMATA.Click
        If BTNNOMATA.Visible = True Then
            BTNNOMATA.Visible = False
            BTNMATA.Visible = True
            BunifuMaterialSTAFFPASSWORD.isPassword = True
        End If
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        If BunifuImageButton2.Visible = True Then
            BunifuImageButton2.Visible = False
            BunifuImageButton1.Visible = True
            BunifuMaterialTextboxDOCPassword.isPassword = False
        End If
    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If BunifuImageButton1.Visible = True Then
            BunifuImageButton1.Visible = False
            BunifuImageButton2.Visible = True
            BunifuMaterialTextboxDOCPassword.isPassword = True
        End If
    End Sub
End Class
