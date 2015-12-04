<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/MainMaster.master" AutoEventWireup="true" CodeFile="Project.aspx.cs" Inherits="Project" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="ProjectInfo">
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
    </div>
    <div id="ProjectFileList">
        <h2>Files</h2>
        <asp:ListView ID="lwFiles" runat="server" DataSourceID="objGetFileList">
            <ItemTemplate>
                <a href='<%# DataBinder.Eval(Container.DataItem,"Id", "File.aspx?ID={0}") %>'> <div id="Projectfiles">
                    <h4><%# DataBinder.Eval(Container.DataItem, "Title") %></h4>
                    <p><%# DataBinder.Eval(Container.DataItem, "Description") %></p>
                    <hr />
                </div></a>
            </ItemTemplate>
        </asp:ListView>
        <asp:ObjectDataSource runat="server" ID="objGetFileList" SelectMethod="GetAllFilesForProject" TypeName="FileService.FileUpLoadServiceClient">
            <SelectParameters>
                <asp:QueryStringParameter QueryStringField="ID" DefaultValue="1" Name="projectId" Type="Int32"></asp:QueryStringParameter>
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>


