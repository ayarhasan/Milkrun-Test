using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkrunTest.Objects
{
    internal class TransferAcceptByDeliveryNote
    {
        public string WarehouseCode { get; set; }
        public string DeliveryNote { get; set; }
        public DateTime TransactionDateTime { get; set; }
    }
}
