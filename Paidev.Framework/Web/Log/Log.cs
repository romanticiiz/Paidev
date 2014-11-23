using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Paidev.Framework.Web.Log
{
    public class Log : Paidev.Framework.Web.UI.Page
    {
        /// <summary>
        /// 파일로그 | 예시: GetXmlDataErrMsg() Exception 오류" + ex.Message
        /// </summary>
        /// <param name="logBool"></param>
        /// <param name="detailPath"></param>
        /// <param name="message"></param>
        public void FileLog(bool logBool, string detailPath, string message)
        {
            try
            {
                if (logBool)
                {
                    string path = string.Empty;

                    path = Page.Server.MapPath(detailPath);

                    if (!path.Equals(string.Empty) && path.LastIndexOf(@"\", path.Length - 1, 1) < 0)
                    {
                        path = path + @"\";
                    }
                    else
                    {
                        path = System.Web.HttpContext.Current.Server.MapPath("/") + @"bin\" + path;
                    }

                    string file = path + DateTime.Now.ToString("yyyyMMdd") + ".log";
                    System.IO.StreamWriter writer = System.IO.File.AppendText(file);
                    writer.WriteLine(DateTime.Now.ToString() + message);
                    writer.WriteLine("----- ----- ----- ----- -----");
                    writer.Flush();
                    writer.Close();
                }
            }
            catch(Exception ex)
            { 
                
            }
        }
    }
}