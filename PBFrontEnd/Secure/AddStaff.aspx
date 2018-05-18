<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>

<script runat="server">

    List<Int32> NewStaffIDs;

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        ClassLibrary.clsStaffCollection Staff = new ClassLibrary.clsStaffCollection();
        //validation here
        Boolean OK = Staff.ThisStaff.Valid(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPosition.Text, txtTeleNo.Text);
        //set some vars for the txt elements
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Email = txtEmail.Text;
        string Position = txtPosition.Text;
        string TeleNo = txtTeleNo.Text;
        //if the data is OK add it to the object
        if (OK == true)
        {
            Staff.ThisStaff.FirstName = FirstName;
            Staff.ThisStaff.LastName = LastName;
            Staff.ThisStaff.Email = Email;
            Staff.ThisStaff.Position = Position;
            Staff.ThisStaff.TeleNo = TeleNo;
            Staff.Add();
            Response.Redirect("StaffManagement.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "Please try again";
        } 
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <a href="StaffManagement.aspx"><div class="return">
        <span>&#8592;</span><p>Return</p>
    </div></a>

    <div class="container">  
        <div class="Options">
            
            <br />
            <asp:TextBox ID="txtFirstName" runat="server" class="button"></asp:TextBox>
            <label for="FirstName">First Name</label>
            <br />
            <asp:TextBox ID="txtLastName" runat="server" class="button"></asp:TextBox>
            <label for="LastName">Last Name</label>
            <br />
            <asp:TextBox ID="txtTeleNo" runat="server" class="button"></asp:TextBox>
            <label for="TeleNum">Telephone Number</label>
            <br />
            <asp:TextBox ID="txtEmail" runat="server" CssClass="button"></asp:TextBox>
            <label for="Email">Email</label>
            <br />
            <asp:DropDownList ID="txtPosition" runat="server" CssClass="button">
                <asp:ListItem>Manager</asp:ListItem>
                <asp:ListItem>Programmer</asp:ListItem>
            </asp:DropDownList>
            <label for="position">Position</label>     
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" CssClass="button" />
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label> 
            

        </div>
        <div class="StaffList">
            <table class="AddResultsTable">
                <caption>Add New Staff</caption>
                <tr class="tableHead">
                    <td>Staff#</td>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>Tele Num</td>
                    <td>Email</td>
                    <td>Position</td>
                </tr>
                <tr>
                    <td>N/A</td>
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

