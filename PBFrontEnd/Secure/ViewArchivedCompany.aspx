<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>
    <%--Master Page Link--%>
    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <%--Link back to CompanyMangement page--%>
     <a href="CompanyManagement.aspx"><div class="return">
         <span>&#8592;</span><p>Return</p>
     </div></a>
     
    <%--Company table that holds an existing record--%>
    <div class="container4Company">
         <div class="CompanyList1">
              <input id="FuzSearch4Company" class="button" type="text" name="Search" placeholder="Search Here..." />
              <input type="submit" id="searchButton4Company" class="button" name="Search" value="GO" />
             <h1 id="title">View Archived Companies</h1>
             <table class="AddResultsTable4Company">             
                 <tr class="tableHead4Company">
                     <%--Table headings--%>
                     <td>CompanyID</td>
                     <td>Company Name</td>
                     <td>Address</td>
                     <td>Postcode</td>
                     <td>Tele Num</td>
                     <td>Email</td>
                     <td>Description</td>
                 </tr>
                 <tr>
                     <%--Example of a data entry--%>
                     <td>4</td>
                     <td>Leicester Plumbing</td>
                     <td>47 Some Address Road</td>
                     <td>LE2 FFS</td>
                     <td>07123456789</td>
                     <td>LeiPlumbing@hotmail.co.uk</td>
                     <td>...</td>
                 </tr>
                  <tr>
                     <%--Example of a data entry--%>
                     <td>21</td>
                     <td>DJ Productions</td>
                     <td>47 Some Address Road</td>
                     <td>LE2 FFS</td>
                     <td>07123456789</td>
                     <td>DjProd@hotmail.co.uk</td>
                     <td>...</td>
                 </tr>
             </table>
         </div> 
    </div>
          
      <%--Buttons for redirection--%>         
     <div class="CompanyOnClickButtons2">
              <a href="DeleteRestoreCompany.aspx"><input type="button" id="OptionButton4Company" class="button" name="options" value="Options" /></a>
              <a href="CompanyManagement.aspx"><input type="button" id="exitButton4Company3" class="button" name="Exit" value="Exit" /></a>
         </div>

</asp:Content>

