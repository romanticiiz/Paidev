using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace Paidev.Web.Etc
{
    public partial class sqlTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void SetSql()
        {
            string connectionStrings = "server=127.0.0.1:1433; uid=sa; pwd=tkdgus.1; database=TEST;";

            string ProcName = "SPNAME";
            //SqlCommand cmd = new SqlCommand(ProcName, connectionStrings); 
        }
    }
}