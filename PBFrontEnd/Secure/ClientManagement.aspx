<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <a href="Default.aspx"><div class="return">
        <span>&#8592;</span><p>Return</p>
    </div></a>
    <div class="container">
           <div class="Options">
                <a href="AddClient.aspx" class="button"><div>Add</div></a>
                <a href="EditClient.aspx" class="button"><div>Edit</div></a>
                <a href="ArchiveClient.aspx" class="button"><div>View Archived</div></a>

            <button id="ArchiveButton" class="button">Archive Selected</button>
            <select id="FilterBy" name="FilterBy" class="button">
                <option value="" disabled selected>Filter By...</option>
                <option value="Title">Title</option>
                <option value="Location">Location</option>
                <option value="Booking Date">Booking Date</option>
            </select>
            <input type="submit" value="Filter" class="button" />
          </div>

            <div class="ClientList">
            <input type="submit" id="searchButton" class="button" name="Search" value="Search" />
            <input id="FuzSearch" class="button" type="text" name="Search" placeholder="Search Here..." />
                <table class="allStaff">
                <caption>Client Management</caption>
                <tr class="tableHead">
                <td>Client#</td>
                <td>CompanyNo</td>
                <td>First Name</td>
                <td>Last Name</td>
                <td>Position</td>
                <td>Tele Num</td>
                <td>Fax Num</td>
                <td>Email</td>
               
                </tr>

        
                <%
                    ClassLibrary.clsClientCollection ClientList = new ClassLibrary.clsClientCollection();
                    Int32 Index = 0;
                    Int32 RecordCount = ClientList.Count;
                    while (Index < RecordCount)
                    {
                        %>
                <tr>
                    <td><% Response.Write(ClientList.ClientList[Index].ClientNo);  %></td>
                    <td></td>
                    <td><% Response.Write(ClientList.ClientList[Index].CompanyNo);  %></td>
                    <td></td>
                    <td><% Response.Write(ClientList.ClientList[Index].FirstName);  %></td>
                    <td></td>
                    <td><% Response.Write(ClientList.ClientList[Index].LastName);  %></td>
                    <td></td>
                    <td><% Response.Write(ClientList.ClientList[Index].Position);  %></td>
                    <td></td>
                    <td><% Response.Write(ClientList.ClientList[Index].TelephoneNumber);  %></td>
                    <td></td>
                    <td><% Response.Write(ClientList.ClientList[Index].FaxNumber); %></td>
                    <td></td>
                    <td><% Response.Write(ClientList.ClientList[Index].Email);  %></td>
                    <td></td>
                </tr>
            <%
                    Index++;
                }

                 %>
           </table>
        </div>
    </div>
</asp:Content>


