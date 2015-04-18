using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;

namespace Paidev.Web.Etc
{
    public partial class txtFileLoad : System.Web.UI.Page
    {
        protected string fileName = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            fileName = string.IsNullOrEmpty(Request["fileName"]) ? "" : Convert.ToString(Request["fileName"]);
        }

        protected void btnFileUpload_Button(object sender, EventArgs e)
        {
            DirectoryInfo aDir = new DirectoryInfo(Server.MapPath("/Upload_img/"));
            FileInfo[] files;

            if (aDir != null)
            {
                DirectoryInfo[] directories = aDir.GetDirectories();

                for (int i = 0; i < directories.Length; i++)
                {
                    files = directories[i].GetFiles();
                    for (int j = files.Length - 1; j >= 0; j--)
                    {
                        files[j].Delete();
                    }
                }

                files = aDir.GetFiles();

                for (int i = files.Length - 1; i >= 0; i--)
                {
                    files[i].Delete();
                }
            }            

            if (FileUpload.HasFile)
            {
                string fileName = Path.Combine(Server.MapPath("/Upload_img/"), FileUpload.FileName);
                FileUpload.SaveAs(fileName);

                Response.Redirect("/etc/txtFileLoad.aspx?fileName="+ FileUpload.FileName.ToString() +"");
            }

            //string virturePath = Request.QueryString["fileT"];
            //string realPath = Server.MapPath("/Upload_img/" + virturePath);

            //int length = Request.ContentLength;
            //byte[] bytes = new byte[length];
            //Request.InputStream.Read(bytes, 0, length);

            //string fileName = Request.Headers["file-name"];
            //string fileSize = Request.Headers["file-size"];
            //string fileType = Request.Headers["file-type"];

            //string fileUrl = Server.MapPath("/Upload_img/");
        }
    }
}