Imports YTDownload
Imports System.Windows.Forms

Public Class TestForm


    Dim title As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim msgboxTxt As String = ""

        Dim YTDl As New YTDownload(TextBox1.Text)
        title = YTDl.getTitle()

        msgboxTxt += title & vbCrLf
        Dim retUrls As Dictionary(Of String, String) = YTDl.GetAllUrls

        Dim dT As New DataTable
        dT.Columns.Add("URL")
        dT.Columns.Add("Link")
       
        For Each rUrl In retUrls

            Dim dr As DataRow = dT.NewRow
            dr(0) = rUrl.Value
            dr(1) = rUrl.Key

            dT.Rows.Add(dr)
            dT.AcceptChanges()

        Next

        DataGridView1.DataSource = dT



    End Sub

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class