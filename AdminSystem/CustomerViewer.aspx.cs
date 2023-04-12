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
        //cretaes new instance of customer class
        clsCustomer customer = new clsCustomer();
        //get data of the session object
        customer = (clsCustomer)Session["customer"];
        //display data
        Response.Write(customer.CusAdress);
    }
}