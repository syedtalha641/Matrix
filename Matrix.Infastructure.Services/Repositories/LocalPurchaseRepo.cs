using Matrix.Core.Application.DTOs;
using Matrix.Core.Application.Interfaces;
using Matrix.Core.Domain.Entities;
using Matrix.Infastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Infastructure.Services.Repositories
{
    public class LocalPurchaseRepo : ILocalPurchaseRepo
    {
        private MatrixContext _context;
        public LocalPurchaseRepo(MatrixContext context)
        {
            _context = context;
        }
        public void GenerateLocalPurchase(LocalPurchaseRequest req)
        {
            try
            {
                tblLocalPurchase tblRreq = new tblLocalPurchase
                {
                    InvoiceDate = req.InvoiceDate,
                    PaymentDueDate = req.PaymentDueDate,
                    Remarks = req.Remarks,
                    TransactionDate = req.TransactionDate,
                    SupplierID = req.SupplierID,
                    SupplierInvoiceNo = req.SupplierInvoice,
                    SubTotal = req.LineItems.Sum(s=> (s.Rate * s.QTY)),
                    Others = req.Other,
                    Discount = req.Discount,
                    Total = (((req.LineItems.Sum(s => (s.Rate * s.QTY))) + req.Other) - req.Discount),
                    PurchaseDetails = req.LineItems.Select(s => new tblLocalPurchaseDetails
                    {
                        WareHouseID = s.WareHouseID,
                        Amount = (s.Rate * s.QTY),
                        ModelID = s.ModelID,
                        Rate = s.Rate,
                        QTY = s.QTY
                    }).ToList()
                };
                _context.LocalPurchase.Add(tblRreq);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
