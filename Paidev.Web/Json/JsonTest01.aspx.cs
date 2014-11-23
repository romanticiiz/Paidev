using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Json;

namespace Paidev.Web.Json
{
    public partial class JsonTest01 : System.Web.UI.Page
    {
        protected int intArrLength;
        protected string stringArrText = string.Empty;
        protected string stringName = string.Empty;

        protected string objAge = string.Empty;
        protected string objSex = string.Empty;
        protected string objCity = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            #region: 직접 데이터를 생성할때.
            //// Json데이터를 생성할때.
            //JsonObjectCollection res = new JsonObjectCollection();
            //res.Add(new JsonStringValue("name", "LeeSangHyun"));

            //// telllist 배열 생성
            //JsonArrayCollection items = new JsonArrayCollection("tellist");
            //items.Add(new JsonStringValue(null, "1234"));
            //items.Add(new JsonStringValue(null, "4321"));
            //items.Add(new JsonStringValue(null, "1111"));
            //res.Add(items);

            //// 부가정보 objectCollection 생성
            //JsonObjectCollection moreinfo = new JsonObjectCollection();
            //moreinfo.Add(new JsonStringValue("age", "10"));
            //moreinfo.Add(new JsonStringValue("sex", "woman"));
            //moreinfo.Add(new JsonStringValue("city", "busan"));

            //// res Collection 에추가
            //JsonObjectCollection ressub = new JsonObjectCollection("moreinfo", moreinfo);
            //res.Add(ressub);
            #endregion

            #region: 파일로 파싱할때.
            // 파일로 파싱
            string jsonPath = Page.Server.MapPath("json.json");
            string res = System.IO.File.ReadAllText(jsonPath);
            #endregion

            JSONParser myParser = new JSONParser(res.ToString());

            // 배열
            string[] telarray = myParser.GetStringArrayValue("tellist");
            intArrLength = telarray.Length;
            stringArrText = telarray[0];

            // 일반 문자열
            stringName = myParser.GetStringValue("name");

            // json파일의 moreinfo객체는 root가 아니기때문에 sub객체로 구성되어 별도 처리가 필요
            string value, name;
            JsonTextParser parser = new JsonTextParser();
            JsonObject obj = parser.Parse(res.ToString());

            foreach (JsonObject field in obj as JsonObjectCollection)
            {
                name = field.Name;
                value = string.Empty;

                // root의 name를 가지고있다면 안쪽 값을 Object로 변환
                if (name == "moreinfo")
                {
                    // value 값을 다시 JsonObject로 변환
                    JsonObject objSub = (JsonObject)(field);

                    // moreinfo 객체의 값들을 가지고옴
                    foreach (JsonObject fieldSub in objSub as JsonObjectCollection)
                    {
                        name = fieldSub.Name;
                        value = (string)fieldSub.GetValue();

                        if (name == "age")
                            objAge = value;
                        else if (name == "sex")
                            objSex = value;
                        else if (name == "city")
                            objCity = value;
                    }
                }
            }
        }
    }
}