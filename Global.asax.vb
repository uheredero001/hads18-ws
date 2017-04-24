Imports System.Web.SessionState

Public Class Global_asax
    Inherits System.Web.HttpApplication
    Public Shared listaProfes As List(Of String)
    Public Shared listaAlumnos As List(Of String)

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la aplicación
        listaAlumnos = New List(Of String)
        listaProfes = New List(Of String)
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la sesión

    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al comienzo de cada solicitud
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al intentar autenticar el uso
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se produce un error
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la sesión
        If (Session("rol").Equals("P")) Then
            listaProfes.Remove(Session("user"))
        Else
            listaAlumnos.Remove(Session("user"))
        End If
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la aplicación
    End Sub

    Public Shared Function getAlumnos() As List(Of String)
        Return listaAlumnos
    End Function

    Public Shared Function getProfes() As List(Of String)
        Return listaProfes
    End Function
End Class