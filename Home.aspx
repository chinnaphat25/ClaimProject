﻿<%@ Page Title="WebClientPrint 2.0 for ASP.NET Demo" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">

<h2>Available Samples</h2>

<table class="table table-bordered">
    <tr>
        <td><a href="DemoPrintCommands.aspx" class="btn btn-large btn-info" style="width:100px;height:35px;">Print Raw Commands</a></td>
        <td>In this demo you'll be able to specify the printer commands you want to send to a client printer. You must specify the commands that the target printer can handle. Common printer commands are ESC/P, PCL, ZPL, EPL, DPL, IPL, EZPL, and so on.</td>
    </tr>
    <tr>
        <td><a href="DemoPrintFile.aspx" class="btn btn-large btn-info" style="width:100px;height:35px;">Print Files</a></td>
        <td>In this demo you'll be able to specify a file like PDF, TXT, MS Word DOC, MS Excel XLS, JPG & PNG images, multipage TIF; that you want to print to a client printer <strong>without displaying any Print dialog!</strong>.</td>
    </tr>
</table>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="script" Runat="Server">
</asp:Content>

