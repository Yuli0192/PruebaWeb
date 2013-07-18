<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
       
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        datos de la persona
    </h2>
    <p>
        <form>
            <label>Nombre</label><input type="text" id="txtNombre" name="txtNombre" runat="server"/>
            <label>Edad</label><input type="text" id="TxtEdad" name="txtEdad" runat="server"/>
            <asp:Button ID="bntRegistrar" class="bntRegistrar" runat="server" Text="Registrar" 
                onclick="bntRegistrar_Click" />
        </form>
    </p>
    <p>
        <asp:GridView ID="gvPersonas" runat="server" AutoGenerateColumns="False" 
            Height="141px" Width="381px">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" SortExpression="Id" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" 
                    SortExpression="nombre" />
                <asp:BoundField DataField="edad" HeaderText="edad" SortExpression="edad" />
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>
