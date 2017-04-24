<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="controlUsuarios.ascx.vb" Inherits="WebApplication1.WebUserControl1" %>
Usuarios conectados:<br />
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getAlumnos" TypeName="WebApplication1.Global_asax"></asp:ObjectDataSource>
<br />
Alumnos:
<asp:Label ID="Label1" runat="server"></asp:Label>
<br />
<asp:ListBox ID="ListBox1" runat="server" DataTextField="Length" DataValueField="Length">
</asp:ListBox>
<br />
<asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="getProfes" TypeName="WebApplication1.Global_asax"></asp:ObjectDataSource>
<br />
Profesores:
<asp:Label ID="Label2" runat="server"></asp:Label>
<br />
<asp:ListBox ID="ListBox2" runat="server">
</asp:ListBox>
<p>
    &nbsp;</p>

