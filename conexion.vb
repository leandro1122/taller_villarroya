Module conexion
    Public conexion As New SqlClient.SqlConnection("Data Source=LABP-5\SQLEXPRESS;Initial Catalog=taller_villarroya;User ID=sa; password=2022")
    Public cmd As New SqlClient.SqlCommand
    Public dr As SqlClient.SqlDataReader
    Public Sub conectar()
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module