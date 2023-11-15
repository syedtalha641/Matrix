using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matrix.Core.Domain.Entities
{
    public class tblLocalPurchase
    {
        [Key]
        public int RecID { get; set; }
        public string TransactionNo { get { return string.Concat("Inv-", RecID.ToString().PadLeft(8, '0')); } }
        public DateOnly TransactionDate { get; set; }
        public int SupplierID { get; set; }
        public string SupplierInvoiceNo { get; set; }
        public DateOnly InvoiceDate { get; set; }
        public DateOnly PaymentDueDate { get; set; }
        public string? Remarks { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Others { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public virtual List<tblLocalPurchaseDetails> PurchaseDetails { get; set; }

        [ForeignKey("SupplierID")]
        public virtual tblSuppliers SupplierDetails { get; set; }
    }
}
