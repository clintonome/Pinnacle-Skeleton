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
        //creates instance of class
        clsStock Stock = new clsStock();
        //get data from session
        Stock = (clsStock)Session["Stock"];
        //displays the data
        Response.Write(Stock.Description);
        //get data from session
        Stock = (clsStock)Session["Stock"];
        //displays the data
        Response.Write(Stock.Colour);
        //get data from session
        Stock = (clsStock)Session["Stock"];
        //displays the data
        Response.Write(Stock.Quantity);
        //get data from session
        Stock = (clsStock)Session["Stock"];
        //displays the data
        Response.Write(Stock.StockID);
        //get data from session
        Stock = (clsStock)Session["Stock"];
        //displays the data
        Response.Write(Stock.Price);
        //get data from session
        Stock = (clsStock)Session["Stock"];
        //displays the data
        Response.Write(Stock.DateAdded);
        //get data from session
        Stock = (clsStock)Session["Stock"];
        //displays the data
        Response.Write(Stock.Availability);
    }
}