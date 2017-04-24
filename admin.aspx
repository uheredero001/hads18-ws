<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="admin.aspx.vb" Inherits="WebApplication1.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Hola administrador<br />
        <br />
        Usuarios en la bd:<br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="email" DataSourceID="DatosUsuarios">
            <Columns>
                <asp:BoundField DataField="email" HeaderText="email" ReadOnly="True" SortExpression="email" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="pregunta" HeaderText="pregunta" SortExpression="pregunta" />
                <asp:BoundField DataField="respuesta" HeaderText="respuesta" SortExpression="respuesta" />
                <asp:BoundField DataField="dni" HeaderText="dni" SortExpression="dni" />
                <asp:CheckBoxField DataField="confirmado" HeaderText="confirmado" SortExpression="confirmado" />
                <asp:BoundField DataField="grupo" HeaderText="grupo" SortExpression="grupo" />
                <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" />
                <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="DatosUsuarios" runat="server" ConnectionString="<%$ ConnectionStrings:HADS18_usuariosConnectionString %>" SelectCommand="SELECT * FROM [Usuarios]"></asp:SqlDataSource>
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/salir.jpg" />
    
    </div>
    </form>
</body>
</html>
