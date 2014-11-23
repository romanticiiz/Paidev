using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paidev.Web.MultiLanguage
{
    public partial class MultiLanguageTest01 : Paidev.Framework.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 언어변경 버튼 Setting
            this.btnChangeLng.Text = this.Message("Content", "LanguageChangeButton");

            // 쿠키가 존재한다면 selectedBox Default값 설정
            if (!IsPostBack)
            {
                ddlChangeLng.SelectedValue = this.GetLngCookie();
            }
        }

        protected void btnChangeLng_Click(object sender, EventArgs e)
        {
            // 선택한 언어로 새로 쿠키 생성
            string cookie = string.Format("{0}", ddlChangeLng.SelectedValue.ToString());
            Paidev.Framework.Web.Cookie.Information.SetCookie("lngCookie", cookie);

            // 리다이렉트
            Response.Redirect(Request.Url.PathAndQuery);
        }
    }
}