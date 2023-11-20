<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_14112023_WebForm.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Form Elementleri</h1>
        <h2>TextBox</h2>
        <hr />
        <asp:TextBox ID="TextBox1" runat="server"  Width="105px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        <%--------------------------------%>
        <hr />
        <div>
            <h2> Checkbox</h2>
            <hr />
            <p> Kullandığınız programlama dillerini seçiniz</p>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="C#" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Pyhton"/>
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Java"/>
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Kotlin"/>
            <br />
            <asp:Button ID="btnCheckbox" runat="server" Text="Oku" OnClick="btnCheckbox_Click" />
            <br />
            <asp:Label ID="lblCheckbox" runat="server"></asp:Label>
        </div>
        

    </form>
</body>
</html>
