using AuthenticationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5GroupSln
{
  public partial class Login : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Go back to default page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnGoBack_Click(object sender, EventArgs e)
    {
      Response.Redirect(@"~/Default.aspx");
    }

    protected void btnLoginAsStaff_Click(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Login as member
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnLoginAsMember_Click(object sender, EventArgs e)
    {
      //get user's input
      string inputUserName = this.txtUserName.Text;
      string password = this.txtPassword.Text;

      if (Authentication.ValidateUser(inputUserName, password, "Member"))
      {
        ////RedirectFromLoginPage method to automatically generate the forms authentication cookie and redirect the user to an appropriate page in the
        //var isPersistentCooke = chekRememberMe.Checked;
        //FormsAuthentication.RedirectFromLoginPage(userName, isPersistentCooke);

        // initialize FormsAuthentication
        FormsAuthentication.Initialize();
        // create a new ticket used for authentication
        FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(1, inputUserName, DateTime.Now, DateTime.Now.AddMinutes(15), this.chekRememberMe.Checked, "userData");
        // encrypt the cookie using the machine key for secure transport
        string encTicket = FormsAuthentication.Encrypt(authTicket);
        // create and add the cookies to the list for outgoing response
        HttpCookie faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);

        Response.Cookies.Add(faCookie);

        Session["username"] = inputUserName;
        Response.Redirect(@"~/Member/Member.aspx");

      }
      else
      {
        this.lblLoginError.Text = "Invalid Credentials: Please try again.";
      }
    }
  }
}