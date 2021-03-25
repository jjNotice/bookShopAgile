using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the orderline
        AnOrder.OrderLine = txtOrderLine.Text;
        //stroe the order in the session object
        Session["Order"]= AnOrder;
        //navigate to the viewer page
        Response.Redirect("Orderviewer.aspx");
    }
}