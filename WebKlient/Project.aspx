<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/MainMaster.master" AutoEventWireup="true" CodeFile="Project.aspx.cs" Inherits="Project" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource2">
        <ItemTemplate>
            <h1><%# DataBinder.Eval(Container.DataItem, "Title") %></h1>
            <hr />
            <p><%# DataBinder.Eval(Container.DataItem, "description") %></p>
        </ItemTemplate>
    </asp:Repeater>

    <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" SelectMethod="GetProject" TypeName="ProjectService.ProjectServiceClient">
        <SelectParameters>
            <asp:QueryStringParameter QueryStringField="ID" DefaultValue="1" Name="id" Type="Int32"></asp:QueryStringParameter>
        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>


