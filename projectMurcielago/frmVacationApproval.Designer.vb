<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVacationApproval
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFindUser = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PunchFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterNewPuchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPunchesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToPDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacationMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterNewVacationRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewVacationRequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApproveVacationRequestAdminOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtRequest1 = New System.Windows.Forms.TextBox()
        Me.txtVacationLength1 = New System.Windows.Forms.TextBox()
        Me.rbtAccept1 = New System.Windows.Forms.RadioButton()
        Me.rbtDeny1 = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(381, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Accept or Deny:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 19)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "Half or Full Day Off:"
        '
        'btnFindUser
        '
        Me.btnFindUser.Location = New System.Drawing.Point(419, 88)
        Me.btnFindUser.Name = "btnFindUser"
        Me.btnFindUser.Size = New System.Drawing.Size(95, 38)
        Me.btnFindUser.TabIndex = 159
        Me.btnFindUser.Text = "Find"
        Me.btnFindUser.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(208, 90)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(171, 27)
        Me.txtUser.TabIndex = 158
        Me.txtUser.Text = "-Input User Login-"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(72, 98)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(81, 19)
        Me.lblUserName.TabIndex = 157
        Me.lblUserName.Text = "Find User:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 19)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Dates Off Requested:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PunchFormToolStripMenuItem, Me.VacationMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(587, 24)
        Me.MenuStrip1.TabIndex = 155
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PunchFormToolStripMenuItem
        '
        Me.PunchFormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterNewPuchToolStripMenuItem, Me.ViewPunchesToolStripMenuItem})
        Me.PunchFormToolStripMenuItem.Name = "PunchFormToolStripMenuItem"
        Me.PunchFormToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.PunchFormToolStripMenuItem.Text = "Punch Menu"
        '
        'EnterNewPuchToolStripMenuItem
        '
        Me.EnterNewPuchToolStripMenuItem.Name = "EnterNewPuchToolStripMenuItem"
        Me.EnterNewPuchToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EnterNewPuchToolStripMenuItem.Text = "Enter New Punch"
        '
        'ViewPunchesToolStripMenuItem
        '
        Me.ViewPunchesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewReportToolStripMenuItem, Me.ExportToPDAToolStripMenuItem, Me.ExportToExcelToolStripMenuItem})
        Me.ViewPunchesToolStripMenuItem.Name = "ViewPunchesToolStripMenuItem"
        Me.ViewPunchesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewPunchesToolStripMenuItem.Text = "View Punches"
        '
        'ViewReportToolStripMenuItem
        '
        Me.ViewReportToolStripMenuItem.Name = "ViewReportToolStripMenuItem"
        Me.ViewReportToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ViewReportToolStripMenuItem.Text = "View Report/Edit Punches"
        '
        'ExportToPDAToolStripMenuItem
        '
        Me.ExportToPDAToolStripMenuItem.Name = "ExportToPDAToolStripMenuItem"
        Me.ExportToPDAToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ExportToPDAToolStripMenuItem.Text = "Export to PDA"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export to Excel"
        '
        'VacationMenuToolStripMenuItem
        '
        Me.VacationMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterNewVacationRequestToolStripMenuItem, Me.ViewVacationRequestsToolStripMenuItem, Me.ApproveVacationRequestAdminOnlyToolStripMenuItem})
        Me.VacationMenuToolStripMenuItem.Name = "VacationMenuToolStripMenuItem"
        Me.VacationMenuToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.VacationMenuToolStripMenuItem.Text = "Vacation Menu"
        '
        'EnterNewVacationRequestToolStripMenuItem
        '
        Me.EnterNewVacationRequestToolStripMenuItem.Name = "EnterNewVacationRequestToolStripMenuItem"
        Me.EnterNewVacationRequestToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.EnterNewVacationRequestToolStripMenuItem.Text = "Enter New Vacation Request"
        '
        'ViewVacationRequestsToolStripMenuItem
        '
        Me.ViewVacationRequestsToolStripMenuItem.Name = "ViewVacationRequestsToolStripMenuItem"
        Me.ViewVacationRequestsToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.ViewVacationRequestsToolStripMenuItem.Text = "View Vacation Requests"
        '
        'ApproveVacationRequestAdminOnlyToolStripMenuItem
        '
        Me.ApproveVacationRequestAdminOnlyToolStripMenuItem.Name = "ApproveVacationRequestAdminOnlyToolStripMenuItem"
        Me.ApproveVacationRequestAdminOnlyToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.ApproveVacationRequestAdminOnlyToolStripMenuItem.Text = "Approve Vacation Request (Admin Only)"
        '
        'txtRequest1
        '
        Me.txtRequest1.Location = New System.Drawing.Point(16, 189)
        Me.txtRequest1.Name = "txtRequest1"
        Me.txtRequest1.ReadOnly = True
        Me.txtRequest1.Size = New System.Drawing.Size(100, 27)
        Me.txtRequest1.TabIndex = 160
        '
        'txtVacationLength1
        '
        Me.txtVacationLength1.Location = New System.Drawing.Point(208, 189)
        Me.txtVacationLength1.Name = "txtVacationLength1"
        Me.txtVacationLength1.ReadOnly = True
        Me.txtVacationLength1.Size = New System.Drawing.Size(100, 27)
        Me.txtVacationLength1.TabIndex = 176
        '
        'rbtAccept1
        '
        Me.rbtAccept1.AutoSize = True
        Me.rbtAccept1.Location = New System.Drawing.Point(385, 190)
        Me.rbtAccept1.Name = "rbtAccept1"
        Me.rbtAccept1.Size = New System.Drawing.Size(75, 23)
        Me.rbtAccept1.TabIndex = 192
        Me.rbtAccept1.TabStop = True
        Me.rbtAccept1.Text = "Accept"
        Me.rbtAccept1.UseVisualStyleBackColor = True
        '
        'rbtDeny1
        '
        Me.rbtDeny1.AutoSize = True
        Me.rbtDeny1.Location = New System.Drawing.Point(466, 190)
        Me.rbtDeny1.Name = "rbtDeny1"
        Me.rbtDeny1.Size = New System.Drawing.Size(64, 23)
        Me.rbtDeny1.TabIndex = 193
        Me.rbtDeny1.TabStop = True
        Me.rbtDeny1.Text = "Deny"
        Me.rbtDeny1.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(174, 280)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(97, 46)
        Me.btnSubmit.TabIndex = 222
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmVacationApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 375)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.rbtDeny1)
        Me.Controls.Add(Me.rbtAccept1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVacationLength1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRequest1)
        Me.Controls.Add(Me.btnFindUser)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmVacationApproval"
        Me.Text = "Vacation Approval"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFindUser As System.Windows.Forms.Button
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PunchFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterNewPuchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPunchesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToPDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VacationMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterNewVacationRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewVacationRequestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApproveVacationRequestAdminOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtRequest1 As System.Windows.Forms.TextBox
    Friend WithEvents txtVacationLength1 As System.Windows.Forms.TextBox
    Friend WithEvents rbtAccept1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDeny1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
End Class
