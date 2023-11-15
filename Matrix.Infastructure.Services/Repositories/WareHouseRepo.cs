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
    public class WareHouseRepo : IWareHouseRepo
    {
        private MatrixContext _context;
        public WareHouseRepo(MatrixContext context)
        {
            _context = context;
        }

        public void AddWareHouse(WareHouseDTO req)
        {
            try
            {
                var isExist = _context.WareHouses.Where(x=>x.WareHouseName == req.WareHouseName).FirstOrDefault();
                if (isExist != null)
                    throw new Exception("Warehouse with the same name already exist");

                tblWareHouse tblReq = new tblWareHouse
                {
                  WareHouseName = req.WareHouseName
                };
                _context.WareHouses.Add(tblReq);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<GetWareHouse>> GetWareHouse()
        {
            return await _context.WareHouses
                .Select(s => new GetWareHouse
                { WareHouseID = s.WareHouseID, WareHouseName = s.WareHouseName }
                ).ToListAsync();
        }
    }
}
