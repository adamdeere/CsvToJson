using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoJson
{
    [DelimitedRecord(",")]
    public class Record
    {
        public string DispatchAdvice;
        public string Order;
        public string Ref;
        public string OrderType;
        public string Received;
        public string Required;
        public string Consignee;
        public string Ctry;
        public string Lines;
        public string Items;
        public string NoCat;

    }
}
