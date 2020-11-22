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

        protected void btn_staffCreate_Click(object sender, EventArgs e)
        {
            try
            {
                XMLServiceRef.ServiceClient proxy = new XMLServiceRef.ServiceClient();
                string username, password;
                username = staff_username.Text;
                password = staff_password.Text;

                string result = proxy.CreateStaff(username, password);
                if (result.Contains("is created successfully at"))
                {
                    creation_result.Text = "Staff member added successfully!";
                }
                else
                {
                    creation_result.Text = "Problem adding staff, please try again.";
                }
            }
            catch (Exception ex)
            {
                creation_result.Text = ex.Message;
            }

        }
    }
}