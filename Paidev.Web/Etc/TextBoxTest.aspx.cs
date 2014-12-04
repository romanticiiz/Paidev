using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paidev.Web.Etc
{
    public partial class TextBoxTest : System.Web.UI.Page
    {
        private string tmpFloatNum = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            string num = "5";

            double tmpPrice = (Convert.ToInt32(num) - 1) + 0.99;            

            return;
        }
    }
}