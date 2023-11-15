using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Domain.Entities
{
    public class tblModels
    {
        [Key]
        public int ModelID { get; set; }
        public int ModelName { get; set; }
        public virtual List<tblLocalPurchaseDetails> PurchaseDetails { get; set; }
        public virtual List<tblWareHouseInHoldProducts> WareHouseInHoldProducts { get; set; }
    }
}
