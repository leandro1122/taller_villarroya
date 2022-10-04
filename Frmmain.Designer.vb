<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmain))
        Me.Panelcabecera = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panelmenu = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_especialidad = New System.Windows.Forms.Button()
        Me.Panelcontenedor = New System.Windows.Forms.Panel()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.horayfecha = New System.Windows.Forms.Timer(Me.components)
        Me.Panelcabecera.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelmenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelcontenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panelcabecera
        '
        Me.Panelcabecera.BackColor = System.Drawing.Color.Gray
        Me.Panelcabecera.Controls.Add(Me.PictureBox1)
        Me.Panelcabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelcabecera.Location = New System.Drawing.Point(0, 0)
        Me.Panelcabecera.Name = "Panelcabecera"
        Me.Panelcabecera.Size = New System.Drawing.Size(1100, 32)
        Me.Panelcabecera.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1063, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panelmenu
        '
        Me.Panelmenu.BackColor = System.Drawing.Color.Silver
        Me.Panelmenu.Controls.Add(Me.Button6)
        Me.Panelmenu.Controls.Add(Me.Button5)
        Me.Panelmenu.Controls.Add(Me.Button4)
        Me.Panelmenu.Controls.Add(Me.Label2)
        Me.Panelmenu.Controls.Add(Me.Label1)
        Me.Panelmenu.Controls.Add(Me.PictureBox2)
        Me.Panelmenu.Controls.Add(Me.Button3)
        Me.Panelmenu.Controls.Add(Me.Button2)
        Me.Panelmenu.Controls.Add(Me.Button1)
        Me.Panelmenu.Controls.Add(Me.btn_especialidad)
        Me.Panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelmenu.Location = New System.Drawing.Point(0, 32)
        Me.Panelmenu.Name = "Panelmenu"
        Me.Panelmenu.Size = New System.Drawing.Size(200, 548)
        Me.Panelmenu.TabIndex = 1
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(28, 471)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(155, 43)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Ingresos"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(28, 413)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(155, 43)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Tareas"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(28, 348)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(155, 43)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Autos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Taller"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(28, 219)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 43)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Propietarios"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(28, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 43)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Repuestos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(28, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Operarios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_especialidad
        '
        Me.btn_especialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_especialidad.Location = New System.Drawing.Point(28, 92)
        Me.btn_especialidad.Name = "btn_especialidad"
        Me.btn_especialidad.Size = New System.Drawing.Size(155, 43)
        Me.btn_especialidad.TabIndex = 0
        Me.btn_especialidad.Text = "Especialidades"
        Me.btn_especialidad.UseVisualStyleBackColor = True
        '
        'Panelcontenedor
        '
        Me.Panelcontenedor.Controls.Add(Me.lblfecha)
        Me.Panelcontenedor.Controls.Add(Me.lblhora)
        Me.Panelcontenedor.Controls.Add(Me.Label4)
        Me.Panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelcontenedor.Location = New System.Drawing.Point(200, 32)
        Me.Panelcontenedor.Name = "Panelcontenedor"
        Me.Panelcontenedor.Size = New System.Drawing.Size(900, 548)
        Me.Panelcontenedor.TabIndex = 2
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(55, 452)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(131, 44)
        Me.lblfecha.TabIndex = 13
        Me.lblfecha.Text = "Fecha"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(55, 390)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(104, 44)
        Me.lblhora.TabIndex = 12
        Me.lblhora.Text = "Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(235, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(431, 44)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Bienvenido al taller x"
        '
        'horayfecha
        '
        Me.horayfecha.Enabled = True
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 580)
        Me.Controls.Add(Me.Panelcontenedor)
        Me.Controls.Add(Me.Panelmenu)
        Me.Controls.Add(Me.Panelcabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panelcabecera.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelmenu.ResumeLayout(False)
        Me.Panelmenu.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelcontenedor.ResumeLayout(False)
        Me.Panelcontenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panelcabecera As Panel
    Friend WithEvents Panelmenu As Panel
    Friend WithEvents Panelcontenedor As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_especialidad As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents lblfecha As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents horayfecha As Timer
End Class
