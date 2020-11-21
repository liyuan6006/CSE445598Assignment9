using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5GroupSln
{
  public partial class Default : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Go to member register page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnMemberRegister_Click(object sender, EventArgs e)
    {
      Response.Redirect(@"~/MemberRegister.aspx");
    }

    /// <summary>
    /// Go to member page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnMember_Click(object sender, EventArgs e)
    {
      Response.Redirect(@"~/Member/Member.aspx");
    }

    /// <summary>
    /// sign out
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnClear_Click(object sender, EventArgs e)
    {
      FormsAuthentication.SignOut();
      Session["staff"] = false;
      Response.Write("Logged out - cookie deleted.");
    }
        /// <summary>
        /// staff button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnStaff_Click(object sender, EventArgs e)
    {
       Response.Redirect(@"~/Staff/Staff.aspx");
    }

    /// <summary>
    /// Try it hash
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnHash_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.txtPwdToHash.Text)) 
      {
        this.lblHashResult.Text = "The password string can not be empty!";
      }
      else
      {
        this.lblHashResult.Text = MD5HashLibrary.MD5Hash.Encrypt(this.txtPwdToHash.Text);
      }
    }

        protected void buttonServiceDirectory_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~/ServiceDirectory.html");
        }
    }
}