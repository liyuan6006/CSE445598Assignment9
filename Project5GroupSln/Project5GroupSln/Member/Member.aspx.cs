using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5GroupSln.Member
{
  public partial class Member : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

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