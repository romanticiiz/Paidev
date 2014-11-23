using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paidev.Web.Etc
{
    public partial class UcTest01 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImgBtnTest_Click(object sender, ImageClickEventArgs e)
        {
            //if (Request.Form["isAllrealname"].ToString().ToLower() != "false" && info.IsRealName == "Y")
            //{
            //    if (processType == "i")
            //    {
            //        SetNextPanel(false);
            //    }
            //    else
            //    {
            //        SetNextPanel(true);
            //    }
            //}
            //else
            //{
            //    pnlnotRealName.Visible = true;

            //    List<HanbitSoft.Membership.Members.Entity.Info.User> ret = new HanbitSoft.Membership.Members.Data.Register().GetUserListByDi(info.Di);
            //    SetIdList(ret);
            //}
            Response.Write("성공");
        }
    }
}