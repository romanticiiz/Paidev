using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paidev.Web.Etc
{
    public partial class view : System.Web.UI.Page
    {
        protected int n4ArticleSN { get { return string.IsNullOrEmpty(Request["n4ArticleSN"]) ? 1 : Convert.ToInt32(Request["n4ArticleSN"]); } }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}