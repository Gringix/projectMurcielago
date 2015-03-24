<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkCategory
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
        Me.components = New System.ComponentModel.Container()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.WorkCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClessidraDataSet = New projectMurcielago.ClessidraDataSet()
        Me.Work_CategoryTableAdapter = New projectMurcielago.ClessidraDataSetTableAdapters.Work_CategoryTableAdapter()
        Me.TimelogDataSet = New projectMurcielago.timelogDataSet()
        Me.WorkCategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Work_CategoryTableAdapter1 = New projectMurcielago.timelogDataSetTableAdapters.Work_CategoryTableAdapter()
        Me.IdcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClessidraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimelogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(53, 49)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 0
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(361, 49)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(261, 49)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(157, 49)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvCategory
        '
        Me.dgvCategory.AllowUserToAddRows = False
        Me.dgvCategory.AllowUserToDeleteRows = False
        Me.dgvCategory.AutoGenerateColumns = False
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcategoryDataGridViewTextBoxColumn, Me.CategorynameDataGridViewTextBoxColumn})
        Me.dgvCategory.DataSource = Me.WorkCategoryBindingSource1
        Me.dgvCategory.Location = New System.Drawing.Point(130, 122)
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.ReadOnly = True
        Me.dgvCategory.Size = New System.Drawing.Size(240, 150)
        Me.dgvCategory.TabIndex = 6
        '
        'WorkCategoryBindingSource
        '
        Me.WorkCategoryBindingSource.DataMember = "Work_Category"
        Me.WorkCategoryBindingSource.DataSource = Me.ClessidraDataSet
        '
        'ClessidraDataSet
        '
        Me.ClessidraDataSet.DataSetName = "ClessidraDataSet"
        Me.ClessidraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Work_CategoryTableAdapter
        '
        Me.Work_CategoryTableAdapter.ClearBeforeFill = True
        '
        'TimelogDataSet
        '
        Me.TimelogDataSet.DataSetName = "timelogDataSet"
        Me.TimelogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkCategoryBindingSource1
        '
        Me.WorkCategoryBindingSource1.DataMember = "Work_Category"
        Me.WorkCategoryBindingSource1.DataSource = Me.TimelogDataSet
        '
        'Work_CategoryTableAdapter1
        '
        Me.Work_CategoryTableAdapter1.ClearBeforeFill = True
        '
        'IdcategoryDataGridViewTextBoxColumn
        '
        Me.IdcategoryDataGridViewTextBoxColumn.DataPropertyName = "id_category"
        Me.IdcategoryDataGridViewTextBoxColumn.HeaderText = "id_category"
        Me.IdcategoryDataGridViewTextBoxColumn.Name = "IdcategoryDataGridViewTextBoxColumn"
        Me.IdcategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategorynameDataGridViewTextBoxColumn
        '
        Me.CategorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name"
        Me.CategorynameDataGridViewTextBoxColumn.HeaderText = "category_name"
        Me.CategorynameDataGridViewTextBoxColumn.Name = "CategorynameDataGridViewTextBoxColumn"
        Me.CategorynameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmWorkCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 350)
        Me.Controls.Add(Me.dgvCategory)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Name = "frmWorkCategory"
        Me.Text = "frmWorkCategory"
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClessidraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimelogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvCategory As System.Windows.Forms.DataGridView
    Friend WithEvents ClessidraDataSet As projectMurcielago.ClessidraDataSet
    Friend WithEvents WorkCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Work_CategoryTableAdapter As projectMurcielago.ClessidraDataSetTableAdapters.Work_CategoryTableAdapter
    Friend WithEvents TimelogDataSet As projectMurcielago.timelogDataSet
    Friend WithEvents WorkCategoryBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Work_CategoryTableAdapter1 As projectMurcielago.timelogDataSetTableAdapters.Work_CategoryTableAdapter
    Friend WithEvents IdcategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategorynameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
