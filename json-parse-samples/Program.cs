using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace json_parse_samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var example1 = @"{""coord"":{""lon"":-71.06,""lat"":42.36},""weather"":[{""id"":741,""main"":""Fog"",""description"":""fog"",""icon"":""50n""},{""id"":701,""main"":""Mist"",""description"":""mist"",""icon"":""50n""},{""id"":501,""main"":""Rain"",""description"":""moderate rain"",""icon"":""10n""}],""base"":""stations"",""main"":{""temp"":293.61,""pressure"":1017,""humidity"":94,""temp_min"":292.15,""temp_max"":295.15},""visibility"":402,""wind"":{""speed"":4.6,""deg"":80},""clouds"":{""all"":90},""dt"":1534049760,""sys"":{""type"":1,""id"":1274,""message"":0.0065,""country"":""US"",""sunrise"":1534067308,""sunset"":1534117754},""id"":4930956,""name"":""Boston"",""cod"":200}";


            //Parse the above string/text and pick out the temperature.
            ParseExample1 pe1 = new ParseExample1();
            float t1 = pe1.ParseTemperature(example1);
            Console.WriteLine("Temperature 1 is " + t1);

            //Another way to do the same without the "dynamic" cast
            ParseExample2 pe2 = new ParseExample2();
            float t2 = pe2.ParseTemperature(example1);
            Console.WriteLine("Temperature 2 is " + t2);

            Thread.Sleep(5000);
        }
    }
}
