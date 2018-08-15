using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace json_parse_samples
{
    internal class ParseExample1
    {
        public ParseExample1()
        {
        }


        public float ParseTemperature(string example1)
        {
            var example1Model = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(example1);
            dynamic s = JsonConvert.DeserializeObject(example1);
            return s["main"]["temp"];
        }
    }
}