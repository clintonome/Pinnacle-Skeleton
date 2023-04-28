using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CusId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CusId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            if(CusId != -1)
            {
                DisplayCustomer();
            }
        }
        
    }

    void DisplayCustomer()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CusId);
        txtCusPassword.Text = CustomerBook.ThisCustomer.CusPassword;
        txtCusUsername.Text = CustomerBook.ThisCustomer.CusUsername;
        txtCusEmail.Text = CustomerBook.ThisCustomer.CusEmail;
        chkEmailAlerts.Checked = CustomerBook.ThisCustomer.Active;
        txtCusAdress.Text = CustomerBook.ThisCustomer.CusAdress;
        txtCusDob.Text = CustomerBook.ThisCustomer.CusDOB.ToString();
    }


    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsCustomer customer = new clsCustomer();
        string CusPassword = txtCusPassword.Text;
        string CusUsername = txtCusUsername.Text;
        string CusEmail = txtCusEmail.Text;
        string CusAdress = txtCusAdress.Text;
        string CusDOB = txtCusDob.Text;

        string Error = "";
        
        Error = customer.Valid(CusUsername, CusPassword, CusEmail, CusAdress, CusDOB);
        if (Error == "")
        {
            //creates an instance

            //captures the data
            customer.CusPassword = txtCusPassword.Text;
            customer.CusUsername = txtCusUsername.Text;
            customer.CusEmail = txtCusEmail.Text;
            customer.Active = chkEmailAlerts.Checked;
            customer.CusAdress = txtCusAdress.Text;
            customer.CusId = (int)txtCusId.TextMode;
            customer.CusDOB = DateTime.Now;



            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (Convert.ToInt32(txtCusId.Text) == -1)
            {
                CustomerList.ThisCustomer = customer;

                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(Convert.ToInt32(txtCusId.Text));

                CustomerList.ThisCustomer = customer;

                CustomerList.Update();
            }


            //navigate the viewers page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }



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