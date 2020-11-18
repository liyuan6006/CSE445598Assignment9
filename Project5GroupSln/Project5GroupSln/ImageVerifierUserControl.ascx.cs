using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5GroupSln
{
  public partial class ImageVerifierUserControl : System.Web.UI.UserControl
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      this.Image1.ImageUrl = @"~/ImageProcess.aspx";
    }

    /// <summary>
    /// Get new image
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnNewImage_Click(object sender, EventArgs e)
    {
      ImageVerifierServiceRef.ServiceClient proxy = new ImageVerifierServiceRef.ServiceClient();
      //define image string length
      string userLength = "5";
      var mystr = proxy.GetVerifierString(userLength);
      //set session
      Session["generatedString"] = mystr;
    }
  }
}