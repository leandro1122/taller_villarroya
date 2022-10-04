<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepuestos
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
        Me.dgvrepuestos = New System.Windows.Forms.DataGridView()
        Me.RepuestosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallervillarroyaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Taller_villarroyaDataSet = New taller_villarroya.taller_villarroyaDataSet()
        Me.RepuestosTableAdapter = New taller_villarroya.taller_villarroyaDataSetTableAdapters.repuestosTableAdapter()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_importe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_eliminar = New System.Windows.Forms.TextBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.CodrepuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionrepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporterepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvrepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepuestosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallervillarroyaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taller_villarroyaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvrepuestos
        '
        Me.dgvrepuestos.AllowUserToAddRows = False
        Me.dgvrepuestos.AllowUserToDeleteRows = False
        Me.dgvrepuestos.AutoGenerateColumns = False
        Me.dgvrepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrepuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodrepuestoDataGridViewTextBoxColumn, Me.DescripcionrepDataGridViewTextBoxColumn, Me.ImporterepDataGridViewTextBoxColumn})
        Me.dgvrepuestos.DataSource = Me.RepuestosBindingSource
        Me.dgvrepuestos.Location = New System.Drawing.Point(12, 46)
        Me.dgvrepuestos.Name = "dgvrepuestos"
        Me.dgvrepuestos.ReadOnly = True
        Me.dgvrepuestos.Size = New System.Drawing.Size(770, 150)
        Me.dgvrepuestos.TabIndex = 0
        '
        'RepuestosBindingSource
        '
        Me.RepuestosBindingSource.DataMember = "repuestos"
        Me.RepuestosBindingSource.DataSource = Me.TallervillarroyaDataSetBindingSource
        '
        'TallervillarroyaDataSetBindingSource
        '
        Me.TallervillarroyaDataSetBindingSource.DataSource = Me.Taller_villarroyaDataSet
        Me.TallervillarroyaDataSetBindingSource.Position = 0
        '
        'Taller_villarroyaDataSet
        '
        Me.Taller_villarroyaDataSet.DataSetName = "taller_villarroyaDataSet"
        Me.Taller_villarroyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepuestosTableAdapter
        '
        Me.RepuestosTableAdapter.ClearBeforeFill = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(66, 415)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(58, 318)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(100, 20)
        Me.txt_descripcion.TabIndex = 3
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(58, 375)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Size = New System.Drawing.Size(100, 20)
        Me.txt_importe.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Importe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ingresar repuestos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(337, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Eliminar repuestos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(370, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Codigo de repuesto"
        '
        'txt_eliminar
        '
        Me.txt_eliminar.Location = New System.Drawing.Point(360, 336)
        Me.txt_eliminar.Name = "txt_eliminar"
        Me.txt_eliminar.Size = New System.Drawing.Size(120, 20)
        Me.txt_eliminar.TabIndex = 10
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(385, 372)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(65, 23)
        Me.btn_eliminar.TabIndex = 11
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'CodrepuestoDataGridViewTextBoxColumn
        '
        Me.CodrepuestoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CodrepuestoDataGridViewTextBoxColumn.DataPropertyName = "cod_repuesto"
        Me.CodrepuestoDataGridViewTextBoxColumn.HeaderText = "Codigo de repuesto"
        Me.CodrepuestoDataGridViewTextBoxColumn.Name = "CodrepuestoDataGridViewTextBoxColumn"
        Me.CodrepuestoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodrepuestoDataGridViewTextBoxColumn.Width = 114
        '
        'DescripcionrepDataGridViewTextBoxColumn
        '
        Me.DescripcionrepDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionrepDataGridViewTextBoxColumn.DataPropertyName = "descripcion_rep"
        Me.DescripcionrepDataGridViewTextBoxColumn.HeaderText = "Descripcion "
        Me.DescripcionrepDataGridViewTextBoxColumn.Name = "DescripcionrepDataGridViewTextBoxColumn"
        Me.DescripcionrepDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporterepDataGridViewTextBoxColumn
        '
        Me.ImporterepDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ImporterepDataGridViewTextBoxColumn.DataPropertyName = "importe_rep"
        Me.ImporterepDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporterepDataGridViewTextBoxColumn.Name = "ImporterepDataGridViewTextBoxColumn"
        Me.ImporterepDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporterepDataGridViewTextBoxColumn.Width = 67
        '
        'FrmRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 549)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.txt_eliminar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_importe)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgvrepuestos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(49, 12)
        Me.Name = "FrmRepuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repuestos"
        CType(Me.dgvrepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepuestosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallervillarroyaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller_villarroyaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvrepuestos As DataGridView
    Friend WithEvents TallervillarroyaDataSetBindingSource As BindingSource
    Friend WithEvents Taller_villarroyaDataSet As taller_villarroyaDataSet
    Friend WithEvents RepuestosBindingSource As BindingSource
    Friend WithEvents RepuestosTableAdapter As taller_villarroyaDataSetTableAdapters.repuestosTableAdapter
    Friend WithEvents btn_agregar As Button
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_importe As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_eliminar As TextBox
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents CodrepuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionrepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporterepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
