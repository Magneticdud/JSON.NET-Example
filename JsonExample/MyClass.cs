using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample
{
    class MyClass
    {
        //generate at http://json2csharp.com/
        public class High
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class Low
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class Avg
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class Vwap
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class Vol
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class LastLocal
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class LastOrig
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class LastAll
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class Last
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class Buy
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class Sell
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class Return
        {
            public High high { get; set; }
            public Low low { get; set; }
            public Avg avg { get; set; }
            public Vwap vwap { get; set; }
            public Vol vol { get; set; }
            public LastLocal last_local { get; set; }
            public LastOrig last_orig { get; set; }
            public LastAll last_all { get; set; }
            public Last last { get; set; }
            public Buy buy { get; set; }
            public Sell sell { get; set; }
            public string item { get; set; }
            public string now { get; set; }
        }

        public class RootObject
        {
            public string result { get; set; }
            public Return @return { get; set; }
        }
    }
}
