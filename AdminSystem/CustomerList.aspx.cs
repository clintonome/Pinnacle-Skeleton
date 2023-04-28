using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
          DisplayCustomer();
        }
    }
    void DisplayCustomer()
    {
        clsCustomerCollection customers = new clsCustomerCollection();
        lstCustomerList.DataSource = customers.CustomerList;
        lstCustomerList.DataValueField = "CusId";
        lstCustomerList.DataTextField = "CusUsername";
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Int32 CusId;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CusId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CusId"] = CusId;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please Select a record to edit";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CusId;
        
        if (lstCustomerList.SelectedIndex != -1)
        {
            CusId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CusId"] = CusId;
            Response.Redirect("CustomerDataEmrty.aspx");
        }
        else
        {
            lblError.Text = "please select a record to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CusId;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CusId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CusId"] = CusId;
            Response.Redirect("CustomerConfirmDelete");
        }
        else
        {
            lblError.Text = "Please select a record";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection customer = new clsCustomerCollection();
        customer.ReportByUsername(txtFilter.Text);
        lstCustomerList.DataSource = customer.CustomerList;
        lstCustomerList.DataValueField = "CusId";
        lstCustomerList.DataTextField = "CusUsername";
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection customer = new clsCustomerCollection();
        customer.ReportByUsername("");
        txtFilter.Text = "";
        lstCustomerList.DataValueField = "CusId";
        lstCustomerList.DataTextField = "cusUsername";
    }
}