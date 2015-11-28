<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/MainMaster.master" AutoEventWireup="true" CodeFile="Projects.aspx.cs" Inherits="Projects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>Projects</h1>
    <br />
    <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
            <h2> <a href='<%# DataBinder.Eval(Container.DataItem,"Id", "Project.aspx?ID={0}") %>'><%# DataBinder.Eval(Container.DataItem, "Title") %></a>  </h2>
                    <%--<h2><a href='<%# Eval("NewsID", "NewsDetail.aspx?ID={0}") %>'><%# Eval("NewsTitle") %></a></h2>
                    <p>
                        <%# Eval("NewsText") %><br />
                        <%# Eval("NewsDate") %>
                    </p>
                    <asp:Image ID="newsSep" CssClass="newsSEP" ImageUrl="~/Images/separator.png" runat="server" />--%>
                </ItemTemplate>
    </asp:ListView>
</asp:Content>

