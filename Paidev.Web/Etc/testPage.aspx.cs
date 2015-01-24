using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO;
using System.Net.Json;

namespace Paidev.Web.Etc
{
    public partial class testPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VerifyByApple(214, "497", "ewogICAgcG9kID0gNTA7CiAgICAicHVyY2hhc2UtaW5mbyIgPSAiZXdvSkltSjJjbk1pSUQwZ0lqSXVPUzR6SWpzS0NTSmhjSEF0YVhSbGJTMXBaQ0lnUFNBaU1DSTdDZ2tpWW1sa0lpQTlJQ0pqYjIwdVNHRnVZbWwwYzI5bWRDNURiMjV4ZFdWemRDSTdDZ2tpY0hWeVkyaGhjMlV0WkdGMFpTSWdQU0FpTWpBeE5TMHdNUzB4TWlBeE16b3pOem8xTkNCRmRHTXZSMDFVSWpzS0NTSnhkV0Z1ZEdsMGVTSWdQU0FpTVNJN0Nna2lkbVZ5YzJsdmJpMWxlSFJsY201aGJDMXBaR1Z1ZEdsbWFXVnlJaUE5SUNJd0lqc0tDU0p3ZFhKamFHRnpaUzFrWVhSbExYQnpkQ0lnUFNBaU1qQXhOUzB3TVMweE1pQXdOam96TnpvMU5DQkJiV1Z5YVdOaEwweHZjMTlCYm1kbGJHVnpJanNLQ1NKd2RYSmphR0Z6WlMxa1lYUmxMVzF6SWlBOUlDSXhOREl4TURZNU9EYzBNVEk1SWpzS0NTSjFibWx4ZFdVdGRtVnVaRzl5TFdsa1pXNTBhV1pwWlhJaUlEMGdJakEzTUVZek1FTTBMVEU1UVRRdE5EZzVOeTFDUWtZeExVRTFRemxHTlRORU56UTNOU0k3Q2draWFYUmxiUzFwWkNJZ1BTQWlOalUzTVRZeU9ESXdJanNLQ1NKdmNtbG5hVzVoYkMxd2RYSmphR0Z6WlMxa1lYUmxMVzF6SWlBOUlDSXhOREl4TURZNU9EYzBNVEk1SWpzS0NTSnZjbWxuYVc1aGJDMTBjbUZ1YzJGamRHbHZiaTFwWkNJZ1BTQWlORGszTVRReU1UQTJPVGczTkRFeE1pSTdDZ2tpZFc1cGNYVmxMV2xrWlc1MGFXWnBaWElpSUQwZ0lqRXlObVV4WWpReE0yUXdOelV5WmpRME9HSmhZakkyT0RVMk4yWTVOREV3Wm1GbFkyWTFObVFpT3dvSkltOXlhV2RwYm1Gc0xYQjFjbU5vWVhObExXUmhkR1VpSUQwZ0lqSXdNVFV0TURFdE1USWdNVE02TXpjNk5UUWdSWFJqTDBkTlZDSTdDZ2tpY0hKdlpIVmpkQzFwWkNJZ1BTQWlORGszSWpzS0NTSjBjbUZ1YzJGamRHbHZiaTFwWkNJZ1BTQWlORGszTVRReU1UQTJPVGczTkRFeE1pSTdDZ2tpYjNKcFoybHVZV3d0Y0hWeVkyaGhjMlV0WkdGMFpTMXdjM1FpSUQwZ0lqSXdNVFV0TURFdE1USWdNRFk2TXpjNk5UUWdRVzFsY21sallTOU1iM05mUVc1blpXeGxjeUk3Q24wPSI7CiAgICBzaWduYXR1cmUgPSAiQXBkeEpkdE53UFUyckE1L2NuM2tJTzFPVGsyNWZlREthMGFhZ3l5UnZlV2xjRmxnbHY2UkY2em5raUJTM3VtOVVjN3BWb2IrUHFaUjJUOHd5VnJITnBsb2YzRFgzSXFET2xXcSs5MGE3WWwrcXJSN0E3ald3dml3NzA4UFMrNjdQeUhSbmhPL0c3YlZxZ1JwRXI2RXVGeWJpVTFGWEFpWEpjNmxzMVlBc3NReEFBQURWekNDQTFNd2dnSTdvQU1DQVFJQ0NHVVVrVTNaV0FTMU1BMEdDU3FHU0liM0RRRUJCUVVBTUg4eEN6QUpCZ05WQkFZVEFsVlRNUk13RVFZRFZRUUtEQXBCY0hCc1pTQkpibU11TVNZd0pBWURWUVFMREIxQmNIQnNaU0JEWlhKMGFXWnBZMkYwYVc5dUlFRjFkR2h2Y21sMGVURXpNREVHQTFVRUF3d3FRWEJ3YkdVZ2FWUjFibVZ6SUZOMGIzSmxJRU5sY25ScFptbGpZWFJwYjI0Z1FYVjBhRzl5YVhSNU1CNFhEVEE1TURZeE5USXlNRFUxTmxvWERURTBNRFl4TkRJeU1EVTFObG93WkRFak1DRUdBMVVFQXd3YVVIVnlZMmhoYzJWU1pXTmxhWEIwUTJWeWRHbG1hV05oZEdVeEd6QVpCZ05WQkFzTUVrRndjR3hsSUdsVWRXNWxjeUJUZEc5eVpURVRNQkVHQTFVRUNnd0tRWEJ3YkdVZ1NXNWpMakVMTUFrR0ExVUVCaE1DVlZNd2daOHdEUVlKS29aSWh2Y05BUUVCQlFBRGdZMEFNSUdKQW9HQkFNclJqRjJjdDRJclNkaVRDaGFJMGc4cHd2L2NtSHM4cC9Sd1YvcnQvOTFYS1ZoTmw0WElCaW1LalFRTmZnSHNEczZ5anUrK0RyS0pFN3VLc3BoTWRkS1lmRkU1ckdYc0FkQkVqQndSSXhleFRldngzSExFRkdBdDFtb0t4NTA5ZGh4dGlJZERnSnYyWWFWczQ5QjB1SnZOZHk2U01xTk5MSHNETHpEUzlvWkhBZ01CQUFHamNqQndNQXdHQTFVZEV3RUIvd1FDTUFBd0h3WURWUjBqQkJnd0ZvQVVOaDNvNHAyQzBnRVl0VEpyRHRkREM1RllRem93RGdZRFZSMFBBUUgvQkFRREFnZUFNQjBHQTFVZERnUVdCQlNwZzRQeUdVakZQaEpYQ0JUTXphTittVjhrOVRBUUJnb3Foa2lHOTJOa0JnVUJCQUlGQURBTkJna3Foa2lHOXcwQkFRVUZBQU9DQVFFQUVhU2JQanRtTjRDL0lCM1FFcEszMlJ4YWNDRFhkVlhBZVZSZVM1RmFaeGMrdDg4cFFQOTNCaUF4dmRXLzNlVFNNR1k1RmJlQVlMM2V0cVA1Z204d3JGb2pYMGlreVZSU3RRKy9BUTBLRWp0cUIwN2tMczlRVWU4Y3pSOFVHZmRNMUV1bVYvVWd2RGQ0TndOWXhMUU1nNFdUUWZna1FRVnk4R1had1ZIZ2JFL1VDNlk3MDUzcEdYQms1MU5QTTN3b3hoZDNnU1JMdlhqK2xvSHNTdGNURXFlOXBCRHBtRzUrc2s0dHcrR0szR01lRU41LytlMVFUOW5wL0tsMW5qK2FCdzdDMHhzeTBiRm5hQWQxY1NTNnhkb3J5L0NVdk02Z3RLc21uT09kcVRlc2JwMGJzOHNuNldxczBDOWRnY3hSSHVPTVoydG04bnBMVW03YXJnT1N6UT09IjsKICAgICJzaWduaW5nLXN0YXR1cyIgPSAwOwp9");
        }

        public static int VerifyByApple(int gamekey, string itemno, string receiptnum)
        {
            int revalue = 0;

            //string url = "https://sandbox.itunes.apple.com/verifyReceipt";
            string url = "https://buy.itunes.apple.com/verifyReceipt";
            string postString = String.Format("{{ \"receipt-data\" : \"{0}\" }}", receiptnum);
            string resultData = string.Empty;

            //HanbitSoft.Mobile.API.Utility.AppLog.WriteLog(gamekey,
            //  string.Format("{0}\r\nVerifyByApple Start :{1}", DateTime.Now.ToString(), postString),
            //  "Charge", Utility.AppLog.LogType.Bill
            //  );

            try
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] data = encoding.GetBytes(postString);

                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

                myRequest.Method = "POST";
                myRequest.KeepAlive = false;
                myRequest.ProtocolVersion = HttpVersion.Version11;
                myRequest.ContentType = "application/json"; //"text/xml"; //"text/html;charset=utf-8";// "application/x-www-form-urlencoded"; 
                myRequest.ContentLength = data.Length;

                Stream newStream = myRequest.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Flush();
                newStream.Close();

                HttpWebResponse response = (HttpWebResponse)myRequest.GetResponse();

                StringBuilder sb = new StringBuilder();
                byte[] buf = new byte[8192];
                Stream resStream = response.GetResponseStream();
                string tempString = null;
                int count = 0;

                do
                {
                    count = resStream.Read(buf, 0, buf.Length);
                    if (count != 0)
                    {
                        tempString = Encoding.ASCII.GetString(buf, 0, count);
                        sb.Append(tempString);
                    }
                } while (count > 0);

                resultData = sb.ToString();

                JsonTextParser parser = new JsonTextParser();
                JsonObjectCollection root = (JsonObjectCollection)parser.Parse(resultData);
                JsonObject status = root["status"];
                JsonObjectCollection receipt = (JsonObjectCollection)root["receipt"];

                if (status.GetValue().ToString().Trim().Equals("0"))
                {
                    if (!receipt["product_id"].GetValue().ToString().Trim().Equals(itemno))
                    {
                        revalue = 1; //영수증 확인은 되었으나 DB 상품번호가 틀린 경우
                    }
                }
                else
                {
                    revalue = 2; //영수증 확인 오류
                }

                //HanbitSoft.Mobile.API.Utility.AppLog.WriteLog(
                //gamekey,
                //string.Format("{0}\r\nVerifyByApple :{1} {2} {3} {4} {5} \r\n{6}", DateTime.Now.ToString(), revalue, status.GetValue().ToString(), receipt["product_id"].GetValue().ToString(), receipt["purchase_date"].GetValue(), receipt["transaction_id"].GetValue().ToString(), receiptnum),
                //"Charge", Utility.AppLog.LogType.Bill
                //);
            }
            catch (Exception ex)
            {
                string txt = ex.Message;
            }

            return revalue;
        }
    }
}