<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <a href="Default.aspx"><div class="return">
        <span>&#8592;</span><p>Return</p>
    </div></a>
    <div class="container">
           <div class="Options">
                <a href="AddStaff.aspx" class="button"><div>Add</div></a>
                <a href="EditStaff.aspx" class="button"><div>Edit</div></a>
                <a href="ArchiveStaff.aspx" class="button"><div>View Archived</div></a>

            <button id="ArchiveButton" class="button">Archive Selected</button>
            <select id="FilterBy" name="FilterBy" class="button">
                <option value="" disabled selected>Filter By...</option>
                <option value="Name">Name</option>
                <option value="Position">Position</option>
            </select>
            <input type="submit" value="Filter" class="button" />
          </div>

        <div class="StaffList">
            <input type="submit" id="searchButton" class="button" name="Search" value="Search" />
            <input id="FuzSearch" class="button" type="text" name="Search" placeholder="Search Here..." />
                <table class="allStaff">
                <caption>Staff Management</caption>
                <tr class="tableHead">
                <td>StaffNo</td>
                <td>First Name</td>
                <td>Last Name</td>
                <td>Tele Num</td>
                <td>Email</td>
                <td>Position</td>
                </tr>


                <%
                    ClassLibrary.clsStaffCollection StaffList = new ClassLibrary.clsStaffCollection();
                    Int32 Index = 0;
                    Int32 RecordCount = StaffList.Count;
                    while (Index < RecordCount)
                    {
                        %>
                <tr>
                    <td><% Response.Write(StaffList.StaffList[Index].StaffNo);  %></td>
                    <td><% Response.Write(StaffList.StaffList[Index].FirstName);  %></td>
                    <td><% Response.Write(StaffList.StaffList[Index].LastName);  %></td>
                    <td><% Response.Write(StaffList.StaffList[Index].TeleNo);  %></td>
                    <td><% Response.Write(StaffList.StaffList[Index].Email);  %></td>
                    <td><% Response.Write(StaffList.StaffList[Index].Position);  %></td>
                </tr>
            <%
                    Index++;
                }

                 %>
            </table>               
        </div>
    </div>
</asp:Content>

