<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVacation
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lblAvailableVacationDays = New System.Windows.Forms.Label()
        Me.txtAvailableVacationDays = New System.Windows.Forms.TextBox()
        Me.lblDaysOff = New System.Windows.Forms.Label()
        Me.mclDaysOffSelection = New System.Windows.Forms.MonthCalendar()
        Me.rbtHalfDay = New System.Windows.Forms.RadioButton()
        Me.rbtFullDayOff = New System.Windows.Forms.RadioButton()
        Me.lblVacationType = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRequestVacation = New System.Windows.Forms.Button()
        Me.cbxSelectionDay = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(577, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lblAvailableVacationDays
        '
        Me.lblAvailableVacationDays.AutoSize = True
        Me.lblAvailableVacationDays.Location = New System.Drawing.Point(235, 66)
        Me.lblAvailableVacationDays.Name = "lblAvailableVacationDays"
        Me.lblAvailableVacationDays.Size = New System.Drawing.Size(179, 19)
        Me.lblAvailableVacationDays.TabIndex = 7
        Me.lblAvailableVacationDays.Text = "Available Vacation Days"
        '
        'txtAvailableVacationDays
        '
        Me.txtAvailableVacationDays.Location = New System.Drawing.Point(441, 64)
        Me.txtAvailableVacationDays.Name = "txtAvailableVacationDays"
        Me.txtAvailableVacationDays.ReadOnly = True
        Me.txtAvailableVacationDays.Size = New System.Drawing.Size(49, 27)
        Me.txtAvailableVacationDays.TabIndex = 8
        '
        'lblDaysOff
        '
        Me.lblDaysOff.AutoSize = True
        Me.lblDaysOff.Location = New System.Drawing.Point(26, 169)
        Me.lblDaysOff.Name = "lblDaysOff"
        Me.lblDaysOff.Size = New System.Drawing.Size(66, 19)
        Me.lblDaysOff.TabIndex = 9
        Me.lblDaysOff.Text = "Days off"
        '
        'mclDaysOffSelection
        '
        Me.mclDaysOffSelection.Location = New System.Drawing.Point(104, 169)
        Me.mclDaysOffSelection.Name = "mclDaysOffSelection"
        Me.mclDaysOffSelection.TabIndex = 10
        '
        'rbtHalfDay
        '
        Me.rbtHalfDay.AutoSize = True
        Me.rbtHalfDay.Location = New System.Drawing.Point(352, 201)
        Me.rbtHalfDay.Name = "rbtHalfDay"
        Me.rbtHalfDay.Size = New System.Drawing.Size(117, 23)
        Me.rbtHalfDay.TabIndex = 11
        Me.rbtHalfDay.TabStop = True
        Me.rbtHalfDay.Text = "Half Day Off"
        Me.rbtHalfDay.UseVisualStyleBackColor = True
        '
        'rbtFullDayOff
        '
        Me.rbtFullDayOff.AutoSize = True
        Me.rbtFullDayOff.Location = New System.Drawing.Point(352, 231)
        Me.rbtFullDayOff.Name = "rbtFullDayOff"
        Me.rbtFullDayOff.Size = New System.Drawing.Size(114, 23)
        Me.rbtFullDayOff.TabIndex = 12
        Me.rbtFullDayOff.TabStop = True
        Me.rbtFullDayOff.Text = "Full Day Off"
        Me.rbtFullDayOff.UseVisualStyleBackColor = True
        '
        'lblVacationType
        '
        Me.lblVacationType.AutoSize = True
        Me.lblVacationType.Location = New System.Drawing.Point(352, 174)
        Me.lblVacationType.Name = "lblVacationType"
        Me.lblVacationType.Size = New System.Drawing.Size(109, 19)
        Me.lblVacationType.TabIndex = 13
        Me.lblVacationType.Text = "Vacation Type"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(57, 387)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 47)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRequestVacation
        '
        Me.btnRequestVacation.Location = New System.Drawing.Point(383, 387)
        Me.btnRequestVacation.Name = "btnRequestVacation"
        Me.btnRequestVacation.Size = New System.Drawing.Size(155, 47)
        Me.btnRequestVacation.TabIndex = 15
        Me.btnRequestVacation.Text = "Request Vacation"
        Me.btnRequestVacation.UseVisualStyleBackColor = True
        '
        'cbxSelectionDay
        '
        Me.cbxSelectionDay.AutoSize = True
        Me.cbxSelectionDay.Location = New System.Drawing.Point(30, 66)
        Me.cbxSelectionDay.Name = "cbxSelectionDay"
        Me.cbxSelectionDay.Size = New System.Drawing.Size(156, 23)
        Me.cbxSelectionDay.TabIndex = 16
        Me.cbxSelectionDay.Text = "Multiple selection"
        Me.cbxSelectionDay.UseVisualStyleBackColor = True
        '
        'frmVacation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 461)
        Me.Controls.Add(Me.cbxSelectionDay)
        Me.Controls.Add(Me.btnRequestVacation)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblVacationType)
        Me.Controls.Add(Me.rbtFullDayOff)
        Me.Controls.Add(Me.rbtHalfDay)
        Me.Controls.Add(Me.mclDaysOffSelection)
        Me.Controls.Add(Me.lblDaysOff)
        Me.Controls.Add(Me.txtAvailableVacationDays)
        Me.Controls.Add(Me.lblAvailableVacationDays)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmVacation"
        Me.Text = "Vacation Request"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lblAvailableVacationDays As System.Windows.Forms.Label
    Friend WithEvents txtAvailableVacationDays As System.Windows.Forms.TextBox
    Friend WithEvents lblDaysOff As System.Windows.Forms.Label
    Friend WithEvents mclDaysOffSelection As System.Windows.Forms.MonthCalendar
    Friend WithEvents rbtHalfDay As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFullDayOff As System.Windows.Forms.RadioButton
    Friend WithEvents lblVacationType As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnRequestVacation As System.Windows.Forms.Button
    Friend WithEvents cbxSelectionDay As System.Windows.Forms.CheckBox
End Class
