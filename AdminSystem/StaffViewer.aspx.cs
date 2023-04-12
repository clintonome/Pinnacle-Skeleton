using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // creates a new instance of clsStaff
        clsStaff staff = new clsStaff();
        //Get the data from the session object
        staff = (clsStaff)Session["Staff"];
        //display the data
        Response.Write(staff.Name);
    }
}