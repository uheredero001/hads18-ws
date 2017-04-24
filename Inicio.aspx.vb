
Imports System.Data.SqlClient
Imports System.Web.Security.FormsAuthentication

Public Class Inicio
    Inherits System.Web.UI.Page
    Private Shared datos As New accesodatosSQL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = datos.conectar()
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        datos.cerrarconexion()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String
        result = datos.comprobarLogin(TextBox1.Text, TextBox2.Text)
        If (result.Equals("Ok")) Then

            Session("user") = TextBox1.Text

            result = datos.rol(TextBox1.Text)
            Label3.Text = result
            If result.Equals("A") Then
                Session("rol") = "A"
                Global_asax.listaAlumnos.Add(Session("user"))
                SetAuthCookie("alumno", True)
                Response.Redirect("alumno/Alumno.aspx")
            Else
                Session("rol") = "P"
                Global_asax.listaProfes.Add(Session("user"))
                If (TextBox1.Text.Equals("vadillo@ehu.es")) Then
                    SetAuthCookie("vadillo", True)
                ElseIf (TextBox1.Text.Equals("admin@ehu.es")) Then
                    SetAuthCookie("admin", True)
                    Response.Redirect("admin.aspx")
                Else
                    SetAuthCookie("profesor", True)
                End If
                Response.Redirect("profe/Profesor.aspx")
            End If

        Else
            Label3.Text = "Error en login"
        End If

    End Sub
End Class