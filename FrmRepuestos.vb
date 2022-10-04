Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.ComponentModel

Public Class FrmRepuestos

    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvrepuestos.CellContentClick

    End Sub

    Private Sub FrmRepuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Taller_villarroyaDataSet.repuestos' Puede moverla o quitarla según sea necesario.
        Me.RepuestosTableAdapter.Fill(Me.Taller_villarroyaDataSet.repuestos)
        txt_descripcion.Select()


    End Sub
    Sub mostrar()
        Dim conexion As SqlConnection = New SqlConnection("Data Source=LABP-5\SQLEXPRESS;Initial Catalog=taller_villarroya;User ID=sa; password=2022")
        conexion.Open()
        Dim da As New SqlDataAdapter("select * from repuestos", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        dgvrepuestos.DataSource = ds.Tables(0)
        conexion.Close()
    End Sub
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim conexion As SqlConnection = New SqlConnection("Data Source=LABP-5\SQLEXPRESS;Initial Catalog=taller_villarroya;User ID=sa; password=2022")
        conexion.Open()
        Dim consulta As String = "insert into repuestos(descripcion_rep,importe_rep)values('" & txt_descripcion.Text & "', '" & txt_importe.Text & "' )"

        comando = New SqlCommand(consulta, conexion)
        comando.ExecuteNonQuery()

        MsgBox("Se registro correctamente")
        mostrar()
        txt_descripcion.Clear()
        txt_importe.Clear()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim conexion As SqlConnection = New SqlConnection("Data Source=LABP-5\SQLEXPRESS;Initial Catalog=taller_villarroya;User ID=sa; password=2022")
        conexion.Open()
        Dim consulta As String = "delete from repuestos where cod_repuesto = '" & txt_eliminar.Text & "' "
        comando = New SqlCommand(consulta, conexion)
        comando.ExecuteNonQuery()


        mostrar()
        MsgBox("Datos eliminados correctamente")
        txt_eliminar.Clear()
    End Sub

    Private Sub FrmRepuestos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


    End Sub
End Class