using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paidev.Web.Cookie
{
    public partial class CookieTest01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isCheck = Paidev.Framework.Web.Cookie.Information.IsCookie("HttpCookie");            
            bool responseIsCheck = ResponseCookieIsCheck();

            // 쿠키 존재여부 체크
            this.lbIsCookie.Text = Convert.ToString(isCheck);
            
            // Response쿠키 존재여부 체크
            this.lbResPonseIsCokie.Text = Convert.ToString(ResponseCookieIsCheck());

            // 쿠키가 존재한다면
            if (isCheck)
            {
                // 저장된 쿠키 가져오기
                string cookieText = Paidev.Framework.Web.Cookie.Information.GetCookie("HttpCookie");
                this.lbCookieText.Text = cookieText;  
            }        
    
            // Response쿠키가 존재한다면
            if (responseIsCheck)
            {
                string responseCookieText = Request.Cookies["ResponseCookie"].Value;
                this.lbResponseCookie.Text = responseCookieText;
            }
        }

        protected void btnSetCookieButton_Click(object sender, EventArgs e)
        {
            // 쿠키 셋팅
            Paidev.Framework.Web.Cookie.Information.SetCookie("HttpCookie", "This HttpCookie");

            Response.Redirect(Request.Url.PathAndQuery);
        }

        protected void btnDeleteCookieButton_Click(object sender, EventArgs e)
        {
            // 쿠키 삭제
            Paidev.Framework.Web.Cookie.Information.Delete("HttpCookie");
            this.lbCookieText.Text = "";

            Response.Redirect(Request.Url.PathAndQuery);
        }

        protected void btnResponseCookieSetButton_Click(object sender, EventArgs e)
        {
            // Response를 통한 쿠키셋팅            
            Response.Cookies["ResponseCookie"].Value = "This ResponseCookie";

            // 쿠키 유효기간 설정
            // 설정안함: 브라우저가 종료되면 쿠키소멸
            // 설정함: 브라우저가 종료되더라도 쿠키보존(*.txt), 유효기간까지만
            Response.Cookies["ResponseCookie"].Expires = DateTime.Now.AddDays(1);

            // Response를 통한 쿠키확인
            this.lbResponseCookie.Text = Request.Cookies["ResponseCookie"].Value;

            Response.Redirect(Request.Url.PathAndQuery);
        }

        protected void btnResponseCookieDelButton_Click(object sender, EventArgs e)
        {
            // Response를 통한 쿠키 삭제
            Response.Cookies["ResponseCookie"].Expires = DateTime.Now.AddDays(-1);
            this.lbResponseCookie.Text = "";

            Response.Redirect(Request.Url.PathAndQuery);
        }

        private bool ResponseCookieIsCheck()
        {
            // Response를 통한 쿠키 확인
            try
            {
                if (Request.Cookies["ResponseCookie"].Value != "")
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;                
            }            
        }
    }
}