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
      Response.Write("Logged out - cookie deleted.");
    }
  }
}