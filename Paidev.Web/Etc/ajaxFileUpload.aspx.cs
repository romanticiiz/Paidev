using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paidev.Web.Etc
{
    public partial class ajaxFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        private string UploadFiles(object obj)
        {
            int length = Request.ContentLength;
            byte[] bytes = new byte[length];
            Request.InputStream.Read(bytes, 0, length);

            string fileName = Request.Headers["file-name"];
            string fileSize = Request.Headers["file-size"];
            string fileType = Request.Headers["file-type"];

            string fileUrl = Server.MapPath("/Upload_img/");            

            return string.Format("&bNewLine=true&sFileName={0}&sFileURL={1}");
        }
    }
}