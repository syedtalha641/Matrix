using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public class LocalPurchaseRequest
    {
        public DateOnly TransactionDate { get; set; }
        public int SupplierID { get; set; }
        public string SupplierInvoice { get; set; }
        public DateOnly InvoiceDate { get; set; }
        public DateOnly PaymentDueDate { get; set; }
        public decimal Other { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public string? Remarks { get; set; } = string.Empty;
        public List<LineItemDTO> LineItems { get; set; }
    }
    public class LineItemDTO
    {
        public int ModelID { get; set; }
        public int QTY { get; set; }
        public decimal Rate { get; set; }
        public int WareHouseID { get; set; }
    }
}
