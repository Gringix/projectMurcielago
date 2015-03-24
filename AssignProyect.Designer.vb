<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignProyect
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
        Me.lblTechnician = New System.Windows.Forms.Label()
        Me.lblTechToProject = New System.Windows.Forms.Label()
        Me.cbxTechnician = New System.Windows.Forms.ComboBox()
        Me.cbxTechToProject = New System.Windows.Forms.ComboBox()
        Me.btnAssignTechician = New System.Windows.Forms.Button()
        Me.btnCancelAssignProject = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTechnician
        '
        Me.lblTechnician.AutoSize = True
        Me.lblTechnician.Location = New System.Drawing.Point(18, 70)
        Me.lblTechnician.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTechnician.Name = "lblTechnician"
        Me.lblTechnician.Size = New System.Drawing.Size(85, 19)
        Me.lblTechnician.TabIndex = 0
        Me.lblTechnician.Text = "Technician"
        '
        'lblTechToProject
        '
        Me.lblTechToProject.AutoSize = True
        Me.lblTechToProject.Location = New System.Drawing.Point(18, 134)
        Me.lblTechToProject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTechToProject.Name = "lblTechToProject"
        Me.lblTechToProject.Size = New System.Drawing.Size(80, 19)
        Me.lblTechToProject.TabIndex = 1
        Me.lblTechToProject.Text = "To project"
        '
        'cbxTechnician
        '
        Me.cbxTechnician.FormattingEnabled = True
        Me.cbxTechnician.Location = New System.Drawing.Point(132, 67)
        Me.cbxTechnician.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxTechnician.Name = "cbxTechnician"
        Me.cbxTechnician.Size = New System.Drawing.Size(180, 27)
        Me.cbxTechnician.TabIndex = 2
        '
        'cbxTechToProject
        '
        Me.cbxTechToProject.FormattingEnabled = True
        Me.cbxTechToProject.Location = New System.Drawing.Point(132, 121)
        Me.cbxTechToProject.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxTechToProject.Name = "cbxTechToProject"
        Me.cbxTechToProject.Size = New System.Drawing.Size(180, 27)
        Me.cbxTechToProject.TabIndex = 3
        '
        'btnAssignTechician
        '
        Me.btnAssignTechician.Location = New System.Drawing.Point(62, 212)
        Me.btnAssignTechician.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAssignTechician.Name = "btnAssignTechician"
        Me.btnAssignTechician.Size = New System.Drawing.Size(112, 34)
        Me.btnAssignTechician.TabIndex = 4
        Me.btnAssignTechician.Text = "Assign"
        Me.btnAssignTechician.UseVisualStyleBackColor = True
        '
        'btnCancelAssignProject
        '
        Me.btnCancelAssignProject.Location = New System.Drawing.Point(226, 212)
        Me.btnCancelAssignProject.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelAssignProject.Name = "btnCancelAssignProject"
        Me.btnCancelAssignProject.Size = New System.Drawing.Size(112, 34)
        Me.btnCancelAssignProject.TabIndex = 5
        Me.btnCancelAssignProject.Text = "Cancel"
        Me.btnCancelAssignProject.UseVisualStyleBackColor = True
        '
        'frmAssignProyect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 294)
        Me.Controls.Add(Me.btnCancelAssignProject)
        Me.Controls.Add(Me.btnAssignTechician)
        Me.Controls.Add(Me.cbxTechToProject)
        Me.Controls.Add(Me.cbxTechnician)
        Me.Controls.Add(Me.lblTechToProject)
        Me.Controls.Add(Me.lblTechnician)
        Me.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAssignProyect"
        Me.Text = "Assign Proyect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTechnician As System.Windows.Forms.Label
    Friend WithEvents lblTechToProject As System.Windows.Forms.Label
    Friend WithEvents cbxTechnician As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTechToProject As System.Windows.Forms.ComboBox
    Friend WithEvents btnAssignTechician As System.Windows.Forms.Button
    Friend WithEvents btnCancelAssignProject As System.Windows.Forms.Button
End Class
