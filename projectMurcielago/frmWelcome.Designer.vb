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
        Me.btnNewEntry = New System.Windows.Forms.Button()
        Me.btnRequestVacations = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewEntry
        '
        Me.btnNewEntry.Location = New System.Drawing.Point(106, 123)
        Me.btnNewEntry.Name = "btnNewEntry"
        Me.btnNewEntry.Size = New System.Drawing.Size(147, 23)
        Me.btnNewEntry.TabIndex = 0
        Me.btnNewEntry.Text = "New Entry"
        Me.btnNewEntry.UseVisualStyleBackColor = True
        '
        'btnRequestVacations
        '
        Me.btnRequestVacations.Location = New System.Drawing.Point(106, 168)
        Me.btnRequestVacations.Name = "btnRequestVacations"
        Me.btnRequestVacations.Size = New System.Drawing.Size(147, 23)
        Me.btnRequestVacations.TabIndex = 1
        Me.btnRequestVacations.Text = "Request Vacations"
        Me.btnRequestVacations.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(106, 211)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(147, 23)
        Me.btnHistory.TabIndex = 2
        Me.btnHistory.Text = "View History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(323, 376)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome to Simple Timelog"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Please select an option:"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(103, 299)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(147, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Generate Reports"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(106, 255)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(147, 23)
        Me.btnCreateUser.TabIndex = 7
        Me.btnCreateUser.Text = "Create User"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(106, 376)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(147, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Manage Vacation Requests"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Dias libres disponibles:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(355, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "6"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(106, 337)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(144, 23)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Assignments"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 420)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnRequestVacations)
        Me.Controls.Add(Me.btnNewEntry)
        Me.Name = "frmWelcome"
        Me.Text = "Simple Timelog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewEntry As System.Windows.Forms.Button
    Friend WithEvents btnRequestVacations As System.Windows.Forms.Button
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnCreateUser As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
