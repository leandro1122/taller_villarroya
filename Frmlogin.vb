Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Frmlogin
    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click



        Dim conexion As SqlConnection = New SqlConnection("Data Source=LABP-5\SQLEXPRESS;Initial Catalog=taller_villarroya;User ID=sa; password=2022")
        Dim cmd As SqlCommand = New SqlCommand("select * from usuario where usuario='" + txt_usuario.Text + "' and contraseña = '" + txt_password.Text + "' ", conexion)
        Using sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim table As DataTable = New DataTable()
            sda.Fill(table)
            If (table.Rows.Count > 0) Then

                Frmmain.ShowDialog()
                Me.Close()


            Else
                MessageBox.Show("Usuario o contraseña erroneos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Me.txt_usuario.Clear()
                Me.txt_password.Clear()
                Me.txt_usuario.Focus()
            End If
        End Using
    End Sub

    Private Sub Frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_usuario.Select()
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_password.PasswordChar = ""
        ElseIf CheckBox1.Checked = False Then
            txt_password.PasswordChar = "*"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 
        Me.Close()


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Frmmain.ShowDialog()

    End Sub
End Class
