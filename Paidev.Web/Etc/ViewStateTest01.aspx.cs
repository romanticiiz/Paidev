using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paidev.Web.Etc
{
    public partial class ViewStateTest01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                lbTest01.Text = "Dynamic Value";
                lbTest02.Text = "Dynamic Value";
            }
            else
                lbTest02.Text = "Post Back";
        }

        //public class classtest1
        //{
        //    public string Function()
        //    {
        //        return "";
        //    }
        //}
    }
}