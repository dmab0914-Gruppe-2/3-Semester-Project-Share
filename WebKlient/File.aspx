<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpages/MainMaster.master" AutoEventWireup="true" CodeFile="File.aspx.cs" Inherits="File" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="ProjectInfo">
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource2">
            <ItemTemplate>
                <h1><%# DataBinder.Eval(Container.DataItem, "Title") %><asp:Label ID="lblFileID" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "id") %>' Visible="false"></asp:Label></h1>
                <hr />
                <p><%# DataBinder.Eval(Container.DataItem, "description") %></p>
            </ItemTemplate>
        </asp:Repeater>
        <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" SelectMethod="getFileById" TypeName="FileService.FileUpLoadServiceClient">
            <SelectParameters>
                <asp:QueryStringParameter QueryStringField="ID" DefaultValue="1" Name="fileID" Type="Int32"></asp:QueryStringParameter>
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
    <div id="FileComments">
        <h4>File Comments</h4>
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Time") %>'></asp:Label> : <asp:Label ID="Label2" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Sender") %>'></asp:Label>
                <br />
                <asp:Label ID="Label3" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Message") %>'></asp:Label>
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>

