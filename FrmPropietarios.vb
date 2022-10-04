Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.ComponentModel

Public Class FrmPropietarios
    Dim conexion As SqlConnection
    Dim comando As SqlCommand

    Private Sub Propietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Taller_villarroyaDataSet.propietarios' Puede moverla o quitarla según sea necesario.
        Me.PropietariosTableAdapter.Fill(Me.Taller_villarroyaDataSet.propietarios)
        txt_prop.Select()

    End Sub

    Sub mostrar()
        Dim conexion As SqlConnection = New SqlConnection("Data Source=LABP-5\SQLEXPRESS;Initial Catalog=taller_villarroya;User ID=sa; password=2022")
        conexion.Open()
        Dim da As New SqlDataAdapter("select * from propietarios", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        dgvprop.DataSource = ds.Tables(0)
        conexion.Close()
    End Sub
    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click


        Dim conexion As SqlConnection = New SqlConnection("Data Source=LABP-5\SQLEXPRESS;Initial Catalog=taller_villarroya;User ID=sa; password=2022")
        conexion.Open()
        Dim consulta As String = "insert into propietarios(nombre_prop,telefono_prop)values('" & txt_prop.Text & "', '" & txt_numero.Text & "' )"

        comando = New SqlCommand(consulta, conexion)
        comando.ExecuteNonQuery()


        MsgBox("Se registro correctamente")
        mostrar()




        conexion.Close()
    End Sub

    Private Sub txt_eliminar_TextChanged(sender As Object, e As EventArgs) Handles txt_eliminar.TextChanged

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim conexion As SqlConnection = New SqlConnection("Data Source=LABP-5\SQLEXPRESS;Initial Catalog=taller_villarroya;User ID=sa; password=2022")
        conexion.Open()
        Dim consulta As String = "delete from propietarios where id_propietario = '" & txt_eliminar.Text & "' "
        comando = New SqlCommand(consulta, conexion)
        comando.ExecuteNonQuery()


        mostrar()
        MsgBox("Datos eliminados correctamente")
        txt_eliminar.Clear()
        -
    End Sub

    Private Sub FrmPropietarios_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing




    End Sub

End Class