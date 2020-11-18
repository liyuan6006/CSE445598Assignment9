using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5GroupSln
{
  public partial class MemberRegister : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// register a new user with name and password
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnRegister_Click(object sender, EventArgs e)
    {
      var inputUserName = this.txtName.Text;
      var inputPassword = this.txtPwd.Text;
      // Check for invalid userName.
      if (string.IsNullOrEmpty(inputUserName) || string.IsNullOrEmpty(inputPassword))
      {
        this.lblResult.Text = "Error: Please make sure you entered the username and password.";
        return;
      }

      var result = string.Empty;
      if (VerifyInputAganistImage())
      {
        try
        {
          //call service
          XMLServiceRef.ServiceClient proxy = new XMLServiceRef.ServiceClient();
          var encrypedPwd = MD5HashLibrary.MD5Hash.Encrypt(inputPassword);
          result = proxy.CreateMember(inputUserName, encrypedPwd);

          if (result.Contains("is created successfully at"))
          {
            // initialize FormsAuthentication
            FormsAuthentication.Initialize();
            // create a new ticket used for authentication
            FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(1, inputUserName, DateTime.Now, DateTime.Now.AddMinutes(15), false, "userData");

            // encrypt the cookie using the machine key for secure transport
            string encTicket = FormsAuthentication.Encrypt(authTicket);

            // create and add the cookies to the list for outgoing response
            HttpCookie faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);

            Response.Cookies.Add(faCookie);
            //Redirect to Member page
            Response.Redirect(@"~/Member/Member.aspx");
          }
          else
          {
            this.lblResult.Text = result;
          }
        }
        catch (Exception ex)
        {
          result = ex.Message;
        }
        
      }
      else
      {
        this.lblResult.Text = "Error: Please make sure you entered the right image string";
      }
    }


    /// <summary>
    /// verify image
    /// </summary>
    /// <returns></returns>
    private bool VerifyInputAganistImage()
    {
      try
      {
        if (Session["generatedString"].Equals(this.txtInputForImage.Text))
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      catch (Exception ex)
      {

        this.lblResult.Text = "Error: "+ex.Message;
        return false;
      }
     
    }

    /// <summary>
    /// Go back to default page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnBackToDefault_Click(object sender, EventArgs e)
    {
      Response.Redirect(@"~/Default.aspx");
    }

  
  }
}