using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkrunTest.Objects
{
    

    internal class New_CustomerPoint
    {
        public int RowNum { get; set; }
        public string VALUE { get; set; }
        public string ID { get; set; }
        public string IDCSS { get; set; }
        public string CustomerId { get; set; }
        public string CustomerIdName { get; set; }
        public string CustomerIdNameCss { get; set; }
        
        public string CustomerPointName { get; set; }
        public int CustomerPointType { get; set; }
        public string CustomerPointTypeName { get; set; }
        public bool IsMainWareHouse { get; set; }
        public string CityId { get; set; }
        public string CityIdName { get; set; }
        public string CityIdNameCss { get; set; }
        public string DistrictId { get; set; }
        public string DistrictIdName { get; set; }
        public string DistrictIdNameCss { get; set; }
        public string Address { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ErpCode { get; set; }

        public override string ToString()
        {
            return  CustomerIdName +"  "+CustomerPointName+ "("+ ErpCode+")";
        }
    }

    internal class New_CustomerPointView
    {
        public string elapsedtime { get; set; }
        public List<New_CustomerPoint> Records { get; set; }
        public object sumList { get; set; }
        public int totalCount { get; set; }
    }
}
