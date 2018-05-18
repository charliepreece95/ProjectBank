<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <a href="AppointmentManagement.aspx"><div class="return">
        <span>&#8592;</span><p>Return</p>
    </div></a>
    <div class="container">
        <div class="Options">
            <select id="FilterBy" name="FilterBy" class="button">
                <option value="" disabled selected">Filter By...</option>
                <option value="Appointment#">Appointment ID</option>
                <option value="Location">Location</option>
                <option value="BookingDate">Booking date</option>
                <option value="Status">Status</option>
            </select>
            <input type="submit" value="Filter" class="button" />
            <button id="ReinstateButton" onclick="reinstateConfirm()" class="button">Reinstate Selected</button>
            <button id="deleteButton" onclick="deletePermConfirm()" class="button">Permanently Delete Selected</button>
        </div>
        <div class="StaffList">
            <input id="FuzSearch" class="button" type="text" name="Search" placeholder="Search Appointment ID" />
            <input type="submit" id="searchButton" class="button" name="Search" value="Search" />
            <table class="archivedStaff">
                <caption>Archived Appointments</caption>
                <tr class="tableHead">
                    <td>Appointment#</td>
                    <td>Client#</td>
                    <td>Title</td>
                    <td>Staff member present</td>
                    <td>Location</td>
                    <td>Booking Date</td>
                    <td>Status</td>
                </tr>
                <tr>
                    <td>1</td>
                    <td>2</td>
                    <td>Jaguar landrover website</td>
                    <td>John</td>
                    <td>Birmingham Office</td>
                    <td>12/08/2016</td>
                    <td>Complete</td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>5</td>
                    <td>IEM server</td>
                    <td>Bob</td>
                    <td>Leicester Office</td>
                    <td>12/02/2016</td>
                    <td>Complete</td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>7</td>
                    <td>Triumph website</td>
                    <td>Jim</td>
                    <td>Birmingham Office</td>
                    <td>12/06/2016</td>
                    <td>Cancelled</td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>

