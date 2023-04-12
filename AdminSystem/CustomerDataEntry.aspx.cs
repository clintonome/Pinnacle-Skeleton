using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Create new instance of class
        clsCustomer customer = new clsCustomer();
        //capture customer
        customer.CusPassword = txtCusPassword.Text;
        customer.CusUsername = txtCusUsername.Text;
        customer.CusEmail = txtCusEmail.Text;
        customer.Active = chkEmailAlerts.Checked;
        customer.CusAdress = txtCusAdress.Text;
        customer.CusId = Convert.ToInt32(txtCusId);
        customer.CusDOB = Convert.ToDateTime(txtCusDob);
        Session["Customer"] = customer;
        //navigate to viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}