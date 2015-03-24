<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnWelcomeExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDaysOfVacations = New System.Windows.Forms.Label()
        Me.lblDaysForVacation = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ntsmWelcome = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmNewEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmRequestVacations = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmViewHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmCreateUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmGenerateReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmAssigments = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsmangeVacation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsWorkCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntsTimeRegistrationManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnWelcomeExit
        '
        Me.btnWelcomeExit.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWelcomeExit.Location = New System.Drawing.Point(251, 225)
        Me.btnWelcomeExit.Name = "btnWelcomeExit"
        Me.btnWelcomeExit.Size = New System.Drawing.Size(152, 27)
        Me.btnWelcomeExit.TabIndex = 3
        Me.btnWelcomeExit.Text = "Exit"
        Me.btnWelcomeExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome to Simple Timelog"
        '
        'lblDaysOfVacations
        '
        Me.lblDaysOfVacations.AutoSize = True
        Me.lblDaysOfVacations.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysOfVacations.ForeColor = System.Drawing.Color.Black
        Me.lblDaysOfVacations.Location = New System.Drawing.Point(59, 161)
        Me.lblDaysOfVacations.Name = "lblDaysOfVacations"
        Me.lblDaysOfVacations.Size = New System.Drawing.Size(113, 19)
        Me.lblDaysOfVacations.TabIndex = 9
        Me.lblDaysOfVacations.Text = "Available Days"
        '
        'lblDaysForVacation
        '
        Me.lblDaysForVacation.AutoSize = True
        Me.lblDaysForVacation.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysForVacation.Location = New System.Drawing.Point(247, 161)
        Me.lblDaysForVacation.Name = "lblDaysForVacation"
        Me.lblDaysForVacation.Size = New System.Drawing.Size(18, 19)
        Me.lblDaysForVacation.TabIndex = 10
        Me.lblDaysForVacation.Text = "6"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 51)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(520, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 27)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(520, 24)
        Me.MenuStrip2.TabIndex = 13
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ntsmWelcome})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip3.Size = New System.Drawing.Size(520, 27)
        Me.MenuStrip3.TabIndex = 14
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'ntsmWelcome
        '
        Me.ntsmWelcome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ntsmNewEntry, Me.ntsmRequestVacations, Me.ntsmViewHistory, Me.ntsmCreateUser, Me.ntsmGenerateReports, Me.ntsmAssigments, Me.ntsmangeVacation, Me.ntsWorkCategory, Me.ntsTimeRegistrationManagement})
        Me.ntsmWelcome.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntsmWelcome.Name = "ntsmWelcome"
        Me.ntsmWelcome.Size = New System.Drawing.Size(181, 23)
        Me.ntsmWelcome.Text = "Please select an option"
        '
        'ntsmNewEntry
        '
        Me.ntsmNewEntry.Name = "ntsmNewEntry"
        Me.ntsmNewEntry.Size = New System.Drawing.Size(341, 24)
        Me.ntsmNewEntry.Text = "New Entry"
        '
        'ntsmRequestVacations
        '
        Me.ntsmRequestVacations.Name = "ntsmRequestVacations"
        Me.ntsmRequestVacations.Size = New System.Drawing.Size(341, 24)
        Me.ntsmRequestVacations.Text = "Request Vacations"
        '
        'ntsmViewHistory
        '
        Me.ntsmViewHistory.Name = "ntsmViewHistory"
        Me.ntsmViewHistory.Size = New System.Drawing.Size(341, 24)
        Me.ntsmViewHistory.Text = "View History"
        '
        'ntsmCreateUser
        '
        Me.ntsmCreateUser.Name = "ntsmCreateUser"
        Me.ntsmCreateUser.Size = New System.Drawing.Size(341, 24)
        Me.ntsmCreateUser.Text = "Create User"
        '
        'ntsmGenerateReports
        '
        Me.ntsmGenerateReports.Name = "ntsmGenerateReports"
        Me.ntsmGenerateReports.Size = New System.Drawing.Size(341, 24)
        Me.ntsmGenerateReports.Text = "Generate Reports"
        '
        'ntsmAssigments
        '
        Me.ntsmAssigments.Name = "ntsmAssigments"
        Me.ntsmAssigments.Size = New System.Drawing.Size(341, 24)
        Me.ntsmAssigments.Text = "Assigments"
        '
        'ntsmangeVacation
        '
        Me.ntsmangeVacation.Name = "ntsmangeVacation"
        Me.ntsmangeVacation.Size = New System.Drawing.Size(341, 24)
        Me.ntsmangeVacation.Text = "Manage Vacation Requets"
        '
        'ntsWorkCategory
        '
        Me.ntsWorkCategory.Name = "ntsWorkCategory"
        Me.ntsWorkCategory.Size = New System.Drawing.Size(341, 24)
        Me.ntsWorkCategory.Text = "Work Category"
        '
        'ntsTimeRegistrationManagement
        '
        Me.ntsTimeRegistrationManagement.Name = "ntsTimeRegistrationManagement"
        Me.ntsTimeRegistrationManagement.Size = New System.Drawing.Size(341, 24)
        Me.ntsTimeRegistrationManagement.Text = "Time Registration Management View"
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 268)
        Me.Controls.Add(Me.lblDaysForVacation)
        Me.Controls.Add(Me.lblDaysOfVacations)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnWelcomeExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmWelcome"
        Me.Text = "Simple Timelog"
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnWelcomeExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDaysOfVacations As System.Windows.Forms.Label
    Friend WithEvents lblDaysForVacation As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents ntsmWelcome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmRequestVacations As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmViewHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmCreateUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmGenerateReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmAssigments As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmangeVacation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsmNewEntry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsWorkCategory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntsTimeRegistrationManagement As System.Windows.Forms.ToolStripMenuItem
End Class
