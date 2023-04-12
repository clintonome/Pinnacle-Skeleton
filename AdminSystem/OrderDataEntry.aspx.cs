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
        clsOrder AnOrder = new clsOrder();
        AnOrder.CustName = CustName.Text;
        AnOrder.Quantity = (int)Quantity.TextMode;


        AnOrder.Quantity = (int)Quantity.TextMode;


        AnOrder.Price = (int)Price.TextMode;


        AnOrder.DateAdded = DateTime.Now;


        AnOrder.ShippingAddress = txtShipAdd.Text;
        Session["AnOrder"] = AnOrder;

        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = AnOrder.Find(OrderID);
        if (Found == true)
        {
            CustName.Text = AnOrder.CustName;
            Quantity.Text = AnOrder.Quantity.ToString();
            txtdatetime.Text = AnOrder.DateAdded.ToString();
            Price.Text = AnOrder.Price.ToString();
            txtShipAdd.Text = AnOrder.ShippingAddress;
            chkdelivered.Checked = AnOrder.Active;
        }
    }
}