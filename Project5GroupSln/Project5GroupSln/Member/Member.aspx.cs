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

        protected void WordFillterButton_Click(object sender, EventArgs e)
        {
            var client = new SEOService.RequiredServicesClient();
            try
            {
                WordFilterResultsLabel.Text = client.WordFilter(WordFilterTextBox.Text);
            }
            catch
            {
                WordFilterResultsLabel.Text = "SEO Services may not be running!";
            }
            finally
            {
                client.Close();
            }
        }

        protected void StemmingButton_Click(object sender, EventArgs e)
        {

            var client = new SEOService.RequiredServicesClient();
            try
            {
                StemmingResultLabel.Text = client.Stemming(StemmingTextBox.Text);
            }
            catch
            {
                StemmingResultLabel.Text = "SEO Services may not be running!";
            }
            finally
            {
                client.Close();
            }

        }

        protected void TopTenButton_Click(object sender, EventArgs e)
        {

            var client = new WordService.Service1Client();
            try
            {
                TopTenResultsLabel.Text = String.Join(", ", client.Top10ContentWords(TopTenTextBox.Text));
            }
            catch
            {
                TopTenResultsLabel.Text = "Word Services may not be running!";
            }
            finally
            {
                client.Close();
            }

        }
    }
}