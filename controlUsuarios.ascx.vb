Public Class WebUserControl1
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        For Each elemento As String In Global_asax.listaAlumnos
            If Not ListBox1.Items.Contains(New ListItem(elemento)) Then
                ListBox1.Items.Add(New ListItem(elemento))
            End If
        Next
        Label1.Text = Global_asax.listaAlumnos.Count.ToString
        For Each elemento As String In Global_asax.listaProfes
            If Not ListBox2.Items.Contains(New ListItem(elemento)) Then
                ListBox2.Items.Add(New ListItem(elemento))
            End If
        Next
        Label2.Text = Global_asax.listaProfes.Count.ToString
        ListBox1.Visible = True
        ListBox2.Visible = True
    End Sub

    Protected Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
End Class