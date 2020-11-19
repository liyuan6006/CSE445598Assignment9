using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5GroupSln.Staff
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["staff"] == null)
            {
                Response.Redirect(@"~/Login.aspx");
            }
            else
            {
                Boolean flag = (Boolean)Session["staff"];
                if(flag != true)
                {
                    Response.Redirect(@"~/Login.aspx");
                }
            }
        }

        protected void staff_return_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~/Default.aspx");
        }
    }
}