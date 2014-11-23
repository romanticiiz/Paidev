using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Paidev.Framework.Web.Cookie
{
    /// <summary>
    /// Cookie 관련
    /// </summary>
    public class Information
    {
        private readonly static string cookieDomain = "paidev.com";

        /// <summary>
        /// 쿠키설정
        /// </summary>
        /// <param name="cookieName">쿠키 이름</param>
        /// <param name="cookieValue">쿠키 값</param>
        public static void SetCookie(string cookieName, string cookieValue)
        {
            HttpCookie cookie = new HttpCookie(cookieName, cookieValue);
            cookie.Domain = cookieDomain;
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        /// <summary>
        /// 쿠키값 가져오기
        /// </summary>
        /// <param name="cookieName">쿠키 이름</param>
        /// <returns></returns>
        public static string GetCookie(string cookieName)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[cookieName];
            return (cookie != null && !string.IsNullOrEmpty(cookie.Value)) ? cookie.Value : string.Empty;
        }

        /// <summary>
        /// 쿠키 존재 여부 판단
        /// </summary>
        /// <param name="cookieNamae">쿠키이름</param>
        /// <returns>(true: 있음, false: 없음)</returns>
        public static bool IsCookie(string cookieNamae)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[cookieNamae];
            return (cookie != null && !string.IsNullOrEmpty(cookie.Value)) ? true : false;
        }

        /// <summary>
        /// 쿠키삭제
        /// </summary>
        /// <param name="cookieName"></param>
        public static void Delete(string cookieName)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[cookieName];

            if (null != cookie)
            {
                HttpContext.Current.Response.Cookies.Remove(cookie.Name);

                cookie.Value = string.Empty;
                cookie.Domain = cookieDomain;
                cookie.Expires = new DateTime(1900, 1, 1);

                HttpContext.Current.Response.Cookies.Add(cookie);
            }
        }
    }
}