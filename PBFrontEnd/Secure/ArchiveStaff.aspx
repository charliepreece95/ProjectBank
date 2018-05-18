<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <a href="StaffManagement.aspx"><div class="return">
        <span>&#8592;</span><p>Return</p>
    </div></a>
    <div class="container">
        <div class="Options">
            <select id="FilterBy" name="FilterBy" class="button">
                <option value="" disabled selected">Filter By...</option>
                <option value="Name">Name</option>
                <option value="Position">Position</option>
            </select>
            <input type="submit" value="Filter" class="button" />
            <button id="ReinstateButton" onclick="reinstateConfirm()" class="button">Reinstate Selected</button>
            <button id="deleteButton" onclick="deletePermConfirm()" class="button">Permanently Delete Selected</button>
        </div>
        <div class="StaffList">
            <input id="FuzSearch" class="button" type="text" name="Search" placeholder="Search Staff Member" />
            <input type="submit" id="searchButton" class="button" name="Search" value="Search" />
            <table class="archivedStaff">
                <caption>Archived Staff</caption>
                <tr class="tableHead">
                    <td>Staff#</td>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>Tele Num</td>
                    <td>Email</td>
                    <td>Position</td>
                </tr>
                <tr>
                    <td>1</td>
                    <td>James</td>
                    <td>Blake</td>
                    <td>0783535000</td>
                    <td>james@email.com</td>
                    <td>Manager</td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>Susan</td>
                    <td>Smith</td>
                    <td>045345360</td>
                    <td>susan@email.com</td>
                    <td>Worker</td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>Tom</td>
                    <td>Smith</td>
                    <td>12345678901</td>
                    <td>tom@email.com</td>
                    <td>Worker</td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>

