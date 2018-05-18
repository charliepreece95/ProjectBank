<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <a href="StaffManagement.aspx"><div class="return">
        <span>&#8592;</span><p>Return</p>
    </div></a>
    <div class="container">
        <div class="Options">
            <input id="AddStaffID" type="text" value="3" class="button" />
            <label for="Staff#">Staff ID: </label>
            <br />
            <input type="text" value="Tom" class="button" />
            <label for="FirstName">First Name</label>
            <br />
            <input type="text" value="Smith" class="button" />
            <label for="LastName">Last Name</label>
            <br />
            <input type="text" value="12345678901" class="button" />
            <label for="TeleNum">Telephone Number</label>
            <br />
            <input type="text" value="tom@email.com" class="button" />
            <label for="Email">Email</label>
            <br />
            <select id="selectPosition" name="selectPosdition" class="button">
                <option value="" disabled selected>Select Position</option>
                <option value="Manager">Manager</option>
                <option value="Supervisor">Supervisor</option>
                <option value="Developer">Developer</option>
                <option value="Designer">Designer</option>
                <option value="Apprentice">Apprentice</option>
            </select>
            <label for="position">Position</label>
            <input type="submit" value="Save" class="button" onclick="UpdateConfirm()" />
        </div>
        <div class="StaffList">
            <table class="AddResultsTable">
                <caption>Edit "Tom Smith"</caption>
                <tr class="tableHead">
                    <td>Staff#</td>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>Tele Num</td>
                    <td>Email</td>
                    <td>Position</td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>Tom</td>
                    <td>Smith</td>
                    <td>12345678901</td>
                    <td>tom@email.com</td>
                    <td>Designer</td>
                </tr>
            </table>
    </div>
</asp:Content>

