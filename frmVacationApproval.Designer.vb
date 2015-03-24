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
        Me.lblAceptVacation = New System.Windows.Forms.Label()
        Me.lblHalfFullDay = New System.Windows.Forms.Label()
        Me.btnFindUser = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblFindUser = New System.Windows.Forms.Label()
        Me.lblDatesVacation = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ntsmPunchMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmVacation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmPunchView = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmViewReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmExportPdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmExportExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmVacationMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmNewVacation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmViewVacation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmApproveVacation = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtRequest1 = New System.Windows.Forms.TextBox()
        Me.txtVacationLength1 = New System.Windows.Forms.TextBox()
        Me.rbtAccept1 = New System.Windows.Forms.RadioButton()
        Me.rbtDeny1 = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAceptVacation
        '
        Me.lblAceptVacation.AutoSize = True
        Me.lblAceptVacation.Location = New System.Drawing.Point(381, 167)
        Me.lblAceptVacation.Name = "lblAceptVacation"
        Me.lblAceptVacation.Size = New System.Drawing.Size(120, 19)
        Me.lblAceptVacation.TabIndex = 191
        Me.lblAceptVacation.Text = "Accept or Deny:"
        '
        'lblHalfFullDay
        '
        Me.lblHalfFullDay.AutoSize = True
        Me.lblHalfFullDay.Location = New System.Drawing.Point(204, 167)
        Me.lblHalfFullDay.Name = "lblHalfFullDay"
        Me.lblHalfFullDay.Size = New System.Drawing.Size(153, 19)
        Me.lblHalfFullDay.TabIndex = 175
        Me.lblHalfFullDay.Text = "Half or Full Day Off:"
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
        'lblFindUser
        '
        Me.lblFindUser.AutoSize = True
        Me.lblFindUser.Location = New System.Drawing.Point(72, 98)
        Me.lblFindUser.Name = "lblFindUser"
        Me.lblFindUser.Size = New System.Drawing.Size(81, 19)
        Me.lblFindUser.TabIndex = 157
        Me.lblFindUser.Text = "Find User:"
        '
        'lblDatesVacation
        '
        Me.lblDatesVacation.AutoSize = True
        Me.lblDatesVacation.Location = New System.Drawing.Point(13, 167)
        Me.lblDatesVacation.Name = "lblDatesVacation"
        Me.lblDatesVacation.Size = New System.Drawing.Size(157, 19)
        Me.lblDatesVacation.TabIndex = 156
        Me.lblDatesVacation.Text = "Dates Off Requested:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ntsmPunchMenu, Me.ntsmVacationMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(587, 27)
        Me.MenuStrip1.TabIndex = 155
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ntsmPunchMenu
        '
        Me.ntsmPunchMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ntsmVacation, Me.ntsmPunchView})
        Me.ntsmPunchMenu.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntsmPunchMenu.Name = "ntsmPunchMenu"
        Me.ntsmPunchMenu.Size = New System.Drawing.Size(108, 23)
        Me.ntsmPunchMenu.Text = "Punch Menu"
        '
        'ntsmVacation
        '
        Me.ntsmVacation.Name = "ntsmVacation"
        Me.ntsmVacation.Size = New System.Drawing.Size(198, 24)
        Me.ntsmVacation.Text = "Enter New Punch"
        '
        'ntsmPunchView
        '
        Me.ntsmPunchView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ntsmViewReport, Me.ntsmExportPdf, Me.ntsmExportExcel})
        Me.ntsmPunchView.Name = "ntsmPunchView"
        Me.ntsmPunchView.Size = New System.Drawing.Size(198, 24)
        Me.ntsmPunchView.Text = "View Punches"
        '
        'ntsmViewReport
        '
        Me.ntsmViewReport.Name = "ntsmViewReport"
        Me.ntsmViewReport.Size = New System.Drawing.Size(262, 24)
        Me.ntsmViewReport.Text = "View Report/Edit Punches"
        '
        'ntsmExportPdf
        '
        Me.ntsmExportPdf.Name = "ntsmExportPdf"
        Me.ntsmExportPdf.Size = New System.Drawing.Size(262, 24)
        Me.ntsmExportPdf.Text = "Export to PDA"
        '
        'ntsmExportExcel
        '
        Me.ntsmExportExcel.Name = "ntsmExportExcel"
        Me.ntsmExportExcel.Size = New System.Drawing.Size(262, 24)
        Me.ntsmExportExcel.Text = "Export to Excel"
        '
        'ntsmVacationMenu
        '
        Me.ntsmVacationMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ntsmNewVacation, Me.ntsmViewVacation, Me.ntsmApproveVacation})
        Me.ntsmVacationMenu.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntsmVacationMenu.Name = "ntsmVacationMenu"
        Me.ntsmVacationMenu.Size = New System.Drawing.Size(127, 23)
        Me.ntsmVacationMenu.Text = "Vacation Menu"
        '
        'ntsmNewVacation
        '
        Me.ntsmNewVacation.Name = "ntsmNewVacation"
        Me.ntsmNewVacation.Size = New System.Drawing.Size(367, 24)
        Me.ntsmNewVacation.Text = "Enter New Vacation Request"
        '
        'ntsmViewVacation
        '
        Me.ntsmViewVacation.Name = "ntsmViewVacation"
        Me.ntsmViewVacation.Size = New System.Drawing.Size(367, 24)
        Me.ntsmViewVacation.Text = "View Vacation Requests"
        '
        'ntsmApproveVacation
        '
        Me.ntsmApproveVacation.Name = "ntsmApproveVacation"
        Me.ntsmApproveVacation.Size = New System.Drawing.Size(367, 24)
        Me.ntsmApproveVacation.Text = "Approve Vacation Request (Admin Only)"
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
        Me.rbtDeny1.Location = New System.Drawing.Point(511, 189)
        Me.rbtDeny1.Name = "rbtDeny1"
        Me.rbtDeny1.Size = New System.Drawing.Size(64, 23)
        Me.rbtDeny1.TabIndex = 193
        Me.rbtDeny1.TabStop = True
        Me.rbtDeny1.Text = "Deny"
        Me.rbtDeny1.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(419, 295)
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
        Me.Controls.Add(Me.lblAceptVacation)
        Me.Controls.Add(Me.txtVacationLength1)
        Me.Controls.Add(Me.lblHalfFullDay)
        Me.Controls.Add(Me.txtRequest1)
        Me.Controls.Add(Me.btnFindUser)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblFindUser)
        Me.Controls.Add(Me.lblDatesVacation)
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
    Friend WithEvents lblAceptVacation As System.Windows.Forms.Label
    Friend WithEvents lblHalfFullDay As System.Windows.Forms.Label
    Friend WithEvents btnFindUser As System.Windows.Forms.Button
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblFindUser As System.Windows.Forms.Label
    Friend WithEvents lblDatesVacation As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ntsmPunchMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmVacation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmPunchView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmViewReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmExportPdf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmExportExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmVacationMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmNewVacation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmViewVacation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmApproveVacation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtRequest1 As System.Windows.Forms.TextBox
    Friend WithEvents txtVacationLength1 As System.Windows.Forms.TextBox
    Friend WithEvents rbtAccept1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDeny1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
End Class
