
Imports System.Data.SqlClient

Public Class UserControlsettings

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlConnection1 As New SqlConnection(mycon)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        cmd.CommandText = "resetBill_no"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        reader = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.

        sqlConnection1.Close()
    End Sub
End Class
