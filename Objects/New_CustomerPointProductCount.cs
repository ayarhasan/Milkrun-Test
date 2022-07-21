using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkrunTest.Objects
{
    internal class New_CustomerPointProductCount
    {
        public string VALUE { get; set; }
        public string ID { get; set; }
        public string IDCSS { get; set; }
        public string ModifiedOn { get; set; }
        public DateTime ModifiedOnUtcTime { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedByName { get; set; }
        public string ModifiedByNameCss { get; set; }
        public string ProductId { get; set; }
        public string ProductIdName { get; set; }
        public string ProductIdNameCss { get; set; }
        public int Quantity { get; set; }
        public string CustomerPointId { get; set; }
        public string CustomerPointIdName { get; set; }
        public string CustomerPointIdNameCss { get; set; }
        public string dp_CustomerId { get; set; }
        public string dp_CustomerIdName { get; set; }
        public string dp_CustomerIdNameCss { get; set; }
        public string dp_ErpCode { get; set; }
        public override string ToString()
        {
            
            return ProductIdName+"  ("+ Quantity +")";
        }
    }
    internal class New_CustomerPointProductCountView
    {
        public string elapsedtime { get; set; }
        public List<New_CustomerPointProductCount> Records { get; set; }
        public object sumList { get; set; }
        public int totalCount { get; set; }
    }
}
