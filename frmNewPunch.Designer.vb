<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewPunch
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
        Me.dtpPunchDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDateWorked = New System.Windows.Forms.Label()
        Me.lblHoursWorked = New System.Windows.Forms.Label()
        Me.lblProyectWorked = New System.Windows.Forms.Label()
        Me.lblAreaWorked = New System.Windows.Forms.Label()
        Me.lblTaskDone = New System.Windows.Forms.Label()
        Me.cbxProjectSelection = New System.Windows.Forms.ComboBox()
        Me.cbxAreaSelection = New System.Windows.Forms.ComboBox()
        Me.numHoursWorked = New System.Windows.Forms.NumericUpDown()
        Me.txtTaskDone = New System.Windows.Forms.RichTextBox()
        Me.btnPunch = New System.Windows.Forms.Button()
        Me.ckbMultipleSelection = New System.Windows.Forms.CheckBox()
        CType(Me.numHoursWorked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(576, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'dtpPunchDate
        '
        Me.dtpPunchDate.Location = New System.Drawing.Point(165, 123)
        Me.dtpPunchDate.Name = "dtpPunchDate"
        Me.dtpPunchDate.Size = New System.Drawing.Size(213, 27)
        Me.dtpPunchDate.TabIndex = 5
        '
        'lblDateWorked
        '
        Me.lblDateWorked.AutoSize = True
        Me.lblDateWorked.Location = New System.Drawing.Point(13, 131)
        Me.lblDateWorked.Name = "lblDateWorked"
        Me.lblDateWorked.Size = New System.Drawing.Size(103, 19)
        Me.lblDateWorked.TabIndex = 6
        Me.lblDateWorked.Text = "Date Worked"
        '
        'lblHoursWorked
        '
        Me.lblHoursWorked.AutoSize = True
        Me.lblHoursWorked.Location = New System.Drawing.Point(13, 269)
        Me.lblHoursWorked.Name = "lblHoursWorked"
        Me.lblHoursWorked.Size = New System.Drawing.Size(112, 19)
        Me.lblHoursWorked.TabIndex = 7
        Me.lblHoursWorked.Text = "Hours Worked"
        '
        'lblProyectWorked
        '
        Me.lblProyectWorked.AutoSize = True
        Me.lblProyectWorked.Location = New System.Drawing.Point(13, 174)
        Me.lblProyectWorked.Name = "lblProyectWorked"
        Me.lblProyectWorked.Size = New System.Drawing.Size(64, 19)
        Me.lblProyectWorked.TabIndex = 8
        Me.lblProyectWorked.Text = "Projects"
        '
        'lblAreaWorked
        '
        Me.lblAreaWorked.AutoSize = True
        Me.lblAreaWorked.Location = New System.Drawing.Point(13, 220)
        Me.lblAreaWorked.Name = "lblAreaWorked"
        Me.lblAreaWorked.Size = New System.Drawing.Size(102, 19)
        Me.lblAreaWorked.TabIndex = 9
        Me.lblAreaWorked.Text = "Area Worked"
        '
        'lblTaskDone
        '
        Me.lblTaskDone.AutoSize = True
        Me.lblTaskDone.Location = New System.Drawing.Point(13, 315)
        Me.lblTaskDone.Name = "lblTaskDone"
        Me.lblTaskDone.Size = New System.Drawing.Size(83, 19)
        Me.lblTaskDone.TabIndex = 10
        Me.lblTaskDone.Text = "Task Done"
        '
        'cbxProjectSelection
        '
        Me.cbxProjectSelection.FormattingEnabled = True
        Me.cbxProjectSelection.Location = New System.Drawing.Point(165, 171)
        Me.cbxProjectSelection.Name = "cbxProjectSelection"
        Me.cbxProjectSelection.Size = New System.Drawing.Size(213, 27)
        Me.cbxProjectSelection.TabIndex = 11
        Me.cbxProjectSelection.Tag = ""
        Me.cbxProjectSelection.Text = "-Select Proyect-"
        '
        'cbxAreaSelection
        '
        Me.cbxAreaSelection.FormattingEnabled = True
        Me.cbxAreaSelection.Location = New System.Drawing.Point(165, 217)
        Me.cbxAreaSelection.Name = "cbxAreaSelection"
        Me.cbxAreaSelection.Size = New System.Drawing.Size(213, 27)
        Me.cbxAreaSelection.TabIndex = 12
        Me.cbxAreaSelection.Text = "-Select Area-"
        '
        'numHoursWorked
        '
        Me.numHoursWorked.Location = New System.Drawing.Point(165, 261)
        Me.numHoursWorked.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.numHoursWorked.Name = "numHoursWorked"
        Me.numHoursWorked.Size = New System.Drawing.Size(64, 27)
        Me.numHoursWorked.TabIndex = 13
        '
        'txtTaskDone
        '
        Me.txtTaskDone.Location = New System.Drawing.Point(165, 315)
        Me.txtTaskDone.Name = "txtTaskDone"
        Me.txtTaskDone.Size = New System.Drawing.Size(200, 119)
        Me.txtTaskDone.TabIndex = 14
        Me.txtTaskDone.Text = "-Enter specifics regarding what was worked on-"
        '
        'btnPunch
        '
        Me.btnPunch.Location = New System.Drawing.Point(377, 474)
        Me.btnPunch.Name = "btnPunch"
        Me.btnPunch.Size = New System.Drawing.Size(149, 46)
        Me.btnPunch.TabIndex = 15
        Me.btnPunch.Text = "Punch"
        Me.btnPunch.UseVisualStyleBackColor = True
        '
        'ckbMultipleSelection
        '
        Me.ckbMultipleSelection.AutoSize = True
        Me.ckbMultipleSelection.Location = New System.Drawing.Point(17, 40)
        Me.ckbMultipleSelection.Name = "ckbMultipleSelection"
        Me.ckbMultipleSelection.Size = New System.Drawing.Size(156, 23)
        Me.ckbMultipleSelection.TabIndex = 17
        Me.ckbMultipleSelection.Text = "Multiple selection"
        Me.ckbMultipleSelection.UseVisualStyleBackColor = True
        '
        'frmNewPunch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 574)
        Me.Controls.Add(Me.ckbMultipleSelection)
        Me.Controls.Add(Me.btnPunch)
        Me.Controls.Add(Me.txtTaskDone)
        Me.Controls.Add(Me.numHoursWorked)
        Me.Controls.Add(Me.cbxAreaSelection)
        Me.Controls.Add(Me.cbxProjectSelection)
        Me.Controls.Add(Me.lblTaskDone)
        Me.Controls.Add(Me.lblAreaWorked)
        Me.Controls.Add(Me.lblProyectWorked)
        Me.Controls.Add(Me.lblHoursWorked)
        Me.Controls.Add(Me.lblDateWorked)
        Me.Controls.Add(Me.dtpPunchDate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNewPunch"
        Me.Text = "New Punch "
        CType(Me.numHoursWorked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents dtpPunchDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateWorked As System.Windows.Forms.Label
    Friend WithEvents lblHoursWorked As System.Windows.Forms.Label
    Friend WithEvents lblProyectWorked As System.Windows.Forms.Label
    Friend WithEvents lblAreaWorked As System.Windows.Forms.Label
    Friend WithEvents lblTaskDone As System.Windows.Forms.Label
    Friend WithEvents cbxProjectSelection As System.Windows.Forms.ComboBox
    Friend WithEvents cbxAreaSelection As System.Windows.Forms.ComboBox
    Friend WithEvents numHoursWorked As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTaskDone As System.Windows.Forms.RichTextBox
    Friend WithEvents btnPunch As System.Windows.Forms.Button
    Friend WithEvents ckbMultipleSelection As System.Windows.Forms.CheckBox
End Class
