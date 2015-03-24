<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.btnFindUser = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnExport = New System.Windows.Forms.Button()
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PunchFormToolStripMenuItem, Me.VacationMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(705, 24)
        Me.MenuStrip1.TabIndex = 5
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
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(12, 50)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(237, 19)
        Me.lblUserName.TabIndex = 6
        Me.lblUserName.Text = "(Name of admin/user logged in):"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(255, 42)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(171, 27)
        Me.txtUser.TabIndex = 7
        Me.txtUser.Text = "-Input User Login-"
        '
        'btnFindUser
        '
        Me.btnFindUser.Location = New System.Drawing.Point(432, 41)
        Me.btnFindUser.Name = "btnFindUser"
        Me.btnFindUser.Size = New System.Drawing.Size(132, 27)
        Me.btnFindUser.TabIndex = 8
        Me.btnFindUser.Text = "Get User Report"
        Me.btnFindUser.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(195, 641)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.Text = "Export to:"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(342, 641)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(84, 27)
        Me.btnExport.TabIndex = 10
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 706)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnFindUser)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvDataBaseReport)
        Me.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReport"
        Me.Text = "frmReport"
        CType(Me.dgvDataBaseReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDataBaseReport As System.Windows.Forms.DataGridView
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
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents btnFindUser As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
End Class
