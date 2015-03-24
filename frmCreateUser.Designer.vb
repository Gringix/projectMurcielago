<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateUser
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
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.lblUserRegister = New System.Windows.Forms.Label()
        Me.lblPasswordRegister = New System.Windows.Forms.Label()
        Me.txtUserRegister = New System.Windows.Forms.TextBox()
        Me.txtPasswordRegister = New System.Windows.Forms.TextBox()
        Me.lblRegisterUser = New System.Windows.Forms.Label()
        Me.btnCancelRegister = New System.Windows.Forms.Button()
        Me.rbnUserRegister = New System.Windows.Forms.RadioButton()
        Me.rbnAdminRegister = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(138, 256)
        Me.btnCreateUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(112, 34)
        Me.btnCreateUser.TabIndex = 0
        Me.btnCreateUser.Text = "Create User"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'lblUserRegister
        '
        Me.lblUserRegister.AutoSize = True
        Me.lblUserRegister.Location = New System.Drawing.Point(40, 95)
        Me.lblUserRegister.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserRegister.Name = "lblUserRegister"
        Me.lblUserRegister.Size = New System.Drawing.Size(84, 19)
        Me.lblUserRegister.TabIndex = 1
        Me.lblUserRegister.Text = "Username:"
        '
        'lblPasswordRegister
        '
        Me.lblPasswordRegister.AutoSize = True
        Me.lblPasswordRegister.Location = New System.Drawing.Point(44, 145)
        Me.lblPasswordRegister.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPasswordRegister.Name = "lblPasswordRegister"
        Me.lblPasswordRegister.Size = New System.Drawing.Size(78, 19)
        Me.lblPasswordRegister.TabIndex = 2
        Me.lblPasswordRegister.Text = "Password:"
        '
        'txtUserRegister
        '
        Me.txtUserRegister.Location = New System.Drawing.Point(138, 95)
        Me.txtUserRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserRegister.Name = "txtUserRegister"
        Me.txtUserRegister.Size = New System.Drawing.Size(148, 27)
        Me.txtUserRegister.TabIndex = 3
        '
        'txtPasswordRegister
        '
        Me.txtPasswordRegister.Location = New System.Drawing.Point(138, 145)
        Me.txtPasswordRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPasswordRegister.Name = "txtPasswordRegister"
        Me.txtPasswordRegister.Size = New System.Drawing.Size(148, 27)
        Me.txtPasswordRegister.TabIndex = 4
        '
        'lblRegisterUser
        '
        Me.lblRegisterUser.AutoSize = True
        Me.lblRegisterUser.Location = New System.Drawing.Point(18, 44)
        Me.lblRegisterUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegisterUser.Name = "lblRegisterUser"
        Me.lblRegisterUser.Size = New System.Drawing.Size(406, 19)
        Me.lblRegisterUser.TabIndex = 5
        Me.lblRegisterUser.Text = "Please fill this information in order to create the account"
        '
        'btnCancelRegister
        '
        Me.btnCancelRegister.Location = New System.Drawing.Point(138, 314)
        Me.btnCancelRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelRegister.Name = "btnCancelRegister"
        Me.btnCancelRegister.Size = New System.Drawing.Size(112, 34)
        Me.btnCancelRegister.TabIndex = 6
        Me.btnCancelRegister.Text = "Cancel"
        Me.btnCancelRegister.UseVisualStyleBackColor = True
        '
        'rbnUserRegister
        '
        Me.rbnUserRegister.AutoSize = True
        Me.rbnUserRegister.Location = New System.Drawing.Point(81, 197)
        Me.rbnUserRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnUserRegister.Name = "rbnUserRegister"
        Me.rbnUserRegister.Size = New System.Drawing.Size(59, 23)
        Me.rbnUserRegister.TabIndex = 7
        Me.rbnUserRegister.TabStop = True
        Me.rbnUserRegister.Text = "User"
        Me.rbnUserRegister.UseVisualStyleBackColor = True
        '
        'rbnAdminRegister
        '
        Me.rbnAdminRegister.AutoSize = True
        Me.rbnAdminRegister.Location = New System.Drawing.Point(200, 197)
        Me.rbnAdminRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnAdminRegister.Name = "rbnAdminRegister"
        Me.rbnAdminRegister.Size = New System.Drawing.Size(75, 23)
        Me.rbnAdminRegister.TabIndex = 8
        Me.rbnAdminRegister.TabStop = True
        Me.rbnAdminRegister.Text = "Admin"
        Me.rbnAdminRegister.UseVisualStyleBackColor = True
        '
        'frmCreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 381)
        Me.Controls.Add(Me.rbnAdminRegister)
        Me.Controls.Add(Me.rbnUserRegister)
        Me.Controls.Add(Me.btnCancelRegister)
        Me.Controls.Add(Me.lblRegisterUser)
        Me.Controls.Add(Me.txtPasswordRegister)
        Me.Controls.Add(Me.txtUserRegister)
        Me.Controls.Add(Me.lblPasswordRegister)
        Me.Controls.Add(Me.lblUserRegister)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCreateUser"
        Me.Text = "Register User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateUser As System.Windows.Forms.Button
    Friend WithEvents lblUserRegister As System.Windows.Forms.Label
    Friend WithEvents lblPasswordRegister As System.Windows.Forms.Label
    Friend WithEvents txtUserRegister As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordRegister As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterUser As System.Windows.Forms.Label
    Friend WithEvents btnCancelRegister As System.Windows.Forms.Button
    Friend WithEvents rbnUserRegister As System.Windows.Forms.RadioButton
    Friend WithEvents rbnAdminRegister As System.Windows.Forms.RadioButton
End Class
