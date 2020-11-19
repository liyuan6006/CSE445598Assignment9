using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5GroupSln
{
    public partial class UserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String datex, userName;
            DateTime thisDay = DateTime.Now;
            datex = thisDay.ToString("g");
            if(Session["username"] != null)
            {
                userName = (string)Session["username"];
            }
            else
            {
                userName = "User";
            }
            date.Text = datex;
            greeting.Text =string.Format("Hello, {0}. <br> Welcome to our website!" , userName);
            // if we get cookies or session state maybe we can use it here.
            if(Session["clicks"] != null)
            {
                int clicks = (int)Session["clicks"];
                string clicks_str = clicks.ToString();
                session_count.Text = clicks_str;
            }
            if(Session["staff"] != null) // if staff variable set
            {
                if((bool)Session["staff"] == true)
                {
                    staff_status.Text = "Staff Privileges Active!";
                }
            }
            


        }

        protected void session_1_Click(object sender, EventArgs e)
        {
            if(Session["clicks"] == null)
            {
                Session["clicks"] = 1;
            }
            else
            {
                int clicks = (int)Session["clicks"];
                Session["clicks"] = clicks + 1;
            }
        }
    }
}