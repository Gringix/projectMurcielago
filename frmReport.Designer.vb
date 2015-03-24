<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Me.dgvDataBaseReport = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ntsmPunchMenuReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterNewPuchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPunchesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToPDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmVacationMenuPunch = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterNewVacationRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewVacationRequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApproveVacationRequestAdminOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUserNameReport = New System.Windows.Forms.Label()
        Me.txtUserReport = New System.Windows.Forms.TextBox()
        Me.btnGetUserReport = New System.Windows.Forms.Button()
        Me.cbxExportTo = New System.Windows.Forms.ComboBox()
        Me.btnExportReport = New System.Windows.Forms.Button()
        CType(Me.dgvDataBaseReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDataBaseReport
        '
        Me.dgvDataBaseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataBaseReport.Location = New System.Drawing.Point(12, 95)
        Me.dgvDataBaseReport.Name = "dgvDataBaseReport"
        Me.dgvDataBaseReport.Size = New System.Drawing.Size(681, 512)
        Me.dgvDataBaseReport.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ntsmPunchMenuReport, Me.ntsmVacationMenuPunch})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(705, 27)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ntsmPunchMenuReport
        '
        Me.ntsmPunchMenuReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterNewPuchToolStripMenuItem, Me.ViewPunchesToolStripMenuItem})
        Me.ntsmPunchMenuReport.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntsmPunchMenuReport.Name = "ntsmPunchMenuReport"
        Me.ntsmPunchMenuReport.Size = New System.Drawing.Size(108, 23)
        Me.ntsmPunchMenuReport.Text = "Punch Menu"
        '
        'EnterNewPuchToolStripMenuItem
        '
        Me.EnterNewPuchToolStripMenuItem.Name = "EnterNewPuchToolStripMenuItem"
        Me.EnterNewPuchToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.EnterNewPuchToolStripMenuItem.Text = "Enter New Punch"
        '
        'ViewPunchesToolStripMenuItem
        '
        Me.ViewPunchesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewReportToolStripMenuItem, Me.ExportToPDAToolStripMenuItem, Me.ExportToExcelToolStripMenuItem})
        Me.ViewPunchesToolStripMenuItem.Name = "ViewPunchesToolStripMenuItem"
        Me.ViewPunchesToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.ViewPunchesToolStripMenuItem.Text = "View Punches"
        '
        'ViewReportToolStripMenuItem
        '
        Me.ViewReportToolStripMenuItem.Name = "ViewReportToolStripMenuItem"
        Me.ViewReportToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.ViewReportToolStripMenuItem.Text = "View Report/Edit Punches"
        '
        'ExportToPDAToolStripMenuItem
        '
        Me.ExportToPDAToolStripMenuItem.Name = "ExportToPDAToolStripMenuItem"
        Me.ExportToPDAToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.ExportToPDAToolStripMenuItem.Text = "Export to PDA"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.ExportToExcelToolStripMenuItem.Text = "Export to Excel"
        '
        'ntsmVacationMenuPunch
        '
        Me.ntsmVacationMenuPunch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterNewVacationRequestToolStripMenuItem, Me.ViewVacationRequestsToolStripMenuItem, Me.ApproveVacationRequestAdminOnlyToolStripMenuItem})
        Me.ntsmVacationMenuPunch.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntsmVacationMenuPunch.Name = "ntsmVacationMenuPunch"
        Me.ntsmVacationMenuPunch.Size = New System.Drawing.Size(127, 23)
        Me.ntsmVacationMenuPunch.Text = "Vacation Menu"
        '
        'EnterNewVacationRequestToolStripMenuItem
        '
        Me.EnterNewVacationRequestToolStripMenuItem.Name = "EnterNewVacationRequestToolStripMenuItem"
        Me.EnterNewVacationRequestToolStripMenuItem.Size = New System.Drawing.Size(367, 24)
        Me.EnterNewVacationRequestToolStripMenuItem.Text = "Enter New Vacation Request"
        '
        'ViewVacationRequestsToolStripMenuItem
        '
        Me.ViewVacationRequestsToolStripMenuItem.Name = "ViewVacationRequestsToolStripMenuItem"
        Me.ViewVacationRequestsToolStripMenuItem.Size = New System.Drawing.Size(367, 24)
        Me.ViewVacationRequestsToolStripMenuItem.Text = "View Vacation Requests"
        '
        'ApproveVacationRequestAdminOnlyToolStripMenuItem
        '
        Me.ApproveVacationRequestAdminOnlyToolStripMenuItem.Name = "ApproveVacationRequestAdminOnlyToolStripMenuItem"
        Me.ApproveVacationRequestAdminOnlyToolStripMenuItem.Size = New System.Drawing.Size(367, 24)
        Me.ApproveVacationRequestAdminOnlyToolStripMenuItem.Text = "Approve Vacation Request (Admin Only)"
        '
        'lblUserNameReport
        '
        Me.lblUserNameReport.AutoSize = True
        Me.lblUserNameReport.Location = New System.Drawing.Point(12, 50)
        Me.lblUserNameReport.Name = "lblUserNameReport"
        Me.lblUserNameReport.Size = New System.Drawing.Size(237, 19)
        Me.lblUserNameReport.TabIndex = 6
        Me.lblUserNameReport.Text = "(Name of admin/user logged in):"
        '
        'txtUserReport
        '
        Me.txtUserReport.Location = New System.Drawing.Point(255, 42)
        Me.txtUserReport.Name = "txtUserReport"
        Me.txtUserReport.Size = New System.Drawing.Size(171, 27)
        Me.txtUserReport.TabIndex = 7
        Me.txtUserReport.Text = "-Input User Login-"
        '
        'btnGetUserReport
        '
        Me.btnGetUserReport.Location = New System.Drawing.Point(432, 41)
        Me.btnGetUserReport.Name = "btnGetUserReport"
        Me.btnGetUserReport.Size = New System.Drawing.Size(132, 27)
        Me.btnGetUserReport.TabIndex = 8
        Me.btnGetUserReport.Text = "Get User Report"
        Me.btnGetUserReport.UseVisualStyleBackColor = True
        '
        'cbxExportTo
        '
        Me.cbxExportTo.FormattingEnabled = True
        Me.cbxExportTo.Location = New System.Drawing.Point(195, 641)
        Me.cbxExportTo.Name = "cbxExportTo"
        Me.cbxExportTo.Size = New System.Drawing.Size(121, 27)
        Me.cbxExportTo.TabIndex = 9
        Me.cbxExportTo.Text = "Export to:"
        '
        'btnExportReport
        '
        Me.btnExportReport.Location = New System.Drawing.Point(342, 641)
        Me.btnExportReport.Name = "btnExportReport"
        Me.btnExportReport.Size = New System.Drawing.Size(84, 27)
        Me.btnExportReport.TabIndex = 10
        Me.btnExportReport.Text = "Export"
        Me.btnExportReport.UseVisualStyleBackColor = True
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 706)
        Me.Controls.Add(Me.btnExportReport)
        Me.Controls.Add(Me.cbxExportTo)
        Me.Controls.Add(Me.btnGetUserReport)
        Me.Controls.Add(Me.txtUserReport)
        Me.Controls.Add(Me.lblUserNameReport)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvDataBaseReport)
        Me.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReports"
        Me.Text = "Reports"
        CType(Me.dgvDataBaseReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDataBaseReport As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ntsmPunchMenuReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterNewPuchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPunchesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToPDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmVacationMenuPunch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterNewVacationRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewVacationRequestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApproveVacationRequestAdminOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUserNameReport As System.Windows.Forms.Label
    Friend WithEvents txtUserReport As System.Windows.Forms.TextBox
    Friend WithEvents btnGetUserReport As System.Windows.Forms.Button
    Friend WithEvents cbxExportTo As System.Windows.Forms.ComboBox
    Friend WithEvents btnExportReport As System.Windows.Forms.Button
End Class
