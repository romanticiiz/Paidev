using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Json;

namespace Paidev.Web.Json
{
    public class JSONParser
    {
        private JsonTextParser parser;
        private JsonObjectCollection col;

        public JSONParser(string strData)
        {
            parser = new JsonTextParser();
            col = (JsonObjectCollection)parser.Parse(strData);
        }

        public string GetStringValue(string name)
        {
            try
            {
                return (string)col[name].GetValue();
            }
            catch
            {
                return null;
            }
        }

        public string[] GetStringArrayValue(string name)
        {
            try
            {
                JsonArrayCollection items = (JsonArrayCollection)col[name];
                string[] item = new string[items.Count];

                for (int count = 0; count < items.Count; count++)
                {
                    item[count] = ((JsonStringValue)items[count]).Value;
                }

                if (item.Length == 0)
                    return null;
                else
                    return item;
            }
            catch
            {
                return null;   
            }
        }

        public void Remove(string name)
        {
            try
            {
                JsonObject obj = col[name];
                col.Remove(obj);
            }
            catch
            {                
            }
        }
    }
}