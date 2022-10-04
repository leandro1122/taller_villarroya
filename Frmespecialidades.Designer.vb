<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmespecialidades
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Taller_villarroyaDataSet = New taller_villarroya.taller_villarroyaDataSet()
        Me.EspecialidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EspecialidadesTableAdapter = New taller_villarroya.taller_villarroyaDataSetTableAdapters.especialidadesTableAdapter()
        Me.TableAdapterManager = New taller_villarroya.taller_villarroyaDataSetTableAdapters.TableAdapterManager()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_Especialidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.txt_eliminar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvespecialidades = New System.Windows.Forms.DataGridView()
        Me.IdespecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Taller_villarroyaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvespecialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Taller_villarroyaDataSet
        '
        Me.Taller_villarroyaDataSet.DataSetName = "taller_villarroyaDataSet"
        Me.Taller_villarroyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EspecialidadesBindingSource
        '
        Me.EspecialidadesBindingSource.DataMember = "especialidades"
        Me.EspecialidadesBindingSource.DataSource = Me.Taller_villarroyaDataSet
        '
        'EspecialidadesTableAdapter
        '
        Me.EspecialidadesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.autosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.especialidadesTableAdapter = Me.EspecialidadesTableAdapter
        Me.TableAdapterManager.ingresos_repuestosTableAdapter = Nothing
        Me.TableAdapterManager.ingresos_TareasTableAdapter = Nothing
        Me.TableAdapterManager.ingresosTableAdapter = Nothing
        Me.TableAdapterManager.operariosTableAdapter = Nothing
        Me.TableAdapterManager.propietariosTableAdapter = Nothing
        Me.TableAdapterManager.repuestosTableAdapter = Nothing
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = taller_villarroya.taller_villarroyaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(482, 192)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 2
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'txt_Especialidad
        '
        Me.txt_Especialidad.Location = New System.Drawing.Point(470, 166)
        Me.txt_Especialidad.Name = "txt_Especialidad"
        Me.txt_Especialidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_Especialidad.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(479, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Especialidad"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(739, 192)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 7
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'txt_eliminar
        '
        Me.txt_eliminar.Location = New System.Drawing.Point(728, 166)
        Me.txt_eliminar.Name = "txt_eliminar"
        Me.txt_eliminar.Size = New System.Drawing.Size(100, 20)
        Me.txt_eliminar.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(736, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Id especialidad"
        '
        'dgvespecialidades
        '
        Me.dgvespecialidades.AllowUserToAddRows = False
        Me.dgvespecialidades.AllowUserToDeleteRows = False
        Me.dgvespecialidades.AutoGenerateColumns = False
        Me.dgvespecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvespecialidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdespecialidadDataGridViewTextBoxColumn, Me.EspecialidadDataGridViewTextBoxColumn})
        Me.dgvespecialidades.DataSource = Me.EspecialidadesBindingSource
        Me.dgvespecialidades.Location = New System.Drawing.Point(81, 113)
        Me.dgvespecialidades.Name = "dgvespecialidades"
        Me.dgvespecialidades.ReadOnly = True
        Me.dgvespecialidades.Size = New System.Drawing.Size(354, 150)
        Me.dgvespecialidades.TabIndex = 11
        '
        'IdespecialidadDataGridViewTextBoxColumn
        '
        Me.IdespecialidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IdespecialidadDataGridViewTextBoxColumn.DataPropertyName = "id_especialidad"
        Me.IdespecialidadDataGridViewTextBoxColumn.HeaderText = "ID "
        Me.IdespecialidadDataGridViewTextBoxColumn.Name = "IdespecialidadDataGridViewTextBoxColumn"
        Me.IdespecialidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdespecialidadDataGridViewTextBoxColumn.Width = 43
        '
        'EspecialidadDataGridViewTextBoxColumn
        '
        Me.EspecialidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EspecialidadDataGridViewTextBoxColumn.DataPropertyName = "especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad"
        Me.EspecialidadDataGridViewTextBoxColumn.Name = "EspecialidadDataGridViewTextBoxColumn"
        '
        'Frmespecialidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 549)
        Me.Controls.Add(Me.dgvespecialidades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_eliminar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Especialidad)
        Me.Controls.Add(Me.btn_agregar)
        Me.Name = "Frmespecialidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Especialidades"
        CType(Me.Taller_villarroyaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecialidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvespecialidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Taller_villarroyaDataSet As taller_villarroyaDataSet
    Friend WithEvents EspecialidadesBindingSource As BindingSource
    Friend WithEvents EspecialidadesTableAdapter As taller_villarroyaDataSetTableAdapters.especialidadesTableAdapter
    Friend WithEvents TableAdapterManager As taller_villarroyaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btn_agregar As Button
    Friend WithEvents txt_Especialidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents txt_eliminar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvespecialidades As DataGridView
    Friend WithEvents IdespecialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspecialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
