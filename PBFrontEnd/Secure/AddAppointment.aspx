<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>

<script runat="server">

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        ClassLibrary.clsAppointmentCollection Appointment = new ClassLibrary.clsAppointmentCollection();
        //validation here
        Boolean OK = Appointment.ThisAppointment.Valid(txtTitle.Text, calBookingDate.SelectedDate.ToString(), txtClientNo.Text, txtLocation.Text, txtStaffNo.Text, txtStatus.Text);
        //set some variables for the txt elements
        string Title = txtTitle.Text;
        Int32 ClientNo = Convert.ToInt32(txtClientNo.Text);
        Int32 StaffNo = Convert.ToInt32(txtStaffNo.Text);
        string Location = txtLocation.Text;
        DateTime BookingDate = calBookingDate.SelectedDate;
        string Status = txtStatus.Text;
        //if the data is OK add it to the object

        if (OK == true)
        {
            Appointment.ThisAppointment.AppointmentTitle = Title;
            Appointment.ThisAppointment.ClientNo = ClientNo;
            Appointment.ThisAppointment.StaffNo = StaffNo;
            Appointment.ThisAppointment.Location = Location;
            Appointment.ThisAppointment.BookingDate = BookingDate;
            Appointment.ThisAppointment.Status = Status;
            Appointment.Add();
            Response.Redirect("AppointmentManagement.aspx");
        }
        else if (OK == false)
        {
            //report na error
            lblError.Text = "Please try agian";
        }
        /*
        else if(OK calBookingDate.SelectedDate)
        {
           lblError.Text = "You've selected a date in the past");         
        }
        */
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <a href="AppointmentManagement.aspx"><div class="return">
        <span>&#8592;</span><p>Return</p>
    </div></a>
    <div class="container">
        <div class="OptionsApp">

            <label for="ClientNo">Client No</label>
            <asp:TextBox ID="txtClientNo" runat="server" class="button"></asp:TextBox>
            <br />   
            <label for="Title">Title</label>         
            <asp:TextBox ID="txtTitle" runat="server" class="button"></asp:TextBox>
            <br />
            <label for="StaffMemberPresent">Staff member present</label>
            <asp:TextBox ID="txtStaffNo" runat="server" class="button"></asp:TextBox>
            <br />
            <label for="Location">Location</label>
            <asp:TextBox ID="txtLocation" runat="server" class="button"></asp:TextBox>
            <br />
            <label for="BookingDate">Booking date</label>
            <asp:Calendar ID="calBookingDate" runat="server" CssClass="button" ForeColor="White" BorderStyle="Solid"></asp:Calendar>
            <br />
            <label for="Status">Status</label>
            <asp:DropDownList ID="txtStatus" runat="server" CssClass="button">
                <asp:ListItem>Pending</asp:ListItem>
            </asp:DropDownList>   

            <asp:Button ID="btnAdd" runat="server" Text="Add" class="button" OnClick="btnAdd_Click"/>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

        </div>
        <div class="StaffList">
            <table class="AddResultsTable">
                <caption>Add New Appointment</caption>
                <tr class="tableHead">
                    <td>Appointment#</td>
                    <td>Client#</td>
                    <td>Title</td>
                    <td>Staff member present</td>
                    <td>Location</td>
                    <td>Booking Date</td>
                    <td>Status</td>
                </tr>
                <tr>
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

