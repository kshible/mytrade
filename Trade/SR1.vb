Public Class SR1

    Private Sub txtGetRecords_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGetRecords.TextChanged
        mysales.txt_receve.Text = txtGetRecords.Text
    End Sub
End Class