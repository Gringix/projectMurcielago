<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewProject
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
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.txtProyectName = New System.Windows.Forms.TextBox()
        Me.txtBudget = New System.Windows.Forms.TextBox()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.lblHoursOfTheProject = New System.Windows.Forms.Label()
        Me.txtHoursOfTheProject = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnCancelProject = New System.Windows.Forms.Button()
        Me.cklTechAssigned = New System.Windows.Forms.CheckedListBox()
        Me.lblTechniciansAssigned = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.Location = New System.Drawing.Point(32, 41)
        Me.lblProjectName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(104, 19)
        Me.lblProjectName.TabIndex = 0
        Me.lblProjectName.Text = "Project Name"
        '
        'lblBudget
        '
        Me.lblBudget.AutoSize = True
        Me.lblBudget.Location = New System.Drawing.Point(32, 94)
        Me.lblBudget.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(59, 19)
        Me.lblBudget.TabIndex = 1
        Me.lblBudget.Text = "Budget"
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(32, 142)
        Me.lblDueDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(76, 19)
        Me.lblDueDate.TabIndex = 2
        Me.lblDueDate.Text = "Due Date"
        '
        'txtProyectName
        '
        Me.txtProyectName.Location = New System.Drawing.Point(148, 41)
        Me.txtProyectName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProyectName.Name = "txtProyectName"
        Me.txtProyectName.Size = New System.Drawing.Size(148, 27)
        Me.txtProyectName.TabIndex = 3
        '
        'txtBudget
        '
        Me.txtBudget.Location = New System.Drawing.Point(148, 94)
        Me.txtBudget.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBudget.Name = "txtBudget"
        Me.txtBudget.Size = New System.Drawing.Size(148, 27)
        Me.txtBudget.TabIndex = 4
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Location = New System.Drawing.Point(148, 142)
        Me.dtpDueDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(298, 27)
        Me.dtpDueDate.TabIndex = 5
        '
        'lblHoursOfTheProject
        '
        Me.lblHoursOfTheProject.AutoSize = True
        Me.lblHoursOfTheProject.Location = New System.Drawing.Point(92, 193)
        Me.lblHoursOfTheProject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoursOfTheProject.Name = "lblHoursOfTheProject"
        Me.lblHoursOfTheProject.Size = New System.Drawing.Size(285, 19)
        Me.lblHoursOfTheProject.TabIndex = 6
        Me.lblHoursOfTheProject.Text = "How many hours will this project take?"
        '
        'txtHoursOfTheProject
        '
        Me.txtHoursOfTheProject.Location = New System.Drawing.Point(148, 235)
        Me.txtHoursOfTheProject.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHoursOfTheProject.Name = "txtHoursOfTheProject"
        Me.txtHoursOfTheProject.Size = New System.Drawing.Size(148, 27)
        Me.txtHoursOfTheProject.TabIndex = 7
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(57, 455)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(112, 34)
        Me.btnGenerate.TabIndex = 8
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnCancelProject
        '
        Me.btnCancelProject.Location = New System.Drawing.Point(323, 455)
        Me.btnCancelProject.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelProject.Name = "btnCancelProject"
        Me.btnCancelProject.Size = New System.Drawing.Size(112, 34)
        Me.btnCancelProject.TabIndex = 9
        Me.btnCancelProject.Text = "Cancel"
        Me.btnCancelProject.UseVisualStyleBackColor = True
        '
        'cklTechAssigned
        '
        Me.cklTechAssigned.FormattingEnabled = True
        Me.cklTechAssigned.Location = New System.Drawing.Point(135, 339)
        Me.cklTechAssigned.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cklTechAssigned.Name = "cklTechAssigned"
        Me.cklTechAssigned.Size = New System.Drawing.Size(178, 92)
        Me.cklTechAssigned.TabIndex = 10
        '
        'lblTechniciansAssigned
        '
        Me.lblTechniciansAssigned.AutoSize = True
        Me.lblTechniciansAssigned.Location = New System.Drawing.Point(36, 294)
        Me.lblTechniciansAssigned.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTechniciansAssigned.Name = "lblTechniciansAssigned"
        Me.lblTechniciansAssigned.Size = New System.Drawing.Size(158, 19)
        Me.lblTechniciansAssigned.TabIndex = 11
        Me.lblTechniciansAssigned.Text = "Technicians assigned:"
        '
        'frmNewProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 535)
        Me.Controls.Add(Me.lblTechniciansAssigned)
        Me.Controls.Add(Me.cklTechAssigned)
        Me.Controls.Add(Me.btnCancelProject)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtHoursOfTheProject)
        Me.Controls.Add(Me.lblHoursOfTheProject)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.txtBudget)
        Me.Controls.Add(Me.txtProyectName)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.lblBudget)
        Me.Controls.Add(Me.lblProjectName)
        Me.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmNewProject"
        Me.Text = "Create Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProjectName As System.Windows.Forms.Label
    Friend WithEvents lblBudget As System.Windows.Forms.Label
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents txtProyectName As System.Windows.Forms.TextBox
    Friend WithEvents txtBudget As System.Windows.Forms.TextBox
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHoursOfTheProject As System.Windows.Forms.Label
    Friend WithEvents txtHoursOfTheProject As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnCancelProject As System.Windows.Forms.Button
    Friend WithEvents cklTechAssigned As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblTechniciansAssigned As System.Windows.Forms.Label
End Class
