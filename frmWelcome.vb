Public Class frmWelcome
    Public verifiedUser As User = New User


    Private Sub permissions()
        Dim permissionType As Integer
        permissionType = Integer.Parse(verifiedUser.User_ID_Role)

        Select Case permissionType
            Case 3
                ntsmNewEntry.Enabled = True
                ntsmRequestVacations.Enabled = True
                ntsmViewHistory.Enabled = True
                ntsmCreateUser.Enabled = True
                ntsmGenerateReports.Enabled = True
                ntsmAssigments.Enabled = True
                ntsmangeVacation.Enabled = True
                ntsWorkCategory.Enabled = True
                ntsTimeRegistrationManagement.Visible = True


            Case 2
                'Admin can see Time Registration & Holiday Management          
                ntsmNewEntry.Visible = True
                ntsmRequestVacations.Visible = False
                ntsmViewHistory.Visible = False
                ntsmCreateUser.Visible = False
                ntsmGenerateReports.Visible = False
                ntsmAssigments.Visible = False
                ntsmangeVacation.Visible = True
                ntsWorkCategory.Visible = False
                ntsTimeRegistrationManagement.Visible = True

            Case 1
                'User can see Time Registrationbrb
                ntsmNewEntry.Enabled = True
                ntsmRequestVacations.Visible = False
                ntsmViewHistory.Visible = False
                ntsmCreateUser.Visible = False
                ntsmGenerateReports.Visible = False
                ntsmAssigments.Visible = False
                ntsmangeVacation.Visible = False
                ntsWorkCategory.Visible = False
                ntsTimeRegistrationManagement.Visible = False

        End Select

    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        verifiedUser = frmSignIn.tellUser()
        permissions()
        lblDaysForVacation.Text = verifiedUser.Available_Holidays()



    End Sub

    Private Sub btnWelcomeExit_Click(sender As Object, e As EventArgs) Handles btnWelcomeExit.Click
        Me.Close()
    End Sub

    
    Private Sub WorkCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ntsWorkCategory.Click
        Dim frmWorkCategory As frmWorkCategory
        frmWorkCategory = New frmWorkCategory
        Me.Hide()
        frmWorkCategory.Show()

    End Sub

    Private Sub ntsTimeRegistrationManagement_Click(sender As Object, e As EventArgs) Handles ntsTimeRegistrationManagement.Click
        Dim frmTimeRegistrationManagement As frmTimeRegistrationManagement = New frmTimeRegistrationManagement
        Me.Hide()
        frmTimeRegistrationManagement.Show()


    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim AnchoBorde As Integer = 5
        Dim ColorBorde As Color = Color.Red
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, ColorBorde,
        AnchoBorde, ButtonBorderStyle.Solid, ColorBorde, AnchoBorde,
        ButtonBorderStyle.Solid, ColorBorde, AnchoBorde, ButtonBorderStyle.Solid,
        ColorBorde, AnchoBorde, ButtonBorderStyle.Solid)
    End Sub

End Class