using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Xml;

namespace AuthenticationLibrary
{
    public class Authentication
    {
        /// <summary>
        /// Validate user's input with xml file
        /// </summary>
        /// <param name="inputUserName"></param>
        /// <param name="inputPassword"></param>
        /// <param name="type">If it's member it will lookup Mmeber.xml. If it's staff it will lookup Staff.xml</param>
        /// <returns></returns>
        public static bool ValidateUser(string inputUserName, string inputPassword, string type)
        {

            // Check for invalid userName.
            if (string.IsNullOrEmpty(inputUserName) || string.IsNullOrEmpty(inputPassword))
            {
                System.Diagnostics.Trace.WriteLine("[ValidateUser] Input validation of userName or passWord failed.");
                return false;
            }
            try
            {
                string pathToXml;
                var deployedPath = WebConfigurationManager.AppSettings["XMLPathOnWebstrar"] + type + ".xml";
                var localPath = WebConfigurationManager.AppSettings["XMLPathOnLocal"] + type + ".xml";

                if (File.Exists(deployedPath))
                {
                    pathToXml = deployedPath;
                }
                else if (File.Exists(localPath))
                {
                    pathToXml = localPath;
                }
                else
                {
                    throw new FileNotFoundException($"No available ${type}.xml file could be located");
                }


                var pwd = string.Empty;
                //If it's member login, it will encrypt the entered password by MD5
                if (type == "Member")
                {
                    pwd = MD5HashLibrary.MD5Hash.Encrypt(inputPassword);
                }
                else
                {
                    pwd = inputPassword;
                }


                XmlDocument myDoc = new XmlDocument();
                // load file
                myDoc.Load(pathToXml);
                XmlElement rootElement = myDoc.DocumentElement;
                foreach (XmlNode node in rootElement.ChildNodes)
                {
                    if (node["Name"].InnerText == inputUserName)
                    {
                        if (node["Password"].InnerText == pwd)
                        {
                            return true; ;
                        }
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("[ValidateUser] Exception " + ex.Message);
                return false;
            }
        }
    }
}
