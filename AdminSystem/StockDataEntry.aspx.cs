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

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        //creates an instance
        clsStock Stock = new clsStock();
        //captures the data
        Stock.StockID = Convert.ToInt32(txtStockID.Text);
        Stock.Description = txtDescription.Text;
        Stock.Colour = txtColour.Text;
        Stock.DateAdded = Convert.ToDateTime(txtDate.Text);
        Stock.Price = Convert.ToDouble(txtPrice.Text);
        Stock.Quantity = Convert.ToInt32(txtQuantity.Text);
        Stock.Availability = Convert.ToBoolean(Availability.Checked);
        Session["Stock"] = Stock;
        //navigate the viewers page
        Response.Redirect("StockViewer.aspx");
    }

    protected void ButtonFind_Click(object sender, EventArgs e)
    {
        //creates an instance
        clsStock Stock = new clsStock();
        //store primary key
        Int32 StockID;
        //result of find operation
        Boolean Found = false;
        //get primary key
        StockID = Convert.ToInt32(txtStockID.Text);
        //finding record
        Found = Stock.Find(StockID);
        //if Found
        if (Found == true)
        {
            txtDescription.Text = Stock.Description;
            txtColour.Text = Stock.Colour;
            txtPrice.Text = Stock.Price.ToString();
            txtDate.Text = Stock.DateAdded.ToString();
            txtQuantity.Text = Stock.Quantity.ToString();
            Availability.Checked = Stock.Availability;
        }
        else
        {
            txtDescription.Text = "Item Nonexistant";
        }
    }
}