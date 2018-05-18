<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

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
        Int32 Index = 0;
        Int32 RecordCount = StaffList.Count;
        Response.Write("<table border=\"1\">");
        
        while (Index < RecordCount)
        {
            Response.Write("<tr>");
            Response.Write("<td>");
            Response.Write(StaffList.StaffList[Index].FirstName);
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


</asp:Content>

