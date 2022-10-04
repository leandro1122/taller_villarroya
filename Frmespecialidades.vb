Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.ComponentModel

Public Class Frmespecialidades
    Dim conexion As SqlConnection
    Dim comando As SqlCommand


    Private Sub EspecialidadesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EspecialidadesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Taller_villarroyaDataSet)

    End Sub

    Private Sub Frmespecialidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Taller_villarroyaDataSet.especialidades' Puede moverla o quitarla según sea necesario.
        Me.EspecialidadesTableAdapter.Fill(Me.Taller_villarroyaDataSet.especialidades)
        txt_Especialidad.Select()

    End Sub
    Sub mostrar()
        Dim conexion As SqlConnection = New SqlConnection("Data Source=LABP-5\SQLEXPRESS;Initial Catalog=taller_villarroya;User ID=sa; password=2022")
        conexion.Open()
        Dim da As New SqlDataAdapter("select * from especialidades", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        dgvespecialidades.DataSource = ds.Tables(0)
        conexion.Close()

    End Sub


    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim conexion As SqlConnection = New SqlConnection("Data Source=LABP-5\SQLEXPRESS;Initial Catalog=taller_villarroya;User ID=sa; password=2022")
        conexion.Open()
        Dim consulta As String = "insert into especialidades(especialidad)values('" & txt_Especialidad.Text & "' )"
        comando = New SqlCommand(consulta, conexion)
        comando.ExecuteNonQuery()


        MsgBox("Se registro correctamente")
        mostrar()
        txt_Especialidad.Clear()




        conexion.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgvespecialidades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim conexion As SqlConnection = New SqlConnection("Data Source=LABP-5\SQLEXPRESS;Initial Catalog=taller_villarroya;User ID=sa; password=2022")
        conexion.Open()
        Dim consulta As String = "delete from especialidades where id_especialidad = '" & txt_eliminar.Text & "' "
        comando = New SqlCommand(consulta, conexion)
        comando.ExecuteNonQuery()


        mostrar()
        MsgBox("Datos eliminados correctamente")
        txt_eliminar.Clear()






        conexion.Close()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs)
        mostrar()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvespecialidades.CellContentClick

    End Sub

    Private Sub txt_Especialidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Especialidad.KeyDown
        If e.KeyData = Keys.Enter Then

        End If
    End Sub

    Private Sub Frmespecialidades_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


    End Sub
End Class