using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkrunTest.Objects
{
    internal class Transfer
    {
        public string FromWarehouseCode { get; set; }
        public string ToWarehouseCode { get; set; }
        public string DeliveryNote { get; set; }
        public string MilkrunProductCode { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public int Quantity { get; set; }

    }
}
