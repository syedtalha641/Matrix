using Matrix.Core.Application.DTOs;
using Matrix.Core.Application.Interfaces;
using Matrix.Core.Domain.Entities;
using Matrix.Infastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Infastructure.Services.Repositories
{
    public class SupplierRepo : ISupplierRepo
    {
        private MatrixContext _context;
        public SupplierRepo(MatrixContext context)
        {
            _context = context;
        }
        public void AddSupplier(SupplierDTO req)
        {
            try
            {
                tblSuppliers tblReq = new tblSuppliers
                {
                    SupplierName = req.SupplierName
                };
                _context.Suppliers.Add(tblReq);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<GetSuppliers>> GetSupplier()
        {
            return await _context.Suppliers
                .Select(s => new GetSuppliers
                { SupplierID = s.SupplierID, SupplierName = s.SupplierName }
                ).ToListAsync();
        }


    }
}
