using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public class WareHouseDTO
    {
        public string WareHouseName { get; set; }
    }
    public class GetWareHouse
    {
        public int WareHouseID { get; set; }
        public string WareHouseName { get; set; }
    }
}
