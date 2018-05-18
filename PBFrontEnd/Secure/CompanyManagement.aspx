<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
      <!--Link back to CompanyMangement page-->
      <a href="Default.aspx"><div class="return">
         <span>&#8592;</span><p>Return</p>
     </div></a>
 
     <!--CompanyManagement Page where you use the buttons to navigate to other pages-->
     <div class="container">
            <div class="Options">
                 <a href="AddCompany.aspx" class="button"><div>Add</div></a>
                 <a href="EditCompany.aspx" class="button"><div>Edit</div></a>
                 <a href="ViewCompany.aspx" class="button"><div>View Company</div></a>
                 <button id="ArchiveButton" onclick="ArchiveCompanyConfirm()" class="button">Archive</button>
                 <a href="ViewArchivedCompany.aspx" class="button"><div>View Archived</div></a>
           </div>
 
          <!--Company table that holds existing records-->
         <div class="StaffList">
             <input id="FuzSearch" class="button" type="text" name="Search" placeholder="Search Here..." />
                 <input type="submit" id="searchButton" class="button" name="Search" value="GO" />
                     <h1 id="title">Company Management</h1>
                         <table class="allCompanies">
                              <tr class="tableHead4Company">
                                 <!--Table headings-->
                                 <td>CompanyID</td>
                                 <td>Company Name</td>
                                 <td>Address</td>
                                 <td>Post Code</td>
                                 <td>Tele Num</td>
                                 <td>Email</td>
                                 <td>Description</td>
                             </tr>
                           <tr>
                             
                <%
                   ClassLibrary.clsCompanyCollection CompanyList = new ClassLibrary.clsCompanyCollection();
                    Int32 Index = 0;
                    Int32 RecordCount = CompanyList.Count;
                    while (Index < RecordCount)
                    {
                        %>
                <tr>
                    <td><% Response.Write(CompanyList.CompanyList[Index].CompanyID);  %></td>
                    <td><% Response.Write(CompanyList.CompanyList[Index].CompanyName);  %></td>
                    <td><% Response.Write(CompanyList.CompanyList[Index].Address);  %></td>
                    <td><% Response.Write(CompanyList.CompanyList[Index].PostCode);  %></td>
                    <td><% Response.Write(CompanyList.CompanyList[Index].TeleNum);  %></td>
                    <td><% Response.Write(CompanyList.CompanyList[Index].Email);  %></td>
                    <td><% Response.Write(CompanyList.CompanyList[Index].Description);  %></td>
                </tr>
            <%
                    Index++;
                }

                 %>
                             </tr>
                      </table>
                  </div>
             </div>
 </asp:Content>



