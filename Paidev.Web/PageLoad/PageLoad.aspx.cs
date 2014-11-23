using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paidev.Web.PageLoad
{
    public partial class PageLoad : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            Label1.Text += "Page Init<br />";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text += "Page Load<br />";
        }

        // PostBack 단계에서 실행될 버튼 이벤트
        protected void Button1_Click(object sender, EventArgs e)
        {
            // PostBack 요청
            Label1.Text += "Button Click<br />";
        }

        // PreRender
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            Label1.Text += "Page PreRender<br />";
        }

        // Render
        protected override void Render(HtmlTextWriter writer)
        {
            // 아래부터는 컨트롤이 변경되어도 값이 ViewState에 저장되지 않는다
            // 이뉴는 ViewState저장 단계는 Render전에 호출되기 때문
            Label1.Text += "Page Render 전<br />";

            base.Render(writer);

            // Render 이후에는 더이상 임시페이지에 참조할 수 없다
            Label1.Text += "Page Render 후<br />";
        }

        // OnUnload
        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);

            // Render 이후에는 더이상 임시페이지에 차마조할 수 없다
            Label1.Text += "Page UnLoad<br />";

            // 이 후 페이지 객체는 소멸된다
        }
    }
}