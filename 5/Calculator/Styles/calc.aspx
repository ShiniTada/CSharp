<%@ Page Title="" Language="C#" MasterPageFile="~/Styles/Site1.Master" AutoEventWireup="true" CodeBehind="calc.aspx.cs" Inherits="Calcolatrice.Styles.calc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="centro">
        <asp:TextBox ID="TextBox1" runat="server" CssClass="text" ReadOnly="true" Text="0"></asp:TextBox><br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="1" CssClass="bottone" 
                onclick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="2" CssClass="bottone" 
                onclick="Button2_Click"/>
            <asp:Button ID="Button3" runat="server" Text="3" CssClass="bottone" 
                onclick="Button3_Click"/>
            <asp:Button ID="Button4" runat="server" Text="+" CssClass="bottone" 
                onclick="Button4_Click"/><br />
            <asp:Button ID="Button5" runat="server" Text="4" CssClass="bottone" 
                onclick="Button5_Click"/>
            <asp:Button ID="Button6" runat="server" Text="5" CssClass="bottone" 
                onclick="Button6_Click"/>
            <asp:Button ID="Button7" runat="server" Text="6" CssClass="bottone" 
                onclick="Button7_Click"/>
            <asp:Button ID="Button8" runat="server" Text="-" CssClass="bottone" 
                onclick="Button8_Click"/><br />
            <asp:Button ID="Button9" runat="server" Text="7" CssClass="bottone" 
                onclick="Button9_Click"/>
            <asp:Button ID="Button10" runat="server" Text="8" CssClass="bottone" 
                onclick="Button10_Click"/>
            <asp:Button ID="Button11" runat="server" Text="9" CssClass="bottone" 
                onclick="Button11_Click"/>
            <asp:Button ID="Button12" runat="server" Text="x" CssClass="bottone" 
                onclick="Button12_Click"/><br />
            <asp:Button ID="Button13" runat="server" Text="C.E." CssClass="bottone" 
                onclick="Button13_Click"/>
            <asp:Button ID="Button14" runat="server" Text="0" CssClass="bottone" 
                onclick="Button14_Click"/>
            <asp:Button ID="Button15" runat="server" Text="=" CssClass="bottone" 
                onclick="Button15_Click"/>
            <asp:Button ID="Button16" runat="server" Text=":" CssClass="bottone" 
                onclick="Button16_Click"/>
        </div>
    </div>
</asp:Content>
