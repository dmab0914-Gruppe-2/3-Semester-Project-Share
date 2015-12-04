<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/MainMaster.master" AutoEventWireup="true" CodeFile="Projects.aspx.cs" Inherits="Projects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>Projects</h1>
    <br />
    <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
            <div id="ProjectList">               
                <h2><a href='<%# DataBinder.Eval(Container.DataItem,"Id", "Project.aspx?ID={0}") %>'><%# DataBinder.Eval(Container.DataItem, "Title") %></a>  </h2>
                <br />
                <p><%# DataBinder.Eval(Container.DataItem, "Description") %></p>
                <hr />
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>

