Imports System.Runtime.InteropServices
Public Class Frmmain









    Private Sub EspecialidadesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Frmespecialidades.ShowDialog()

    End Sub

    Private Sub PropietariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmPropietarios.ShowDialog()

    End Sub

    Private Sub RepuestosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmRepuestos.ShowDialog()

    End Sub

    Private Sub OperariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmOperarios.ShowDialog()

    End Sub

    Private Sub Panelcabecera_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()


    End Sub

    Private Sub Panelcabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles Panelcabecera.MouseMove

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_especialidad.Click
        Frmespecialidades.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmRepuestos.Show()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frmpropietarios As New FrmPropietarios
        frmpropietarios.Show()




    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FrmOperarios.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Panelcontenedor_Paint(sender As Object, e As PaintEventArgs) Handles Panelcontenedor.Paint

    End Sub

    Private Sub horayfecha_Tick(sender As Object, e As EventArgs) Handles horayfecha.Tick
        lblhora.Text = DateTime.Now.ToString("hh:mm:ss")
        lblfecha.Text = DateTime.Now.ToLongDateString()



    End Sub

    Private Sub Panelmenu_Paint(sender As Object, e As PaintEventArgs) Handles Panelmenu.Paint

    End Sub

    Private Sub Panelcabecera_Paint_1(sender As Object, e As PaintEventArgs) Handles Panelcabecera.Paint

    End Sub
End Class