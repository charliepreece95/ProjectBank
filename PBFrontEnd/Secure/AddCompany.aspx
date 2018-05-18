<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>

<script runat="server">

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        ClassLibrary.clsCompanyCollection Company = new ClassLibrary.clsCompanyCollection();
        //validation here
        Boolean OK = Company.ThisCompany.Valid(txtCompanyName.Text, txtAddress.Text, txtPostCode.Text, txtTeleNum.Text, txtEmail.Text, txtDescription.Text);
        //set some vars for the txt elements
        string CompanyName = txtCompanyName.Text;
        string Address = txtAddress.Text;
        string PostCode = txtPostCode.Text;
        string TeleNum = txtTeleNum.Text;
        string Email = txtEmail.Text;
        string Description = txtDescription.Text;
        //if the data is OK add it to the object
        if (OK == true)
        {
            Company.ThisCompany.CompanyName = CompanyName;
            Company.ThisCompany.Address = Address;
            Company.ThisCompany.PostCode = PostCode;
            Company.ThisCompany.TeleNum = TeleNum;
            Company.ThisCompany.Email = Email;
            Company.ThisCompany.Description = Description;
            Company.Add();
            Response.Redirect("CompanyManagement.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "Please try again";
        }
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <a href="CompanyManagement.aspx">
        <div class="return">
            <span>&#8592;</span><p>Return</p>
        </div>
    </a>

    <div class="container">
        <div class="OptionsApp">

            <br />
            <asp:TextBox ID="txtCompanyName" runat="server" class="button"></asp:TextBox>
            <label for="CompanyName">Company Name</label>
            <br />
            <asp:TextBox ID="txtAddress" runat="server" class="button"></asp:TextBox>
            <label for="Address">Address</label>
            <br />
            <asp:TextBox ID="txtPostCode" runat="server" class="button"></asp:TextBox>
            <label for="PostCode">Post Code</label>
            <br />
            <asp:TextBox ID="txtTeleNum" runat="server" CssClass="button"></asp:TextBox>
            <label for="TeleNum">Telephone Number</label>
            <br />
            <asp:TextBox ID="txtEmail" runat="server" CssClass="button"></asp:TextBox>
            <label for="Email">Email</label>
            <br />
            <asp:TextBox ID="txtDescription" runat="server" CssClass="button"></asp:TextBox>
            <label for="Description">Description</label>
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" CssClass="button" />
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>


        </div>
        <div class="CompanyList">
            <table class="AddResultsTable">
                <caption>Add New Company</caption>
                <tr class="tableHead">
                    <td>Company Name</td>
                    <td>Address</td>
                    <td>Post Code</td>
                    <td>Tele Number</td>
                    <td>Email</td>
                    <td>Description</td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </table>

        </div>
    </div>
</asp:Content>

