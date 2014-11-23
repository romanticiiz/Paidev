using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paidev.Web.Etc
{
    public partial class ImageButtonTest01 : System.Web.UI.Page
    {        
        private System.Web.UI.UserControl uc = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            this.contentHolder.FindControl("cphContent").Controls.Clear();

            uc = (System.Web.UI.UserControl)LoadControl("UcTest01.ascx");            

            this.contentHolder.FindControl("cphContent").Controls.Add(uc);
        }

        protected void btnIPinNext_Click(object sender, EventArgs e)
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

        protected void ImgBtnTest_Click2(object sender, ImageClickEventArgs e)
        {
            Response.Write("이미지버튼2 성공");
        }
    }
}