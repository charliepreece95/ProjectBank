<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>

<script runat="server">

    List<Int32> NewClientIDs;

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        ClassLibrary.clsClientCollection Client = new ClassLibrary.clsClientCollection();
        //validation here
        Boolean OK = Client.ThisClient.Valid(txtCompanyNo.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPosition.Text, txtFaxNum.Text, txtTeleNo.Text);
        //set some vars for the txt elements
        string companyNo = txtCompanyNo.Text;
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        string email = txtEmail.Text;
        string position = txtPosition.Text;
        string faxNumbe = txtFaxNum.Text;
        string telephone = txtTeleNo.Text;
        //if the data is OK add it to the object
        if (OK == true)
        {
            Client.ThisClient.CompanyNo =companyNo;
            Client.ThisClient.FirstName = firstName;
            Client.ThisClient.LastName = lastName;
            Client.ThisClient.Email = email;
            Client.ThisClient.Position = position;
            Client.ThisClient.TelephoneNumber = telephone;
            Client.ThisClient.FaxNumber = faxNumbe;
            Client.Add();
            Response.Redirect("ClientManagement.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "Please try again";
        }
    }

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <a href="ClientManagement.aspx"><div class="return">
        <span>&#8592;</span><p>Return</p>
    </div></a>
    <div class="container">
        <div class="Options">
            
            <asp:TextBox ID="txtClientNo" runat="server" CssClass="button"></asp:TextBox>
            <label for="ClientNo">ClientNo</label>
            <br />
            <asp:TextBox ID="txtCompanyNo" runat="server" CssClass="button"></asp:TextBox>
            <label for="CompanyNo">CompanyNo</label>
            <br />
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="button"></asp:TextBox>
            <label for="FirstName">First Name</label>
            <br />
            <asp:TextBox ID="txtLastName" runat="server" CssClass="button"></asp:TextBox>
            <label for="LastName">Last Name</label>
            <br />
            <asp:TextBox ID="txtTeleNo" runat="server" CssClass="button"></asp:TextBox>
            <label for="TeleNum">Telephone Number</label>
            <br />
            <asp:TextBox ID="txtEmail" runat="server" CssClass="button"></asp:TextBox>
            <label for="Email">Email</label>
            <br />
             <asp:TextBox ID="txtFaxNum" runat="server" CssClass="button"></asp:TextBox>
            <label for="FaxNu">Fax Number</label>
            <br />
          
             <asp:DropDownList ID="txtPosition" runat="server" CssClass="button">
                <asp:ListItem>Manager</asp:ListItem>
                <asp:ListItem>Programmer</asp:ListItem>
                <asp:ListItem>SuperVisor</asp:ListItem>
                <asp:ListItem>Designer</asp:ListItem>
                <asp:ListItem>Developer</asp:ListItem>
                <asp:ListItem>Human Resources</asp:ListItem>
                <asp:ListItem>Others</asp:ListItem>
            </asp:DropDownList>
            <label for="position">Position</label> 

            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" CssClass="button" />
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

        
        </div>
        <div class="ClientList">
            <table class="AddResultsTable">
                <caption>Add New Client</caption>
                <tr class="tableHead">
                    <td>ClientNo</td>
                    <td>CompanyNo</td>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>Fax Num</td>
                    <td>Tele Num</td>
                    <td>Email</td>
                    <td>Position</td>
                </tr>
                <tr>
                    <%--<td>N/A</td>--%>
                    <td></td>
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

