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
             <h1 id="title1">View Company</h1>
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
                     <td>1</td>
                     <td>MJ Constructions</td>
                     <td>47 Some Address Road</td>
                     <td>LE2 FFS</td>
                     <td>07123456789</td>
                     <td>JohnSmith@hotmail.co.uk</td>
                     <td>...</td>
                 </tr>
             </table>
         </div> 
    </div>
      
     <%--Button for redirection--%>  
     <div class="CompanyOnClickButtons1">
              <a href="CompanyManagement.aspx"><input type="button" id="exitButton4Company1" class="button" name="Exit" value="Exit" /></a>
         </div>

</asp:Content>

