<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <a href="Default.aspx"><div class="return">
        <span>&#8592;</span><p>Return</p>
    </div></a>
    <div class="container">
           <div class="Options">
                <a href="AddAppointment.aspx" class="button"><div>Add</div></a>
                <a href="EditAppointment.aspx" class="button"><div>Edit</div></a>
                <a href="ArchiveAppointment.aspx" class="button"><div>View Archived</div></a>

            <button id="ArchiveButton" class="button">Archive Selected</button>
            <select id="FilterBy" name="FilterBy" class="button">
                <option value="" disabled selected>Filter By...</option>
                <option value="Title">Title</option>
                <option value="Location">Location</option>
                <option value="Booking Date">Booking Date</option>
            </select>
            <input type="submit" value="Filter" class="button" />
          </div>

            <div class="StaffList">
            <input type="submit" id="searchButton" class="button" name="Search" value="Search" />
            <input id="FuzSearch" class="button" type="text" name="Search" placeholder="Search Here..." />
                <table class="allStaff">
                <caption>Appointment Management</caption>
                <tr class="tableHead">
                <td>AppointmentNo</td>
                <td>ClientNo</td>
                <td>AppointmentTitle</td>
                <td>StaffNo</td>
                <td>Location</td>
                <td>BookingDate</td>
                <td>Status</td>
                </tr>

        
                <%
                   ClassLibrary.clsAppointmentCollection AppointmentList = new ClassLibrary.clsAppointmentCollection();
                    Int32 Index = 0;
                    Int32 RecordCount = AppointmentList.Count;
                    while (Index < RecordCount)
                    {
                        %>
                <tr>
                    <td><% Response.Write(AppointmentList.AppointmentList[Index].AppointmentNo);  %></td>
                    <td><% Response.Write(AppointmentList.AppointmentList[Index].ClientNo);  %></td>
                    <td><% Response.Write(AppointmentList.AppointmentList[Index].AppointmentTitle);  %></td>
                    <td><% Response.Write(AppointmentList.AppointmentList[Index].StaffNo);  %></td>
                    <td><% Response.Write(AppointmentList.AppointmentList[Index].Location);  %></td>
                    <td><% Response.Write(AppointmentList.AppointmentList[Index].BookingDate);  %></td>
                    <td><% Response.Write(AppointmentList.AppointmentList[Index].Status);  %></td>
                </tr>
            <%
                    Index++;
                }

                 %>
           </table>
        </div>
    </div>
</asp:Content>


