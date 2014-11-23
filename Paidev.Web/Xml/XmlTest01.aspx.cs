using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Paidev.Web.Xml
{
    public partial class XmlTest01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string xmlPath = Page.Server.MapPath("Xml.xml");            

                XmlDocument xml = new XmlDocument();

                xml.Load(xmlPath);

                // 접근할 노드
                XmlNodeList xnList = xml.SelectNodes("/main/main_node/class_name");

                foreach (XmlNode xn in xnList)
                {
                    string part1 = xn["code"].InnerText;
                    string part2 = xn["code_name"].InnerText;
                    string part3 = xn["class_teacher"]["teacher"].InnerText;
                    string part4 = xn["school"]["code"].InnerText;
                    string part5 = xn["school"]["code_name"].InnerText;

                    lbText.Text = part1 + "|" + part2 + "|" + part3 + "|" + part4 + "|" + part5;
                }
            }
            catch (Exception ex)
            {
                lbText.Text = ("XML 문제 발생\r\n" + ex);
            }           
        }
    }
}