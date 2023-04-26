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
        customer.CusId = (int)txtCusId.TextMode;
        customer.CusDOB = DateTime.Now;
        Session["Customer"] = customer;
        //navigate to viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void Findbtn_Click(object sender, EventArgs e)
    {
        clsCustomer customer = new clsCustomer();
        Int32 CusId;
        Boolean Found = false;
        CusId = (int)txtCusId.TextMode;
        Found = customer.Find(CusId);
        if (Found == true)
        {
            txtCusPassword.Text = customer.CusPassword;
            txtCusUsername.Text = customer.CusUsername;
            txtCusEmail.Text = customer.CusEmail;
            chkEmailAlerts.Checked = customer.Active;
            txtCusAdress.Text = customer.CusAdress;
            txtCusDob.Text = customer.CusDOB.ToString();
        }
        else
        {
            txtCusUsername.Text = "Customer Not here";
        }
    }
}