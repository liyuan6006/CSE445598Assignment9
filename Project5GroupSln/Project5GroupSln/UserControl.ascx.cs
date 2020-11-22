using System;
using System.Collections.Concurrent;
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
            // Show the user their username if logged in
            String userName;
            if(Session["username"] != null)
            {
                userName = (string)Session["username"];
            }
            else
            {
                userName = "User";
            }
            greeting.Text =string.Format("Hello, {0}!" , userName);

            // Let the user know if they have Staff privileges if applicable
            if(Session["staff"] != null) // if staff variable set
            {
                if ((bool)Session["staff"] == true)
                {
                    staff_status.Text = "You have Staff Privileges!";
                }
            }

            // Show the user the date
            date.Text = DateTime.Now.ToString("g");

            // Show the user the number of users currently online
            if (Application["OnlineUserCount"] != null)
            {
                var counter = (ConcurrentStack<int>)Application["OnlineUserCount"];
                var count = counter.Count;
                if (count == 1)
                {
                    usersOnlineLabel.Text = $"1 user on Server.";
                }
                else
                {
                    usersOnlineLabel.Text = $"{count} users on Server.";
                }                
            }           

            // Show the user an inspirational quote
            inspirational_quote.Text = InspirationalQuoteLibrary.InspirationalQuotes.GetRandomQuote();
        }

        protected void quoteBtn_Click(object sender, EventArgs e)
        {
            // User has requested a new inspirational quote be shown
            inspirational_quote.Text = InspirationalQuoteLibrary.InspirationalQuotes.GetRandomQuote();
        }
    }
}