<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>
    <%--Master Page Link--%>
 
<script runat  ="server">

    //event handler for the edit button 
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
         ClassLibrary.clsCompanyCollection Company = new ClassLibrary.clsCompanyCollection();
        //validation here
        Boolean OK = Company.ThisCompany.Valid(txtCompanyName.Text, txtAddress.Text, txtPostCode.Text, txtTeleNum.Text, txtEmail.Text, txtDescription.Text);
        //set some vars for the txt elements
        //Int32 CompanyID = Convert.ToInt32(txtCompanyID.Text);
        string CompanyName = txtCompanyName.Text;
        string Address = txtAddress.Text;
        string PostCode = txtPostCode.Text;
        string TeleNum = txtTeleNum.Text;
        string Email = txtEmail.Text;
        string Description = txtDescription.Text;
        //if the data is OK add it to the object
        if (OK == true)
        {
            //get the data entered by the user 
            //Company.ThisCompany.CompanyID = CompanyID;
            Company.ThisCompany.CompanyName = CompanyName;
            Company.ThisCompany.Address = Address;
            Company.ThisCompany.PostCode = PostCode;
            Company.ThisCompany.TeleNum = TeleNum;
            Company.ThisCompany.Email = Email;
            Company.ThisCompany.Description = Description;
            Company.Update();
            //redirect to company management if successful
            Response.Redirect("CompanyManagement.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "Please try again";
        }

    }
 
</script> 

    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <%--Link back to CompanyMangement page--%>
      <a href="CompanyManagement.aspx"><div class="return">
         <span>&#8592;</span><p>Return</p>
     </div></a>
 
      <%--Input text data fields--%>
     <!--Input boxes-->
    <div class="container">  
        <div class="OptionsApp">
            <!--
            <asp:TextBox ID="txtCompanyID" runat="server" Height="64px"></asp:TextBox>
            <label for="CompanyID">CompanyID</label>
            -->
            <br />
            <asp:TextBox ID="txtCompanyName" value="MJ Constructions" runat="server" class="button"></asp:TextBox>
            <label for="CompanyName">Company Name</label>
            <br />
            <asp:TextBox ID="txtAddress" value="47 Some Address Road" runat="server" class="button"></asp:TextBox>
            <label for="Address">Address</label>
            <br />
            <asp:TextBox ID="txtPostCode" value="LE2 FFS" runat="server" class="button"></asp:TextBox>
            <label for="PostCode">Post Code</label>
            <br />
            <asp:TextBox ID="txtTeleNum" value="07123456789" runat="server" CssClass="button"></asp:TextBox>
            <label for="TeleNum">Telephone Number</label>
            <br />
            <asp:TextBox ID="txtEmail" value="JohnSmith@hotmail.co.uk"  runat="server" CssClass="button"></asp:TextBox>
            <label for="Email">Email</label>
            <br />
            <asp:TextBox ID="txtDescription" value="..." runat="server" CssClass="button"></asp:TextBox>
            <label for="Description">Description</label>
            <br />  
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" CssClass="button" />
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label> 
            
        </div>
            
         <%--Company table that holds an existing record--%>
          <!--List of companies-->
            <div class="CompanyList">
                <table class="AddResultsTable">
                    <caption>Edit Company</caption>
                    <tr class="tableHead">
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
 </asp:Content>
