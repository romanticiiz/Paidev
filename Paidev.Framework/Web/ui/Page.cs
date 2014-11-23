using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace Paidev.Framework.Web.UI
{
    public class Page : System.Web.UI.Page
    {
        #region: 다국어 관련 메소드
        /// <summary>
        /// Resource 사용
        /// </summary>
        /// <param name="resourceName">리소스 파일명</param>
        /// <param name="name">리소스 키값</param>
        /// <returns></returns>
        public string Message(string resourceName, string key)
        {
            string rtnStr = string.Empty;

            try
            {
                // 언어별 리소스파일에서 키값에 해당하는 Value값을 가져와서 Return
                // GetGlobalResourceObject메소드는 System.Web.UI.Page 상속받아야 사용 가능
                rtnStr = GetGlobalResourceObject(resourceName, key).ToString();
            }
            catch (Exception)
            {
                // 리소스파일에 해당 키 값이 없을 경우 'ResourceError' Return
                rtnStr = "ResourceError";
            }

            return rtnStr;
        }

        /// <summary>
        /// 언어에 대한 쿠키 가져오기
        /// </summary>
        /// <returns>언어코드</returns>
        public string GetLngCookie()
        {
            // 기본언어 en-US
            string lngCookie = "en-US";

            // 언어쿠키 가져오기
            string cookieValue = Paidev.Framework.Web.Cookie.Information.GetCookie("lngCookie");

            if (cookieValue != "")
            {
                lngCookie = cookieValue;
            }

            return lngCookie;
        }

        /// <summary>
        /// 언어에 따른 문화권 설정(언어는 쿠키에 저장해서 가져오는 방식)
        /// </summary>
        protected override void InitializeCulture()
        {
            string lngCode = GetLngCookie();

            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lngCode);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(lngCode);

            base.InitializeCulture();
        }
        #endregion
    }
}