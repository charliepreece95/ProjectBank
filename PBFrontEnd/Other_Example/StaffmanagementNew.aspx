<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">



    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("<html xmlns=\"http://www.w3.org/1999/xhtml\">");
        Response.Write("<head runat=\"server\">");
        Response.Write("<title></title>");
        Response.Write("<link href=\"css/ProjectBank.css\" rel=\"stylesheet\" type=\"text/css\" />");
        Response.Write("</head>");
        Response.Write("<body>");

        ClassLibrary.clsStaffCollection StaffList = new ClassLibrary.clsStaffCollection();
        Int32 Index = 1;
        Int32 RecordCount = StaffList.Count;

        //Response.Write("<caption> StaffManagement </caption>");
        Response.Write("<table border=\"1\">");

        Response.Write("<tr>");
        Response.Write("<td>FirstName</td>");
        Response.Write("<td>LastName</td>");


        while (Index < RecordCount)
        {
            
            Response.Write("<td>");
            Response.Write(StaffList.StaffList[Index].FirstName);
            Response.Write("</td>");
            Response.Write("<td>");
            Response.Write(StaffList.StaffList[Index].LastName);
            Response.Write("</td>");
            Response.Write("</tr>");

            Index++;
        }
        Response.Write("</table>");

        Response.Write("<form id=\"form1\" runat=\"server\">");
        Response.Write("<div>");



        Response.Write("</div>");
        Response.Write("</form>");
        Response.Write("</body>");
        Response.Write("</html>");

    }
</script>

