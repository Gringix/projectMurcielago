<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectOption
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
        Me.btnEnterPunch = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnVacation = New System.Windows.Forms.Button()
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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEnterPunch
        '
        Me.btnEnterPunch.Location = New System.Drawing.Point(172, 91)
        Me.btnEnterPunch.Name = "btnEnterPunch"
        Me.btnEnterPunch.Size = New System.Drawing.Size(225, 89)
        Me.btnEnterPunch.TabIndex = 0
        Me.btnEnterPunch.Text = "Click here to enter a new punch"
        Me.btnEnterPunch.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(172, 186)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(225, 89)
        Me.btnReport.TabIndex = 1
        Me.btnReport.Text = "Click here to view punch report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnVacation
        '
        Me.btnVacation.Location = New System.Drawing.Point(172, 281)
        Me.btnVacation.Name = "btnVacation"
        Me.btnVacation.Size = New System.Drawing.Size(225, 89)
        Me.btnVacation.TabIndex = 2
        Me.btnVacation.Text = "Click here to enter vacation request"
        Me.btnVacation.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PunchFormToolStripMenuItem, Me.VacationMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 24)
        Me.MenuStrip1.TabIndex = 3
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
        Me.ViewReportToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ViewReportToolStripMenuItem.Text = "View Report"
        '
        'ExportToPDAToolStripMenuItem
        '
        Me.ExportToPDAToolStripMenuItem.Name = "ExportToPDAToolStripMenuItem"
        Me.ExportToPDAToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExportToPDAToolStripMenuItem.Text = "Export to PDA"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
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
        'frmSelectOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 580)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnVacation)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnEnterPunch)
        Me.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSelectOption"
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnterPunch As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnVacation As System.Windows.Forms.Button
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
End Class
