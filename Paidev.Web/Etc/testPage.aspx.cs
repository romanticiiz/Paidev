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
            VerifyByApple(205, "397", "ewoJInNpZ25hdHVyZSIgPSAiQW1ScGt0RmFkVzlCN0g3ejJvUmpwREYvVzdKMzdxbm1lc2V0TjQ1dDlGRDhNNGxyaGJ5M0hmS2FQNUxtSWdwZGhhWVI4QmFVbG1KejMvRDFGMTU5dVRXeWhXaGROK0lFb3M4bnlMTzgxaWErcnVuNmtJc0cvYUhhdFBaa1R5QndnVEh2RU1PU09JR2I1d29BekdJTzBUbng5bVhsUGRPZzhTLzZNNTNYQ1RmZ0FBQURWekNDQTFNd2dnSTdvQU1DQVFJQ0NCdXA0K1BBaG0vTE1BMEdDU3FHU0liM0RRRUJCUVVBTUg4eEN6QUpCZ05WQkFZVEFsVlRNUk13RVFZRFZRUUtEQXBCY0hCc1pTQkpibU11TVNZd0pBWURWUVFMREIxQmNIQnNaU0JEWlhKMGFXWnBZMkYwYVc5dUlFRjFkR2h2Y21sMGVURXpNREVHQTFVRUF3d3FRWEJ3YkdVZ2FWUjFibVZ6SUZOMGIzSmxJRU5sY25ScFptbGpZWFJwYjI0Z1FYVjBhRzl5YVhSNU1CNFhEVEUwTURZd056QXdNREl5TVZvWERURTJNRFV4T0RFNE16RXpNRm93WkRFak1DRUdBMVVFQXd3YVVIVnlZMmhoYzJWU1pXTmxhWEIwUTJWeWRHbG1hV05oZEdVeEd6QVpCZ05WQkFzTUVrRndjR3hsSUdsVWRXNWxjeUJUZEc5eVpURVRNQkVHQTFVRUNnd0tRWEJ3YkdVZ1NXNWpMakVMTUFrR0ExVUVCaE1DVlZNd2daOHdEUVlKS29aSWh2Y05BUUVCQlFBRGdZMEFNSUdKQW9HQkFNbVRFdUxnamltTHdSSnh5MW9FZjBlc1VORFZFSWU2d0Rzbm5hbDE0aE5CdDF2MTk1WDZuOTNZTzdnaTNvclBTdXg5RDU1NFNrTXArU2F5Zzg0bFRjMzYyVXRtWUxwV25iMzRucXlHeDlLQlZUeTVPR1Y0bGpFMU93QytvVG5STStRTFJDbWVOeE1iUFpoUzQ3VCtlWnRERWhWQjl1c2szK0pNMkNvZ2Z3bzdBZ01CQUFHamNqQndNQjBHQTFVZERnUVdCQlNKYUVlTnVxOURmNlpmTjY4RmUrSTJ1MjJzc0RBTUJnTlZIUk1CQWY4RUFqQUFNQjhHQTFVZEl3UVlNQmFBRkRZZDZPS2RndElCR0xVeWF3N1hRd3VSV0VNNk1BNEdBMVVkRHdFQi93UUVBd0lIZ0RBUUJnb3Foa2lHOTJOa0JnVUJCQUlGQURBTkJna3Foa2lHOXcwQkFRVUZBQU9DQVFFQWVhSlYyVTUxcnhmY3FBQWU1QzIvZkVXOEtVbDRpTzRsTXV0YTdONlh6UDFwWkl6MU5ra0N0SUl3ZXlOajVVUllISytIalJLU1U5UkxndU5sMG5rZnhxT2JpTWNrd1J1ZEtTcTY5Tkluclp5Q0Q2NlI0Szc3bmI5bE1UQUJTU1lsc0t0OG9OdGxoZ1IvMWtqU1NSUWNIa3RzRGNTaVFHS01ka1NscDRBeVhmN3ZuSFBCZTR5Q3dZVjJQcFNOMDRrYm9pSjNwQmx4c0d3Vi9abEwyNk0ydWVZSEtZQ3VYaGRxRnd4VmdtNTJoM29lSk9PdC92WTRFY1FxN2VxSG02bTAzWjliN1BSellNMktHWEhEbU9Nazd2RHBlTVZsTERQU0dZejErVTNzRHhKemViU3BiYUptVDdpbXpVS2ZnZ0VZN3h4ZjRjemZIMHlqNXdOelNHVE92UT09IjsKCSJwdXJjaGFzZS1pbmZvIiA9ICJld29KSW05eWFXZHBibUZzTFhCMWNtTm9ZWE5sTFdSaGRHVXRjSE4wSWlBOUlDSXlNREUwTFRBNUxUSXpJREUwT2pJeU9qVXdJRUZ0WlhKcFkyRXZURzl6WDBGdVoyVnNaWE1pT3dvSkluVnVhWEYxWlMxcFpHVnVkR2xtYVdWeUlpQTlJQ0kxWVdRd01qVXlPVFl5TWprd1pEQmlZbVV4TWpGbE0ySmlZVEF6T0RjMlpHSXdNREU0TmpSbUlqc0tDU0p2Y21sbmFXNWhiQzEwY21GdWMyRmpkR2x2YmkxcFpDSWdQU0FpTVRBd01EQXdNREV5TkRnNE56STRNaUk3Q2draVluWnljeUlnUFNBaU5EWWlPd29KSW5SeVlXNXpZV04wYVc5dUxXbGtJaUE5SUNJeE1EQXdNREF3TVRJME9EZzNNamd5SWpzS0NTSnhkV0Z1ZEdsMGVTSWdQU0FpTVNJN0Nna2liM0pwWjJsdVlXd3RjSFZ5WTJoaGMyVXRaR0YwWlMxdGN5SWdQU0FpTVRReE1UVXdOek0zTURJd05DSTdDZ2tpZFc1cGNYVmxMWFpsYm1SdmNpMXBaR1Z1ZEdsbWFXVnlJaUE5SUNKRVEwSkNORUUyT0MwM05ERkRMVFEzUWpVdFFqSkVNQzB4TWtRMk16TkZRemxFTmpBaU93b0pJbkJ5YjJSMVkzUXRhV1FpSUQwZ0lqUXdNaUk3Q2draWFYUmxiUzFwWkNJZ1BTQWlPRFU0TWpreU9UVXlJanNLQ1NKMlpYSnphVzl1TFdWNGRHVnlibUZzTFdsa1pXNTBhV1pwWlhJaUlEMGdJalk1TmpreE1qWTVOQ0k3Q2draVltbGtJaUE5SUNKamIyMHVhR0p2TG1aamJXMGlPd29KSW5CMWNtTm9ZWE5sTFdSaGRHVXRiWE1pSUQwZ0lqRTBNVEUxTURjek56QXlNRFFpT3dvSkluQjFjbU5vWVhObExXUmhkR1VpSUQwZ0lqSXdNVFF0TURrdE1qTWdNakU2TWpJNk5UQWdSWFJqTDBkTlZDSTdDZ2tpY0hWeVkyaGhjMlV0WkdGMFpTMXdjM1FpSUQwZ0lqSXdNVFF0TURrdE1qTWdNVFE2TWpJNk5UQWdRVzFsY21sallTOU1iM05mUVc1blpXeGxjeUk3Q2draWIzSnBaMmx1WVd3dGNIVnlZMmhoYzJVdFpHRjBaU0lnUFNBaU1qQXhOQzB3T1MweU15QXlNVG95TWpvMU1DQkZkR012UjAxVUlqc0tmUT09IjsKCSJlbnZpcm9ubWVudCIgPSAiU2FuZGJveCI7CgkicG9kIiA9ICIxMDAiOwoJInNpZ25pbmctc3RhdHVzIiA9ICIwIjsKfQ==");
        }

        public static int VerifyByApple(int gamekey, string itemno, string receiptnum)
        {
            int revalue = 0;

            string url = "https://sandbox.itunes.apple.com/verifyReceipt";
            //string url = "https://buy.itunes.apple.com/verifyReceipt";
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