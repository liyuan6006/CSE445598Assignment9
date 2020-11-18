using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5GroupSln
{
  public partial class ImageProcess : System.Web.UI.Page
  {
    /// <summary>
    /// write image stream out to the page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
      Response.Clear();
      //create a proxy to the remote service
      ImageVerifierServiceRef.ServiceClient proxy = new ImageVerifierServiceRef.ServiceClient();
      string mystr = string.Empty;
      //check session
      if (Session["generatedString"] == null)
      {
        string userLength = "5";
        mystr = proxy.GetVerifierString(userLength);
        //set session
        Session["generatedString"] = mystr;

      }
      else
      {
        //get value from session
        mystr = Session["generatedString"].ToString();
      }
      Stream myStream = proxy.GetImage(mystr);
      System.Drawing.Image myImage = System.Drawing.Image.FromStream(myStream);
      Response.ContentType = "image/jpeg";
      myImage.Save(Response.OutputStream, ImageFormat.Jpeg);
    }
  }
}