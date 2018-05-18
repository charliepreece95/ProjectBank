<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Login ID="Login1" runat="server" CreateUserText="Sign Up" CreateUserUrl="SignUp.aspx" DestinationPageUrl="Secure/Default.aspx"></asp:Login>


</asp:Content>

