using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkrunTest.Objects
{
    internal class New_BoxTransaction
    {
        public int RowNum { get; set; }
        public string VALUE { get; set; }
        public string ID { get; set; }
        public string IDCSS { get; set; }
        public string CreatedOn { get; set; }
        public DateTime CreatedOnUtcTime { get; set; }
        public string CustomerId { get; set; }
        public string CustomerIdName { get; set; }
        public string CustomerIdNameCss { get; set; }
        public string TransactionTypeId { get; set; }
        public string TransactionTypeIdName { get; set; }
        public string TransactionTypeIdNameCss { get; set; }
        public string FromWarehouseCode { get; set; }
        public string FromWarehouseId { get; set; }
        public string FromWarehouseIdName { get; set; }
        public string FromWarehouseIdNameCss { get; set; }
        public string ToWarehouseCode { get; set; }
        public string ToWarehouseId { get; set; }
        public string ToWarehouseIdName { get; set; }
        public string ToWarehouseIdNameCss { get; set; }
        public string DeliveryNote { get; set; }
        public string ProductId { get; set; }
        public string ProductIdName { get; set; }
        public string ProductIdNameCss { get; set; }
        public string ProductSerialNumber { get; set; }
        public string ProductSeriesId { get; set; }
        public string ProductSeriesIdName { get; set; }
        public string ProductSeriesIdNameCss { get; set; }
        public string TransactionDateTime { get; set; }
        public DateTime TransactionDateTimeUtcTime { get; set; }
        public int Quantity { get; set; }
        public string IsRingCreated { get; set; }
        public string RingId { get; set; }
        public string RingIdName { get; set; }
        public string RingIdNameCss { get; set; }
        public string IsTransferCompleted { get; set; }
        public string IsStockOperatied { get; set; }
        public string IslogisticDeliveryNoteCreated { get; set; }
        public string logisticDeliveryNoteId { get; set; }
        public string logisticDeliveryNoteIdName { get; set; }
        public string logisticDeliveryNoteIdNameCss { get; set; }
        public string StockTransactionId { get; set; }
        public string StockTransactionIdName { get; set; }
        public string StockTransactionIdNameCss { get; set; }
        public override string ToString()
        {
            return DeliveryNote + "  - " + FromWarehouseIdName + " --> " + ToWarehouseIdName;
        }
    }
    internal class New_BoxTransactionView
    {
        public string elapsedtime { get; set; }
        public List<New_BoxTransaction> Records { get; set; }
        public object sumList { get; set; }
        public int totalCount { get; set; }
    }
}
