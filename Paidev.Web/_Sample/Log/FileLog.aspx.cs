using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Xml;

namespace Paidev.Web._Sample.Log
{
    public partial class FileLog : Paidev.Framework.Web.UI.Page
    {
        private bool logBool = false;               // 파일로그를 남겨야 할 경우 XML 파일에서 true로 수정
        private string logPath = string.Empty;      // 파일로그를 남기는 경로

        Paidev.Framework.Web.Log.Log log = new Paidev.Framework.Web.Log.Log();

        protected void Page_Load(object sender, EventArgs e)
        {
            // XML데이터 가져오기
            GetXmlData();
        }

        protected void btnLog_Button(object sender, EventArgs e)
        {
            // 파일로그 사용
            log.FileLog(logBool, logPath, "로그테스트");
        }

        /// <summary>
        /// XML 데이터 가져오기
        /// </summary>
        private void GetXmlData()
        {
            string xmlPath = Page.Server.MapPath("Log.xml");

            XmlDocument xml = new XmlDocument();

            xml.Load(xmlPath);

            // 접근할 노드
            XmlNodeList xnList = xml.SelectNodes("/log/log_node");

            foreach (XmlNode xn in xnList)
            {
                logBool = Convert.ToBoolean(xn["log_bool"].InnerText);
                logPath = xn["log_path"].InnerText;
            }
        }
    }
}