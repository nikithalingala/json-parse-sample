using System;
using System.Web.Script.Serialization;

namespace json_parse_samples
{
    internal class ParseExample2
    {
        public ParseExample2()
        {
        }

        class Example1Model
        {
            public MainModel main { get; set; }
        }

        class MainModel
        {
            public float temp { get; set; }

        }

        internal float ParseTemperature(string example1)
        {
            Example1Model s = new JavaScriptSerializer().Deserialize<Example1Model>(example1);
            return s.main.temp;
        }
    }
}