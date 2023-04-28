using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CusId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CusId = Convert.ToInt32(Session["CusId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CusId);
        CustomerBook.Delete();
        Response.Redirect("CustomerList");
    }



    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList");
    }
}