<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <a href="AppointmentManagement.aspx"><div class="return">
        <span>&#8592;</span><p>Return</p>
    </div></a>
    <div class="container">
        <div class="Options">
            <input id="AddAppointmentID" type="text" value="1" class="button" />
            <label for="Appointment#">Appointment ID: </label>
            <br />
            <input type="text" value="23" class="button" />
            <label for="Client#">Client ID</label>
            <br />
            <input type="text" value="Website" class="button" />
            <label for="Title">Title</label>
            <br />
            <input type="text" value="John" class="button" />
            <label for="StaffMember">Staff member</label>
            <br />
            <input type="text" value="Birmingham Office" class="button" />
            <label for="Location">Location</label>
            <br />
            <input type="text" value="12/02/2017" class="button" />
            <label for="BookingDate">Booking date</label>
            <br />
            <select id="selectPosition" name="Status" class="button">
                <option value="" disabled selected>Status</option>
                <option value="Pending">Pending</option>
                <option value="Cancelled">Cancelled</option>
                <option value="Complete">Complete</option>
            </select>
            <label for="Status">Status</label>
            <input type="submit" value="Save" class="button" onclick="UpdateConfirm()" />
        </div>
        <div class="StaffList">
            <table class="AddResultsTable">
                <caption>Edit "Appointment #1"</caption>
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
                    <td>12/02/2017</td>
                    <td>Pending</td>
                </tr>
            </table>
    </div>
  </div>
</asp:Content>

