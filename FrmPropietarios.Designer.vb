<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPropietarios
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
        Me.PropietariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallervillarroyaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Taller_villarroyaDataSet = New taller_villarroya.taller_villarroyaDataSet()
        Me.PropietariosTableAdapter = New taller_villarroya.taller_villarroyaDataSetTableAdapters.propietariosTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.txt_prop = New System.Windows.Forms.TextBox()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.txt_eliminar = New System.Windows.Forms.TextBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvprop = New System.Windows.Forms.DataGridView()
        Me.IdpropietarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrepropDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonopropDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PropietariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallervillarroyaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taller_villarroyaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvprop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PropietariosBindingSource
        '
        Me.PropietariosBindingSource.DataMember = "propietarios"
        Me.PropietariosBindingSource.DataSource = Me.TallervillarroyaDataSetBindingSource
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
        'PropietariosTableAdapter
        '
        Me.PropietariosTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(782, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del propietario"
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(786, 148)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(221, 26)
        Me.txt_numero.TabIndex = 3
        '
        'txt_prop
        '
        Me.txt_prop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prop.Location = New System.Drawing.Point(786, 80)
        Me.txt_prop.Name = "txt_prop"
        Me.txt_prop.Size = New System.Drawing.Size(221, 26)
        Me.txt_prop.TabIndex = 4
        '
        'btn_registrar
        '
        Me.btn_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.Location = New System.Drawing.Point(806, 201)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(191, 49)
        Me.btn_registrar.TabIndex = 5
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'txt_eliminar
        '
        Me.txt_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_eliminar.Location = New System.Drawing.Point(835, 367)
        Me.txt_eliminar.Name = "txt_eliminar"
        Me.txt_eliminar.Size = New System.Drawing.Size(125, 29)
        Me.txt_eliminar.TabIndex = 7
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(818, 412)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(170, 45)
        Me.btn_eliminar.TabIndex = 8
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(846, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(757, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(302, 36)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Eliminar Propietario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(814, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ID del propietario"
        '
        'dgvprop
        '
        Me.dgvprop.AllowUserToAddRows = False
        Me.dgvprop.AllowUserToDeleteRows = False
        Me.dgvprop.AutoGenerateColumns = False
        Me.dgvprop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvprop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpropietarioDataGridViewTextBoxColumn, Me.NombrepropDataGridViewTextBoxColumn, Me.TelefonopropDataGridViewTextBoxColumn})
        Me.dgvprop.DataSource = Me.PropietariosBindingSource
        Me.dgvprop.Location = New System.Drawing.Point(12, 9)
        Me.dgvprop.Name = "dgvprop"
        Me.dgvprop.ReadOnly = True
        Me.dgvprop.Size = New System.Drawing.Size(717, 528)
        Me.dgvprop.TabIndex = 14
        '
        'IdpropietarioDataGridViewTextBoxColumn
        '
        Me.IdpropietarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IdpropietarioDataGridViewTextBoxColumn.DataPropertyName = "id_propietario"
        Me.IdpropietarioDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdpropietarioDataGridViewTextBoxColumn.Name = "IdpropietarioDataGridViewTextBoxColumn"
        Me.IdpropietarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdpropietarioDataGridViewTextBoxColumn.Width = 43
        '
        'NombrepropDataGridViewTextBoxColumn
        '
        Me.NombrepropDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombrepropDataGridViewTextBoxColumn.DataPropertyName = "nombre_prop"
        Me.NombrepropDataGridViewTextBoxColumn.HeaderText = "Nombre del propietario"
        Me.NombrepropDataGridViewTextBoxColumn.Name = "NombrepropDataGridViewTextBoxColumn"
        Me.NombrepropDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonopropDataGridViewTextBoxColumn
        '
        Me.TelefonopropDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TelefonopropDataGridViewTextBoxColumn.DataPropertyName = "telefono_prop"
        Me.TelefonopropDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonopropDataGridViewTextBoxColumn.Name = "TelefonopropDataGridViewTextBoxColumn"
        Me.TelefonopropDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonopropDataGridViewTextBoxColumn.Width = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(757, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Registrar Propietario"
        '
        'FrmPropietarios
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1084, 549)
        Me.Controls.Add(Me.dgvprop)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.txt_eliminar)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.txt_prop)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmPropietarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Propietarios"
        CType(Me.PropietariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallervillarroyaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taller_villarroyaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvprop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TallervillarroyaDataSetBindingSource As BindingSource
    Friend WithEvents Taller_villarroyaDataSet As taller_villarroyaDataSet
    Friend WithEvents PropietariosBindingSource As BindingSource
    Friend WithEvents PropietariosTableAdapter As taller_villarroyaDataSetTableAdapters.propietariosTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents txt_prop As TextBox
    Friend WithEvents btn_registrar As Button
    Friend WithEvents txt_eliminar As TextBox
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvprop As DataGridView
    Friend WithEvents IdpropietarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombrepropDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonopropDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
